using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vCardEditor.View
{
    public class StateTextBox : TextBox
    {
        private string _oldText;
        public string oldText 
        {
            get { return _oldText; }
        }
      

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            _oldText = this.Text;
        }

    }
}
