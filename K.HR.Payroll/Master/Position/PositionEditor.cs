using System;
using System.Linq;
using System.Windows.Forms;
using K.Common.Data;
using K.Common.UI.Forms;
using K.Common.UI.Helpers;
using K.Common.UI.Patterns;
using K.HR.Payroll.Core;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Master.Position
{
	public partial class PositionEditor : EditorBase
	{
		public PositionEditor()
		{
			InitializeComponent();
		}

		internal void Edit(Form form, int id, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			DataStatus = 2;
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Edit Employee Position", "");
				PopulateInterfaceFromModel(id);
				SetEditButton();
				editor.ShowDialogEditor(form, this);
			}
		}

		private void PopulateInterfaceFromModel(int id)
		{
			using (var facade = new PositionCore())
			{
				var positionModel = facade.Get<IPositionModel>(WhereTerm.DefaultParam(id, "ID")).FirstOrDefault();
				if (positionModel == null || !facade.IsSuccess)
				{
					MsgHelpers.ShowError(this, string.IsNullOrEmpty(facade.Message) ? "Employee Position not found" : facade.Message);
					return;
				}
				createdBy.Text = positionModel.CreatedBy;
				createdDate.Value = positionModel.CreatedDate;
				recordId.Text = positionModel.Id.ToString();
				positionName.Text = positionModel.PositionName;
				createdBy.Text = positionModel.CreatedBy;
				createdDate.Value = positionModel.CreatedDate;
				modifiedBy.Text = positionModel.ModifiedBy;
				modifiedDate.Value = positionModel.ModifiedDate.HasValue ? positionModel.ModifiedDate.Value : DateTime.Now;
			}
		}

		internal void Delete(Form form, int id, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			DataStatus = 3;
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Delete Employee Position", "");
				PopulateInterfaceFromModel(id);
				SetDeleteButton();
				editor.ShowDialogEditor(form, this);
			}
		}

		protected override void Save()
		{
			base.Save();
			var positionModel = PopulateModelFromInterface();
			using (var facade = new PositionCore())
			{
				facade.Save(positionModel);
				ShowMessage(facade);
			}
		}

		protected override void SaveUpdate()
		{
			base.SaveUpdate();
			var positionModel = PopulateModelFromInterface();
			positionModel.Id = Convert.ToInt32(recordId.Text);
			positionModel.ModifiedBy = modifiedBy.Text;
			positionModel.ModifiedDate = modifiedDate.Value;
			using (var facade = new PositionCore())
			{
				facade.Update(positionModel);
				ShowMessage(facade);
			}
		}

		protected override void DeleteRecord()
		{
			base.DeleteRecord();
			var id = Convert.ToInt32(recordId.Text);
			using (var facade = new PositionCore())
			{
				facade.Delete(id);
				ShowMessage(facade);
			}
		}

		private IPositionModel PopulateModelFromInterface()
		{
			IPositionModel positionModel = new PositionModel();
			positionModel.CreatedBy = createdBy.Text;
			positionModel.CreatedDate = createdDate.Value;
			positionModel.Id = 0;
			positionModel.PositionName = positionName.Text;
			return positionModel;
		}

		internal void Create(Form form, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			var maintainData = form as IMainConfiguration;
			if (maintainData != null)
			{
				createdBy.Text = maintainData.CurrentUserName;
				createdDate.Value = DateTime.Now;
			}
			DataStatus = 1;
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Create New Employee Position", "");
				SetCreateButton();
				editor.ShowDialogEditor(form, this);
			}
		}
	}
}
