using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsMVC.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public List<string> Numbers { get; set; }

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

    }
}
