using ShowroomData.Util;
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
        private DataGridView dt = new DataGridView();
        //private string listType = "all";
        private List<Button>? buttons;

        public Layout(string listType = "employees")
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

        public void RefeshData()
        {
            ShowEmployData();
            dt.Refresh();
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
            CreateEmployeeForm createForm = new CreateEmployeeForm(this);
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
            RefeshData();
        }

        private void ShowEmployData(string type = "all")
        {
            string query = "";
            if (type == "employees")
            {
                query = "select * from employees";
            }

            dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt.Dock = DockStyle.Fill;
            dt.Location = new Point(136, 100);
            dt.Name = "dataGridView1";
            dt.RowTemplate.Height = 25;
            dt.Size = new Size(664, 400);
            dt.TabIndex = 2;
            dt.CellValueChanged += dt_CellValueChanged;
            panelContent.Controls.Add(dt);

            try
            {
                DataTable dtEmployee = processDb.GetData(query);
                dt.DataSource = dtEmployee;

                //Định dạng dataGrid
                ColumnObject[] colFormat = {
                new ColumnObject
                {
                    Name = "Mã nhân viên",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Họ",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Tên",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Ngày sinh",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Giới tính",
                    Width = 50
                },
                new ColumnObject
                {
                    Name = "CCCD",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Vị trí",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Ngày bắt đầu",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Lương",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Email",
                    Width = 100
                },new ColumnObject
                {
                    Name = "SaleId",
                    Width = 100
                }
            };

                for (int i = 0; i < colFormat.Length; i++)
                {
                    dt.Columns[i].HeaderText = colFormat[i].Name;
                    dt.Columns[i].Width = colFormat[i].Width;
                }

                dt.BackgroundColor = Color.LightBlue;
                dt.GridColor = Color.Gray;

                dtEmployee.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Dispose();
            }
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
            if (MessageBox.Show("Bạn có muốn thoát",
                "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
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
