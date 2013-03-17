using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common.UI.Patterns;
using K.HR.Payroll.Master.Cities;

namespace K.HR.Payroll.Command.Payroll
{
    class CityCommand : ICommand
    {
        public void ExecCommand()
        {
            var mpanel = new CityMaintain();
            var paramlist = new CityParameterList(mpanel);
            CurrentMainForm.ShowMaintain(mpanel, paramlist);
            mpanel.SetTitle("Master City");
        }

        public IMainConfiguration CurrentMainForm { get; set; }
    }
}
