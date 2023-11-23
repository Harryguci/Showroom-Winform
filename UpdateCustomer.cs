using ShowroomData.Models;
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
    public partial class UpdateCustomer : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        // Constructor
        public UpdateCustomer(Customer customer, Form? _parent)
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
            // Fill the data of the customer which you want to change info.
            //
            txtId.Text = customer.ClientId;
            txtFirstname.Text = customer.Firstname;
            txtLastname.Text = customer.Lastname;
            txtCCCD.Text = customer.Cccd;
            birthDateTimePicker.Value = customer.DateBirth != null ? customer.DateBirth.Value : DateTime.Now;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            if (customer.Gender == true)
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UpdateCustomerForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                lastName = txtLastname.Text.Trim(),
                firstName = txtFirstname.Text.Trim(),
                cccd = txtCCCD.Text.Trim(),
                address = txtAddress.Text.Trim(),
                email = txtEmail.Text.Trim()
            };


            if (curr.firstName.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên");
                return false;
            }
            if (curr.lastName.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập họ");
                return false;
            }
            if (curr.cccd.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập căn cước công dân");
                return false;
            }
            if (curr.address.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ");
                return false;
            }
            if (curr.email.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập email");
                return false;
            }

            return true;
        }
        private void CleanForm()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }

            if (txtCCCD.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật khách hàng này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int temp = 0;
            if (rdbFemale.Checked == true)
            {
                temp = 1;
            }
            else
            {
                temp = 0;
            }

            var curr = new
            {
                id = txtId.Text.Trim(),
                lastName = txtLastname.Text.Trim(),
                firstName = txtFirstname.Text.Trim(),
                birth = birthDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                cccd = txtCCCD.Text.Trim(),
                address = txtAddress.Text.Trim(),
                gender = temp,
                email = txtEmail.Text.Trim()
            };

            // Handle Create
            string query = $"UPDATE Customers SET FirstName = N'{curr.firstName}'," +
                $" LastName = N'{curr.lastName}', DateBirth = '{curr.birth}', Gender = {curr.gender}," +
                $" CCCD = N'{curr.cccd}', Email = N'{curr.email}', Address = N'{curr.address}'," +
                $" Deleted = 0 WHERE ClientId = N'{curr.id}'";
            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            Dispose();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- CCCD chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?.\nDữ liệu chưa lưu sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes) Close();
        }
    }
}
