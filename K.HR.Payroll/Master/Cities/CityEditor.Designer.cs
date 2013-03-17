namespace K.HR.Payroll.Master.Cities
{
    partial class CityEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.TextBox();
            this.createdBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifiedDate = new System.Windows.Forms.DateTimePicker();
            this.modifiedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recordId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.recordId);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.modifiedDate);
            this.splitContainer1.Panel1.Controls.Add(this.modifiedBy);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.createdDate);
            this.splitContainer1.Panel1.Controls.Add(this.createdBy);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cityName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name";
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(113, 40);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(184, 21);
            this.cityName.TabIndex = 1;
            // 
            // createdBy
            // 
            this.createdBy.Location = new System.Drawing.Point(113, 73);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(184, 21);
            this.createdBy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Created By";
            // 
            // createdDate
            // 
            this.createdDate.CustomFormat = "dd-MM-yyyy hh:mm";
            this.createdDate.Enabled = false;
            this.createdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createdDate.Location = new System.Drawing.Point(113, 111);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(224, 21);
            this.createdDate.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Created Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Modified Date";
            // 
            // modifiedDate
            // 
            this.modifiedDate.CustomFormat = "dd-MM-yyyy hh:mm";
            this.modifiedDate.Enabled = false;
            this.modifiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.modifiedDate.Location = new System.Drawing.Point(480, 114);
            this.modifiedDate.Name = "modifiedDate";
            this.modifiedDate.Size = new System.Drawing.Size(224, 21);
            this.modifiedDate.TabIndex = 24;
            // 
            // modifiedBy
            // 
            this.modifiedBy.Location = new System.Drawing.Point(480, 76);
            this.modifiedBy.Name = "modifiedBy";
            this.modifiedBy.Size = new System.Drawing.Size(184, 21);
            this.modifiedBy.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Modified By";
            // 
            // recordId
            // 
            this.recordId.AcceptsTab = true;
            this.recordId.Enabled = false;
            this.recordId.Location = new System.Drawing.Point(480, 40);
            this.recordId.Name = "recordId";
            this.recordId.Size = new System.Drawing.Size(224, 21);
            this.recordId.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Record ID";
            // 
            // CityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 482);
            this.Name = "CityEditor";
            this.Text = "CityEditor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.TextBox createdBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker createdDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker modifiedDate;
        private System.Windows.Forms.TextBox modifiedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recordId;
    }
}