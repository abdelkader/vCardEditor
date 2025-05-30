using System.Windows.Forms;

namespace vCardEditor.View.Customs
{
    public partial class CustomInputDialog : Form
    {
        public CustomInputDialog()
        {
            InitializeComponent();
        }

        public string input { get; set; }

        private void CustumInputDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            input = tbInput.Text;
        }
    }
}
