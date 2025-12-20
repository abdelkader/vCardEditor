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
        event EventHandler ExportQR;
        event EventHandler ExportCsv;
        event EventHandler ExportJson;
        event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> AddressAdded;
        event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> AddressModified;
        event EventHandler<EventArg<int>> AddressRemoved;
        event EventHandler CopyTextToClipboardEvent;
        event EventHandler<EventArg<vCardPropeties>> AddExtraField;
        event EventHandler CountImagesEvent;
        event EventHandler ClearImagesEvent;
        event EventHandler BatchExportImagesEvent;
        event EventHandler<EventArg<string>> OpenFolderEvent;
        event EventHandler SplitFileEvent;
        event EventHandler CardInfoRemoved;
        event EventHandler BirhdateChanged;

        int SelectedContactIndex { get; }
        void DisplayContacts(SortableBindingList<Contact> contacts);
        void DisplayContactDetail(vCard card, string FileName);
        void ClearContactDetail();
        bool AskMessage(string msg, string caption);
        void DisplayMessage(string msg, string caption);
        string DisplayOpenFileDialog(string filter);
        string DisplaySaveDialog(string title, string filter, string filename = "");
        void UpdateMRUMenu(FixedList MRUList);

        void SendTextToClipBoard(string text);

        FormState GetFormState();
        void LoadIntialState(FormState state);
        void AddExtraTextGroup(vCardPropeties type, string content);
        void DisplayQRCode(string content);

        void ClearImageFromForm();
        string DisplayOpenFolderDialog();
        void LoadLocalizedUI(IReadOnlyDictionary<string, string> currentMessages);
        void LoadAvailablesLangs(IEnumerable<string> availableLanguages);
        void SetFormTitle(string filename);
    }
}
