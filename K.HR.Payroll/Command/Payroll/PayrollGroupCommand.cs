using K.Common.UI.Patterns;
using K.HR.Payroll.Master.PayrollGroup;

namespace K.HR.Payroll.Command.Payroll
{
	class PayrollGroupCommand : ICommand
	{
		public void ExecCommand()
		{
			var mpanel = new PayrollGroupMaintain();
			var paramlist = new PayrollGroupParameterList(mpanel);
			CurrentMainForm.ShowMaintain(mpanel, paramlist);
			mpanel.SetTitle("Payroll Group");
		}

		public IMainConfiguration CurrentMainForm { get; set; }
	}
}
