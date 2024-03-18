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
            var card = this.Tag as vCardRoot;
            card.ChangeContent(Content);
        }

        public RemovableTextBox(vCardRoot cardType) : this()
        {
            this.Tag = cardType;
            Title = cardType.GetNameType();
            Content = cardType.ToString();
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
