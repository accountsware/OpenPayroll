using System;
using System.ComponentModel;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Patterns;

namespace K.Common.UI.Forms
{
    public partial class KCheckBox : CheckBox, IListParameter
    {
        public KCheckBox()
        {
            InitializeComponent();
        }

        public KCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Category("Parameter")]
        [DefaultValue(EnumParamterDataTypes.Number)]
        public EnumParamterDataTypes ParamDataType { get; set; }

        public object GetValue()
        {
            return Checked;
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
            get { return hasEdited; }
        }

        bool hasEdited =  false;
        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            hasEdited = true;
        }
    }
}
