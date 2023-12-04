using ShowroomData.ComponentGUI;

namespace ShowroomData
{
    partial class Layout3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            levelNum = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            cbId = new ComboBox();
            txtConfpassword = new RoundTextBox();
            txtPassword = new RoundTextBox();
            txtUsername = new RoundTextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelNum).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 133);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(160, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(levelNum);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cbId);
            panel2.Controls.Add(txtConfpassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 133);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 356);
            panel2.TabIndex = 1;
            // 
            // levelNum
            // 
            levelNum.BackColor = Color.FromArgb(50, 50, 150);
            levelNum.BorderStyle = BorderStyle.FixedSingle;
            levelNum.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            levelNum.ForeColor = Color.White;
            levelNum.Location = new Point(222, 125);
            levelNum.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            levelNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            levelNum.Name = "levelNum";
            levelNum.Size = new Size(283, 26);
            levelNum.TabIndex = 4;
            levelNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            levelNum.ValueChanged += numberLvl_ValueChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(50, 50, 150);
            button2.Location = new Point(366, 276);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(135, 40);
            button2.TabIndex = 3;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnBack_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(51, 276);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(311, 40);
            button1.TabIndex = 3;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSign_Click;
            // 
            // cbId
            // 
            cbId.BackColor = Color.FromArgb(230, 230, 255);
            cbId.DropDownHeight = 150;
            cbId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbId.FormattingEnabled = true;
            cbId.IntegralHeight = false;
            cbId.Location = new Point(222, 87);
            cbId.Margin = new Padding(2);
            cbId.Name = "cbId";
            cbId.Size = new Size(284, 23);
            cbId.TabIndex = 2;
            // 
            // txtConfpassword
            // 
            txtConfpassword.BackColor = Color.FromArgb(50, 50, 150);
            txtConfpassword.BorderRadius = 3;
            txtConfpassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfpassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfpassword.ForeColor = Color.White;
            txtConfpassword.Location = new Point(223, 209);
            txtConfpassword.Margin = new Padding(2);
            txtConfpassword.MaxLength = 30;
            txtConfpassword.Multiline = true;
            txtConfpassword.Name = "txtConfpassword";
            txtConfpassword.PasswordChar = '*';
            txtConfpassword.Size = new Size(283, 38);
            txtConfpassword.TabIndex = 1;
            txtConfpassword.KeyPress += txtConfpassword_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(50, 50, 150);
            txtPassword.BorderRadius = 3;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(222, 167);
            txtPassword.Margin = new Padding(2);
            txtPassword.MaxLength = 30;
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(283, 38);
            txtPassword.TabIndex = 1;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(50, 50, 150);
            txtUsername.BorderRadius = 3;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(223, 38);
            txtUsername.Margin = new Padding(2);
            txtUsername.MaxLength = 30;
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(283, 38);
            txtUsername.TabIndex = 1;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 211);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 0;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(123, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(83, 127);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 0;
            label5.Text = "Quyền truy cập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(172, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // Layout3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 489);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Layout3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)levelNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbId;
        private Button button1;
        private Button button2;
        private Label label5;
        private NumericUpDown levelNum;
        private RoundTextBox txtUsername;
        private RoundTextBox txtConfpassword;
        private RoundTextBox txtPassword;
    }
}