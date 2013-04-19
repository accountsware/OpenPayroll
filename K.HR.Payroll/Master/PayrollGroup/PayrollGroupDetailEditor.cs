using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using K.Common.UI.Forms;
using K.Common.UI.Patterns;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Master.PayrollGroup
{
	public partial class PayrollGroupDetailEditor : EditorBase
	{
		public PayrollGroupDetailEditor()
		{
			InitializeComponent();
			comboBoxUnitType.SelectedValueChanged += ComboBoxUnitTypeSelectedValueChanged;
		}

		void ComboBoxUnitTypeSelectedValueChanged(object sender, EventArgs e)
		{
			switch (comboBoxUnitType.SelectedText)
			{
				case "BASE-ON-VALUE":
					kNumericTextBoxUnit.Enabled = false;
					kNumericTextBoxUnit.Text = "";
					break;
				case "PERCENTAGE-VALUE":
					kNumericTextBoxUnit.Enabled = true;
					break;
				case "UNIT-VALUE":
					kNumericTextBoxUnit.Enabled = true;
					break;
			}
		}

		internal DialogResult Create(Form form, IMaintainData maintaianControl)
		{
			MaintainData = maintaianControl;
			var maintainData = form as IMainConfiguration;
			if (maintainData != null)
			{
				//createdBy.Text = maintainData.CurrentUserName;
				//createdDate.Value = DateTime.Now;
			}
			DataStatus = 1;
			
			using (var editor = new BlankForm())
			{
				Text = string.Format("{0}Add Payroll Item", "");
				SetCreateButton();
				editor.ShowDialogEditor(form, this);
				return DialogResult;
			}
		}


		internal IPayrollItemModel PayrollItem
		{
			get
			{
				return new PayrollItemModel
				{
					CrudStatus = 1,
					Description = textBoxDescription.Text,
					ItemType = comboBoxItemType.Text,
					Name = textBoxName.Text,
					Id = 0,
					PayrolGroupId = 0,
					RowStatus = 0,
					Type = comboBoxUnitType.Text,
					Unit = string.IsNullOrEmpty(kNumericTextBoxUnit.Text) ? 0 : Convert.ToDecimal(kNumericTextBoxUnit.Text),
					Value = Convert.ToDecimal(kNumericTextBoxValue.Text)
				};
			}
		}

		private void PayrollGroupDetailEditorLoad(object sender, EventArgs e)
		{
			textBoxName.Focus();
		}
	}
}
