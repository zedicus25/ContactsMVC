using ContactsMVC.Model;
using System.Windows.Forms;

namespace ContactsMVC.View.Forms
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }
        public ShowForm(Contact c) : this()
        {
            this.Controls.Remove(showContactControl1);
            showContactControl1 = new Controls.ShowContactControl(c);
            this.Controls.Add(showContactControl1);
        }
    }
}
