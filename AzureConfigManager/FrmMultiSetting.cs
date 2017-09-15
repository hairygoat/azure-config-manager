using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AzureConfigManager.Models;
using AzureConfigManager.Services;

namespace AzureConfigManager
{
    public partial class FrmMultiSetting : Form
    {
        private readonly AzureConnection _connection;
        private readonly IEnumerable<WebApp> _apps;

        public FrmMultiSetting(AzureConnection connection, IEnumerable<WebApp> apps)
        {
            _connection = connection;
            _apps = apps;
            InitializeComponent();
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Text = "Please Wait";
            btnGo.Enabled = false;

            var i = 0;
            foreach (var app in _apps)
            {
                if (radioAppSetting.Checked)
                {
                    SetSetting(app.AppSettings, txtName.Text, txtValue.Text);
                }
                else
                {
                    SetSetting(app.ConnectionStrings, txtName.Text, txtValue.Text);
                }

                await _connection.SaveWebApp(app);
                i++;
                btnGo.Text = $"{i}/{_apps.Count()}";
            }

            Close();
        }

        private void SetSetting(List<Setting> settings, string key, string value)
        {
            if (settings.Any(a => a.Key == key))
            {
                settings.Single(a => a.Key == key).Value = value;
            }
            else
            {
                settings.Add(new Setting { Key = key, Value = value, IsSql = false });
            }
        }
    }
}
