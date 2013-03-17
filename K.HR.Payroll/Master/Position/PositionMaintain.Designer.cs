namespace K.HR.Payroll.Master.Position
{
    partial class PositionMaintain
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
			this.olvColumnPositionName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataListView1
			// 
			this.dataListView1.AllColumns.Add(this.olvColumnRecordId);
			this.dataListView1.AllColumns.Add(this.olvColumnPositionName);
			this.dataListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnRecordId,
            this.olvColumnPositionName});
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
			this.olvColumnRecordId.Text = "Record ID";
			// 
			// olvColumnPositionName
			// 
			this.olvColumnPositionName.AspectName = "PositionName";
			this.olvColumnPositionName.Text = "Position Name";
			this.olvColumnPositionName.Width = 290;
			// 
			// PositionMaintain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataListView1);
			this.Name = "PositionMaintain";
			this.Controls.SetChildIndex(this.dataListView1, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private BrightIdeasSoftware.DataListView dataListView1;
		private BrightIdeasSoftware.OLVColumn olvColumnRecordId;
		private BrightIdeasSoftware.OLVColumn olvColumnPositionName;

	}
}
