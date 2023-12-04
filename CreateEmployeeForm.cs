using System.Data;

namespace ShowroomData
{
    public partial class CreateEmployeeForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private int temp = 0;
        private bool isCreateOne = false;
        private bool isChanged = false;
        // Constructor
        public CreateEmployeeForm(Form? _parent, bool isCreateOne = false)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //if (_parent != null && _parent.GetType() == typeof(Layout))
            //    parent = (Layout?)_parent;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;

            txtFirstname.TextChanged += TextBox_Changed;
            txtLastname.TextChanged += TextBox_Changed;
            txtCCCD.TextChanged += TextBox_Changed;
            txtEmail.TextChanged += TextBox_Changed;
            txtPhone.TextChanged += TextBox_Changed;
            cboPosition.TextChanged += TextBox_Changed;
            rdbFemale.CheckedChanged += TextBox_Changed;
            rdbMale.CheckedChanged += TextBox_Changed;
            birthDateTimePicker.ValueChanged += TextBox_Changed;
            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            cboPosition.Text = "--- Chọn ---";
            this.isCreateOne = isCreateOne;
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
        private void TextBox_Changed(object? sender, EventArgs e)
        {
            isChanged = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!isChanged || MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            Close();
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
                phonenumber = txtPhone.Text.Trim(),
                birth = birthDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                position = cboPosition.Text != "--- Chọn ---" ? cboPosition.Text : "",
                cccd = txtCCCD.Text.Trim(),
                email = txtEmail.Text.Trim(),
                salary = 0,
                gender = rdbMale.Checked ? 1 : 0,
                Url_image = "images//uploaded//" + Path.GetFileName(pictureBoxAvatar.ImageLocation)
            };

            // Handle Create
            string query = $"INSERT INTO Employees (EmployeeId, FirstName, LastName, DateBirth, CCCD, Position, StartDate, Salary, Email, Deleted, Gender, PhoneNumber, Url_image) " +
                $"VALUES (N'{curr.id}',N'{curr.firstName}',N'{curr.lastName}','{curr.birth}', " +
                $"N'{curr.cccd}',N'{curr.position}','{curr.start}',{curr.salary}, N'{curr.email}', 0, {curr.gender}, N'{curr.phonenumber}', N'{curr.Url_image}')";

            // Excute the query
            processDb.UpdateData(query);

            if (File.Exists(pictureBoxAvatar.ImageLocation))
            {
                // Copy the file to the foldersss
                string folderPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "images//uploaded//");
                Image image = Image.FromFile(pictureBoxAvatar.ImageLocation);
                File.Copy(pictureBoxAvatar.ImageLocation, folderPath + Path.GetFileName(pictureBoxAvatar.ImageLocation), true);
            }

            // Earse current data
            CleanForm();

            MessageBox.Show("Tạo thành công", "Thông báo");

            if (isCreateOne) Close();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            txtId.Text = AutoCreateId();
        }

        private bool IsValidEmail(string email)
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
                position = cboPosition.Text != "--- Chọn ---" ? cboPosition.Text : "",
                cccd = txtCCCD.Text.Trim(),
                birthday = birthDateTimePicker.Value,
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                gender = temp,
                email = txtEmail.Text.Trim(),
                salary = txtSalary.Text.Trim(),
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
            if (curr.cccd.Length < 9)
            {
                MessageBox.Show("Căn cước công dân không hợp lý");
                return false;
            }
            if (curr.email.Length <= 0 && !IsValidEmail(curr.email))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            if (curr.sdt.Length == 0 || curr.sdt.Length > 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }
            if (curr.salary.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập lương");
                return false;
            }

            DateTime currentDate = DateTime.Now;
            DateTime minimumBirthDate = currentDate.AddYears(-18);
            if (curr.birthday > minimumBirthDate)
            {
                MessageBox.Show("Bạn nhân viên phải trên 18 tuổi.",
                    "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                id = "E" + id;
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

            cboPosition.Text = "--- Chọn ----";
            birthDateTimePicker.Value = DateTime.Now;
            rdbFemale.Checked = rdbMale.Checked = false;
            pictureBoxAvatar.Image = null;
            pictureBoxAvatar.ImageLocation = "";
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Bắt buộc chọn 1 vị trí\n" +
                "- Số điện thoại, CCCD, lương chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isChanged || MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void txtPhonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar > '9' || e.KeyChar < '0'))
            {
                e.Handled = true;
            }
        }

        private void btnChangeAvt_Clicked(object sender, EventArgs e)
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
    }
}
