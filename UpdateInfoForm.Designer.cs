using ShowroomData.ComponentGUI;

namespace ShowroomData
{
    partial class UpdateInfoForm
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
            txtId = new RoundTextBox();
            label2 = new Label();
            txtFirstName = new RoundTextBox();
            label3 = new Label();
            txtLastName = new RoundTextBox();
            label4 = new Label();
            txtPhone = new RoundTextBox();
            label5 = new Label();
            birthDateTimePicker = new DateTimePicker();
            panel3 = new Panel();
            btnChangeAvt = new Button();
            pictureBoxAvatar = new PictureBox();
            cbPosition = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            grbGender = new GroupBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            btnClean = new Button();
            btnCreate = new Button();
            txtEmail = new RoundTextBox();
            txtSalary = new RoundTextBox();
            txtCCCD = new RoundTextBox();
            label7 = new Label();
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
            flowLayoutPanel1.Size = new Size(136, 624);
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
            btnBack.TabIndex = 10;
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
            helpBtn.TabIndex = 11;
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
            panel1.Size = new Size(1089, 100);
            panel1.TabIndex = 100;
            panel1.Paint += panel1_Paint;
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
            flowLayoutPanel2.Size = new Size(1089, 33);
            flowLayoutPanel2.TabIndex = 101;
            flowLayoutPanel2.MouseDown += Form_MouseDown;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(1040, 0);
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
            button2.Location = new Point(991, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(49, 33);
            button2.TabIndex = 0;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(316, 47);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(318, 37);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Thông tin nhân viên";
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
            txtId.BorderRadius = 3;
            txtId.Enabled = false;
            txtId.Location = new Point(132, 34);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(469, 35);
            txtId.TabIndex = 0;
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
            // txtFirstName
            // 
            txtFirstName.BorderRadius = 3;
            txtFirstName.Location = new Point(132, 89);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(202, 35);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // txtLastName
            // 
            txtLastName.BorderRadius = 3;
            txtLastName.Location = new Point(430, 92);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 35);
            txtLastName.TabIndex = 2;
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
            txtPhone.BorderRadius = 3;
            txtPhone.Location = new Point(132, 166);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(245, 35);
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
            birthDateTimePicker.Location = new Point(176, 238);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(395, 26);
            birthDateTimePicker.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(btnChangeAvt);
            panel3.Controls.Add(pictureBoxAvatar);
            panel3.Controls.Add(cbPosition);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(grbGender);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(birthDateTimePicker);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtSalary);
            panel3.Controls.Add(txtCCCD);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(243, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(943, 496);
            panel3.TabIndex = 100;
            // 
            // btnChangeAvt
            // 
            btnChangeAvt.BackColor = Color.FromArgb(50, 50, 150);
            btnChangeAvt.FlatAppearance.BorderSize = 0;
            btnChangeAvt.FlatStyle = FlatStyle.Flat;
            btnChangeAvt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeAvt.ForeColor = Color.White;
            btnChangeAvt.Location = new Point(783, 343);
            btnChangeAvt.Name = "btnChangeAvt";
            btnChangeAvt.Size = new Size(124, 37);
            btnChangeAvt.TabIndex = 10;
            btnChangeAvt.Text = "Đổi ảnh";
            btnChangeAvt.UseVisualStyleBackColor = false;
            btnChangeAvt.Click += btnChangeAvt_Click;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackColor = Color.White;
            pictureBoxAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar.Location = new Point(636, 37);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(271, 300);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 9;
            pictureBoxAvatar.TabStop = false;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "NV bán hàng", "NV bảo trì", "NV phục vụ", "Quản lý" });
            cbPosition.Location = new Point(423, 370);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(178, 28);
            cbPosition.TabIndex = 8;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 307);
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
            grbGender.TabIndex = 4;
            grbGender.TabStop = false;
            grbGender.Text = "Giới tính";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(103, 39);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(47, 24);
            rdbFemale.TabIndex = 4;
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
            btnClean.FlatAppearance.BorderSize = 0;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(480, 431);
            btnClean.Margin = new Padding(0);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(121, 38);
            btnClean.TabIndex = 6;
            btnClean.Text = "Nhập lại";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.MenuHighlight;
            btnCreate.BackgroundImageLayout = ImageLayout.None;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(348, 431);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(121, 38);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Lưu";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += createBtn_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 3;
            txtEmail.Location = new Point(132, 304);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(469, 35);
            txtEmail.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.BorderRadius = 3;
            txtSalary.Location = new Point(131, 428);
            txtSalary.Multiline = true;
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(178, 35);
            txtSalary.TabIndex = 7;
            txtSalary.KeyPress += txtCCCD_KeyPress_1;
            // 
            // txtCCCD
            // 
            txtCCCD.BorderRadius = 3;
            txtCCCD.Location = new Point(131, 370);
            txtCCCD.Multiline = true;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(178, 35);
            txtCCCD.TabIndex = 7;
            txtCCCD.KeyPress += txtCCCD_KeyPress_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 431);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 2;
            label7.Text = "Lương";
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
            // UpdateInfoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 624);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UpdateInfoForm";
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker birthDateTimePicker;
        private Panel panel3;
        private Button btnCreate;
        private Label lblHeading;
        private Button btnClean;
        private GroupBox grbGender;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Label label6;
        private Label label9;
        private Label label10;
        private ComboBox cbPosition;
        private Button helpBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label7;
        private RoundTextBox txtId;
        private RoundTextBox txtFirstName;
        private RoundTextBox txtLastName;
        private RoundTextBox txtPhone;
        private RoundTextBox txtCCCD;
        private RoundTextBox txtEmail;
        private RoundTextBox txtSalary;
        private PictureBox pictureBoxAvatar;
        private Button btnChangeAvt;
    }
}