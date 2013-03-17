using System.ComponentModel;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Patterns;

namespace K.Common.UI.Forms
{
	public partial class KTextBox : TextBox, IListParameter
	{
		public KTextBox()
		{
			InitializeComponent();
		}

		public KTextBox(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		[Category("Parameter")]
		[DefaultValue(EnumParamterDataTypes.Character)]
		public EnumParamterDataTypes ParamDataType { get; set; }
		
        public object GetValue()
		{
            return Text;
		}

		[Category("Parameter")]
		public string ColumnName { get; set; }

        [Category("Parameter")]
        public string TableName{ get; set; }

		[Category("Parameter")]
		//[DefaultValue(SqlOperator.Like)]
		public SqlOperator Operator { get; set; }

		public bool HasValue
		{
			get { return !string.IsNullOrEmpty(Text); }
		}
	}
}
