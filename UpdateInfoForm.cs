using ShowroomData.Models;
using System.Data;

namespace ShowroomData
{
    public partial class UpdateInfoForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        // Constructor
        public UpdateInfoForm(Employee employee, Form? _parent)
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
            cbPosition.Text = "--- Chọn ---";

            //
            // Fill the data of the employee which you want to change info.
            //
            txtId.Text = employee.EmployeeId;
            txtFirstname.Text = employee.Firstname;
            txtLastname.Text = employee.Lastname;
            txtCCCD.Text = employee.Cccd;
            txtSalary.Text = employee.Salary.ToString();
            birthDateTimePicker.Value = employee.DateBirth != null ? employee.DateBirth.Value : DateTime.Now;
            txtEmail.Text = employee.Email;
            cbPosition.Text = employee.Position;
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
            // TODO: reset values
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
                position = cbPosition.Text != "--- Chọn ---" ? cbPosition.Text : "",
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
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            // ToDo
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
                sdt = txtPhone.Text.Trim(),
                position = cbPosition.Text != "--- Chọn ---" ? cbPosition.Text : "",
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
        private void CleanForm()
        {
            // // Earse current data
            // System.Windows.Forms.TextBox[] textBoxes = { txtLastname, txtFirstname, txtPhone, txtCCCD, txtEmail, txtSalary };
            // for (int i = 0; i < textBoxes.Length; i++)
            //     textBoxes[i].Text = string.Empty;

            //// txtId.Text = AutoCreateId();

            // cbPosition.Text = "--- Chọn ----";
            // birthDateTimePicker.Value = DateTime.Now;
            // rdbFemale.Checked = rdbMale.Checked = false;

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập họ, tên\n" +
                "- Bắt buộc chọn 1 vị trí\n" +
                "- Số điện thoại, CCCD, lương chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?.\nDữ liệu chưa lưu sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes) Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
