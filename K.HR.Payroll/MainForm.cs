using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using K.Common.UI.Forms;
using K.Common.UI.Panels;
using K.Common.UI.Patterns;
using K.HR.Payroll.Command;

namespace K.HR.Payroll
{
    public partial class MainForm : Form, IMainConfiguration
    {
        public MainForm()
        {
            InitializeComponent();
        	ListActiveObject = new List<ActiveObject>();
            Text = string.Format(@"K-Payroll Lite - {0}", Application.ProductVersion);
			treeView1.AfterSelect += TreeView1AfterSelect;
            CurrentUserName = "K-ON-DEV";
        }

        static void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
		    var treeNodeCommand = e.Node as TreeNodeCommand;
		    if (treeNodeCommand != null)
		        (treeNodeCommand).Command.ExecCommand();
		}

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        internal List<ActiveObject> ListActiveObject { get; set; }

        private void MainFormLoad(object sender, EventArgs e)
        {
        	TreeMenu.PopulateMenu(treeView1, this);
            treeView1.ExpandAll();
        }

        public Form CurrentMainForm
        {
            get { return this; }
        }

        public void ShowMaintain(UserControl maintainPanel)
        {
            var onList = false;
            for (var i = 0; i < splitContainerCenter.Panel2.Controls.Count; i++)
            {
                splitContainerCenter.Panel2.Controls.RemoveAt(i);
            }
            foreach (var a in ListActiveObject.Where(a => a.Name.Equals(maintainPanel.GetType().ToString()) && a.Index == ((MaintainBaseControl)maintainPanel).Index))
            {
                onList = true;
                splitContainerCenter.Panel2.Controls.Add(a.MaintainObject);
                maintainPanel.Dock = DockStyle.Fill;
                break;
            }
            if (onList) return;
            splitContainerCenter.Panel2.Controls.Add(maintainPanel);
            //((MaintainBaseControl)maintainPanel).FormParameter = formParameter;
            ((MaintainBaseControl)maintainPanel).CurrentMainForm = this;
            maintainPanel.Dock = DockStyle.Fill;
            ListActiveObject.Add(new ActiveObject
            {
                Name = maintainPanel.GetType().ToString(),
                //ListParameterForm = formParameter,
                MaintainObject = maintainPanel,
                Index = ((MaintainBaseControl)maintainPanel).Index
            });
        }
        
		public void ShowMaintain(UserControl maintainPanel, ListParameterBase formParameter)
		{
			var onList = false;
			for (var i = 0; i < splitContainerCenter.Panel2.Controls.Count; i++)
			{
				splitContainerCenter.Panel2.Controls.RemoveAt(i);
			}
			foreach (var a in ListActiveObject.Where(a => a.Name.Equals(maintainPanel.GetType().ToString()) && a.Index == ((MaintainBaseControl)maintainPanel).Index))
			{
				onList = true;
				splitContainerCenter.Panel2.Controls.Add(a.MaintainObject);
				maintainPanel.Dock = DockStyle.Fill;
				break;
			}
			if (onList) return;
			splitContainerCenter.Panel2.Controls.Add(maintainPanel);
			((MaintainBaseControl)maintainPanel).FormParameter = formParameter;
			((MaintainBaseControl)maintainPanel).CurrentMainForm = this;
			maintainPanel.Dock = DockStyle.Fill;
			ListActiveObject.Add(new ActiveObject
			{
				Name = maintainPanel.GetType().ToString(),
				ListParameterForm = formParameter,
				MaintainObject = maintainPanel,
				Index = ((MaintainBaseControl)maintainPanel).Index
			});
		}

        /// <summary>
        /// Registered Object 
        /// </summary>
        internal class ActiveObject
        {
            /// <summary>
            /// Name object
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Object Control
            /// </summary>
            public Control MaintainObject { get; set; }

            /// <summary>
            /// Parameter object biasa 
            /// </summary>
            public ListParameterBase ListParameterForm { get; set; }

            /// <summary>
            /// No urut index
            /// </summary>
            public int Index { get; set; }
        }

        public string CurrentUserName { get; set; }

    }
}
