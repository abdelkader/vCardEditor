using System;
using System.Collections.Generic;
using System.Linq;
using Thought.vCards;
using VCFEditor.View;
using vCardEditor.View;
using VCFEditor.Repository;
using vCardEditor.Repository;
using vCardEditor.Model;


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
            if (_repository.dirty && _view.AskMessage("Exit before saving?", "Exit"))
                e.Data = true;
        }
        public void BeforeLeavingContact(object sender, EventArg<vCard> e)
        {
            if (_view.SelectedContactIndex > -1)
            {
                if (_repository.dirty)
                    _repository.SaveDirtyVCard(_view.SelectedContactIndex, e.Data);
            }
        }

        public void TextBoxValueChanged(object sender, EventArgs e)
        {
            StateTextBox tb = sender as StateTextBox;
            if (tb != null && tb.oldText != tb.Text)
                _repository.SaveDirtyFlag(_view.SelectedContactIndex);

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
                _repository.SaveContacts(_repository.fileName);

        }

        private void BeforeOpeningNewFile(object sender, EventArgs e)
        {
            if (_repository.Contacts != null && _repository.dirty)
            {
                if (!_view.AskMessage("Save current file before?", "Load"))
                    _repository.SaveContacts(_repository.fileName);
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
                string ext = System.IO.Path.GetExtension(path);
                if (ext != ".vcf")
                {
                    _view.DisplayMessage("Only vcf extension accepted!", "Error");
                    return;
                }

                FixedList MRUList = ConfigRepository.Instance.Paths;
                if (!MRUList.Contains(path))
                {
                    MRUList.Enqueue(path);
                    _view.UpdateMRUMenu(MRUList);
                }
                
                _repository.LoadContacts(path);
                _view.DisplayContacts(_repository.Contacts);
            }


        }


        public void ChangeContactSelected(object sender, EventArgs e)
        {
            if (_view.SelectedContactIndex > -1)
            {
                int index = _view.SelectedContactIndex;
                vCard card = _repository.Contacts[index].card;

                if (card != null)
                {
                    _repository.Contacts[index].isDirty = false;
                    _view.DisplayContactDetail(card, _repository.fileName);
                }
            }

        }


    }
}
