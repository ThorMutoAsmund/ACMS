using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ACMS.System
{
    internal abstract class ConfigBase
    {
        private const string ConfigFolderBase = "/Config/";

        protected static string GetSystemConfigData(string fileName)
        {
            return File.ReadAllText(Path.Combine(HttpContext.Current.Server.MapPath(ConfigFolderBase), fileName), Encoding.UTF8);
        }
    }
}
