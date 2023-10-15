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

        // Constructor
        public CreateEmployeeForm(Form? _parent)
        {
            InitializeComponent();

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout?)_parent;

            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            comboBox1.Text = "--- Chọn ---";
        }

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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
                salary = Convert.ToInt32(txtSalary.Text.Trim()),
                position = comboBox1.Text != "--- Chọn ---" ? comboBox1.Text : "",
                cccd = txtCCCD.Text.Trim(),
                email = txtEmail.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO Employees (EmployeeId, FirstName, LastName, DateBirth, CCCD, Position, StartDate, Salary, Email, SaleId) " +
                $"VALUES (N'{curr.id}',N'{curr.firstName}',N'{curr.lastName}','{curr.birth}', " +
                $"N'{curr.cccd}',N'{curr.position}','{curr.start}',{curr.salary}, N'{curr.email}', NULL)";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            // Update the data grid view in The list Form
            if (parent != null)
                parent.RefeshData();
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
            => txtId.Text = AutoCreateId();

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                lastName = txtLastname.Text.Trim(),
                firstName = txtFirstname.Text.Trim(),
                sdt = txtPhone.Text.Trim(),
                position = comboBox1.Text != "--- Chọn ---" ? comboBox1.Text : "",
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
            TextBox[] textBoxes = { txtLastname, txtFirstname, txtPhone, txtCCCD, txtEmail, txtSalary };
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
                "- Bắt buộc nhập họ, tên\n" +
                "- Bắt buộc chọn 1 vị trí\n" +
                "- Số điện thoại, CCCD, lương chỉ có thể nhập số");

            helperDialog.Show();
        }
    }
}
