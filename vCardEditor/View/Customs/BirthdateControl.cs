using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace vCardEditor.View.Customs
{
    [DefaultEvent(nameof(BirhdayChanged))]
    public partial class BirthdateControl : UserControl
    {
        private bool _isSet;
        private bool _suppressValueChanged;

        public DateTime? Value {
            get
            {
                if(_isSet) return dtpBirthdate.Value;
                return null;
            }
            set
            {
                // Suppress ValueChanged events while updating programmatically.
                _suppressValueChanged = true;
                if(value.HasValue)
                {
                    _isSet = true;
                    dtpBirthdate.Value = value.Value;
                }
                else
                {
                    _isSet = false;
                    dtpBirthdate.Value = DateTime.Now;
                }
                _suppressValueChanged = false;

                _control_update();
            }
        }
        public event EventHandler BirhdayChanged;
        public BirthdateControl()
        {
            InitializeComponent();
            _isSet = false;

            // Prevent firing ValueChanged while initializing.
            _suppressValueChanged = true;
            dtpBirthdate.Value = DateTime.Now;
            _suppressValueChanged = false;

            _control_update();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            _isSet = !_isSet;
            _control_update();
            BirhdayChanged?.Invoke(sender, e);
        }

        private void _control_update()
        {
            dtpBirthdate.Enabled = _isSet;
            lblBirtdate.Enabled = _isSet;
            btnSwitch.Image =(_isSet)?
                Properties.Resources.Close:
                Properties.Resources.Add;
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            // Only raise the public event if the change was not programmatic.
            if (_suppressValueChanged)
                return;

            BirhdayChanged?.Invoke(sender, e);
        }
    }
}
