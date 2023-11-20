namespace ShowroomData
{
    partial class CreateUpdateCustomer
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
            button2 = new Button();
            panel1 = new Panel();
            lblHeadingPage = new Label();
            panelContent = new Panel();
            panel3 = new Panel();
            btnReset = new Button();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtCccd = new TextBox();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            dtpBirth = new DateTimePicker();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelContent.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 720);
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
            button1.Margin = new Padding(0, 0, 0, 30);
            button1.Name = "button1";
            button1.Size = new Size(136, 51);
            button1.TabIndex = 2;
            button1.Text = "Quay Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 50, 150);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 209);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(136, 51);
            button2.TabIndex = 3;
            button2.Text = "Trợ Giúp";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblHeadingPage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 100);
            panel1.TabIndex = 1;
            panel1.MouseDown += Form_MouseDown;
            // 
            // lblHeadingPage
            // 
            lblHeadingPage.AutoSize = true;
            lblHeadingPage.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeadingPage.Location = new Point(390, 31);
            lblHeadingPage.Name = "lblHeadingPage";
            lblHeadingPage.Size = new Size(105, 27);
            lblHeadingPage.TabIndex = 1;
            lblHeadingPage.Text = "Welcome";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panel3);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(136, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(964, 620);
            panelContent.TabIndex = 2;
            panelContent.MouseDown += Form_MouseDown;
            panelContent.Resize += panelContent_Resize;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpBirth);
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtCccd);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtPhoneNumber);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(70, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 548);
            panel3.TabIndex = 0;
            panel3.MouseDown += Form_MouseDown;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(425, 477);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 45);
            btnReset.TabIndex = 3;
            btnReset.Text = "Đặt lại";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(226, 477);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += HandleSaveChange_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(140, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 107);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(126, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 23);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 23);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(541, 244);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 165);
            txtAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 382);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(425, 247);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 0;
            label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 385);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // txtCccd
            // 
            txtCccd.Location = new Point(541, 177);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(220, 27);
            txtCccd.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 180);
            label6.Name = "label6";
            label6.Size = new Size(50, 19);
            label6.TabIndex = 0;
            label6.Text = "CCCD";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(541, 106);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(220, 27);
            txtPhoneNumber.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 109);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 0;
            label5.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 46);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 0;
            label4.Text = "Ngày Sinh";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 177);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 27);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 180);
            label3.Name = "label3";
            label3.Size = new Size(35, 19);
            label3.TabIndex = 0;
            label3.Text = "Tên";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 106);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(220, 27);
            txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 109);
            label2.Name = "label2";
            label2.Size = new Size(29, 19);
            label2.TabIndex = 0;
            label2.Text = "Họ";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(140, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(220, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 43);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(541, 40);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(220, 27);
            dtpBirth.TabIndex = 4;
            // 
            // CreateUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1100, 720);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateUpdateCustomer";
            Text = "Showroom - Management System";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContent.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label lblHeadingPage;
        private Panel panelContent;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtCccd;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label label5;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnSave;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label8;
        private Label label7;
        private Button btnReset;
        private DateTimePicker dtpBirth;
    }
}