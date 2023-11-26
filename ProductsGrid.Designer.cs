namespace ShowroomData
{
    partial class ProductsGrid
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            panel1 = new Panel();
            btnBack = new Button();
            btnShowList = new Button();
            btnSearch = new Button();
            btnReset = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtPurchasePriceMax = new TextBox();
            txtSalePriceMax = new TextBox();
            label6 = new Label();
            label4 = new Label();
            txtPurchasePriceMin = new TextBox();
            label5 = new Label();
            txtSalePriceMin = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(206, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1062, 815);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1054, 787);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tất cả";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1166, 787);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1054, 787);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mercedes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1054, 787);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Toyota";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1054, 787);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Ford";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1054, 787);
            tabPage5.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnShowList);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPurchasePriceMax);
            panel1.Controls.Add(txtSalePriceMax);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPurchasePriceMin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSalePriceMin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 815);
            panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 50, 150);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 749);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 57);
            btnBack.TabIndex = 5;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowList
            // 
            btnShowList.BackColor = Color.FromArgb(50, 50, 150);
            btnShowList.FlatAppearance.BorderSize = 0;
            btnShowList.FlatStyle = FlatStyle.Flat;
            btnShowList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowList.ForeColor = Color.White;
            btnShowList.Location = new Point(0, 692);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(200, 57);
            btnShowList.TabIndex = 5;
            btnShowList.Text = "Danh sách";
            btnShowList.UseVisualStyleBackColor = false;
            btnShowList.Click += button3_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(50, 50, 150);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(96, 639);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(50, 50, 150);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(12, 639);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 34);
            btnReset.TabIndex = 4;
            btnReset.Text = "Đặt lại";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Trắng", "Đen", "Đỏ", "Vàng", "Cam", "Xanh dương", "Xanh lá" });
            comboBox1.Location = new Point(12, 307);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 23);
            comboBox1.TabIndex = 3;
            comboBox1.TextChanged += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 283);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 1;
            label2.Text = "Màu";
            // 
            // txtPurchasePriceMax
            // 
            txtPurchasePriceMax.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPurchasePriceMax.Location = new Point(12, 595);
            txtPurchasePriceMax.Name = "txtPurchasePriceMax";
            txtPurchasePriceMax.Size = new Size(169, 23);
            txtPurchasePriceMax.TabIndex = 2;
            txtPurchasePriceMax.TextChanged += btnSearch_Click;
            // 
            // txtSalePriceMax
            // 
            txtSalePriceMax.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalePriceMax.Location = new Point(12, 450);
            txtSalePriceMax.Name = "txtSalePriceMax";
            txtSalePriceMax.Size = new Size(169, 23);
            txtSalePriceMax.TabIndex = 2;
            txtSalePriceMax.TextChanged += btnSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 560);
            label6.Name = "label6";
            label6.Size = new Size(134, 21);
            label6.TabIndex = 1;
            label6.Text = "Giá nhập lớn nhất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 415);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 1;
            label4.Text = "Giá bán lớn nhất";
            // 
            // txtPurchasePriceMin
            // 
            txtPurchasePriceMin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPurchasePriceMin.Location = new Point(12, 526);
            txtPurchasePriceMin.Name = "txtPurchasePriceMin";
            txtPurchasePriceMin.Size = new Size(169, 23);
            txtPurchasePriceMin.TabIndex = 2;
            txtPurchasePriceMin.TextChanged += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 491);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 1;
            label5.Text = "Giá nhập nhỏ nhất";
            // 
            // txtSalePriceMin
            // 
            txtSalePriceMin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalePriceMin.Location = new Point(12, 381);
            txtSalePriceMin.Name = "txtSalePriceMin";
            txtSalePriceMin.Size = new Size(169, 23);
            txtSalePriceMin.TabIndex = 2;
            txtSalePriceMin.TextChanged += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 346);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 1;
            label3.Text = "Giá bán nhỏ nhất";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 209);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ProductsGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 815);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "ProductsGrid";
            Text = "ProductsGrid";
            Load += ProductsGrid_Load;
            Resize += ProductsGrid_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtSalePriceMin;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Button btnReset;
        private Button btnSearch;
        private Button btnShowList;
        private Button btnBack;
        private TextBox txtSalePriceMax;
        private Label label4;
        private TextBox txtPurchasePriceMax;
        private Label label6;
        private TextBox txtPurchasePriceMin;
        private Label label5;
    }
}