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
            numberLvl = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            cbId = new ComboBox();
            txtConfpassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberLvl).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 117);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(276, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(numberLvl);
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
            panel2.Location = new Point(0, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 553);
            panel2.TabIndex = 1;
            // 
            // numberLvl
            // 
            numberLvl.BorderStyle = BorderStyle.FixedSingle;
            numberLvl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numberLvl.Location = new Point(300, 216);
            numberLvl.Margin = new Padding(4, 5, 4, 5);
            numberLvl.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numberLvl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberLvl.Name = "numberLvl";
            numberLvl.Size = new Size(294, 35);
            numberLvl.TabIndex = 4;
            numberLvl.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(50, 50, 150);
            button2.Location = new Point(466, 427);
            button2.Name = "button2";
            button2.Size = new Size(130, 67);
            button2.TabIndex = 3;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(300, 427);
            button1.Name = "button1";
            button1.Size = new Size(169, 67);
            button1.TabIndex = 3;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbId
            // 
            cbId.FormattingEnabled = true;
            cbId.Location = new Point(300, 160);
            cbId.Name = "cbId";
            cbId.Size = new Size(294, 33);
            cbId.TabIndex = 2;
            // 
            // txtConfpassword
            // 
            txtConfpassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfpassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfpassword.Location = new Point(301, 347);
            txtConfpassword.MaxLength = 30;
            txtConfpassword.Name = "txtConfpassword";
            txtConfpassword.Size = new Size(293, 35);
            txtConfpassword.TabIndex = 1;
            txtConfpassword.KeyPress += txtConfpassword_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(300, 277);
            txtPassword.MaxLength = 30;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 35);
            txtPassword.TabIndex = 1;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(301, 88);
            txtUsername.MaxLength = 30;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(293, 35);
            txtUsername.TabIndex = 1;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 350);
            label4.Name = "label4";
            label4.Size = new Size(215, 29);
            label4.TabIndex = 0;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 280);
            label3.Name = "label3";
            label3.Size = new Size(109, 29);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(194, 218);
            label5.Name = "label5";
            label5.Size = new Size(71, 29);
            label5.TabIndex = 0;
            label5.Text = "Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 158);
            label2.Name = "label2";
            label2.Size = new Size(36, 29);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 92);
            label1.Name = "label1";
            label1.Size = new Size(175, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // Layout3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 670);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Layout3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberLvl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtConfpassword;
        private TextBox txtPassword;
        private ComboBox cbId;
        private Button button1;
        private Button button2;
        private Label label5;
        private NumericUpDown numberLvl;
    }
}