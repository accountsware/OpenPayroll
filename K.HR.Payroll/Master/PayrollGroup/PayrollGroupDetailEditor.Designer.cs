namespace K.HR.Payroll.Master.PayrollGroup
{
	partial class PayrollGroupDetailEditor
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.comboBoxUnitType = new System.Windows.Forms.ComboBox();
            this.kNumericTextBoxValue = new K.Common.UI.Forms.KNumericTextBox(this.components);
            this.kNumericTextBoxUnit = new K.Common.UI.Forms.KNumericTextBox(this.components);
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(591, 347);
            this.splitContainer1.SplitterDistance = 288;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(591, 288);
            this.splitContainer2.SplitterDistance = 158;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 28, 0, 20);
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(158, 288);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBoxName);
            this.flowLayoutPanel3.Controls.Add(this.comboBoxItemType);
            this.flowLayoutPanel3.Controls.Add(this.comboBoxUnitType);
            this.flowLayoutPanel3.Controls.Add(this.kNumericTextBoxValue);
            this.flowLayoutPanel3.Controls.Add(this.kNumericTextBoxUnit);
            this.flowLayoutPanel3.Controls.Add(this.textBoxDescription);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10, 20, 0, 20);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(432, 288);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 24);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(396, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Items.AddRange(new object[] {
            "EARNINGS",
            "DEDUCTIONS"});
            this.comboBoxItemType.Location = new System.Drawing.Point(14, 54);
            this.comboBoxItemType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(213, 22);
            this.comboBoxItemType.TabIndex = 1;
            // 
            // comboBoxUnitType
            // 
            this.comboBoxUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnitType.FormattingEnabled = true;
            this.comboBoxUnitType.Items.AddRange(new object[] {
            "BASE-ON-VALUE",
            "PERCENTAGE-VALUE",
            "UNIT-VALUE",
            "CUSTOM-BASE"});
            this.comboBoxUnitType.Location = new System.Drawing.Point(14, 84);
            this.comboBoxUnitType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUnitType.Name = "comboBoxUnitType";
            this.comboBoxUnitType.Size = new System.Drawing.Size(212, 22);
            this.comboBoxUnitType.TabIndex = 2;
            // 
            // kNumericTextBoxValue
            // 
            this.kNumericTextBoxValue.ColumnName = null;
            this.kNumericTextBoxValue.Location = new System.Drawing.Point(14, 114);
            this.kNumericTextBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.kNumericTextBoxValue.Name = "kNumericTextBoxValue";
            this.kNumericTextBoxValue.Size = new System.Drawing.Size(121, 22);
            this.kNumericTextBoxValue.TabIndex = 3;
            this.kNumericTextBoxValue.TableName = null;
            // 
            // kNumericTextBoxUnit
            // 
            this.kNumericTextBoxUnit.ColumnName = null;
            this.kNumericTextBoxUnit.Location = new System.Drawing.Point(14, 144);
            this.kNumericTextBoxUnit.Margin = new System.Windows.Forms.Padding(4);
            this.kNumericTextBoxUnit.Name = "kNumericTextBoxUnit";
            this.kNumericTextBoxUnit.Size = new System.Drawing.Size(121, 22);
            this.kNumericTextBoxUnit.TabIndex = 4;
            this.kNumericTextBoxUnit.TableName = null;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(14, 174);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(396, 69);
            this.textBoxDescription.TabIndex = 5;
            // 
            // PayrollGroupDetailEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 347);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PayrollGroupDetailEditor";
            this.Text = "Payroll Group Detail Editor";
            this.Load += new System.EventHandler(this.PayrollGroupDetailEditorLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxItemType;
		private System.Windows.Forms.ComboBox comboBoxUnitType;
		private Common.UI.Forms.KNumericTextBox kNumericTextBoxValue;
		private Common.UI.Forms.KNumericTextBox kNumericTextBoxUnit;
		private System.Windows.Forms.TextBox textBoxDescription;
	}
}