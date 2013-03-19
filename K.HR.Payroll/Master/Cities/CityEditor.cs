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

namespace K.HR.Payroll.Master.Cities
{
    public partial class CityEditor : EditorBase
    {
        public CityEditor()
        {
            InitializeComponent();
        }

        internal void Edit(Form form, int id, IMaintainData maintaianControl)
        {
            MaintainData = maintaianControl;
            DataStatus = 2;
            using (var editor = new BlankForm())
            {
                Text = string.Format("{0}Edit Employee", "");
                PopulateInterfaceFromModel(id);
                var maintainData = form as IMainConfiguration;
                if (maintainData != null)
                {
                    modifiedBy.Text = maintainData.CurrentUserName;
                    modifiedDate.Value = DateTime.Now;
                }
                SetEditButton();
                editor.ShowDialogEditor(form, this);
            }
        }

        private void PopulateInterfaceFromModel(int id)
        {
            using (var facade = new CityModuleCore())
            {
                var city = facade.Get<ICityModel>(WhereTerm.DefaultParam(id, "ID")).FirstOrDefault();
                if (city == null || !facade.IsSuccess)
                {
                    MsgHelpers.ShowError(this, string.IsNullOrEmpty(facade.Message) ? "Employee not found" : facade.Message);
                    return;
                }
                recordId.Text = city.Id.ToString();
                cityName.Text = city.CityName;
                createdBy.Text = city.CreatedBy;
                createdDate.Value = city.CreatedDate;
                modifiedBy.Text = city.ModifiedBy;
                if (city.ModifiedDate != null) modifiedDate.Value = (DateTime) city.ModifiedDate;
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
            var city = PopulateCityModelFromInterface();
            using (var facade = new CityModuleCore())
            {
                facade.Save(city);
                ShowMessage(facade);
            }
        }

        protected override void SaveUpdate()
        {
            base.SaveUpdate();
            var city = PopulateCityModelFromInterface();
            city.Id = Convert.ToInt32(recordId.Text);
            city.ModifiedBy = modifiedBy.Text;
            city.ModifiedDate = modifiedDate.Value;
            using (var facade = new CityModuleCore())
            {
                facade.Update(city);
                ShowMessage(facade);
            }
        }

        protected override void DeleteRecord()
        {
            base.DeleteRecord();
            var id = Convert.ToInt32(recordId.Text);
            using (var facade = new CityModuleCore())
            {
                facade.Delete(id);
                ShowMessage(facade);
            }
        }

        private ICityModel PopulateCityModelFromInterface()
        {
            ICityModel city = new CityModel();
            city.CityName       = cityName.Text;
            city.CreatedBy      = createdBy.Text;
            city.CreatedDate    = createdDate.Value;
            city.ModifiedBy     = modifiedBy.Text;
            city.ModifiedDate   = modifiedDate.Value;
            city.RowStatus      = 0;
            return city;
        }

        internal void Create(Form form, IMaintainData maintaianControl)
        {
            MaintainData = maintaianControl;
            var maintainData = form as IMainConfiguration;
            if (maintainData != null)
            {
                createdBy.Text = maintainData.CurrentUserName;
                createdDate.Value = DateTime.Now;
                modifiedBy.Text = maintainData.CurrentUserName;
                modifiedDate.Value = DateTime.Now;
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
