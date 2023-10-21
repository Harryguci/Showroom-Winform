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
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
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
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 392);
            panel1.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(56, 206);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 23);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Ghi nhớ mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(201, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 108);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 10;
            label1.Text = "Tên đăng nhập";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(201, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(50, 50, 150);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(56, 250);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(223, 51);
            button4.TabIndex = 2;
            button4.Text = "Đăng nhập";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 152);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 11;
            label2.Text = "Mật khẩu";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(282, 250);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(110, 51);
            button1.TabIndex = 3;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
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
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.MidnightBlue;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 513);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button4;
        private Label label2;
        public Button button1;
        private Panel panel2;
        private CheckBox checkBox1;
        public Button btnClose;
    }
}