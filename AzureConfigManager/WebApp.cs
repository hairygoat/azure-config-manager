using System.Collections.Generic;

namespace AzureConfigManager
{
    public class WebApp
    {
        public string Name { get; set; }
        public string WebSpace { get; set; }
        public List<Setting> AppSettings { get; set; }
        public List<Setting> ConnectionStrings { get; set; }
    }
}