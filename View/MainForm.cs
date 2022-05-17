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
        private ContactController _contactController;
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
            AddContactToPanel();
            GC.Collect(GC.GetGeneration(f));
        }

        private void AddContactToPanel()
        {
            if (_contactController.GetContacts().Count == 0)
                return;
            ContactThumbnailControl c = new ContactThumbnailControl(_contactController.GetContacts().Last().Name,
               _contactController.GetContacts().Last().LastName);
            if (contactPanel.Controls.Count > 0)
            {
                if (_contactController.GetContacts().Count == 0)
                    return;
                c.Location = new Point(contactPanel.Controls[contactPanel.Controls.Count - 1].Location.X,
                    contactPanel.Controls[contactPanel.Controls.Count - 1].Location.Y + 80);
            }
            contactPanel.Controls.Add(c);

        }
    }
}
