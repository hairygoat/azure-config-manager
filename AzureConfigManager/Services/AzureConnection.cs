﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzureConfigManager.Configuration;
using AzureConfigManager.Models;
using Microsoft.Azure;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.WebSites;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace AzureConfigManager.Services
{
    public class AzureConnection
    {
        private TokenCloudCredentials _credentials;

        public void Connect(string subscriptionId)
        {
            var token = GetAuthorizationHeader();
            _credentials = new TokenCloudCredentials(subscriptionId, token);
        }

        public async Task<List<WebApp>> GetApps(Func<int, bool> totalCallback, Func<bool> iterateCallback)
        {
            using (var client = new WebSiteManagementClient(_credentials))
            {
                var spaces = await client.WebSpaces.ListAsync();
                totalCallback(spaces.Count());
                var sites = (await Task.WhenAll(spaces.Select(async s => await client.WebSpaces.ListWebSitesAsync(s.Name, new WebSiteListParameters())).ToList())).SelectMany(a => a);
                totalCallback(sites.Count());
                var apps = await Task.WhenAll(sites.Select(async s =>
                {
                    var webApp = await GetWebApp(client, s);
                    iterateCallback();
                    return webApp;
                }).ToList());
                return apps.OrderBy(a => a.Name).ToList();
            }
        }

        public async Task SaveWebApp(WebApp app)
        {
            var connectionStrings = app.ConnectionStrings.Select(MapSettingToConnectionString).ToList();

            var newConfig = new WebSiteUpdateConfigurationParameters
            {
                ConnectionStrings = connectionStrings,
                DefaultDocuments = null,
                HandlerMappings = null,
                Metadata = null,
                AppSettings = app.AppSettings.ToDictionary(s => s.Key, s => s.Value)
            };

            using (var client = new WebSiteManagementClient(_credentials))
            {
                await client.WebSites.UpdateConfigurationAsync(app.WebSpace, app.Name, newConfig);
            }
        }

        private static async Task<WebApp> GetWebApp(IWebSiteManagementClient client, WebSite site)
        {
            var currentConfig = await client.WebSites.GetConfigurationAsync(site.WebSpace, site.Name,
                CancellationToken.None);

            var settings =
                currentConfig.AppSettings.Select(d => new Setting {Key = d.Key, Value = d.Value, IsSql = false})
                    .ToList();
            var connectionStrings = currentConfig.ConnectionStrings.Select(MapConnectionStringToSetting).ToList();

            var webApp = new WebApp
            {
                Name = site.Name,
                WebSpace = site.WebSpace,
                AppSettings = settings,
                ConnectionStrings = connectionStrings,
                FtpSettings = GetFtpSettings(site, currentConfig)
            };
            return webApp;
        }

        private static FtpSettings GetFtpSettings(WebSite site, WebSiteGetConfigurationResponse currentConfig)
        {
            var host = site.Uri.Host.Split('.').First() + ".ftp.azurewebsites.windows.net";

            return new FtpSettings
            {
                Host = host,
                User = currentConfig.PublishingUserName,
                Password = currentConfig.PublishingPassword
            };
        }

        private static WebSiteUpdateConfigurationParameters.ConnectionStringInfo MapSettingToConnectionString(Setting c)
        {
            return new WebSiteUpdateConfigurationParameters.ConnectionStringInfo
            {
                Name = c.Key,
                ConnectionString = c.Value,
                Type = c.IsSql ? ConnectionStringType.SqlAzure : ConnectionStringType.Custom
            };
        }

        private static Setting MapConnectionStringToSetting(WebSiteGetConfigurationResponse.ConnectionStringInfo d)
        {
            return new Setting
            {
                Key = d.Name,
                Value = d.ConnectionString,
                IsSql = d.Type == ConnectionStringType.SqlAzure || d.Type == ConnectionStringType.SqlServer
            };
        }

        private static string GetAuthorizationHeader()
        {
            var config = AcmSettings.Load();
            AuthenticationResult result = null;

            var context = new AuthenticationContext(string.Format(
                config.Login,
                config.TenantId));

            var thread = new Thread(() =>
            {
                result = context.AcquireToken(
                    config.ApiEndpoint,
                    config.ClientId,
                    new Uri(config.RedirectUri));
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Name = "AquireTokenThread";
            thread.Start();
            thread.Join();

            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            return result.AccessToken;
        }

        public async Task<List<object>> GetVms(Func<object, bool> totalCallback, Func<bool> iterateCallback)
        {
            using (var client = new ComputeManagementClient(_credentials))
            {
                var machines = client.VirtualMachines.Get(null, null, null);
                
                return new List<object>();
            }
        }
    }
}