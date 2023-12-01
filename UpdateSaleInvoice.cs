using ShowroomData.Models;
using System.Data;

namespace ShowroomData
{
    public partial class UpdateSaleInvoice : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private bool isInfoChanged = false;

        public UpdateSaleInvoice(SalesInvoice salesInvoice, Form? _parent)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;

            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            //
            // Fill the data of the product which you want to change info.
            //
            txtIdInvoices.Text = salesInvoice.InSaleId;
            txtIdClients.Text = salesInvoice.ClientId;
            txtIdEmployee.Text = salesInvoice.EmployeeId;
            txtIdProducts.Text = salesInvoice.ProductId;
            dayDateTimePicker.Value = salesInvoice.SaleDate != null ? salesInvoice.SaleDate.Value : DateTime.Now;
            txtQuantity.Text = salesInvoice.QuantitySale.ToString();
            txtStatus.Text = salesInvoice.Status;

            // Added Event handle change the information.
            txtIdClients.TextChanged += InfoChanged;
            txtIdEmployee.TextChanged += InfoChanged;
            txtIdProducts.TextChanged += InfoChanged;
            txtQuantity.TextChanged += InfoChanged;
            txtStatus.TextChanged += InfoChanged;
            dayDateTimePicker.TextChanged += InfoChanged;
        }

        private void InfoChanged(object? sender, EventArgs e)
        {
            isInfoChanged = true;
        }

        #region HANDLE FORM DRAGGING

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
        // [Handle Events]
        //
        private void UpdateSaleInvoiceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void UpdateSaleInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật hóa đơn này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtIdInvoices.Text.Trim(),
                idCustomer = txtIdClients.Text.Trim(),
                idEmployee = txtIdEmployee.Text.Trim(),
                idProduct = txtIdProducts.Text.Trim(),
                day = dayDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            var isEmployeeExist = processDb.GetData($"SELECT EMPLOYEEID FROM EMPLOYEES WHERE EMPLOYEEID = N'{curr.idEmployee}'").Rows.Count > 0 ? true : false;
            if (!isEmployeeExist)
            {
                MessageBox.Show("Không tìm thấy nhân viên này", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $" UPDATE SalesInvoices SET ClientId = N'{curr.idCustomer}', EmployeeId = N'{curr.idEmployee}', " +
                $" ProductId = N'{curr.idProduct}', Date = N'{curr.day}', QuantitySale = N'{curr.quantity}', " +
                $" Status = N'{curr.status}', Deleted = 0 WHERE InSaleId = N'{curr.id}' ";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            if (!isInfoChanged || MessageBox.Show("Bạn có chắc muốn thoát?\nThông tin không lưu sẽ bị xóa.", 
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Số lượng chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isInfoChanged || MessageBox.Show("Bạn có chắc muốn thoát?\nThông tin không lưu sẽ bị xóa.",
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                idCustomer = txtIdClients.Text.Trim(),
                idSale = txtIdEmployee.Text.Trim(),
                idProduct = txtIdProducts.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };


            if (curr.idCustomer.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id khách hàng");
                return false;
            }
            if (curr.idProduct.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id sản phẩm");
                return false;
            }
            if (curr.quantity.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng");
                return false;
            }
            if (curr.status.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập trạng thái");
                return false;
            }

            return true;
        }

        private void CleanForm()
        {
            isInfoChanged = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txtIdEmployee.Text.Trim().Length > 0)
            {
                var query = processDb.GetData($"SELECT FIRSTNAME, LASTNAME FROM EMPLOYEES WHERE " +
                    $"EMPLOYEEID = N'{txtIdEmployee.Text.ToLower().Trim()}'");
                if (query != null
                    && query.Rows.Count > 0)
                {
                    lblFullnameEmployee.Text = query.Rows[0].Field<string>("LASTNAME") + " " + query.Rows[0].Field<string>("FIRSTNAME");
                    lblFullnameEmployee.ForeColor = Color.Green;
                    lblFullnameEmployee.Font = new Font(lblFullnameEmployee.Font, FontStyle.Bold);
                    lblFullnameEmployee.Visible = true;
                }
                else
                {
                    lblFullnameEmployee.Visible = true;
                    lblFullnameEmployee.Text = "Không tồn tại";
                    lblFullnameEmployee.Font = new Font(lblFullnameEmployee.Font, FontStyle.Regular);
                    lblFullnameEmployee.ForeColor = Color.Red;
                }
            }
        }

        private void txtIdProducts_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProducts.Text.Trim().Length > 0)
            {
                var query = processDb.GetData($"SELECT PRODUCTNAME FROM PRODUCTS WHERE " +
                    $"SERIAL = N'{txtIdProducts.Text.ToLower().Trim()}'");
                if (query != null
                    && query.Rows.Count > 0)
                {
                    lblProductName.Text = query.Rows[0].Field<string>("PRODUCTNAME");
                    lblProductName.ForeColor = Color.Green;
                    lblProductName.Font = new Font(lblProductName.Font, FontStyle.Bold);
                    lblProductName.Visible = true;
                }
                else
                {
                    lblProductName.Visible = true;
                    lblProductName.Text = "Không tồn tại";
                    lblProductName.Font = new Font(lblProductName.Font, FontStyle.Regular);
                    lblProductName.ForeColor = Color.Red;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm createForm = new CreateEmployeeForm(this);
            createForm.FormClosed += (f, args) =>
            {
                var query = processDb.GetData($"SELECT TOP 1 EMPLOYEEID FROM EMPLOYEES ORDER BY EMPLOYEEID DESC");
                try
                {
                    txtIdEmployee.Text = query.Rows[0].Field<string>("EMPLOYEEID");
                }
                catch {; }
            };

            createForm.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchAll searchAll = new SearchAll();
            searchAll.filter = "employee";
            searchAll.CanNavigate = false;
            searchAll.FormClosing += (f, args) =>
            {
                if (f != null && f.GetType() == typeof(SearchAll))
                    txtIdEmployee.Text = ((SearchAll)f).IdValue;
            };
            searchAll.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchAll searchAll = new SearchAll();
            searchAll.filter = "product";
            searchAll.CanNavigate = false;
            searchAll.FormClosing += (f, args) =>
            {
                if (f != null && f.GetType() == typeof(SearchAll))
                    txtIdProducts.Text = ((SearchAll)f).IdValue;
            };
            searchAll.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct(this, true);
            createProduct.FormClosed += CreateProduct_FormClosed;

            createProduct.ShowDialog(this);
        }

        private void CreateProduct_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var query = processDb.GetData("SELECT TOP 1 SERIAL FROM PRODUCTS ORDER BY SERIAL DESC");

            if (query != null && query.Rows.Count > 0)
            {
                txtIdProducts.Text = query.Rows[0].Field<string>("SERIAL");
            }
        }

        private void txtIdClients_TextChanged(object sender, EventArgs e)
        {
            if (txtIdClients.Text.Trim().Length > 0)
            {
                var query = processDb.GetData($"SELECT FIRSTNAME, LASTNAME FROM Customers WHERE " +
                    $"CLIENTID = N'{txtIdClients.Text.ToLower().Trim()}'");
                if (query != null
                    && query.Rows.Count > 0)
                {
                    lblCustomerName.Text = query.Rows[0].Field<string>("LASTNAME") + " " + query.Rows[0].Field<string>("FIRSTNAME");
                    lblCustomerName.ForeColor = Color.Green;
                    lblCustomerName.Font = new Font(lblCustomerName.Font, FontStyle.Bold);
                    lblCustomerName.Visible = true;
                }
                else
                {
                    lblCustomerName.Visible = true;
                    lblCustomerName.Text = "Không tồn tại";
                    lblCustomerName.Font = new Font(lblCustomerName.Font, FontStyle.Regular);
                    lblCustomerName.ForeColor = Color.Red;
                }
            }
        }
    }
}
