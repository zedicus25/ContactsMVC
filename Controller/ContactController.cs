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
        }
        public ContactController(List<Contact> contacts)
        {
            _contacts = new List<Contact>(contacts);
            
        }
        public void AddContact(Contact c)
        {
            if (c == null)
                return;
            if(c.Name != String.Empty && c.Numbers.Count > 0)
            {
                c.Id = _contacts.Count;
                _contacts.Add(c);
            }
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

        public Contact GetById(int id)
        {
            if(id >= 0 && id < _contacts.Count)
                return _contacts[id];
            return null;
        }

        
    }
}
