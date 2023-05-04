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
            ConfigRepository conf = ConfigRepository.Instance;//
            pgConfig.SelectedObject = conf;
        }
    }
}
