using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using K.Common.Helpers;
using K.Common.Patterns;
using K.Common.UI.Forms;
using K.Common.UI.Helpers;
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

		private IMainConfiguration mainConfiguration;

	    internal void Create(Form form, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			mainConfiguration = form as IMainConfiguration;
			DataStatus = 1;
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Create New Payroll Group", "");
				SetCreateButton();
				recordId.Text = DefaultValue.AUTO_GENERATE_TEXT;
				recordId.ReadOnly = true;
			    LoadComboItem();
                //kDataGridView1.UserAddedRow += KDataGridView1UserAddedRow;
                kDataGridView1.RowsAdded += KDataGridView1RowsAdded;
                kDataGridView1.CellEndEdit += KDataGridView1CellEndEdit;
                kDataGridView1.UserDeletingRow += KDataGridView1UserDeletingRow;
				editor.ShowDialogEditor(form, this);
			}
		}

        void KDataGridView1RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (kDataGridView1.Rows[e.RowIndex].Cells[DefaultValue.CRUD_STATUS] == null) return;
            kDataGridView1.Rows[e.RowIndex].Cells[DefaultValue.CRUD_STATUS].Value = 1;
        }

	    static void KDataGridView1UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var crudValue = Convert.ToInt32(e.Row.Cells[DefaultValue.CRUD_STATUS].Value);
            if (crudValue == 1)
            {
                e.Cancel = false;
            }
            if (crudValue == 0 || crudValue == 2)
            {
                e.Row.DefaultCellStyle.BackColor = Color.Red;
                e.Row.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                e.Row.Cells[DefaultValue.CRUD_STATUS].Value = 3;
            }
	        if (crudValue != 3) return;
	        e.Row.DefaultCellStyle.BackColor = Color.White;
	        e.Row.DefaultCellStyle.ForeColor = Color.Black;
	        e.Row.Cells[DefaultValue.CRUD_STATUS].Value = 2;
	        e.Cancel = true;
        }

	    static void KDataGridView1UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }


        void KDataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (kDataGridView1.Rows[e.RowIndex].IsNewRow) return;
            if (Convert.ToInt32(kDataGridView1.Rows[e.RowIndex].Cells[DefaultValue.CRUD_STATUS].Value) == 0)
                kDataGridView1.Rows[e.RowIndex].Cells[DefaultValue.CRUD_STATUS].Value = 2;
        }

	    private void LoadComboItem()
	    {
	        var comboType = kDataGridView1.Columns["typeDataGridViewTextBoxColumn"] as DataGridViewComboBoxColumn;
	        if (comboType != null)
	        {
	            comboType.DataSource = PayrollCore.GetTypeItem();
	        }

            var comboUnitItemType = kDataGridView1.Columns["itemTypeDataGridViewTextBoxColumn"] as DataGridViewComboBoxColumn;
            if (comboUnitItemType != null)
            {
                comboUnitItemType.DataSource = PayrollCore.GetUnitTypeItem();
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
            try
            {
                base.Save();
                CurrentDate = DateTime.Now;
                var payrollgroup = PopulatePayrollGroupModelFromInterface();
                payrollgroup.ListPayrollItemModel = PopulatePayrolItem();
                using (var facade = new PayrollGroupCore())
                {
                    // TODO SAVE TRANSACTION
                    facade.Save(payrollgroup);
                }
            }
            catch (Exception err)
            {
                MsgHelpers.ShowError(this, err);
            }
		}

        private IList<IPayrollItemModel> PopulatePayrolItem()
        {
            return (from DataGridViewRow row in kDataGridView1.Rows
                    select new PayrollItemModel
                    {
                        CreatedBy = mainConfiguration.CurrentUserName,
                        CreatedDate = CurrentDate,
                        CrudStatus = kDataGridView1.GetRowValue(row, DefaultValue.CRUD_STATUS, (byte)0),
                        Description = kDataGridView1.GetRowValue(row, "descriptionDataGridViewTextBoxColumn", string.Empty),
                        Id = kDataGridView1.GetRowValue(row, "idDataGridViewTextBoxColumn", 0),
                        ItemType = kDataGridView1.GetRowValue(row, "itemTypeDataGridViewTextBoxColumn", string.Empty),
                        Name = kDataGridView1.GetRowValue(row, "nameDataGridViewTextBoxColumn", string.Empty),
                        PayrolGroupId = 0,
                        RowStatus = 0,
                        RowVersion = kDataGridView1.GetRowValue(row, "rowVersionDataGridViewImageColumn", (byte[])null),
                        Type = kDataGridView1.GetRowValue(row, "typeDataGridViewTextBoxColumn", string.Empty),
                        Unit = kDataGridView1.GetRowValue(row, "unitDataGridViewTextBoxColumn", 0),
                        Value = kDataGridView1.GetRowValue(row, "valueDataGridViewTextBoxColumn", 0)
                    }).Cast<IPayrollItemModel>().ToList();
        }

	    protected void SaveDetail(int parentId) 
        {
            //var facade = new PayrollItemModuleCore();
            //if (objectListView1.Items.Count <= 0) return;
            //for (var i = 0; i < objectListView1.Items.Count; i++ )
            //{
            //    var payrollItemModel = (IPayrollItemModel) objectListView1.GetModelObject(i);
            //    payrollItemModel.Id = parentId;
            //    switch (payrollItemModel.CrudStatus)
            //    {
            //        case 1:
            //            facade.Save(payrollItemModel);
            //            break;
            //        case 2:
            //            facade.Update(payrollItemModel);
            //            break;
            //        case 3:
            //            facade.Delete(payrollItemModel.Id);
            //            break;
            //    }
            //}
        }

	    protected override void SaveUpdate()
		{
		    base.SaveUpdate();
		    var payrollGroup = PopulatePayrollGroupModelFromInterface();
            payrollGroup.Id = Convert.ToInt32(recordId.Text);
            payrollGroup.ModifiedBy = "";
            payrollGroup.ModifiedDate = DateTime.Now;
		    using (var facade = new EmployeeCore())
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
            var payrollGroup = new PayrollGroupModel
                {
                    Id = Convert.ToInt32((recordId.Text.Equals(DefaultValue.AUTO_GENERATE_TEXT) ? "0" : recordId.Text)),
                    Name = groupName.Text,
                    Code = groupCode.Text,
                    Type = groupType.SelectedText,
                    Basic = Convert.ToDecimal(basicSalary.Text),
                    Unit = Convert.ToByte(unit.Text),
                    StartDate = startActiveDate.Value,
                    EndDate = endActiveDate.Value,
                    Description = description.Text,
                    CreatedBy = mainConfiguration.CurrentUserName,
                    CreatedDate = CurrentDate
                };

            return payrollGroup;
        }
	}
}
