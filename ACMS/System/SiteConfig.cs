using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS.System
{
    internal class SitesConfig : ConfigBase
    {
        private const string ConfigFileName = "sites.json";

        public List<SiteConfig> Sites { get; set; }

        public SitesConfig()
        {
        }

        public static SitesConfig Load()
        {
            var result = JsonConvert.DeserializeObject<SitesConfig>(GetSystemConfigData(ConfigFileName));
            return result;
        }
    }

    internal class SiteConfig
    {
        public string Name { get; set; }

        public SiteConfig()
        {
        }
    }
}
