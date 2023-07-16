using System;
using System.IO;
using System.Linq;
using System.Text;
using Thought.vCards;
using VCFEditor.Model;
using System.ComponentModel;
using vCardEditor.Repository;
using vCardEditor.View;

namespace VCFEditor.Repository
{
    public class ContactRepository : IContactRepository
    {
        public string fileName { get; set; }
        private IFileHandler _fileHandler;
        /// <summary>
        /// Formatted name.
        /// </summary>
        public const string KeyName = "FN";

        /// <summary>
        /// Keep a copy of contact list when filtering
        /// </summary>
        private SortableBindingList<Contact> OriginalContactList = null;
        private SortableBindingList<Contact> _contacts;
        public SortableBindingList<Contact> Contacts
        {
            get
            {
                if (_contacts == null)
                    _contacts = new SortableBindingList<Contact>();
                return _contacts;
            }
            set
            {
                _contacts = value;
            }
        }

        private bool _dirty;
        public bool dirty
        {
            get { return (_contacts != null && _contacts.Any(x => x.isDirty)) || _dirty; }
            set { _dirty = true; }
        }
        public ContactRepository(IFileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }

        public bool LoadContacts(string fileName)
        {
            Contacts.Clear();

            this.fileName = fileName;

            if (!_fileHandler.FileExist(fileName))
            {
                OriginalContactList = null;
                return false;
            }
            
            string[] lines = _fileHandler.ReadAllLines(fileName);

            StringBuilder RawContent = new StringBuilder();
            Contact contact = new Contact();

            for (int i = 0; i < lines.Length; i++)
            {
                RawContent.AppendLine(lines[i]);
                if (string.Equals(lines[i].TrimEnd(), "END:VCARD", StringComparison.OrdinalIgnoreCase))
                {
                    contact.card = ParseRawContent(RawContent);
                    Contacts.Add(contact);
                    contact = new Contact();
                    RawContent.Length = 0;
                }
              
            }
            
            OriginalContactList = Contacts;
            return true;
        }
       
        public void AddEmptyContact()
        {
            if (_contacts != null && _contacts.Count > 0)
            {
                Contact contact = new Contact();
                Contacts.Add(contact);
            }
        }

        public void SaveContactsToFile(string fileName)
        {
            //overwrite the same file, else save as another file.
            if (string.IsNullOrEmpty(fileName))
                fileName = this.fileName;

            //Take a copy if specified in the config file
            if (!ConfigRepository.Instance.OverWrite)
            {
                string backupName = GetBackupName();
                _fileHandler.MoveFile(fileName, backupName);
            }

            StringBuilder sb = new StringBuilder();
            
            foreach (var entry in Contacts)
            {
                //Do not save the deleted ones!
                if (!entry.isDeleted)
                {
                    string SerializedCard = GenerateStringFromVCard(entry.card);
                    sb.Append(SerializedCard);
                }
                
                //Clean the flag for every contact, even the deleted ones.
                entry.isDirty = false;
            }
                

            _fileHandler.WriteAllText(fileName, sb.ToString());
        }

        private string GetBackupName()
        {
            int count = 0;
            string backupName = fileName + ".old" + count.ToString();

            while (_fileHandler.FileExist(backupName))
            {
                count++;
                backupName = fileName + ".old" + count.ToString();
            }

            return backupName;
        }
        
        public void DeleteContact()
        {
            if (_contacts != null && _contacts.Count > 0)
            {
                //loop from the back to prevent index mangling...
                for (int i = _contacts.Count - 1; i > -1; i--)
                {
                    if (_contacts[i].isSelected)
                    {
                        _dirty = true;
                        _contacts.RemoveAt(i);
                    }
                        
                }
            }

        }
       
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
       
        private MemoryStream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public SortableBindingList<Contact> FilterContacts(string filter)
        {
            var list = OriginalContactList.Where(i => (i.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0) && 
                                                    !i.isDeleted);
            Contacts = new SortableBindingList<Contact>(list.ToList());
            return Contacts;
        }


        public void SetDirtyFlag(int index)
        {
            if (index > -1)
                _contacts[index].isDirty = true;
        }

        public void SaveDirtyVCard(int index, vCard NewCard)
        {
            if (index > -1 && index <= _contacts.Count-1 && _contacts[index].isDirty)
            {
                vCard card = _contacts[index].card;
                card.Title = NewCard.Title;
                card.FormattedName = NewCard.FormattedName;
                card.GivenName = NewCard.GivenName;
                card.FamilyName = NewCard.FamilyName;
                card.AdditionalNames = NewCard.AdditionalNames;
                card.FamilyName = NewCard.FamilyName;

                SavePhone(NewCard, card);
                SaveEmail(NewCard, card);
                SaveWebUrl(NewCard, card);
                SaveAddresses(NewCard, card);
                SaveExtraField(NewCard, card);
                SaveExtraPhones(NewCard, card);
            }
        }

