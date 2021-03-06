using ContactsMVC.Controller;
using System;
using ContactsMVC.View.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class MainForm : Form
    {
        private ContactController _contactController = null;
        private WriteReadController _writeReadController = null;
        public MainForm()
        {
            InitializeComponent();
            this.Controls.Remove(contactsLB);
            _writeReadController = new WriteReadController();
            _contactController = new ContactController(_writeReadController.ReadFromFile());
            contactsLB = new ListBoxForContactsControl(_contactController);
            contactsLB.Location = new Point(12, 12);
            this.Controls.Add(contactsLB);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddingForm f = new AddingForm();
            f.ShowDialog();
            _contactController.AddContact(f.NewContact);
            contactsLB.AddContactToPanel(_contactController.GetContacts().Last());
            GC.Collect(GC.GetGeneration(f));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _writeReadController.WriteToFile(_contactController.GetContacts());
        }

    }
}
