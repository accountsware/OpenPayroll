using System.Configuration;
using System.Web.Configuration;
using System.Windows.Forms;

namespace K.Common.Helpers
{
    public static class ConfigurationHelpers
    {
        public static Configuration GetCurrentConfiguration()
        {
            var isweb = ConfigurationManager.AppSettings["IsWebApps"];
            return isweb.Equals("0")
                       ? ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
                       : WebConfigurationManager.OpenWebConfiguration("~");
        }
    }
}
