namespace ShowroomData
{
    partial class CreateSaleInvoice
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
            txtIdClients = new TextBox();
            label3 = new Label();
            txtIdProducts = new TextBox();
            label5 = new Label();
            dayDateTimePicker = new DateTimePicker();
            panel3 = new Panel();
            button6 = new Button();
            button4 = new Button();
            button7 = new Button();
            button3 = new Button();
            button5 = new Button();
            btnCreateCustomer = new Button();
            lblProductName = new Label();
            lblEmployeeName = new Label();
            lblCustomerName = new Label();
            btnClean = new Button();
            btnCreate = new Button();
            label6 = new Label();
            label4 = new Label();
            txtStatus = new TextBox();
            txtQuantity = new TextBox();
            txtIdEmployee = new TextBox();
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
            flowLayoutPanel1.Size = new Size(136, 753);
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
            panel1.Size = new Size(1138, 100);
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
            flowLayoutPanel2.Size = new Size(1138, 33);
            flowLayoutPanel2.TabIndex = 102;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(1089, 0);
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
            button2.Location = new Point(1040, 0);
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
            lblHeading.Size = new Size(232, 31);
            lblHeading.TabIndex = 100;
            lblHeading.Text = "Tạo hóa đơn bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "ID hóa đơn";
            // 
            // txtIdInvoices
            // 
            txtIdInvoices.Enabled = false;
            txtIdInvoices.Location = new Point(212, 30);
            txtIdInvoices.Multiline = true;
            txtIdInvoices.Name = "txtIdInvoices";
            txtIdInvoices.Size = new Size(389, 26);
            txtIdInvoices.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 97);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "ID khách hàng";
            // 
            // txtIdClients
            // 
            txtIdClients.Location = new Point(212, 94);
            txtIdClients.Multiline = true;
            txtIdClients.Name = "txtIdClients";
            txtIdClients.Size = new Size(389, 26);
            txtIdClients.TabIndex = 1;
            txtIdClients.TextChanged += txtIdClients_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 269);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "ID sản phẩm";
            // 
            // txtIdProducts
            // 
            txtIdProducts.Location = new Point(212, 266);
            txtIdProducts.Multiline = true;
            txtIdProducts.Name = "txtIdProducts";
            txtIdProducts.Size = new Size(389, 26);
            txtIdProducts.TabIndex = 3;
            txtIdProducts.TextChanged += txtIdProducts_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 362);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 2;
            label5.Text = "Ngày nhập";
            // 
            // dayDateTimePicker
            // 
            dayDateTimePicker.Format = DateTimePickerFormat.Short;
            dayDateTimePicker.Location = new Point(212, 357);
            dayDateTimePicker.Name = "dayDateTimePicker";
            dayDateTimePicker.Size = new Size(389, 26);
            dayDateTimePicker.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(btnCreateCustomer);
            panel3.Controls.Add(lblProductName);
            panel3.Controls.Add(lblEmployeeName);
            panel3.Controls.Add(lblCustomerName);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(dayDateTimePicker);
            panel3.Controls.Add(txtIdClients);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtIdInvoices);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtIdEmployee);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtIdProducts);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(236, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 625);
            panel3.TabIndex = 100;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.BackgroundImage = Properties.Resources.magnifying_glass;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(653, 270);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.BackgroundImage = Properties.Resources.tabs;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(612, 269);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.BackgroundImage = Properties.Resources.magnifying_glass;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(653, 188);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImage = Properties.Resources.user_avatar;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(607, 183);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.BackgroundImage = Properties.Resources.magnifying_glass;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(653, 99);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.BackColor = SystemColors.Control;
            btnCreateCustomer.BackgroundImage = Properties.Resources.user_avatar;
            btnCreateCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreateCustomer.FlatAppearance.BorderSize = 0;
            btnCreateCustomer.FlatStyle = FlatStyle.Flat;
            btnCreateCustomer.Location = new Point(607, 94);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(40, 40);
            btnCreateCustomer.TabIndex = 8;
            btnCreateCustomer.UseVisualStyleBackColor = false;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(212, 306);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(51, 20);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "label8";
            lblProductName.Visible = false;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(212, 219);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(51, 20);
            lblEmployeeName.TabIndex = 7;
            lblEmployeeName.Text = "label8";
            lblEmployeeName.Visible = false;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(212, 130);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(51, 20);
            lblCustomerName.TabIndex = 7;
            lblCustomerName.Text = "label8";
            lblCustomerName.Visible = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.ActiveCaption;
            btnClean.BackgroundImageLayout = ImageLayout.None;
            btnClean.FlatStyle = FlatStyle.Popup;
            btnClean.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(264, 570);
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
            btnCreate.Location = new Point(132, 570);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(121, 38);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 484);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 2;
            label6.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 421);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "Số lượng";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(212, 481);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(389, 26);
            txtStatus.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(212, 421);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(173, 26);
            txtQuantity.TabIndex = 5;
            txtQuantity.KeyPress += txtQuantity_KeyPress_1;
            // 
            // txtIdEmployee
            // 
            txtIdEmployee.Location = new Point(212, 180);
            txtIdEmployee.Multiline = true;
            txtIdEmployee.Name = "txtIdEmployee";
            txtIdEmployee.Size = new Size(389, 26);
            txtIdEmployee.TabIndex = 2;
            txtIdEmployee.TextChanged += txtIdEmployee_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 183);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 2;
            label7.Text = "ID nhân viên";
            // 
            // CreateSaleInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 753);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateSaleInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showroom - Create a invoice";
            Load += SaleInvoice_Load;
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
        private TextBox txtIdClients;
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
        private TextBox txtIdEmployee;
        private Label label7;
        private Label lblProductName;
        private Label lblEmployeeName;
        private Label lblCustomerName;
        private Button btnCreateCustomer;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button5;
    }
}