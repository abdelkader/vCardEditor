using System;
using System.Collections.Generic;
using System.Linq;
using Thought.vCards;
using vCardEditor;
using vCardEditor.Model;
using vCardEditor.Repository;
using vCardEditor.View.Customs;
using VCFEditor.Repository;
using VCFEditor.View;

namespace VCFEditor.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IContactRepository _repository;
        private readonly ILocalizationProvider _localization;

        public MainPresenter(IMainView view, IContactRepository repository, ILocalizationProvider localization)
        {
            _view = view;
            _repository = repository;
            _localization = localization;

            _view.LoadForm += LoadFormHandler;
            _view.AddContact += AddContactHandler;
            _view.NewFileOpened += OpenNewFileHandler;
            _view.SaveContactsSelected += SaveContactsHandler;
            _view.ChangeContactsSelected += ChangeContactSelectedHandler;
            _view.DeleteContact += DeleteContactHandler;
            _view.FilterTextChanged += FilterTextChangedHandler;
            _view.TextBoxValueChanged += TextBoxValueChangedHandler;
            _view.BeforeLeavingContact += BeforeLeavingContactHandler;
            _view.CloseForm += CloseFormHandler;
            _view.ModifyImage += ModifyImageHandler;
            _view.ExportImage += ExportImageHandler;
            _view.ExportQR += ExportQRHandler;
            _view.ExportCsv += ExportCsvHandler;
            _view.ExportJson += ExportJsonHandler;
            _view.ImportCsv += ImportCsvHandler;
            _view.ImportJson += ImportJsonHandler;
            _view.AddressAdded += AddressAddedHandler;
            _view.AddressModified += AddressModifiedHandler;
            _view.AddressRemoved += AddressRemovedHandler;
            _view.CopyTextToClipboardEvent += CopyTextToClipboardHandler;
            _view.AddExtraField += _view_AddExtraField;
            _view.CountImagesEvent += _view_CountImages;
            _view.ClearImagesEvent += _view_ClearImages;
            _view.BatchExportImagesEvent += _view_BatchExportImagesEvent;
            _view.SplitFileEvent += SaveSplittedFileHandler;
            _view.OpenFolderEvent += OpenNewFolderHandler;
            _view.CardInfoRemoved += CardInfoRemovedHandler;
            _view.BirhdateChanged += BirthdateChangedHandler;
        }

        private void ImportJsonHandler(object sender, EventArgs e)
        {
            string path = _view.DisplayOpenFileDialog("JSON files (*.json)|*.json");
            if (string.IsNullOrWhiteSpace(path))
                return;

            try
            {
                BeforeOpeningNewFileHandler();

                var contacts = _repository.ImportFromJson(path);
                if (contacts == null || contacts.Count == 0)
                {
                    _view.DisplayMessage("No contacts imported.", "Import");
                    return;
                }
                _repository.Contacts = contacts;
                _repository.fileName = path;

                _view.DisplayContacts(_repository.Contacts);
                _view.DisplayContactDetail(_repository.Contacts[0].card, _repository.fileName);
            }
            catch (Exception ex)
            {
                _view.DisplayMessage($"Import JSON failed: {ex.Message}", "Import");
            }



        }

        private void ImportCsvHandler(object sender, EventArgs e)
        {
            string path = _view.DisplayOpenFileDialog("CSV files (*.csv)|*.csv");
            if (string.IsNullOrWhiteSpace(path))
                return;

            try
            {
                BeforeOpeningNewFileHandler();

                var contacts = _repository.ImportFromCsv(path);

                if (contacts == null || contacts.Count == 0)
                {
                    _view.DisplayMessage("No contacts imported.", "Import");
                    return;
                }

                _repository.Contacts = contacts;
                _repository.fileName = path;
                _view.DisplayContacts(_repository.Contacts);
                _view.DisplayContactDetail(_repository.Contacts[0].card, _repository.fileName);

            }
            catch (Exception ex)
            {
                _view.DisplayMessage($"Import CSV failed: {ex.Message}", "Import");
            }
        }

        private void ExportCsvHandler(object sender, EventArgs e)
        {
            if (_repository.Contacts == null || _repository.Contacts.Count == 0)
            {
                _view.DisplayMessage("No contacts to export.", "Export");
                return;
            }

            var Title = "Export contacts to CSV";
            var Filter = "CSV files (*.csv)|*.csv";
            var FileName = $"vCardExport_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            string filename = _view.DisplaySaveDialog(Title, Filter, FileName);
            if (string.IsNullOrWhiteSpace(filename))
                return;

            try
            {
                _repository.ExportToCsv(filename, _repository.Contacts);
                _view.DisplayMessage("Export CSV completed.", "Export");
            }
            catch (Exception ex)
            {
                _view.DisplayMessage($"Export CSV failed: {ex.Message}", "Export");
            }
        }

        private void ExportJsonHandler(object sender, EventArgs e)
        {
            if (_repository.Contacts == null || _repository.Contacts.Count == 0)
            {
                _view.DisplayMessage("No contacts to export.", "Export");
                return;
            }

            var Title = "Export contacts to JSON";
            var Filter = "JSON files (*.json)|*.json";
            var FileName = $"vCardExport_{DateTime.Now:yyyyMMdd_HHmmss}.json";

            string filename = _view.DisplaySaveDialog(Title, Filter, FileName);
            if (string.IsNullOrWhiteSpace(filename))
                return;

            try
            {
                _repository.ExportToJson(filename, _repository.Contacts);
                _view.DisplayMessage("Export JSON completed.", "Export");
            }
            catch (Exception ex)
            {
                _view.DisplayMessage($"Export JSON failed: {ex.Message}", "Export");
            }
        }

        private void OpenNewFolderHandler(object sender, EventArg<string> e)
        {
            BeforeOpeningNewFileHandler();

            string path = e.Data;
            if (string.IsNullOrEmpty(path))
                path = _view.DisplayOpenFolderDialog();

            if (!string.IsNullOrEmpty(path))
            {
                bool Loaded = _repository.LoadMultipleFilesContact(path);
                if (!Loaded)
                {
                    _view.DisplayMessage("No file loaded!", "Error");
                    return;
                }

                AddPathToMostRecentUsedFiles(path);
                _view.DisplayContacts(_repository.Contacts);
            }
        }

        public void OpenNewFileHandler(object sender, EventArg<string> e)
        {
            BeforeOpeningNewFileHandler();

            string path = e.Data;
            if (string.IsNullOrEmpty(path))
                path = _view.DisplayOpenFileDialog("vCard Files|*.vcf");

            if (!string.IsNullOrEmpty(path))
            {
                string ext = _repository.GetExtension(path);
                if (!string.Equals(ext, ".vcf", StringComparison.OrdinalIgnoreCase))
                {
                    _view.DisplayMessage("Only vcf extension accepted!", "Error");
                    return;
                }

                if (!_repository.LoadContacts(path))
                    _view.DisplayMessage("File seems missing or corrupted!", "Error");
                else
                {
                    _view.DisplayContacts(_repository.Contacts);
                    AddPathToMostRecentUsedFiles(path);
                }
            }
        }

        private void AddPathToMostRecentUsedFiles(string path)
        {
            FixedList MostRecentUsedFiles = ConfigRepository.Instance.Paths;
            if (!MostRecentUsedFiles.Contains(path))
            {
                MostRecentUsedFiles.Enqueue(path);
                _view.UpdateMRUMenu(MostRecentUsedFiles);
            }
        }

        private void _view_BatchExportImagesEvent(object sender, EventArgs e)
        {
            if (_repository.Contacts == null || _repository.Contacts.Count == 0)
                return;

            int count = 0;
            for (int i = 0; i < _repository.Contacts.Count; i++)
            {
                if (_repository.Contacts[i].card.Photos.Count > 0)
                {
                    count++;
                    SaveCardPhoto(_repository.Contacts[i].card, i);
                }
            }

            if (count > 0)
                _view.DisplayMessage($"{count} contact(s) processed!", "Photo Count");
            else
                _view.DisplayMessage($"No picture found!", "Photo Count");
        }

        private void _view_ClearImages(object sender, EventArgs e)
        {
            if (_repository.Contacts == null || _repository.Contacts.Count == 0)
                return;

            int count = 0;
            for (int i = 0; i < _repository.Contacts.Count; i++)
            {
                if (_repository.Contacts[i].card.Photos.Count > 0)
                {
                    count++;
                    _repository.ModifyImage(i, null);

                    //remove from the form the image displayed.
                    if (_view.SelectedContactIndex == i)
                        _view.ClearImageFromForm();
                }
            }

            if (count > 0)
                _view.DisplayMessage($"{count} contact(s) processed!", "Photo Count");
            else
                _view.DisplayMessage($"No picture found!", "Photo Count");
        }

        private void _view_CountImages(object sender, EventArgs e)
        {
            if (_repository.Contacts == null)
                return;

            int count = _repository.Contacts.Count(x => x.card.Photos.Count > 0);
            if (count > 0)
                _view.DisplayMessage($"{count} contact(s) containing a picture = ", "Photo Count");
            else
                _view.DisplayMessage($"No picture found!", "Photo Count");
        }

        private void _view_AddExtraField(object sender, EventArg<vCardPropeties> e)
        {
            _view.AddExtraTextGroup(e.Data, string.Empty);
        }

        private void CopyTextToClipboardHandler(object sender, EventArgs e)
        {
            if (_view.SelectedContactIndex < 0)
                return;

            var contact = _repository.Contacts[_view.SelectedContactIndex];

            string SerializedCard = _repository.GenerateStringFromVCard(contact.card);

            _view.SendTextToClipBoard(SerializedCard);
            _view.DisplayMessage("vCard copied to clipboard!", "Information");
        }

        private void LoadFormHandler(object sender, EventArg<FormState> e)
        {
            _view.LoadIntialState(ConfigRepository.Instance.FormState);
            _view.LoadAvailablesLangs(_localization.AvailableLanguages);
            _view.LoadLocalizedUI(_localization.CurrentMessages);
            string[] paths = Environment.GetCommandLineArgs();
            if (paths.Length > 1)
            {
                var evt = new EventArg<string>(paths[1]);
                OpenNewFileHandler(sender, evt);
            }
        }

        private void AddressRemovedHandler(object sender, EventArg<int> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);

            contact.card.DeliveryAddresses.RemoveAt(e.Data);
        }

        private void AddressAddedHandler(object sender, EventArg<List<vCardDeliveryAddressTypes>> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);

            contact.card.DeliveryAddresses.Add(new vCardDeliveryAddress(e.Data));
        }

        private void AddressModifiedHandler(object sender, EventArg<List<vCardDeliveryAddressTypes>> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);

            contact.card.DeliveryAddresses.Clear();
            contact.card.DeliveryAddresses.Add(new vCardDeliveryAddress(e.Data));
        }

        private void ExportImageHandler(object sender, EventArgs e)
        {
            if (_view.SelectedContactIndex > -1)
            {
                //TODO: image can be url, or file location.
                vCard card = _repository.Contacts[_view.SelectedContactIndex].card;
                SaveCardPhoto(card, _view.SelectedContactIndex, true);
            }
        }

        private void SaveCardPhoto(vCard card, int index, bool askUser = false)
        {
            //TODO: Save every image for a vCard.
            vCardPhoto image = card.Photos.FirstOrDefault();

            if (image != null)
            {
                string newPath = _repository.GenerateFileName(_repository.fileName, index, image.Extension);

                //string ImagePath = string.Empty;
                //if (askUser)
                //    ImagePath = _view.DisplaySaveDialog(newPath);

                _repository.SaveImageToDisk(newPath, image);
            }
        }

        private void ExportQRHandler(object sender, EventArgs e)
        {
            if (_view.SelectedContactIndex > -1)
            {
                vCard card = _repository.Contacts[_view.SelectedContactIndex].card;
                string content = _repository.GenerateStringFromVCard(card);

                _view.DisplayQRCode(content);
            }
        }

        private void ModifyImageHandler(object sender, EventArg<string> e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                vCardPhoto photo = new vCardPhoto(e.Data);
                _repository.ModifyImage(_view.SelectedContactIndex, photo);
            }
            else
                _repository.ModifyImage(_view.SelectedContactIndex, null);
        }

        void CloseFormHandler(object sender, EventArg<bool> e)
        {
            if (_repository.dirty && !_view.AskMessage("Exit without saving?", "Exit"))
                e.Data = true;

            if (!e.Data)
            {
                FormState state = _view.GetFormState();
                ConfigRepository.Instance.FormState = state;
                ConfigRepository.Instance.SaveConfig();
            }
        }

        public void BeforeLeavingContactHandler(object sender, EventArg<vCard> e)
        {
            _repository.SaveDirtyVCard(_view.SelectedContactIndex, e.Data);
        }

        public void TextBoxValueChangedHandler(object sender, EventArgs e)
        {
            StateTextBox tb = sender as StateTextBox;
            if (tb != null && tb.oldText != tb.Text)
                _repository.SetDirtyFlag(_view.SelectedContactIndex);
        }

        public void CardInfoRemovedHandler(object sender, EventArgs e)
        {
            _repository.SetDirtyFlag(_view.SelectedContactIndex);
        }

        public void FilterTextChangedHandler(object sender, EventArg<string> e)
        {
            var FilteredContacts = _repository.FilterContacts(e.Data);
            _view.DisplayContacts(FilteredContacts);
        }

        private void AddContactHandler(object sender, EventArgs e)
        {
            _repository.AddEmptyContact();
            _view.DisplayContacts(_repository.Contacts);
        }

        private void DeleteContactHandler(object sender, EventArgs e)
        {
            _repository.DeleteContact();
        }

        private void SaveContactsHandler(object sender, EventArgs e)
        {
            var Title = "Save vCard file";
            var Filter = "Virtual Contact File|*.vcf";

            string filename = _repository.fileName ?? _view.DisplaySaveDialog(Title, Filter);
            if (string.IsNullOrWhiteSpace(filename))
                return;


            _view.SetFormTitle(filename);
            _repository.SaveContactsToFile(filename);
        }

        private void SaveSplittedFileHandler(object sender, EventArgs e)
        {
            if (_repository.Contacts == null || _repository.Contacts.Count == 0)
                return;

            string Path = _view.DisplayOpenFolderDialog();
            if (!string.IsNullOrEmpty(Path))
            {
                int count = _repository.SaveSplittedFiles(Path);
                _view.DisplayMessage(string.Format("{0} contact(s) processed!", count), "Information");
            }
        }

        private void BeforeOpeningNewFileHandler()
        {
            if (_repository.Contacts != null && _repository.dirty)
            {
                if (_view.AskMessage("Save current file before?", "Load"))
                    SaveContactsHandler(null, null);
            }
        }

        public void ChangeContactSelectedHandler(object sender, EventArgs e)
        {
            if (_view.SelectedContactIndex > -1)
            {
                vCard card = _repository.Contacts[_view.SelectedContactIndex].card;

                if (card != null)
                    _view.DisplayContactDetail(card, _repository.fileName);
                else
                    _view.ClearContactDetail();
            }
            else
                _view.ClearContactDetail();
        }

        private void BirthdateChangedHandler(object sender, EventArgs e)
        {
            _repository.SetDirtyFlag(_view.SelectedContactIndex);
        }
    }
}
