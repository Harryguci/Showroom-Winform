using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.ComponentGUI
{
    internal class RoundTextBox : TextBox
    {
        // The padding value
        private int padding = 5;
        // The border radius value
        public int BorderRadius { get; set; } = 3;

        public RoundTextBox()
        {
            //Multiline = true;
        }


        private const int EM_SETRECT = 0xB3;

        [DllImport(@"User32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessageRefRect(IntPtr hWnd, uint msg, int wParam, ref RECT rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public readonly int Left;
            public readonly int Top;
            public readonly int Right;
            public readonly int Bottom;

            private RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom)
            {
            }
        }

        public static void SetPadding(TextBox textBox, Padding padding)
        {
            var rect = new Rectangle(padding.Left, padding.Top, textBox.ClientSize.Width - padding.Left - padding.Right, textBox.ClientSize.Height - padding.Top - padding.Bottom);
            RECT rc = new RECT(rect);
            SendMessageRefRect(textBox.Handle, EM_SETRECT, 0, ref rc);
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );

        protected override void OnResize(EventArgs e)
        {
            // Adjust the height of the TextBox
            this.Height = this.PreferredHeight + padding * 2;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, 
                this.Height, BorderRadius, BorderRadius)); //play with these values till you are happy

            base.OnResize(e);
        }
    }
}
