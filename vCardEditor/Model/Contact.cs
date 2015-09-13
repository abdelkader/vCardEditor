using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thought.vCards;

namespace VCFEditor.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Contact : INotifyPropertyChanged
    {
        private string _name;

        [DisplayName(" ")]
        public bool isSelected { get; set; }
       

        [DisplayName("Name")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
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

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
