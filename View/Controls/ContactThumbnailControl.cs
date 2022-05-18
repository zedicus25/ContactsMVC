using ContactsMVC.Model;
using ContactsMVC.View.Forms;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactThumbnailControl : UserControl
    {
        private Contact _contact;
        public ContactThumbnailControl()
        {
            InitializeComponent();
            _contact = new Contact();
        }
        public ContactThumbnailControl(Contact c):this()
        {
            nameL.Text = $"{c.Name} {c.LastName}";
            _contact = c;
        }

        private void nameL_Click(object sender, System.EventArgs e)
        {
            ShowForm f = new ShowForm(_contact);
            f.ShowDialog();
        }
    }
}
