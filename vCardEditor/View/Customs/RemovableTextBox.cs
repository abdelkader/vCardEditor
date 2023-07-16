using System;
using System.Windows.Forms;
using Thought.vCards;

namespace vCardEditor.View.Customs
{
    public partial class RemovableTextBox : UserControl
    {
        public event EventHandler BoutonRemoveClicked;
        public event EventHandler ContentTextChanged;
        public RemovableTextBox()
        {
            InitializeComponent();
            btnRemove.Click += (s, e) => BoutonRemoveClicked?.Invoke(s, e);

            ContentTextBox.LostFocus += (s, e) => ContentTextChanged?.Invoke(s, e);
            ContentTextBox.Validated += (s, e) => ContentTextChanged?.Invoke(s, e);


        }

        public RemovableTextBox(vCardRoot cardType) : this()
        {
            //CardType = cardType;
            this.Tag = cardType;
            switch (cardType)
            {
                case vCardPhone phone:
                    Title = phone.PhoneType.ToString();
                    Content = phone.FullNumber;
                    break;

                case vCardEmailAddress email:
                    Title = email.EmailType.ToString();
                    Content = email.Address;
                    break;

                case vCardWebsite website:
                    Title = website.WebsiteType.ToString();
                    Content = website.Url;
                    break;
                   
                default:
                    break;
            }
            
        }


        public string Title
        {
            get { return TitleLabel.Text; }
            set { TitleLabel.Text = value; }
        }

        public string Content
        {
            get { return ContentTextBox.Text; }
            set { ContentTextBox.Text = value; }
        }

    }
}
