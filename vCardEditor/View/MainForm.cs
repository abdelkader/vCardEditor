using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VCFEditor.View;
using VCFEditor.Model;
using Thought.vCards;
using vCardEditor.Repository;
using vCardEditor.Model;
using System.Drawing;

namespace vCardEditor.View
{
    public partial class MainForm : Form, IMainView
    {
        #region event list
        public event EventHandler SaveContactsSelected;
        public event EventHandler BeforeOpeningNewFile;
        public event EventHandler DeleteContact;
        public event EventHandler<EventArg<string>> NewFileOpened;
        public event EventHandler ChangeContactsSelected;
        public event EventHandler<EventArg<vCard>> BeforeLeavingContact;
        public event EventHandler<EventArg<string>> FilterTextChanged;
        public event EventHandler TextBoxValueChanged;
        public event EventHandler<EventArg<bool>> CloseForm;
        #endregion
        ComponentResourceManager resources;

        public int SelectedContactIndex
        {
            get
            {
                if (dgContacts.CurrentCell != null)
                    return dgContacts.CurrentCell.RowIndex;
                else
                    return -1;
            }

        }

        public MainForm()
        {
            InitializeComponent();
            resources = new ComponentResourceManager(typeof(MainForm));

            BuildMRUMenu();

        }

        private void tbsOpen_Click(object sender, EventArgs e)
        {
            if (NewFileOpened != null)
                NewFileOpened(sender, new EventArg<string>(string.Empty));
        }

        

        public void DisplayContacts(BindingList<Contact> contacts)
        {
            if (contacts != null)
                this.bsContacts.DataSource = contacts;

        }

