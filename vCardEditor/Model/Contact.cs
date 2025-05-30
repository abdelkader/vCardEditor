using System.ComponentModel;
using Thought.vCards;

namespace VCFEditor.Model
{
    public class Contact : INotifyPropertyChanged
    {
        [DisplayName("Name")]
        public string Name
        {
            get => card.FormattedName;
            set
            {
                card.FormattedName = value;
                NotifyPropertyChanged("Name");
            }
        }
        
        [DisplayName("F.Name")]
        public string FamilyName
        {
            get => card.FamilyName;
        }

        [DisplayName("Cellular")]
        public string Cellular
        {
            get { 
                if (card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular) != null)
                    return card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber;
                return string.Empty;
            }
        }

        [Browsable(false)]
        public vCard card { get; set; }
       
        [Browsable(false)]
        public bool isDirty { get; set; }
        
        [DisplayName(" ")]
        public bool isSelected { get; set; }
        
        [Browsable(false)]
        public bool isDeleted { get; set; }
        
        [Browsable(false)]
        public string path { get; set; }

        public Contact()
        {
            card = new vCard();
            isSelected = false;
            isDirty = false;
        }

        public Contact(vCard card)
        {
            this.card = card;
            isSelected = false;
            isDirty = false;
        }

        public Contact(string path) : this()
        {
            this.path = path;
        }

        private void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
