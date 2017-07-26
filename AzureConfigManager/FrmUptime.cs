using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace AzureConfigManager
{
    public partial class FrmUptime : Form
    {
        private readonly List<Service> _services;

        public FrmUptime(List<Tuple<string, string>> services)
        {
            _services = services.Select(MapTupleToService).ToList();
            InitializeComponent();
        }

        private void FrmUptime_Load(object sender, EventArgs e)
        {
            backWorker.RunWorkerAsync(_services);
        }

        private static Service MapTupleToService(Tuple<string, string> arg)
        {
            return new Service
            {
                Name = arg.Item1,
                SharedSecret = arg.Item2,
                Complete = false,
                Result = "Not Tested"
            };
        }

        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var services = e.Argument as List<Service>;
            var worker = sender as BackgroundWorker;

            worker.ReportProgress(0, services);

            foreach (var service in services)
            {
                TestService(service);
                worker.ReportProgress(0, services);
            }
        }

        private void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var status = e.UserState as List<Service>;

            lstResults.Items.Clear();

            foreach (var svc in status)
            {
                lstResults.Items.Add(svc.Name + " " + (svc.Complete ? svc.Result : "......"));
            }
        }

        private void TestService(Service service)
        {
            TestServiceEndpoint(service, service.StatusEndpoint);
            if (service.Result == "NotFound")
            {
                TestServiceEndpoint(service, service.BaseEndpoint);
                service.Result = $"Status {service.Result}";
            }
            else
            {
                service.Result = $"Base {service.Result}";
            }
        }

        private void TestServiceEndpoint(Service service, string endpoint)
        {
            var client = new RestClient(endpoint);
            var request = new RestRequest("", Method.GET);
            request.AddHeader("Accept", "*/*");
            if (service.SharedSecret != null)
            {
                request.AddHeader("Authorization", service.AuthHeader);
            }
            client.Timeout = 5000;
            var result = client.Execute(request);
            if (result.ResponseStatus == ResponseStatus.TimedOut)
            {
                service.Result = "TIMEOUT";
            }
            else if (result.StatusCode == HttpStatusCode.OK || result.StatusCode == HttpStatusCode.Forbidden)
            {
                service.Result = $"ok";
            }
            else if (result.StatusCode == HttpStatusCode.NotFound)
            {
                service.Result = "NotFound";
            }
            else
            {
                service.Result = $"ERROR {result.StatusCode}";
            }
            service.Complete = true;
        }

        internal class Service
        {
            public string Name { get; set; }
            public string SharedSecret { get; set; }
            public bool Complete { get; set; }
            public string Result { get; set; }

            public string BaseEndpoint => $"https://{Name}.azurewebsites.net";
            public string StatusEndpoint => $"{BaseEndpoint}/status";
            public string AuthHeader => SharedSecret == null ? null : $"Basic {EncodedSharedSecret()}";

            private string EncodedSharedSecret()
            {
                var plainTextBytes = Encoding.UTF8.GetBytes(SharedSecret);
                return Convert.ToBase64String(plainTextBytes);
            }
        }
    }
}