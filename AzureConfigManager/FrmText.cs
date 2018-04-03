using System.Windows.Forms;

namespace AzureConfigManager
{
    public partial class FrmText : Form
    {
        public FrmText(string text)
        {
            InitializeComponent();
            txtText.Text = text;
        }
    }
}
