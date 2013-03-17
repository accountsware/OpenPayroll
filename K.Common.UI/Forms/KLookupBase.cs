using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace K.Common.UI.Forms
{
    public partial class KLookupBase : Form
    {
        public KLookupBase()
        {
            InitializeComponent();
            buttonSelect1.Click +=ButtonSelect1Click;
            listView1.DoubleClick += ListView1DoubleClick;
            
        }

      

        void ListView1DoubleClick(object sender, EventArgs e)
        {
            SelectedItem = listView1.FocusedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        [DefaultValue(null)]
        public ListViewItem SelectedItem { get; set; }

        protected virtual void ButtonSelect1Click(object sender, EventArgs e)
        {
            SelectedItem = listView1.FocusedItem;
        }

        
    }
}
