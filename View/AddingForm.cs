
using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class AddingForm : Form
    {
        private Contact contact;
        private List<TextBox> numbers;
        public Contact NewContact => contact;
        public AddingForm()
        {
            InitializeComponent();
            numbers = new List<TextBox>();
            numbers.Add(number0TB);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == String.Empty || number0TB.Text == String.Empty)
            {
                SelectTextBoxes();
                return;
            }
                
            List<string> nums = new List<string>();
            foreach (var it in numbers)
            {
                if (it.Text != String.Empty)
                    nums.Add(it.Text);
            }
            contact = new Contact(nameTB.Text, lastNameTB.Text,adressTB.Text, nums);
            this.Close();
        }

        private void addNumber_Click(object sender, EventArgs e)
        {
            if(numbers.Count + 1 <= 5)
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

        private void SelectTextBoxes()
        {
            nameTB.BackColor = nameTB.Text == String.Empty ? Color.DarkSalmon : Color.White;
            number0TB.BackColor = number0TB.Text == String.Empty ? Color.DarkSalmon : Color.White;
        }

        private void TBSelected(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }
    }
}
