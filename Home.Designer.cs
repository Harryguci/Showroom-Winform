﻿namespace ShowroomData
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnCurrAccount = new Button();
            button2 = new Button();
            button3 = new Button();
            btnSignUp = new Button();
            panel1 = new Panel();
            btnSearchAll = new Button();
            btnLogout = new Button();
            lblHeadingPage = new Label();
            panelContent = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnProducts = new Button();
            btnEmployees = new Button();
            btnCustomers = new Button();
            btnPuchaInvoices = new Button();
            btnSaleInvoice = new Button();
            btnSource = new Button();
            btnDevices = new Button();
            btnTask = new Button();
            btnAccounts = new Button();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelContent.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnCurrAccount);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(btnSignUp);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 785);
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
            // btnCurrAccount
            // 
            btnCurrAccount.BackColor = Color.FromArgb(50, 50, 150);
            btnCurrAccount.FlatAppearance.BorderSize = 0;
            btnCurrAccount.FlatStyle = FlatStyle.Flat;
            btnCurrAccount.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCurrAccount.ForeColor = Color.White;
            btnCurrAccount.Location = new Point(0, 128);
            btnCurrAccount.Margin = new Padding(0, 0, 0, 30);
            btnCurrAccount.Name = "btnCurrAccount";
            btnCurrAccount.Size = new Size(136, 51);
            btnCurrAccount.TabIndex = 2;
            btnCurrAccount.Text = "Tài khoản";
            btnCurrAccount.UseVisualStyleBackColor = true;
            btnCurrAccount.Click += btnCurrAccount_Click;
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
            button2.Text = "Công việc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 50, 150);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 260);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(136, 51);
            button3.TabIndex = 4;
            button3.Text = "Báo cáo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnShowReport_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(50, 50, 150);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(0, 311);
            btnSignUp.Margin = new Padding(0);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(136, 51);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Đăng ký tài khoản";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSearchAll);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblHeadingPage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 179);
            panel1.TabIndex = 1;
            // 
            // btnSearchAll
            // 
            btnSearchAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchAll.BackgroundImage = Properties.Resources.magnifying_glass;
            btnSearchAll.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchAll.FlatAppearance.BorderSize = 0;
            btnSearchAll.FlatStyle = FlatStyle.Flat;
            btnSearchAll.Location = new Point(942, 17);
            btnSearchAll.Margin = new Padding(5);
            btnSearchAll.Name = "btnSearchAll";
            btnSearchAll.Padding = new Padding(10);
            btnSearchAll.Size = new Size(45, 41);
            btnSearchAll.TabIndex = 3;
            btnSearchAll.UseVisualStyleBackColor = true;
            btnSearchAll.Click += btnSearchAll_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.logout;
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(997, 12);
            btnLogout.Margin = new Padding(5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(46, 51);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblHeadingPage
            // 
            lblHeadingPage.AutoSize = true;
            lblHeadingPage.Font = new Font("Lobster", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeadingPage.Location = new Point(325, 27);
            lblHeadingPage.Name = "lblHeadingPage";
            lblHeadingPage.Size = new Size(280, 100);
            lblHeadingPage.TabIndex = 1;
            lblHeadingPage.Text = "Welcome";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(flowLayoutPanel2);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(136, 179);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1055, 606);
            panelContent.TabIndex = 2;
            panelContent.Resize += panelContent_Resize;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnProducts);
            flowLayoutPanel2.Controls.Add(btnEmployees);
            flowLayoutPanel2.Controls.Add(btnCustomers);
            flowLayoutPanel2.Controls.Add(btnPuchaInvoices);
            flowLayoutPanel2.Controls.Add(btnSaleInvoice);
            flowLayoutPanel2.Controls.Add(btnSource);
            flowLayoutPanel2.Controls.Add(btnDevices);
            flowLayoutPanel2.Controls.Add(btnTask);
            flowLayoutPanel2.Controls.Add(btnAccounts);
            flowLayoutPanel2.Location = new Point(42, 30);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(50, 0, 0, 0);
            flowLayoutPanel2.Size = new Size(1001, 564);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnProducts
            // 
            btnProducts.AllowDrop = true;
            btnProducts.BackgroundImage = (Image)resources.GetObject("btnProducts.BackgroundImage");
            btnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducts.ForeColor = SystemColors.ButtonHighlight;
            btnProducts.ImageAlign = ContentAlignment.TopCenter;
            btnProducts.Location = new Point(70, 20);
            btnProducts.Margin = new Padding(20);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(177, 150);
            btnProducts.TabIndex = 0;
            toolTip1.SetToolTip(btnProducts, "Sản phẩm");
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += HandleChangeForm;
            // 
            // btnEmployees
            // 
            btnEmployees.BackgroundImage = Properties.Resources.employees;
            btnEmployees.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Location = new Point(287, 20);
            btnEmployees.Margin = new Padding(20);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(177, 150);
            btnEmployees.TabIndex = 0;
            toolTip1.SetToolTip(btnEmployees, "Nhân viên");
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += HandleChangeForm;
            // 
            // btnCustomers
            // 
            btnCustomers.BackgroundImage = Properties.Resources.customers;
            btnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Location = new Point(504, 20);
            btnCustomers.Margin = new Padding(20);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(177, 150);
            btnCustomers.TabIndex = 0;
            toolTip1.SetToolTip(btnCustomers, "Khách hàng");
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += HandleChangeForm;
            // 
            // btnPuchaInvoices
            // 
            btnPuchaInvoices.BackgroundImage = Properties.Resources.invoices;
            btnPuchaInvoices.BackgroundImageLayout = ImageLayout.Zoom;
            btnPuchaInvoices.FlatAppearance.BorderSize = 0;
            btnPuchaInvoices.FlatStyle = FlatStyle.Flat;
            btnPuchaInvoices.Location = new Point(721, 20);
            btnPuchaInvoices.Margin = new Padding(20);
            btnPuchaInvoices.Name = "btnPuchaInvoices";
            btnPuchaInvoices.Size = new Size(177, 150);
            btnPuchaInvoices.TabIndex = 0;
            toolTip1.SetToolTip(btnPuchaInvoices, "Hóa đơn nhập");
            btnPuchaInvoices.UseVisualStyleBackColor = true;
            btnPuchaInvoices.Click += HandleChangeForm;
            // 
            // btnSaleInvoice
            // 
            btnSaleInvoice.BackgroundImage = (Image)resources.GetObject("btnSaleInvoice.BackgroundImage");
            btnSaleInvoice.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaleInvoice.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSaleInvoice.FlatAppearance.BorderSize = 0;
            btnSaleInvoice.FlatStyle = FlatStyle.Flat;
            btnSaleInvoice.Location = new Point(70, 210);
            btnSaleInvoice.Margin = new Padding(20);
            btnSaleInvoice.Name = "btnSaleInvoice";
            btnSaleInvoice.Size = new Size(177, 150);
            btnSaleInvoice.TabIndex = 0;
            toolTip1.SetToolTip(btnSaleInvoice, "Hóa đơn bán");
            btnSaleInvoice.UseVisualStyleBackColor = true;
            btnSaleInvoice.Click += HandleChangeForm;
            // 
            // btnSource
            // 
            btnSource.BackgroundImage = Properties.Resources.sources;
            btnSource.BackgroundImageLayout = ImageLayout.Zoom;
            btnSource.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSource.FlatAppearance.BorderSize = 0;
            btnSource.FlatStyle = FlatStyle.Flat;
            btnSource.Location = new Point(287, 210);
            btnSource.Margin = new Padding(20);
            btnSource.Name = "btnSource";
            btnSource.Size = new Size(177, 150);
            btnSource.TabIndex = 0;
            toolTip1.SetToolTip(btnSource, "Nguồn cung");
            btnSource.UseVisualStyleBackColor = true;
            btnSource.Click += HandleChangeForm;
            // 
            // btnDevices
            // 
            btnDevices.BackgroundImage = (Image)resources.GetObject("btnDevices.BackgroundImage");
            btnDevices.BackgroundImageLayout = ImageLayout.Zoom;
            btnDevices.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnDevices.FlatAppearance.BorderSize = 0;
            btnDevices.FlatStyle = FlatStyle.Flat;
            btnDevices.Location = new Point(504, 210);
            btnDevices.Margin = new Padding(20);
            btnDevices.Name = "btnDevices";
            btnDevices.Size = new Size(177, 150);
            btnDevices.TabIndex = 0;
            toolTip1.SetToolTip(btnDevices, "Thiết bị");
            btnDevices.UseVisualStyleBackColor = true;
            btnDevices.Click += HandleChangeForm;
            // 
            // btnTask
            // 
            btnTask.BackgroundImage = Properties.Resources.list;
            btnTask.BackgroundImageLayout = ImageLayout.Zoom;
            btnTask.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnTask.FlatAppearance.BorderSize = 0;
            btnTask.FlatStyle = FlatStyle.Flat;
            btnTask.Location = new Point(721, 210);
            btnTask.Margin = new Padding(20);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(177, 150);
            btnTask.TabIndex = 0;
            toolTip1.SetToolTip(btnTask, "Công việc");
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += HandleChangeForm;
            // 
            // btnAccounts
            // 
            btnAccounts.BackgroundImage = Properties.Resources.user;
            btnAccounts.BackgroundImageLayout = ImageLayout.Zoom;
            btnAccounts.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Location = new Point(70, 400);
            btnAccounts.Margin = new Padding(20);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(177, 150);
            btnAccounts.TabIndex = 0;
            toolTip1.SetToolTip(btnAccounts, "Tài khoản");
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += HandleChangeForm;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(50, 50, 150);
            toolTip1.ForeColor = Color.White;
            toolTip1.OwnerDraw = true;
            toolTip1.Draw += toolTip1_Draw;
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1191, 785);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1560, 1032);
            MinimumSize = new Size(190, 40);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Management System";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContent.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnCurrAccount;
        private Button button2;
        private Button button3;
        private Button btnSignUp;
        private Label lblHeadingPage;
        private Panel panelContent;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnProducts;
        private Button btnEmployees;
        private Button btnCustomers;
        private Button btnPuchaInvoices;
        private Button btnSource;
        private ToolTip toolTip1;
        private Button btnSaleInvoice;
        private Button btnDevices;
        private Button btnLogout;
        private Button btnSearchAll;
        private Button btnTask;
        private Button btnAccounts;
    }
}