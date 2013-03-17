using System;
using System.Windows.Forms;

namespace K.Common.UI.Patterns
{
    public interface ICommand
    {
        void ExecCommand();
        IMainConfiguration CurrentMainForm { get; set; }
    }
}
