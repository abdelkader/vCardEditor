using System;
using System.IO;
using System.Linq;
using System.Text;
using Thought.vCards;
using vCardEditor.Repository;
using vCardEditor.View;
using VCFEditor.Model;

namespace VCFEditor.Repository
{
    public class ContactRepository : IContactRepository
    {
        public string fileName { get; set; }
        private IFileHandler _fileHandler;

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
            get
            {
                return (_contacts != null && _contacts.Any(x => x.isDirty)) || _dirty;
            }
            set
            {
                _dirty = true;
            }
        }

        public ContactRepository(IFileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }

        public bool LoadMultipleFilesContact(string path)
        {
            Contacts.Clear();
            
            string[] filePaths = _fileHandler.GetFiles(path, "*.vcf");
            if (filePaths.Count() == 0)
                return false;

            SortableBindingList<Contact> loaded;
            foreach (string item in filePaths)
            {
                loaded = LoadContactFromFile(item);
                if (loaded != null)
                    Contacts.AddRange(loaded);
            }
            OriginalContactList = Contacts;

            return true;
        }

        public bool LoadContacts(string fileName)
        {
            Contacts.Clear();
            this.fileName = fileName;
            Contacts = LoadContactFromFile(fileName);
            if (Contacts == null)
                return false;
            OriginalContactList = Contacts;
            return true;
        }

        public SortableBindingList<Contact> LoadContactFromFile(string fileName)
        {
            if (!_fileHandler.FileExist(fileName))
                return null;

            SortableBindingList<Contact> ListOfContacts = new SortableBindingList<Contact>();

            string[] lines = _fileHandler.ReadAllLines(fileName);

            StringBuilder RawContent = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                RawContent.AppendLine(lines[i]);
                try
                {
                    if (string.Equals(lines[i].TrimEnd(), "END:VCARD", StringComparison.OrdinalIgnoreCase))
                    {
                        ListOfContacts.Add(new Contact(ParseRawContent(RawContent)));
                        RawContent.Clear();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }

            return ListOfContacts;
        }

        private vCard ParseRawContent(StringBuilder rawContent)
        {
            vCard card = null;

            using (StringReader reader = new StringReader(rawContent.ToString()))
                card = new vCard(reader);

            return card;
        }

        public void AddEmptyContact()
        {
            Contacts.Add(new Contact() { isDirty = true });
        }

        public void SaveContactsToFile(string fileName)
        {
            //overwrite the same file, else save as another file.
            if (string.IsNullOrEmpty(fileName))
                fileName = this.fileName;

            //Take a copy if specified in the config file
            if (!ConfigRepository.Instance.Overwrite)
            {
                string backupName = GetBackupName();
                _fileHandler.MoveFile(fileName, backupName);
            }

            StringBuilder sb = new StringBuilder();
            
            foreach (Contact entry in Contacts)
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
            _dirty = false;
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
            foreach (vCardPhone item in newCard.Phones)
                card.Phones.Add(new vCardPhone(item.FullNumber, item.PhoneType));
        }

        private void SaveExtraField(vCard newCard, vCard card)
        {
            card.Notes.Clear();
            foreach (vCardNote item in newCard.Notes)
                card.Notes.Add(new vCardNote(item.Text));
            card.Organization = newCard.Organization;
        }

        private void SaveAddresses(vCard NewCard, vCard card)
        {
            foreach (vCardDeliveryAddress item in NewCard.DeliveryAddresses)
            {
                vCardDeliveryAddress adr = card.DeliveryAddresses.Where(x => x.AddressType.FirstOrDefault() == item.AddressType.FirstOrDefault()).FirstOrDefault();
                if (adr != null)
                {
                    adr.City = item.City;
                    adr.Country = item.Country;
                    adr.PostalCode = item.PostalCode;
                    adr.Region = item.Region;
                    adr.Street = item.Street;
                    adr.ExtendedAddress = item.ExtendedAddress;
                    adr.PostOfficeBox = item.PostOfficeBox;
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
            //Personal
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

            //Work
            //if (NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Work) != null)
            //{
            //    if (card.Websites.GetFirstChoice(vCardWebsiteTypes.Work) != null)
            //        card.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url = NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url;
            //    else
            //        card.Websites.Add(new vCardWebsite(NewCard.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url, vCardWebsiteTypes.Work));
            //}
            //else
            //{
            //    if (card.Websites.GetFirstChoice(vCardWebsiteTypes.Work) != null)
            //        card.Websites.GetFirstChoice(vCardWebsiteTypes.Work).Url = string.Empty;
            //}
        }
       
        public string GenerateStringFromVCard(vCard card)
        {
            vCardStandardWriter writer = new vCardStandardWriter();
            using (TextWriter tw = new StringWriter())
            {
                writer.Write(card, tw);
                return tw.ToString();
            }
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

        public string GenerateFileName(string fileName, int index, string extension)
        {
            return _fileHandler.GetFileNameWithExtension(fileName, index, extension);
        }

        public int SaveSplittedFiles(string FolderPath)
        {
            //Do not save the deleted ones!
            var contactsToSave = Contacts.Where(x => !x.isDeleted).ToList();
            int count;
            for (count = 0; count < contactsToSave.Count(); count++)
            {
                Contact entry = contactsToSave[count];
                string SerializedCard = GenerateStringFromVCard(entry.card);

                //Check if filename for the card is empty, and generate one if empty
                if (string.IsNullOrEmpty(entry.path))
                    entry.path = GenerateFileName(FolderPath, entry.FamilyName, count);

                _fileHandler.WriteAllText(entry.path, SerializedCard);

                //Clean the flag for every contact, even the deleted ones.
                entry.isDirty = false;
            }
            
            //Clean the global flag for the entire vCard Catalog.
            _dirty = false;
            
            //return number of contacts processed!
            return count;
        }

        private string GenerateFileName(string FolderPath, string familyName, int index)
        {
            return _fileHandler.GetVcfFileName(FolderPath, familyName ?? index.ToString());
        }
    }
}