        private void SaveExtraPhones(vCard newCard, vCard card)
        {
            card.Phones.Clear();
            foreach (var item in newCard.Phones)
                card.Phones.Add(new vCardPhone(item.FullNumber, item.PhoneType));

        }

        private void SaveExtraField(vCard newCard, vCard card)
        {
            card.Notes.Clear();
            foreach (var item in newCard.Notes)
                card.Notes.Add(new vCardNote(item.Text));

            card.Organization = newCard.Organization;
        }

        private void SaveAddresses(vCard NewCard, vCard card)
        {
            foreach (var item in NewCard.DeliveryAddresses)
            {
                var adr = card.DeliveryAddresses.Where(x => x.AddressType.FirstOrDefault() == item.AddressType.FirstOrDefault()).FirstOrDefault();
                if (adr != null)
                {
                    adr.City = item.City;
                    adr.Country = item.Country;
                    adr.PostalCode = item.PostalCode;
                    adr.Region = item.Region;
                    adr.Street = item.Street;
                }
                else
                    card.DeliveryAddresses.Add(new vCardDeliveryAddress(item.Street, item.City, item.Region, item.Country,
                        item.PostalCode, item.AddressType.FirstOrDefault()));
                
            }
        }

        private void SavePhone(vCard NewCard, vCard card)
        {
            //HomePhone
            if (NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Home) != null)
            {
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Home) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber = NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber;
                else
                    card.Phones.Add(new vCardPhone(NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber, vCardPhoneTypes.Home));
            }
            else
            {
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Home) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Home).FullNumber = string.Empty;

            }


            //Cellular
            if (NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Cellular) != null)
            {
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber = NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber;
                else
                    card.Phones.Add(new vCardPhone(NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber, vCardPhoneTypes.Cellular));
            }
            else
            {
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber = string.Empty;

            }

            //Work
            if (NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Work) != null)
            {
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Work) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Work).FullNumber = NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Work).FullNumber;
                else
                    card.Phones.Add(new vCardPhone(NewCard.Phones.GetFirstChoice(vCardPhoneTypes.Work).FullNumber, vCardPhoneTypes.Work));
            }
            else
            {
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Work) != null)
                    card.Phones.GetFirstChoice(vCardPhoneTypes.Work).FullNumber = string.Empty;

            }
        }

        private void SaveEmail(vCard NewCard, vCard card)
        {
            //Inernet
            if (NewCard.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet) != null)
            {
                if (card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet) != null)
                    card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address
                        = NewCard.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address;
                else
                    card.EmailAddresses.Add(new vCardEmailAddress(NewCard.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address,
                            vCardEmailAddressType.Internet));
            }
            else
            {
                if (card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet) != null)
                    card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address = string.Empty;

            }

        }

        private void SaveWebUrl(vCard NewCard, vCard card)
        {
           
            if (NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Personal) != null)
            {
                if (card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal) != null)
                    card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal).Url = NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Personal).Url;
                else
                    card.Websites.Add(new vCardWebsite(NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Personal).Url, vCardWebsiteTypes.Personal));
            }
            else
            {
                if (card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal) != null)
                    card.Websites.GetFirstChoice(vCardWebsiteTypes.Personal).Url = string.Empty;

            }


            if (NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Work) != null)
            {
                if (card.Websites.GetFirstChoice(vCardWebsiteTypes.Work) != null)
                    card.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url = NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url;
                else
                    card.Websites.Add(new vCardWebsite(NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url, vCardWebsiteTypes.Work));
            }
            else
            {
                if (card.Websites.GetFirstChoice(vCardWebsiteTypes.Work) != null)
                    card.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url = string.Empty;

            }
        }
       
        public string GenerateStringFromVCard(vCard card)
        {
            vCardStandardWriter writer = new vCardStandardWriter();
            TextWriter tw = new StringWriter();
            writer.Write(card, tw);

            return tw.ToString();
        }

        public void ModifyImage(int index, vCardPhoto photo)
        {
            if (index > -1)
            {
                SetDirtyFlag(index);
                _contacts[index].card.Photos.Clear();
                if (photo != null)
                    _contacts[index].card.Photos.Add(photo);
            }
        }

        public string GetExtension(string path)
        {
            return _fileHandler.GetExtension(path);
        }

        public void SaveImageToDisk(string imageFile, vCardPhoto image)
        {
            _fileHandler.WriteBytesToFile(imageFile, image.GetBytes());
        }

        public string ChangeExtension(string path, string extension)
        {
            return _fileHandler.ChangeExtension(path, extension);
        }

        

    }
}
