using System.Collections.Generic;

namespace ContactsMVC.View.Controls
{
    partial class ShowContactControl
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
            this.number0L = new System.Windows.Forms.Label();
            this.adressL = new System.Windows.Forms.Label();
            this.contactLastNameL = new System.Windows.Forms.Label();
            this.contactNameL = new System.Windows.Forms.Label();
            this.contactFotoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactFotoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // number0L
            // 
            this.number0L.AutoSize = true;
            this.number0L.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number0L.Location = new System.Drawing.Point(12, 352);
            this.number0L.Name = "number0L";
            this.number0L.Size = new System.Drawing.Size(70, 21);
            this.number0L.TabIndex = 9;
            this.number0L.Text = "number";
            this.number0L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adressL
            // 
            this.adressL.AutoSize = true;
            this.adressL.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressL.Location = new System.Drawing.Point(12, 312);
            this.adressL.Name = "adressL";
            this.adressL.Size = new System.Drawing.Size(70, 21);
            this.adressL.TabIndex = 8;
            this.adressL.Text = "adress";
            this.adressL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactLastNameL
            // 
            this.contactLastNameL.AutoSize = true;
            this.contactLastNameL.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactLastNameL.Location = new System.Drawing.Point(12, 275);
            this.contactLastNameL.Name = "contactLastNameL";
            this.contactLastNameL.Size = new System.Drawing.Size(90, 21);
            this.contactLastNameL.TabIndex = 7;
            this.contactLastNameL.Text = "lastName";
            this.contactLastNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactNameL
            // 
            this.contactNameL.AutoSize = true;
            this.contactNameL.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactNameL.Location = new System.Drawing.Point(12, 236);
            this.contactNameL.Name = "contactNameL";
            this.contactNameL.Size = new System.Drawing.Size(50, 21);
            this.contactNameL.TabIndex = 6;
            this.contactNameL.Text = "name";
            this.contactNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactFotoPB
            // 
            this.contactFotoPB.Image = global::ContactsMVC.Properties.Resources.defaultContact;
            this.contactFotoPB.Location = new System.Drawing.Point(64, 14);
            this.contactFotoPB.Name = "contactFotoPB";
            this.contactFotoPB.Size = new System.Drawing.Size(200, 200);
            this.contactFotoPB.TabIndex = 5;
            this.contactFotoPB.TabStop = false;
            // 
            // ShowContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.number0L);
            this.Controls.Add(this.adressL);
            this.Controls.Add(this.contactLastNameL);
            this.Controls.Add(this.contactNameL);
            this.Controls.Add(this.contactFotoPB);
            this.Name = "ShowContactControl";
            this.Size = new System.Drawing.Size(320, 520);
            ((System.ComponentModel.ISupportInitialize)(this.contactFotoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number0L;
        private System.Windows.Forms.Label adressL;
        private System.Windows.Forms.Label contactLastNameL;
        private System.Windows.Forms.Label contactNameL;
        private System.Windows.Forms.PictureBox contactFotoPB;
        private List<System.Windows.Forms.Label> contactNumbers;
    }
}
