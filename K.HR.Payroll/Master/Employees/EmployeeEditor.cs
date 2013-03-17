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

namespace K.HR.Payroll.Master.Employees
{
    public partial class EmployeeEditor : EditorBase
    {
        public EmployeeEditor()
        {
            InitializeComponent();
        	PopulatePosition();
        }

    	private void PopulatePosition()
    	{
    		using (var position = new PositionCore())
    		{
				var source = position.Get<IPositionModel>();
    			positionName.DisplayMember = "PositionName";
				positionName.ValueMember = "Id";
				if (source != null)
    				positionName.DataSource = source.OrderBy(a => a.PositionName).ToList();
    		}
    	}

    	internal void Edit(Form form, int id, IMaintainData maintaianControl)
        {
            MaintainData = maintaianControl;
            DataStatus = 2;
            using (var editor = new BlankForm())
            {
                Text = string.Format("{0}Edit Employee", "");
                PopulateInterfaceFromModel(id);
                SetEditButton();
                editor.ShowDialogEditor(form, this);
            }
        }

        private void PopulateInterfaceFromModel(int id)
        {
            using(var facade = new EmployeeCore())
            {
                var employee = facade.Get<IEmployeeModel>(WhereTerm.DefaultParam(id, "ID")).FirstOrDefault();
                if (employee == null || !facade.IsSuccess)
                {
                    MsgHelpers.ShowError(this, string.IsNullOrEmpty(facade.Message) ? "Employee not found" : facade.Message);
                    return;
                }
                address.Text = employee.Address;
                bankAccount.Text = employee.BankAccount ;
                bankName.Text = employee.BankName;
                birthDate.Value = employee.BirthDate;
                cityName.Text = employee.City;
                createdBy.Text = employee.CreatedBy;
                createdDate.Value = employee.CreatedDate;
                firstName.Text = employee.FirstName;
                gender.Text = employee.Gender;
                hireDate.Value = employee.HiredDate;
                recordId.Text = employee.Id.ToString();
                lastName.Text = employee.LastName;
                maritalStatus.Text = employee.MaritalStatus;
                middleName.Text = employee.MiddleName;
                nationalIdNumber.Text = employee.NationalIDNumber;
                payrollGroupCode.Text = employee.PayrollGroupCode;
                positionName.Text = employee.PositionName;
                postalCode.Text = employee.PostalCode;
                stateName.Text = employee.State;
                titleName.Text = employee.Title;
                createdBy.Text = employee.CreatedBy;
                createdDate.Value = employee.CreatedDate;
                modifiedBy.Text = employee.ModifiedBy;
                modifiedDate.Value = employee.ModifiedDate.HasValue ? employee.ModifiedDate.Value : DateTime.Now;
                employeeId.Text = employee.EmployeeID;
                isTerminate.Text = employee.IsTerminate.ToString();
                terminateDate.Value = employee.TerminateDate.HasValue ? employee.TerminateDate.Value : DateTime.Now;
                terminateDate.Checked = employee.TerminateDate.HasValue;
                terminateDescription.Text = employee.TerminateDescription;
            }
        }

        internal void Delete(Form form, int id, IMaintainData maintaianControl)
        {
            MaintainData = maintaianControl;
            DataStatus = 3;
            using (var editor = new BlankForm())
            {
                Text = string.Format("{0}Delete Employee", "");
                PopulateInterfaceFromModel(id);
                SetDeleteButton();
                editor.ShowDialogEditor(form, this);
            }
        }

        protected override void Save()
        {
            base.Save();
            var employee = PopulateEmployeeModelFromInterface();
            using(var facade = new EmployeeCore())
            {
                facade.Save(employee);
                ShowMessage(facade);
            }
        }

        protected override void SaveUpdate()
        {
            base.SaveUpdate();
            var employee = PopulateEmployeeModelFromInterface();
            employee.Id = Convert.ToInt32(recordId.Text);
            employee.ModifiedBy = modifiedBy.Text;
            employee.ModifiedDate = modifiedDate.Value;
            using (var facade = new EmployeeCore())
            {
                facade.Update(employee);
                ShowMessage(facade);
            }
        }

        protected override void DeleteRecord()
        {
            base.DeleteRecord();
            var id = Convert.ToInt32(recordId.Text);
            using (var facade = new EmployeeCore())
            {
                facade.Delete(id);
                ShowMessage(facade);
            }
        }

        private IEmployeeModel PopulateEmployeeModelFromInterface()
        {
            IEmployeeModel employee = new EmployeeModel();
            employee.Address = address.Text;
            employee.BankAccount = bankAccount.Text;
            employee.BankName = bankName.Text;
            employee.BirthDate = birthDate.Value;
            employee.City = cityName.Text;
            employee.CreatedBy = createdBy.Text;
            employee.CreatedDate = createdDate.Value;
            employee.FirstName = firstName.Text;
            employee.Gender = gender.Text;
            employee.HiredDate = hireDate.Value;
			employee.Id = Convert.ToInt32(recordId.Text); 
            employee.LastName = lastName.Text;
        	employee.ModifiedBy = modifiedBy.Text;
        	employee.ModifiedDate = modifiedDate.Value;
            employee.MaritalStatus = maritalStatus.Text;
            employee.MiddleName = middleName.Text;
            employee.NationalIDNumber = nationalIdNumber.Text;
            employee.PayrollGroupCode = payrollGroupCode.Text;
            employee.PositionName = positionName.Text;
            employee.PostalCode = postalCode.Text;
            employee.State = stateName.Text;
            employee.Title = titleName.Text;
            employee.EmployeeID = employeeId.Text;
            bool b;
            Boolean.TryParse(isTerminate.Text, out b);
            employee.IsTerminate = b;
            employee.TerminateDate = terminateDate.Checked ? (DateTime?)terminateDate.Value : null;
            employee.TerminateDescription = terminateDescription.Text;
            return employee;
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
                Text = string.Format("{0}Create New Employee", "");
                SetCreateButton();
                editor.ShowDialogEditor(form, this);
            }
        }
    }
}
