namespace K.HR.Payroll.Master.PayrollGroup
{
	partial class PayrollGroupEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.recordId = new System.Windows.Forms.TextBox();
            this.groupCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.basicSalary = new K.Common.UI.Forms.KNumericTextBox(this.components);
            this.unit = new K.Common.UI.Forms.KNumericTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startActiveDate = new System.Windows.Forms.DateTimePicker();
            this.endActiveDate = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupType = new System.Windows.Forms.ComboBox();
            this.splitContainerMainContent = new System.Windows.Forms.SplitContainer();
            this.kDataGridView1 = new K.Common.UI.Forms.KDataGridView(this.components);
            this.payrollItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payrolGroupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrudStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainContent)).BeginInit();
            this.splitContainerMainContent.Panel1.SuspendLayout();
            this.splitContainerMainContent.Panel2.SuspendLayout();
            this.splitContainerMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollItemModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerMainContent);
            this.splitContainer1.Size = new System.Drawing.Size(939, 529);
            this.splitContainer1.SplitterDistance = 473;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record Id";
            // 
            // recordId
            // 
            this.recordId.Location = new System.Drawing.Point(147, 18);
            this.recordId.Name = "recordId";
            this.recordId.Size = new System.Drawing.Size(285, 22);
            this.recordId.TabIndex = 0;
            // 
            // groupCode
            // 
            this.groupCode.Location = new System.Drawing.Point(633, 18);
            this.groupCode.Name = "groupCode";
            this.groupCode.Size = new System.Drawing.Size(285, 22);
            this.groupCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group Code";
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(147, 47);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(284, 22);
            this.groupName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Group Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Basic Salary";
            // 
            // basicSalary
            // 
            this.basicSalary.ColumnName = null;
            this.basicSalary.Location = new System.Drawing.Point(147, 76);
            this.basicSalary.Name = "basicSalary";
            this.basicSalary.Size = new System.Drawing.Size(284, 22);
            this.basicSalary.TabIndex = 4;
            this.basicSalary.TableName = null;
            // 
            // unit
            // 
            this.unit.ColumnName = null;
            this.unit.Location = new System.Drawing.Point(633, 76);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(285, 22);
            this.unit.TabIndex = 5;
            this.unit.TableName = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Start Active Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "End Active Date";
            // 
            // startActiveDate
            // 
            this.startActiveDate.Location = new System.Drawing.Point(147, 106);
            this.startActiveDate.Name = "startActiveDate";
            this.startActiveDate.Size = new System.Drawing.Size(284, 22);
            this.startActiveDate.TabIndex = 6;
            // 
            // endActiveDate
            // 
            this.endActiveDate.Location = new System.Drawing.Point(633, 102);
            this.endActiveDate.Name = "endActiveDate";
            this.endActiveDate.Size = new System.Drawing.Size(285, 22);
            this.endActiveDate.TabIndex = 7;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(147, 135);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(772, 68);
            this.description.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "Description";
            // 
            // groupType
            // 
            this.groupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupType.FormattingEnabled = true;
            this.groupType.Items.AddRange(new object[] {
            "FULL MONTH",
            "TIME BASE"});
            this.groupType.Location = new System.Drawing.Point(633, 47);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(285, 22);
            this.groupType.TabIndex = 3;
            // 
            // splitContainerMainContent
            // 
            this.splitContainerMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMainContent.IsSplitterFixed = true;
            this.splitContainerMainContent.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMainContent.Name = "splitContainerMainContent";
            this.splitContainerMainContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainContent.Panel1
            // 
            this.splitContainerMainContent.Panel1.Controls.Add(this.label1);
            this.splitContainerMainContent.Panel1.Controls.Add(this.groupType);
            this.splitContainerMainContent.Panel1.Controls.Add(this.recordId);
            this.splitContainerMainContent.Panel1.Controls.Add(this.description);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label2);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label9);
            this.splitContainerMainContent.Panel1.Controls.Add(this.groupCode);
            this.splitContainerMainContent.Panel1.Controls.Add(this.endActiveDate);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label3);
            this.splitContainerMainContent.Panel1.Controls.Add(this.startActiveDate);
            this.splitContainerMainContent.Panel1.Controls.Add(this.groupName);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label8);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label4);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label7);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label5);
            this.splitContainerMainContent.Panel1.Controls.Add(this.unit);
            this.splitContainerMainContent.Panel1.Controls.Add(this.basicSalary);
            this.splitContainerMainContent.Panel1.Controls.Add(this.label6);
            // 
            // splitContainerMainContent.Panel2
            // 
            this.splitContainerMainContent.Panel2.Controls.Add(this.kDataGridView1);
            this.splitContainerMainContent.Size = new System.Drawing.Size(939, 473);
            this.splitContainerMainContent.SplitterDistance = 217;
            this.splitContainerMainContent.TabIndex = 21;
            // 
            // kDataGridView1
            // 
            this.kDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.kDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kDataGridView1.AutoGenerateColumns = false;
            this.kDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.kDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.kDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rowStatusDataGridViewTextBoxColumn,
            this.rowVersionDataGridViewImageColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.modifiedByDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.payrolGroupIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.CrudStatusColumn});
            this.kDataGridView1.DataSource = this.payrollItemModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.kDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kDataGridView1.GridColor = System.Drawing.Color.Black;
            this.kDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kDataGridView1.MultiSelect = false;
            this.kDataGridView1.Name = "kDataGridView1";
            this.kDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.kDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kDataGridView1.RowTemplate.Height = 20;
            this.kDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kDataGridView1.Size = new System.Drawing.Size(939, 252);
            this.kDataGridView1.TabIndex = 20;
            // 
            // payrollItemModelBindingSource
            // 
            this.payrollItemModelBindingSource.DataSource = typeof(K.HR.Payroll.Model.PayrollItemModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // rowStatusDataGridViewTextBoxColumn
            // 
            this.rowStatusDataGridViewTextBoxColumn.DataPropertyName = "RowStatus";
            this.rowStatusDataGridViewTextBoxColumn.HeaderText = "RowStatus";
            this.rowStatusDataGridViewTextBoxColumn.Name = "rowStatusDataGridViewTextBoxColumn";
            this.rowStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // rowVersionDataGridViewImageColumn
            // 
            this.rowVersionDataGridViewImageColumn.DataPropertyName = "RowVersion";
            this.rowVersionDataGridViewImageColumn.HeaderText = "RowVersion";
            this.rowVersionDataGridViewImageColumn.Name = "rowVersionDataGridViewImageColumn";
            this.rowVersionDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rowVersionDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rowVersionDataGridViewImageColumn.Visible = false;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedByDataGridViewTextBoxColumn
            // 
            this.modifiedByDataGridViewTextBoxColumn.DataPropertyName = "ModifiedBy";
            this.modifiedByDataGridViewTextBoxColumn.HeaderText = "ModifiedBy";
            this.modifiedByDataGridViewTextBoxColumn.Name = "modifiedByDataGridViewTextBoxColumn";
            this.modifiedByDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // payrolGroupIdDataGridViewTextBoxColumn
            // 
            this.payrolGroupIdDataGridViewTextBoxColumn.DataPropertyName = "PayrolGroupId";
            this.payrolGroupIdDataGridViewTextBoxColumn.HeaderText = "PayrolGroupId";
            this.payrolGroupIdDataGridViewTextBoxColumn.Name = "payrolGroupIdDataGridViewTextBoxColumn";
            this.payrolGroupIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 180;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemTypeDataGridViewTextBoxColumn.Width = 140;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 80;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 120;
            // 
            // CrudStatusColumn
            // 
            this.CrudStatusColumn.DataPropertyName = "CrudStatus";
            this.CrudStatusColumn.HeaderText = "CrudStatus";
            this.CrudStatusColumn.Name = "CrudStatusColumn";
            this.CrudStatusColumn.Visible = false;
            // 
            // PayrollGroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 529);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PayrollGroupEditor";
            this.Text = "Payroll Group Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerMainContent.Panel1.ResumeLayout(false);
            this.splitContainerMainContent.Panel1.PerformLayout();
            this.splitContainerMainContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainContent)).EndInit();
            this.splitContainerMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollItemModelBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Common.UI.Forms.KNumericTextBox unit;
		private System.Windows.Forms.Label label6;
		private Common.UI.Forms.KNumericTextBox basicSalary;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox groupName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox groupCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox recordId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker endActiveDate;
		private System.Windows.Forms.DateTimePicker startActiveDate;
		private System.Windows.Forms.TextBox description;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox groupType;
        private System.Windows.Forms.SplitContainer splitContainerMainContent;
        private System.Windows.Forms.BindingSource payrollItemModelBindingSource;
        private Common.UI.Forms.KDataGridView kDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowVersionDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrolGroupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrudStatusColumn;
	}
}