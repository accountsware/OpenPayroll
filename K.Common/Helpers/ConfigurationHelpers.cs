using System.Configuration;

namespace K.Common.Helpers
{
    public static class ConfigurationHelpers
    {
        public static Configuration GetCurrentConfiguration()
        {
	        return null;
	        //var isweb = ConfigurationManager.AppSettings["IsWebApps"];
	        //return isweb.Equals("0")
	        //           ? ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
	        //           : WebConfigurationManager.OpenWebConfiguration("~");
        }
    }
}
