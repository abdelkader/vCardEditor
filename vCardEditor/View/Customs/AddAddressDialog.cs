using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thought.vCards;

namespace vCardEditor.View.Customs
{
    public partial class AddAddressDialog : Form
    {
        public List<vCardDeliveryAddressTypes> Addresses { get;}
        private readonly List<CheckBox> _checkBoxes;

        public AddAddressDialog()
        {
            InitializeComponent();
            
            _checkBoxes = Controls.OfType<CheckBox>().ToList();
            Addresses = new List<vCardDeliveryAddressTypes>();
        }

        public AddAddressDialog(List<vCardDeliveryAddressTypes> addressCollection)
        {
            InitializeComponent();
            Addresses = addressCollection;
            _checkBoxes = Controls.OfType<CheckBox>().ToList();

            

            foreach (var item in addressCollection)
            {
                switch (item.ToString())
                {
                    case "Home":
                        cbHome.Checked = true;
                        break;
                    case "Work":
                        cbWork.Checked = true;
                        break;
                    case "Postal":
                        cbPostal.Checked = true;
                        break;
                    case "Parcel":
                        cbParcel.Checked = true;
                        break;
                    case "Preferred":
                        cbPreferred.Checked = true;
                        break;
                    case "Domestic":
                        cbDomestic.Checked = true;
                        break;
                    case "International":
                        cbInternational.Checked = true;
                        break;

                }
               
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var checkedItems = _checkBoxes.Where(checkBox => checkBox.Checked);

            if (checkedItems.Count() == 0)
            {
                MessageBox.Show("At least, one address type must be checked!");
                DialogResult = DialogResult.None;
                return;
            }
            
            foreach (var item in checkedItems)
            {
                var enumType = (vCardDeliveryAddressTypes)Enum.Parse(typeof(vCardDeliveryAddressTypes), item.Text, true);
                Addresses.Add(enumType);
            }
           

        }

    }
}
