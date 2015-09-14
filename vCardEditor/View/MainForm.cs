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
using System.IO;

namespace vCardEditor.View
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler SaveContactsSelected;
        public event EventHandler DeleteContact;
        public event EventHandler<EventArg<string>> NewFileOpened;
        public event EventHandler ChangeContactsSelected;
        public event EventHandler<EventArg<vCard>> BeforeLeavingContact;
        public event EventHandler<EventArg<string>> FilterTextChanged;
        public event EventHandler TextBoxValueChanged;

        ComponentResourceManager resources;

        public int SelectedContactIndex
        {
            get { return dgContacts.CurrentCell.RowIndex; }

        }

        public MainForm()
        {
            InitializeComponent();
            resources = new ComponentResourceManager(typeof(MainForm));
        }

        private void tbsOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                OpenNewFile(sender, openFileDialog.FileName);

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
                ChangeContactsSelected(sender, new EventArg<vCard>(getvCard()));

        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxValueChanged != null)
                TextBoxValueChanged(sender, e);
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
                    //Empty image icon instead.
                    PhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("PhotoBox.Image")));
                }
            }
            else
                PhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("PhotoBox.Image")));

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

        /// <summary>
        /// Generate a vcard from differents fields
        /// </summary>
        /// <returns></returns>
        private vCard getvCard()
        {
            vCard card = new vCard();
            card.FormattedName = this.FormattedNameValue.Text;

            if (!string.IsNullOrEmpty(HomePhoneValue.Text))
            {
                card.Phones.Add(
                    new vCardPhone(HomePhoneValue.Text, vCardPhoneTypes.Home));
            }

            if (!string.IsNullOrEmpty(CellularPhoneValue.Text))
            {
                card.Phones.Add(
                    new vCardPhone(CellularPhoneValue.Text, vCardPhoneTypes.Cellular));
            }

            if (!string.IsNullOrEmpty(this.EmailAddressValue.Text))
            {
                card.EmailAddresses.Add(
                    new vCardEmailAddress(this.EmailAddressValue.Text));
            }

            return card;
        }

        private void dgContacts_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (BeforeLeavingContact != null)
                BeforeLeavingContact(sender, new EventArg<vCard>(getvCard()));
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (FileList.Count() > 1)
            {
                MessageBox.Show("Only one file at the time!");
                return;
            }

            OpenNewFile(sender, FileList[0]);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="file"></param>
        private void OpenNewFile(object sender, string file)
        {
            string ext = Path.GetExtension(file);
            if (ext != ".vcf")
            {
                MessageBox.Show("Only vcf extension accepted!");
                return;
            }

            if (NewFileOpened != null)
                NewFileOpened(sender, new EventArg<string>(file));
        }

    }
}
