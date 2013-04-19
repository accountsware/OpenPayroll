using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace K.ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			
			var a = Console.ReadLine();
			if (!a.Equals("X"))
			{
				PercenRegEx(a);
			}
		}

		private static void DecimalRegEx(string s)
		{
			var decimalRegex = new Regex(@"^-?(([1-9]\d*)|0)(.0*[1-9](0*[1-9])*)?$");
			var d = decimalRegex.IsMatch(s);
			Console.WriteLine("Result Is " + d);
			var a = Console.ReadLine();
			if (!a.Equals("X"))
			{
				DecimalRegEx(a);
			}
		}

		private static void PercenRegEx(string s)
		{
			//var percenReg = new Regex(@"(^(100(?:\.0{1,2})?))|(?!^0*$)(?!^0*\.0*$)^\d{1,2}(\.\d{1,2})?$");
			var percenReg = new Regex(@"^\d{0,2}(\.\d{1,4})? *%?$");
			var d = percenReg.IsMatch(s);
			Console.WriteLine("Result Is " + d);
			var a = Console.ReadLine();
			if (!a.Equals("X"))
			{
				PercenRegEx(a);
			}
		}


	}
}
