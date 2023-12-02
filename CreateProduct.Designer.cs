namespace ShowroomData
{
    partial class CreateProduct
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
            txtNameProduct = new TextBox();
            label2 = new Label();
            txtIdProduct = new TextBox();
            label3 = new Label();
            txtPurchasePrice = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            btnAddImage = new Button();
            btnDeleteImage = new Button();
            btnChangeImage = new Button();
            btnNextImage = new Button();
            btnBackImage = new Button();
            pictureProductImage = new PictureBox();
            btnClean = new Button();
            btnCreate = new Button();
            label6 = new Label();
            label4 = new Label();
            txtStatus = new TextBox();
            txtQuantity = new TextBox();
            txtSalePrice = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProductImage).BeginInit();
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
            btnBack.Click += btnBack_Click_1;
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
            helpBtn.Click += helpBtn_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(lblHeading);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 100);
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
            flowLayoutPanel2.Size = new Size(1090, 33);
            flowLayoutPanel2.TabIndex = 102;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(1041, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(49, 33);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(992, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(49, 33);
            button2.TabIndex = 0;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(355, 57);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(252, 31);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Tạo sản phẩm mới";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên sản phẩm";
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(227, 34);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(374, 26);
            txtNameProduct.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 104);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã sản phẩm";
            // 
            // txtIdProduct
            // 
            txtIdProduct.Enabled = false;
            txtIdProduct.Location = new Point(227, 101);
            txtIdProduct.Name = "txtIdProduct";
            txtIdProduct.Size = new Size(374, 26);
            txtIdProduct.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 174);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá mua";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(227, 171);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(374, 26);
            txtPurchasePrice.TabIndex = 2;
            txtPurchasePrice.TextChanged += txtPurchasePrice_TextChanged;
            txtPurchasePrice.KeyPress += txtPurchasePrice_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 245);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 2;
            label5.Text = "Giá bán";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(btnAddImage);
            panel3.Controls.Add(btnDeleteImage);
            panel3.Controls.Add(btnChangeImage);
            panel3.Controls.Add(btnNextImage);
            panel3.Controls.Add(btnBackImage);
            panel3.Controls.Add(pictureProductImage);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(txtIdProduct);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtNameProduct);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtSalePrice);
            panel3.Controls.Add(txtPurchasePrice);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(195, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(1004, 512);
            panel3.TabIndex = 100;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.FromArgb(50, 50, 150);
            btnAddImage.FlatAppearance.BorderSize = 0;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddImage.ForeColor = Color.White;
            btnAddImage.Location = new Point(667, 408);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(103, 34);
            btnAddImage.TabIndex = 10;
            btnAddImage.Text = "Thêm";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnDeleteImage
            // 
            btnDeleteImage.BackColor = SystemColors.ScrollBar;
            btnDeleteImage.FlatAppearance.BorderSize = 0;
            btnDeleteImage.FlatStyle = FlatStyle.Flat;
            btnDeleteImage.ForeColor = Color.White;
            btnDeleteImage.Location = new Point(885, 408);
            btnDeleteImage.Name = "btnDeleteImage";
            btnDeleteImage.Size = new Size(97, 34);
            btnDeleteImage.TabIndex = 10;
            btnDeleteImage.Text = "Xóa";
            btnDeleteImage.UseVisualStyleBackColor = false;
            btnDeleteImage.Click += btnDeleteImage_Click;
            // 
            // btnChangeImage
            // 
            btnChangeImage.BackColor = Color.FromArgb(50, 50, 150);
            btnChangeImage.FlatAppearance.BorderSize = 0;
            btnChangeImage.FlatStyle = FlatStyle.Flat;
            btnChangeImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeImage.ForeColor = Color.White;
            btnChangeImage.Location = new Point(776, 408);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Size = new Size(103, 34);
            btnChangeImage.TabIndex = 10;
            btnChangeImage.Text = "Đổi ảnh";
            btnChangeImage.UseVisualStyleBackColor = false;
            btnChangeImage.Click += btnChangeImage_Click;
            // 
            // btnNextImage
            // 
            btnNextImage.BackColor = Color.White;
            btnNextImage.FlatAppearance.BorderSize = 0;
            btnNextImage.FlatStyle = FlatStyle.Flat;
            btnNextImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextImage.Location = new Point(958, 186);
            btnNextImage.Name = "btnNextImage";
            btnNextImage.Size = new Size(24, 60);
            btnNextImage.TabIndex = 9;
            btnNextImage.Text = ">";
            btnNextImage.UseVisualStyleBackColor = false;
            btnNextImage.Click += btnNextImage_Click;
            // 
            // btnBackImage
            // 
            btnBackImage.BackColor = Color.White;
            btnBackImage.FlatAppearance.BorderSize = 0;
            btnBackImage.FlatStyle = FlatStyle.Flat;
            btnBackImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackImage.Location = new Point(667, 186);
            btnBackImage.Name = "btnBackImage";
            btnBackImage.Size = new Size(24, 60);
            btnBackImage.TabIndex = 9;
            btnBackImage.Text = "<";
            btnBackImage.UseVisualStyleBackColor = false;
            btnBackImage.Click += btnBackImage_Click;
            // 
            // pictureProductImage
            // 
            pictureProductImage.BackColor = Color.White;
            pictureProductImage.Location = new Point(667, 34);
            pictureProductImage.Name = "pictureProductImage";
            pictureProductImage.Size = new Size(315, 368);
            pictureProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProductImage.TabIndex = 8;
            pictureProductImage.TabStop = false;
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
            btnClean.TabIndex = 7;
            btnClean.Text = "Nhập mới";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click_1;
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
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 382);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 2;
            label6.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 313);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "Số lượng";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(227, 379);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(374, 26);
            txtStatus.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(227, 310);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(173, 26);
            txtQuantity.TabIndex = 4;
            txtQuantity.KeyPress += txtQuantity_KeyPress_1;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Enabled = false;
            txtSalePrice.Location = new Point(227, 242);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(374, 26);
            txtSalePrice.TabIndex = 3;
            txtSalePrice.KeyPress += txtSalePrice_KeyPress;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 640);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Create a product";
            Load += Product_Load_1;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnBack;
        private Label label1;
        private TextBox txtNameProduct;
        private Label label2;
        private TextBox txtIdProduct;
        private Label label3;
        private TextBox txtPurchasePrice;
        private Label label5;
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
        private TextBox txtSalePrice;
        private Button btnBackImage;
        private PictureBox pictureProductImage;
        private Button btnAddImage;
        private Button btnDeleteImage;
        private Button btnChangeImage;
        private Button btnNextImage;
    }
}