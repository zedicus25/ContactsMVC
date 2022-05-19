﻿namespace ContactsMVC.View.Forms
{
    partial class EditForm
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
            this.addControl = new ContactsMVC.View.Controls.AddingEditContactControl();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addControl
            // 
            this.addControl.BackColor = System.Drawing.Color.Gainsboro;
            this.addControl.Location = new System.Drawing.Point(12, 12);
            this.addControl.Name = "addControl";
            this.addControl.Size = new System.Drawing.Size(221, 400);
            this.addControl.TabIndex = 8;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(239, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 65);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 436);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addControl);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AddingEditContactControl addControl;
        private System.Windows.Forms.Button saveBtn;
    }
}