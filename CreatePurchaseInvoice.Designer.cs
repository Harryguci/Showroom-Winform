namespace ShowroomData
{
    partial class CreatePurchaseInvoice
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
            txtIdInvoices = new TextBox();
            label2 = new Label();
            txtIdSuppliers = new TextBox();
            label3 = new Label();
            txtIdProducts = new TextBox();
            label5 = new Label();
            dayDateTimePicker = new DateTimePicker();
            panel3 = new Panel();
            lblProductName = new Label();
            lblSourceName = new Label();
            btnCreateSource = new Button();
            btnCreateProduct = new Button();
            btnClean = new Button();
            btnCreate = new Button();
            label6 = new Label();
            label4 = new Label();
            txtStatus = new TextBox();
            txtQuantity = new TextBox();
            txtPurchasePrice = new TextBox();
            label7 = new Label();
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
            flowLayoutPanel1.Controls.Add(btnBack);
            flowLayoutPanel1.Controls.Add(helpBtn);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 807);
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
            panel1.Size = new Size(928, 100);
            panel1.TabIndex = 100;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(928, 33);
            flowLayoutPanel2.TabIndex = 102;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(879, 0);
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
            button2.Location = new Point(830, 0);
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
            lblHeading.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(355, 57);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(239, 31);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Tạo hóa đơn mua";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "ID hóa đơn";
            // 
            // txtIdInvoices
            // 
            txtIdInvoices.Enabled = false;
            txtIdInvoices.Location = new Point(227, 34);
            txtIdInvoices.Multiline = true;
            txtIdInvoices.Name = "txtIdInvoices";
            txtIdInvoices.Size = new Size(374, 35);
            txtIdInvoices.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 104);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 2;
            label2.Text = "ID nhà cung cấp";
            // 
            // txtIdSuppliers
            // 
            txtIdSuppliers.Location = new Point(227, 101);
            txtIdSuppliers.Multiline = true;
            txtIdSuppliers.Name = "txtIdSuppliers";
            txtIdSuppliers.Size = new Size(374, 35);
            txtIdSuppliers.TabIndex = 1;
            txtIdSuppliers.TextChanged += txtIdSuppliers_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 192);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "ID sản phẩm";
            // 
            // txtIdProducts
            // 
            txtIdProducts.Location = new Point(227, 189);
            txtIdProducts.Multiline = true;
            txtIdProducts.Name = "txtIdProducts";
            txtIdProducts.Size = new Size(374, 35);
            txtIdProducts.TabIndex = 2;
            txtIdProducts.TextChanged += txtIdProducts_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 286);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 2;
            label5.Text = "Ngày nhập";
            // 
            // dayDateTimePicker
            // 
            dayDateTimePicker.Format = DateTimePickerFormat.Short;
            dayDateTimePicker.Location = new Point(226, 281);
            dayDateTimePicker.Name = "dayDateTimePicker";
            dayDateTimePicker.Size = new Size(374, 26);
            dayDateTimePicker.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(lblProductName);
            panel3.Controls.Add(lblSourceName);
            panel3.Controls.Add(btnCreateSource);
            panel3.Controls.Add(btnCreateProduct);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(dayDateTimePicker);
            panel3.Controls.Add(txtIdSuppliers);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtIdInvoices);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtPurchasePrice);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtIdProducts);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(208, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(827, 679);
            panel3.TabIndex = 100;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(227, 227);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(51, 20);
            lblProductName.TabIndex = 8;
            lblProductName.Text = "label7";
            lblProductName.Visible = false;
            // 
            // lblSourceName
            // 
            lblSourceName.AutoSize = true;
            lblSourceName.Location = new Point(227, 139);
            lblSourceName.Name = "lblSourceName";
            lblSourceName.Size = new Size(51, 20);
            lblSourceName.TabIndex = 8;
            lblSourceName.Text = "label7";
            lblSourceName.Visible = false;
            // 
            // btnCreateSource
            // 
            btnCreateSource.Location = new Point(616, 102);
            btnCreateSource.Name = "btnCreateSource";
            btnCreateSource.Size = new Size(174, 34);
            btnCreateSource.TabIndex = 7;
            btnCreateSource.Text = "Tạo nhà CC";
            btnCreateSource.UseVisualStyleBackColor = true;
            btnCreateSource.Click += btnCreateSource_Click;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(616, 190);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(174, 34);
            btnCreateProduct.TabIndex = 7;
            btnCreateProduct.Text = "Tạo sản phẩm";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.ActiveCaption;
            btnClean.BackgroundImageLayout = ImageLayout.None;
            btnClean.FlatStyle = FlatStyle.Popup;
            btnClean.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(263, 546);
            btnClean.Margin = new Padding(0);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(121, 38);
            btnClean.TabIndex = 6;
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
            btnCreate.Location = new Point(131, 546);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(121, 38);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 485);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 2;
            label6.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 354);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "Số lượng";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(226, 482);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(374, 35);
            txtStatus.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(226, 351);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(173, 35);
            txtQuantity.TabIndex = 4;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(226, 419);
            txtPurchasePrice.Multiline = true;
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(374, 35);
            txtPurchasePrice.TabIndex = 4;
            txtPurchasePrice.TextChanged += txtPurchasePrice_TextChanged;
            txtPurchasePrice.KeyPress += txtQuantity_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 422);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 2;
            label7.Text = "Giá nhập";
            // 
            // CreatePurchaseInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 807);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreatePurchaseInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Create a invoice";
            Load += PurchaseInvoice_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnBack;
        private Label label1;
        private TextBox txtIdInvoices;
        private Label label2;
        private TextBox txtIdSuppliers;
        private Label label3;
        private TextBox txtIdProducts;
        private Label label5;
        private DateTimePicker dayDateTimePicker;
        private Panel panel3;
        private Button btnCreate;
        private Label lblHeading;
        private Button btnClean;
        private Button helpBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label4;
        private TextBox txtStatus;
        private TextBox txtQuantity;
        private Button btnCreateSource;
        private Button btnCreateProduct;
        private Label lblProductName;
        private Label lblSourceName;
        private Label label7;
        private TextBox txtPurchasePrice;
    }
}