using ContactsMVC.Model;
using System.Windows.Forms;

namespace ContactsMVC.View.Forms
{
    public partial class ShowForm : Form
    {
        private Contact _contact;
        public Contact NewContact => _contact;
        public ShowForm()
        {
            InitializeComponent();
        }
        public ShowForm(Contact c) : this()
        {
            _contact = c;
            UpdateContact();
        }

        private void editBtn_Click(object sender, System.EventArgs e)
        {
            EditForm editForm = new EditForm(_contact);
            editForm.ShowDialog();
            _contact = editForm.NewContact;
            UpdateContact();
        }

        private void UpdateContact()
        {
            this.Controls.Remove(showContactControl1);
            showContactControl1 = new Controls.ShowContactControl(_contact);
            showContactControl1.Location = new System.Drawing.Point(12, 12);
            this.Controls.Add(showContactControl1);
        }

        private void backBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
