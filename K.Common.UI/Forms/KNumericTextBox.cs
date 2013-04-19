using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.Common.UI.Forms
{
    public partial class KNumericTextBox : TextBox, IListParameter
    {
        public KNumericTextBox()
        {
            InitializeComponent();
        }

        public KNumericTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public enum PasteRejectReasons
        {
            Unknown = 0,
            NoData,
            InvalidCharacter,
            Accepted
        }


        public const int WM_PASTE = 0x0302;
    	private readonly string defaultText = string.Empty;
        public const string DEFAULT_EMPTY_TEXT = "Please Enter Number...";


        
		[Category("Behavior"),
		 Description("Occurs whenever a KeyDown event is suppressed.")]
		public event EventHandler<KeyRejectedEventArgs> KeyRejected;

		[Category("Behavior"),
		 Description("Occurs whenever a paste attempt is suppressed.")]
		public event EventHandler<PasteEventArgs> PasteRejected;

		protected override void OnGotFocus(EventArgs e)
		{
			SelectAll();
			base.OnGotFocus(e);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			var result = true;

			var numericKeys = (
			                   	((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
			                   	 (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyValue == 190)
			                   	&& e.Modifiers != Keys.Shift  );

			bool ctrlA = e.KeyCode == Keys.A && e.Modifiers == Keys.Control;

			bool editKeys = (
			                	(e.KeyCode == Keys.Z && e.Modifiers == Keys.Control) ||
			                	(e.KeyCode == Keys.X && e.Modifiers == Keys.Control) ||
			                	(e.KeyCode == Keys.C && e.Modifiers == Keys.Control) ||
			                	(e.KeyCode == Keys.V && e.Modifiers == Keys.Control) ||
			                	e.KeyCode == Keys.Delete ||
			                	e.KeyCode == Keys.Back);

			bool navigationKeys = (
			                      	e.KeyCode == Keys.Up ||
			                      	e.KeyCode == Keys.Right ||
			                      	e.KeyCode == Keys.Down ||
			                      	e.KeyCode == Keys.Left ||
			                      	e.KeyCode == Keys.Home ||
			                      	e.KeyCode == Keys.End);

			if (!(numericKeys || editKeys || navigationKeys))
			{
				if (ctrlA)
					SelectAll();
				result = false;
			}
			if (!result)
			{
				e.SuppressKeyPress = true;
				e.Handled = true;
				if (ctrlA)
				{
				}
				else
					OnKeyRejected(new KeyRejectedEventArgs(e.KeyCode));
			}
			else
				base.OnKeyDown(e);
		}

		protected override void OnTextChanged(EventArgs e)
		{
			if (!Text.Trim().Equals(DEFAULT_EMPTY_TEXT))
			{
				if (string.IsNullOrEmpty(Text) || Text.Any(c => !char.IsNumber(c)))
				{
					Text = defaultText;
					SelectAll();
				}
				//var invalid = string.IsNullOrEmpty(Text) || Text.Any(c => !char.IsDigit(c));
				//if (Text.Contains("."))
				//    invalid = false;
				//if (invalid)
				//{
					
				//}
			}
			base.OnTextChanged(e);
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_PASTE)
			{
				var e = CheckPasteValid();
				if (e.RejectReason != PasteRejectReasons.Accepted)
				{
					m.Result = IntPtr.Zero;
					OnPasteRejected(e);
					return;
				}
			}
			base.WndProc(ref m);
		}

		private PasteEventArgs CheckPasteValid()
		{
			// Default values.
			PasteRejectReasons rejectReason = PasteRejectReasons.Accepted;
			string originalText = Text;
			string clipboardText = string.Empty;
			string textResult = string.Empty;

			try
			{
				clipboardText = Clipboard.GetText(TextDataFormat.Text);
				if (clipboardText.Length > 0)
				{
					textResult = (
					             	Text.Remove(SelectionStart, SelectionLength).Insert(SelectionStart, clipboardText));
					if (clipboardText.Any(c => !char.IsDigit(c)))
					{
						rejectReason = PasteRejectReasons.InvalidCharacter;
					}
				}
				else
					rejectReason = PasteRejectReasons.NoData;
			}
			catch
			{
				rejectReason = PasteRejectReasons.Unknown;
			}
			return new PasteEventArgs(originalText, clipboardText, textResult, rejectReason);
		}

		protected virtual void OnKeyRejected(KeyRejectedEventArgs e)
		{
			EventHandler<KeyRejectedEventArgs> handler = KeyRejected;
			if (handler != null)
				handler(this, e);
		}

		protected virtual void OnPasteRejected(PasteEventArgs e)
		{
			EventHandler<PasteEventArgs> handler = PasteRejected;
			if (handler != null)
				handler(this, e);
		}
        
		public class KeyRejectedEventArgs : EventArgs
		{
			private readonly Keys mKey;

			public KeyRejectedEventArgs(Keys key)
			{
				mKey = key;
			}

			[ReadOnly(true)]
			public Keys Key
			{
				get { return mKey; }
			}

			public override string ToString()
			{
				return string.Format("Rejected Key: {0}", Key);
			}
		}

        public class PasteEventArgs : EventArgs
        {
            private readonly string mClipboardText;
            private readonly string mOriginalText;
            private readonly PasteRejectReasons mRejectReason;
            private readonly string mTextResult;

            public PasteEventArgs(string originalText, string clipboardText, string textResult,
                                  PasteRejectReasons rejectReason)
            {
                mOriginalText = originalText;
                mClipboardText = clipboardText;
                mTextResult = textResult;
                mRejectReason = rejectReason;
            }

            [ReadOnly(true)]
            public string OriginalText
            {
                get { return mOriginalText; }
            }

            [ReadOnly(true)]
            public string ClipboardText
            {
                get { return mClipboardText; }
            }

            [ReadOnly(true)]
            public string TextResult
            {
                get { return mTextResult; }
            }

            [ReadOnly(true)]
            public PasteRejectReasons RejectReason
            {
                get { return mRejectReason; }
            }

            public override string ToString()
            {
                return string.Format("Rejected reason: {0}", RejectReason);
            }

        }

        [Category("Parameter")]
        [DefaultValue(EnumParamterDataTypes.Character)]
        public EnumParamterDataTypes ParamDataType { get; set; }

        public object GetValue()
        {
            return Convert.ToDouble(Text);
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
