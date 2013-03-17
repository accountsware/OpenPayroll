using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Patterns;

namespace K.Common.UI.Forms
{
	public partial class KDateTimePicker : DateTimePicker, IListParameter
	{
		public KDateTimePicker()
		{
			InitializeComponent();
		}

		public KDateTimePicker(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		public EnumParamterDataTypes ParamDataType { get; set; }
		public object GetValue()
		{
			return Value;
		}

		public string TableName { get; set; }
		public string ColumnName { get; set; }
		public SqlOperator Operator { get; set; }
		public bool HasValue { get; private set; }
	}
}
