namespace ContactsMVC.View.Forms
{
    partial class ShowForm
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
            this.showContactControl1 = new ContactsMVC.View.Controls.ShowContactControl();
            this.SuspendLayout();
            // 
            // showContactControl1
            // 
            this.showContactControl1.Location = new System.Drawing.Point(12, 12);
            this.showContactControl1.Name = "showContactControl1";
            this.showContactControl1.Size = new System.Drawing.Size(320, 520);
            this.showContactControl1.TabIndex = 0;
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 583);
            this.Controls.Add(this.showContactControl1);
            this.Name = "ShowForm";
            this.Text = "ShowForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ShowContactControl showContactControl1;
    }
}