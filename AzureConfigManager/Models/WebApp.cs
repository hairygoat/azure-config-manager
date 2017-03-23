using System.Collections.Generic;

namespace AzureConfigManager.Models
{
    public class WebApp
    {
        public string Name { get; set; }
        public string WebSpace { get; set; }
        public List<Setting> AppSettings { get; set; }
        public List<Setting> ConnectionStrings { get; set; }
        public FtpSettings FtpSettings { get; set; }
    }

    public class FtpSettings
    {
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string FilezillaArgument => $"{User}:{Password}@{Host}";
    }
}