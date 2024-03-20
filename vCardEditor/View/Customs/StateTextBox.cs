using System;
using System.Windows.Forms;

namespace vCardEditor.View.Customs
{
    public class StateTextBox : TextBox
    {
        public string oldText { get; set; }

        protected override void OnLostFocus(EventArgs e)
        {
            oldText = this.Text;
            base.OnLostFocus(e);
        }

    }
}
