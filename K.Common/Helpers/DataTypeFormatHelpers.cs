using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K.Common.Helpers
{
	public class DataTypeFormatHelpers
	{
		public static string GetDate(DateTime datetime)
		{
			//TODO CONFIGUREABLE
			return datetime.ToString("dd-MM-yyyy");
		}
	}
}
