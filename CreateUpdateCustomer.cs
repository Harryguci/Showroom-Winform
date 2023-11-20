using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class CreateUpdateCustomer : Form
    {
        private Form? _parent;
        public CreateUpdateCustomer(ListForm? parent = null, string? title = "Tạo Khách hàng")
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            lblHeadingPage.Text = title;

            _parent = parent;
        }

        #region Handle Form Dragging

        //
        // [Handle Dragging the Form]
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void panelContent_Resize(object sender, EventArgs e)
        {
            panel3.Location = new Point((panelContent.Width - panel3.Width) / 2, (panelContent.Height - panel3.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát? Dữ liệu chưa lưu sẽ bị xóa",
                "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
