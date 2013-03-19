using System;
using System.Configuration;
using K.Common.Patterns;

namespace K.Common.Helpers
{
    public static class ExceptionHelpers
    {
        public const string BREAK_LINE = "\n";
        public static string GetMessage(Exception err)
        {
			if (err == null) return "";
			var result = err.Message + (err.InnerException == null ? "" : NewLine) + GetMessage(err.InnerException);
			return result;
        }

		private static string NewLine
		{
			get
			{
				return string.IsNullOrEmpty(ConfigurationManager.AppSettings["IsWebApps"])
						? DefaultValue.DEFAULT_NEW_LINE_CONSOLE
						: ConfigurationManager.AppSettings["IsWebApps"].Equals("1")
							? DefaultValue.DEFAULT_NEW_LINE_WEB
							: DefaultValue.DEFAULT_NEW_LINE_CONSOLE;
			}
		}

    }
}
