using System.Collections.Generic;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.Patterns;
using K.Common.UI.Patterns;

namespace K.Common.UI.Forms
{
	public partial class ListParameterBase : Form
	{

        public ListParameterBase()
        {
            InitializeComponent();
            buttonClose.Click += ButtonCloseClick;
            buttonApply.Click += ButtonApplyClick;
            buttonOk.Click += ButtonOkClick;
            buttonClear.Click += ButtonClearClick;
        }

        void ButtonClearClick(object sender, System.EventArgs e)
        {
            ClearParamater(this);
        }

	    private void ClearParamater(Control parent)
	    {
	        foreach (Control control in parent.Controls)
	        {
	            if (control is IListParameter)
	            {
	                if (((IListParameter) control).HasValue)
	                {
	                    if ((control is KDateTimePicker))
	                    {
	                        ((KDateTimePicker) control).Checked = false;
	                    }
	                    else
	                    {
	                        control.Text = string.Empty;
	                    }
	                }
	            }
	            else
	            {
	                if (control.HasChildren)
	                {
                        ClearParamater(control);
	                }
	            }
	        }
	    }

	    public ListParameterBase(IMaintainData maintainData)
		{
			InitializeComponent();
            buttonClose.Click += ButtonCloseClick;
            buttonApply.Click += ButtonApplyClick;
            buttonOk.Click += ButtonOkClick;
            buttonClear.Click += ButtonClearClick;
		    MaintainData = maintainData;
		}

	    IMaintainData MaintainData { get; set; }

        void ButtonOkClick(object sender, System.EventArgs e)
        {
            MaintainData.RefreshList();
            Hide();
        }

        void ButtonApplyClick(object sender, System.EventArgs e)
        {
            MaintainData.RefreshList();
        }

        void ButtonCloseClick(object sender, System.EventArgs e)
        {
            Hide();
        }


		public IEnumerable<IListParameter> GetQueryParameter()
		{
			return GetControlParameterWhereTerm(this);
		}

		public IEnumerable<IListParameter> GetQueryParameter(IEnumerable<IListParameter> defaultparams)
		{
			var a = GetControlParameterWhereTerm(this);
			a.AddRange(defaultparams);
			return a;
		}

		private static List<IListParameter> GetControlParameterWhereTerm(Control pcontrol)
		{
			var result = new List<IListParameter>();
            foreach (Control control in pcontrol.Controls)
            {
                if (control is IListParameter)
                {
                    if (((IListParameter)control).HasValue)
                    {
                        result.Add(control as IListParameter);
                    }
                }
                else
                {
                    if (control.HasChildren)
                    {
                        result.AddRange(GetControlParameterWhereTerm(control));
                    }
                }
            }
			return result;
		}
	}
}
