using System.Windows.Forms;
using K.Common.UI.Forms;

namespace K.Common.UI.Patterns
{
    public interface IMainConfiguration
    {
        Form CurrentMainForm { get; }
        void ShowMaintain(UserControl mpanel);
        void ShowMaintain(UserControl mpanel, ListParameterBase parameterBase);
        string CurrentUserName { get; set; }
    }
}
