using System.ComponentModel;
using Thought.vCards;

namespace VCFEditor.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Contact : INotifyPropertyChanged
    {
        [DisplayName(" ")]
        public bool isSelected { get; set; }
       

        [DisplayName("Name")]
        public string Name
        {
            get { return card.FormattedName; }
            set
            {
                card.FormattedName = value;
                this.NotifyPropertyChanged("Name");
            }
        }


        [Browsable(false)]
        public vCard card { get; set; }
       
        [Browsable(false)]
        public bool isDirty { get; set; }
     

        public Contact()
        {
            card = new vCard();
            isSelected = false;
            isDirty = false;
        }

        #region property change event
        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
