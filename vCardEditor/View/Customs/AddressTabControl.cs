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
        public event EventHandler<EventArg<List<vCardDeliveryAddressTypes>>> ModifyTab;

        public AddressTabControl()
        {
            Padding = new Point(20, 20);
            ShowToolTips = true;
            DrawMode = TabDrawMode.OwnerDrawFixed;

            DrawItem += tbcAddress_DrawItem;
            MouseDown += tbcAddress_MouseDown;
            Selecting += tbcAddress_Selecting;
            HandleCreated += tbcAddress_HandleCreated;
            MouseDoubleClick += AddressTabControl_MouseDoubleClick;
        }

        public void getDeliveryAddress(vCard card)
        {
            if (TabCount < 2)
                return;

            card.DeliveryAddresses.Clear();

            for (int i = 0; i < TabCount - 1; i++)
            {
                if (TabPages[i].Controls.Count == 0) continue;
                AddressBox adr = TabPages[i].Controls[0] as AddressBox;
                card.DeliveryAddresses.Add(adr.getDeliveryAddress());
            }
        }

        private void AddressTabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TabPage SlectedTab;
            for (int i = 0; i < TabPages.Count - 1; ++i)
            {
                if (GetTabRect(i).Contains(e.Location))
                {
                    AddressBox AddressBox = TabPages[i].Controls[0] as AddressBox;

                    AddAddressDialog diag = new AddAddressDialog(AddressBox.AddressType);

                    if (diag.ShowDialog() == DialogResult.OK)
                    {
                        SlectedTab = TabPages[i];
                        SelectedTab.Text = GetTabTitle(diag.Addresses);
                        SelectedTab.ToolTipText = string.Join(",", diag.Addresses.ConvertAll(f => f.ToString()));
                        
                        ModifyTab?.Invoke(sender, new EventArg<List<vCardDeliveryAddressTypes>>(diag.Addresses));
                    }
                    break;
                }
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        private void tbcAddress_HandleCreated(object sender, EventArgs e)
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
            int lastIndex = TabCount - 1;
            if (GetTabRect(lastIndex).Contains(e.Location))
            {
                AddAddressDialog diag = new AddAddressDialog();
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    vCardDeliveryAddress da = new vCardDeliveryAddress();
                    da.AddressType = diag.Addresses;
                    AddtabForAddress(da);
                    AddTab?.Invoke(sender, new EventArg<List<vCardDeliveryAddressTypes>>(diag.Addresses));
                    SelectedIndex = TabCount - 2;
                }
            }
            else
            {
                for (int i = 0; i < TabPages.Count; i++)
                {
                    Rectangle tabRect = GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    Bitmap closeImage = Properties.Resources.Close;
                    Rectangle imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width, closeImage.Height);
                    
                    if (imageRect.Contains(e.Location))
                    {
                        if (MessageBox.Show("Remove tab?", "Asking", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

            Rectangle tabRect = GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            
            if (e.Index == TabCount - 1)
            {
                Bitmap addImage = Properties.Resources.Add;
                e.Graphics.DrawImage(addImage,
                    tabRect.Left + (tabRect.Width - addImage.Width) / 2,
                    tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                Bitmap closeImage = Properties.Resources.Close;
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
            foreach (vCardDeliveryAddress item in card.DeliveryAddresses)
                AddtabForAddress(item);
            SelectedIndex = 0;
        }

        private void AddtabForAddress(vCardDeliveryAddress da)
        {
            string title = GetTabTitle(da.AddressType);

            TabPage page = new TabPage($"  {title}   ");
            TabPages.Insert(TabCount - 1, page);

            AddressBox ab = new AddressBox(da.Street, da.City, da.Region, da.Country,
                                da.PostalCode, da.ExtendedAddress, da.PostOfficeBox, da.AddressType);

            ab.TextChangedEvent += (s, e) => TextChangedEvent?.Invoke(s, e);
            ab.Dock = DockStyle.Fill;
            page.Controls.Add(ab);
            page.ToolTipText = string.Join(",", da.AddressType.ConvertAll(f => f.ToString()));
        }

        private string GetTabTitle(List<vCardDeliveryAddressTypes> addressTypes)
        {
            string title = string.Empty;
            if (addressTypes.Count > 0)
            {
                title = addressTypes[0].ToString();
                if (addressTypes.Count > 1)
                    title += "...";
            }
            return title;
        }

        private void ClearTabs()
        {
            //Remove every tab (except "+"). We don't call Clear() as it doesn't free memory.
            while (TabCount > 1)
                TabPages[0].Dispose();
        }
    }
}
