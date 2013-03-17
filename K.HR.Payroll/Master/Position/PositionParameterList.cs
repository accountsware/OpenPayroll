using K.Common.UI.Forms;
using K.Common.UI.Patterns;

namespace K.HR.Payroll.Master.Position
{
	public partial class PositionParameterList : ListParameterBase
	{
		public PositionParameterList()
		{
			InitializeComponent();
		}

		public PositionParameterList(IMaintainData maintainData)
            : base(maintainData)
		{
			InitializeComponent();
		}
	}
}
