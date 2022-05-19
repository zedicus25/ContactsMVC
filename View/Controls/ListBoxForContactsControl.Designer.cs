namespace ContactsMVC.View.Controls
{
    partial class ListBoxForContactsControl
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
            this.contactPanel = new System.Windows.Forms.Panel();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.rightGoCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // contactPanel
            // 
            this.contactPanel.AutoScroll = true;
            this.contactPanel.BackColor = System.Drawing.Color.Beige;
            this.contactPanel.Location = new System.Drawing.Point(12, 95);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(350, 512);
            this.contactPanel.TabIndex = 3;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.Location = new System.Drawing.Point(12, 20);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(350, 29);
            this.searchTB.TabIndex = 4;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // rightGoCB
            // 
            this.rightGoCB.AutoSize = true;
            this.rightGoCB.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightGoCB.Location = new System.Drawing.Point(12, 60);
            this.rightGoCB.Name = "rightGoCB";
            this.rightGoCB.Size = new System.Drawing.Size(109, 25);
            this.rightGoCB.TabIndex = 5;
            this.rightGoCB.Text = "Right go";
            this.rightGoCB.UseVisualStyleBackColor = true;
            // 
            // ListBoxForContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rightGoCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.contactPanel);
            this.Name = "ListBoxForContactsControl";
            this.Size = new System.Drawing.Size(385, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.CheckBox rightGoCB;
    }
}
