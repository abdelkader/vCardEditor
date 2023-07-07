using System;
using System.Windows.Forms;
using vCardEditor.Model;

namespace vCardEditor.View.UIToolbox
{
    public partial class ExtraTextGroup : UserControl
    {
        public event EventHandler ControlDeleted;
        public event EventHandler TextChangedEvent;

        public ExtraTextGroup()
        {
            InitializeComponent();
            txtContent.TextChanged += (s, e) => TextChangedEvent?.Invoke(s, e);
            btnClose.Click += (s, e) => ControlDeleted?.Invoke(s, e);

        }

        public vCardPropeties CardProp { get; set; }

        public string Caption
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public string Content
        {
            get { return txtContent.Text; }
            set { txtContent.Text = value; }
        }
    }
}
