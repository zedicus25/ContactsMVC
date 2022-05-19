using ContactsMVC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ListBoxForContactsControl : UserControl
    {
        private ContactController _contactController;
        public ListBoxForContactsControl()
        {
            InitializeComponent();
        }
        public ListBoxForContactsControl(ContactController controller) : this() 
        {
            _contactController = controller;
        }

        public void AddContactToPanel(ContactController con)
        {
            _contactController = con;
            if (_contactController == null)
                return;
            if (_contactController.GetContacts().Count == 0)
                return;
            ContactThumbnailControl c = new ContactThumbnailControl(_contactController);
            if (contactPanel.Controls.Count > 0)
            {
                if (_contactController.GetContacts().Count == 0)
                    return;
                c.Location = new Point(contactPanel.Controls[contactPanel.Controls.Count - 1].Location.X,
                    contactPanel.Controls[contactPanel.Controls.Count - 1].Location.Y + 80);
            }
            c.Name = $"contact{_contactController.GetContacts().Last().Id}";
            contactPanel.Controls.Add(c);

        }
    }
}
