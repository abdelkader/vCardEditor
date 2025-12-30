using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Thought.vCards;
using vCardEditor.Model;
using vCardEditor.Repository;
using vCardEditor.View.Customs;
using vCardEditor.View.UIToolbox;
using VCFEditor.Model;
using VCFEditor.View;

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
        public event EventHandler ExportCsv;
        public event EventHandler ExportJson;
        public event EventHandler ImportCsv;
        public event EventHandler ImportJson;
        public event EventHandler CopyTextToClipboardEvent;
        public event EventHandler CountImagesEvent;
        public event EventHandler ClearImagesEvent;
        public event EventHandler BatchExportImagesEvent;
        public event EventHandler<EventArg<string>> OpenFolderEvent;
        public event EventHandler SplitFileEvent;
        public event EventHandler CardInfoRemoved;
        public event EventHandler BirhdateChanged;
        public event EventHandler<EventArg<string>> LanguageChanged;

        ComponentResourceManager resources;

        private int LastRowIndex = -1;
        private ILocalizationProvider _localization;
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

            tbcAddress.AddTab += (sender, e) => AddressAdded?.Invoke(sender, e);
            tbcAddress.RemoveTab += (sender, e) => AddressRemoved?.Invoke(sender, e);
            tbcAddress.ModifyTab += (sender, e) => AddressModified?.Invoke(sender, e);
            tbcAddress.TextChangedEvent += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            btnClearFilter.Click += (sender, e) => textBoxFilter.Clear();

            extendedPanelPhones.ContentTextChanged += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            extendedPanelWeb.ContentTextChanged += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            extendedPanelPhones.CardInfoRemoved += (sender, e) => CardInfoRemoved?.Invoke(sender, e);
            extendedPanelWeb.CardInfoRemoved += (sender, e) => CardInfoRemoved?.Invoke(sender, e);

            //this.frToolStripMenuItem.Click += new System.EventHandler(this.frToolStripMenuItem_Click);

            
            BuildMRUMenu();
        }

        private void BuildLanguageMenu()
        {
            changeLangToolStripMenuItem.DropDownItems.Clear();

            foreach (string code in _localization.AvailableLanguages)
            {
                ToolStripMenuItem langItem = new ToolStripMenuItem(code);
                langItem.Tag = code;
                
                if (_localization.CurrentLanguage == code)
                {
                    langItem.Checked = true;
                }
                
                langItem.Click += (s, e) => ChangeLanguage_Click(s, code);

                changeLangToolStripMenuItem.DropDownItems.Add(langItem);
            }
        }

        private void ChangeLanguage_Click(object sender, string code)
        {
            foreach (ToolStripItem item in changeLangToolStripMenuItem.DropDownItems)
            {
                if (item is ToolStripMenuItem langItem)
                {
                    langItem.Checked = (langItem.Tag as string) == code;
                }
            }

            _localization.SetLanguage(code);
            LoadLocalizedUIText();
        }

        public void LoadLocalizedUIText()
        {
            this.fileToolStripMenuItem.Text = _localization["MSG_900"];
            this.miSave.Text = "&Save";
            this.miOpen.Text = "&Open";
            this.exportToolStripMenuItem1.Text = "Export";
            this.btnCSVExportToolStripMenuItem.Text = "CSV";
            this.btnJSONExportToolStripMenuItem.Text = "JSON";
            this.miConfig.Text = "Preference";
            this.recentFilesMenuItem.Text = "Recent";
            this.miQuit.Text = "&Quit";
            this.editToolStripMenuItem.Text = "Edit";
            this.copyToolStripMenuItem.Text = "Copy";
            this.extraFieldsToolStripMenuItem.Text = "Extra Fields";
            this.addNotesToolStripMenuItem.Text = "Add Notes";
            this.addOrgToolStripMenuItem.Text = "Add Org";
            this.toolsToolStripMenuItem.Text = "Tools";
            this.imagesToolStripMenuItem.Text = "Images";
            this.exportToolStripMenuItem.Text = "Export";
            this.clearToolStripMenuItem.Text = "Clear";
            this.countToolStripMenuItem.Text = "Count";
            this.helpToolStripMenuItem.Text = "Help";
            this.miAbout.Text = "&About";
            //this.statusStrip1.Text = "statusStrip1";
            this.tbsNew.Text = "&Nouveau";
            this.tbsOpen.Text = "&Open";
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.tbsSave.Text = "&Save";
            this.splitToFilesToolStripMenuItem.Text = "Split to files";
            this.tbsDelete.Text = "Delete";
            this.tbsQR.Text = "&QR Code";
            this.tbsAbout.Text = "&?";
            this.openFileDialog.Title = "Open vCard File";
            this.gbNameList.Text = "Name List :";
            this.modifiyColumnsToolStripMenuItem.Text = "Modifiy Columns";
            this.TapPageMain.Text = "Main";
            this.groupBox3.Text = "Name";
            this.FormattedTitleLabel.Text = "Title:";
            this.label3.Text = "Last:";
            this.label2.Text = "Middle:";
            this.label1.Text = "First:";
            this.FormattedNameLabel.Text = "Full Name:";
            this.groupBox4.Text = "Address:";
            this.TapPageExtra.Text = "Extra";
            this.miNote.Text = "Note";
            this.miOrg.Text = "Organisation";
            this.importerToolStripMenuItem.Text = "Importer";
            this.btnCSVImportToolStripMenuItem.Text = "CSV";
            this.btnJSONImportToolStripMenuItem.Text = "JSON";
        }

        private void tbsOpen_Click(object sender, EventArgs e)
        {
            OpenFile(sender, string.Empty);
        }

        private void OpenFile(object sender, string filename)
        {
            var evt = new EventArg<string>(filename);

            NewFileOpened?.Invoke(sender, new EventArg<string>(filename));

            if (!evt.CanCancel)
                LastRowIndex = -1;
        }

        public void DisplayContacts(SortableBindingList<Contact> contacts)
        {
            bsContacts.DataSource = null;
            if (contacts != null)
                bsContacts.DataSource = contacts;
        }

        private void tbsSave_Click(object sender, EventArgs e)
        {
            if (dgContacts.RowCount == 0)
                return;

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
            if (dgContacts.CurrentCell == null)
                return;

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

            Text = string.Format("{0} - vCard Editor", FileName ?? "New file");

            tcMainTab.Enabled = true;
            gbNameList.Enabled = true;

            SetSummaryValue(FormattedTitleValue, card.Title);
            SetSummaryValue(firstNameValue, card.GivenName);
            SetSummaryValue(lastNameValue, card.FamilyName);
            SetSummaryValue(middleNameValue, card.AdditionalNames);
            SetSummaryValue(FormattedNameValue, card.FormattedName);

            ucBirtdate.Value = card.BirthDate;

            SetAddressesValues(card);
            SetPhotoValue(card.Photos);

            SetExtraInfos(card);
            SetExtraTabFields(card);
        }

        private void SetExtraInfos(vCard card)
        {
            foreach (vCardPhone item in card.Phones)
                extendedPanelPhones.AddControl(item);

            foreach (vCardEmailAddress item in card.EmailAddresses)
                extendedPanelWeb.AddControl(item);

            foreach (vCardWebsite item in card.Websites)
                extendedPanelWeb.AddControl(item);
        }

        private void SetExtraTabFields(vCard card)
        {
            foreach (vCardNote note in card.Notes)
                AddExtraTextGroup(vCardPropeties.NOTE, note.Text);

            if (!string.IsNullOrEmpty(card.Organization))
            {
                AddExtraTextGroup(vCardPropeties.ORG, card.Organization);
            }
        }

        public void AddExtraTextGroup(vCardPropeties type, string content)
        {
            ExtraTextGroup etg = new ExtraTextGroup
            {
                Content = content,
                Caption = type.ToString() + ":",
                CardProp = type,
                Dock = DockStyle.Top
            };
            etg.TextChangedEvent += (sender, e) => TextBoxValueChanged?.Invoke(sender, e);
            etg.ControlDeleted += (sender, e) =>
            {
                if (AskMessage("Are you sure?", "Question"))
                    panelTabExtra.Controls.Remove((sender as Control).Parent);
            };

            panelTabExtra.Controls.Add(etg);
        }

        public void ClearContactDetail()
        {
            tcMainTab.Enabled = false;
            gbNameList.Enabled = false;

            SetSummaryValue(firstNameValue, string.Empty);
            SetSummaryValue(lastNameValue, string.Empty);
            SetSummaryValue(middleNameValue, string.Empty);
            SetSummaryValue(FormattedTitleValue, string.Empty);
            SetSummaryValue(FormattedNameValue, string.Empty);

            ucBirtdate.Value = null;

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
                vCardPhoto photo = photos[0];
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

            LastRowIndex = -1;
            dgContacts.ClearSelection();
            textBoxFilter.Focus();
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
                BirthDate = ucBirtdate.Value,
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
            foreach (vCardRoot item in extendedPanelPhones.GetExtraFields())
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

            foreach (vCardRoot item in extendedPanelWeb.GetExtraFields())
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
            foreach (object item in panelTabExtra.Controls)
            {
                ExtraTextGroup tbc = item as ExtraTextGroup;
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

            OpenFile(sender, FileList[0]);
        }

        private void BuildMRUMenu()
        {
            //TODO: Open File or Folder.
            recentFilesMenuItem.DropDownItemClicked += (s, e) => OpenFile(s, e.ClickedItem.Text);
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
            DialogResult window = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo);
            return window == DialogResult.Yes;
        }

        private void miConfig_Click(object sender, EventArgs e)
        {
            new ConfigDialog().ShowDialog();
        }

        public void DisplayMessage(string msg, string caption)
        {
            MessageBox.Show(msg, caption);
        }

        public string DisplayOpenFileDialog(string filter = "")
        {
            string filename = string.Empty;
            openFileDialog.Filter = filter;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                filename = openFileDialog.FileName;

            return filename;
        }

        public string DisplaySaveDialog(string title, string filter, string filename = "")
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = title, 
                Filter = filter, 
                FileName = filename
                
            };
            string _filename = filename;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                _filename = saveFileDialog.FileName;
            
            return _filename;
        }

        private void PhotoBox_Click(object sender, EventArgs e)
        {
            if (ModifyImage != null)
            {
                string fileName = DisplayOpenFileDialog();
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

        public void ClearImageFromForm()
        {
            PhotoBox.Image = (Image)resources.GetObject("PhotoBox.Image");
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

            ColumnsDialog dialog = new ColumnsDialog(Columns);
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
                    string name = dgContacts.Columns[i].Name;
                    Column enumType = (Column)Enum.Parse(typeof(Column), name, true);
                    Columns.Add(enumType);
                }
            }
            return Columns;
        }

        private void ToggleOnlySelected(List<Column> columns)
        {
            foreach (Column item in columns)
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

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountImagesEvent?.Invoke(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearImagesEvent?.Invoke(sender, e);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchExportImagesEvent?.Invoke(sender, e);
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var evt = new EventArg<string>(string.Empty);
            OpenFolderEvent?.Invoke(sender, evt);
        }

        private void splitToFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitFileEvent?.Invoke(sender, e);
        }

        public string DisplayOpenFolderDialog()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.SelectedPath;
            return string.Empty;
        }

        public void SetLocalizedUI(ILocalizationProvider localization)
        {
            _localization = localization;

            BuildLanguageMenu();
                    
            //var lang = localization.AvailableLanguageNames;
        }

        

     

        private void Value_BirhdateChanged(object sender, EventArgs e)
        {
            BirhdateChanged?.Invoke(sender, e);
        }

        private void btnCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportCsv?.Invoke(sender, e);
        }

        private void btnJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportJson?.Invoke(sender, e);
        }

        public void SetFormTitle(string filename)
        {
            Text = string.Format("{0} - vCard Editor", filename);
        }

        private void btnCSVImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportCsv?.Invoke(sender, e);
        }

        private void btnJSONImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportJson?.Invoke(sender, e);
        }

        
    }
}
