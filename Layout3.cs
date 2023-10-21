using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class Layout3 : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        public Layout3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Layout2 layout2 = new Layout2();
            layout2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox4.Text;
            string password = textBox2.Text;
            string confpassword = textBox3.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confpassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password.Contains(" ") || confpassword.Contains(" ") || username.Contains(" ") || email.Contains(" "))
            {
                MessageBox.Show("Không được nhập khoảng trắng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password != confpassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
