using ShowroomData.ComponentGUI;

namespace ShowroomData
{
    partial class Layout2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnTogglePassword = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new RoundTextBox();
            label1 = new Label();
            textBox1 = new RoundTextBox();
            btnLogin = new Button();
            label2 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(113, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += Form_MouseDown;
            pictureBox1.MouseDown += Form_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnTogglePassword);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 392);
            panel1.TabIndex = 8;
            panel1.MouseClick += Form_MouseDown;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackgroundImage = Properties.Resources.show;
            btnTogglePassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Location = new Point(398, 152);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(30, 30);
            btnTogglePassword.TabIndex = 12;
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.FromArgb(100, 100, 255);
            checkBox1.Location = new Point(56, 206);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Ghi nhớ mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(70, 70, 200);
            textBox2.BorderRadius = 3;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.White;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(196, 150);
            textBox2.Margin = new Padding(0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(196, 36);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 108);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 10;
            label1.Text = "Tên đăng nhập";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(70, 70, 200);
            textBox1.BorderRadius = 3;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(196, 106);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 36);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(50, 50, 150);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(56, 250);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(223, 51);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 152);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Mật khẩu";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(282, 250);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(110, 51);
            button1.TabIndex = 3;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 117);
            panel2.TabIndex = 9;
            panel2.MouseClick += Form_MouseDown;
            panel2.MouseDown += Form_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.MidnightBlue;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(393, 9);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Layout2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 513);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Layout2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Management System";
            FormClosing += Layout2_FormClosing;
            Load += Layout2_Load;
            Resize += Layout_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        public Button button1;
        private Panel panel2;
        private CheckBox checkBox1;
        public Button btnClose;
        private Button btnTogglePassword;
        private RoundTextBox textBox2;
        private RoundTextBox textBox1;
    }
}