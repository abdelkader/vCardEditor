using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Thought.vCards;
using TinyJson;
using vCardEditor.Libs.SmallestCSVParser;
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
            get { return (_contacts != null && _contacts.Any(x => x.isDirty)) || _dirty; }
            set { _dirty = true; }
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

            foreach (string item in filePaths)
            {
                var result = LoadContactFromFile(item);
                Contacts.AddRange(result);
                OriginalContactList = Contacts;
            }
            return true;
        }

        public bool LoadContacts(string fileName)
        {
            Contacts.Clear();
            this.fileName = fileName;
            Contacts = LoadContactFromFile(fileName);
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
            Contact contact;

            for (int i = 0; i < lines.Length; i++)
            {
                RawContent.AppendLine(lines[i]);
                try
                {
                    if (string.Equals(lines[i].TrimEnd(), "END:VCARD", StringComparison.OrdinalIgnoreCase))
                    {
                        contact = new Contact(ParseRawContent(RawContent));
                        ListOfContacts.Add(contact);
                        RawContent.Length = 0;
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
            if (index > -1 && index <= _contacts.Count - 1 && _contacts[index].isDirty)
            {
                vCard card = _contacts[index].card;
                card.Title = NewCard.Title;
                card.FormattedName = NewCard.FormattedName;
                card.GivenName = NewCard.GivenName;
                card.FamilyName = NewCard.FamilyName;
                card.AdditionalNames = NewCard.AdditionalNames;
                card.FamilyName = NewCard.FamilyName;
                card.BirthDate = NewCard.BirthDate;

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
            // Internet email handling: update/add when present, remove when deleted.
            var newEmail = NewCard.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet);
            var existingEmail = card.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet);

            if (newEmail != null)
            {
                if (existingEmail != null)
                    existingEmail.Address = newEmail.Address;
                else
                    card.EmailAddresses.Add(new vCardEmailAddress(newEmail.Address, vCardEmailAddressType.Internet));
            }
            else
            {
                if (existingEmail != null)
                    card.EmailAddresses.Remove(existingEmail);
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
            string FinalPath;
            if (string.IsNullOrEmpty(familyName))
                FinalPath = _fileHandler.GetVcfFileName(FolderPath, index.ToString());
            else
                FinalPath = _fileHandler.GetVcfFileName(FolderPath, familyName);

            return FinalPath;
        }

        public void ExportToCsv(string path, IEnumerable<Contact> contacts)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(nameof(path));

            var sb = new StringBuilder();
            // En-tête
            sb.AppendLine("FormattedName,GivenName,FamilyName,Email,Cellular,Organization,BirthDate");

            foreach (var c in contacts.Where(x => !x.isDeleted))
            {
                var name = EscapeCsv(c.card.FormattedName);
                var given = EscapeCsv(c.card.GivenName);
                var family = EscapeCsv(c.card.FamilyName);

                // Email internet first
                var email = string.Empty;
                var eAddr = c.card.EmailAddresses.GetFirstChoice(Thought.vCards.vCardEmailAddressType.Internet);
                if (eAddr != null) email = EscapeCsv(eAddr.Address);

                // Cellular
                var cell = string.Empty;
                var cellPhone = c.card.Phones.GetFirstChoice(Thought.vCards.vCardPhoneTypes.Cellular);
                if (cellPhone != null) cell = EscapeCsv(cellPhone.FullNumber);

                var org = EscapeCsv(c.card.Organization ?? string.Empty);

                var bday = c.card.BirthDate.HasValue ? c.card.BirthDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : string.Empty;

                sb.AppendLine(string.Join(",", new[] { name, given, family, email, cell, org, bday }));
            }

            _fileHandler.WriteAllText(path, sb.ToString());
        }

        private static string JsonEncodeString(string s)
        {
            if (s == null) s = string.Empty;
            var esc = s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t");
            return "\"" + esc + "\"";
        }

        private static string JsonEncodeValue(object v)
        {
            if (v == null) return "null";
            if (v is string s) return JsonEncodeString(s);
            if (v is IEnumerable<string> arr)
            {
                return "[" + string.Join(",", arr.Select(JsonEncodeString)) + "]";
            }
            if (v is IEnumerable<object> objArr)
            {
                var parts = objArr.Select(o => JsonEncodeValue(o)).ToArray();
                return "[" + string.Join(",", parts) + "]";
            }
            if (v is bool b) return b ? "true" : "false";
            if (v is Dictionary<string, object> dict)
            {
                var parts = dict.Select(kv => JsonEncodeString(kv.Key) + ":" + JsonEncodeValue(kv.Value));
                return "{" + string.Join(",", parts) + "}";
            }
            // fallback to string
            return JsonEncodeString(v.ToString());
        }

        private static string BuildJCardProperty(string name, Dictionary<string, object> parameters, string valueType, object value)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            sb.Append(JsonEncodeString(name));
            sb.Append(",");
            // parameters -> JSON object or {}
            if (parameters == null || parameters.Count == 0)
            {
                sb.Append("{}");
            }
            else
            {
                sb.Append("{");
                bool first = true;
                foreach (var kv in parameters)
                {
                    if (!first) sb.Append(",");
                    first = false;
                    sb.Append(JsonEncodeString(kv.Key));
                    sb.Append(":");
                    sb.Append(JsonEncodeValue(kv.Value));
                }
                sb.Append("}");
            }
            sb.Append(",");
            sb.Append(JsonEncodeString(valueType));
            sb.Append(",");
            sb.Append(JsonEncodeValue(value));
            sb.Append("]");
            return sb.ToString();
        }


        public void ExportToJson(string path, IEnumerable<Contact> contacts)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(nameof(path));

            // Export en jCard conforme RFC 7095 : chaque vCard est représentée comme ["vcard", [ [prop, params, type, value], ... ] ]
            var sb = new StringBuilder();
            sb.Append("[");

            bool firstCard = true;
            foreach (var c in contacts.Where(x => !x.isDeleted))
            {
                if (!firstCard) sb.Append(",");
                firstCard = false;

                var props = new List<string>();

                // version
                props.Add(BuildJCardProperty("version", null, "text", "4.0"));

                // fn
                props.Add(BuildJCardProperty("fn", null, "text", c.card.FormattedName ?? string.Empty));

                // n -> array [family, given, additional, prefix, suffix]
                var nArray = new[] {
                    c.card.FamilyName ?? string.Empty,
                    c.card.GivenName ?? string.Empty,
                    c.card.AdditionalNames ?? string.Empty,
                    c.card.NamePrefix ?? string.Empty,
                    c.card.NameSuffix ?? string.Empty
                };
                props.Add(BuildJCardProperty("n", null, "text", nArray));

                // emails (internet)
                foreach (var email in c.card.EmailAddresses)
                {
                    var parameters = new Dictionary<string, object>();
                    if (email.EmailType == vCardEmailAddressType.Internet)
                        parameters["type"] = "internet";
                    props.Add(BuildJCardProperty("email", parameters, "text", email.Address ?? string.Empty));
                }

                // phones
                foreach (var phone in c.card.Phones)
                {
                    var pType = phone.PhoneType.ToString().ToLowerInvariant();
                    var parameters = new Dictionary<string, object> { { "type", pType } };
                    props.Add(BuildJCardProperty("tel", parameters, "text", phone.FullNumber ?? string.Empty));
                }

                // org - use array with single element per jCard spec convenience
                if (!string.IsNullOrEmpty(c.card.Organization))
                    props.Add(BuildJCardProperty("org", null, "text", new[] { c.card.Organization }));

                // bday
                if (c.card.BirthDate.HasValue)
                    props.Add(BuildJCardProperty("bday", null, "text", c.card.BirthDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)));

                // build card
                sb.Append("[\"vcard\",[");
                sb.Append(string.Join(",", props));
                sb.Append("]]");
            }

            sb.Append("]");
            _fileHandler.WriteAllText(path, sb.ToString());
        }

        private static string EscapeCsv(string s)
        {
            if (s == null) return string.Empty;
            if (s.Contains("\"") || s.Contains(",") || s.Contains("\n") || s.Contains("\r"))
            {
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            }
            return s;
        }



        public SortableBindingList<Contact> ImportFromJson(string path)
        {
            if (string.IsNullOrEmpty(path) || !_fileHandler.FileExist(path))
                throw new FileNotFoundException(path);

            var lines = _fileHandler.ReadAllLines(path);
            string json = string.Join("\n", lines);

            var parsed = json.FromJson<object>();
            if (!(parsed is List<object> topList))
                return new SortableBindingList<Contact>();

            var cards = new List<List<object>>();

            if (topList.Count >= 1 && topList[0] is string first && string.Equals(first, "vcard", StringComparison.OrdinalIgnoreCase))
            {
                cards.Add(topList);
            }
            else
            {
                foreach (var item in topList)
                {
                    if (item is List<object> cardArr && cardArr.Count > 0 && cardArr[0] is string cardName && string.Equals(cardName, "vcard", StringComparison.OrdinalIgnoreCase))
                    {
                        cards.Add(cardArr);
                    }
                }
            }

            var resultList = new List<Contact>();

            foreach (var cardArr in cards)
            {
                if (cardArr.Count < 2)
                    continue;

                if (!(cardArr[1] is List<object> props))
                    continue;

                var card = new vCard();

                foreach (var p in props)
                {
                    if (!(p is List<object> propList) || propList.Count < 4)
                        continue;

                    var propName = propList[0] as string;
                    var propParams = propList[1];
                    var propType = propList[2] as string;
                    var propValue = propList[3];

                    if (string.IsNullOrEmpty(propName))
                        continue;

                    switch (propName.ToLowerInvariant())
                    {
                        case "version":
                            break;
                        case "fn":
                            if (propValue is string fn) card.FormattedName = fn;
                            break;
                        case "n":
                            // n: [family, given, additional, prefix, suffix]
                            if (propValue is List<object> nlist)
                            {
                                card.FamilyName = nlist.Count > 0 ? (nlist[0]?.ToString() ?? string.Empty) : string.Empty;
                                card.GivenName = nlist.Count > 1 ? (nlist[1]?.ToString() ?? string.Empty) : string.Empty;
                                card.AdditionalNames = nlist.Count > 2 ? (nlist[2]?.ToString() ?? string.Empty) : string.Empty;
                                card.NamePrefix = nlist.Count > 3 ? (nlist[3]?.ToString() ?? string.Empty) : string.Empty;
                                card.NameSuffix = nlist.Count > 4 ? (nlist[4]?.ToString() ?? string.Empty) : string.Empty;
                            }
                            break;
                        case "org":
                            if (propValue is string orgs) card.Organization = orgs;
                            else if (propValue is List<object> orgList && orgList.Count > 0) card.Organization = orgList[0]?.ToString() ?? string.Empty;
                            break;
                        case "title":
                            if (propValue is string title) card.Title = title;
                            break;
                        case "photo":
                            // photo value can be uri or embedded; handle uri -> add as photo with Uri
                            if (propValue is string photoUri)
                            {
                                try
                                {
                                    card.Photos.Add(new vCardPhoto(new Uri(photoUri), null));
                                }
                                catch { }
                            }
                            break;
                        case "email":
                            if (propValue is string emailStr && !string.IsNullOrEmpty(emailStr))
                                card.EmailAddresses.Add(new vCardEmailAddress(emailStr, vCardEmailAddressType.Internet));
                            break;
                        case "tel":
                            if (propValue is string telStr && !string.IsNullOrEmpty(telStr))
                            {
                                // strip "tel:" scheme if present
                                if (telStr.StartsWith("tel:", StringComparison.OrdinalIgnoreCase))
                                    telStr = telStr.Substring(4);

                                var types = ExtractTypesFromParams(propParams);
                                var phoneType = MapPhoneTypes(types);
                                card.Phones.Add(new vCardPhone(telStr, phoneType));
                            }
                            break;
                        case "adr":
                            // adr value is an array: [po box, extended, street, locality, region, postalCode, country]
                            if (propValue is List<object> adrList)
                            {
                                string postOfficeBox = adrList.Count > 0 ? (adrList[0]?.ToString() ?? string.Empty) : string.Empty;
                                string extended = adrList.Count > 1 ? (adrList[1]?.ToString() ?? string.Empty) : string.Empty;
                                string street = adrList.Count > 2 ? (adrList[2]?.ToString() ?? string.Empty) : string.Empty;
                                string city = adrList.Count > 3 ? (adrList[3]?.ToString() ?? string.Empty) : string.Empty;
                                string region = adrList.Count > 4 ? (adrList[4]?.ToString() ?? string.Empty) : string.Empty;
                                string postal = adrList.Count > 5 ? (adrList[5]?.ToString() ?? string.Empty) : string.Empty;
                                string country = adrList.Count > 6 ? (adrList[6]?.ToString() ?? string.Empty) : string.Empty;

                                var adr = new vCardDeliveryAddress(street, city, region, country, postal, vCardDeliveryAddressTypes.Default)
                                {
                                    ExtendedAddress = extended,
                                    PostOfficeBox = postOfficeBox
                                };

                                var types = ExtractTypesFromParams(propParams);
                                var mapped = MapAddressTypes(types);
                                if (mapped.Any())
                                    adr.AddressType = mapped;

                                card.DeliveryAddresses.Add(adr);
                            }
                            break;
                        case "bday":
                            if (propValue is string bdayStr && DateTime.TryParse(bdayStr, null, DateTimeStyles.AdjustToUniversal, out var bdt))
                                card.BirthDate = bdt;
                            break;
                        default:
                            // ignore other properties for now
                            break;
                    }
                }

                resultList.Add(new Contact(card));
            }

            return new SortableBindingList<Contact>(resultList);
        }

        private static List<string> ExtractTypesFromParams(object propParams)
        {
            var types = new List<string>();

            if (propParams == null)
                return types;

            if (propParams is Dictionary<string, object> dict)
            {
                if (dict.TryGetValue("type", out var tval))
                {
                    if (tval is string ts) types.Add(ts);
                    else if (tval is List<object> tl) types.AddRange(tl.Select(x => x?.ToString() ?? string.Empty));
                }
                else
                {
                    // sometimes type may be represented directly as a list or string in params
                    foreach (var kv in dict)
                    {
                        if (kv.Key.Equals("type", StringComparison.OrdinalIgnoreCase))
                        {
                            if (kv.Value is string s) types.Add(s);
                            else if (kv.Value is List<object> lo) types.AddRange(lo.Select(o => o?.ToString() ?? string.Empty));
                        }
                    }
                }
            }
            else if (propParams is List<object> plist)
            {
                // If params is a list of tokens, collect string tokens
                types.AddRange(plist.Select(x => x?.ToString() ?? string.Empty));
            }
            else if (propParams is string ps)
            {
                types.Add(ps);
            }

            // normalize to lower-case
            return types.Where(t => !string.IsNullOrEmpty(t)).Select(t => t.ToLowerInvariant()).ToList();
        }

        private static vCardPhoneTypes MapPhoneTypes(List<string> types)
        {
            if (types == null || types.Count == 0) return vCardPhoneTypes.Default;
            if (types.Any(t => t.Contains("cell") || t.Contains("mobile") || t.Contains("cellular"))) return vCardPhoneTypes.Cellular;
            if (types.Any(t => t.Contains("home"))) return vCardPhoneTypes.Home;
            if (types.Any(t => t.Contains("work"))) return vCardPhoneTypes.Work;
            return vCardPhoneTypes.Default;
        }

        private static List<vCardDeliveryAddressTypes> MapAddressTypes(List<string> types)
        {
            var result = new List<vCardDeliveryAddressTypes>();
            if (types == null || types.Count == 0) return result;
            foreach (var t in types)
            {
                if (t.Contains("home")) result.Add(vCardDeliveryAddressTypes.Home);
                else if (t.Contains("work")) result.Add(vCardDeliveryAddressTypes.Work);
                else if (t.Contains("postal")) result.Add(vCardDeliveryAddressTypes.Postal);
                else if (t.Contains("intl") || t.Contains("international")) result.Add(vCardDeliveryAddressTypes.International);
                else if (t.Contains("dom")) result.Add(vCardDeliveryAddressTypes.Domestic);
                else if (t.Contains("parcel")) result.Add(vCardDeliveryAddressTypes.Parcel);
                else if (t.Contains("preferred") || t == "pref" || t == "preferred") result.Add(vCardDeliveryAddressTypes.Preferred);
            }
            return result.Distinct().ToList();
        }
        public SortableBindingList<Contact> ImportFromCsv(string path)
        {
            if (string.IsNullOrEmpty(path) || !_fileHandler.FileExist(path))
                throw new FileNotFoundException(path);

            using (var stream = _fileHandler.OpenRead(path))
            using (var sr = new StreamReader(stream, Encoding.UTF8))
            {
                var parser = new SmallestCSVParser(sr);
                var header = parser.ReadNextRow();
                if (header == null || header.Count == 0)
                    return new SortableBindingList<Contact>();

                var list = new List<Contact>();
                List<string> row;
                while ((row = parser.ReadNextRow()) != null)
                {
                    string formatted = GetFieldByName(header, row, "FormattedName");
                    string given = GetFieldByName(header, row, "GivenName");
                    string family = GetFieldByName(header, row, "FamilyName");
                    string email = GetFieldByName(header, row, "Email");
                    string cellular = GetFieldByName(header, row, "Cellular");
                    string org = GetFieldByName(header, row, "Organization");
                    string bday = GetFieldByName(header, row, "BirthDate");

                    var card = new vCard
                    {
                        FormattedName = formatted,
                        GivenName = given,
                        FamilyName = family,
                        Organization = org
                    };

                    if (!string.IsNullOrWhiteSpace(email))
                        card.EmailAddresses.Add(new vCardEmailAddress(email, vCardEmailAddressType.Internet));
                    if (!string.IsNullOrWhiteSpace(cellular))
                        card.Phones.Add(new vCardPhone(cellular, vCardPhoneTypes.Cellular));
                    if (!string.IsNullOrWhiteSpace(bday) && DateTime.TryParse(bday, out DateTime dt))
                        card.BirthDate = dt;

                    list.Add(new Contact(card));
                }

                return new SortableBindingList<Contact>(list);
            }
        }

        private static string GetFieldByName(List<string> header, List<string> fields, string name)
        {
            if (header == null || fields == null) return string.Empty;
            int idx = header.FindIndex(h => string.Equals(h?.Trim(), name, StringComparison.OrdinalIgnoreCase));
            if (idx >= 0 && idx < fields.Count)
                return fields[idx].Trim();
            return string.Empty;
        }

    }
}