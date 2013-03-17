using K.Common.UI.Forms;
using K.Common.UI.Patterns;

namespace K.HR.Payroll.Master.PayrollGroup
{
	public partial class PayrollGroupParameterList : ListParameterBase
	{
		public PayrollGroupParameterList()
		{
			InitializeComponent();
		}

		public PayrollGroupParameterList(IMaintainData maintainData)
            : base(maintainData)
		{
			InitializeComponent();
		}
	}
}
