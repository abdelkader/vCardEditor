using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thought.vCards;
using VCFEditor.Model;
using System.ComponentModel;

namespace VCFEditor
{
    public class ContactRepository : IContactRepository
    {
        public string fileName { get; set; }

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

        

        /// <summary>
        /// Formatted name.
        /// </summary>
        public const string KeyName = "FN";

        /// <summary>
        /// Load contacts. 
        /// 1- Parse the file
        /// 2- 
        /// </summary>
        /// <param name="path"></param>
        public BindingList<Contact> LoadContacts(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            string[] parts;
            var contact = new Contact();
            
            //Prevent from adding contacts to existings ones.
            Contacts.Clear();

            for (int i = 0; i < lines.Length; i++)
            {

                contact.RawContent.AppendLine(lines[i]);
                if (lines[i] == "END:VCARD")
                {
                    Contacts.Add(contact);
                    contact = new Contact();
                }
                else
                {
                    parts = lines[i].Split(new char[] { ':' });

                    if (string.Compare(parts[0], KeyName) == 0)
                        contact.Name = parts[1];
                }
            }

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
                sb.Append(entry.RawContent);

            File.WriteAllText(fileName, sb.ToString());
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

        public vCard ParseContactAt(int index)
        {
            vCard card = null;
            Contact contact = _contacts[index];

            using (MemoryStream s = GenerateStreamFromString(contact.RawContent.ToString()))
            using (TextReader streamReader = new StreamReader(s, Encoding.Default))
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

        public List<Contact> FilterContacts(string filter)
        {
            List<Contact> Filtered = new List<Contact>(Contacts);
            Filtered.RemoveAll(i => !(i.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0));
            return Filtered;
        }

        public void SaveContactRawContent(int index, string rawContent )
        {
            if (index > -1)
                _contacts[index].RawContent = new StringBuilder(rawContent);
        }
    }
}
