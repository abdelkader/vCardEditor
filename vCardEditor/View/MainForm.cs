using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VCFEditor.View;
using VCFEditor.Model;
using Thought.vCards;

namespace vCardEditor.View
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler SaveContactsSelected;
        public event EventHandler DeleteContact;
        public event EventHandler<EventArg<string>> NewFileOpened;
        public event EventHandler<EventArg<int>> ChangeContactsSelected;

        public int SelectedContactIndex
        {
            get
            {
                return dgContacts.CurrentCell.RowIndex;
            }

        }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbsOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                if (NewFileOpened != null)
                    NewFileOpened(sender, new EventArg<string>(file));
            }

        }

        public void DisplayContacts(BindingList<Contact> contacts)
        {
            if (contacts != null)
                this.bsContacts.DataSource = contacts;

        }

        private void tbsSave_Click(object sender, EventArgs e)
        {
            if (SaveContactsSelected != null)
                SaveContactsSelected(sender, e);

        }

        private void dgContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (ChangeContactsSelected != null)
            {
                int index = dgContacts.CurrentCell.RowIndex;
                ChangeContactsSelected(sender, new EventArg<int>(index));
            }
        }

        public void DisplayContactDetail(vCard card)
        {
            if (card == null)
                throw new ArgumentException("card");

            //Formatted Name
            SetSummaryValue(FormattedNameValue, card.FormattedName);

            //Home Phone
            SetSummaryValue(HomePhoneValue, card.Phones.GetFirstChoice(vCardPhoneTypes.Home));

            //Cellular Phone
            SetSummaryValue(CellularPhoneValue, card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular));


        }
        private void SetSummaryValue(TextBox valueLabel, string value)
        {
            if (valueLabel == null)
                throw new ArgumentNullException("valueLabel");

            //Clear textbox if value is empty!
            valueLabel.Text = value;
        }

        private void SetSummaryValue(TextBox valueLabel, vCardPhone phone)
        {
            valueLabel.Text = string.Empty;
            if (phone != null)
                SetSummaryValue(valueLabel, phone.FullNumber);

        }

        private void tbsDelete_Click(object sender, EventArgs e)
        {
            if (DeleteContact != null)
            {
                //commit changes...
                dgContacts.EndEdit();
                DeleteContact(sender, e);
            }
        }

        private void tbsAbout_Click(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog();
        }
    }
}
