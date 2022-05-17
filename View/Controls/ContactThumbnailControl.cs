using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactThumbnailControl : UserControl
    {
        public ContactThumbnailControl()
        {
            InitializeComponent();
        }
        public ContactThumbnailControl(string name, string lastName):this()
        {
            nameL.Text = $"{name} {lastName}";
        }
    }
}
