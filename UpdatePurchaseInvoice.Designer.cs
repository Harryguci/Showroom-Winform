﻿namespace ShowroomData
{
    partial class UpdatePurchaseInvoice
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
            txtIdInvoice = new TextBox();
            panel3 = new Panel();
            dayDateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label9 = new Label();
            btnClean = new Button();
            btnCreate = new Button();
            txtQuantity = new TextBox();
            txtStatus = new TextBox();
            txtIdProduct = new TextBox();
            txtIdSupplier = new TextBox();
            txtPurchasePrice = new TextBox();
            label6 = new Label();
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
            flowLayoutPanel2.TabIndex = 101;
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
            button1.Click += button1_Click_1;
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
            button2.Click += button2_Click_1;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(315, 46);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(372, 37);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Thông tin hóa đơn mua";
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
            // txtIdInvoice
            // 
            txtIdInvoice.Enabled = false;
            txtIdInvoice.Location = new Point(233, 34);
            txtIdInvoice.Name = "txtIdInvoice";
            txtIdInvoice.Size = new Size(368, 26);
            txtIdInvoice.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(dayDateTimePicker);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtPurchasePrice);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtIdProduct);
            panel3.Controls.Add(txtIdSupplier);
            panel3.Controls.Add(txtIdInvoice);
            panel3.Location = new Point(286, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 512);
            panel3.TabIndex = 100;
            // 
            // dayDateTimePicker
            // 
            dayDateTimePicker.Format = DateTimePickerFormat.Short;
            dayDateTimePicker.Location = new Point(233, 240);
            dayDateTimePicker.Name = "dayDateTimePicker";
            dayDateTimePicker.Size = new Size(368, 26);
            dayDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 245);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 11;
            label3.Text = "Ngày nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 400);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 1;
            label4.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 301);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 1;
            label5.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 172);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "ID sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 104);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 1;
            label9.Text = "ID nhà cung cấp";
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
            btnClean.TabIndex = 6;
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
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Lưu";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(233, 301);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(156, 26);
            txtQuantity.TabIndex = 4;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(233, 397);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(368, 26);
            txtStatus.TabIndex = 5;
            // 
            // txtIdProduct
            // 
            txtIdProduct.Location = new Point(233, 169);
            txtIdProduct.Name = "txtIdProduct";
            txtIdProduct.Size = new Size(368, 26);
            txtIdProduct.TabIndex = 2;
            // 
            // txtIdSupplier
            // 
            txtIdSupplier.Location = new Point(233, 101);
            txtIdSupplier.Name = "txtIdSupplier";
            txtIdSupplier.Size = new Size(368, 26);
            txtIdSupplier.TabIndex = 1;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(233, 345);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(368, 26);
            txtPurchasePrice.TabIndex = 4;
            txtPurchasePrice.KeyPress += txtQuantity_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 345);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 1;
            label6.Text = "Giá nhập";
            // 
            // UpdatePurchaseInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 640);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UpdatePurchaseInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Update a invoice";
            Load += UpdatePurchaseInvoice_Load;
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
        private TextBox txtIdInvoice;
        private Panel panel3;
        private Button btnCreate;
        private Label lblHeading;
        private Button btnClean;
        private TextBox txtStatus;
        private Label label9;
        private Button helpBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox txtQuantity;
        private Label label2;
        private Label label5;
        private TextBox txtIdSupplier;
        private DateTimePicker dayDateTimePicker;
        private Label label3;
        private TextBox txtIdProduct;
        private Label label6;
        private TextBox txtPurchasePrice;
    }
}