using ShowroomData.ComponentGUI;
using ShowroomData.Models;
using ShowroomData.Util;
using System.Data;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class ListForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private DataGridView dt = new DataGridView();
        private string listType = ListType.EMPLOYEES;

        public ListForm(string _listType = "employees")
        {
            InitializeComponent();
            listType = _listType;
            HandleGUI();
            HandleSearchGUI();

            //
            // [Add Form events]
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

        //
        // []
        //
        public void HandleGUI()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Location = new Point(0, 0);
            AutoScroll = true;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            panelContent.AutoScroll = true;

            #region DataGridView_GUI_INIT
            //
            // [DataGridView]
            //
            dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt.Location = new Point(0, 0);
            dt.Size = new Size(panelContent.Width - 50, panelContent.Height - panelFooter.Height - 50);
            dt.AutoSize = false; // set the AutoSize property to false
            dt.ScrollBars = ScrollBars.Both;
            dt.Name = "dataGridView1";
            dt.RowTemplate.Height = 35;
            dt.TabIndex = 2;
            dt.CellValueChanged += dt_CellValueChanged;
            dt.ReadOnly = true;
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(dt);

            // Added Formating for dataGridView Cells Formating
            dt.CellFormatting += dt_CellFormating;

            // Styles
            dt.BackgroundColor = Color.FromArgb(200, 200, 255);
            dt.BorderStyle = BorderStyle.None;
            dt.GridColor = Color.FromArgb(230, 230, 255);

            dt.EnableHeadersVisualStyles = false;
            // Create a DataGridViewCellStyle object for the header
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.FromArgb(50, 50, 150); // Set the background color
            style.ForeColor = Color.White; // Set the foreground color
            style.Font = new Font("Roboto", 12f, FontStyle.Bold); // Set the font style

            // Apply the style to the header
            dt.ColumnHeadersDefaultCellStyle = style;
            dt.ReadOnly = true;
            #endregion

            string title = "";
            if (listType == "employees")
            {
                title = "nhân viên";
            }
            else if (listType == "products")
            {
                title = "sản phẩm";
            }
            else if (listType == "customers")
            {
                title = "khách hàng";
            }
            else if (listType == "purchaseinvoices")
            {
                title = "hóa đơn mua";
            }
            else if (listType == "salesinvoices")
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

        #region HANDLE_FILTERING

        private Label lbMain = new Label(),
            lbHo = new Label(),
            lbPhone = new Label(),
            lbBirthDay = new Label(),
            lbSource = new Label(),
            lbProduct = new Label(),
            lbEmployee = new Label(),
            lbClient = new Label(),
            lbCCCD = new Label();
        private TextBox txtMain = new RoundTextBox(),
            txtHo = new RoundTextBox(),
            txtPhone = new RoundTextBox(),
            txtSource = new RoundTextBox(),
            txtProduct = new RoundTextBox(),
            txtEmployee = new RoundTextBox(),
            txtClient = new RoundTextBox(),
            txtCCCD = new RoundTextBox();
        private DateTimePicker dtBirthDay = new DateTimePicker();
        private Button btnSearch = new Button();

        private void HandleSearchGUI()
        {
            int x = panelFooter.Width / 3;
            int y = panelFooter.Height / 2;

            if (listType == "employees" || listType == "purchaseinvoices" || listType == "customers" || listType == "salesinvoices")
            {
                //lbMain = new Label();
                //txtMain = new RoundTextBox();

                panelFooter.Controls.Add(lbMain);
                panelFooter.Controls.Add(txtMain);
                lbMain.Text = "Tên | Mã";
                lbMain.Location = new Point(50, 5);
                lbMain.AutoSize = true;

                txtMain.Location = new Point(lbMain.Location.X + lbMain.Width + 10, lbMain.Location.Y);
                txtMain.Width = x - txtMain.Location.X - 50;
                txtMain.TextChanged += SearchTextBox_Changed;
                txtMain.Multiline = true;
                txtMain.BackColor = Color.FromArgb(100, 100, 255);
                txtMain.ForeColor = Color.White;
                RoundTextBox.SetPadding(txtMain, new Padding(10, 10, 2, 2));

                btnSearch = new Button();
                panelFooter.Controls.Add(btnSearch);
                btnSearch.Text = "Tìm kiếm";
                btnSearch.Width = 200;
                btnSearch.Height = 50;
                btnSearch.Location = new Point(x * 2 + 100, y / 2);
                btnSearch.Click += BtnSearch_Click;
                btnSearch.Font = new Font("Roboto", 12F, FontStyle.Bold);

            }


            if (listType == "employees")
            {
                panelFooter.Controls.Add(lbCCCD);
                panelFooter.Controls.Add(lbHo);
                panelFooter.Controls.Add(lbBirthDay);

                panelFooter.Controls.Add(txtHo);
                panelFooter.Controls.Add(txtCCCD);
                panelFooter.Controls.Add(dtBirthDay);

                lbHo.AutoSize = true;
                lbHo.Text = "Họ";
                lbHo.Location = new Point(lbMain.Location.X, y + 5);

                txtHo.Location = new Point(txtMain.Location.X, lbHo.Location.Y);
                txtHo.Width = txtMain.Width;
                txtHo.BackColor = Color.FromArgb(100, 100, 255);
                txtHo.ForeColor = Color.White;
                txtHo.Multiline = true;
                txtHo.TextChanged += SearchTextBox_Changed;

                lbCCCD.AutoSize = true;
                lbCCCD.Text = "CCCD";
                lbCCCD.Location = new Point(x + 5, 5);

                txtCCCD.Location = new Point(lbCCCD.Width + lbCCCD.Location.X + 50, lbCCCD.Location.Y);
                txtCCCD.Width = txtMain.Width;
                txtCCCD.BackColor = Color.FromArgb(100, 100, 255);
                txtCCCD.ForeColor = Color.White;
                txtCCCD.Multiline = true;
                txtCCCD.TextChanged += SearchTextBox_Changed;

                lbBirthDay.AutoSize = true;
                lbBirthDay.Text = "Ngày sinh";
                lbBirthDay.Location = new Point(lbCCCD.Location.X, y + 5);

                dtBirthDay.Format = DateTimePickerFormat.Custom;
                dtBirthDay.CustomFormat = "MM/yyyy";
                dtBirthDay.ShowUpDown = true;

                dtBirthDay.Location = new Point(txtCCCD.Location.X, lbBirthDay.Location.Y);
                dtBirthDay.Width = 100;
                dtBirthDay.Height = 100;

                RoundTextBox.SetPadding(txtHo, new Padding(20));
                RoundTextBox.SetPadding(txtCCCD, new Padding(20));
            }
            else if (listType == "purchaseinvoices")
            {
                lbMain.Text = "Mã HĐM";

                panelFooter.Controls.Add(lbSource);
                panelFooter.Controls.Add(lbProduct);
                panelFooter.Controls.Add(lbBirthDay);

                panelFooter.Controls.Add(txtProduct);
                panelFooter.Controls.Add(txtSource);
                panelFooter.Controls.Add(dtBirthDay);


                lbProduct.AutoSize = true;
                lbProduct.Text = "Mã SP";
                lbProduct.Location = new Point(lbMain.Location.X, y + 5);

                txtProduct.Location = new Point(txtMain.Location.X, lbProduct.Location.Y);
                txtProduct.Width = txtMain.Width;
                txtProduct.Multiline = true;
                txtProduct.BackColor = Color.FromArgb(100, 100, 255);
                txtProduct.ForeColor = Color.White;
                txtProduct.TextChanged += SearchTextBox_Changed;

                lbSource.AutoSize = true;
                lbSource.Text = "Mã NCC";
                lbSource.Location = new Point(x + 5, 5);

                txtSource.Location = new Point(lbSource.Width + lbSource.Location.X + 50, lbSource.Location.Y);
                txtSource.Width = txtMain.Width;
                txtSource.Multiline = true;
                txtSource.BackColor = Color.FromArgb(100, 100, 255);
                txtSource.ForeColor = Color.White;
                txtSource.TextChanged += SearchTextBox_Changed;

                lbBirthDay.AutoSize = true;
                lbBirthDay.Text = "Ngày nhập";
                lbBirthDay.Location = new Point(lbSource.Location.X, y + 5);

                dtBirthDay.Format = DateTimePickerFormat.Custom;
                dtBirthDay.CustomFormat = "MM/yyyy";
                dtBirthDay.ShowUpDown = true;

                dtBirthDay.Location = new Point(txtSource.Location.X, lbBirthDay.Location.Y);
                dtBirthDay.Width = 100;
                dtBirthDay.Height = 100;
                dtBirthDay.TextChanged += SearchTextBox_Changed;

                RoundTextBox.SetPadding(txtSource, new Padding(5, 5, 5, 5));
                RoundTextBox.SetPadding(txtProduct, new Padding(5, 5, 5, 5));
            }
            else if (listType == "customers")
            {
                panelFooter.Controls.Add(lbPhone);
                panelFooter.Controls.Add(lbHo);
                panelFooter.Controls.Add(lbBirthDay);

                panelFooter.Controls.Add(txtHo);
                panelFooter.Controls.Add(txtPhone);
                panelFooter.Controls.Add(dtBirthDay);


                lbHo.AutoSize = true;
                lbHo.Text = "Họ";
                lbHo.Location = new Point(lbMain.Location.X, y + 5);

                txtHo.Location = new Point(txtMain.Location.X, lbHo.Location.Y);
                txtHo.Width = txtMain.Width;
                txtHo.BackColor = Color.FromArgb(100, 100, 255);
                txtHo.ForeColor = Color.White;
                txtHo.Multiline = true;
                txtHo.TextChanged += SearchTextBox_Changed;

                lbPhone.AutoSize = true;
                lbPhone.Text = "CCCD";
                lbPhone.Location = new Point(x + 5, 5);

                txtPhone.Location = new Point(lbPhone.Width + lbPhone.Location.X + 50, lbPhone.Location.Y);
                txtPhone.Width = txtMain.Width;
                txtPhone.Multiline = true;
                txtPhone.BackColor = Color.FromArgb(100, 100, 255);
                txtPhone.ForeColor = Color.White;
                txtPhone.TextChanged += SearchTextBox_Changed;

                lbBirthDay.AutoSize = true;
                lbBirthDay.Text = "Ngày sinh";
                lbBirthDay.Location = new Point(lbPhone.Location.X, y + 5);

                dtBirthDay.Format = DateTimePickerFormat.Custom;
                dtBirthDay.CustomFormat = "MM/yyyy";
                dtBirthDay.ShowUpDown = true;

                dtBirthDay.Location = new Point(txtPhone.Location.X, lbBirthDay.Location.Y);
                dtBirthDay.Width = 100;
                dtBirthDay.Height = 100;
                dtBirthDay.TextChanged += SearchTextBox_Changed;

                RoundTextBox.SetPadding(txtHo, new Padding(5, 5, 5, 5));
                RoundTextBox.SetPadding(txtPhone, new Padding(5, 5, 5, 5));
            }
            else if (listType == "salesinvoices")
            {
                int _y = panelFooter.Height / 3;

                lbMain.Text = "Mã HĐB";

                panelFooter.Controls.Add(lbEmployee);
                panelFooter.Controls.Add(lbProduct);
                panelFooter.Controls.Add(lbBirthDay);
                panelFooter.Controls.Add(lbClient);

                panelFooter.Controls.Add(txtEmployee);
                panelFooter.Controls.Add(txtProduct);
                panelFooter.Controls.Add(txtClient);
                panelFooter.Controls.Add(dtBirthDay);


                lbProduct.AutoSize = true;
                lbProduct.Text = "Mã SP";
                lbProduct.Location = new Point(lbMain.Location.X, y + 5);

                txtProduct.Location = new Point(txtMain.Location.X, lbProduct.Location.Y);
                txtProduct.Width = txtMain.Width;
                txtProduct.Multiline = true;
                txtProduct.BackColor = Color.FromArgb(100, 100, 255);
                txtProduct.TextChanged += SearchTextBox_Changed;
                txtProduct.ForeColor = Color.White;

                lbEmployee.AutoSize = true;
                lbEmployee.Text = "Mã NV";
                lbEmployee.Location = new Point(lbMain.Location.X, y * 2 + 5);

                txtEmployee.Location = new Point(txtMain.Location.X, lbEmployee.Location.Y);
                txtEmployee.Width = txtMain.Width;
                txtEmployee.Multiline = true;
                txtEmployee.BackColor = Color.FromArgb(100, 100, 255);
                txtEmployee.ForeColor = Color.White;
                txtEmployee.TextChanged += SearchTextBox_Changed;

                lbClient.AutoSize = true;
                lbClient.Text = "Mã KH";
                lbClient.Location = new Point(x + 5, lbMain.Location.Y);

                txtClient.Location = new Point(lbClient.Width + x + 30, lbClient.Location.Y);
                txtClient.Multiline = true;
                txtClient.BackColor = Color.FromArgb(100, 100, 255);
                txtClient.ForeColor = Color.White;
                txtClient.Width = txtMain.Width;
                txtClient.TextChanged += SearchTextBox_Changed;

                lbBirthDay.AutoSize = true;
                lbBirthDay.Text = "Ngày sinh";
                lbBirthDay.Location = new Point(lbClient.Location.X, y + 5);

                dtBirthDay.Format = DateTimePickerFormat.Custom;
                dtBirthDay.CustomFormat = "MM/yyyy";
                dtBirthDay.ShowUpDown = true;

                dtBirthDay.Location = new Point(txtClient.Location.X, lbBirthDay.Location.Y);
                dtBirthDay.Width = 100;
                dtBirthDay.Height = 100;
                dtBirthDay.TextChanged += SearchTextBox_Changed;

                RoundTextBox.SetPadding(txtEmployee, new Padding(5));
                RoundTextBox.SetPadding(txtClient, new Padding(5));
                RoundTextBox.SetPadding(txtProduct, new Padding(5));
            }
        }

        private DataTable HandleSearch()
        {
            string query = "";
            if (listType == "employees")
            {
                query += $"SELECT * FROM {listType} WHERE 1 = 1 ";
                string main = txtMain.Text.Trim().ToLower();
                string ho = txtHo.Text.Trim().ToLower();
                string cccd = txtCCCD.Text.Trim().ToLower();

                DateTime selectedDateTime = dtBirthDay.Value;
                DateTime currentDateTime = DateTime.Now;


                DateTime currentMonthYear = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);


                DateTime selectedMonthYear = new DateTime(selectedDateTime.Year, selectedDateTime.Month, 1);


                if (selectedMonthYear != currentMonthYear)
                {
                    int month = selectedMonthYear.Month;
                    int year = selectedMonthYear.Year;
                    query += $"AND  MONTH(DateBirth) = {month} and YEAR(DateBirth) = {year}";
                }


                if (!string.IsNullOrEmpty(main))
                {
                    query += $"AND (EmployeeId LIKE N'%{main}%' OR FirstName LIKE N'%{main}%') ";
                }
                if (!string.IsNullOrEmpty(ho))
                {
                    query += $"AND LastName LIKE N'%{ho}%'";
                }
                if (!string.IsNullOrEmpty(cccd))
                {
                    query += $"AND CCCD  LIKE N'%{cccd}%'";
                }

            }
            else if (listType == "customers")
            {
                query += $"SELECT * FROM {listType} WHERE 1 = 1 ";
                string main = txtMain.Text.Trim().ToLower();
                string ho = txtHo.Text.Trim().ToLower();
                string cccd = txtCCCD.Text.Trim().ToLower();

                DateTime selectedDateTime = dtBirthDay.Value;
                DateTime currentDateTime = DateTime.Now;


                DateTime currentMonthYear = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);


                DateTime selectedMonthYear = new DateTime(selectedDateTime.Year, selectedDateTime.Month, 1);


                if (selectedMonthYear != currentMonthYear)
                {
                    int month = selectedMonthYear.Month;
                    int year = selectedMonthYear.Year;
                    query += $"AND  MONTH(DateBirth) = {month} and YEAR(DateBirth) = {year}";
                }


                if (!string.IsNullOrEmpty(main))
                {
                    query += $"AND (ClientId LIKE N'%{main}%' OR FirstName LIKE N'%{main}%') ";
                }
                if (!string.IsNullOrEmpty(ho))
                {
                    query += $"AND LastName LIKE N'%{ho}%'";
                }
                if (!string.IsNullOrEmpty(cccd))
                {
                    query += $"AND CCCD  LIKE N'%{cccd}%'";
                }

            }
            else if (listType == "purchaseinvoices")
            {
                query += $"SELECT * FROM {listType} WHERE 1 = 1 ";
                string main = txtMain.Text.Trim().ToLower();
                string source = txtSource.Text.Trim().ToLower();
                string productid = txtProduct.Text.Trim().ToLower();

                DateTime selectedDateTime = dtBirthDay.Value;
                DateTime currentDateTime = DateTime.Now;
                DateTime currentMonthYear = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);
                DateTime selectedMonthYear = new DateTime(selectedDateTime.Year, selectedDateTime.Month, 1);

                if (selectedMonthYear != currentMonthYear)
                {
                    int month = selectedMonthYear.Month;
                    int year = selectedMonthYear.Year;
                    query += $"AND  MONTH(Date) = {month} and YEAR(Date) = {year}";
                }
                if (!string.IsNullOrEmpty(main))
                {
                    query += $"AND InEnterId LIKE N'%{main}%'";
                }
                if (!string.IsNullOrEmpty(source))
                {
                    query += $"AND SourceId LIKE N'%{source}%'";
                }
                if (!string.IsNullOrEmpty(productid))
                {
                    query += $"AND ProductId  LIKE N'%{productid}%'";
                }
            }
            else if (listType == "salesinvoices")
            {
                query += $"SELECT * FROM {listType} WHERE 1 = 1 ";
                string main = txtMain.Text.Trim().ToLower();
                string clientid = txtClient.Text.Trim().ToLower();
                string productid = txtProduct.Text.Trim().ToLower();
                string employeeid = txtEmployee.Text.Trim().ToLower();

                DateTime selectedDateTime = dtBirthDay.Value;
                DateTime currentDateTime = DateTime.Now;
                DateTime currentMonthYear = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);
                DateTime selectedMonthYear = new DateTime(selectedDateTime.Year, selectedDateTime.Month, 1);

                if (selectedMonthYear != currentMonthYear)
                {
                    int month = selectedMonthYear.Month;
                    int year = selectedMonthYear.Year;
                    query += $"AND  MONTH(Date) = {month} and YEAR(Date) = {year}";
                }
                if (!string.IsNullOrEmpty(main))
                {
                    query += $"AND InSaleId LIKE N'%{main}%'";
                }
                if (!string.IsNullOrEmpty(clientid))
                {
                    query += $"AND ClientId LIKE N'%{clientid}%'";
                }
                if (!string.IsNullOrEmpty(productid))
                {
                    query += $"AND ProductId  LIKE N'%{productid}%'";
                }
                if (!string.IsNullOrEmpty(employeeid))
                {
                    query += $"AND EmployeeId  LIKE N'%{employeeid}%'";
                }
            }

            try
            {
                DataTable dta = new DataTable();
                dta = processDb.GetData(query);
                return dta;
            }
            catch (Exception ep)
            {
                Console.WriteLine(ep.Message);
                Console.WriteLine(ep.StackTrace);
                throw; // Re-throw ngoại lệ để nó được xử lý ở nơi gọi hàm này
            }
        }
        private void SearchTextBox_Changed(object? sender, EventArgs e)
        {
            HandleSearch();
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            var dataTable = HandleSearch();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        public void RefreshData()
        {
            RenderDataToGridView();
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
                CreateProduct createProduct = new CreateProduct(this);
                createProduct.Show();
            }
            else if (listType == ListType.CUSTOMERS)
            {
                CreateUpdateCustomer form = new CreateUpdateCustomer(this);
                form.Show();
            }
            else if (listType == ListType.DEVICES)
            {
                CreateDevice createDevice = new CreateDevice(this);
                createDevice.Show();
            }
            else if (listType == ListType.PURCHASEINVOICES)
            {
                CreatePurchaseInvoice createPurchaseInvoice = new CreatePurchaseInvoice(this);
                createPurchaseInvoice.Show();
            }
            else if (listType == ListType.SALEINVOICES)
            {
                CreateSaleInvoice createSaleInvoice = new CreateSaleInvoice(this);
                createSaleInvoice.Show();
            }
            else if (listType == ListType.SALESTARGETS)
            {
                CreateSaleTarget createSaleTarget = new CreateSaleTarget(this);
                createSaleTarget.Show();
            }
            else if (listType == ListType.SOURCE)
            {
                CreateSource createSource = new CreateSource(this);
                createSource.Show();
            }
            else
            {
                CreateSchedule createSchedule = new CreateSchedule(this);
                createSchedule.Show();
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
            RefreshData();
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
                query = $"select Top {limits} * from {table}";
            else if (whereCondition != string.Empty)
                query = $"select Top {limits} * from {table} where {whereCondition}";

            //dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dt.Location = new Point(0, 0);
            //dt.Size = new Size(panelContent.Width - 50, panelContent.Height - panelFooter.Height - 50);
            //dt.AutoSize = false; // set the AutoSize property to false
            //dt.ScrollBars = ScrollBars.Both;
            //dt.Name = "dataGridView1";
            //dt.RowTemplate.Height = 35;
            //dt.TabIndex = 2;
            //dt.CellValueChanged += dt_CellValueChanged;
            //panelContent.AutoScroll = true;
            //panelContent.Controls.Add(dt);
            try
            {
                DataTable dtResult = processDb.GetData(query);
                var colGenderRaw = dtResult.Columns["Gender"];
                if (colGenderRaw != null)
                {
                    dtResult.Columns.Add("gendertext");
                    var colGenderText = dtResult.Columns["gendertext"];

                    dtResult.Columns[dtResult.Columns.IndexOf(colGenderText)]
                        .SetOrdinal(dtResult.Columns.IndexOf(colGenderRaw));

                }


                dt.DataSource = dtResult;

                #region HANDLE_DISPLAY_GENDER

                int genderIndex = -1;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (dt.Columns[i].Name.ToLower() == "gender")
                    {
                        genderIndex = i;
                        break;
                    }
                }

                if (genderIndex >= 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i].Cells[genderIndex].Value != null
                            && (bool)dt.Rows[i].Cells[genderIndex].Value)
                        {
                            dt.Rows[i].Cells[dt.Columns.IndexOf(dt.Columns["gendertext"])].Value = "Nam";
                        }
                        else if (dt.Rows[i].Cells[genderIndex].Value != null
                            && (bool)dt.Rows[i].Cells[genderIndex].Value == false)
                        {
                            dt.Rows[i].Cells[dt.Columns.IndexOf(dt.Columns["gendertext"])].Value = "Nữ";
                        }
                    }
                }

                #endregion
                for (int i = 0; i < colFormat.Length; i++)
                {
                    dt.Columns[i].HeaderText = colFormat[i].Name;
                    dt.Columns[i].Width = colFormat[i].Width;
                }
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (dt.Columns[i].Name.ToLower() == "deleted"
                        || dt.Columns[i].Name.ToLower() == "url_image"
                        || dt.Columns[i].Name.ToLower() == "gender")
                    {
                        dt.Columns[i].Visible = false;
                    }
                }

                //// Added Formating for dataGridView Cells Formating
                //dt.CellFormatting += dt_CellFormating;

                //// Styles
                //dt.BackgroundColor = Color.FromArgb(200, 200, 255);
                //dt.BorderStyle = BorderStyle.None;
                //dt.GridColor = Color.FromArgb(230, 230, 255);

                //dt.EnableHeadersVisualStyles = false;
                //// Create a DataGridViewCellStyle object for the header
                //DataGridViewCellStyle style = new DataGridViewCellStyle();
                //style.BackColor = Color.FromArgb(50, 50, 150); // Set the background color
                //style.ForeColor = Color.White; // Set the foreground color
                //style.Font = new Font("Roboto", 12f, FontStyle.Bold); // Set the font style

                //// Apply the style to the header
                //dt.ColumnHeadersDefaultCellStyle = style;
                //dt.ReadOnly = true;

                dtResult.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Dispose();
            }
        }

        private void dt_CellFormating(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == System.DBNull.Value || e.Value == null)
            {
                if (e.DesiredType.Name == "String")
                {
                    e.Value = "";
                }
                return;
            }

            if (e.Value.GetType() == typeof(bool) && (bool?)e.Value == true)
            {
                e.CellStyle.BackColor = Color.FromArgb(245, 245, 255);
            }
            else if (e.Value.GetType() == typeof(bool) && (bool?)e.Value == false)
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 245, 245);
            }

            if (e.Value.GetType() == typeof(string))
            {
                if ((string)e.Value == "Available")
                    e.Value = "Sẵn";
                else if ((string)e.Value == "Sales")
                    e.Value = "NV Sale";
                else if ((string)e.Value == "Sales Manager")
                    e.Value = "Quản lý";
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            RenderDataToGridView(type: "all");
        }

        private void dt_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            //savedBtn.Enabled = true;
        }

        private void Layout_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thoát",
            //    "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
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
                var id = (string)selected[0].Value;
                var query = processDb.GetData($"SELECT * FROM EMPLOYEES WHERE EMPLOYEEID = N'{id.Trim()}'");
                if (query.Rows.Count <= 0) return;

                Employee employee = new Employee()
                {
                    EmployeeId = query.Rows[0].Field<string>("EmployeeId") ?? "",
                    Firstname = query.Rows[0].Field<string>("Firstname") ?? "",
                    Lastname = query.Rows[0].Field<string>("Lastname") ?? "",
                    DateBirth = query.Rows[0].Field<DateTime>("DateBirth"),
                    Phone = query.Rows[0].Field<string>("PhoneNumber"),
                    Gender = query.Rows[0].Field<bool>("Gender"),
                    Cccd = query.Rows[0].Field<string>("CCCD"),
                    Position = query.Rows[0].Field<string>("Position"),
                    StartDate = query.Rows[0].Field<DateTime>("StartDate"),
                    Salary = query.Rows[0].Field<int>("Salary"),
                    Email = query.Rows[0].Field<string>("Email"),
                    Deleted = query.Rows[0].Field<bool>("Deleted"),
                    Url_image = query.Rows[0].Field<string>("Url_image"),
                };

                UpdateInfoForm updateInfoForm = new UpdateInfoForm(employee, this);
                updateInfoForm.FormClosed += (f, args) =>
                {
                    RefreshData();
                };

                updateInfoForm.ShowDialog(this);
            }
            else if (listType == ListType.CUSTOMERS)
            {
                var selected = dt.SelectedRows[0].Cells;
                var id = (string)selected[0].Value;
                var query = processDb.GetData($"SELECT * FROM CUSTOMERS WHERE ClientId = N'{id.Trim()}'");
                var response = query.Rows[0];
                if (query.Rows.Count <= 0) return;

                Customer customer = new Customer()
                {
                    ClientId = response.Field<string>("ClientId") ?? "",
                    Firstname = response.Field<string>("Firstname") ?? "",
                    Lastname = response.Field<string>("Lastname") ?? "",
                    DateBirth = response.Field<DateTime>("DateBirth"),
                    PhoneNumber = response.Field<string>("PhoneNumber") ?? "",
                    Gender = response.Field<bool>("Gender"),
                    Cccd = response.Field<string>("CCCD") ?? "",
                    Email = response.Field<string>("Email") ?? "",
                    Address = response.Field<string>("Address") ?? "",
                    Deleted = response.Field<bool>("Deleted"),
                };

                CreateUpdateCustomer updateForm = new CreateUpdateCustomer(this, title: "Cập nhật khách hàng", customer);
                //updateForm.FormClosed += (e, args) =>
                //{
                //    RefreshData();
                //};
                updateForm.ShowDialog(this);
            }
            else if (listType == ListType.PRODUCTS)
            {
                var selected = dt.SelectedRows[0].Cells;
                if (selected[1].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể tìm thấy Sản phẩm",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var id = (string)selected[1].Value;
                id = id.Trim();

                var query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE SERIAL = N'{id}'");
                if (query.Rows.Count <= 0)
                {
                    MessageBox.Show("Không thể tìm thấy Sản phẩm",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var response = query.Rows[0];

                Products products = new Products()
                {
                    Serial = response.Field<string>("Serial") ?? "",
                    ProductName = response.Field<string>("ProductName") ?? "",
                    PurchasePrice = response.Field<int>("PurchasePrice"),
                    SalePrice = response.Field<int>("SalePrice"),
                    Quantity = response.Field<int>("Quantity"),
                    Status = response.Field<string>("Status") ?? "",
                    Deleted = response.Field<bool>("Deleted")
                };

                UpdateProduct updateProduct = new UpdateProduct(products, this);
                updateProduct.ShowDialog(this);
            }
            else if (listType == ListType.PURCHASEINVOICES)
            {
                var selected = dt.SelectedRows[0].Cells;
                if (selected[0].Value == DBNull.Value)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.\nVui lòng thử lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var id = (string)selected[0].Value;
                id = id.Trim();
                var query = processDb.GetData($"SELECT * FROM PURCHASEINVOICES WHERE InEnterId = N'{id}'");
                if (query.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.\nVui lòng thử lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var response = query.Rows[0];

                PurchaseInvoice purchaseInvoice = new PurchaseInvoice()
                {
                    InEnterId = response.Field<string>("InEnterId") ?? "",
                    SourceId = response.Field<string>("SourceId") ?? "",
                    ProductId = response.Field<string>("ProductId") ?? "",
                    EnteredDate = response.Field<DateTime>("EnteredDate"),
                    QuantityPurchase = response.Field<int>("QuantityPurchase"),
                    Status = response.Field<string>("Status") ?? "",
                    Deleted = response.Field<bool>("Deleted")
                };

                UpdatePurchaseInvoice updatePurchaseInvoice = new UpdatePurchaseInvoice(purchaseInvoice,
                    this);
                updatePurchaseInvoice.Show();
            }
            else if (listType == ListType.SALEINVOICES)
            {
                var selected = dt.SelectedRows[0].Cells;

                SalesInvoice salesInvoice = new SalesInvoice()
                {
                    InSaleId = (string)selected[0].Value,
                    ClientId = (string)selected[1].Value,
                    EmployeeId = (selected[2].Value != System.DBNull.Value ? (string)selected[2].Value : ""),
                    ProductId = (string)selected[3].Value,
                    SaleDate = (DateTime?)selected[4].Value,
                    QuantitySale = (int)selected[5].Value,
                    Status = (string)selected[6].Value,
                    Deleted = (selected[7].Value != System.DBNull.Value ? (bool)selected[7].Value : false)
                };

                UpdateSaleInvoice updateSaleInvoice = new UpdateSaleInvoice(salesInvoice, this);
                updateSaleInvoice.Show();

                updateSaleInvoice.FormClosed += (f, args) =>
                {
                    RefreshData();
                };
            }
            else if (listType == ListType.SALESTARGETS)
            {
                var selected = dt.SelectedRows[0].Cells;

                SalesTarget salesTarget = new SalesTarget()
                {
                    SaleId = (string)selected[0].Value,
                    EmployeeId = (string)selected[1].Value,
                    StartDate = (DateTime)selected[2].Value,
                    EndDate = (DateTime)selected[3].Value,
                    Total = (int)selected[4].Value,
                    Target = (int)selected[5].Value,
                    Status = (string)selected[6].Value,
                    Reward = (double)selected[7].Value,
                };

                UpdateSaleTarget updateSaleTarget = new UpdateSaleTarget(salesTarget, this);
                updateSaleTarget.Show();
            }
            else if (listType == ListType.SOURCE)
            {
                var selected = dt.SelectedRows[0].Cells;

                Source source = new Source()
                {
                    SourceId = (string)selected[0].Value,
                    Name = (string)selected[1].Value
                };

                UpdateSource updateSource = new UpdateSource(source, this);
                updateSource.Show();
            }
            else if (listType == ListType.DEVICES)
            {
                var selected = dt.SelectedRows[0].Cells;

                Device device = new Device()
                {
                    DeviceId = (string)selected[0].Value,
                    DeviceName = (string)selected[1].Value,
                    DateEntry = (DateTime)selected[2].Value,
                    Price = (int)selected[3].Value,
                    Status = (string)selected[4].Value
                };

                UpdateDevice updateDevice = new UpdateDevice(device, this);
                updateDevice.Show();
            }
            else
            {
                var selected = dt.SelectedRows[0].Cells;

                TestDrive testDrive = new TestDrive()
                {
                    DriveId = (string)selected[0].Value,
                    ClientId = (string)selected[1].Value,
                    EmployeeId = (string)selected[2].Value,
                    BookDate = (DateTime)selected[3].Value,
                    Note = (string)selected[4].Value,
                    Status = (string)selected[5].Value
                };

                UpdateTestDrive updateTestDrive = new UpdateTestDrive(testDrive, this);
                updateTestDrive.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listType == ListType.EMPLOYEES)
            {
                var selected = dt.SelectedRows[0].Cells;

                Employee employee = new Employee()
                {
                    EmployeeId = selected[0].Value != DBNull.Value ? (string)selected[0].Value : "",
                    Firstname = selected[1].Value != DBNull.Value ? (string)selected[1].Value : "",
                    Lastname = selected[2].Value != DBNull.Value ? (string)selected[2].Value : "",
                    DateBirth = selected[3].Value != DBNull.Value ? (DateTime?)selected[3].Value : DateTime.Now,
                    Phone = selected[4].Value != DBNull.Value ? (string)selected[4].Value : "",
                    Gender = selected[5].Value != DBNull.Value ? (bool)selected[5].Value : true,
                    Cccd = selected[6].Value != DBNull.Value ? (string)selected[6].Value : "",
                    Position = selected[7].Value != DBNull.Value ? (string?)selected[7].Value : "",
                    StartDate = selected[8].Value != DBNull.Value ? (DateTime?)selected[8].Value : DateTime.Now,
                    Salary = selected[9].Value != DBNull.Value ? Convert.ToInt32(selected[9].Value) : 0,
                    Email = selected[10].Value != DBNull.Value ? (string)selected[10].Value : "",
                    Deleted = selected[11].Value != DBNull.Value ? (bool)selected[11].Value : false
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Employees WHERE EmployeeId = N'{employee.EmployeeId}'";
                    processDb.UpdateData(query);
                }
            }
            else if (listType == ListType.CUSTOMERS)
            {
                var selected = dt.SelectedRows[0].Cells;

                Customer customer = new Customer()
                {
                    ClientId = selected[0].Value != DBNull.Value ? (string)selected[0].Value : "",
                    Firstname = selected[1].Value != DBNull.Value ? (string)selected[1].Value : "",
                    Lastname = selected[2].Value != DBNull.Value ? (string)selected[2].Value : "",
                    DateBirth = selected[3].Value != DBNull.Value ? (DateTime)selected[3].Value : DateTime.Now,
                    Phone = selected[4].Value != DBNull.Value ? (string)selected[4].Value : "",
                    Gender = selected[5].Value != DBNull.Value ? (bool)selected[5].Value : true,
                    Cccd = selected[6].Value != DBNull.Value ? (string)selected[6].Value : "",
                    Email = selected[7].Value != DBNull.Value ? (string)selected[7].Value : "",
                    Address = selected[8].Value != DBNull.Value ? (string)selected[8].Value : "",
                    Deleted = selected[9].Value != DBNull.Value ? (bool?)selected[9].Value : false
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Customers WHERE ClientId = N'{customer.ClientId}'";
                    processDb.UpdateData(query);
                }
            }
            else if (listType == ListType.PRODUCTS)
            {
                var selected = dt.SelectedRows[0].Cells;

                Products products = new Products()
                {
                    Serial = selected[1].Value != DBNull.Value ? (string)selected[1].Value : "",
                    ProductName = selected[0].Value != DBNull.Value ? (string)selected[0].Value : "",
                    PurchasePrice = selected[2].Value != DBNull.Value ? (int)selected[2].Value : 0,
                    SalePrice = selected[3].Value != DBNull.Value ? (int)selected[3].Value : 0,
                    Quantity = selected[4].Value != DBNull.Value ? (int)selected[4].Value : 0,
                    Status = selected[5].Value != DBNull.Value ? (string)selected[5].Value : "",
                    Deleted = selected[6].Value != DBNull.Value ? (bool?)selected[6].Value : false,
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Products WHERE Serial = N'{products.Serial}'";
                    processDb.UpdateData(query);
                }
            }
            else if (listType == ListType.PURCHASEINVOICES)
            {
                var selected = dt.SelectedRows[0].Cells;

                PurchaseInvoice purchaseInvoice = new PurchaseInvoice()
                {
                    InEnterId = selected[0].Value != DBNull.Value ? (string)selected[0].Value : "",
                    SourceId = selected[1].Value != DBNull.Value ? (string)selected[1].Value : "",
                    ProductId = selected[2].Value != DBNull.Value ? (string)selected[2].Value : "",
                    EnteredDate = selected[3].Value != DBNull.Value ? (DateTime?)selected[3].Value : DateTime.Now,
                    QuantityPurchase = selected[4].Value != DBNull.Value ? (int)selected[4].Value : 0,
                    Status = selected[5].Value != DBNull.Value ? (string)selected[5].Value : "",
                    Deleted = selected[6].Value != DBNull.Value ? (bool)selected[6].Value : false
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM PurchaseInvoices WHERE InEnterId = N'{purchaseInvoice.InEnterId}'";
                    processDb.UpdateData(query);
                }
            }
            else if (listType == ListType.SALEINVOICES)
            {
                var selected = dt.SelectedRows[0].Cells;

                SalesInvoice salesInvoice = new SalesInvoice()
                {
                    InSaleId = selected[0].Value != DBNull.Value ? (string)selected[0].Value : "",
                    ClientId = selected[1].Value != DBNull.Value ? (string)selected[1].Value : "",
                    EmployeeId = selected[2].Value != System.DBNull.Value ? (string)selected[2].Value : "",
                    ProductId = selected[3].Value != DBNull.Value ? (string)selected[3].Value : "",
                    SaleDate = selected[4].Value != DBNull.Value ? (DateTime?)selected[4].Value : DateTime.Now,
                    QuantitySale = selected[5].Value != DBNull.Value ? (int)selected[5].Value : 0,
                    Status = selected[6].Value != DBNull.Value ? (string)selected[6].Value : "",
                    Deleted = selected[7].Value != DBNull.Value ? (bool)selected[7].Value : false,
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM SalesInvoices WHERE InSaleId = N'{salesInvoice.InSaleId}'";
                    processDb.UpdateData(query);
                }
            }
            else if (listType == ListType.SALESTARGETS)
            {
                var selected = dt.SelectedRows[0].Cells;

                SalesTarget salesTarget = new SalesTarget()
                {
                    SaleId = selected[0].Value != DBNull.Value ? (string)selected[0].Value : "",
                    EmployeeId = selected[1].Value != DBNull.Value ? selected[1].Value.ToString() : "",
                    StartDate = selected[2].Value != DBNull.Value ? (DateTime?)selected[2].Value : DateTime.Now,
                    EndDate = selected[3].Value != DBNull.Value ? (DateTime?)selected[3].Value : DateTime.Now,
                    Total = selected[4].Value != DBNull.Value ? (int)selected[4].Value : 0,
                    Target = selected[5].Value != DBNull.Value ? (int)selected[5].Value : 0,
                    Status = selected[6].Value != DBNull.Value ? (string)selected[6].Value : "",
                    Reward = selected[7].Value != DBNull.Value ? (double)selected[7].Value : 0,
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục tiêu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM SalesTargets WHERE SaleId = N'{salesTarget.SaleId}'";
                    processDb.UpdateData(query);
                }
            }
            else if (listType == ListType.SOURCE)
            {
                var selected = dt.SelectedRows[0].Cells;

                Source source = new Source()
                {
                    SourceId = (string)selected[0].Value,
                    Name = (string)selected[1].Value
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Source WHERE SourceId = N'{source.SourceId}'";
                    processDb.UpdateData(query);
                }
            }
            else if (listType == ListType.DEVICES)
            {
                var selected = dt.SelectedRows[0].Cells;

                Device device = new Device()
                {
                    DeviceId = (string)selected[0].Value,
                    DeviceName = (string)selected[1].Value,
                    DateEntry = (DateTime?)selected[2].Value,
                    Price = (int)selected[3].Value,
                    Status = (string)selected[4].Value
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Devices WHERE DeviceId = N'{device.DeviceId}'";
                    processDb.UpdateData(query);
                }
            }
            else
            {
                var selected = dt.SelectedRows[0].Cells;

                TestDrive testDrive = new TestDrive()
                {
                    DriveId = (string)selected[0].Value,
                    ClientId = (string)selected[1].Value,
                    EmployeeId = (string)selected[2].Value,
                    BookDate = (DateTime)selected[3].Value,
                    Note = (string)selected[4].Value,
                    Status = (string)selected[5].Value
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch lái thử này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM TestDrive WHERE DriveId = N'{testDrive.DriveId}'";
                    processDb.UpdateData(query);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 200);
                CenterToScreen();
            }
            else WindowState = FormWindowState.Maximized;
        }

        private void btnSmallForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
