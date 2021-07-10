namespace WindowsFormsApp3
{
    partial class nForm
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
            this.CheckBoxClose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CheckBoxClose
            // 
            this.CheckBoxClose.AutoSize = true;
            this.CheckBoxClose.Location = new System.Drawing.Point(464, 101);
            this.CheckBoxClose.Name = "CheckBoxClose";
            this.CheckBoxClose.Size = new System.Drawing.Size(101, 17);
            this.CheckBoxClose.TabIndex = 0;
            this.CheckBoxClose.Text = "CheckBoxClose";
            this.CheckBoxClose.UseVisualStyleBackColor = true;
            this.CheckBoxClose.CheckedChanged += new System.EventHandler(this.CheckBoxClose_CheckedChanged);
            // 
            // nForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBoxClose);
            this.Name = "nForm";
            this.Text = "nForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxClose;
    }
}