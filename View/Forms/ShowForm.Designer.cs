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
            this.backBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.showContactControl1 = new ContactsMVC.View.Controls.ShowContactControl();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Image = global::ContactsMVC.Properties.Resources.backArrow;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(60, 40);
            this.backBtn.TabIndex = 12;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Image = global::ContactsMVC.Properties.Resources.editButton;
            this.editBtn.Location = new System.Drawing.Point(272, 511);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(50, 50);
            this.editBtn.TabIndex = 11;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // showContactControl1
            // 
            this.showContactControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.showContactControl1.Location = new System.Drawing.Point(12, 12);
            this.showContactControl1.Name = "showContactControl1";
            this.showContactControl1.Size = new System.Drawing.Size(324, 559);
            this.showContactControl1.TabIndex = 0;
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 583);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.showContactControl1);
            this.Name = "ShowForm";
            this.Text = "ShowForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ShowContactControl showContactControl1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button backBtn;
    }
}