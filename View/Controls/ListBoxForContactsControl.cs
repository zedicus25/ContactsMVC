using ContactsMVC.Controller;
using ContactsMVC.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public void AddContactToPanel(Contact con)
        {
            if (_contactController == null)
                return;
            if (_contactController.GetContacts().Count == 0)
                return;
            ContactThumbnailControl c = new ContactThumbnailControl(con);
            if (contactPanel.Controls.Count > 0)
            {
                if (_contactController.GetContacts().Count == 0)
                    return;
                c.Location = new Point(contactPanel.Controls[contactPanel.Controls.Count - 1].Location.X,
                    contactPanel.Controls[contactPanel.Controls.Count - 1].Location.Y + 80);
            }
            c.Name = $"contact{con.Id}";
            contactPanel.Controls.Add(c);
        }

        public void RemoveContact(int id)
        {
            _contactController.RemoveContact(_contactController.GetById(id));
            GenerateView(_contactController.GetContacts());
        }

        private void GenerateView(List<Contact> contacList)
        {
            contactPanel.Controls.Clear();
            foreach (Contact item in contacList)
            {
                AddContactToPanel(item);
            }
        }

        private void searchTB_TextChanged(object sender, System.EventArgs e)
        {
            if (searchTB.Text == string.Empty)
            {
                GenerateView(_contactController.GetContacts());
            }
            else
            {
                if (rightGoCB.Checked != true)
                {
                    GenerateView(this._contactController.GetContacts().Where(i => i.Name.ToLower().Contains(searchTB.Text.ToLower()) 
                    || i.LastName.ToLower().Contains(searchTB.Text.ToLower())).ToList());
                }
                else
                {
                    GenerateView(this._contactController.GetContacts().Where(i => i.Name.Equals(searchTB.Text) 
                    || i.LastName.Contains(searchTB.Text)).ToList());
                }
            }
        }
    }
}
