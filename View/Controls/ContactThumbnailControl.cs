using ContactsMVC.Controller;
using ContactsMVC.Model;
using ContactsMVC.View.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactThumbnailControl : UserControl
    {
        private Contact _contact;
        //private ContactController _contactController; 
        public ContactThumbnailControl()
        {
            InitializeComponent();
        }
        public ContactThumbnailControl(Contact contact):this()
        {
            //_contactController = controller;
            _contact = contact;
            //Contact contact = _contactController.GetContacts().Last();
            nameL.Text = $"{_contact.Name} {_contact.LastName}";
            
        }

        private void nameL_Click(object sender, System.EventArgs e)
        {
            //Contact contact = _contactController.GetById(GetId());
            ShowForm f = new ShowForm(_contact);
            f.ShowDialog();
            int id = _contact.Id;
            _contact.EditContact(f.NewContact.Name, f.NewContact.LastName, f.NewContact.Numbers,
                f.NewContact.Adress, id);
            //_contactController.GetById(GetId()).EditContact(f.NewContact.Name,
            //f.NewContact.LastName, f.NewContact.Numbers, f.NewContact.Adress, id);
            nameL.Text = $"{_contact.Name} {_contact.LastName}";
        }

        private void deleteBtn_Click(object sender, System.EventArgs e)
        {
            if(this.Parent.Parent is ListBoxForContactsControl)
            {
                (this.Parent.Parent as ListBoxForContactsControl).RemoveContact(GetId());
            }
        }

        private int GetId()
        {
            string str = this.Name;
            char[] arr = str.Where(ch => Char.IsNumber(ch)).ToArray();
            str = String.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i];
            }
            return Convert.ToInt32(str);
        }
    }
}
