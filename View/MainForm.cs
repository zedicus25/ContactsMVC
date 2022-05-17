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
        public MainForm()
        {
            InitializeComponent();
            _contactController = new ContactController();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddingForm f = new AddingForm();
            f.ShowDialog();
            _contactController.AddContact(f.NewContact);
            contactsLB.AddContactToPanel(_contactController);
            GC.Collect(GC.GetGeneration(f));
        }

        
    }
}
