using System;
using System.Linq;
using System.Windows.Forms;
using AzureConfigManager.Models;

namespace AzureConfigManager
{
    public partial class FrmConfigXml : Form
    {
        private readonly WebApp _currentApp;

        public FrmConfigXml(WebApp currentApp)
        {
            _currentApp = currentApp;
            InitializeComponent();
        }

        private void FrmConfigXml_Load(object sender, EventArgs e)
        {
            txtAppSettings.Text = GetAppSettingsXml(_currentApp);
            txtConnectionStrings.Text = GetConnectionStringsXml(_currentApp);
        }

        private static string GetAppSettingsXml(WebApp currentApp)
        {
            var settingStrings = currentApp.AppSettings.Select(a => $"<add key=\"{a.Key}\" value=\"{a.Value}\" />");
            return string.Join(Environment.NewLine, settingStrings.ToArray());
        }

        private static string GetConnectionStringsXml(WebApp currentApp)
        {
            var connections = currentApp.ConnectionStrings.Select(MapConnectionString);
            return string.Join(Environment.NewLine, connections.ToArray());
        }

        private static string MapConnectionString(Setting a)
        {
            var providerName = string.Empty;
            if (a.IsSql)
            {
                providerName = "providerName=\"System.Data.SqlClient\" ";
            }
            return $"<add name=\"{a.Key}\" {providerName}connectionString=\"{a.Value}\" />";
        }

        private void txtAppSettings_Click(object sender, EventArgs e)
        {
            txtAppSettings.SelectAll();
        }

        private void txtConnectionStrings_Click(object sender, EventArgs e)
        {
            txtConnectionStrings.SelectAll();
        }
    }
}