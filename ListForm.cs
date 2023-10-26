using ShowroomData.Models;
using ShowroomData.Util;
using ShowroomManagement.Models;
using System.Data;
using System.Diagnostics;

namespace ShowroomData
{
    public partial class ListForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private DataGridView dt = new DataGridView();
        private string listType = "products";

        public ListForm(string _listType = "employees")
        {
            InitializeComponent();
            listType = _listType;
            HandleGUI();


            
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
            string title = "";
            if (listType == "employees")
            {
                title = "nhân viên";
            } else if (listType == "products")
            {
                title = "sản phẩm";
            }
            else if (listType == "customers")
            {
                title = "khách hàng";
            }
            else if (listType == "purchaseinvoice")
            {
                title = "hóa đơn mua";
            }
            else if (listType == "salesinvoice")
            {
                title = "hóa đơn bán";
            }
            else if (listType == "salestargets")
            {
                title = "KPI tháng";
            }
            else if (listType == "devices")
            {
                title = "thiết bị";
            }
            else if (listType == "testdrive")
            {
                title = "chạy thử xe";
            }
            else if (listType == "source")
            {
                title = "nhà cung cấp";
            }
            else
            {
                title = "tài khoản nội bộ";
            }
            
            lblHeadingPage.Text = $"Danh sách {title}";
            lblHeadingPage.Location = new Point((panel1.Width - lblHeadingPage.Width) / 2,
                lblHeadingPage.Location.Y);
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
            #region COLUMOBJ
            if (listType == ListType.EMPLOYEES)
            {
                table = TableName.EMPLOYEES;
                //Định dạng dataGrid
                colFormat = ColumnObject.EMPLOYEES_COLS;
            }
            else if (listType == ListType.PRODUCTS)
            {
                table = TableName.PRODUCTS;
                //Định dạng dataGrid
                colFormat = ColumnObject.PRODUCT_COLS;
            }
            else if (listType == ListType.CUSTOMERS)
            {
                table = TableName.CUSTOMERS;
                //Định dạng dataGrid
                colFormat = ColumnObject.CUSTOMERS_COLS;
            }
            else if (listType == ListType.PURCHASEINVOICES)
            {
                table = TableName.PURCHASEINVOICES;
                //Định dạng dataGrid
                colFormat = ColumnObject.PURCHASEINVOICES_COLS;
            }
            else if (listType == ListType.SALEINVOICES)
            {
                table = TableName.SALEINVOICES;
                //Định dạng dataGrid
                colFormat = ColumnObject.SALEINVOICES_COLS;
            }
            else if (listType == ListType.SALESTARGETS)
            {
                table = TableName.SALESTARGETS;
                //Định dạng dataGrid
                colFormat = ColumnObject.SALETARGETS_COLS;
            }
            else if (listType == ListType.DEVICES)
            {
                table = TableName.DEVICES;
                //Định dạng dataGrid
                colFormat = ColumnObject.DEVICES_COLS;
            }
            else if (listType == ListType.TESTDRIVE)
            {
                table = TableName.TESTDRIVE;
                //Định dạng dataGrid
                colFormat = ColumnObject.TESTDRIVE_COLS;
            }
            else if (listType == ListType.ACCOUNT)
            {
                table = TableName.ACCOUNT;
                //Định dạng dataGrid
                colFormat = ColumnObject.ACCOUNT_COLS;
            }
            else
            {
                table = TableName.SOURCE;
                //Định dạng dataGrid
                colFormat = ColumnObject.SOURCE_COLS;
            } 
            

            #endregion
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
                Employee employee = new Employee()
                {
                    EmployeeId= selected[0].Value.ToString(),
                    Firstname= selected[1].Value.ToString(),
                    Lastname= selected[2].Value.ToString(),
                    DateBirth = (DateTime?)selected[3].Value,
                    Cccd = (string)selected[4].Value,
                    Position = (string?)selected[5].Value,
                    StartDate = (DateTime?)selected[6].Value,
                    Salary = Convert.ToInt32(selected[7].Value),
                    Email = (string)selected[8].Value,
                    SaleId = (string)selected[9].Value,
                    Deleted = (bool?)selected[10].Value
                };
#pragma warning restore CS8604 // Possible null reference argument.

                UpdateInfoForm updateInfoForm = new UpdateInfoForm(employee, this);
                updateInfoForm.Show();
            }
            else if (listType == ListType.CUSTOMERS)
            {
                var selected = dt.SelectedRows[0].Cells;

                Customer customer = new Customer()
                {
                    ClientId = selected[0].Value.ToString(),
                    Firstname = selected[1].Value.ToString(),
                    Lastname = selected[2].Value.ToString(),
                    DateBirth = (DateTime?)selected[3].Value,
                    Gender = (bool)selected[4].Value,
                    Cccd = (string)selected[5].Value,
                    Email = (string)selected[6].Value,
                    Address = (string)selected[7].Value,
                    Deleted = (bool)selected[8].Value
                };

               /* UpdateInfoForm updateInfoForm = new UpdateInfoForm(customer, this);
                updateInfoForm.Show();*/
            }
        }
    }
}
