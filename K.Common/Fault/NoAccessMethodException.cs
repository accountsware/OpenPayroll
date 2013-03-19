// CreatedBy	:  kun
// Solution 	:  KYourMovement 
// Projectt		:  K.Common
// FileName		:  NoAccessMethodException.cs
// Created Date	:  2013 03 19 6:28 PM

using System;
using System.Reflection;
using System.Text;

namespace K.Common.Fault
{
	public class NoAccessMethodException : Exception
	{
		public NoAccessMethodException(string message)
			: base(message)
		{
		}

		public NoAccessMethodException(string message, MethodBase methodBase)
			: base(message)
		{
			CurrentMethodBase = methodBase;
		}

		public override string StackTrace
		{
			get
			{
				var result = new StringBuilder();
				if (CurrentMethodBase != null)
				{
					result.AppendLine("\tMethodName: " + CurrentMethodBase.Name);
					result.AppendLine("\tModule: " + CurrentMethodBase.Module);
				}
				var a = result + base.StackTrace;
				return a;
			}
		}

		internal MethodBase CurrentMethodBase { get; set; }
	}
}