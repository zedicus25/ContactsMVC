namespace ContactsMVC.View.Controls
{
    partial class ContactThumbnailControl
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
            this.fotoPB = new System.Windows.Forms.PictureBox();
            this.nameL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoPB
            // 
            this.fotoPB.Image = global::ContactsMVC.Properties.Resources.defaultIcon;
            this.fotoPB.InitialImage = null;
            this.fotoPB.Location = new System.Drawing.Point(0, 0);
            this.fotoPB.Name = "fotoPB";
            this.fotoPB.Size = new System.Drawing.Size(70, 70);
            this.fotoPB.TabIndex = 0;
            this.fotoPB.TabStop = false;
            // 
            // nameL
            // 
            this.nameL.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(76, 0);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(194, 70);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "name";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactThumbnailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.fotoPB);
            this.Name = "ContactThumbnailControl";
            this.Size = new System.Drawing.Size(270, 70);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoPB;
        private System.Windows.Forms.Label nameL;
    }
}
