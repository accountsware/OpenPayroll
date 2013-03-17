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
            this.detailPanel1 = new K.Common.UI.Panels.DetailPanel();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnItemType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnUnit = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCreatedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.objectListView1);
            this.splitContainer1.Panel1.Controls.Add(this.detailPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupType);
            this.splitContainer1.Panel1.Controls.Add(this.description);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.endActiveDate);
            this.splitContainer1.Panel1.Controls.Add(this.startActiveDate);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.unit);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.basicSalary);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.groupName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.groupCode);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.recordId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(807, 482);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record Id";
            // 
            // recordId
            // 
            this.recordId.Location = new System.Drawing.Point(127, 23);
            this.recordId.Name = "recordId";
            this.recordId.Size = new System.Drawing.Size(245, 21);
            this.recordId.TabIndex = 0;
            // 
            // groupCode
            // 
            this.groupCode.Location = new System.Drawing.Point(544, 23);
            this.groupCode.Name = "groupCode";
            this.groupCode.Size = new System.Drawing.Size(245, 21);
            this.groupCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group Code";
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(127, 50);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(244, 21);
            this.groupName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Group Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Basic Salary";
            // 
            // basicSalary
            // 
            this.basicSalary.ColumnName = null;
            this.basicSalary.Location = new System.Drawing.Point(127, 77);
            this.basicSalary.Name = "basicSalary";
            this.basicSalary.Size = new System.Drawing.Size(244, 21);
            this.basicSalary.TabIndex = 4;
            this.basicSalary.TableName = null;
            // 
            // unit
            // 
            this.unit.ColumnName = null;
            this.unit.Location = new System.Drawing.Point(544, 77);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(245, 21);
            this.unit.TabIndex = 5;
            this.unit.TableName = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Start Active Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "End Active Date";
            // 
            // startActiveDate
            // 
            this.startActiveDate.Location = new System.Drawing.Point(127, 104);
            this.startActiveDate.Name = "startActiveDate";
            this.startActiveDate.Size = new System.Drawing.Size(244, 21);
            this.startActiveDate.TabIndex = 6;
            // 
            // endActiveDate
            // 
            this.endActiveDate.Location = new System.Drawing.Point(544, 101);
            this.endActiveDate.Name = "endActiveDate";
            this.endActiveDate.Size = new System.Drawing.Size(245, 21);
            this.endActiveDate.TabIndex = 7;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(127, 131);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(662, 63);
            this.description.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Description";
            // 
            // groupType
            // 
            this.groupType.FormattingEnabled = true;
            this.groupType.Items.AddRange(new object[] {
            "FULL MONTH",
            "TIME BASE"});
            this.groupType.Location = new System.Drawing.Point(544, 50);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(245, 21);
            this.groupType.TabIndex = 3;
            // 
            // detailPanel1
            // 
            this.detailPanel1.Location = new System.Drawing.Point(27, 200);
            this.detailPanel1.Name = "detailPanel1";
            this.detailPanel1.Size = new System.Drawing.Size(762, 27);
            this.detailPanel1.TabIndex = 19;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumnId);
            this.objectListView1.AllColumns.Add(this.olvColumnName);
            this.objectListView1.AllColumns.Add(this.olvColumnItemType);
            this.objectListView1.AllColumns.Add(this.olvColumnType);
            this.objectListView1.AllColumns.Add(this.olvColumnValue);
            this.objectListView1.AllColumns.Add(this.olvColumnUnit);
            this.objectListView1.AllColumns.Add(this.olvColumnDescription);
            this.objectListView1.AllColumns.Add(this.olvColumnCreatedDate);
            this.objectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnId,
            this.olvColumnName,
            this.olvColumnItemType,
            this.olvColumnType,
            this.olvColumnValue,
            this.olvColumnUnit,
            this.olvColumnDescription,
            this.olvColumnCreatedDate});
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point(27, 225);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.SelectAllOnControlA = false;
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(762, 193);
            this.objectListView1.TabIndex = 20;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnId
            // 
            this.olvColumnId.AspectName = "Id";
            this.olvColumnId.Groupable = false;
            this.olvColumnId.IsEditable = false;
            this.olvColumnId.IsVisible = false;
            this.olvColumnId.Text = "Record Id";
            this.olvColumnId.Width = 80;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.Groupable = false;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 170;
            // 
            // olvColumnItemType
            // 
            this.olvColumnItemType.AspectName = "ItemType";
            this.olvColumnItemType.Text = "Item Type";
            this.olvColumnItemType.Width = 89;
            // 
            // olvColumnType
            // 
            this.olvColumnType.AspectName = "Type";
            this.olvColumnType.Text = "Type";
            // 
            // olvColumnValue
            // 
            this.olvColumnValue.AspectName = "Value";
            this.olvColumnValue.Text = "Value";
            // 
            // olvColumnUnit
            // 
            this.olvColumnUnit.AspectName = "Unit";
            this.olvColumnUnit.Text = "Unit";
            // 
            // olvColumnDescription
            // 
            this.olvColumnDescription.AspectName = "Description";
            this.olvColumnDescription.Text = "Description";
            this.olvColumnDescription.Width = 141;
            // 
            // olvColumnCreatedDate
            // 
            this.olvColumnCreatedDate.AspectName = "CreatedDate";
            this.olvColumnCreatedDate.Text = "Created Date";
            this.olvColumnCreatedDate.Width = 95;
            // 
            // PayrollGroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 482);
            this.Name = "PayrollGroupEditor";
            this.Text = "PayrollGroupEditor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
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
        private Common.UI.Panels.DetailPanel detailPanel1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnId;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnItemType;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumnValue;
        private BrightIdeasSoftware.OLVColumn olvColumnUnit;
        private BrightIdeasSoftware.OLVColumn olvColumnDescription;
        private BrightIdeasSoftware.OLVColumn olvColumnCreatedDate;
	}
}