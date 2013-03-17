using System.ComponentModel;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.Common.UI.Forms
{
    public partial class KComboBox : ComboBox, IListParameter
    {
        public KComboBox()
        {
            InitializeComponent();
        }

        public KComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Category("Parameter")]
        [DefaultValue(EnumParamterDataTypes.Bool)]
        public EnumParamterDataTypes ParamDataType { get; set; }

        public object GetValue()
        {
            if ( string.IsNullOrEmpty(ValueMember))
                return Text;
            return SelectedValue;
        }

        [Category("Parameter")]
        public string ColumnName { get; set; }

        [Category("Parameter")]
        public string TableName { get; set; }

        [Category("Parameter")]
        [DefaultValue(SqlOperator.Equals)]
        public SqlOperator Operator { get; set; }

    	public bool HasValue
    	{
			get { return !string.IsNullOrEmpty(Text); }
    	}
    }
}
