using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.WindowsAzure.Management.WebSites;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace AzureConfigManager
{
    public partial class FrmMain : Form
    {
        private WebApp[] _apps;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void btnLoadCredentials_Click(object sender, EventArgs e)
        {
            await RefreshData();
        }

        private async Task RefreshData()
        {
            statusLabel.Text = "Connecting to Azure...";
            DisableButtons();
            var token = GetAuthorizationHeader();
            var subscriptionId = comboSubscription.SelectedItem.ToString().Split('=')[1];
            var credentials = new TokenCloudCredentials(subscriptionId, token);
            statusLabel.Text = "Fetching data...";
            using (var client = new WebSiteManagementClient(credentials)) {
                var spaces = await client.WebSpaces.ListAsync();
                var sites = (await Task.WhenAll(spaces.Select(async s => await client.WebSpaces.ListWebSitesAsync(s.Name, new WebSiteListParameters())).ToList())).SelectMany(a => a);

                _apps = await Task.WhenAll(sites.Select(async s => await GetWebApp(client, s)).ToList());
            }

            _apps = _apps.OrderBy(a => a.Name).ToArray();
            lstApps.Items.Clear();
            lstApps.Items.AddRange(_apps.Select(a => a.Name).ToArray());
            statusLabel.Text = $"{_apps.Length} Web Apps loaded";

            EnableButtons();
        }

        private static async Task<WebApp> GetWebApp(IWebSiteManagementClient client, WebSite site)
        {
            var currentConfig = await client.WebSites.GetConfigurationAsync(site.WebSpace, site.Name, CancellationToken.None);
            var settings = currentConfig.AppSettings.Select(d => new Setting { Key = d.Key, Value = d.Value, IsSql = false }).ToList();
            var connectionStrings = currentConfig.ConnectionStrings.Select(d =>
                new Setting
                {
                    Key = d.Name,
                    Value = d.ConnectionString,
                    IsSql = (d.Type == ConnectionStringType.SqlAzure || d.Type == ConnectionStringType.SqlServer)
                }).ToList();

            var webApp = new WebApp() {
                Name = site.Name,
                WebSpace = site.WebSpace,
                AppSettings = settings,
                ConnectionStrings = connectionStrings
            };
            return webApp;
        }

        private static string GetAuthorizationHeader()
        {
            AuthenticationResult result = null;

            var context = new AuthenticationContext(string.Format(
              ConfigurationManager.AppSettings["login"],
              ConfigurationManager.AppSettings["tenantId"]));

            var thread = new Thread(() => {
                result = context.AcquireToken(
                  ConfigurationManager.AppSettings["apiEndpoint"],
                  ConfigurationManager.AppSettings["clientId"],
                  new Uri(ConfigurationManager.AppSettings["redirectUri"]));
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Name = "AquireTokenThread";
            thread.Start();
            thread.Join();

            if (result == null) {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            string token = result.AccessToken;
            return token;
        }

        internal class WebApp
        {
            public string Name { get; set; }
            public string WebSpace { get; set; }
            public List<Setting> AppSettings { get; set; }
            public List<Setting> ConnectionStrings { get; set; }
        }

        internal class Setting
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public bool IsSql { get; set; }
        }

        private void lstApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = lstApps.SelectedItem.ToString();
            var app = _apps.Single(a => a.Name == name);

            PopulateDataGridFromDictionary(appSettingsGrid, app.AppSettings, false);

            PopulateDataGridFromDictionary(connectionStringsGrid, app.ConnectionStrings, true);
        }

        private static void PopulateDataGridFromDictionary(DataGridView dataGrid, List<Setting> dictionary, bool withSql)
        {
            object[][] rows;

            if (withSql)
            {
                rows = dictionary.Select(a => new object[] {a.Key, a.Value, a.IsSql}).ToArray();
            }
            else
            {
                rows = dictionary.Select(a => new object[] { a.Key, a.Value }).ToArray();
            }
            
            dataGrid.Rows.Clear();
            foreach (var row in rows) {
                dataGrid.Rows.Add(row);
            }
        }

        private static void PopulateDictionaryFromDataGrid(List<Setting> dictionary, DataGridView dataGrid)
        {
            dictionary.Clear();
            foreach (var row in dataGrid.Rows) {
                var rowArray = (row as DataGridViewRow).Cells;
                if (rowArray[0].Value != null && rowArray[1].Value != null) {
                    if (rowArray.Count == 3)
                    {
                        dictionary.Add(new Setting
                        {
                            Key = rowArray[0].Value.ToString(),
                            Value = rowArray[1].Value.ToString(),
                            IsSql = (bool) rowArray[2].Value
                        });
                    }
                    else
                    {
                        dictionary.Add(new Setting
                        {
                            Key = rowArray[0].Value.ToString(),
                            Value = rowArray[1].Value.ToString(),
                            IsSql = false
                        });
                    }
                }
            }
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            DisableButtons();
            var name = lstApps.SelectedItem.ToString();
            var app = _apps.Single(a => a.Name == name);
            PopulateDictionaryFromDataGrid(app.AppSettings, appSettingsGrid);
            PopulateDictionaryFromDataGrid(app.ConnectionStrings, connectionStringsGrid);

            statusLabel.Text = "Connecting to Azure...";
            var token = GetAuthorizationHeader();
            var subscriptionId = comboSubscription.SelectedItem.ToString().Split('=')[1];
            var credentials = new TokenCloudCredentials(subscriptionId, token);
            statusLabel.Text = "Setting data...";

            var connectionStrings =
            app.ConnectionStrings.Select(c => new WebSiteUpdateConfigurationParameters.ConnectionStringInfo
            {
                Name = c.Key,
                ConnectionString = c.Value,
                Type = c.IsSql ? ConnectionStringType.SqlAzure : ConnectionStringType.Custom
            }).ToList();
            

            var newConfig = new WebSiteUpdateConfigurationParameters
            {
                ConnectionStrings = connectionStrings,
                DefaultDocuments = null,
                HandlerMappings = null,
                Metadata = null,
                AppSettings = app.AppSettings.ToDictionary(s => s.Key, s => s.Value)
            };
            
            using (var client = new WebSiteManagementClient(credentials)) {
                await client.WebSites.UpdateConfigurationAsync(app.WebSpace, app.Name, newConfig);
            }

            EnableButtons();

            await RefreshData();
        }

        private void DisableButtons()
        {
            btnCommit.Enabled = false;
            btnLoadCredentials.Enabled = false;
        }

        private void EnableButtons()
        {
            btnCommit.Enabled = true;
            btnLoadCredentials.Enabled = true;
        }
    }
}
