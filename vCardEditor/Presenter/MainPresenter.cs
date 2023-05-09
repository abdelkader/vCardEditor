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

            _view.LoadForm += LoadFormEvent;
            _view.AddContact += AddContactEvent;
            _view.NewFileOpened += NewFileOpenedEvent;
            _view.BeforeOpeningNewFile += BeforeOpeningNewFileEvent;
            _view.SaveContactsSelected += SaveContactsEvent;
            _view.ChangeContactsSelected += ChangeContactSelectedEvent;
            _view.DeleteContact += DeleteContactEvent;
            _view.FilterTextChanged += FilterTextChangedEvent;
            _view.TextBoxValueChanged += TextBoxValueChangedEvent;
            _view.BeforeLeavingContact += BeforeLeavingContactEvent;
            _view.CloseForm += CloseFormEvent;
            _view.ModifyImage += ModifyImageEvent;
            _view.ExportImage += ExportImageEvent;
            _view.AddressAdded += AddressAddedEvent;
            _view.AddressModified += AddressModifiedEvent;
            _view.AddressRemoved += AddressRemovedEvent;
            _view.CopyTextToClipboardEvent += CopyTextToClipboardEvent;

        }

        private void CopyTextToClipboardEvent(object sender, EventArgs e)
        {
            if (_view.SelectedContactIndex < 0)
                return;

            var contact = _repository.Contacts[_view.SelectedContactIndex];

            string SerializedCard = _repository.GenerateStringFromVCard(contact.card);

            _view.SendTextToClipBoard(SerializedCard);
            _view.DisplayMessage("vCard copied to clipboard!", "Information");
        }
        private void LoadFormEvent(object sender, EventArg<FormState> e)
        {
            e.Data = ConfigRepository.Instance.FormState;
        }


        private void AddressRemovedEvent(object sender, EventArg<int> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);
            
            contact.card.DeliveryAddresses.RemoveAt(e.Data);
        }

        private void AddressAddedEvent(object sender, EventArg<List<vCardDeliveryAddressTypes>> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);

            contact.card.DeliveryAddresses.Add(new vCardDeliveryAddress( e.Data));
        }

        private void AddressModifiedEvent(object sender, EventArg<List<vCardDeliveryAddressTypes>> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);

            contact.card.DeliveryAddresses.Clear();
            contact.card.DeliveryAddresses.Add(new vCardDeliveryAddress(e.Data));
        }
        private void ExportImageEvent(object sender, EventArgs e)
        {
            
            if (_view.SelectedContactIndex > -1)
            {
                //TODO: image can be url, or file location.
                var card = _repository.Contacts[_view.SelectedContactIndex].card;
                var image = card.Photos.FirstOrDefault();

                if (image != null)
                {
                    var newPath = Path.ChangeExtension(_repository.fileName, image.Extension);

                    string imageFile = _view.DisplaySaveDialog(newPath);
                    _repository.SaveImageToDisk(imageFile, image);
                }
            }
        }

        private void ModifyImageEvent(object sender, EventArg<string> e)
        {
            if (!string.IsNullOrEmpty(e.Data) )
            {
                vCardPhoto photo = new vCardPhoto(e.Data);
                _repository.ModifyImage(_view.SelectedContactIndex, photo);
            }
            else
                _repository.ModifyImage(_view.SelectedContactIndex, null);

        }

        void CloseFormEvent(object sender, EventArg<bool> e)
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
        public void BeforeLeavingContactEvent(object sender, EventArg<vCard> e)
        {
            _repository.SaveDirtyVCard(_view.SelectedContactIndex, e.Data);
        }

        public void TextBoxValueChangedEvent(object sender, EventArgs e)
        {
            var tb = sender as StateTextBox;
            if (tb != null && tb.oldText != tb.Text)
                _repository.SetDirtyFlag(_view.SelectedContactIndex);

        }

        public void FilterTextChangedEvent(object sender, EventArg<string> e)
        {
            var FilteredContacts = _repository.FilterContacts(e.Data);
            _view.DisplayContacts(FilteredContacts);
        }

        private void AddContactEvent(object sender, EventArgs e)
        {
            _repository.AddEmptyContact();
        }

        private void DeleteContactEvent(object sender, EventArgs e)
        {
            _repository.DeleteContact();
        }

        private void SaveContactsEvent(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_repository.fileName))
                _repository.SaveContactsToFile(_repository.fileName);

        }

        private void BeforeOpeningNewFileEvent(object sender, EventArgs e)
        {
            if (_repository.Contacts != null && _repository.dirty)
            {
                if (!_view.AskMessage("Save current file before?", "Load"))
                    _repository.SaveContactsToFile(_repository.fileName);
            }

        }
        public void NewFileOpenedEvent(object sender, EventArg<string> e)
        {
            BeforeOpeningNewFileEvent(sender, e);
            
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

        public void ChangeContactSelectedEvent(object sender, EventArgs e)
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
