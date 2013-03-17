using System;

namespace K.Common.Helpers
{
    public static class ExceptionHelpers
    {
        public const string BREAK_LINE = "\n";
        public static string GetMessage(Exception err)
        {
            if (err == null) return "";
            var result = err.Message + BREAK_LINE + GetMessage(err.InnerException);
            return result;
        }

    }
}
