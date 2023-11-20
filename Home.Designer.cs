namespace ShowroomData
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            lblHeadingPage = new Label();
            panelContent = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnProducts = new Button();
            btnEmployees = new Button();
            btnCustomers = new Button();
            btnInvoices = new Button();
            btnServices = new Button();
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
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 599);
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
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
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
            button2.Text = "Tạo mới";
            button2.UseVisualStyleBackColor = true;
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
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(50, 50, 150);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 311);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(136, 51);
            button4.TabIndex = 5;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblHeadingPage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 179);
            panel1.TabIndex = 1;
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
            panelContent.Size = new Size(964, 420);
            panelContent.TabIndex = 2;
            panelContent.Resize += panelContent_Resize;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnProducts);
            flowLayoutPanel2.Controls.Add(btnEmployees);
            flowLayoutPanel2.Controls.Add(btnCustomers);
            flowLayoutPanel2.Controls.Add(btnInvoices);
            flowLayoutPanel2.Controls.Add(btnServices);
            flowLayoutPanel2.Location = new Point(42, 30);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(891, 369);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnProducts
            // 
            btnProducts.AllowDrop = true;
            btnProducts.BackgroundImage = Properties.Resources.product;
            btnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducts.ForeColor = SystemColors.ButtonHighlight;
            btnProducts.ImageAlign = ContentAlignment.TopCenter;
            btnProducts.Location = new Point(20, 20);
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
            btnEmployees.Location = new Point(237, 20);
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
            btnCustomers.Location = new Point(454, 20);
            btnCustomers.Margin = new Padding(20);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(177, 150);
            btnCustomers.TabIndex = 0;
            toolTip1.SetToolTip(btnCustomers, "Khách hàng");
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += HandleChangeForm;
            // 
            // btnInvoices
            // 
            btnInvoices.BackgroundImage = Properties.Resources.invoices;
            btnInvoices.BackgroundImageLayout = ImageLayout.Zoom;
            btnInvoices.FlatAppearance.BorderSize = 0;
            btnInvoices.FlatStyle = FlatStyle.Flat;
            btnInvoices.Location = new Point(671, 20);
            btnInvoices.Margin = new Padding(20);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(177, 150);
            btnInvoices.TabIndex = 0;
            toolTip1.SetToolTip(btnInvoices, "Hóa đơn");
            btnInvoices.UseVisualStyleBackColor = true;
            btnInvoices.Click += HandleChangeForm;
            // 
            // btnServices
            // 
            btnServices.BackgroundImage = Properties.Resources.sources;
            btnServices.BackgroundImageLayout = ImageLayout.Zoom;
            btnServices.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnServices.FlatAppearance.BorderSize = 0;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Location = new Point(20, 210);
            btnServices.Margin = new Padding(20);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(177, 150);
            btnServices.TabIndex = 0;
            toolTip1.SetToolTip(btnServices, "Nguồn cung");
            btnServices.UseVisualStyleBackColor = true;
            btnServices.Click += HandleChangeForm;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.DeepSkyBlue;
            toolTip1.ForeColor = Color.White;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1100, 599);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Home";
            Text = "Showroom - Management System";
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblHeadingPage;
        private Panel panelContent;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnProducts;
        private Button btnEmployees;
        private Button btnCustomers;
        private Button btnInvoices;
        private Button btnServices;
        private ToolTip toolTip1;
    }
}