using System;
using System.ComponentModel;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.Common.UI.Forms;

namespace Ceva.Windows.Controls.EditBox
{
    public partial class LookupTextBox : Control, IListParameter
    {

        public LookupTextBox()
        {
            InitializeComponent();
            LButton.Click += ButtonLookupOnClick;
            //LTextBox.KeyDown += new KeyEventHandler(LTextBox_KeyDown);
        }

        public event EventHandler<OnListViewItemSelectedItemArgs> ListViewItemSelectedItemHandler;

        public LookupTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            LButton.Click += ButtonLookupOnClick;
            //LTextBox.KeyDown += new KeyEventHandler(LTextBox_KeyDown);
        }

        private void ButtonLookupOnClick(object sender, EventArgs e)
        {
            var ownerform = GetParentForm(Parent);
            if (FormLookup == null)
            {
                MessageBox.Show(ownerform, @"Form Lookup is undefined", @"Error",MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                if ((ownerform != null || ParentForm != null )&& FormLookup != null)
                {
					//FormLookup.ShowDialog((ownerform == null ? ParentForm : ownerform));
					// TODO GOOD LOGIC
                    FormLookup.ShowDialog((ownerform ?? ParentForm));
                    if (FormLookup.DialogResult == DialogResult.OK)
                    {
                        if (FormLookup.SelectedItem == null) return;
                        LTextBox.Text = FormLookup.SelectedItem.Text;
                        OnListViewItemSelectedItemHandler(new OnListViewItemSelectedItemArgs(FormLookup.SelectedItem));
                    }
                }
                else
                {
                    FormLookup.Show();
                }
            }
        }

        private static Form GetParentForm(Control control)
        {
        	if (control is Form)
                return control as Form;
        	return control.Parent.Equals(null) ? null : GetParentForm(control.Parent);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            LTextBox.Text = string.Empty;
        }
        
    	public Form ParentForm { get; set; }

        protected void OnListViewItemSelectedItemHandler(OnListViewItemSelectedItemArgs e)
        {
            var handler = ListViewItemSelectedItemHandler;
            if (handler != null) handler(this, e);
        }

        [DefaultValue(null)]
        public KLookupBase FormLookup { get; set; }

        public TextBox InnerTextBox
        {
            get
            {
                return LTextBox;
            }
            set
            {
                LTextBox = value;
            }
        }

        [DefaultValue(null)]
        public object Value { get; set; }

        [Category("Parameter")]
        [DefaultValue(EnumParamterDataTypes.Character)]
        public EnumParamterDataTypes ParamDataType { get; set; }

        public object GetValue()
        {
            return LTextBox.Text;
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
			get { return !string.IsNullOrEmpty(LTextBox.Text); }
    	}

        public new string Text 
        { 
            get{
                return LTextBox.Text;
            }
            set
            {
                LTextBox.Text = value;
            }
        }
    }
}
