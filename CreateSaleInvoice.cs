using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShowroomData
{
    public partial class CreateSaleInvoice : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        public CreateSaleInvoice(Form? _parent)
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

        private void SaleInvoiceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 InSaleId From SalesInvoices Order By InSaleId DESC");
            string? id = tb.Rows[0]["InSaleId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(2, id.Length - 2));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "IS" + id;
            }
            else
            {
                id = "IS001";
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
                idClients = txtIdClients.Text.Trim(),
                idEmployee = txtIdEmployee.Text.Trim(),
                idProducts = txtIdProducts.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            if (curr.idClients.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id khách hàng");
                return false;
            }
            if (curr.idEmployee.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id nhân viên");
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
            if (curr.quantity.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập trạng thái");
                return false;
            }

            return true;
        }

        private void CleanForm()
        {
            // Earse current data
            TextBox[] textBoxes = { txtIdClients, txtIdEmployee, txtIdProducts, txtQuantity, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdInvoices.Text = AutoCreateId();
            dayDateTimePicker.Value = DateTime.Now;
        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {
            txtIdInvoices.Text = AutoCreateId();
        }

        private void txtQuantity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Số lượng chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới hóa đơn này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtIdInvoices.Text,
                idClients = txtIdClients.Text.Trim(),
                idEmployee = txtIdEmployee.Text.Trim(),
                idProducts = txtIdProducts.Text.Trim(),
                day = dayDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO SalesInvoices (InSaleId, ClientId, EmployeeId, ProductId, Date, QuantitySale, Status, Deleted) " +
                $"VALUES (N'{curr.id}',N'{curr.idClients}',N'{curr.idEmployee}',N'{curr.idProducts}','{curr.day}', " +
                $"N'{curr.quantity}',N'{curr.status}', 0)";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtIdClients, txtIdEmployee, txtIdProducts, txtQuantity, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdInvoices.Text = AutoCreateId();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
