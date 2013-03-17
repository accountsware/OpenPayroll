namespace K.HR.Payroll.Master.PayrollGroup
{
	partial class PayrollGroupMaintain
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataListView1 = new BrightIdeasSoftware.DataListView();
			this.olvColumnRecordId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnBasicSalary = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnUnit = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnStartDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnEndDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumnDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataListView1
			// 
			this.dataListView1.AllColumns.Add(this.olvColumnRecordId);
			this.dataListView1.AllColumns.Add(this.olvColumnCode);
			this.dataListView1.AllColumns.Add(this.olvColumnName);
			this.dataListView1.AllColumns.Add(this.olvColumnType);
			this.dataListView1.AllColumns.Add(this.olvColumnBasicSalary);
			this.dataListView1.AllColumns.Add(this.olvColumnUnit);
			this.dataListView1.AllColumns.Add(this.olvColumnStartDate);
			this.dataListView1.AllColumns.Add(this.olvColumnEndDate);
			this.dataListView1.AllColumns.Add(this.olvColumnDescription);
			this.dataListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnRecordId,
            this.olvColumnCode,
            this.olvColumnName,
            this.olvColumnType,
            this.olvColumnBasicSalary,
            this.olvColumnUnit,
            this.olvColumnStartDate,
            this.olvColumnEndDate,
            this.olvColumnDescription});
			this.dataListView1.DataSource = null;
			this.dataListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataListView1.Location = new System.Drawing.Point(0, 66);
			this.dataListView1.Name = "dataListView1";
			this.dataListView1.Size = new System.Drawing.Size(859, 356);
			this.dataListView1.TabIndex = 4;
			this.dataListView1.UseCompatibleStateImageBehavior = false;
			this.dataListView1.View = System.Windows.Forms.View.Details;
			// 
			// olvColumnRecordId
			// 
			this.olvColumnRecordId.AspectName = "Id";
			this.olvColumnRecordId.Text = "Record Id";
			// 
			// olvColumnCode
			// 
			this.olvColumnCode.AspectName = "Code";
			this.olvColumnCode.Text = "Group Code";
			this.olvColumnCode.Width = 80;
			// 
			// olvColumnName
			// 
			this.olvColumnName.AspectName = "Name";
			this.olvColumnName.Text = "Group Name";
			this.olvColumnName.Width = 103;
			// 
			// olvColumnType
			// 
			this.olvColumnType.AspectName = "Type";
			this.olvColumnType.Text = "Group Type";
			this.olvColumnType.Width = 92;
			// 
			// olvColumnBasicSalary
			// 
			this.olvColumnBasicSalary.AspectName = "Basic";
			this.olvColumnBasicSalary.AspectToStringFormat = "{0:#,###.##}";
			this.olvColumnBasicSalary.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColumnBasicSalary.Text = "Basic Salary";
			this.olvColumnBasicSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColumnBasicSalary.Width = 90;
			// 
			// olvColumnUnit
			// 
			this.olvColumnUnit.AspectName = "Unit";
			this.olvColumnUnit.AspectToStringFormat = "{0:#,###}";
			this.olvColumnUnit.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColumnUnit.Text = "Unit Salary";
			this.olvColumnUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColumnUnit.Width = 71;
			// 
			// olvColumnStartDate
			// 
			this.olvColumnStartDate.AspectName = "StartDate";
			this.olvColumnStartDate.AspectToStringFormat = "{0:dd-MM-yyyy}";
			this.olvColumnStartDate.Text = "Start Active Date";
			this.olvColumnStartDate.Width = 100;
			// 
			// olvColumnEndDate
			// 
			this.olvColumnEndDate.AspectName = "EndDate";
			this.olvColumnEndDate.AspectToStringFormat = "{0:dd-MM-yyyy}";
			this.olvColumnEndDate.Text = "End Active Date";
			this.olvColumnEndDate.Width = 94;
			// 
			// olvColumnDescription
			// 
			this.olvColumnDescription.AspectName = "Description";
			this.olvColumnDescription.Text = "Description";
			this.olvColumnDescription.Width = 258;
			// 
			// PayrollGroupMaintain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataListView1);
			this.Name = "PayrollGroupMaintain";
			this.Controls.SetChildIndex(this.dataListView1, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BrightIdeasSoftware.DataListView dataListView1;
		private BrightIdeasSoftware.OLVColumn olvColumnRecordId;
		private BrightIdeasSoftware.OLVColumn olvColumnCode;
		private BrightIdeasSoftware.OLVColumn olvColumnName;
		private BrightIdeasSoftware.OLVColumn olvColumnType;
		private BrightIdeasSoftware.OLVColumn olvColumnBasicSalary;
		private BrightIdeasSoftware.OLVColumn olvColumnUnit;
		private BrightIdeasSoftware.OLVColumn olvColumnStartDate;
		private BrightIdeasSoftware.OLVColumn olvColumnEndDate;
		private BrightIdeasSoftware.OLVColumn olvColumnDescription;
	}
}
