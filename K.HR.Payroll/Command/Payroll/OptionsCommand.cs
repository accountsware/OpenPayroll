using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common.UI.Patterns;

namespace K.HR.Payroll.Command.Payroll
{
	class OptionsCommand : ICommand
	{
		public void ExecCommand()
		{
			// TODO OPEN OPTION FORM
		}

		public IMainConfiguration CurrentMainForm { get; set; }
	}
}
