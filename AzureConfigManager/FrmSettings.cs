using System;
using System.Windows.Forms;
using AzureConfigManager.Configuration;
using AzureConfigManager.Helpers;

namespace AzureConfigManager
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadSettings(AcmSettings.Load());
        }

        private void LoadSettings(AcmSettings settings)
        {
            txtLogin.Text = settings.Login;
            txtTenantId.Text = settings.TenantId;
            txtApiEndpoint.Text = settings.ApiEndpoint;
            txtClientId.Text = settings.ClientId;
            txtRedirectUri.Text = settings.RedirectUri;
            DataGridHelpers.FillDataGridFromDictionary(gridSubscriptions, settings.Subscriptions);
        }

        private void SaveSettings()
        {
            var settings = new AcmSettings
            {
                Login = txtLogin.Text,
                TenantId = txtTenantId.Text,
                ApiEndpoint = txtApiEndpoint.Text,
                ClientId = txtClientId.Text,
                RedirectUri = txtRedirectUri.Text,
                Subscriptions = DataGridHelpers.DataGridToDictionary(gridSubscriptions)
            };
            AcmSettings.Save(settings);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }
    }
}
