using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace vCardEditor.View.Customs
{
    class AddressTabControl : TabControl
    {
        public AddressTabControl()
        {
            Padding = new Point(12, 4);

            DrawMode = TabDrawMode.OwnerDrawFixed;
            DrawItem += tbcAddress_DrawItem;
            MouseDown += tbcAddress_MouseDown;
            Selecting += tbcAddress_Selecting;
            HandleCreated += tbcAddress_HandleCreated;
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
            var lastIndex = TabCount - 1;
            if (GetTabRect(lastIndex).Contains(e.Location))
            {
                TabPages.Insert(lastIndex, "New Tab");
                SelectedIndex = lastIndex;
                
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
                        closeImage.Width,
                        closeImage.Height);
                    if (imageRect.Contains(e.Location))
                    {
                        TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tbcAddress_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = TabPages[e.Index];
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
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
        }

    }
}
