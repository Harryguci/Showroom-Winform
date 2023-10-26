using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShowroomData
{
    public partial class Layout3 : Form
    {

        ProcessDatabase processDatabase = new ProcessDatabase();
        private List<string> EmployeeId = new List<string>();
        public Layout3()
        {
            InitializeComponent();
            LoadCombobox();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
            Layout2 layout2 = new Layout2();
            layout2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfpassword.Text;
            string id = EmployeeId[cbId.SelectedIndex];

            Debug.WriteLine("\n\n " + id);
            // Kiểm tra xem liệu Username, Password và ConfirmPassword có rỗng hay không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password.Contains(" ") || confirmPassword.Contains(" ") || username.Contains(" "))
            {
                MessageBox.Show("Không được nhập khoảng trắng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /// Kiem tra tai khoan ton tai chua :
            if (CheckExist(username, password))
            {
                InsertAccount(id, username, password);
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadCombobox()
        {
            List<string> employeeCombo = new List<string>();
            //employeeCombo.Add(string.Empty);
            DataTable employees = new DataTable();
            employees = GetEmployeeID();
            foreach (DataRow row in employees.Rows)
            {
                string employeeid = row["EmployeeId"].ToString();
                EmployeeId.Add(employeeid);
                string name = row["HovaTen"].ToString();
                string combinedName = employeeid + " -- " + name;
                employeeCombo.Add(combinedName);
            }
            cbId.DataSource = employeeCombo;
        }
        private bool CheckExist(string username, string password)
        {

            //string query = "SELECT * FROM Login_check('" + username + "','" + password + "')";
            string query = "SELECT * FROM Login_check('" + username + "','" + password + "')";
            DataTable dt = new DataTable();
            try
            {
                dt = processDatabase.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Gặp lỗi" + e.Message + "!!!", "Thông báo lỗi", MessageBoxButtons.OK);
                throw;
            }
            return true;
        }
        private void InsertAccount(string id, string username, string password)
        {
            string query = "INSERT INTO Account (EmployeeId, Username, Password_foruser, Deleted, CreateAt, DeleteAt) VALUES" +
                 " ('" + id + "', '" + username + "', CONVERT(VARBINARY(500), '" + password + "'), 0, GETDATE(), NULL)";
            try
            {
                processDatabase.UpdateData(query);
                MessageBox.Show("Tài khoản tạo cho nhân viên : " + id + "\nusername : " + username + "\npassword : " + password, "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private DataTable GetEmployeeID()
        {
            DataTable dt = new DataTable();
            string query = "select EmployeeId,FirstName + ' ' + LastName as HovaTen\r\nfrom Employees";
            try
            {
                dt = processDatabase.GetData(query);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtConfpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
