using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACMS.System
{
    internal static class Config
    {
        public static SystemConfig System { get; } = SystemConfig.Load();
        public static SitesConfig Sites { get; } = SitesConfig.Load();
    }
}