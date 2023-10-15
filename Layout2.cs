﻿using Newtonsoft.Json;
using ShowroomData.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ShowroomData
{
    public partial class Layout2 : Form
    {
        public Layout2()
        {
            InitializeComponent();
            HandleGUI();
        }

        public void HandleGUI()
        {
            //
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

        private void button4_Click(object sender, EventArgs e)
        {
            Layout layout = new Layout();
            layout.Show();

            Hide(); // Hide the current Form.

            layout.FormClosed += (s, args) => Close();
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
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "Data", "login_cookie.json")))
                {
                    outputFile.WriteLine(JsonConvert.SerializeObject(curr));
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }

        private void Layout2_FormClosing(object sender, FormClosingEventArgs e)
        {
            RememberLoginInfo();
        }
    }
}
