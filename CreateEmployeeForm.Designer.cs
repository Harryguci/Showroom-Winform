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
            btnBack = new Button();
            helpBtn = new Button();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            lblHeading = new Label();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtLastname = new TextBox();
            label3 = new Label();
            txtFirstname = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            birthDateTimePicker = new DateTimePicker();
            panel3 = new Panel();
            btnChangeAvt = new Button();
            pictureBoxAvatar = new PictureBox();
            cboPosition = new ComboBox();
            label10 = new Label();
            label7 = new Label();
            label9 = new Label();
            grbGender = new GroupBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            btnClean = new Button();
            btnCreate = new Button();
            txtSalary = new TextBox();
            txtEmail = new TextBox();
            txtCCCD = new TextBox();
            label6 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            grbGender.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnBack);
            flowLayoutPanel1.Controls.Add(helpBtn);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 640);
            flowLayoutPanel1.TabIndex = 10;
            flowLayoutPanel1.MouseDown += Form_MouseDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(133, 122);
            panel2.TabIndex = 100;
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
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 50, 150);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 128);
            btnBack.Margin = new Padding(0, 0, 0, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 51);
            btnBack.TabIndex = 13;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // helpBtn
            // 
            helpBtn.BackColor = Color.FromArgb(50, 50, 150);
            helpBtn.FlatAppearance.BorderSize = 0;
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            helpBtn.ForeColor = Color.White;
            helpBtn.Location = new Point(0, 209);
            helpBtn.Margin = new Padding(0, 0, 0, 10);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(136, 51);
            helpBtn.TabIndex = 14;
            helpBtn.Text = "Trợ giúp";
            helpBtn.UseVisualStyleBackColor = true;
            helpBtn.Click += helpBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(lblHeading);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 100);
            panel1.TabIndex = 100;
            panel1.MouseDown += Form_MouseDown;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1144, 33);
            flowLayoutPanel2.TabIndex = 102;
            flowLayoutPanel2.MouseDown += Form_MouseDown;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(1095, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(49, 33);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(1046, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(49, 33);
            button2.TabIndex = 0;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnChangeSize_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(355, 57);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(252, 31);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Tạo mới nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(132, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(469, 26);
            txtId.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 92);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(132, 89);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(202, 26);
            txtLastname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 95);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(407, 92);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(194, 26);
            txtFirstname.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 169);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 2;
            label4.Text = "SDT";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(132, 166);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(217, 26);
            txtPhone.TabIndex = 3;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 244);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 2;
            label5.Text = "Ngày sinh";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDateTimePicker.Location = new Point(176, 238);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(317, 26);
            birthDateTimePicker.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnChangeAvt);
            panel3.Controls.Add(pictureBoxAvatar);
            panel3.Controls.Add(cboPosition);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(grbGender);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(birthDateTimePicker);
            panel3.Controls.Add(txtLastname);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtSalary);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtCCCD);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtFirstname);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(227, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(964, 512);
            panel3.TabIndex = 100;
            // 
            // btnChangeAvt
            // 
            btnChangeAvt.Location = new Point(815, 338);
            btnChangeAvt.Name = "btnChangeAvt";
            btnChangeAvt.Size = new Size(126, 32);
            btnChangeAvt.TabIndex = 103;
            btnChangeAvt.Text = "Thêm ảnh";
            btnChangeAvt.UseVisualStyleBackColor = true;
            btnChangeAvt.Click += btnChangeAvt_Clicked;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackColor = Color.White;
            pictureBoxAvatar.Location = new Point(640, 37);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(301, 295);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 102;
            pictureBoxAvatar.TabStop = false;
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Items.AddRange(new object[] { "NV bán hàng", "NV bảo trì", "NV phục vụ", "Quản lý" });
            cboPosition.Location = new Point(423, 370);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(178, 28);
            cboPosition.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 373);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 1;
            label10.Text = "Vị trí";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 306);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 1;
            label7.Text = "Lương";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 309);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 1;
            label9.Text = "Email";
            // 
            // grbGender
            // 
            grbGender.Controls.Add(rdbFemale);
            grbGender.Controls.Add(rdbMale);
            grbGender.Location = new Point(399, 143);
            grbGender.Name = "grbGender";
            grbGender.Size = new Size(202, 77);
            grbGender.TabIndex = 100;
            grbGender.TabStop = false;
            grbGender.Text = "Giới tính";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(103, 39);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(47, 24);
            rdbFemale.TabIndex = 5;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Nữ";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(6, 39);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(60, 24);
            rdbMale.TabIndex = 4;
            rdbMale.TabStop = true;
            rdbMale.Text = "Nam";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.ActiveCaption;
            btnClean.BackgroundImageLayout = ImageLayout.None;
            btnClean.FlatStyle = FlatStyle.Popup;
            btnClean.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(264, 454);
            btnClean.Margin = new Padding(0);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(121, 38);
            btnClean.TabIndex = 14;
            btnClean.Text = "Nhập mới";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.MenuHighlight;
            btnCreate.BackgroundImageLayout = ImageLayout.None;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(132, 454);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(121, 38);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += createBtn_Click;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(423, 303);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(178, 26);
            txtSalary.TabIndex = 10;
            txtSalary.KeyPress += txtPhonenumber_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 306);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 26);
            txtEmail.TabIndex = 9;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(132, 370);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(178, 26);
            txtCCCD.TabIndex = 11;
            txtCCCD.KeyPress += txtCCCD_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 373);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 2;
            label6.Text = "CCCD";
            // 
            // CreateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 640);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            grbGender.ResumeLayout(false);
            grbGender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnBack;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtLastname;
        private Label label3;
        private TextBox txtFirstname;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private DateTimePicker birthDateTimePicker;
        private Panel panel3;
        private Button btnCreate;
        private Label lblHeading;
        private Button btnClean;
        private GroupBox grbGender;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private TextBox txtCCCD;
        private Label label6;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private ComboBox cboPosition;
        private Button helpBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label7;
        private TextBox txtSalary;
        private Button btnChangeAvt;
        private PictureBox pictureBoxAvatar;
    }
}