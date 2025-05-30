using System.Windows.Forms;
using vCardEditor.Repository;

namespace vCardEditor.View
{
    public partial class ConfigDialog : Form
    {
        public ConfigDialog()
        {
            InitializeComponent();
            ConfigRepository conf = ConfigRepository.Instance;
            pgConfig.SelectedObject = conf;
        }
    }
}
