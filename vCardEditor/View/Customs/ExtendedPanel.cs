using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Thought.vCards;

namespace vCardEditor.View.Customs
{

    public partial class ExtendedPanel : UserControl
    {
        public event EventHandler ContentTextChanged;

        public string Caption
        {
            get { return PanelContent.Text; }
            set { PanelContent.Text = value; }
        }

        public PanelType panelType { get; set; }

        public ExtendedPanel(PanelType _panel)
        {
            InitializeComponent();
            panelType = _panel;
            miCell.Click += MenuItemClickHandlers;
            miCell.Tag = new vCardPhone(string.Empty, vCardPhoneTypes.Cellular);
            
            miHome.Tag = new vCardPhone(string.Empty, vCardPhoneTypes.Home);
            miHome.Click += MenuItemClickHandlers;

            miWork.Tag = new vCardPhone(string.Empty, vCardPhoneTypes.Home);
            miWork.Click += MenuItemClickHandlers;

            miEmail.Tag = new vCardEmailAddress(string.Empty, vCardEmailAddressType.Internet);
            miEmail.Click += MenuItemClickHandlers;
            
            miWeb.Tag = new vCardWebsite(string.Empty, vCardWebsiteTypes.Personal);
            miWeb.Click += MenuItemClickHandlers;

            //TODO : For Custom types
            //CustumInputDialog custom = new CustumInputDialog();
            //var res = custom.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    AddControl(custom.input, string.Empty);
            //}

        }

        private void MenuItemClickHandlers(object sender, EventArgs e)
        {
            var tag = (sender as ToolStripMenuItem).Tag;
            if (tag != null && tag is vCardRoot)
                AddControl(tag as vCardRoot);   
        }

       
        private void btnAddExtraText_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            
            switch (panelType)
            {
                case PanelType.Phone:
                    menuPhone.Show(ptLowerLeft);
                    break;
                case PanelType.Web:
                    menuWeb.Show(ptLowerLeft);
                    break;
                default:
                    break;
            }


           

        }
       
        public void AddControl(vCardRoot card)
        {
            Point pt = GetCoordinatesForNewControl();
            
            RemovableTextBox ctl = new RemovableTextBox(card);
            
            ctl.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            ctl.Location = pt;
            ctl.Width = PanelContent.Width - 20; //TODO : Calculte the right size of the scrollbar!


            ctl.BoutonRemoveClicked += RemoveControl;
            ctl.ContentTextChanged += (s, e) => ContentTextChanged?.Invoke(s, e);
            PanelContent.Controls.Add(ctl);
        }
        public List<vCardRoot> GetExtraFields()
        {
            List<vCardRoot> result = new List<vCardRoot>();

            foreach (var item in PanelContent.Controls)
            {
                var ctl = item as RemovableTextBox;
                result.Add(ctl.Tag as vCardRoot);
            }

            return result;
        }

        public void ClearFields()
        {
            if (PanelContent.Controls.Count > 0)
                PanelContent.Controls.Clear();
        }

        private void RemoveControl(object sender, EventArgs e)
        {
            var par = (sender as Control).Parent;
            PanelContent.Controls.Remove(par);

            ReplaceControls();
        }

        private void ReplaceControls()
        {
            for (int i = 0; i < PanelContent.Controls.Count; i++)
            {
                var ctl = PanelContent.Controls[i];
                ctl.Location = new Point(5, (i * 30) + 10);
            }

        }



        private Point GetCoordinatesForNewControl()
        {
            Point pt;
            if (PanelContent.Controls.Count > 0)
            {
                var LastControl = PanelContent.Controls[PanelContent.Controls.Count - 1];
                pt = LastControl.Location;
                pt.Y += 30;
            }
            else
                pt = new Point(5, 10);

            return pt;
        }



    }
}
