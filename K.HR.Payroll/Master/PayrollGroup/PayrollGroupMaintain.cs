using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using K.Common.UI.Panels;
using K.HR.Payroll.Core;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Master.PayrollGroup
{
	public partial class PayrollGroupMaintain : MaintainBaseControl
	{
		public PayrollGroupMaintain()
		{
			InitializeComponent();
			ObjectName = "Payroll Group";
			dataListView1.ShowGroups = false;
			dataListView1.MultiSelect = false;
			CurrentListView = dataListView1;
		}

		public override void RefreshList()
		{
			base.RefreshList();
			using (DataManager = new PayrollGroupModuleCore())
			{
				BindDataSource<IPayrollGroupModel>();
			}
		}

		protected override void ToolStripButtonNewClick(object sender, EventArgs e)
		{
			base.ToolStripButtonNewClick(sender, e);
			using (var editor = new PayrollGroupEditor())
			{
				editor.Create(MainConfiguration.CurrentMainForm, this);
			}
		}

		protected override void OpenItem()
		{
			base.OpenItem();
			if (!IsReadyEdited) return;
			using (var editor = new PayrollGroupEditor())
			{
				editor.Edit(MainConfiguration.CurrentMainForm, CurrentId, this);
			}
		}

		protected override void ToolStripButtonDeleteClick(object sender, EventArgs e)
		{
			base.ToolStripButtonDeleteClick(sender, e);
			if (!IsReadyEdited) return;
			using (var editor = new PayrollGroupEditor())
			{
				editor.Delete(MainConfiguration.CurrentMainForm, CurrentId, this);
			}
		}

		protected override void ComboBoxPagingSelectedIndexChanged(object sender, EventArgs e)
		{
			base.ComboBoxPagingSelectedIndexChanged(sender, e);
			BindDataSource<IPayrollGroupModel>();
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
			BindDataSource<IPayrollGroupModel>();
		}

		protected override void ButtonLastClick(object sender, EventArgs e)
		{
			base.ButtonLastClick(sender, e);
			BindDataSource<IPayrollGroupModel>();
		}

		protected override void ButtonNextClick(object sender, EventArgs e)
		{
			base.ButtonNextClick(sender, e);
			BindDataSource<IPayrollGroupModel>();
		}

		protected override void ButtonPreviousClick(object sender, EventArgs e)
		{
			base.ButtonPreviousClick(sender, e);
			BindDataSource<IPayrollGroupModel>();
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
			using (DataManager = new PayrollGroupModuleCore())
			{
				BindDataSource<IPayrollGroupModel>();
			}
		}
	}
}
