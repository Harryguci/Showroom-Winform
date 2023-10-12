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
            flowLayoutPanel2 = new FlowLayoutPanel();
            closeFormBtn = new Button();
            hideBtn = new Button();
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
            button5 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
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
            flowLayoutPanel1.TabIndex = 0;
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
            button1.TabIndex = 2;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 100);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AllowDrop = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(closeFormBtn);
            flowLayoutPanel2.Controls.Add(hideBtn);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(664, 38);
            flowLayoutPanel2.TabIndex = 0;
            flowLayoutPanel2.TabStop = true;
            flowLayoutPanel2.MouseDown += Form_MouseDown;
            // 
            // closeFormBtn
            // 
            closeFormBtn.Cursor = Cursors.Hand;
            closeFormBtn.Location = new Point(624, 0);
            closeFormBtn.Margin = new Padding(0);
            closeFormBtn.Name = "closeFormBtn";
            closeFormBtn.RightToLeft = RightToLeft.No;
            closeFormBtn.Size = new Size(40, 38);
            closeFormBtn.TabIndex = 1;
            closeFormBtn.TabStop = false;
            closeFormBtn.Text = "X";
            closeFormBtn.UseVisualStyleBackColor = true;
            closeFormBtn.Click += closeFormBtn_Click;
            // 
            // hideBtn
            // 
            hideBtn.Cursor = Cursors.Hand;
            hideBtn.Location = new Point(584, 0);
            hideBtn.Margin = new Padding(0);
            hideBtn.Name = "hideBtn";
            hideBtn.RightToLeft = RightToLeft.No;
            hideBtn.Size = new Size(40, 38);
            hideBtn.TabIndex = 1;
            hideBtn.TabStop = false;
            hideBtn.Text = "-";
            hideBtn.UseVisualStyleBackColor = true;
            hideBtn.Click += hideFormBtn_Click;
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
            textBox1.Location = new Point(181, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 92);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 2;
            label2.Text = "Firstname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 154);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 2;
            label3.Text = "Lastname";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 27);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 214);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 2;
            label4.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(246, 27);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 272);
            label5.Name = "label5";
            label5.Size = new Size(42, 19);
            label5.TabIndex = 2;
            label5.Text = "Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(179, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            panel3.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(181, 324);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(121, 38);
            button5.TabIndex = 6;
            button5.Text = "Send";
            button5.UseVisualStyleBackColor = false;
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
            FormBorderStyle = FormBorderStyle.None;
            Padding = new Padding
            {
                Left = 0,
                Top = 0,
                Right = 0,
                Bottom = 5,
            };
            Name = "CreateEmployeeForm";
            Text = "Showroom - Create a employee";
            MouseDown += Form_MouseDown;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button closeFormBtn;
        private Button hideBtn;
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
    }
}