using ShowroomData.ComponentGUI;
using ShowroomData.Models;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class UpdateInfoForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private ListForm? _parent;
        private bool _isUpdating = false;
        private Employee _currEmployee;
        // Constructor
        public UpdateInfoForm(Employee employee, Form? parent)
        {
            InitializeComponent();
            _currEmployee = employee;
            FormBorderStyle = FormBorderStyle.None;
            if (parent != null && parent.GetType() == typeof(ListForm))
                this._parent = (ListForm)parent;
            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            cbPosition.Text = "--- Chọn ---";

            //
            // Fill the data of the employee which you want to change info.
            //
            bool temp = employee.Gender != null && employee.Gender.Value;
            txtId.Text = employee.EmployeeId;
            txtLastName.Text = employee.Lastname;
            txtFirstName.Text = employee.Firstname;
            txtPhone.Text = employee.Phone;
            txtCCCD.Text = employee.Cccd;
            txtPhone.Text = employee.Phone;
            txtSalary.Text = employee.Salary.ToString();

            birthDateTimePicker.Value = employee.DateBirth != null ? employee.DateBirth.Value : DateTime.Now;
            txtEmail.Text = employee.Email;
            cbPosition.Text = employee.Position;
            if (employee.Url_image != null && File.Exists(Path.Combine(Directory.GetCurrentDirectory(), employee.Url_image)))
                pictureBoxAvatar.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), employee.Url_image);

            if (employee.Gender == true)
                rdbMale.Checked = true;
            else rdbFemale.Checked = true;

            txtId.TextChanged += textBox_textChanged;
            txtFirstName.TextChanged += textBox_textChanged;
            txtLastName.TextChanged += textBox_textChanged;
            txtPhone.TextChanged += textBox_textChanged;
            txtCCCD.TextChanged += textBox_textChanged;
            txtSalary.TextChanged += textBox_textChanged;
            txtEmail.TextChanged += textBox_textChanged;
            birthDateTimePicker.TextChanged += textBox_textChanged;
            cbPosition.TextChanged += textBox_textChanged;
            rdbFemale.CheckedChanged += (rdb, args) => _isUpdating = true;
            rdbMale.CheckedChanged += (rdb, args) => _isUpdating = true;
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
            if (!_isUpdating || MessageBox.Show("Bạn có muốn thoát?.\nDữ liệu chưa lưu sẽ bị xóa?",
                "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes) Close();
        }

        private void CreateEmployeeForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void textBox_textChanged(object? sender, EventArgs e)
        {
            _isUpdating = true;
        }

        private void txtCCCD_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }

            if (txtCCCD.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // TODO: reset values
            bool temp = _currEmployee.Gender != null && _currEmployee.Gender.Value;
            txtId.Text = _currEmployee.EmployeeId;
            txtLastName.Text = _currEmployee.Lastname;
            txtFirstName.Text = _currEmployee.Firstname;
            txtPhone.Text = _currEmployee.Phone;
            txtCCCD.Text = _currEmployee.Cccd;
            txtPhone.Text = _currEmployee.Phone;
            txtSalary.Text = _currEmployee.Salary.ToString();
            birthDateTimePicker.Value = _currEmployee.DateBirth != null ?
                _currEmployee.DateBirth.Value : DateTime.Now;
            txtEmail.Text = _currEmployee.Email;
            cbPosition.Text = _currEmployee.Position;

            if (_currEmployee.Gender == true)
                rdbMale.Checked = true;
            else rdbFemale.Checked = true;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật thông tin nhân viên này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var curr = new
            {
                id = txtId.Text.Trim(),
                firstName = txtFirstName.Text.Trim(),
                lastName = txtLastName.Text.Trim(),
                birth = birthDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                phone = txtPhone.Text.Trim(),
                position = cbPosition.Text != "--- Chọn ---" ? cbPosition.Text : "",
                cccd = txtCCCD.Text.Trim(),
                email = txtEmail.Text.Trim(),
                salary = txtSalary.Text.Trim(),
                gender = (rdbMale.Checked ? 1 : 0),
                url_image = "images//uploaded//" + Path.GetFileName(pictureBoxAvatar.ImageLocation)
            };

            string query = $"UPDATE Employees ";
            query += $"SET FirstName = N'{curr.firstName}',";
            query += $"LastName = N'{curr.lastName}',";
            query += $"DateBirth = '{curr.birth}',";
            query += $"PhoneNumber = '{curr.phone}',";
            query += $"Gender = '{curr.gender}',";
            query += $"CCCD = '{curr.cccd}',";
            query += $"Position = N'{curr.position}',";
            query += $"StartDate = '{curr.start}',";
            query += $"Email = '{curr.email}',";
            query += $"Deleted = 0,";
            query += $"Salary = {curr.salary},";
            query += $"Url_image = '{curr.url_image}'";
            query += $" WHERE EmployeeId = N'{curr.id}'";

            // Excute the query
            processDb.UpdateData(query);

            MessageBox.Show("Cập nhật thành công",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (File.Exists(pictureBoxAvatar.ImageLocation))
            {
                // Copy the file to the folder
                string folderPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "images/uploaded/");
                Image image = Image.FromFile(pictureBoxAvatar.ImageLocation);
                File.Copy(pictureBoxAvatar.ImageLocation, folderPath + Path.GetFileName(pictureBoxAvatar.ImageLocation), true);
            }

            // Earse current data
            CleanForm();
            Dispose();
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            // ToDo
            Padding p = new Padding(5, 5, 2, 2);

            txtId.Multiline = txtLastName.Multiline = txtFirstName.Multiline = txtPhone.Multiline
                = txtCCCD.Multiline = txtEmail.Multiline = txtSalary.Multiline = true;

            RoundTextBox.SetPadding(txtId, p);
            RoundTextBox.SetPadding(txtFirstName, p);
            RoundTextBox.SetPadding(txtLastName, p);
            RoundTextBox.SetPadding(txtEmail, p);
            RoundTextBox.SetPadding(txtPhone, p);
            RoundTextBox.SetPadding(txtCCCD, p);
            RoundTextBox.SetPadding(txtSalary, p);
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                id = txtId.Text,
                lastName = txtLastName.Text.Trim(),
                firstName = txtFirstName.Text.Trim(),
                sdt = txtPhone.Text.Trim(),
                birth = birthDateTimePicker.Value,
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                salary = Convert.ToInt32(txtSalary.Text.Trim()),
                position = cbPosition.Text != "--- Chọn ---" ? cbPosition.Text : "",
                cccd = txtCCCD.Text.Trim(),
                email = txtEmail.Text.Trim(),
                gender = (rdbMale.Checked ? 1 : 0)
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
            if (!rdbMale.Checked && !rdbFemale.Checked)
            {
                MessageBox.Show("Bạn phải chọn giới tính");
                return false;
            }
            if (curr.sdt.Max() > '9' || curr.sdt.Min() < '0')
            {
                MessageBox.Show("SĐT chỉ bao gồm các chữ số");
                return false;
            }

            DateTime currentDate = DateTime.Now;
            DateTime minimumBirthDate = currentDate.AddYears(-18);
            if (curr.birth > minimumBirthDate)
            {
                MessageBox.Show("Bạn phải đủ 18 tuổi để tiếp tục.");
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
            if (!_isUpdating || MessageBox.Show("Bạn có muốn thoát?.\nDữ liệu chưa lưu sẽ bị xóa?",
                "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes) Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnChangeAvt_Click(object sender, EventArgs e)
        {
            // Use the open file dialog to let the user select an image file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog1.Title = "Select an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the file name and the folder path
                string fileName = openFileDialog1.FileName;
                string folderPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "/images/uploaded/");

                // Check if the file exists
                if (File.Exists(fileName))
                {
                    // Check if the folder exists, if not, create it
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    // Copy the file to the folder
                    // File.Copy(fileName, folderPath + Path.GetFileName(fileName), true);
                    // Try to load the image from the file
                    try
                    {
                        Image image = Image.FromFile(fileName);
                        // Dispose the previous image if it exists
                        if (pictureBoxAvatar.Image != null)
                        {
                            pictureBoxAvatar.Image.Dispose();
                        }
                        // Assign the image to the picture box
                        pictureBoxAvatar.Image = image;
                        pictureBoxAvatar.ImageLocation = fileName;
                        btnChangeAvt.Text = "Đổi ảnh";
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Show a message if the file does not exist
                    MessageBox.Show("The file does not exist.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreateTargetSale_Click(object sender, EventArgs e)
        {

        }
    }

}
