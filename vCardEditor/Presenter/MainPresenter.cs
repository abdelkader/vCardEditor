using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thought.vCards;
using VCFEditor.Model;
using VCFEditor.View;
using System.ComponentModel;


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

            //hook event from the view to event handler present in this presenter.
            _view.NewFileOpened += NewFileOpened;
            _view.SaveContactsSelected += SaveContacts;
            _view.ChangeContactsSelected += ChangeContactSelected;
            _view.DeleteContact += DeleteContact;
            

        }

        private void DeleteContact(object sender, EventArgs e)
        {
            _repository.DeleteContact();
        }

        private void SaveContacts(object sender, EventArgs e)
        {
            _repository.SaveContacts(_repository.fileName);
        }

        public void NewFileOpened(object sender, EventArg<string> e)
        {
            DisplayContacts(e.Data);
        }

        public void ChangeContactSelected(object sender, EventArg<int> e)
        {
            if (e.Data > -1)
            {
                int index = e.Data;
                vCard card = _repository.ParseContactAt(index);
                if (card != null)
                {
                    _view.DisplayContactDetail(card);
                }
            }
            
        }

        public void DisplayContacts(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                _repository.LoadContacts(path);
                _view.DisplayContacts(_repository.Contacts);
            }

        }
        
    }
}
