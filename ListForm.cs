﻿using ShowroomData.Models;
using ShowroomData.Util;
using System.Data;
using System.Diagnostics;

namespace ShowroomData
{
    public partial class ListForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private DataGridView dt = new DataGridView();
        private string listType = "employees";
<<<<<<< HEAD

        public ListForm(string _listType = "employees")
=======
        private NotificationForm? notificationForm;
        public ListForm(string ListType = "employees")
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
        {
            InitializeComponent();
            HandleGUI();


<<<<<<< HEAD
            listType = _listType;
=======
            listType = ListType;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            //
            // [Add Form events]b
            //
            Resize += Form1_Resize;

            //
            //  [Render GridView]
            //
            RenderDataToGridView();

            dt.SelectionChanged += (sender, args) =>
            {
                if (dt.SelectedRows.Count > 0)
                {
                    btnUpdateInfo.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdateInfo.BackColor = Color.FromArgb(50, 50, 150);
                    btnDelete.BackColor = Color.FromArgb(50, 50, 150);
                }
                else
                {
                    btnUpdateInfo.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdateInfo.BackColor = Color.FromArgb(50, 50, 100);
                    btnDelete.BackColor = Color.FromArgb(50, 50, 100);
                }
            };
        }

        public void HandleGUI()
        {
            WindowState = FormWindowState.Maximized;
            Location = new Point(0, 0);
            Size = Screen.PrimaryScreen.WorkingArea.Size;

            lblHeadingPage.Text = "Danh sách nhân viên";
            lblHeadingPage.Location = new Point((panel1.Width - lblHeadingPage.Width) / 2,
                lblHeadingPage.Location.Y);
<<<<<<< HEAD
=======

            Refresh();
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
        }

        public void RefeshData()
        {
            RenderDataToGridView();
            dt.Refresh();
        }

        //
        // [Handle Events]
        //
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
            if (listType == ListType.EMPLOYEES)
            {
                CreateEmployeeForm createForm = new CreateEmployeeForm(this);
                createForm.Show();
            }
            else if (listType == ListType.PRODUCTS)
            {

            }
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

        private void RenderDataToGridView(string type = "all", string whereCondition = "", int limits = 1000)
        {
            string query = "";
            string table = string.Empty;
            ColumnObject[] colFormat;

            if (listType == ListType.EMPLOYEES)
            {
                table = TableName.EMPLOYEES;
                //Định dạng dataGrid
                colFormat = ColumnObject.EMPLOYEES_COLS;
            }
            else
            {
                colFormat = ColumnObject.PRODUCT_COLS;
            }

            if (type == "all")
            {
                query = $"select Top {limits} * from {table}";
            }
            else if (whereCondition != string.Empty)
            {
                query = $"select Top {limits} * from {table} where {whereCondition}";
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
                DataTable dtResult = processDb.GetData(query);
                dt.DataSource = dtResult;

                for (int i = 0; i < colFormat.Length; i++)
                {
                    dt.Columns[i].HeaderText = colFormat[i].Name;
                    dt.Columns[i].Width = colFormat[i].Width;
                }

                dt.BackgroundColor = Color.LightBlue;
                dt.GridColor = Color.Gray;

                dtResult.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Dispose();
            }
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            RenderDataToGridView(type: "all");
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

        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            if (dt.SelectedRows.Count <= 0) return;
            if (listType == ListType.EMPLOYEES)
            {
                var selected = dt.SelectedRows[0].Cells;

#pragma warning disable CS8604 // Possible null reference argument.
                Employee employee = new Employee(
                    employeeId: selected[0].Value.ToString(),
                    firstname: selected[1].Value.ToString(),
                    lastname: selected[2].Value.ToString()
                )
                {
                    DateBirth = (DateTime?)selected[3].Value,
                    Cccd = (string)selected[4].Value,
                    Position = (string?)selected[5].Value,
                    StartDate = (DateTime?)selected[6].Value,
                    Salary = Convert.ToInt32(selected[7].Value),
                    Email = (string)selected[8].Value,
<<<<<<< HEAD
                    SaleId = (string)selected[9].Value,
=======
                    SaleId = selected[9].Value != null ? (string)selected[9].Value : "",
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
                };
#pragma warning restore CS8604 // Possible null reference argument.

                UpdateInfoForm updateInfoForm = new UpdateInfoForm(employee, this);
                updateInfoForm.Show();
            }
            else if (listType == ListType.PRODUCTS)
            {

            }
        }
<<<<<<< HEAD
=======

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Show Notification Dialog
            Point p = ((Button)sender).Location;
            p = new Point(p.X - 20, p.Y + 50);
            notificationForm = new NotificationForm(location: p);
            notificationForm.Show();
        }

        private void ListForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (notificationForm != null) notificationForm.Close();
        }

        private void ListForm_Click(object sender, EventArgs e)
        {
            if (notificationForm != null) notificationForm.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("DASHBOARD", "Show the dashboard");

            helperDialog.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dt.SelectedRows.Count <= 0) return;
            
            if (listType == ListType.EMPLOYEES)
            {
                var selected = dt.SelectedRows[0].Cells;
                if (selected == null) return;
#pragma warning disable CS8604 // Possible null reference argument.
                Employee employee = new Employee(
                    employeeId: selected[0].Value != null ? selected[0].Value.ToString() : "",
                    firstname: selected[1].Value != null ? selected[1].Value.ToString() : "",
                    lastname: selected[2].Value != null ? selected[2].Value.ToString() : ""
                )
                {
                    DateBirth = selected[3].Value != null ? (DateTime?)selected[3].Value : null,
                    Cccd = selected[4].Value != null ? (string?)selected[4].Value : "",
                    Position = selected[5].Value != null ? (string?)selected[5].Value : "",
                    StartDate = selected[6].Value != null ? (DateTime?)selected[6].Value : null,
                    Salary = selected[7].Value != null ? Convert.ToInt32(selected[7].Value) : 0,
                    Email = selected[8].Value != null ? (string?)selected[8].Value : "",
                    SaleId = selected[9].Value != null ? (string?)selected[9].Value : "",
                };
#pragma warning restore CS8604 // Possible null reference argument.

                if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {employee.Firstname} {employee.Lastname}, " +
                    $"Mã nhân viên: {employee.EmployeeId}?", 
                    "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.No) return;

                processDb.Run($"Delete From Employees where EmployeeId = N'{employee.EmployeeId}'");
            }
            else if (listType == ListType.PRODUCTS)
            {
                // TODO
            }
        }
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
    }
}