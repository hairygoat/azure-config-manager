using System;
using System.Windows.Forms;
using AzureConfigManager.Models;
using AzureConfigManager.Services;

namespace AzureConfigManager
{
    public partial class FrmCustomErrors : Form
    {
        private readonly CustomErrorsService _customErrors;

        public FrmCustomErrors(FtpSettings settings)
        {
            InitializeComponent();
            _customErrors = new CustomErrorsService(settings);
        }

        private void FrmCustomErrors_Load(object sender, EventArgs e)
        {
            var enabled = _customErrors.Get();
            switch (enabled)
            {
                case true:
                    lblStatus.Text = "customErrors are ON (good)";
                    break;
                default:
                    lblStatus.Text = "customErrors are OFF (bad)";
                    break;
            }
        }
    }
}
