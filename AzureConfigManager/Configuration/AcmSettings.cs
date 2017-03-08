using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AzureConfigManager.Configuration
{
    public class AcmSettings
    {
        public AcmSettings()
        {
            Subscriptions = new Dictionary<string, string>();
        }
        public string Login { get; set; }
        public string TenantId { get; set; }
        public string ApiEndpoint { get; set; }
        public string ClientId { get; set; }
        public string RedirectUri { get; set; }
        public Dictionary<string, string> Subscriptions { get; set; }

        public static AcmSettings Load()
        {
            if (!File.Exists("azure.settings"))
            {
                return new AcmSettings();
            }

            var settingsFile = File.ReadAllText("azure.settings");
            return JsonConvert.DeserializeObject<AcmSettings>(settingsFile);
        }

        public static void Save(AcmSettings settings)
        {
            File.WriteAllText("azure.settings", JsonConvert.SerializeObject(settings));
        }
    }
}