using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Thought.vCards;
using VCFEditor.Model;
using System.ComponentModel;
using vCardEditor.Repository;

namespace VCFEditor.Repository
{
    public class ContactRepository : IContactRepository
    {
        public string fileName { get; set; }
        private IFileHandler _fileHandler;
        #region Contact Info
        /// <summary>
        /// Formatted name.
        /// </summary>
        public const string KeyName = "FN";

        /// <summary>
        /// Keep a copy of contact list when filtering
        /// </summary>
        private BindingList<Contact> OriginalContactList = null;
        /// <summary>
        /// Contact List
        /// </summary>
        private BindingList<Contact> _contacts;
        public BindingList<Contact> Contacts
        {
            get
            {
                if (_contacts == null)
                    _contacts = new BindingList<Contact>();
                return _contacts;
            }
            set
            {
                _contacts = value;
            }
        }
        #endregion

        public ContactRepository(IFileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }
        /// <summary>
        /// Load contacts. 
        /// 1- Parse the file
        /// 2- 
        /// </summary>
        /// <param name="path"></param>
        public BindingList<Contact> LoadContacts(string fileName)
        {
            this.fileName = fileName;

            StringBuilder RawContent = new StringBuilder();
            Contact contact = new Contact();
            string[] lines = _fileHandler.ReadAllLines(fileName);

            //Prevent from adding contacts to existings ones.
            Contacts.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                RawContent.AppendLine(lines[i]);
                if (lines[i] == "END:VCARD")
                {
                    contact.card = ParseRawContent(RawContent);
                    Contacts.Add(contact);
                    contact = new Contact();
                    RawContent.Length = 0;
                }
              
            }

            OriginalContactList = Contacts;
            return Contacts;
        }

        /// <summary>
        /// Save the contact to the file.
        /// </summary>
        /// <param name="path">Path to the new file, else if null, we overwrite the same file</param>
        public void SaveContacts(string fileName)
        {
            //overwrite the same file, else save as another file.
            if (string.IsNullOrEmpty(fileName))
                fileName = this.fileName;


            StringBuilder sb = new StringBuilder();
            foreach (var entry in Contacts)
                sb.Append(generateRawContent(entry.card));

            _fileHandler.WriteAllText(fileName, sb.ToString());
        }


        /// <summary>
        /// Delete contacted that are selected.
        /// </summary>
        public void DeleteContact()
        {
            if (_contacts != null && _contacts.Count > 0)
            {
                //loop from the back to prevent index mangling...
                for (int i = _contacts.Count - 1; i > -1; i--)
                {
                    if (_contacts[i].isSelected)
                        _contacts.RemoveAt(i);
                }
            }

        }


        /// <summary>
        /// Use the lib to parse a vcard chunk.
        /// </summary>
        /// <param name="rawContent"></param>
        /// <returns></returns>
        private vCard ParseRawContent(StringBuilder rawContent)
        {
            vCard card = null;

            using (MemoryStream s = GenerateStreamFromString(rawContent.ToString()))
            using (TextReader streamReader = new StreamReader(s, Encoding.UTF8))
            {
                card = new vCard(streamReader);
            }

            return card;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private MemoryStream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public BindingList<Contact> FilterContacts(string filter)
        {
            var list = OriginalContactList.Where(i => (i.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0));
            Contacts = new BindingList<Contact>(list.ToList());
            return Contacts;
        }


        /// <summary>
        /// Save modified card info in the raw content.
        /// </summary>
        /// <param name="card"></param>
        /// <param name="index"></param>
        public void SaveDirtyFlag(int index)
        {
            if (index > -1)
                _contacts[index].isDirty = true;
        }

        public void SaveDirtyVCard(int index, vCard NewCard)
        {
            if (index > -1 && _contacts[index].isDirty)
            {
                vCard card = _contacts[index].card;
                card.FormattedName = NewCard.FormattedName;


                //HomePhone
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Home) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber = NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber;
                else
                {
                    if (NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Home) != null
                        && !string.IsNullOrEmpty(NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber))
                        card.Phones.Add(new vCardPhone(NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber, vCardPhoneTypes.Home));
                }


                //Cellular
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber = NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber;
                else
                {
                    if (NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Cellular) != null
                        && !string.IsNullOrEmpty(NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber))
                        card.Phones.Add(new vCardPhone(NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber, vCardPhoneTypes.Cellular));
                }

                if (card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet) != null)
                    card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address = NewCard.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address;
                if (card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal) != null)
                    card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal).Url = NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Personal).Url;


                _contacts[index].isDirty = false;
            }
        }

        /// <summary>
        /// Generate a VCard class from a string.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        private string generateRawContent(vCard card)
        {
            vCardStandardWriter writer = new vCardStandardWriter();
            TextWriter tw = new StringWriter();
            writer.Write(card, tw);

            return tw.ToString();
        }

        /// <summary>
        /// Check if some iem in the contact list is modified
        /// </summary>
        /// <returns>true for dirty</returns>
        public bool isDirty()
        {
            return (_contacts != null && _contacts.Any(x => x.isDirty));
        }
    }
}
