using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using K.Common.UI.Panels;
using K.HR.Payroll.Core;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Master.Cities
{
    public partial class CityMaintain : MaintainBaseControl
    {
        public CityMaintain()
        {
            InitializeComponent();
            ObjectName = "City";
            dataListView1.ShowGroups = false;
            dataListView1.MultiSelect = false;
            CurrentListView = dataListView1;
        }

        public override void RefreshList()
        {
            base.RefreshList();
            using (DataManager = new CityModuleCore())
            {
                BindDataSource<ICityModel>();
            }
        }

        protected override void ToolStripButtonNewClick(object sender, EventArgs e)
        {
            base.ToolStripButtonNewClick(sender, e);
            using (var editor = new CityEditor())
            {
                editor.Create(CurrentMainForm.CurrentMainForm, this);
            }
        }

        protected override void OpenItem()
        {
            base.OpenItem();
            if (!IsReadyEdited) return;
            using (var editor = new CityEditor())
            {
                editor.Edit(CurrentMainForm.CurrentMainForm, CurrentId, this);
            }
        }

        protected override void ToolStripButtonDeleteClick(object sender, EventArgs e)
        {
            base.ToolStripButtonDeleteClick(sender, e);
            if (!IsReadyEdited) return;
            using (var editor = new CityEditor())
            {
                editor.Delete(CurrentMainForm.CurrentMainForm, CurrentId, this);
            }
        }

        protected override void ComboBoxPagingSelectedIndexChanged(object sender, EventArgs e)
        {
            base.ComboBoxPagingSelectedIndexChanged(sender, e);
            BindDataSource<IEmployeeModel>();
        }

        protected override void PopulateListView<T>(IEnumerable<T> source)
        {
            dataListView1.Items.Clear();
            if (source == null) return;
	        var enumerable = source as IList<T> ?? source.ToList();
	        base.PopulateListView(enumerable);
            var tsource = enumerable.ToList();
            // TODO CONFIGUREABLE
            dataListView1.AlternateRowBackColor = Color.Khaki;
            dataListView1.DataSource = tsource;
        }

        protected override void ButtonFirstClick(object sender, EventArgs e)
        {
            base.ButtonFirstClick(sender, e);
            BindDataSource<IEmployeeModel>();
        }

        protected override void ButtonLastClick(object sender, EventArgs e)
        {
            base.ButtonLastClick(sender, e);
            BindDataSource<IEmployeeModel>();
        }

        protected override void ButtonNextClick(object sender, EventArgs e)
        {
            base.ButtonNextClick(sender, e);
            BindDataSource<IEmployeeModel>();
        }

        protected override void ButtonPreviousClick(object sender, EventArgs e)
        {
            base.ButtonPreviousClick(sender, e);
            BindDataSource<IEmployeeModel>();
        }

        protected override void DataListView1BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            base.DataListView1BeforeSorting(sender, e);
            if (SortCounter != 0)
            {
                e.Canceled = true;
                return;
            }
            SortCounter++;
            if (e.ColumnToSort == null) return;
            SortColumn = e.ColumnToSort.AspectName;
            SortDirection = GetSort(e.SortOrder);
            using (DataManager = new EmployeeModuleCore())
            {
                BindDataSource<IEmployeeModel>();
            }
        }
    }
}
