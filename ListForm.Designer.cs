namespace ShowroomData
{
    partial class ListForm
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
<<<<<<< HEAD
=======
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnRefresh = new Button();
            btnCreate = new Button();
            btnUpdateInfo = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
<<<<<<< HEAD
            lblHeadingPage = new Label();
            panelContent = new Panel();
=======
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnNoti = new Button();
            button1 = new Button();
            lblHeadingPage = new Label();
            panelContent = new Panel();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
<<<<<<< HEAD
=======
            flowLayoutPanel2.SuspendLayout();
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.Controls.Add(btnCreate);
            flowLayoutPanel1.Controls.Add(btnUpdateInfo);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 544);
            flowLayoutPanel1.TabIndex = 0;
<<<<<<< HEAD
=======
            flowLayoutPanel1.Click += ListForm_Click;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
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
<<<<<<< HEAD
            pictureBox1.Location = new Point(20, 9);
=======
            pictureBox1.Location = new Point(23, 9);
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(50, 50, 150);
<<<<<<< HEAD
=======
            btnRefresh.BackgroundImage = Properties.Resources.icons8_refresh_100;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
<<<<<<< HEAD
=======
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnRefresh.Location = new Point(0, 128);
            btnRefresh.Margin = new Padding(0, 0, 0, 30);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 51);
            btnRefresh.TabIndex = 2;
<<<<<<< HEAD
            btnRefresh.Text = "Làm mới";
=======
            toolTip4.SetToolTip(btnRefresh, "Làm mới dữ liệu");
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button1_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(50, 50, 150);
<<<<<<< HEAD
=======
            btnCreate.BackgroundImage = Properties.Resources.icons8_create_96_white;
            btnCreate.BackgroundImageLayout = ImageLayout.Zoom;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(0, 209);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(136, 51);
            btnCreate.TabIndex = 3;
<<<<<<< HEAD
            btnCreate.Text = "Tạo mới";
=======
            toolTip1.SetToolTip(btnCreate, "Tạo mới một nhân viên");
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += createBtn_Click;
            // 
            // btnUpdateInfo
            // 
            btnUpdateInfo.BackColor = Color.FromArgb(50, 50, 100);
<<<<<<< HEAD
=======
            btnUpdateInfo.BackgroundImage = Properties.Resources.icons8_fix_1002;
            btnUpdateInfo.BackgroundImageLayout = ImageLayout.Zoom;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnUpdateInfo.Enabled = false;
            btnUpdateInfo.FlatAppearance.BorderSize = 0;
            btnUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateInfo.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInfo.ForeColor = Color.White;
            btnUpdateInfo.Location = new Point(0, 260);
            btnUpdateInfo.Margin = new Padding(0);
            btnUpdateInfo.Name = "btnUpdateInfo";
            btnUpdateInfo.Size = new Size(136, 51);
            btnUpdateInfo.TabIndex = 4;
<<<<<<< HEAD
            btnUpdateInfo.Text = "Sửa";
=======
            toolTip2.SetToolTip(btnUpdateInfo, "Sửa thông tin nhân viên được chọn");
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnUpdateInfo.UseVisualStyleBackColor = false;
            btnUpdateInfo.Click += updateInfoBtn_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(50, 50, 100);
<<<<<<< HEAD
=======
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_96;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 311);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 51);
            btnDelete.TabIndex = 5;
<<<<<<< HEAD
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
=======
            toolTip2.SetToolTip(btnDelete, "Sửa thông tin nhân viên được chọn");
            toolTip3.SetToolTip(btnDelete, "Xóa nhân viên được chọn");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
<<<<<<< HEAD
=======
            panel1.Controls.Add(flowLayoutPanel2);
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            panel1.Controls.Add(lblHeadingPage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 100);
            panel1.TabIndex = 1;
<<<<<<< HEAD
=======
            panel1.Click += ListForm_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnNoti);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(964, 46);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.Click += ListForm_Click;
            // 
            // btnNoti
            // 
            btnNoti.BackgroundImage = (Image)resources.GetObject("btnNoti.BackgroundImage");
            btnNoti.BackgroundImageLayout = ImageLayout.Zoom;
            btnNoti.Location = new Point(918, 3);
            btnNoti.Margin = new Padding(3, 3, 10, 3);
            btnNoti.Name = "btnNoti";
            btnNoti.Size = new Size(36, 40);
            btnNoti.TabIndex = 3;
            btnNoti.UseVisualStyleBackColor = true;
            btnNoti.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(868, 3);
            button1.Name = "button1";
            button1.Size = new Size(44, 40);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            // 
            // lblHeadingPage
            // 
            lblHeadingPage.AutoSize = true;
            lblHeadingPage.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            lblHeadingPage.Location = new Point(390, 31);
=======
            lblHeadingPage.Location = new Point(455, 61);
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            lblHeadingPage.Name = "lblHeadingPage";
            lblHeadingPage.Size = new Size(105, 27);
            lblHeadingPage.TabIndex = 1;
            lblHeadingPage.Text = "Welcome";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(136, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(964, 444);
            panelContent.TabIndex = 2;
            // 
<<<<<<< HEAD
=======
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Tạo mới";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Sửa";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = "Xóa";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            toolTip4.ToolTipTitle = "Refresh";
            // 
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1100, 544);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ListForm";
            Text = "Showroom - Management System";
            FormClosing += Layout_FormClosing;
            FormClosed += Layout_FormClosed;
            Load += Layout_Load;
<<<<<<< HEAD
=======
            Click += ListForm_Click;
            MouseDown += ListForm_MouseDown;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            Resize += Layout_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
<<<<<<< HEAD
=======
            flowLayoutPanel2.ResumeLayout(false);
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnRefresh;
        private Button btnCreate;
        private Button btnUpdateInfo;
        private Button btnDelete;
        private Label lblHeadingPage;
        private Panel panelContent;
<<<<<<< HEAD
=======
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnNoti;
        private Button button1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
>>>>>>> fb1a3db17375f003e63ccd3577eaaa215d683848
    }
}