namespace ShowroomData
{
    partial class CreateEmployeeForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            lblHeading = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel3 = new Panel();
            button2 = new Button();
            button5 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 500);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(133, 122);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(20, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 150);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 128);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(136, 51);
            button1.TabIndex = 10;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblHeading);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 100);
            panel1.TabIndex = 100;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(224, 35);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(236, 33);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Tạo mới nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(132, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 92);
            label2.Name = "label2";
            label2.Size = new Size(29, 19);
            label2.TabIndex = 2;
            label2.Text = "Họ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 27);
            textBox2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 154);
            label3.Name = "label3";
            label3.Size = new Size(35, 19);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 27);
            textBox3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 214);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 2;
            label4.Text = "SDT";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 27);
            textBox4.TabIndex = 3;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 272);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 2;
            label5.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(230, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 372);
            panel3.TabIndex = 100;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(263, 318);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(121, 38);
            button2.TabIndex = 6;
            button2.Text = "Nhập mới";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(131, 318);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(121, 38);
            button5.TabIndex = 5;
            button5.Text = "Tạo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // CreateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Create a employee";
            Load += CreateEmployeeForm_Load;
            MouseDown += Form_MouseDown;
            Resize += CreateEmployeeForm_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Panel panel3;
        private Button button5;
        private Label lblHeading;
        private Button button2;
    }
}