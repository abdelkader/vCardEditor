using System;
using Thought.vCards;
using VCFEditor.View;
using vCardEditor.View;
using VCFEditor.Repository;
using vCardEditor.Repository;
using vCardEditor.Model;
using System.Linq;
using System.IO;
using System.Drawing;
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

            _view.AddContact += AddContact;
            _view.NewFileOpened += NewFileOpened;
            _view.BeforeOpeningNewFile += BeforeOpeningNewFile;
            _view.SaveContactsSelected += SaveContacts;
            _view.ChangeContactsSelected += ChangeContactSelected;
            _view.DeleteContact += DeleteContact;
            _view.FilterTextChanged += FilterTextChanged;
            _view.TextBoxValueChanged += TextBoxValueChanged;
            _view.BeforeLeavingContact += BeforeLeavingContact;
            _view.CloseForm += CloseForm;
            _view.ModifyImage += ModifyImage;
            _view.ExportImage += ExportImage;
            _view.AddressAdded += _view_AddressAdded;
            _view.AddressRemoved += _view_AddressRemoved;


    }

        private void _view_AddressRemoved(object sender, EventArg<int> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);
            
            contact.card.DeliveryAddresses.RemoveAt(e.Data);
        }

        private void _view_AddressAdded(object sender, EventArg<List<vCardDeliveryAddressTypes>> e)
        {
            var contact = _repository.Contacts[_view.SelectedContactIndex];
            _repository.SetDirtyFlag(_view.SelectedContactIndex);

            contact.card.DeliveryAddresses.Add(new vCardDeliveryAddress( e.Data));
        }

        private void ExportImage(object sender, EventArgs e)
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

       

        private void ModifyImage(object sender, EventArg<string> e)
        {
            if (!string.IsNullOrEmpty(e.Data) )
            {
                vCardPhoto photo = new vCardPhoto(e.Data);
                
                _repository.ModifyImage(_view.SelectedContactIndex, photo);
            }
            else
                _repository.ModifyImage(_view.SelectedContactIndex, null);

        }

        void CloseForm(object sender, EventArg<bool> e)
        {
            if (_repository.dirty && _view.AskMessage("Exit without saving?", "Exit"))
                e.Data = true;
        }
        public void BeforeLeavingContact(object sender, EventArg<vCard> e)
        {
            _repository.SaveDirtyVCard(_view.SelectedContactIndex, e.Data);
        }

        public void TextBoxValueChanged(object sender, EventArgs e)
        {
            var tb = sender as StateTextBox;
            if (tb != null && tb.oldText != tb.Text)
                _repository.SetDirtyFlag(_view.SelectedContactIndex);

        }

        public void FilterTextChanged(object sender, EventArg<string> e)
        {
            var FilteredContacts = _repository.FilterContacts(e.Data);
            _view.DisplayContacts(FilteredContacts);
        }

        private void AddContact(object sender, EventArgs e)
        {
            _repository.AddEmptyContact();
        }

        private void DeleteContact(object sender, EventArgs e)
        {
            _repository.DeleteContact();
        }

        private void SaveContacts(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_repository.fileName))
                _repository.SaveContactsToFile(_repository.fileName);

        }

        private void BeforeOpeningNewFile(object sender, EventArgs e)
        {
            if (_repository.Contacts != null && _repository.dirty)
            {
                if (!_view.AskMessage("Save current file before?", "Load"))
                    _repository.SaveContactsToFile(_repository.fileName);
            }

        }

        public void NewFileOpened(object sender, EventArg<string> e)
        {
            BeforeOpeningNewFile(sender, e);
            
            string path = e.Data;
            if (string.IsNullOrEmpty(path))
                path = _view.DisplayOpenDialog("vCard Files|*.vcf");
            
            if (!string.IsNullOrEmpty(path))
            {
                string ext = _repository.GetExtension(path);
                if (ext != ".vcf")
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


        public void ChangeContactSelected(object sender, EventArgs e)
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
