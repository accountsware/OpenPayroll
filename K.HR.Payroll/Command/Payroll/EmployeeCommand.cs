using K.Common.UI.Patterns;
using K.HR.Payroll.Master.Employees;

namespace K.HR.Payroll.Command.Payroll
{
    class EmployeeCommand : ICommand
    {
        #region Implementation of ICommand

        public void ExecCommand()
        {
            var mpanel = new EmployeeMaintain();
            var paramlist = new EmployeeParameterList(mpanel);
            CurrentMainForm.ShowMaintain(mpanel, paramlist);
            mpanel.SetTitle("Employees");
        }

        public IMainConfiguration CurrentMainForm { get; set; }

        #endregion
    }
}
