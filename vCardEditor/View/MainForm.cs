using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VCFEditor.View;
using VCFEditor.Model;
using Thought.vCards;
using vCardEditor.Repository;
using vCardEditor.Model;
using System.Drawing;
using System.Collections.Generic;
using vCardEditor.View.Customs;
using vCardEditor.View.UIToolbox;

namespace vCardEditor.View
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler<EventArg<FormState>> LoadForm;
        public event EventHandler<EventArg<vCard>> BeforeLeavingContact;
        public event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> AddressModified;
        public event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> AddressAdded;
        public event EventHandler<EventArg<string>> NewFileOpened;
        public event EventHandler<EventArg<string>> FilterTextChanged;
        public event EventHandler<EventArg<string>> ModifyImage;
        public event EventHandler<EventArg<bool>> CloseForm;
        public event EventHandler<EventArg<int>> AddressRemoved;
        public event EventHandler<EventArg<vCardPropeties>> AddExtraField;
        public event EventHandler SaveContactsSelected;
        public event EventHandler DeleteContact;
        public event EventHandler AddContact;
        public event EventHandler ChangeContactsSelected;
        public event EventHandler TextBoxValueChanged;
        public event EventHandler ExportImage;
        public event EventHandler ExportQR;
        public event EventHandler CopyTextToClipboardEvent;
       
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
        
        private int LastRowIndex = -1;

        public MainForm()
        {

            InitializeComponent();
            
            resources = new ComponentResourceManager(typeof(MainForm));
            tbcAddress.AddTab += (sender, e) => AddressAdded?.Invoke(sender, e);
            tbcAddress.RemoveTab += (sender, e) => AddressRemoved?.Invoke(sender, e);
            tbcAddress.ModifyTab += (sender, e) => AddressModified?.Invoke(sender, e);
            tbcAddress.TextChangedEvent += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            btnClearFilter.Click += (sender, e) => textBoxFilter.Clear();
            extendedPanelPhones.ContentTextChanged += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            extendedPanelWeb.ContentTextChanged += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            BuildMRUMenu();

        }
                
        private void tbsOpen_Click(object sender, EventArgs e)
        {
            NewFileOpened?.Invoke(sender, new EventArg<string>(string.Empty));
        }

        public void DisplayContacts(SortableBindingList<Contact> contacts)
        {
            if (contacts != null)
                bsContacts.DataSource = contacts;

        }

        private void tbsSave_Click(object sender, EventArgs e)
        {
            if (SaveContactsSelected != null)
            {
                //make sure the last changes in the textboxes is saved.
                Validate();

                //Make sure to save changes for the current row.
                dgContacts_RowLeave(null, null);

                SaveContactsSelected(sender, e);
            }

        }

        private void tbsNew_Click(object sender, EventArgs e)
        {
            AddContact?.Invoke(sender, e);
        }

        private void dgContacts_SelectionChanged(object sender, EventArgs e)
        {
            //Weired, the selection is fired multiple times...
            int RowIndex = dgContacts.CurrentCell.RowIndex;
            if (LastRowIndex != RowIndex)
            {

                if (ChangeContactsSelected != null && dgContacts.CurrentCell != null)
                {
                    vCard data = GetvCardFromWindow();
                    ChangeContactsSelected(sender, new EventArg<vCard>(data));
                }
                else
                    ChangeContactsSelected(sender, new EventArg<vCard>(null));

                LastRowIndex = RowIndex;
            }
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            TextBoxValueChanged?.Invoke(sender, e);
        }

        public void DisplayContactDetail(vCard card, string FileName)
        {

            if (card == null)
                throw new ArgumentException("vCard must be valid!");

            ClearContactDetail();
           
            Text = string.Format("{0} - vCard Editor", FileName);
            //gbContactDetail.Enabled = true;
            tcMainTab.Enabled = true;
            gbNameList.Enabled = true;

            SetSummaryValue(FormattedTitleValue, card.Title);
            SetSummaryValue(firstNameValue, card.GivenName);
            SetSummaryValue(lastNameValue, card.FamilyName);
            SetSummaryValue(middleNameValue, card.AdditionalNames);
            SetSummaryValue(FormattedNameValue, card.FormattedName);
            
            SetAddressesValues(card);
            SetPhotoValue(card.Photos);

            SetExtraInfos(card);
            
            SetExtraTabFields(card);

        }

        private void SetExtraInfos(vCard card)
        {
            foreach (var item in card.EmailAddresses)
            {
                extendedPanelWeb.AddControl(item);
            }

            foreach (var item in card.Websites)
            {
                extendedPanelWeb.AddControl(item);
            }

            foreach (var item in card.Phones)
            {
                extendedPanelPhones.AddControl(item);
            }
        }

        

        private void SetExtraTabFields(vCard card)
        {
            if (card.Notes.Count > 0)
            {
                foreach (var note in card.Notes)
                    AddExtraTextGroup(vCardPropeties.NOTE, note.Text);
            }

            if (!string.IsNullOrEmpty(card.Organization))
            {
                AddExtraTextGroup(vCardPropeties.ORG, card.Organization);
            }

            
        }

        public void AddExtraTextGroup(vCardPropeties type, string content)
        {
            ExtraTextGroup etg = new ExtraTextGroup();
            etg.Content = content;
            etg.Caption = type.ToString() + " :";
            etg.CardProp = type;
            etg.TextChangedEvent += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            etg.ControlDeleted += (sender, e) =>
            {
                var send = sender as Control;
                panelTabExtra.Controls.Remove(send.Parent);
            };
            etg.Dock = DockStyle.Top;


            panelTabExtra.Controls.Add(etg);
        }

        public void ClearContactDetail()
        {
            //gbContactDetail.Enabled = false;
            tcMainTab.Enabled = false;
            gbNameList.Enabled = false;

            SetSummaryValue(firstNameValue, string.Empty);
            SetSummaryValue(lastNameValue, string.Empty);
            SetSummaryValue(middleNameValue, string.Empty);
            SetSummaryValue(FormattedTitleValue, string.Empty);
            SetSummaryValue(FormattedNameValue, string.Empty);

            //SetAddressesValues(new vCard());
            

            SetPhotoValue(new vCardPhotoCollection());
            panelTabExtra.Controls.Clear();
            extendedPanelPhones.ClearFields();
            extendedPanelWeb.ClearFields();
        }

        private void SetSummaryValue(StateTextBox valueLabel, string value)
        {
            if (valueLabel == null)
                throw new ArgumentNullException("valueLabel");

            //Clear textbox if value is empty!
            valueLabel.Text = value;
            valueLabel.oldText = value;
        }

        void SetPhotoValue(vCardPhotoCollection photos)
        {
            if (photos.Any())
            {
                var photo = photos[0];
                try
                {
                    // Get the bytes of the photo if it has not already been loaded.
                    if (!photo.IsLoaded)
                        photo.Fetch();

                    PhotoBox.Image = photo.GetBitmap();
                }
                catch
                {
                    //Empty image icon instead.
                    PhotoBox.Image = (Image)resources.GetObject("PhotoBox.Image");
                }
            }
            else
                PhotoBox.Image = (Image)resources.GetObject("PhotoBox.Image");

        }
        private void SetAddressesValues(vCard card)
        {
            tbcAddress.SetAddresses(card);
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
            new AboutDialog().ShowDialog();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            //Save before leaving contact.
            BeforeLeavingContact?.Invoke(sender, new EventArg<vCard>(GetvCardFromWindow()));

            FilterTextChanged?.Invoke(sender, new EventArg<string>(textBoxFilter.Text));
        }

      
       
        private vCard GetvCardFromWindow()
        {
            vCard card = new vCard
            {

                Title = FormattedTitleValue.Text,
                FormattedName = FormattedNameValue.Text,
                GivenName = firstNameValue.Text,
                AdditionalNames = middleNameValue.Text,
                FamilyName = lastNameValue.Text,

            };

            tbcAddress.getDeliveryAddress(card);
            getExtraPhones(card);
            getExtraWeb(card);
            getExtraData(card);
            return card;
        }

        private void getExtraPhones(vCard card)
        {
            card.Phones.Clear();
            foreach (var item in extendedPanelPhones.GetExtraFields())
            {
                if (item is vCardPhone)
                {
                    vCardPhone phone = item as vCardPhone;
                    card.Phones.Add(phone);
                }
            }

        }
        private void getExtraWeb(vCard card)
        {
            card.Websites.Clear();
            card.EmailAddresses.Clear();

            foreach (var item in extendedPanelWeb.GetExtraFields())
            {
                switch (item)
                {
                    case vCardEmailAddress email:
                        card.EmailAddresses.Add(email);
                        break;

                    case vCardWebsite website:
                        card.Websites.Add(website);
                        break;

                    default:
                        break;
                }

            }

        }

       

        private void getExtraData(vCard card)
        {
            foreach (var item in panelTabExtra.Controls)
            {
                var tbc = item as ExtraTextGroup;
                switch (tbc.CardProp)
                {
                    case vCardPropeties.NOTE:
                        card.Notes.Add(tbc.Content);
                        break;
                    case vCardPropeties.ORG:
                        card.Organization = tbc.Content;
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgContacts_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            vCard data = GetvCardFromWindow();
            BeforeLeavingContact?.Invoke(sender, new EventArg<vCard>(data));
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            Close();
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

            NewFileOpened(sender, new EventArg<string>(FileList[0]));

        }

        private void BuildMRUMenu()
        {
            recentFilesMenuItem.DropDownItemClicked += (s, e) =>
            {
                var evt = new EventArg<string>(e.ClickedItem.Text);
                NewFileOpened(s, evt);
            };

            UpdateMRUMenu(ConfigRepository.Instance.Paths);

        }

        public void UpdateMRUMenu(FixedList MostRecentFilesList)
        {
            if (MostRecentFilesList == null || MostRecentFilesList.IsEmpty())
                return;

            recentFilesMenuItem.DropDownItems.Clear();
            for (int i = 0; i < MostRecentFilesList._innerList.Count; i++)
                recentFilesMenuItem.DropDownItems.Add(MostRecentFilesList[i]);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var evt = new EventArg<bool>(false);
            CloseForm?.Invoke(sender, evt);

            e.Cancel = evt.Data;

        }

        public bool AskMessage(string msg, string caption)
        {
            bool result = true; // true == yes

            DialogResult window = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo);

            if (window != DialogResult.No)
                result = false;

            return result;
        }

        private void miConfig_Click(object sender, EventArgs e)
        {
            new ConfigDialog().ShowDialog();
        }

        public void DisplayMessage(string msg, string caption)
        {
            MessageBox.Show(msg, caption);
        }
        public string DisplayOpenDialog(string filter = "")
        {
            string filename = string.Empty;
            openFileDialog.Filter = filter;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                filename = openFileDialog.FileName;

            return filename;
        }

        public string DisplaySaveDialog(string filename)
        {

            var saveFileDialog = new SaveFileDialog
            {
                FileName = filename
            };

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                filename = saveFileDialog.FileName;

            return filename;
        }
        private void PhotoBox_Click(object sender, EventArgs e)
        {
            if (ModifyImage != null)
            {
                var fileName = DisplayOpenDialog();
                if (!string.IsNullOrEmpty(fileName))
                {
                    try
                    {
                        PhotoBox.Image = new Bitmap(fileName);
                        var evt = new EventArg<string>(fileName);
                        ModifyImage(sender, evt);
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show($"Invalid file! : {fileName}");
                    }

                }

            }

        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            PhotoBox.Image = (Image)resources.GetObject("PhotoBox.Image");
            //Remove image from vcf
            ModifyImage(sender, new EventArg<string>(""));
        }

        private void btnExportImage_Click(object sender, EventArgs e)
        {
            ExportImage?.Invoke(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyTextToClipboardEvent?.Invoke(sender, e);
        }

        public void SendTextToClipBoard(string text)
        {
            Clipboard.SetText(text);
        }

       
        private void dgContacts_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.ContextMenuStrip = contextMenuStrip1;
            }
            
        }

        private void modifiyColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Column> Columns = GetListColumnsForDataGrid();

            var dialog = new ColumnsDialog(Columns);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ToggleAllColumnsToInvisible();
                ToggleOnlySelected(dialog.Columns);

            }
        }

        private List<Column> GetListColumnsForDataGrid()
        {
            List<Column> Columns = new List<Column>();
            for (int i = 2; i < dgContacts.Columns.Count; i++)
            {
                if (dgContacts.Columns[i].Visible)
                {
                    var name = dgContacts.Columns[i].Name;
                    var enumType = (Column)Enum.Parse(typeof(Column), name, true);
                    Columns.Add(enumType);
                }

            }

            return Columns;
        }

        private void ToggleOnlySelected(List<Column> columns)
        {
            foreach (var item in columns)
            {
                switch (item)
                {
                    case Column.FamilyName:
                        dgContacts.Columns["FamilyName"].Visible = true;
                        break;
                    case Column.Cellular:
                        dgContacts.Columns["Cellular"].Visible = true;
                        break;
                }
            }
        }

        private void ToggleAllColumnsToInvisible()
        {
            for (int i = 2; i < dgContacts.Columns.Count; i++)
            {
                dgContacts.Columns[i].Visible = false;
            }
        }

        public FormState GetFormState()
        {

            return new FormState
            {
                Columns = GetListColumnsForDataGrid(),
                X = Location.X,
                Y = Location.Y,
                Height = Size.Height,
                Width = Size.Width,
                splitterPosition = splitContainer1.SplitterDistance
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var evt = new EventArg<FormState>(new FormState());
            LoadForm?.Invoke(sender, evt);

        }

        public void LoadIntialState(FormState state)
        {
            if (state.Width != 0 && state.Height != 0)
            {
                Size = new Size(state.Width, state.Height);
                Location = new Point(state.X, state.Y);
                splitContainer1.SplitterDistance = state.splitterPosition;
                if (state.Columns != null)
                {
                    ToggleOnlySelected(state.Columns);
                }
            }
        }
        private void tbsQR_Click(object sender, EventArgs e)
        {
            ExportQR?.Invoke(sender, e);
        }

        public void DisplayQRCode(string content)
        {
            QRDialog qr = new QRDialog(content);
            qr.ShowDialog();
        }


        private void addNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var evt = new EventArg<vCardPropeties>(vCardPropeties.NOTE);
            AddExtraField?.Invoke(sender, evt);
        }

        private void addOrgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var evt = new EventArg<vCardPropeties>(vCardPropeties.ORG);
            AddExtraField?.Invoke(sender, evt);
        }

        private void btnAddExtraText_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            menuExtraField.Show(ptLowerLeft);
        }


        private void miNote_Click(object sender, EventArgs e)
        {
            var evt = new EventArg<vCardPropeties>(vCardPropeties.NOTE);
            AddExtraField?.Invoke(sender, evt);
        }

        private void miOrg_Click(object sender, EventArgs e)
        {
            var evt = new EventArg<vCardPropeties>(vCardPropeties.ORG);
            AddExtraField?.Invoke(sender, evt);
        }

        private void panelTabExtra_ControlAdded(object sender, ControlEventArgs e)
        {
            TapPageExtra.Text = string.Format("Extra ({0})", panelTabExtra.Controls.Count);
        }

        private void panelTabExtra_ControlRemoved(object sender, ControlEventArgs e)
        {
            TapPageExtra.Text = string.Format("Extra ({0})", panelTabExtra.Controls.Count);
        }

        
    }
}
