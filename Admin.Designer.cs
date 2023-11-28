namespace ShowroomData
{
    partial class Admin
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
            panel2 = new Panel();
            lblHeadingPage = new Label();
            customer = new Button();
            product = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            target = new Button();
            testDrive = new Button();
            source = new Button();
            purchaseInvoice = new Button();
            saleInvoice = new Button();
            device = new Button();
            employee = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblHeadingPage);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(215, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 110);
            panel2.TabIndex = 1;
            // 
            // lblHeadingPage
            // 
            lblHeadingPage.AutoSize = true;
            lblHeadingPage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeadingPage.Location = new Point(405, 44);
            lblHeadingPage.Name = "lblHeadingPage";
            lblHeadingPage.Size = new Size(150, 37);
            lblHeadingPage.TabIndex = 0;
            lblHeadingPage.Text = "Welcome";
            // 
            // customer
            // 
            customer.BackColor = Color.FromArgb(50, 50, 150);
            customer.Dock = DockStyle.Top;
            customer.FlatAppearance.BorderSize = 0;
            customer.FlatStyle = FlatStyle.Flat;
            customer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customer.ForeColor = Color.White;
            customer.Location = new Point(0, 50);
            customer.Name = "customer";
            customer.Size = new Size(209, 50);
            customer.TabIndex = 0;
            customer.Text = "Khách hàng";
            customer.UseVisualStyleBackColor = false;
            customer.Click += customer_Click;
            // 
            // product
            // 
            product.BackColor = Color.FromArgb(50, 50, 150);
            product.Dock = DockStyle.Top;
            product.FlatAppearance.BorderSize = 0;
            product.FlatStyle = FlatStyle.Flat;
            product.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            product.ForeColor = Color.White;
            product.Location = new Point(0, 150);
            product.Name = "product";
            product.Size = new Size(209, 50);
            product.TabIndex = 0;
            product.Text = "Sản phẩm";
            product.UseVisualStyleBackColor = false;
            product.Click += product_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 129);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(52, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(215, 648);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(target);
            panel3.Controls.Add(testDrive);
            panel3.Controls.Add(source);
            panel3.Controls.Add(purchaseInvoice);
            panel3.Controls.Add(saleInvoice);
            panel3.Controls.Add(product);
            panel3.Controls.Add(device);
            panel3.Controls.Add(customer);
            panel3.Controls.Add(employee);
            panel3.Location = new Point(3, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 501);
            panel3.TabIndex = 1;
            // 
            // target
            // 
            target.BackColor = Color.FromArgb(50, 50, 150);
            target.Dock = DockStyle.Top;
            target.FlatAppearance.BorderSize = 0;
            target.FlatStyle = FlatStyle.Flat;
            target.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            target.ForeColor = Color.White;
            target.Location = new Point(0, 401);
            target.Name = "target";
            target.Size = new Size(209, 50);
            target.TabIndex = 0;
            target.Text = "Mục tiêu";
            target.UseVisualStyleBackColor = false;
            target.Click += target_Click;
            // 
            // testDrive
            // 
            testDrive.BackColor = Color.FromArgb(50, 50, 150);
            testDrive.Dock = DockStyle.Top;
            testDrive.FlatAppearance.BorderSize = 0;
            testDrive.FlatStyle = FlatStyle.Flat;
            testDrive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            testDrive.ForeColor = Color.White;
            testDrive.Location = new Point(0, 351);
            testDrive.Name = "testDrive";
            testDrive.Size = new Size(209, 50);
            testDrive.TabIndex = 0;
            testDrive.Text = "Lái thử";
            testDrive.UseVisualStyleBackColor = false;
            testDrive.Click += testDrive_Click;
            // 
            // source
            // 
            source.BackColor = Color.FromArgb(50, 50, 150);
            source.Dock = DockStyle.Top;
            source.FlatAppearance.BorderSize = 0;
            source.FlatStyle = FlatStyle.Flat;
            source.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            source.ForeColor = Color.White;
            source.Location = new Point(0, 301);
            source.Name = "source";
            source.Size = new Size(209, 50);
            source.TabIndex = 0;
            source.Text = "Nguồn";
            source.UseVisualStyleBackColor = false;
            source.Click += source_Click;
            // 
            // purchaseInvoice
            // 
            purchaseInvoice.BackColor = Color.FromArgb(50, 50, 150);
            purchaseInvoice.Dock = DockStyle.Top;
            purchaseInvoice.FlatAppearance.BorderSize = 0;
            purchaseInvoice.FlatStyle = FlatStyle.Flat;
            purchaseInvoice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseInvoice.ForeColor = Color.White;
            purchaseInvoice.Location = new Point(0, 250);
            purchaseInvoice.Name = "purchaseInvoice";
            purchaseInvoice.Size = new Size(209, 51);
            purchaseInvoice.TabIndex = 0;
            purchaseInvoice.Text = "Hóa đơn mua";
            purchaseInvoice.UseVisualStyleBackColor = false;
            purchaseInvoice.Click += purchaseInvoice_Click;
            // 
            // saleInvoice
            // 
            saleInvoice.BackColor = Color.FromArgb(50, 50, 150);
            saleInvoice.Dock = DockStyle.Top;
            saleInvoice.FlatAppearance.BorderSize = 0;
            saleInvoice.FlatStyle = FlatStyle.Flat;
            saleInvoice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saleInvoice.ForeColor = Color.White;
            saleInvoice.Location = new Point(0, 200);
            saleInvoice.Name = "saleInvoice";
            saleInvoice.Size = new Size(209, 50);
            saleInvoice.TabIndex = 0;
            saleInvoice.Text = "Hóa đơn bán";
            saleInvoice.UseVisualStyleBackColor = false;
            saleInvoice.Click += saleInvoice_Click;
            // 
            // device
            // 
            device.BackColor = Color.FromArgb(50, 50, 150);
            device.Dock = DockStyle.Top;
            device.FlatAppearance.BorderSize = 0;
            device.FlatStyle = FlatStyle.Flat;
            device.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            device.ForeColor = Color.White;
            device.Location = new Point(0, 100);
            device.Name = "device";
            device.Size = new Size(209, 50);
            device.TabIndex = 0;
            device.Text = "Thiết bị";
            device.UseVisualStyleBackColor = false;
            device.Click += device_Click;
            // 
            // employee
            // 
            employee.BackColor = Color.FromArgb(50, 50, 150);
            employee.Dock = DockStyle.Top;
            employee.FlatAppearance.BorderSize = 0;
            employee.FlatStyle = FlatStyle.Flat;
            employee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employee.ForeColor = Color.White;
            employee.Location = new Point(0, 0);
            employee.Name = "employee";
            employee.Size = new Size(209, 50);
            employee.TabIndex = 0;
            employee.Text = "Nhân viên";
            employee.UseVisualStyleBackColor = false;
            employee.Click += employee_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1149, 648);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Admin";
            Text = "Showroom - Trang chủ";
            FormClosing += Admin_FormClosing;
            Resize += Admin_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Button customer;
        private Button product;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button employee;
        private Button device;
        private Button button4;
        private Button saleInvoice;
        private Button source;
        private Button purchaseInvoice;
        private Button testDrive;
        private Label lblHeadingPage;
        private Button target;
    }
}