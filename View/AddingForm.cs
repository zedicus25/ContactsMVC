
using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class AddingForm : Form
    {
        private Contact contact;
        public Contact NewContact => contact;
        public AddingForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            contact = new Contact(nameTB.Text, lastNameTB.Text,adressTB.Text, new List<string>());
            this.Close();
        }
    }
}
