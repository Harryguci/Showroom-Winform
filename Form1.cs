using System.Data;
using System.Diagnostics;

namespace ShowroomData
{
    public partial class Form1 : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();

        public Form1()
        {
            InitializeComponent();
            HandleGUI();

            //
            // [Add Form events]
            //
            Resize += Form1_Resize;
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                Debug.WriteLine(ex.Message);
            }
        }

        public void HandleGUI()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.savedBtn.Enabled = false;
        }

        private void savedBtn_Click(object sender, EventArgs e)
        {
            // Saved the change
        }

        private void LoadData()
        {
            DataTable dtEmployee = processDb.GetData("select * from employee");
            dataGridView1.DataSource = dtEmployee;
            //Định dạng dataGrid
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Họ";
            dataGridView1.Columns[2].HeaderText = "Tên";
            dataGridView1.Columns[3].HeaderText = "SDT";
            dataGridView1.Columns[4].HeaderText = "Ngày sinh";

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 350;
            dataGridView1.Columns[4].Width = 400;

            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.GridColor = Color.Gray;

            dtEmployee.Dispose();
        }

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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            savedBtn.Enabled = true;
        }
    }
}