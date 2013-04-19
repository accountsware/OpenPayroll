using System;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.UI.Helpers;
using K.Common.UI.Patterns;
using K.HR.Payroll.Core;

namespace K.Common.UI.Forms
{
    public partial class EditorBase : Form
    {
        public EditorBase()
        {
            InitializeComponent();
            buttonCancel.Click += ButtonCancelClick;
            buttonClose.Click += ButtonCloseClick;
            buttonOK.Click += ButtonOkClick;
            buttonOthers.Click += ButtonOthersClick;
            buttonDelete.Click += ButtonDeleteClick;
        }

        protected byte DataStatus { get; set; }
        protected IMaintainData MaintainData { get; set; }

        protected virtual void ButtonDeleteClick(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        protected virtual void DeleteRecord()
        {
        }

        protected virtual void ButtonOthersClick(object sender, EventArgs e)
        {
        }

        protected virtual void ButtonOkClick(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Yes;
            switch (DataStatus)
            {
                case 1:
                    Save();
                    break;
                case 2:
                    SaveUpdate();
                    break;
                default:
                    MsgHelpers.ShowWarning(this, "Data status is not define");
                    break;
            }
        }

        protected virtual void ButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void ButtonCancelClick(object sender, EventArgs e)
        {
			DialogResult = DialogResult.No;
            Close();
        }

        protected virtual void Save()
        {
            
        }

        protected virtual void SaveUpdate()
        {
            
        }

        protected virtual void ShowMessage(IDataManager dataManager)
        {
			//if (dataManager.IsSuccess)
			//{
			//    MsgHelpers.ShowInfo(this, dataManager.Message);
			//    Close();
			//    MaintainData.RefreshList();
			//}
			//else
			//{
			//    MsgHelpers.ShowError(this, "Error", dataManager.Message);
			//}
        }

		protected virtual void ShowMessage(PayrollModuleCore dataManager)
		{
			MsgHelpers.ShowInfo(this, dataManager.Message);
			Close();
			MaintainData.RefreshList();
		}

		protected virtual void ShowMessage(Exception err)
		{
			MsgHelpers.ShowInfo(this, err.Message);
		}

        protected virtual void SetDeleteButton()
        {
            buttonCancel.Visible = true;
            buttonClose.Visible = false;
            buttonDelete.Visible = true;
            buttonOK.Visible = false;
            buttonOthers.Visible = false;
            AcceptButton = buttonDelete;
            CancelButton = buttonCancel;
        }

        protected virtual void SetEditButton()
        {
            buttonCancel.Visible = true;
            buttonClose.Visible = false;
            buttonDelete.Visible = false;
            buttonOK.Visible = true;
            buttonOthers.Visible = false;
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
        }

        protected virtual void SetCreateButton()
        {
            buttonCancel.Visible = true;
            buttonClose.Visible = false;
            buttonDelete.Visible = false;
            buttonOK.Visible = true;
            buttonOthers.Visible = false;
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
        }
    }
}
