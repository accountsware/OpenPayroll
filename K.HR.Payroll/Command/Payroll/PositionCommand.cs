using K.Common.UI.Patterns;
using K.HR.Payroll.Master.Position;

namespace K.HR.Payroll.Command.Payroll
{
	class PositionCommand : ICommand
	{
		public void ExecCommand()
		{
			var mpanel = new PositionMaintain();
			var paramlist = new PositionParameterList(mpanel);
			CurrentMainForm.ShowMaintain(mpanel, paramlist);
			mpanel.SetTitle("Employee Position");
		}

		public IMainConfiguration CurrentMainForm { get; set; }
	}
}
