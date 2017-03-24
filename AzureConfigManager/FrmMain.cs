using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzureConfigManager.Configuration;
using AzureConfigManager.Helpers;
using AzureConfigManager.Models;
using AzureConfigManager.Services;

namespace AzureConfigManager
{
    public partial class FrmMain : Form
    {
        private readonly AzureConnection _azure;
        private List<WebApp> _apps;
        private WebApp _currentApp;
        private int _progress;
        private int _total;

        public FrmMain()
        {
            InitializeComponent();
            _azure = new AzureConnection();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadSubscriptions();
        }

        private void LoadSubscriptions()
        {
            var config = AcmSettings.Load();
            comboSubscription.Items.Clear();
            foreach (var sub in config.Subscriptions.OrderBy(s => s.Value))
            {
                comboSubscription.Items.Add($"{sub.Value}={sub.Key}");
            }
        }

        private async void BtnLoadCredentials_Click(object sender, EventArgs e)
        {
            if (comboSubscription.SelectedItem == null)
            {
                MessageBox.Show("Pick a subscription idiot");
            }
            else
            {
                await RefreshData();
            }
        }

        private async Task RefreshData()
        {
            statusLabel.Text = "Connecting to Azure...";
            DisableButtons();
            var subscriptionId = comboSubscription.SelectedItem.ToString().Split('=')[1];
            _azure.Connect(subscriptionId);

            statusLabel.Text = "Fetching data...";
            _progress = 0;

            _apps = await _azure.GetApps(t =>
            {
                _total = t;
                return true;
            },  IterateProgress);

            lstApps.Items.Clear();
            var appNames = _apps.Select(a => a.Name).ToArray();
            lstApps.Items.AddRange(appNames);
            statusLabel.Text = $"{_apps.Count} Web Apps loaded";

            EnableButtons();
        }

        private bool IterateProgress()
        {
            _progress++;
            statusLabel.Text = $"Loading web apps... ({_progress}/{_total})";
            return true;
        }

        private void LstApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstApps.SelectedItem == null)
            {
                // You clicked in the whitespace, don't know why this event even fires...
                return;
            }
            var name = lstApps.SelectedItem.ToString();
            _currentApp = _apps.Single(a => a.Name == name);

            PopulateDataGridFromSettings(appSettingsGrid, _currentApp.AppSettings, false);

            PopulateDataGridFromSettings(connectionStringsGrid, _currentApp.ConnectionStrings, true);
        }

        private static void PopulateDataGridFromSettings(DataGridView dataGrid, IEnumerable<Setting> settings, bool withSql)
        {
            object[][] rows;

            if (withSql)
            {
                rows = settings.Select(a => new object[] {a.Key, a.Value, a.IsSql}).ToArray();
            }
            else
            {
                rows = settings.Select(a => new object[] {a.Key, a.Value}).ToArray();
            }

            dataGrid.Rows.Clear();
            foreach (var row in rows)
            {
                dataGrid.Rows.Add(row);
            }
        }

        private async void BtnCommit_Click(object sender, EventArgs e)
        {
            DisableButtons();
            var name = lstApps.SelectedItem.ToString();
            var app = _apps.Single(a => a.Name == name);
            app.AppSettings = DataGridHelpers.SettingsFromDataGrid(appSettingsGrid);
            app.ConnectionStrings = DataGridHelpers.SettingsFromDataGrid(connectionStringsGrid);

            statusLabel.Text = "Connecting to Azure...";

            var subscriptionId = comboSubscription.SelectedItem.ToString().Split('=')[1];
            _azure.Connect(subscriptionId);
            statusLabel.Text = "Setting data...";

            await _azure.SaveWebApp(app);

            EnableButtons();

            await RefreshData();

            lstApps.SelectedItem = name;
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsDialog = new FrmSettings();
            settingsDialog.ShowDialog();
            LoadSubscriptions();
        }

        private void btnFilezilla_Click(object sender, EventArgs e)
        {
            if (_currentApp == null)
            {
                return;
            }

            var fileZillaLocation = AcmSettings.Load().FileZillaLocation;
            Process.Start(fileZillaLocation, _currentApp.FtpSettings.FilezillaArgument);
        }
    }
}