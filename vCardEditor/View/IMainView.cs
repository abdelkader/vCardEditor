using System;
using System.Collections.Generic;
using Thought.vCards;
using VCFEditor.Model;
using vCardEditor.Model;
using vCardEditor.View;

namespace VCFEditor.View
{
    public interface IMainView
    {
        event EventHandler<EventArg<FormState>> LoadForm;
        event EventHandler AddContact;
        event EventHandler DeleteContact;
        event EventHandler SaveContactsSelected;
        event EventHandler<EventArg<string>> NewFileOpened;
        event EventHandler ChangeContactsSelected;
        event EventHandler<EventArg<vCard>> BeforeLeavingContact;
        event EventHandler<EventArg<string>> FilterTextChanged;
        event EventHandler TextBoxValueChanged;
        event EventHandler<EventArg<bool>> CloseForm;
        event EventHandler<EventArg<string>> ModifyImage;
        event EventHandler ExportImage;
        event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> AddressAdded;
        event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> AddressModified;
        event EventHandler<EventArg<int>> AddressRemoved;
        event EventHandler CopyTextToClipboardEvent;
        event EventHandler<EventArg<vCardPropeties>> AddExtraField;
        int SelectedContactIndex { get; }
        void DisplayContacts(SortableBindingList<Contact> contacts);
        void DisplayContactDetail(vCard card, string FileName);
        void ClearContactDetail();
        bool AskMessage(string msg, string caption);
        void DisplayMessage(string msg, string caption);
        string DisplayOpenDialog(string filter);
        string DisplaySaveDialog(string filename);
        void UpdateMRUMenu(FixedList MRUList);

        void SendTextToClipBoard(string text);

        FormState GetFormState();
        void LoadIntialState(FormState state);
        void AddExtraTextGroup(vCardPropeties type, string content);
    }
}
