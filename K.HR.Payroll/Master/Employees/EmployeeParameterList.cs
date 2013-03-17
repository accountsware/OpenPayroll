using K.Common.Data;
using K.Common.Patterns;
using K.Common.UI.Forms;
using K.Common.UI.Patterns;

namespace K.HR.Payroll.Master.Employees
{
	public partial class EmployeeParameterList : ListParameterBase
	{
        public EmployeeParameterList()
        {
            InitializeComponent();
            SetLikeOperator();
        }
        public EmployeeParameterList(IMaintainData maintainData)
            : base(maintainData)
		{
			InitializeComponent();
            SetLikeOperator();
		}

        private void SetLikeOperator()
        {
            foreach (var control in Controls)
            {
                if (!(control is KTextBox)) continue;
                ((IListParameter)control).Operator = SqlOperator.Like; ;
            }
        }
	}
}
