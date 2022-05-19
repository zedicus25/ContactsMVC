using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsMVC.View.Forms
{
    public partial class EditForm : Form
    {
        public Contact NewContact { get; private set; }
        public EditForm(Contact c)
        {
            InitializeComponent();
            this.Controls.Remove(addControl);
            addControl = new Controls.AddingEditContactControl(c, true);
            addControl.Location = new Point(12, 12);
            this.Controls.Add(addControl);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            NewContact = addControl.NewContact();
            this.Close();
        }
    }
}
