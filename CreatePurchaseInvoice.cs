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
    public partial class CreatePurchaseInvoice : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        public CreatePurchaseInvoice(Form? _parent)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //if (_parent != null && _parent.GetType() == typeof(Layout))
            //    parent = (Layout?)_parent;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;


            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        // Constructor

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
        // [Handle Events]
        //

        private void PurchaseInvoiceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 InEnterId From PurchaseInvoices Order By InEnterId DESC");
            string? id = tb.Rows[0]["InEnterId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(2, id.Length - 2));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "IE" + id;
            }
            else
            {
                id = "IE001";
            }
            return id;
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                idSuppliers = txtIdSuppliers.Text.Trim(),
                idProducts = txtIdProducts.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            if (curr.idSuppliers.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id nhà cung cấp");
                return false;
            }
            if (curr.idProducts.Length <= 0)
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
            // Earse current data
            TextBox[] textBoxes = { txtIdSuppliers, txtIdProducts, txtQuantity, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdInvoices.Text = AutoCreateId();
            dayDateTimePicker.Value = DateTime.Now;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            txtIdInvoices.Text = AutoCreateId();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới hóa đơn này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtIdInvoices.Text,
                idSuppliers = txtIdSuppliers.Text.Trim(),
                idProducts = txtIdProducts.Text.Trim(),
                day = dayDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO PurchaseInvoices (InEnterId, SourceId, ProductId, Date, QuantityPurchase, Status, Deleted) " +
                $"VALUES (N'{curr.id}',N'{curr.idSuppliers}',N'{curr.idProducts}','{curr.day}', " +
                $"N'{curr.quantity}',N'{curr.status}', 0)";

            // Excute the query
            processDb.UpdateData(query);

            // Update PurchasePrice for the product
            int purchasePrice = Convert.ToInt32(txtPurchasePrice.Text.Trim());
            query = $"UPDATE PRODUCTS SET PURCHASEPRICE = {purchasePrice}, SALEPRICE = {(int)(purchasePrice * 1.2)}" +
                $" WHERE SERIAL = N'{curr.id}'";
            processDb.UpdateData(query);

            MessageBox.Show("Tạo thành công", "Thông báo");

            // Earse current data
            CleanForm();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtIdSuppliers, txtIdProducts, txtQuantity, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdInvoices.Text = AutoCreateId();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Số lượng chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCreateSource_Click(object sender, EventArgs e)
        {
            CreateSource createSource = new CreateSource(this, isCreateOne: true);
            createSource.FormClosed += (f, args) =>
            {
                var query = processDb.GetData("SELECT TOP 1 SOURCEID FROM SOURCE ORDER BY SOURCEID DESC");
                if (query != null && query.Rows.Count > 0)
                    txtIdSuppliers.Text = query.Rows[0].Field<string>("SOURCEID");
            };
            createSource.ShowDialog();
        }

        private void txtIdSuppliers_TextChanged(object sender, EventArgs e)
        {
            if (txtIdSuppliers.Text.Trim().Length > 0)
            {
                var query = processDb.GetData($"SELECT NAME FROM SOURCE WHERE " +
                    $"SOURCEID = N'{txtIdSuppliers.Text.ToLower().Trim()}'");
                if (query != null
                    && query.Rows.Count > 0)
                {
                    lblSourceName.Text = query.Rows[0].Field<string>("NAME");
                    lblSourceName.ForeColor = Color.Green;
                    lblSourceName.Font = new Font(lblSourceName.Font, FontStyle.Bold);
                    lblSourceName.Visible = true;
                }
                else
                {
                    lblSourceName.Visible = true;
                    lblSourceName.Text = "Không tồn tại";
                    lblSourceName.Font = new Font(lblSourceName.Font, FontStyle.Regular);
                    lblSourceName.ForeColor = Color.Red;
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

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct(this, isCreateOne: true);
            createProduct.FormClosed += (f, args) =>
            {
                var query = processDb.GetData("SELECT TOP 1 SERIAL FROM PRODUCTS ORDER BY SERIAL DESC");
                if (query != null && query.Rows.Count > 0)
                    txtIdProducts.Text = query.Rows[0].Field<string>("SERIAL");
            };
            createProduct.ShowDialog();
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