        private void tbsSave_Click(object sender, EventArgs e)
        {
            if (SaveContactsSelected != null)
            {
                //make sure the last changes in the textboxes is saved.
                this.Validate();
                SaveContactsSelected(sender, e);
            }

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

        public void DisplayContactDetail(vCard card, string FileName)
        {
            if (card == null)
                throw new ArgumentException("card must be valid!");

            this.Text = string.Format("{0} - vCard Editor", FileName);
            gbContactDetail.Enabled = true;
            gbNameList.Enabled = true;

            SetSummaryValue(firstNameValue, card.GivenName);
            SetSummaryValue(lastNameValue, card.FamilyName);
            SetSummaryValue(FormattedTitleValue, card.Title);
            SetSummaryValue(FormattedNameValue, card.FormattedName);
            SetSummaryValue(HomePhoneValue, card.Phones.GetFirstChoice(vCardPhoneTypes.Home));
            SetSummaryValue(CellularPhoneValue, card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular));
            SetSummaryValue(WorkPhoneValue, card.Phones.GetFirstChoice(vCardPhoneTypes.Work));
            SetSummaryValue(EmailAddressValue, card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet));
            SetSummaryValue(PersonalWebSiteValue, card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal));
            SetAddressesValues(card.DeliveryAddresses);
            SetPhotoValue(card.Photos);

        }

        #region helper methods to populate textboxes.
        
        private void SetSummaryValue(StateTextBox valueLabel, string value)
        {
            if (valueLabel == null)
                throw new ArgumentNullException("valueLabel");

            //Clear textbox if value is empty!
            valueLabel.Text = value;
            valueLabel.oldText = value;
        }

        private void SetSummaryValue(StateTextBox valueLabel, vCardEmailAddress email)
        {
            valueLabel.Text = string.Empty;
            if (email != null)
                SetSummaryValue(valueLabel, email.Address);
        }

        private void SetSummaryValue(StateTextBox valueLabel, vCardPhone phone)
        {
            valueLabel.Text = string.Empty;
            if (phone != null)
                SetSummaryValue(valueLabel, phone.FullNumber);

        }

        private void SetSummaryValue(StateTextBox valueLabel, vCardWebsite webSite)
        {
            valueLabel.Text = string.Empty;
            if (webSite != null)
                SetSummaryValue(valueLabel, webSite.Url.ToString());
        }

        void SetPhotoValue(vCardPhotoCollection photos)
        {
            if (photos.Any())
            {
                var photo = photos[0];
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
        private void SetAddressesValues(vCardDeliveryAddressCollection addresses)
        {
            ClearAddressTextFields();

            if (addresses.Any())
            {
                var HomeAddress = addresses.Where(x => x.IsHome).FirstOrDefault();
                if (HomeAddress != null)
                {
                    HomeAddressValue.Text = HomeAddress.Street;
                    HomeCityValue.Text = HomeAddress.City;
                    HomeZipValue.Text = HomeAddress.PostalCode;
                    HomeStateValue.Text = HomeAddress.Region;
                    HomeCountryValue.Text = HomeAddress.Country;
                }

                var WorkAddress = addresses.Where(x => x.IsWork).FirstOrDefault();
                if (WorkAddress != null)
                {
                    WorkAddressValue.Text = WorkAddress.Street;
                    WorkCityValue.Text = WorkAddress.City;
                    WorkZipValue.Text = WorkAddress.PostalCode;
                    WorkStateValue.Text = WorkAddress.Region;
                    WorkCountryValue.Text = WorkAddress.Country;
                }

                var PostalAddress = addresses.Where(x => x.IsPostal).FirstOrDefault();
                if (PostalAddress != null)
                {
                    PostalAddressValue.Text = PostalAddress.Street;
                    PostalAddressValue.Text = PostalAddress.Street;
                    PostalCityValue.Text = PostalAddress.City;
                    PostalZipValue.Text = PostalAddress.PostalCode;
                    PostalStateValue.Text = PostalAddress.Region;
                    PostalCountryValue.Text = PostalAddress.Country;
                }

            }

        }

        private void ClearAddressTextFields()
        {
            HomeAddressValue.Clear();
            HomePOBoxValue.Clear();
            HomeCityValue.Clear();
            HomeZipValue.Clear();
            HomeStateValue.Clear();
            HomeCountryValue.Clear();

            WorkAddressValue.Clear();
            WorkPOBoxValue.Clear();
            WorkCityValue.Clear();
            WorkZipValue.Clear();
            WorkStateValue.Clear();
            WorkCountryValue.Clear();

            PostalAddressValue.Clear();
            PostalPOBoxValue.Clear();
            PostalCityValue.Clear();
            PostalZipValue.Clear();
            PostalStateValue.Clear();
            PostalCountryValue.Clear();
        }
        #endregion

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
            //Save before leaving contact.
            if (BeforeLeavingContact != null)
                BeforeLeavingContact(sender, new EventArg<vCard>(getvCard()));

            //filter.
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
            card.Title = this.FormattedTitleValue.Text;
            card.FormattedName = this.FormattedNameValue.Text;
            
            if (!string.IsNullOrEmpty(HomePhoneValue.Text))
                card.Phones.Add(new vCardPhone(HomePhoneValue.Text, vCardPhoneTypes.Home));
            if (!string.IsNullOrEmpty(CellularPhoneValue.Text))
                card.Phones.Add(new vCardPhone(CellularPhoneValue.Text, vCardPhoneTypes.Cellular));
            if (!string.IsNullOrEmpty(WorkPhoneValue.Text))
                card.Phones.Add(new vCardPhone(WorkPhoneValue.Text, vCardPhoneTypes.Work));

            if (!string.IsNullOrEmpty(this.EmailAddressValue.Text))
                card.EmailAddresses.Add(new vCardEmailAddress(this.EmailAddressValue.Text));
            
            if (!string.IsNullOrEmpty(this.PersonalWebSiteValue.Text))
                card.Websites.Add(new vCardWebsite(this.PersonalWebSiteValue.Text));
            
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

        #region drag&drop
        /// <summary>
        /// Make our form accept drag&drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


            NewFileOpened(sender, new EventArg<string>(FileList[0]));

        }
        #endregion

      

        private void BuildMRUMenu()
        {
            recentFilesMenuItem.DropDownItemClicked += (s, e) => NewFileOpened(s, new EventArg<string>(e.ClickedItem.Text));
            //Update the MRU Menu entries..
            UpdateMRUMenu(ConfigRepository.Instance.Paths);

        }

        public void UpdateMRUMenu(FixedList MRUList)
        {
            //No need to go further if no menu entry to load!
            if (MRUList == null || MRUList.IsEmpty())
                return;

            recentFilesMenuItem.DropDownItems.Clear();
            for (int i = 0; i < MRUList._innerList.Count; i++)
                recentFilesMenuItem.DropDownItems.Add(MRUList[i]);
                
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var evt = new EventArg<bool>(false);
            if (CloseForm != null)
                CloseForm(sender,evt);

            e.Cancel = evt.Data;

            ConfigRepository.Instance.SaveConfig();
        }

        public bool AskMessage(string msg, string caption)
        {
            bool result = true; // true == yes

            DialogResult window = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo);

            if (window != DialogResult.No)
                result = false;

            return result;
        }

        /// <summary>
        /// Load the config dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miConfig_Click(object sender, EventArgs e)
        {
            ConfigDialog dialog = new ConfigDialog();
            dialog.ShowDialog();
        }

        public void DisplayMessage(string msg, string caption)
        {
            MessageBox.Show(msg, caption);
        }
        public string DisplayOpenDialog()
        {
            string filename = string.Empty;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                filename = openFileDialog.FileName;

            return filename;
        }

        private void rbChangeAddress(object sender, EventArgs e)
        {

        }
    }
}
