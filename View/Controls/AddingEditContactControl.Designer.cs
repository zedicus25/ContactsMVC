namespace ContactsMVC.View.Controls
{
    partial class AddingEditContactControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNumberBtn = new System.Windows.Forms.Button();
            this.number0TB = new System.Windows.Forms.TextBox();
            this.numberL = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.adressL = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.lastNameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNumberBtn
            // 
            this.addNumberBtn.Location = new System.Drawing.Point(132, 202);
            this.addNumberBtn.Name = "addNumberBtn";
            this.addNumberBtn.Size = new System.Drawing.Size(75, 23);
            this.addNumberBtn.TabIndex = 19;
            this.addNumberBtn.Text = "Add number";
            this.addNumberBtn.UseVisualStyleBackColor = true;
            this.addNumberBtn.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // number0TB
            // 
            this.number0TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number0TB.Location = new System.Drawing.Point(12, 231);
            this.number0TB.Name = "number0TB";
            this.number0TB.Size = new System.Drawing.Size(200, 26);
            this.number0TB.TabIndex = 18;
            this.number0TB.Click += new System.EventHandler(this.TBSelected);
            // 
            // numberL
            // 
            this.numberL.AutoSize = true;
            this.numberL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberL.Location = new System.Drawing.Point(8, 208);
            this.numberL.Name = "numberL";
            this.numberL.Size = new System.Drawing.Size(118, 20);
            this.numberL.TabIndex = 17;
            this.numberL.Text = "Enter numbers:";
            this.numberL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adressTB
            // 
            this.adressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTB.Location = new System.Drawing.Point(12, 163);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(200, 26);
            this.adressTB.TabIndex = 15;
            // 
            // adressL
            // 
            this.adressL.AutoSize = true;
            this.adressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressL.Location = new System.Drawing.Point(8, 140);
            this.adressL.Name = "adressL";
            this.adressL.Size = new System.Drawing.Size(100, 20);
            this.adressL.TabIndex = 14;
            this.adressL.Text = "Enter adress";
            this.adressL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTB.Location = new System.Drawing.Point(12, 106);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(200, 26);
            this.lastNameTB.TabIndex = 13;
            // 
            // lastNameL
            // 
            this.lastNameL.AutoSize = true;
            this.lastNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameL.Location = new System.Drawing.Point(8, 83);
            this.lastNameL.Name = "lastNameL";
            this.lastNameL.Size = new System.Drawing.Size(121, 20);
            this.lastNameL.TabIndex = 12;
            this.lastNameL.Text = "Enter last name";
            this.lastNameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(12, 46);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 26);
            this.nameTB.TabIndex = 11;
            this.nameTB.Click += new System.EventHandler(this.TBSelected);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(8, 23);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(92, 20);
            this.nameL.TabIndex = 10;
            this.nameL.Text = "Enter name";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddingContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.addNumberBtn);
            this.Controls.Add(this.number0TB);
            this.Controls.Add(this.numberL);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.adressL);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.lastNameL);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Name = "AddingContactControl";
            this.Size = new System.Drawing.Size(221, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNumberBtn;
        private System.Windows.Forms.TextBox number0TB;
        private System.Windows.Forms.Label numberL;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Label adressL;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label lastNameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameL;
    }
}
