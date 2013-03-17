using System;
using System.Windows.Forms;

namespace K.Common.UI.Forms
{
    public class OnListViewItemSelectedItemArgs : EventArgs
    {
        public OnListViewItemSelectedItemArgs(ListViewItem item)
        {
            SelectedItem = item;
        }

        public ListViewItem SelectedItem { get; set; }

    }
}
