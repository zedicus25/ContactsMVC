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
    public partial class AddingContactControl : UserControl
    {
        private Contact contact;
        private List<TextBox> numbers;
        public AddingContactControl()
        {
            InitializeComponent();
            numbers = new List<TextBox>();
            numbers.Add(number0TB);
        }


        private void addNumber_Click(object sender, EventArgs e)
        {
            if (numbers.Count + 1 <= 5)
            {
                numbers.Add(CreateTextBox(new Point(numbers.Last().Location.X, numbers.Last().Location.Y + 30)));
                this.Controls.Add(numbers.Last());
            }
        }

        private TextBox CreateTextBox(Point pos)
        {
            TextBox t = new TextBox();
            t.Location = pos;
            t.Size = number0TB.Size;
            t.Font = number0TB.Font;
            return t;
        }

        public void SelectTextBoxes()
        {
            nameTB.BackColor = nameTB.Text == String.Empty ? Color.DarkSalmon : Color.White;
            number0TB.BackColor = number0TB.Text == String.Empty ? Color.DarkSalmon : Color.White;
        }

        private void TBSelected(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        public bool CanCreate()
        {
            if (nameTB.Text == String.Empty || number0TB.Text == String.Empty)
                return false;
            return true;
        }

        public Contact NewContact()
        {
            List<string> nums = new List<string>();
            foreach (var item in numbers)
            {
                nums.Add(item.Text);
            }
            return new Contact(nameTB.Text, lastNameTB.Text, adressTB.Text, nums);
        }
    }
}
