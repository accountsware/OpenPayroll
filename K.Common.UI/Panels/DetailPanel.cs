using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K.Common.UI.Panels
{
	public partial class DetailPanel : UserControl
	{
		public DetailPanel()
		{
			InitializeComponent();
		}

        public ToolStripButton GetAddButton()
        {
            return toolStripButtonAdd;
        }


	}
}
