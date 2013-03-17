using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K.Common.UI.Forms
{
    public partial class BlankForm : Form
    {
        public BlankForm()
        {
            InitializeComponent();
            DoubleClick += BlankFormDoubleClick;
        }

        void BlankFormDoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowEditor(IWin32Window win32Window, EditorBase editor)
        {
            
        }

        private EditorBase Editor { get; set; }

        public void ShowDialogEditor(IWin32Window win32Window, EditorBase editor)
        {
            Editor = editor;
            Shown += BlankFormShown;
            ShowDialog(win32Window);
        }

        void BlankFormShown(object sender, EventArgs e)
        {
            Editor.FormClosed += EditorFormClosed;
            Editor.ShowDialog(this);
        }

        void EditorFormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
