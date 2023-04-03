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
        string fileName { get; set; }
        BindingList<Contact> Contacts { get; set; }
        bool dirty { get; set; }

        BindingList<Contact> LoadContacts(string fileName);
        void SaveContacts(string fileName);
        void DeleteContact();
        BindingList<Contact> FilterContacts(string p);
        void SaveDirtyFlag(int index);
        void SaveDirtyVCard(int index, vCard card);
        void AddEmptyContact();

        void ModifyImage(int index, vCardPhoto photo);
    }
}
