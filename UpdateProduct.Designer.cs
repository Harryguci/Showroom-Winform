using ShowroomData.ComponentGUI;

namespace ShowroomData
{
    partial class UpdateProduct
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
            txtName = new RoundTextBox();
            panel3 = new Panel();
            btnImageNext = new Button();
            btnImageBack = new Button();
            btnAddImage = new Button();
            button3 = new Button();
            btnChangeImage = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            btnClean = new Button();
            btnCreate = new Button();
            txtQuantity = new RoundTextBox();
            txtStatus = new RoundTextBox();
            txtSalePrice = new RoundTextBox();
            txtPurchasePrice = new RoundTextBox();
            txtId = new RoundTextBox();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            btnBack.Click += btnBack_Click_2;
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
            panel1.Size = new Size(1085, 100);
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
            flowLayoutPanel2.Size = new Size(1085, 33);
            flowLayoutPanel2.TabIndex = 101;
            flowLayoutPanel2.MouseDown += Form_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(1036, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(49, 33);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(987, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(49, 33);
            button2.TabIndex = 0;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(336, 46);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(321, 37);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Thông tin sản phẩm";
            lblHeading.MouseDown += Form_MouseDown;
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
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderRadius = 5;
            txtName.Location = new Point(211, 34);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(387, 36);
            txtName.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(btnImageNext);
            panel3.Controls.Add(btnImageBack);
            panel3.Controls.Add(btnAddImage);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnChangeImage);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtSalePrice);
            panel3.Controls.Add(txtPurchasePrice);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(182, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(1010, 512);
            panel3.TabIndex = 100;
            panel3.MouseDown += Form_MouseDown;
            // 
            // btnImageNext
            // 
            btnImageNext.FlatAppearance.BorderSize = 0;
            btnImageNext.FlatStyle = FlatStyle.Flat;
            btnImageNext.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImageNext.Location = new Point(943, 172);
            btnImageNext.Name = "btnImageNext";
            btnImageNext.Size = new Size(29, 56);
            btnImageNext.TabIndex = 9;
            btnImageNext.Text = ">";
            btnImageNext.UseVisualStyleBackColor = false;
            btnImageNext.Click += btnNext_Click;
            // 
            // btnImageBack
            // 
            btnImageBack.FlatAppearance.BorderSize = 0;
            btnImageBack.FlatStyle = FlatStyle.Flat;
            btnImageBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImageBack.Location = new Point(654, 172);
            btnImageBack.Name = "btnImageBack";
            btnImageBack.Size = new Size(29, 56);
            btnImageBack.TabIndex = 9;
            btnImageBack.Text = "<";
            btnImageBack.UseVisualStyleBackColor = false;
            btnImageBack.Click += btnBack_Click;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.FromArgb(50, 50, 150);
            btnAddImage.FlatAppearance.BorderSize = 0;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddImage.ForeColor = Color.White;
            btnAddImage.Location = new Point(776, 418);
            btnAddImage.Margin = new Padding(0);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(112, 36);
            btnAddImage.TabIndex = 8;
            btnAddImage.Text = "Thêm";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(898, 418);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(74, 36);
            button3.TabIndex = 8;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDelete_Click;
            // 
            // btnChangeImage
            // 
            btnChangeImage.BackColor = Color.FromArgb(50, 50, 150);
            btnChangeImage.FlatAppearance.BorderSize = 0;
            btnChangeImage.FlatStyle = FlatStyle.Flat;
            btnChangeImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeImage.ForeColor = Color.White;
            btnChangeImage.Location = new Point(654, 418);
            btnChangeImage.Margin = new Padding(0);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Size = new Size(112, 36);
            btnChangeImage.TabIndex = 8;
            btnChangeImage.Text = "Đổi ảnh";
            btnChangeImage.UseVisualStyleBackColor = false;
            btnChangeImage.Click += btnChangeImage_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Location = new Point(654, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(318, 370);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 381);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 1;
            label4.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 311);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 1;
            label5.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 244);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 1;
            label3.Text = "Giá bán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 172);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá mua";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 104);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 1;
            label9.Text = "Mã sản phẩm";
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.ActiveCaption;
            btnClean.BackgroundImageLayout = ImageLayout.None;
            btnClean.FlatAppearance.BorderSize = 0;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(264, 454);
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
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(132, 454);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(121, 38);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Lưu";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.BorderRadius = 5;
            txtQuantity.Enabled = false;
            txtQuantity.Location = new Point(211, 308);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(156, 36);
            txtQuantity.TabIndex = 4;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.White;
            txtStatus.BorderRadius = 5;
            txtStatus.Location = new Point(211, 378);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(387, 36);
            txtStatus.TabIndex = 5;
            // 
            // txtSalePrice
            // 
            txtSalePrice.BackColor = Color.White;
            txtSalePrice.BorderRadius = 5;
            txtSalePrice.Location = new Point(211, 241);
            txtSalePrice.Multiline = true;
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(387, 36);
            txtSalePrice.TabIndex = 3;
            txtSalePrice.KeyPress += txtSalePrice_KeyPress;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.BackColor = Color.White;
            txtPurchasePrice.BorderRadius = 5;
            txtPurchasePrice.Location = new Point(211, 169);
            txtPurchasePrice.Multiline = true;
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(387, 36);
            txtPurchasePrice.TabIndex = 2;
            txtPurchasePrice.TextChanged += txtPurchasePrice_TextChanged;
            txtPurchasePrice.KeyPress += txtPurchasePrice_KeyPress;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderRadius = 5;
            txtId.Enabled = false;
            txtId.Location = new Point(211, 101);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(387, 36);
            txtId.TabIndex = 1;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 640);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Update a product";
            Load += UpdateProduct_Load;
            MouseDown += Form_MouseDown;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnBack;
        private Label label1;
        private Panel panel3;
        private Button btnCreate;
        private Label lblHeading;
        private Button btnClean;
        private Label label9;
        private Button helpBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnChangeImage;
        private Button btnImageNext;
        private Button btnImageBack;
        private RoundTextBox txtName;
        private RoundTextBox txtStatus;
        private RoundTextBox txtQuantity;
        private RoundTextBox txtSalePrice;
        private RoundTextBox txtPurchasePrice;
        private RoundTextBox txtId;
        private Button btnAddImage;
        private Button button3;
    }
}