using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsMVC.Controller
{
    public class WriteReadController
    {
        public string Path { get; private set; }

        public WriteReadController()
        {
            Path = "dataBase.txt";
        }
        public WriteReadController(string path)
        {
            Path=path;
        }

        public void WriteToFile(List<Contact> contacts)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in contacts)
            {
                sb.AppendLine(item.ToStringForFile());
            }
            File.WriteAllText(Path,sb.ToString());

        }

        public List<Contact> ReadFromFile()
        {
            if (!File.Exists(Path))
                return null;

            List<Contact> result = new List<Contact>();
            List<string> lines = File.ReadAllLines(Path).ToList();
            lines.Remove(String.Empty);
            foreach (var line in lines)
            {
                List<string> contact = line.Split('|').ToList();
                contact.Remove(String.Empty);
                List<string> nums = new List<string>();
                for (int i = 4; i < contact.Count; i++)
                {
                    nums.Add(contact[i]);
                }

                result.Add(new Contact(int.Parse(contact[0]),contact[1],contact[2],contact[3],nums));
            }

            return result;
        }

    }
}
