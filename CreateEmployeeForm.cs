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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShowroomData
{
    public partial class CreateEmployeeForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private int temp = 0;

        // Constructor
        public CreateEmployeeForm(Form? _parent)
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
            comboBox1.Text = "--- Chọn ---";
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
        // [Handle Events]
        //
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CreateEmployeeForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            if (txtPhone.Text.Length >= 10 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            if (txtCCCD.Text.Length >= 12 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtLastname, txtFirstname, txtPhone };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới nhân viên này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text,
                lastName = txtLastname.Text.Trim(),
                firstName = txtFirstname.Text.Trim(),
                sdt = txtPhone.Text.Trim(),
                birth = birthDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                position = comboBox1.Text != "--- Chọn ---" ? comboBox1.Text : "",
                cccd = txtCCCD.Text.Trim(),
                gender = temp,
                email = txtEmail.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO Employees (EmployeeId, FirstName, LastName, DateBirth, PhoneNumber, Gender, CCCD, Position, StartDate, Salary, Email, Deleted) " +
                $"VALUES (N'{curr.id}',N'{curr.firstName}',N'{curr.lastName}','{curr.birth}', '{curr.sdt}', " +
                $"'{curr.gender}', N'{curr.cccd}',N'{curr.position}', '{curr.start}', 0, N'{curr.email}', 0)";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            txtId.Text = AutoCreateId();
        }


        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            if (rdbMale.Checked)
            {
                temp = 1;
            }
            else
            {
                temp = 0;
            }

            var curr = new
            {
                lastName = txtLastname.Text.Trim(),
                firstName = txtFirstname.Text.Trim(),
                sdt = txtPhone.Text.Trim(),
                position = comboBox1.Text != "--- Chọn ---" ? comboBox1.Text : "",
                cccd = txtCCCD.Text.Trim(),
                birthday = birthDateTimePicker.Value,
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                gender = temp,
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
            if (curr.position.Length <= 0)
            {
                MessageBox.Show("Bạn phải chọn vị trí");
                return false;
            }
            if (curr.cccd.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập số căn cước công dân");
                return false;
            }
            if (curr.email.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập email");
                return false;
            }
            if (curr.sdt.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại");
                return false;
            }

            DateTime currentDate = DateTime.Now;
            DateTime minimumBirthDate = currentDate.AddYears(-18);
            if (curr.birthday > minimumBirthDate)
            {
                MessageBox.Show("Bạn phải đủ 18 tuổi để tiếp tục.");
                return false;
            }

            return true;
        }
        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 EmployeeId From Employees Order By EmployeeId DESC");
            string? id = tb.Rows[0]["EmployeeId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(1, id.Length - 1));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "e" + id;
            }
            else
            {
                id = "E001";
            }
            return id;
        }

        private void CleanForm()
        {
            // Earse current data
            TextBox[] textBoxes = { txtLastname, txtFirstname, txtPhone, txtCCCD, txtEmail };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();

            comboBox1.Text = "--- Chọn ----";
            birthDateTimePicker.Value = DateTime.Now;
            rdbFemale.Checked = rdbMale.Checked = false;

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Bắt buộc chọn 1 vị trí\n" +
                "- Số điện thoại, CCCD, lương chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }
    }
}
