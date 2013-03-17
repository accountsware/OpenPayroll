namespace K.HR.Payroll.Master.Position
{
	partial class PositionParameterList
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
			this.kTextBox1 = new K.Common.UI.Forms.KTextBox(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.kTextBox1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(373, 207);
			this.splitContainer1.SplitterDistance = 150;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Position Name";
			// 
			// kTextBox1
			// 
			this.kTextBox1.ColumnName = "PositionName";
			this.kTextBox1.Location = new System.Drawing.Point(106, 36);
			this.kTextBox1.Name = "kTextBox1";
			this.kTextBox1.Operator = K.Common.Data.SqlOperator.Like;
			this.kTextBox1.Size = new System.Drawing.Size(211, 21);
			this.kTextBox1.TabIndex = 1;
			this.kTextBox1.TableName = null;
			// 
			// PositionParameterList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 207);
			this.Name = "PositionParameterList";
			this.Text = "Position Parameter List";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Common.UI.Forms.KTextBox kTextBox1;
	}
}