using ContactsMVC.Model;
using System;
using System.Collections.Generic;

namespace ContactsMVC.Controller
{
    public class ContactController
    {
        private List<Contact> _contacts;

        public ContactController()
        {
            _contacts = new List<Contact>();
            //
            //test data
            //
            _contacts.Add(new Contact("Tomas","Brush","USA", new List<string>() { "+15151515","+515151515"}));
            _contacts.Add(new Contact("Bob","Bobski","Finland", new List<string>() { "+51511288","+81881118"}));
            _contacts.Add(new Contact("Ihor","MoCcho","German", new List<string>() { "+81818185","+888599599"}));
        }
        public ContactController(List<Contact> contacts)
        {
            _contacts = new List<Contact>(contacts);
            
        }
        public void AddContact(Contact c)
        {
            _contacts.Add(c);
        }
        public void RemoveContact(Contact c)
        {
            if(_contacts.Contains(c))
                _contacts.Remove(c);    
        }
        public List<Contact> GetContacts()
        {
            return _contacts;
        }
    }
}
