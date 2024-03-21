using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp.Controls
{
    public class TabControlEx : TabControl
    {
        public delegate void TabPageExCloseEventHandler(object sender, int tabIndex);
        int oncloseButtonHoverIndex = -1;

        public event TabPageExCloseEventHandler OnTabPageExClose;
        public TabControlEx()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Padding = new Point(12, 4);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SendMessage(this.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            //CheckTabWidth((TabPage)e.Control, Graphics.FromHwnd(this.Handle));
            e.Control.TextChanged += TabPage_TextChanged;
        }

        private void TabPage_TextChanged(object sender, EventArgs e)
        {
            //TabPage page = sender as TabPage;
            //if (page != null) { }
            //    CheckTabWidth(page, Graphics.FromHwnd(this.Handle));

        }

        void CheckTabWidth(TabPage page, Graphics g)
        {
            SizeF sz = g.MeasureString(page.Text, page.Font);
            int minWidth = (int)sz.Width + 30;
            page.Height = 100;
            SendMessage(this.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)minWidth);

        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
           
            var tabPage = this.TabPages[e.Index];
            var tabRect = this.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
           
            var closeImage = Properties.Resources.close_black;

            if(e.Index == oncloseButtonHoverIndex)
            {
                e.Graphics.FillRectangle(Brushes.Silver,
                    new Rectangle(
                (tabRect.Right - 21),
                tabRect.Top + (tabRect.Height - 21) / 2, 20, 20));

            }

            e.Graphics.DrawImage(closeImage,new Rectangle(
                (tabRect.Right - 19),
                tabRect.Top + (tabRect.Height - 19) / 2,16,16), new Rectangle(0,0,closeImage.Width, closeImage.Height),GraphicsUnit.Pixel);

            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            for (var i = 0; i < this.TabPages.Count; i++)
            {
                var tabRect = this.GetTabRect(i);
                tabRect.Inflate(-2, -2);

                var imageRect = new Rectangle(
                (tabRect.Right - 19),
                tabRect.Top + (tabRect.Height - 19) / 2, 16, 16);

                if (imageRect.Contains(e.Location))
                {
                    if (OnTabPageExClose != null)
                        OnTabPageExClose(this, i);
                    //this.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            bool finded = false;
            for (var i = 0; i < this.TabPages.Count; i++)
            {
                var tabRect = this.GetTabRect(i);
                tabRect.Inflate(-2, -2);

                var imageRect = new Rectangle(
                (tabRect.Right - 19),
                tabRect.Top + (tabRect.Height - 19) / 2, 16, 16);

                if (imageRect.Contains(e.Location))
                {
                    if (oncloseButtonHoverIndex != i)
                    {
                        oncloseButtonHoverIndex = i;
                        
                        Invalidate();
                    }
                    finded = true;
                    break;
                }
            }

            if(!finded && oncloseButtonHoverIndex!=-1) {
                oncloseButtonHoverIndex=-1;
                Invalidate();
            }
        }

    }
}
