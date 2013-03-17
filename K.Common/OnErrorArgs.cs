using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K.Common
{
	public class OnErrorArgs : EventArgs
	{
		public OnErrorArgs(Exception err)
		{
			CException = err;
		}

		public Exception Error { get; set; }

		public Exception CException { get; set; }
	}
}
