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
            // [Add Form events]
            //
            Resize += Form1_Resize;
        }

        public void HandleGUI()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            lblHeadingPage.Text = "Danh sách nhân viên";
            lblHeadingPage.Location = new Point((panel1.Width - lblHeadingPage.Width) / 2,
                lblHeadingPage.Location.Y);
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

        private void Layout_Resize(object sender, EventArgs e)
        {
            lblHeadingPage.Location = new Point((panel1.Width - lblHeadingPage.Width) / 2,
               lblHeadingPage.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ShowEmployData(string type = "all")
        {
            string query = "";
            if (type == "all")
            {
                query = "select * from employees";
            }

            DataGridView dt = new DataGridView();
            dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt.Dock = DockStyle.Fill;
            dt.Location = new Point(136, 100);
            dt.Name = "dataGridView1";
            dt.RowTemplate.Height = 25;
            dt.Size = new Size(664, 400);
            dt.TabIndex = 2;
            dt.CellValueChanged += dt_CellValueChanged;


            panel3.Controls.Add(dt);

            DataTable dtEmployee = processDb.GetData(query);
            dt.DataSource = dtEmployee;
            //Định dạng dataGrid
            dt.Columns[0].HeaderText = "Mã nhân viên";
            dt.Columns[1].HeaderText = "Họ";
            dt.Columns[2].HeaderText = "Tên";
            dt.Columns[3].HeaderText = "Ngày sinh";
            dt.Columns[4].HeaderText = "CCCD";
            dt.Columns[5].HeaderText = "Vị trí";
            dt.Columns[6].HeaderText = "Ngày bắt đầu";
            dt.Columns[7].HeaderText = "Lương";
            dt.Columns[8].HeaderText = "Email";

            dt.Columns[0].Width = 100;
            dt.Columns[1].Width = 200;
            dt.Columns[2].Width = 100;
            dt.Columns[3].Width = 200;
            dt.Columns[4].Width = 100;
            dt.Columns[5].Width = 100;
            dt.Columns[6].Width = 200;
            dt.Columns[7].Width = 100;
            dt.Columns[8].Width = 100;

            dt.BackgroundColor = Color.LightBlue;
            dt.GridColor = Color.Gray;

            dtEmployee.Dispose();
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            ShowEmployData();
        }

        private void dt_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            //savedBtn.Enabled = true;
        }

        private void Layout_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Layout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
