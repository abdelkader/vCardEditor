using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Thought.vCards;
using VCFEditor.View;

namespace vCardEditor.View.Customs
{
    class AddressTabControl : TabControl
    {
        

        public event EventHandler TextChangedEvent;
        public event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> AddTab;
        public event EventHandler<EventArg<int>> RemoveTab;
        //public event EventHandler<EventArg<TabPage>> ModifyTab;

        public AddressTabControl()
        {
            Padding = new Point(20, 20);
            ShowToolTips = true;
            DrawMode = TabDrawMode.OwnerDrawFixed;

            DrawItem += tbcAddress_DrawItem;
            MouseDown += tbcAddress_MouseDown;
            Selecting += tbcAddress_Selecting;
            HandleCreated += tabControl1_HandleCreated;
            MouseDoubleClick += AddressTabControl_MouseDoubleClick;


           
        }

        public void getDeliveryAddress(vCard card)
        {
            if (TabCount < 2)
                return;

            card.DeliveryAddresses.Clear();

            for (int i = 0; i < TabCount - 1; i++)
            {
                AddressBox adr = TabPages[i].Controls[0] as AddressBox;
                card.DeliveryAddresses.Add(adr.getDeliveryAddress());
            }
        }

        private void AddressTabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //NOT IMPLEMENTED
            //TabPage checkTab;
            //for (int i = 0; i < TabPages.Count; ++i)
            //{
            //    if (GetTabRect(i).Contains(e.Location))
            //    {
            //        var AddressBox =  TabPages[i].Controls[0] as AddressBox;

            //        var diag = new AddAddress(AddressBox.AddressType);
            //        diag.ShowDialog();
            //        //if (diag.ShowDialog() == DialogResult.OK)
            //        //    _card.DeliveryAddresses[i].AddressType = diag.Addresses;
            //        //ModifyTab?.Invoke(sender, new EventArg<TabPage>(checkTab));
            //        break; 
            //    }
            //}
           
        }


        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        private void tabControl1_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        }


        private void tbcAddress_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == TabCount - 1)
                e.Cancel = true;
        }


        private void tbcAddress_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = TabCount - 1;
            if (GetTabRect(lastIndex).Contains(e.Location))
            {
                var diag = new AddAddress();
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    vCardDeliveryAddress da = new vCardDeliveryAddress();
                    da.AddressType = diag.Addresses;
                    AddtabForAddress(da);
                    AddTab?.Invoke(sender, new EventArg<List<vCardDeliveryAddressTypes>>(diag.Addresses));
                }
                SelectedIndex = TabCount - 1;
            }
            else
            {
                for (var i = 0; i < TabPages.Count; i++)
                {
                    var tabRect = GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.Close;
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width, closeImage.Height);
                    
                    if (imageRect.Contains(e.Location))
                    {
                        var result = MessageBox.Show("Remove tab?", "Asking", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            TabPages.RemoveAt(i);
                            SelectedIndex = 0;
                            RemoveTab?.Invoke(sender, new EventArg<int>(i));

                        }
                        return;
                    }
                   
                }
                
            }
        }

       

        private void tbcAddress_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > TabCount - 1)
                return;

            var tabRect = GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            
            if (e.Index == TabCount - 1)
            {
                var addImage = Properties.Resources.Add;
                e.Graphics.DrawImage(addImage,
                    tabRect.Left + (tabRect.Width - addImage.Width) / 2,
                    tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                var closeImage = Properties.Resources.Close;
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);

                TabPage SelectedTab = TabPages[e.Index];
                Rectangle HeaderRect = GetTabRect(e.Index);
                SolidBrush TextBrush = new SolidBrush(Color.Black);
                StringFormat sf = new StringFormat
                {
                    LineAlignment = StringAlignment.Center
                };

                if (e.State == DrawItemState.Selected)
                {
                    Font BoldFont = new Font(Font.Name, Font.Size, FontStyle.Bold);

                    e.Graphics.DrawString(SelectedTab.Text, BoldFont, TextBrush, HeaderRect, sf);
                }
                else
                    e.Graphics.DrawString(SelectedTab.Text , e.Font, TextBrush, HeaderRect, sf);
                
                TextBrush.Dispose();
            }


        }

        public void SetAddresses(vCard card)
        {
            ClearTabs();
            AddTabForEveryAddress(card);
        }

        private void AddTabForEveryAddress(vCard card)
        {
            foreach (var item in card.DeliveryAddresses)
                AddtabForAddress(item);

            //Page for the "+" sign
            TabPages.Add(new TabPage(" "));
        }

        private void AddtabForAddress(vCardDeliveryAddress da)
        {
            var title = da.AddressType[0].ToString();

            if (da.AddressType.Count > 1)
                title += "...";

            var page = new TabPage($"  {title}   ");
            TabPages.Add(page);
            
            var ab = new AddressBox(da.Street, da.City, da.Region, da.Country,
                                da.PostalCode, da.ExtendedAddress, da.PostOfficeBox, da.AddressType);

            ab.TextChangedEvent += (s, e) => TextChangedEvent?.Invoke(s, e);
            page.Controls.Add(ab);
            page.ToolTipText = string.Join(",", da.AddressType.ConvertAll(f => f.ToString()));


        }


        private void ClearTabs()
        {

            //Remove every tab. We don't call Clear() as it doesn't free memory.
            while (TabCount > 0)
                TabPages[TabCount - 1].Dispose();
        }
    }
}
