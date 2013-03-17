namespace K.HR.Payroll
{
    partial class MainForm
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
            foreach (var activeObject in ListActiveObject)
            {
                activeObject.ListParameterForm.Dispose();
                activeObject.MaintainObject.Dispose();
            }
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
			this.splitContainerNorth = new System.Windows.Forms.SplitContainer();
			this.splitContainerCenter = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerNorth)).BeginInit();
			this.splitContainerNorth.Panel2.SuspendLayout();
			this.splitContainerNorth.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerCenter)).BeginInit();
			this.splitContainerCenter.Panel1.SuspendLayout();
			this.splitContainerCenter.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerNorth
			// 
			this.splitContainerNorth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerNorth.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerNorth.Location = new System.Drawing.Point(0, 0);
			this.splitContainerNorth.Name = "splitContainerNorth";
			this.splitContainerNorth.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerNorth.Panel2
			// 
			this.splitContainerNorth.Panel2.Controls.Add(this.splitContainerCenter);
			this.splitContainerNorth.Size = new System.Drawing.Size(769, 415);
			this.splitContainerNorth.SplitterDistance = 81;
			this.splitContainerNorth.TabIndex = 0;
			// 
			// splitContainerCenter
			// 
			this.splitContainerCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainerCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerCenter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerCenter.Location = new System.Drawing.Point(0, 0);
			this.splitContainerCenter.Name = "splitContainerCenter";
			// 
			// splitContainerCenter.Panel1
			// 
			this.splitContainerCenter.Panel1.Controls.Add(this.treeView1);
			this.splitContainerCenter.Size = new System.Drawing.Size(769, 330);
			this.splitContainerCenter.SplitterDistance = 192;
			this.splitContainerCenter.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(190, 328);
			this.treeView1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(769, 415);
			this.Controls.Add(this.splitContainerNorth);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.splitContainerNorth.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerNorth)).EndInit();
			this.splitContainerNorth.ResumeLayout(false);
			this.splitContainerCenter.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerCenter)).EndInit();
			this.splitContainerCenter.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerNorth;
		private System.Windows.Forms.SplitContainer splitContainerCenter;
		private System.Windows.Forms.TreeView treeView1;
    }
}

