using System.Windows.Forms;

namespace K.Common.UI.Forms
{
	partial class KDualDatePicker
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
			this.StartDate = new DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.EndDate = new DateTimePicker();
			// 
			// StartDate
			// 
			this.StartDate.Name = "StartDate";
			this.StartDate.TabIndex = 0;
			this.StartDate.CustomFormat = "dd-MM-yyyy";
			this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.StartDate.Location = new System.Drawing.Point(0, 0);
			this.StartDate.Size = new System.Drawing.Size(81, 21);
			this.StartDate.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "To";
			// 
			// EndDate
			// 
			this.EndDate.Location = new System.Drawing.Point(112, 0);
			this.EndDate.Name = "EndDate";
			this.EndDate.Size = new System.Drawing.Size(81, 21);
			this.EndDate.TabIndex = 0;
			this.EndDate.CustomFormat = "dd-MM-yyyy";
			this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

			this.ClientSize = new System.Drawing.Size(192, 21);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.StartDate);
			this.Controls.Add(this.EndDate);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		public DateTimePicker StartDate;
        private System.Windows.Forms.Label label1;
		public DateTimePicker EndDate;
	}
}
