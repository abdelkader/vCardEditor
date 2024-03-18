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
            // Bubble up to set the dirty flag from the parent.
            ContentTextBox.LostFocus += (s, e) => ContentTextChanged?.Invoke(s, e);
            ContentTextBox.Validated += (s, e) => ContentTextChanged?.Invoke(s, e);

            //Reflect the changes inside the control, stored inside the Tag.
            ContentTextBox.Validated += ContentTextBox_Validated;
        }

        private void ContentTextBox_Validated(object sender, EventArgs e)
        {
            var card = this.Tag;

            if (card is vCardPhone)
            {
                var phone = card as vCardPhone;
                phone.FullNumber = Content;
            }
            else if (card is vCardEmailAddress)
            {
                var email = card as vCardEmailAddress;
                email.Address = Content;
            }
            else if (card is vCardWebsite)
            {
                var web = card as vCardWebsite;
                web.Url = Content;
            }


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
