using System;
using Thought.vCards;
using VCFEditor.Model;
using vCardEditor.View;
using System.Collections.Generic;

namespace VCFEditor.Repository
{
    public interface IContactRepository
    {
        bool dirty { get; }
        string fileName { get; set; }
        SortableBindingList<Contact> Contacts { get; set; }
        bool LoadContacts(string fileName);
        bool LoadMultipleFilesContact(string path);
        SortableBindingList<Contact> FilterContacts(string p);
        void SaveContactsToFile(string fileName);
        void DeleteContact();
        void SetDirtyFlag(int index);
        void SaveDirtyVCard(int index, vCard card);
        void AddEmptyContact();
        void ModifyImage(int index, vCardPhoto photo);
        string GetExtension(string path);
        //string ChangeExtension(string path, int index, string extension);
        void SaveImageToDisk(string imageFile, vCardPhoto image);

        string GenerateStringFromVCard(vCard card);
        string GenerateFileName(string fileName, int index, string extension);
        int SaveSplittedFiles(string Path);

        void ExportToCsv(string path, IEnumerable<Contact> contacts);
        void ExportToJson(string path, IEnumerable<Contact> contacts);
        SortableBindingList<Contact> ImportFromJson(string path);
        SortableBindingList<Contact> ImportFromCsv(string path);
    }
}
