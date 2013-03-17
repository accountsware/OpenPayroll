namespace Ceva.Windows.Controls.EditBox
{
    partial class LookupTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookupTextBox));
            this.LButton = new System.Windows.Forms.Button();
            this.LTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LButton
            // 
            this.LButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LButton.Image = ((System.Drawing.Image)(resources.GetObject("LButton.Image")));
            this.LButton.Location = new System.Drawing.Point(154, -1);
            this.LButton.Name = "LButton";
            this.LButton.Size = new System.Drawing.Size(23, 21);
            this.LButton.TabIndex = 0;
            this.LButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LButton.UseVisualStyleBackColor = true;
            // 
            // LTextBox
            // 
            this.LTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LTextBox.Location = new System.Drawing.Point(0, 0);
            this.LTextBox.Name = "LTextBox";
            this.LTextBox.Size = new System.Drawing.Size(154, 20);
            this.LTextBox.TabIndex = 0;
            // 
            // LookupTextBox
            // 
            this.Controls.Add(this.LTextBox);
            this.Controls.Add(this.LButton);
            this.Size = new System.Drawing.Size(177, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button LButton;
        public System.Windows.Forms.TextBox LTextBox;
    }
}
