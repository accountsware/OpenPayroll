using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.Common.UI.Forms;
using K.Common.UI.Helpers;
using K.Common.UI.Patterns;
using K.HR.Payroll.Core;


namespace K.Common.UI.Panels
{
    [ToolboxItem(false)]
    public partial class MaintainBaseControl : UserControl, IMaintainData
    {

        public MaintainBaseControl()
        {
            InitializeComponent();
			comboBoxPaging.SelectedIndex = 1;
            buttonLast.Click += ButtonLastClick;
            buttonFirst.Click += ButtonFirstClick;
            buttonNext.Click += ButtonNextClick;
            buttonPrevious.Click += ButtonPreviousClick;
            comboBoxPaging.SelectedIndexChanged += ComboBoxPagingSelectedIndexChanged;
            toolStripButtonDelete.Click += ToolStripButtonDeleteClick;
            toolStripButtonExport.Click += ToolStripButtonExportClick;
            toolStripButtonFilter.Click += ToolStripButtonFilterClick;
            toolStripButtonNew.Click += ToolStripButtonNewClick;
            toolStripButtonOpen.Click += ToolStripButtonOpenClick;
            toolStripButtonRefresh.Click += ToolStripButtonRefreshClick;
            Load += MaintainBaseControlLoad;
			
			Index = 0;
            SortCounter = 0;
			DefaultPagingEnviroment();
        }
		
        public int Index { get; set; }
        public IMainConfiguration MainConfiguration { get; set; }
		protected PayrollBaseCore DataManager { get; set; }
		protected int CurrentPageIndex { get; set; }
		public int TotalIndex { get; set; }
		public ListParameterBase FormParameter { get; set; }
		public Form CMainForm { get; set; }
		public IFormConfiguration FormConfiguration { get; set; }
		public string DefaultParam { get; set; }
		//public EditorBase Editor { get; set; }
		public string SortColumn { get; set; }
		public string SortDirection { get; set; }
		int totalRecord;
		public DataListView CurrentListView { get; set; }
		public string ObjectName { get; set; }
        protected bool IsReadyEdited { get; set; }
        protected int SortCounter { get; set; }
        private Button lastButtonNavigator;

        protected virtual void DataListView1AfterSorting(object sender, AfterSortingEventArgs e)
        {
            SortCounter--;
        }

        protected virtual void DataListView1BeforeSorting(object sender, BeforeSortingEventArgs e)
        {
        }

		protected virtual void MaintainBaseControlLoad(object sender, EventArgs e)
		{
			if (CurrentListView == null) return;
			CurrentListView.BeforeSorting += DataListView1BeforeSorting;
			CurrentListView.AfterSorting += DataListView1AfterSorting;
			CurrentListView.DoubleClick += CurrentListViewDoubleClick;
			CurrentListView.KeyDown += CurrentListViewKeyDown;
		}

