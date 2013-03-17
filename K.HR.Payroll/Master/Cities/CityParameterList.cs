using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.Common.UI.Forms;
using K.Common.UI.Patterns;

namespace K.HR.Payroll.Master.Cities
{
    public partial class CityParameterList : ListParameterBase
    {
        public CityParameterList()
        {
            InitializeComponent();
            SetLikeOperator();
        }
        public CityParameterList(IMaintainData maintainData)
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
