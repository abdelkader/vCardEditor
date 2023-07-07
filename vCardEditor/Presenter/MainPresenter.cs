using System;
using Thought.vCards;
using VCFEditor.View;
using vCardEditor.View;
using VCFEditor.Repository;
using vCardEditor.Repository;
using vCardEditor.Model;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace VCFEditor.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IContactRepository _repository;

        public MainPresenter(IMainView view, IContactRepository repository)
        {
            _view = view;
            _repository = repository;

            _view.LoadForm += LoadFormHandler;
            _view.AddContact += AddContactHandler;
            _view.NewFileOpened += NewFileOpenedHandler;
            _view.SaveContactsSelected += SaveContactsHandler;
            _view.ChangeContactsSelected += ChangeContactSelectedHandler;
            _view.DeleteContact += DeleteContactHandler;
            _view.FilterTextChanged += FilterTextChangedHandler;
            _view.TextBoxValueChanged += TextBoxValueChangedHandler;
            _view.BeforeLeavingContact += BeforeLeavingContactHandler;
            _view.CloseForm += CloseFormHandler;
            _view.ModifyImage += ModifyImageHandler;
            _view.ExportImage += ExportImageHandler;
            _view.AddressAdded += AddressAddedHandler;
            _view.AddressModified += AddressModifiedHandler;
            _view.AddressRemoved += AddressRemovedHandler;
            _view.CopyTextToClipboardEvent += CopyTextToClipboardHandler;
            _view.AddExtraField += _view_AddExtraField;

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
            var paths = Environment.GetCommandLineArgs();
            if (paths.Length > 1)
            {
                var evt = new EventArg<string>(paths[1]);
                NewFileOpenedHandler(sender, evt);
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

            contact.card.DeliveryAddresses.Add(new vCardDeliveryAddress( e.Data));
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
                var card = _repository.Contacts[_view.SelectedContactIndex].card;
                var image = card.Photos.FirstOrDefault();

                if (image != null)
                {
                    
                    var newPath = _repository.ChangeExtension(_repository.fileName, image.Extension);

                    string imageFile = _view.DisplaySaveDialog(newPath);
                    _repository.SaveImageToDisk(imageFile, image);
                }
            }
        }

        private void ModifyImageHandler(object sender, EventArg<string> e)
        {
            if (!string.IsNullOrEmpty(e.Data) )
            {
                vCardPhoto photo = new vCardPhoto(e.Data);
                _repository.ModifyImage(_view.SelectedContactIndex, photo);
            }
            else
                _repository.ModifyImage(_view.SelectedContactIndex, null);

        }

        void CloseFormHandler(object sender, EventArg<bool> e)
        {
            if (_repository.dirty && _view.AskMessage("Exit without saving?", "Exit")) 
                e.Data = true;

            if (!e.Data)
            {
                var state = _view.GetFormState();
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
            var tb = sender as StateTextBox;
            if (tb != null && tb.oldText != tb.Text)
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
        }

        private void DeleteContactHandler(object sender, EventArgs e)
        {
            _repository.DeleteContact();
        }

        private void SaveContactsHandler(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_repository.fileName))
                _repository.SaveContactsToFile(_repository.fileName);

        }

        private void BeforeOpeningNewFileHandler()
        {
            if (_repository.Contacts != null && _repository.dirty)
            {
                if (!_view.AskMessage("Save current file before?", "Load"))
                    _repository.SaveContactsToFile(_repository.fileName);
            }

        }
        public void NewFileOpenedHandler(object sender, EventArg<string> e)
        {
            BeforeOpeningNewFileHandler();
            
            string path = e.Data;
            if (string.IsNullOrEmpty(path))
                path = _view.DisplayOpenDialog("vCard Files|*.vcf");
            
            if (!string.IsNullOrEmpty(path))
            {
                string ext = _repository.GetExtension(path);
                if (!string.Equals(ext, ".vcf", StringComparison.OrdinalIgnoreCase))
                {
                    _view.DisplayMessage("Only vcf extension accepted!", "Error");
                    return;
                }

                FixedList MostRecentUsedFiles = ConfigRepository.Instance.Paths;
                if (!MostRecentUsedFiles.Contains(path))
                {
                    MostRecentUsedFiles.Enqueue(path);
                    _view.UpdateMRUMenu(MostRecentUsedFiles);
                }
                
                _repository.LoadContacts(path);
                _view.DisplayContacts(_repository.Contacts);
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

    }
}
