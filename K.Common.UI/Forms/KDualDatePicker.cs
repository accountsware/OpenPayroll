using System.ComponentModel;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.Common.UI.Forms
{
    public partial class KDualDatePicker : Control, IListRangeParameter
	{
		public KDualDatePicker()
		{
			InitializeComponent();
            ResetDate();
		}

		public KDualDatePicker(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
            ResetDate();
		}

        [Category("Parameter")]
        [DefaultValue(EnumParamterDataTypes.Character)]
        public EnumParamterDataTypes ParamDataType { get; set; }

        [Category("Parameter")]
        public string TableName { get; set; }

        public object GetValue()
        {
            return StartDate.Value;
        }

        [Category("Parameter")]
        public string ColumnName { get; set; }

        [Category("Parameter")]
        [DefaultValue(SqlOperator.Equals)]
        public SqlOperator Operator { get; set; }

    	public bool HasValue 
		{
			get { return StartDate.Value != null; }
		}

    	public object GetValue2()
        {
            return EndDate.Value;
        }

        [Category("Parameter")]
        public string TableName2 { get; set; }

        [Category("Parameter")]
        public string ColumnName2 { get; set; }

		public bool HasValue2
		{
			get { return EndDate.Value != null; }
		}

        public void ResetDate()
        {
            //StartDate.Value = StartDate.MinDate;
            
            //EndDate.Value = EndDate.MinDate;
            //StartDate.ResetValue();
            //EndDate.ResetValue();
        }
	}
}
