﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Thought.vCards;

namespace vCardEditor.View.Customs
{
    public partial class ExtendedPanel : UserControl
    {
        public ExtendedPanel()
        {
            InitializeComponent();
           
            miCell.Click += MenuItemClickHandlers;
            miCell.Tag = new vCardPhone(string.Empty, vCardPhoneTypes.Cellular);
            
            miHome.Tag = new vCardPhone(string.Empty, vCardPhoneTypes.Home);
            miHome.Click += MenuItemClickHandlers;

            miWork.Tag = new vCardPhone(string.Empty, vCardPhoneTypes.Work);
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

        public event EventHandler ContentTextChanged;

        public string Caption
        {
            get { return PanelContent.Text; }
            set { PanelContent.Text = value; }
        }

        public PanelType panelType { get; set; }
        private void MenuItemClickHandlers(object sender, EventArgs e)
        {
            object tag = (sender as ToolStripMenuItem).Tag;
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

            RemovableTextBox ctl = new RemovableTextBox(card)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left,
                Location = pt,
                Width = PanelContent.Width - 20 //TODO : Calculte the right size of the scrollbar!
            };

            ctl.ButtonRemoveClicked += RemoveControl;
            ctl.ButtonRemoveClicked += (s, e) => ContentTextChanged?.Invoke(s, e);
            ctl.ContentTextChanged += (s, e) => ContentTextChanged?.Invoke(s, e);
            PanelContent.Controls.Add(ctl);
        }

        public List<vCardRoot> GetExtraFields()
        {
            List<vCardRoot> result = new List<vCardRoot>();

            foreach (Control item in PanelContent.Controls)
            {
                result.Add((item as RemovableTextBox).Tag as vCardRoot);
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
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var par = (sender as Control).Parent;
                PanelContent.Controls.Remove(par);

                ReplaceControls();
            }
        }

        private void ReplaceControls()
        {
            for (int i = 0; i < PanelContent.Controls.Count; i++)
            {
                PanelContent.Controls[i].Location = new Point(5, (i * 30) + 10);
            }
        }

        private Point GetCoordinatesForNewControl()
        {
            Point pt;
            if (PanelContent.Controls.Count > 0)
            {
                Control LastControl = PanelContent.Controls[PanelContent.Controls.Count - 1];
                pt = LastControl.Location;
                pt.Y += 30;
            }
            else
                pt = new Point(5, 10);

            return pt;
        }
    }
}
