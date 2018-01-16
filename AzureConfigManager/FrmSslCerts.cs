using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace AzureConfigManager
{
    public partial class FrmSslCerts : Form
    {
        public FrmSslCerts()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var domains = txtDomains.Text.Split(new [] { Environment.NewLine }, StringSplitOptions.None);

            var domainsWithFingerprints = domains.ToDictionary(d => d, d => "");

            foreach (var domain in domainsWithFingerprints.Keys.ToList())
            {
                domainsWithFingerprints[domain] = GetSslExpiryDate(domain);
                txtDomains.Text = string.Join(Environment.NewLine, domainsWithFingerprints.Select(d => $"{d.Key} {d.Value}"));
                Refresh();
            }
        }

        private static string GetSslExpiryDate(string domain)
        {
            var request = (HttpWebRequest)WebRequest.Create($"https://{domain}");
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                {
                    return "COULDN'T RESOLVE";
                }
                response = (HttpWebResponse) ex.Response;
            }
            
            response.Close();

            var cert = request.ServicePoint.Certificate;
            if (cert == null)
            {
                return "NONE";
            }

            var expirationDate = DateTime.Parse(cert.GetExpirationDateString());
            if ((expirationDate - DateTime.Now).TotalDays < 30)
            {
                return $"EXPIRES {expirationDate:dd MMM yyyy} !!";
            }
            return $"Expires {expirationDate:dd MMM yyyy}";
        }
    }
}
