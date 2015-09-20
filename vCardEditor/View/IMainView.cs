using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thought.vCards;
using VCFEditor.Model;
using System.ComponentModel;
using System.Windows.Forms;

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
        event EventHandler<FormClosingEventArgs> CloseForm;
        #endregion

        int SelectedContactIndex { get; }
        void DisplayContacts(BindingList<Contact> contacts);
        void DisplayContactDetail(vCard card, string FileName);
        bool AskMessage(string msg, string caption);
    }
}
