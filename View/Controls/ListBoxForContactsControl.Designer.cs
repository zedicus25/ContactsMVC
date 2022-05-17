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
            this.SuspendLayout();
            // 
            // contactPanel
            // 
            this.contactPanel.AutoScroll = true;
            this.contactPanel.BackColor = System.Drawing.Color.Beige;
            this.contactPanel.Location = new System.Drawing.Point(13, 15);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(270, 512);
            this.contactPanel.TabIndex = 3;
            // 
            // ListBoxForContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contactPanel);
            this.Name = "ListBoxForContactsControl";
            this.Size = new System.Drawing.Size(300, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contactPanel;
    }
}
