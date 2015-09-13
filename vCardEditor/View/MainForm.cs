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
        public event EventHandler<EventArg<string>> FilterTextChanged;
        
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

        public void DisplayContacts(List<Contact> contacts)
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
            if (ChangeContactsSelected != null && dgContacts.CurrentCell != null)
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

            //Email Address 
            SetSummaryValue(EmailAddressValue, card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet));

            // Personal Home Page
            SetSummaryValue(PersonalWebSiteValue, card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal));


            if (card.Photos.Count > 0)
            {
                var photo = card.Photos[0];
                try
                {
                    // Get the bytes of the photo if it has
                    // not already been loaded.
                    if (!photo.IsLoaded)
                        photo.Fetch();

                    PhotoBox.Image = photo.GetBitmap();
                }
                catch
                {
                    // TODO: Ignore this error.
                    // A later version of the viewer should show
                    // a broken image icon (like IE) instead.

                }

            }
            else
                PhotoBox.Image = null;

        }
        private void SetSummaryValue(TextBox valueLabel, string value)
        {
            if (valueLabel == null)
                throw new ArgumentNullException("valueLabel");

            //Clear textbox if value is empty!
            valueLabel.Text = value;
        }

        private void SetSummaryValue(TextBox valueLabel, vCardEmailAddress email)
        {
            valueLabel.Text = string.Empty;
            if (email != null)
                SetSummaryValue(valueLabel, email.Address);
        }

        private void SetSummaryValue(TextBox valueLabel, vCardPhone phone)
        {
            valueLabel.Text = string.Empty;
            if (phone != null)
                SetSummaryValue(valueLabel, phone.FullNumber);

        }

        private void SetSummaryValue(TextBox valueLabel, vCardWebsite webSite)
        {
            valueLabel.Text = string.Empty;
            if (webSite != null)
                SetSummaryValue(valueLabel, webSite.Url.ToString());
        }
        private void tbsDelete_Click(object sender, EventArgs e)
        {
            if (DeleteContact != null)
            {
                //The user can check a box without leaving the cell, calling the EndEdit will cause the 
                //grid to commit the changes.
                dgContacts.EndEdit();
                DeleteContact(sender, e);
            }
        }

        private void tbsAbout_Click(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (FilterTextChanged != null)
                FilterTextChanged(sender, new EventArg<string>(textBoxFilter.Text));   
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = string.Empty;
        }


     
    }
}
