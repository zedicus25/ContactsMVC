using ContactsMVC.Model;
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
    public partial class ShowContactControl : UserControl
    {
        public ShowContactControl()
        {
            InitializeComponent();
        }
        public ShowContactControl(Contact c) : this()
        {
            contactNameL.Text = c.Name;
            contactLastNameL.Text = c.LastName;
            adressL.Text = c.Adress;
            number0L.Text = c.Numbers.First();
            CreateNumbers(c.Numbers);
        }

        private void CreateNumbers(List<string> nums)
        {
            contactNumbers = new List<Label>();
            contactNumbers.Add(number0L);
            if(nums.Count > 1)
            {
                for (int i = 1; i < nums.Count; i++)
                {
                    contactNumbers.Add(CreateNumber(nums[i],new Point(contactNumbers.Last().Location.X,
                        contactNumbers.Last().Location.Y + 35)));
                    this.Controls.Add(contactNumbers.Last());
                }
            }
        }

        private Label CreateNumber(string num,Point pos)
        {
            Label l = new Label();
            l.Location = pos;
            l.Text = num;
            l.Font = number0L.Font;
            return l;
        }
    }
}
