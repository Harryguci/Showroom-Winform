using ShowroomData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class NotificationForm : Form
    {
        private Notification[] notifications = new Notification[]
        {
            new Notification("Title 1", "Content 1..."),
            new Notification("Title 2", "Content 2..."),
            new Notification("Title 3", "Content 3...")
        };


        public NotificationForm(Point? location)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            foreach (var notification in notifications)
            {
                Panel _panel = new Panel();
                TextBox _textBox = new TextBox();
                Label _label = new Label();
                PictureBox _pictureBox = new PictureBox();
                // 
                // panel2
                // 
                _panel.BackColor = Color.White;
                _panel.Controls.Add(_textBox);
                _panel.Controls.Add(_label);
                _panel.Controls.Add(_pictureBox);
                _panel.Location = new Point(3, 3);
                _panel.Name = "panel2";
                _panel.Size = new Size(287, 58);
                _panel.TabIndex = 0;
                // 
                // textBox1
                // 
                _textBox.BorderStyle = BorderStyle.None;
                _textBox.Location = new Point(65, 24);
                _textBox.Multiline = true;
                _textBox.Name = "textBox1";
                _textBox.Size = new Size(219, 34);
                _textBox.TabIndex = 2;
                _textBox.Text = notification.Content;
                // 
                // label1
                // 
                _label.AutoSize = true;
                _label.Location = new Point(65, 6);
                _label.Name = "label1";
                _label.Size = new Size(79, 15);
                _label.TabIndex = 1;
                _label.Text = notification.Title;
                // 
                // pictureBox1
                // 
                // _pictureBox.Image = Properties.Resources.notification_icon;
                _pictureBox.Location = new Point(9, 9);
                _pictureBox.Name = "pictureBox1";
                _pictureBox.Size = new Size(44, 40);
                _pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                _pictureBox.TabIndex = 0;
                _pictureBox.TabStop = false;

                flowLayoutPanel1.Controls.Add(_panel);
            }

            Location = location ?? new Point(0, 0);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
