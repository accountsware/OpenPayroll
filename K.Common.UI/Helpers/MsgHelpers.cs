using System;
using System.Windows.Forms;
using K.Common.Helpers;

namespace K.Common.UI.Helpers
{
    public class MsgHelpers
    {
        public static DialogResult ShowError(IWin32Window win, string caption, string msg)
        {
            return MessageBox.Show(win, msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static DialogResult ShowError(IWin32Window win, string msg)
        {
            return MessageBox.Show(win, msg, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowError(IWin32Window win, Exception err)
        {
            return MessageBox.Show(win, ExceptionHelpers.GetMessage(err), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInfo(IWin32Window win, string msg)
        {
            return MessageBox.Show(win, msg, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static DialogResult ShowWarning(IWin32Window win, string msg)
        {
            return MessageBox.Show(win, msg, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }



        public static DialogResult SaveAsk(IWin32Window win, string msg)
        {
            return MessageBox.Show(win, msg, @"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        public static DialogResult Ask(IWin32Window win, string msg)
        {
            return MessageBox.Show(win, msg, @"Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }

    }
}
