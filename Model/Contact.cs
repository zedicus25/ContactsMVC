using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsMVC.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public List<string> Numbers { get; set; }
        public int Id { get; set; }

        public Contact()
        {
            Name = LastName = Adress = String.Empty;
            Numbers = new List<string>();
        }

        public Contact(string name, string lastName, string adress,List<string> numbers)
        {
            Name = name;
            LastName = lastName;
            Adress = adress;
            Numbers = new List<string>(numbers);
        }
        public Contact(int id,string name, string lastName, string adress, List<string> numbers)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Adress = adress;
            Numbers = new List<string>(numbers);
        }

        public Contact(Contact newContact)
        {
            Name=newContact.Name;
            LastName=newContact.LastName;
            Adress=newContact.Adress;
            Numbers = new List<string>(newContact.Numbers);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Name, LastName);
        }

        public void EditContact(string name, string lastName,List<string> nums, string adress, int ID)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Adress = adress;
            this.Id = ID;
            this.Numbers = new List<string>(nums);
        }

        public string ToStringForFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id.ToString());
            sb.Append('|');
            sb.Append(Name);
            sb.Append('|');
            sb.Append(LastName);
            sb.Append('|');
            sb.Append(Adress);
            sb.Append("|");
            foreach (var item in Numbers)
            {
                sb.Append(item);
                sb.Append('|');
            }
            return sb.ToString();

        }

    }
}