		void CurrentListViewKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Enter:
					OpenItem();
					break;
				case Keys.Delete:
					ToolStripButtonDeleteClick(sender, e);
					break;
				case Keys.PageDown:
					if (buttonNext.Enabled) ButtonNextClick(sender, e);
					break;
				case Keys.PageUp:
					if (buttonPrevious.Enabled) ButtonPreviousClick(sender, e);
					break;
				case Keys.End:
					if (buttonLast.Enabled) ButtonLastClick(sender, e);
					break;
				case Keys.Home:
					if (buttonFirst.Enabled) ButtonFirstClick(sender, e);
					break;
			}
		}

		void CurrentListViewDoubleClick(object sender, EventArgs e)
		{
			OpenItem();
		}

		//void DataManager_ErrorEventHandler(object sender, OnErrorArgs e)
		//{
		//    MsgHelpers.ShowError(this, e.CException.Message);
		//}

        public void SetTitle(string title)
        {
            label1.Text = string.Format("  {0}", title);
        }

		protected virtual List<T> PopulateDataSource<T>() where T : IBaseModel
		{
			var param = FormParameter == null ? null : FormParameter.GetQueryParameter().ToArray();
			return DataManager.Get<T>((CurrentPageIndex )* GetLimit(), GetLimit(), SortColumn, SortDirection, out totalRecord, param) as List<T>;
		}

		protected virtual void BindDataSource<T>() where T : IBaseModel
		{
			if (DataManager == null)
			{
				MsgHelpers.ShowError(CMainForm, "Error", " paging manager is not initialized");
				return;
			}
			//DataManager.ErrorEventHandler += DataManager_ErrorEventHandler;
			var source = PopulateDataSource<T>();

			if (source == null) return;
			Application.DoEvents();
			// TODO SET DATA SOURCE
			PopulateListView(source);
		    if (lastButtonNavigator != null) lastButtonNavigator.Enabled = true;
			SetPagingEnviroment();
		}

		/// <summary>
		/// Must Be Implement in every maintain control
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		protected virtual void PopulateListView<T>(IEnumerable<T> source) where T : IBaseModel
    	{
    	}

		protected string GetSort(SortOrder sort)
		{
			return sort == SortOrder.Ascending ? "ASC" : "DESC";
		}

    	private void SetPagingEnviroment()
		{
			var displayedRecord = CurrentPageIndex + 1;

			TotalIndex = totalRecord / GetLimit();
			if (totalRecord - (TotalIndex * GetLimit()) > 0)
				TotalIndex++;

			labelStatus.Text = totalRecord == 0 ?
				string.Format("No Record {0} Displaying", ObjectName) :
				string.Format("Displaying {0} {1} of {2} Pages", ObjectName, displayedRecord, TotalIndex);
            buttonFirst.Enabled = CurrentPageIndex != 0;
			buttonPrevious.Enabled = CurrentPageIndex != 0;
			buttonNext.Enabled = CurrentPageIndex < (TotalIndex - 1);
            buttonLast.Enabled = CurrentPageIndex < (TotalIndex - 1);
		}

		private void DefaultPagingEnviroment()
		{
			labelStatus.Text = "";
			buttonLast.Enabled = false;
			buttonPrevious.Enabled = false;
			buttonNext.Enabled = false;
			buttonFirst.Enabled = false;
			TotalIndex = 0;
			CurrentPageIndex = 0;
		}

        protected virtual void ToolStripButtonRefreshClick(object sender, EventArgs e)
        {
            RefreshList();
        }

        protected virtual void ToolStripButtonOpenClick(object sender, EventArgs e)
        {
            OpenItem();
        }

        protected virtual void OpenItem()
        {
            ValidateOpenItem();
        }

        protected void ValidateOpenItem()
        {
            if (CurrentListView == null)
            {
                MsgHelpers.ShowError(this, "Data List not define");
                IsReadyEdited = false;
                return;
            }
            if (CurrentListView.Items.Count == 0)
            {
                MsgHelpers.ShowError(this, "No Data in List");
                IsReadyEdited = false;
                return;
            }
            if (CurrentListView.FocusedItem == null)
            {
                MsgHelpers.ShowError(this, "No item selected");
                IsReadyEdited = false;
                return;
            }
            IsReadyEdited = true;
        }

        protected virtual void ToolStripButtonNewClick(object sender, EventArgs e)
        {
        }

        protected virtual void ToolStripButtonFilterClick(object sender, EventArgs e)
        {
            if (FormParameter == null) return;
            FormParameter.Show(MainConfiguration.CurrentMainForm);
        }

        protected virtual void ToolStripButtonExportClick(object sender, EventArgs e)
        {
        }

        protected virtual void ToolStripButtonDeleteClick(object sender, EventArgs e)
        {
            ValidateOpenItem();
        }

        protected virtual void ComboBoxPagingSelectedIndexChanged(object sender, EventArgs e)
        {
			CurrentPageIndex = 0;
        }

        protected virtual void ButtonPreviousClick(object sender, EventArgs e)
        {
			CurrentPageIndex--;
			lastButtonNavigator = buttonPrevious;
			buttonPrevious.Enabled = false;
        }

    	protected virtual void ButtonNextClick(object sender, EventArgs e)
        {
			CurrentPageIndex++;
			lastButtonNavigator = buttonNext;
			buttonNext.Enabled = false;
        }

    	protected virtual void ButtonLastClick(object sender, EventArgs e)
    	{
			CurrentPageIndex = (TotalIndex - 1);
			lastButtonNavigator = buttonLast;
			buttonLast.Enabled = false;
    	}

    	protected virtual void ButtonFirstClick(object sender, EventArgs e)
    	{
			CurrentPageIndex = 0;
			lastButtonNavigator = buttonFirst;
			buttonFirst.Enabled = false;
    	}

    	protected void SetButtonEnabled(object sender, bool value)
        {
            ((Button) sender).Enabled = value;
        }

		private int GetLimit()
		{
			try
			{
				return Convert.ToInt32(comboBoxPaging.Text);
			}
			catch
			{
				// TODO CONFIGUREABLE
				return 20;
			}
		}

        protected int CurrentId
        {
            get { return Convert.ToInt32(CurrentListView.FocusedItem.Text); }
        }

        public virtual void RefreshList()
        {
        }

    }
}
