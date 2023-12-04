using ShowroomData.ComponentGUI;
using ShowroomData.Models;
using System.Data;

namespace ShowroomData
{
    public partial class UserAccount : Form
    {
        private ProcessDatabase _processDb = new ProcessDatabase();
        private Account? _currAccount = null;
        public UserAccount()
        {
            InitializeComponent();
            HandleGUI();
        }

        private void HandleGUI()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;


            Padding padding = new Padding(5);
            RoundTextBox.SetPadding(txtUsername, padding);
            RoundTextBox.SetPadding(txtPassword, padding);
            RoundTextBox.SetPadding(txtConfirmPassword, padding);
            RoundTextBox.SetPadding(txtRole, padding);
            RoundTextBox.SetPadding(txtEmployeeId, padding);

            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            _currAccount = Layout2.CURR_USER;
            txtUsername.Text = _currAccount.Username;
            txtPassword.Text = "***************";
            txtConfirmPassword.Text = "***************";

            txtRole.Text = _currAccount.Level_account == 2
                ? "Quản lý" : "Nhân viên";
            txtEmployeeId.Text = _currAccount.EmployeeId;

            if (_currAccount.EmployeeId != null && _currAccount.EmployeeId.Length > 0)
            {
                var query = _processDb.GetData($"SELECT * FROM Employees Where employeeid = N'{_currAccount.EmployeeId}'");
                var url = query.Rows[0].Field<string>("Url_Image");
                if (url != null && url.Length > 0)
                {
                    var root = Directory.GetCurrentDirectory();
                    while (url[0] == '/') url = url.Substring(1);

                    pictureBox2.ImageLocation = Path.Combine(root, url);
                }
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = txtConfirmPassword.Enabled = !txtPassword.Enabled;
            if (txtPassword.Enabled)
            {
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.BackColor = txtConfirmPassword.BackColor = Color.FromArgb(200, 200, 255);
            }
            else
            {
                txtPassword.Text = txtConfirmPassword.Text = "***************";
                txtPassword.BackColor = txtConfirmPassword.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currAccount == null) return;
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var sql = $"UPDATE ACCOUNT " +
                $"SET PASSWORD_FORUSER = CONVERT(VARBINARY(500), '{txtPassword.Text.Trim()}') " +
                $"WHERE USERNAME = N'{_currAccount.Username}'";

            _processDb.UpdateData(sql);

            MessageBox.Show("Cập nhật thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserAccount_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point((panelHeader.Width - pictureBox1.Width) / 2,
               (panelHeader.Height - pictureBox1.Height) / 2);

            panelMain.Location = new Point((panelContent.Width - panelMain.Width) / 2,
                (panelContent.Height - panelMain.Height) / 2);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelperDialog helper = HelperDialog.Create("Thông tin",
                "Showroom Management Application");

            helper.ShowDialog();
        }
    }
}
