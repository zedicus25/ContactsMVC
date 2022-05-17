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
            contact = new Contact();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (addControl.CanCreate() == false)
            {
                addControl.SelectTextBoxes();
                return;
            }
            if (addControl.CanCreate())
            {
                contact = new Contact(addControl.NewContact());
                this.Close();
            }
                
        }

       
    }
}
