using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class Layout : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();

        public Layout()
        {
            InitializeComponent();
            HandleGUI();

            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            //
            // [Add Form events]
            //
            Resize += Form1_Resize;
        }

        public void HandleGUI()
        {
            closeFormBtn.Size = new Size(flowLayoutPanel2.Height, flowLayoutPanel2.Height);
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    LoadData();

            //    btnConnect.Text = "Refresh";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "ERROR");
            //    Debug.WriteLine(ex.Message);
            //}
        }

        //private void LoadData()
        //{
        //    DataTable dtEmployee = processDb.GetData("select * from employee");
        //    dataGridView1.DataSource = dtEmployee;
        //    //Định dạng dataGrid
        //    dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
        //    dataGridView1.Columns[1].HeaderText = "Họ";
        //    dataGridView1.Columns[2].HeaderText = "Tên";
        //    dataGridView1.Columns[3].HeaderText = "SDT";
        //    dataGridView1.Columns[4].HeaderText = "Ngày sinh";

        //    dataGridView1.Columns[0].Width = 150;
        //    dataGridView1.Columns[1].Width = 250;
        //    dataGridView1.Columns[2].Width = 250;
        //    dataGridView1.Columns[3].Width = 350;
        //    dataGridView1.Columns[4].Width = 400;

        //    dataGridView1.BackgroundColor = Color.LightBlue;
        //    dataGridView1.GridColor = Color.Gray;

        //    dtEmployee.Dispose();
        //}

        private void Form1_Resize(object? sender, EventArgs e)
        {
            flowLayoutPanel1.Size = new Size(Math.Min(Math.Max(Width / 5, 100), 250),
                flowLayoutPanel1.Size.Height);
            var childs = flowLayoutPanel1.Controls;
            for (int i = 0; i < childs.Count; i++)
            {
                childs[i].Size = new Size(flowLayoutPanel1.Width, childs[i].Height);
            }

            pictureBox1.Location = new Point(flowLayoutPanel1.Width / 2 - pictureBox1.Width / 2,
                pictureBox1.Top);
        }

        //
        // [Handle Events]
        //
        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm createForm = new CreateEmployeeForm();
            createForm.Show();
        }

        private void changeSizeFormBtn_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal : FormWindowState.Maximized;
            ClientSize = new Size(1000, 500);
        }

        //
        // Handle Resizing Form
        //
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

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
    }
}
