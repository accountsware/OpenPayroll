using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
using K.Common.UI.Forms;
using K.Common.UI.Patterns;
using K.HR.Payroll.Core;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Master.PayrollGroup
{
	public partial class PayrollGroupEditor : EditorBase
	{
		public PayrollGroupEditor()
		{
			InitializeComponent();
			objectListView1.ShowGroups = false;
            objectListView1.MultiSelect = false;
		    //objectListView1 = true;
            
		    var btnAdd = detailPanel1.GetAddButton();
		    btnAdd.Click += AddDetail;
			Load += PayrollGroupEditorLoad;
			groupType.SelectedIndexChanged += GroupTypeSelectedIndexChanged;
		}

		void GroupTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			switch (groupType.SelectedIndex)
			{
				case 0:
					unit.Text = @"1";
					unit.ReadOnly = true;
					break;
				case 1:
					unit.ReadOnly = false;
					break;
			}
		}

		void PayrollGroupEditorLoad(object sender, EventArgs e)
		{
			groupType.SelectedIndex = 0;

		}

	    private void AddDetail(object sender, EventArgs e)
	    {
			using (var editor = new PayrollGroupDetailEditor())
			{
				var result = editor.Create(this, MaintainData);
				if (result == DialogResult.Yes)
				{
					IPayrollItemModel payrollItemModel = new PayrollItemModel();
					payrollItemModel.Id = editor.PayrollItem.Id;
					payrollItemModel.Name = editor.PayrollItem.Name;
					payrollItemModel.CrudStatus = editor.PayrollItem.CrudStatus;
					payrollItemModel.CreatedDate = DateTime.Now;
					payrollItemModel.CreatedBy = mainConfiguration.CurrentUserName;
					payrollItemModel.CrudStatus = editor.PayrollItem.CrudStatus;
					payrollItemModel.Description = editor.PayrollItem.Description;
					payrollItemModel.ItemType = editor.PayrollItem.ItemType;
					payrollItemModel.RowStatus = editor.PayrollItem.RowStatus;
					payrollItemModel.Type = editor.PayrollItem.Type;
					payrollItemModel.Unit = editor.PayrollItem.Unit;
					objectListView1.AddObject(payrollItemModel);
					
				}
			}
			
	    }

		private IMainConfiguration mainConfiguration;
	    internal void Create(Form form, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			mainConfiguration = form as IMainConfiguration;
			if (mainConfiguration != null)
			{
				//createdBy.Text = maintainData.CurrentUserName;
				//createdDate.Value = DateTime.Now;
			}
			DataStatus = 1;
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Create New Payroll Group", "");
				SetCreateButton();
				recordId.Text = @"Auto Generate";
				recordId.ReadOnly = true;
				editor.ShowDialogEditor(form, this);
			}
		}

		internal void Edit(Form form, int id, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			DataStatus = 2;
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Edit Payroll Group", "");
				PopulateInterfaceFromModel(id);
				SetEditButton();
				editor.ShowDialogEditor(form, this);
			}
		}

		private void PopulateInterfaceFromModel(int id)
		{
		}

		internal void Delete(Form form, int id, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			DataStatus = 3;
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Delete Payroll Group", "");
				PopulateInterfaceFromModel(id);
				SetDeleteButton();
				editor.ShowDialogEditor(form, this);
			}
		}

		protected override void Save()
		{
		    base.Save();
		    var payrollgroup = PopulatePayrollGroupModelFromInterface();
		    using (var facade = new PayrollGroupModuleCore())
		    {
				// TODO SAVE TRANSACTION
				//facade.Save(payrollgroup);
				//SaveDetail(myId);
				//ShowMessage(facade);
		    }
		}

        protected void SaveDetail(int parentId) {
            var facade = new PayrollItemModuleCore();
            if (objectListView1.Items.Count <= 0) return;
            for (var i = 0; i < objectListView1.Items.Count; i++ )
            {
                var payrollItemModel = (IPayrollItemModel) objectListView1.GetModelObject(i);
                payrollItemModel.Id = parentId;
                switch (payrollItemModel.CrudStatus)
                {
	                case 1:
		                facade.Save(payrollItemModel);
		                break;
	                case 2:
		                facade.Update(payrollItemModel);
		                break;
	                case 3:
		                facade.Delete(payrollItemModel.Id);
		                break;
                }
            }
        }

	    protected override void SaveUpdate()
		{
		    base.SaveUpdate();
		    var payrollGroup = PopulatePayrollGroupModelFromInterface();
            payrollGroup.Id = Convert.ToInt32(recordId.Text);
            payrollGroup.ModifiedBy = "";
            payrollGroup.ModifiedDate = DateTime.Now;
		    using (var facade = new EmployeeModuleCore())
		    {
				// TODO SAVE ACTION
				//facade.Update(payrollGroup);
				//ShowMessage(facade);
		    }
		}

		//protected override void DeleteRecord()
		//{
		//    base.DeleteRecord();
		//    var id = Convert.ToInt32(recordId.Text);
		//    using (var facade = new EmployeeCore())
		//    {
		//        facade.Delete(id);
		//        ShowMessage(facade);
		//    }
		//}

        private IPayrollGroupModel PopulatePayrollGroupModelFromInterface()
        {
            IPayrollGroupModel payrollGroup = new PayrollGroupModel();
            payrollGroup.Id = Convert.ToInt32((recordId.Text.Equals("") ? "0" : recordId.Text));
            payrollGroup.Name = groupName.Text;
            payrollGroup.Code = groupCode.Text;
            payrollGroup.Type = groupType.SelectedText;
            payrollGroup.Basic = Convert.ToDecimal(basicSalary.Text);
            payrollGroup.Unit = Convert.ToByte(unit.Text);
            payrollGroup.StartDate = startActiveDate.Value;
            payrollGroup.EndDate = endActiveDate.Value;
            payrollGroup.Description = description.Text;

            payrollGroup.CreatedBy = "";
            payrollGroup.CreatedDate = DateTime.Now;
            payrollGroup.ModifiedBy = "";
            payrollGroup.ModifiedDate = DateTime.Now;

            return payrollGroup;
        }
	}
}
