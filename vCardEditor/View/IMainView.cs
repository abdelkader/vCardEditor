using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thought.vCards;
using VCFEditor.Model;
using System.ComponentModel;

namespace VCFEditor.View
{
    public interface IMainView
    {
        #region All events
        event EventHandler DeleteContact;
        event EventHandler SaveContactsSelected;
        event EventHandler<EventArg<string>> NewFileOpened;
        event EventHandler ChangeContactsSelected;
        event EventHandler<EventArg<vCard>> BeforeLeavingContact;
        event EventHandler<EventArg<string>> FilterTextChanged;
        event EventHandler TextBoxValueChanged;
        #endregion

        int SelectedContactIndex { get; }
        void DisplayContacts(BindingList<Contact> contacts);
        void DisplayContacts(List<Contact> contacts);
        void DisplayContactDetail(vCard card);

        
    }
}
