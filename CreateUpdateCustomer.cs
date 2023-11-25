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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.IdentityModel.Tokens;
using ShowroomData.Models;

namespace ShowroomData
{
    public partial class CreateUpdateCustomer : Form
    {
        private Form? _parent;
        private ProcessDatabase _processDatabase = new ProcessDatabase();
        public CreateUpdateCustomer(ListForm? parent = null, string? title = "Tạo Khách hàng", Customer? customer = null)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            lblHeadingPage.Text = title;

            _parent = parent;

            if (customer == null)
                txtId.Text = AutoCreateId();
            else
            {
                txtId.Text = customer.ClientId;
                txtFirstName.Text = customer.Firstname;
                txtLastName.Text = customer.Lastname;
                txtPhoneNumber.Text = customer.PhoneNumber;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtCccd.Text = customer.Cccd;
                dtpBirth.Value = customer.DateBirth;

                if (customer.Gender != null && customer.Gender.Value) radioButton1.Checked = true;
                else radioButton2.Checked = true;
            }
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

        private void panelContent_Resize(object sender, EventArgs e)
        {
            panel3.Location = new Point((panelContent.Width - panel3.Width) / 2, (panelContent.Height - panel3.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát? Dữ liệu chưa lưu sẽ bị xóa",
                "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private bool ValidateForm()
        {
            var curr = new
            {
                Id = txtId.Text,
                LastName = txtLastName.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Gender = (radioButton1.Checked ? true : false),
            };

            if (curr.Id.IsNullOrEmpty())
            {
                MessageBox.Show("ID không thể để trống", "Lỗi");
                return false;
            }
            if (curr.LastName.IsNullOrEmpty()
                || curr.FirstName.IsNullOrEmpty())
            {
                MessageBox.Show("Họ và tên không thể để trống", "Lỗi");
                return false;
            }
            if (curr.PhoneNumber.Max() > '9' || curr.PhoneNumber.Min() < '0')
            {
                MessageBox.Show("SĐT chỉ bao gồm các chữ số", "Lỗi");
                return false;
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Lỗi");
                return false;
            }
            return true;
        }

        private bool IsExist()
        {
            string id = txtId.Text.Trim();

            var response = _processDatabase.GetData($"SELECT TOP 1 ClientId FROM Customers WHERE ClientId = '{id}'");

            return response.Rows.Count > 0;
        }
        private string AutoCreateId()
        {
            DataTable tb = _processDatabase.GetData("Select Top 1 ClientId From Customers Order By ClientId DESC");
            string? id = tb.Rows[0]["ClientId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(1, id.Length - 1));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "C" + id;
            }
            else
            {
                id = "C001";
            }
            return id;
        }

        private void HandleSaveChange_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới nhân viên này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                Id = txtId.Text,
                LastName = txtLastName.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Cccd = txtCccd.Text.Trim(),
                Gender = (radioButton1.Checked ? true : false),
                DateBirth = dtpBirth.Value.ToString("yyyy-MM-dd"),
            };

            // Check If exist:
            if (IsExist())
            {
                if (MessageBox.Show($"Bạn có muốn cập nhật thông tin khách hàng {curr.Id}",
                    "Thông báo",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                var query = $"UPDATE Customers SET FirstName = N'{curr.FirstName}', LastName = N'{curr.LastName}', PhoneNumber = '{curr.PhoneNumber}', Gender = '{(curr.Gender ? 1 : 0)}', CCCD  = '{curr.Cccd}', Email='{curr.Email}', Address=N'{curr.Address}', DateBirth={curr.DateBirth}" +
                    $" Where Customers.ClientId = '{curr.Id}'";

                _processDatabase.UpdateData(query);
            }
            else
            {
                // handle create
                var query = $"Insert Into Customers (\"ClientId\", \"FirstName\", \"LastName\", \"DateBirth\", \"PhoneNumber\", \"Gender\", \"CCCD\", \"Email\", \"Address\", \"Deleted\") " +
                    $"Values ('{curr.Id}', N'{curr.FirstName}', N'{curr.LastName}', '{curr.DateBirth}', '{curr.PhoneNumber}', {(curr.Gender ? 1 : 0)}, '{curr.Cccd}', '{curr.Email}', N'{curr.Address}', 0)";

                // Excute the query
                _processDatabase.UpdateData(query);
            }

            // Earse current data
            // CleanForm();

            // Refresh Data
            //if (parent == null) return;
            //parent.RefeshData();
            //parent.Refresh();
        }
    }
}
