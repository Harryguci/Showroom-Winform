using ShowroomData.ComponentGUI;
using System.Data;

namespace ShowroomData
{
    public partial class CreateCustomer : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private int temp = 0;

        private bool isCreateOne = false;

        public CreateCustomer(Form? _parent, bool isCreateOne = false)
        {
            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;
            this.isCreateOne = isCreateOne;

            InitializeComponent();
            HandleGUI();
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

        private void HandleGUI()
        {
            FormBorderStyle = FormBorderStyle.None;
            //
            // Add textbox setting
            //
            Padding p = new Padding(5);
            RoundTextBox.SetPadding(txtId, p);
            RoundTextBox.SetPadding(txtPhone, p);
            RoundTextBox.SetPadding(txtCCCD, p);
            RoundTextBox.SetPadding(txtEmail, p);
            RoundTextBox.SetPadding(txtAddress, p);
            RoundTextBox.SetPadding(txtFirstname, p);
            RoundTextBox.SetPadding(txtLastname, p);
            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //
        // [Handle Events]
        //

        private void Customer_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }


        //
        // [Helper Methods]
        //

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

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
                cccd = txtCCCD.Text.Trim(),
                address = txtAddress.Text.Trim(),
                phone = txtPhone.Text.Trim(),
                gender = temp,
                email = txtEmail.Text.Trim()
            };


            if (curr.firstName.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (curr.lastName.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập họ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (curr.cccd.Length < 9 || curr.cccd.Length > 12)
            {
                MessageBox.Show("Số căn cước công dân không hợp lệ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (curr.email.Length > 0 && !IsValidEmail(curr.email))
            {
                MessageBox.Show("Địa chỉ Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (curr.phone.Length <= 0 || curr.phone.Length > 10)
            {
                MessageBox.Show("SĐT không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 ClientId From Customers Order By ClientId DESC");
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
        private void CleanForm()
        {
            // Earse current data
            TextBox[] textBoxes = { txtLastname, txtFirstname, txtPhone, txtEmail, txtAddress, txtCCCD };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();

            birthDateTimePicker.Value = DateTime.Now;
            rdbFemale.Checked = rdbMale.Checked = false;
        }

        private void Customer_Load_1(object sender, EventArgs e)
            => txtId.Text = AutoCreateId();

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }

            if (txtPhone.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

            if (MessageBox.Show("Tạo mới khách hàng này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text,
                lastName = txtLastname.Text.Trim(),
                firstName = txtFirstname.Text.Trim(),
                birth = birthDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                cccd = txtPhone.Text.Trim(),
                email = txtEmail.Text.Trim(),
                phone = txtPhone.Text.Trim(),
                gender = temp,
                address = txtAddress.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO Customers (ClientId, FirstName, LastName, DateBirth, PhoneNumber, Gender, CCCD, Email, Address, Deleted) " +
                $"VALUES (N'{curr.id}', N'{curr.firstName}', N'{curr.lastName}', N'{curr.birth}', N'{curr.phone}', " +
                $"'{curr.gender}', N'{curr.cccd}', N'{curr.email}', N'{curr.address}', 0)";

            // Excute the query
            processDb.UpdateData(query);

            // Inform
            MessageBox.Show("Tạo thành công", "Thông báo");

            // Earse current data
            CleanForm();

            if (isCreateOne) Close();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();

        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtLastname, txtFirstname, txtPhone, txtAddress, txtEmail, txtCCCD };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Số điện thoại, CCCD chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
              MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }
    }
}
