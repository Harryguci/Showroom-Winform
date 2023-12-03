using Newtonsoft.Json;
using ShowroomData.ComponentGUI;
using ShowroomData.Models;
using ShowroomData.Util;
using System.Data;

namespace ShowroomData
{
    public partial class Layout2 : Form
    {
        private ProcessDatabase _ProcessDatabase = new ProcessDatabase();
        private string txtpassword = string.Empty;
        public static Account CURR_USER = new Account();
        public Layout2()
        {
            InitializeComponent();
            HandleGUI();
        }

        public void HandleGUI()
        {
            FormBorderStyle = FormBorderStyle.None;
            RoundTextBox.SetPadding(textBox1, new Padding(5, 5, 1, 1));
            RoundTextBox.SetPadding(textBox2, new Padding(5, 5, 1, 1));
        }

        //
        // [Handle Events]
        //
        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void Layout_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((Width - panel1.Width) / 2, panel1.Location.Y);
            pictureBox1.Location = new Point((panel2.Width - pictureBox1.Width) / 2, pictureBox1.Location.Y);
        }

        #region Handle Dragging the from
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

        private void Layout2_Load(object sender, EventArgs e)
        {
            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string json = File.ReadAllText(Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "Data", "login_cookie.json"));
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                var cookieData = JsonConvert.DeserializeObject<SimpleAccountInfo>(json);
                if (cookieData != null)
                {
                    textBox1.Text = cookieData.Username;
                    textBox2.Text = cookieData.Password;
                }
            }
            catch
            {
                ;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống.");
                return;
            }

            if (CheckLogin(username, password))
            {
                var query = _ProcessDatabase.GetData($"SELECT * FROM ACCOUNT WHERE USERNAME = N'{username}'");

                CURR_USER.EmployeeId = query.Rows[0].Field<string>("EmployeeId");
                CURR_USER.Username = query.Rows[0].Field<string>("Username") ?? "";
                CURR_USER.Level_account = query.Rows[0].Field<int>("Level_account");
                CURR_USER.EmployeeId = query.Rows[0].Field<string>("EmployeeId") ?? "";

                try
                {
                    CURR_USER.CreateAt = query.Rows[0].Field<DateTime>("CreateAt");
                    CURR_USER.DeleteAt = query.Rows[0].Field<DateTime>("DeleteAt");
                }
                catch
                {
                    ;
                }

                Home form = new Home();
                form.Show();
                Hide(); // Hide the current Form.
                form.FormClosed += (s, args) => Close();

                //Admin admin = new Admin();
                //admin.Show();

                //Hide();

                // admin.FormClosed += (s, args) => Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool CheckLogin(string username, string password)
        {
            string query = "SELECT * FROM Login_check('" + username + "','" + password + "')";
            DataTable dt = new DataTable();
            try
            {
                dt = _ProcessDatabase.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Gặp lỗi" + e.Message + "!!!", "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            return false;
        }
        private void RememberLoginInfo()
        {
            if (checkBox1.Checked)
            {
                // Write data to Data/login_cookie.json
                var curr = new
                {
                    username = textBox1.Text,
                    password = textBox2.Text,
                };

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                if (File.Exists(Path.Combine(
                        Directory.GetParent(Directory.GetCurrentDirectory())
                        .Parent.Parent.FullName,
                        "Data", "login_cookie.json")))
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(
                        Directory.GetParent(Directory.GetCurrentDirectory())
                        .Parent.Parent.FullName,
                        "Data", "login_cookie.json")))
                    {
                        outputFile.WriteLine(JsonConvert.SerializeObject(curr));
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }

        private void Layout2_FormClosing(object sender, FormClosingEventArgs e)
        {
            RememberLoginInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin_Click(btnLogin, e);
            }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_'
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin_Click(btnLogin, e);
            }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Layout3 signUpForm = new Layout3();

        //    signUpForm.FormClosed += (signUpForm, args) =>
        //    {
        //        Close();
        //    };
        //    signUpForm.Show();

        //    Hide();

        //    signUpForm.FormClosed += (s, args) => Close();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
                btnTogglePassword.BackgroundImage = Properties.Resources.show;
            }
            else
            {
                textBox2.PasswordChar = '\0';
                btnTogglePassword.BackgroundImage = Properties.Resources.invisible;
            }
        }
    }
}
