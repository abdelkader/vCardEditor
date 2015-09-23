using System;
using System.Windows.Forms;
using vCardEditor.Repository;
using vCardEditor.Model;

namespace vCardEditor.View
{
    public partial class ConfigDialog : Form
    {
        public ConfigDialog()
        {
            InitializeComponent();
            ConfigRepository conf = ConfigRepository.Instance;//.Clone();
            pgConfig.SelectedObject = conf;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
