using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thought.vCards;
using VCFEditor.Model;
using System.ComponentModel;

namespace VCFEditor.Repository
{
    public interface IContactRepository
    {
        bool dirty { get; }
        string fileName { get; set; }
        BindingList<Contact> Contacts { get; set; }
        BindingList<Contact> LoadContacts(string fileName);
        BindingList<Contact> FilterContacts(string p);
        void SaveContactsToFile(string fileName);
        void DeleteContact();
        void SetDirtyFlag(int index);
        void SaveDirtyVCard(int index, vCard card);
        void AddEmptyContact();
        void ModifyImage(int index, vCardPhoto photo);
    }
}
