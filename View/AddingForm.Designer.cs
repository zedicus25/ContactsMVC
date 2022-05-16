namespace ContactsMVC.View
{
    partial class AddingForm
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
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.lastNameL = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.adressL = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(12, 30);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(92, 20);
            this.nameL.TabIndex = 0;
            this.nameL.Text = "Enter name";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(16, 53);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 26);
            this.nameTB.TabIndex = 1;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTB.Location = new System.Drawing.Point(16, 113);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(200, 26);
            this.lastNameTB.TabIndex = 3;
            // 
            // lastNameL
            // 
            this.lastNameL.AutoSize = true;
            this.lastNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameL.Location = new System.Drawing.Point(12, 90);
            this.lastNameL.Name = "lastNameL";
            this.lastNameL.Size = new System.Drawing.Size(121, 20);
            this.lastNameL.TabIndex = 2;
            this.lastNameL.Text = "Enter last name";
            this.lastNameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adressTB
            // 
            this.adressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTB.Location = new System.Drawing.Point(16, 170);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(200, 26);
            this.adressTB.TabIndex = 5;
            // 
            // adressL
            // 
            this.adressL.AutoSize = true;
            this.adressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressL.Location = new System.Drawing.Point(12, 147);
            this.adressL.Name = "adressL";
            this.adressL.Size = new System.Drawing.Size(100, 20);
            this.adressL.TabIndex = 4;
            this.adressL.Text = "Enter adress";
            this.adressL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(237, 204);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 45);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.adressL);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.lastNameL);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Name = "AddingForm";
            this.Text = "AddingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label lastNameL;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Label adressL;
        private System.Windows.Forms.Button addBtn;
    }
}