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
                    btnSwitch.Enabled = true;
                    break;
                default:
                    lblStatus.Text = "customErrors are OFF (bad)";
                    break;
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            btnSwitch.Enabled = false;
            btnSwitch.Text = "Please wait...";
            _customErrors.Set(false);
            MessageBox.Show("CustomErrors are now OFF! Click OK when finished and I'll switch them back on.");
            _customErrors.Set(true);
            btnSwitch.Text = "Switch them off for a bit";
            btnSwitch.Enabled = true;
        }
    }
}
