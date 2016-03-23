using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS.System
{
    internal class SystemConfig : ConfigBase
    {
        private const string ConfigFileName = "system.json";

        public decimal Version { get; set; }

        public static SystemConfig Load()
        {
            var result = JsonConvert.DeserializeObject<SystemConfig>(GetSystemConfigData(ConfigFileName));
            return result;
        }
    }
}
