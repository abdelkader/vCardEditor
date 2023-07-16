using System.Windows.Forms;

namespace vCardEditor.View.Customs
{
    public partial class CustumInputDialog : Form
    {
        public CustumInputDialog()
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
