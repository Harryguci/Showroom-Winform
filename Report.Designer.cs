using ShowroomData.ComponentGUI;

namespace ShowroomData
{
    partial class Report
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
            panel1 = new Panel();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            txtYear = new RoundTextBox();
            label3 = new Label();
            btnExportExcel = new Button();
            btnReset = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnChangeMonth = new Button();
            btnChange3Months = new Button();
            btnChangeYear = new Button();
            btnChangeEmployee = new Button();
            btnChangeSource = new Button();
            txtEmployeeQuery = new RoundTextBox();
            lblEmployeeName = new Label();
            txtMonth = new RoundTextBox();
            lblMonth = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 150);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 138);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackgroundImage = Properties.Resources.pngaaa_com_4834605;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(1143, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 40);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(515, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(50, 50, 200);
            lblTitle.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 164);
            lblTitle.Margin = new Padding(10);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(1213, 51);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "BÁO CÁO";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1111, 518);
            dataGridView1.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.FromArgb(50, 50, 200);
            txtYear.BorderRadius = 3;
            txtYear.BorderStyle = BorderStyle.None;
            txtYear.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtYear.ForeColor = Color.White;
            txtYear.Location = new Point(434, 228);
            txtYear.Margin = new Padding(10, 15, 10, 15);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 35);
            txtYear.TabIndex = 4;
            txtYear.TextAlign = HorizontalAlignment.Center;
            txtYear.TextChanged += txtMonthYear_TextChanged;
            txtYear.KeyPress += txtMonthYear_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(386, 235);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 5;
            label3.Text = "Năm";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportExcel.BackColor = Color.FromArgb(50, 50, 200);
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(1047, 227);
            btnExportExcel.Margin = new Padding(0);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(109, 35);
            btnExportExcel.TabIndex = 6;
            btnExportExcel.Text = "Xuất File";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.BackColor = SystemColors.ScrollBar;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(919, 227);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(109, 35);
            btnReset.TabIndex = 6;
            btnReset.Text = "Đặt lại";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnChangeMonth);
            flowLayoutPanel1.Controls.Add(btnChange3Months);
            flowLayoutPanel1.Controls.Add(btnChangeYear);
            flowLayoutPanel1.Controls.Add(btnChangeEmployee);
            flowLayoutPanel1.Controls.Add(btnChangeSource);
            flowLayoutPanel1.Location = new Point(45, 822);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 0, 10, 0);
            flowLayoutPanel1.Size = new Size(1111, 40);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnChangeMonth
            // 
            btnChangeMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeMonth.BackColor = Color.FromArgb(50, 50, 200);
            btnChangeMonth.FlatAppearance.BorderSize = 0;
            btnChangeMonth.FlatStyle = FlatStyle.Flat;
            btnChangeMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeMonth.ForeColor = Color.White;
            btnChangeMonth.Location = new Point(10, 0);
            btnChangeMonth.Margin = new Padding(0);
            btnChangeMonth.Name = "btnChangeMonth";
            btnChangeMonth.Size = new Size(121, 35);
            btnChangeMonth.TabIndex = 7;
            btnChangeMonth.Text = "Theo tháng";
            btnChangeMonth.UseVisualStyleBackColor = false;
            btnChangeMonth.Click += btnChangeMonth_Click;
            // 
            // btnChange3Months
            // 
            btnChange3Months.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChange3Months.BackColor = Color.FromArgb(50, 50, 200);
            btnChange3Months.FlatAppearance.BorderSize = 0;
            btnChange3Months.FlatStyle = FlatStyle.Flat;
            btnChange3Months.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange3Months.ForeColor = Color.White;
            btnChange3Months.Location = new Point(131, 0);
            btnChange3Months.Margin = new Padding(0);
            btnChange3Months.Name = "btnChange3Months";
            btnChange3Months.Size = new Size(121, 35);
            btnChange3Months.TabIndex = 12;
            btnChange3Months.Text = "Theo quý";
            btnChange3Months.UseVisualStyleBackColor = false;
            btnChange3Months.Click += btn3Months_Click;
            // 
            // btnChangeYear
            // 
            btnChangeYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeYear.BackColor = Color.FromArgb(50, 50, 200);
            btnChangeYear.FlatAppearance.BorderSize = 0;
            btnChangeYear.FlatStyle = FlatStyle.Flat;
            btnChangeYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeYear.ForeColor = Color.White;
            btnChangeYear.Location = new Point(252, 0);
            btnChangeYear.Margin = new Padding(0);
            btnChangeYear.Name = "btnChangeYear";
            btnChangeYear.Size = new Size(121, 35);
            btnChangeYear.TabIndex = 13;
            btnChangeYear.Text = "Theo năm";
            btnChangeYear.UseVisualStyleBackColor = false;
            btnChangeYear.Click += btnChangeYear_Click;
            // 
            // btnChangeEmployee
            // 
            btnChangeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeEmployee.BackColor = Color.FromArgb(50, 50, 200);
            btnChangeEmployee.FlatAppearance.BorderSize = 0;
            btnChangeEmployee.FlatStyle = FlatStyle.Flat;
            btnChangeEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeEmployee.ForeColor = Color.White;
            btnChangeEmployee.Location = new Point(373, 0);
            btnChangeEmployee.Margin = new Padding(0);
            btnChangeEmployee.Name = "btnChangeEmployee";
            btnChangeEmployee.Size = new Size(121, 35);
            btnChangeEmployee.TabIndex = 8;
            btnChangeEmployee.Text = "Nhân viên";
            btnChangeEmployee.UseVisualStyleBackColor = false;
            btnChangeEmployee.Click += btnChangeEmployee_Click;
            // 
            // btnChangeSource
            // 
            btnChangeSource.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeSource.BackColor = Color.FromArgb(50, 50, 200);
            btnChangeSource.FlatAppearance.BorderSize = 0;
            btnChangeSource.FlatStyle = FlatStyle.Flat;
            btnChangeSource.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeSource.ForeColor = Color.White;
            btnChangeSource.Location = new Point(494, 0);
            btnChangeSource.Margin = new Padding(0);
            btnChangeSource.Name = "btnChangeSource";
            btnChangeSource.Size = new Size(121, 35);
            btnChangeSource.TabIndex = 9;
            btnChangeSource.Text = "Nhà cung cấp";
            btnChangeSource.UseVisualStyleBackColor = false;
            btnChangeSource.Click += btnChangeSource_Click;
            // 
            // txtEmployeeQuery
            // 
            txtEmployeeQuery.BackColor = Color.FromArgb(50, 50, 200);
            txtEmployeeQuery.BorderRadius = 3;
            txtEmployeeQuery.BorderStyle = BorderStyle.None;
            txtEmployeeQuery.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmployeeQuery.ForeColor = Color.White;
            txtEmployeeQuery.Location = new Point(681, 228);
            txtEmployeeQuery.Margin = new Padding(10, 15, 10, 15);
            txtEmployeeQuery.Multiline = true;
            txtEmployeeQuery.Name = "txtEmployeeQuery";
            txtEmployeeQuery.Size = new Size(100, 35);
            txtEmployeeQuery.TabIndex = 4;
            txtEmployeeQuery.TextAlign = HorizontalAlignment.Center;
            txtEmployeeQuery.TextChanged += txtEmployeeQuery_TextChanged;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeName.Location = new Point(592, 235);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(87, 21);
            lblEmployeeName.TabIndex = 5;
            lblEmployeeName.Text = "Tên/Mã NV";
            // 
            // txtMonth
            // 
            txtMonth.BackColor = Color.FromArgb(50, 50, 200);
            txtMonth.BorderRadius = 3;
            txtMonth.BorderStyle = BorderStyle.None;
            txtMonth.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtMonth.ForeColor = Color.White;
            txtMonth.Location = new Point(273, 227);
            txtMonth.Margin = new Padding(10, 15, 10, 15);
            txtMonth.Multiline = true;
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(100, 35);
            txtMonth.TabIndex = 4;
            txtMonth.TextAlign = HorizontalAlignment.Center;
            txtMonth.TextChanged += txtMonthYear_TextChanged;
            txtMonth.KeyPress += txtMonthYear_KeyPress;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonth.Location = new Point(207, 235);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(53, 21);
            lblMonth.TabIndex = 5;
            lblMonth.Text = "Tháng";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = Properties.Resources.magnifying_glass;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1103, 12);
            button1.Name = "button1";
            button1.Size = new Size(34, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1213, 874);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnReset);
            Controls.Add(btnExportExcel);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblMonth);
            Controls.Add(label3);
            Controls.Add(txtEmployeeQuery);
            Controls.Add(txtMonth);
            Controls.Add(txtYear);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            Resize += Report_Resize;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private DataGridView dataGridView1;
        private Label label3;
        private Button btnExportExcel;
        private Button btnReset;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnChangeMonth;
        private Button btnChangeEmployee;
        private Button btnChangeSource;
        private Button btnChange3Months;
        private Button btnChangeYear;
        private RoundTextBox txtEmployeeQuery;
        private Label lblEmployeeName;
        private RoundTextBox txtYear;
        private RoundTextBox txtMonth;
        private Label lblMonth;
        private Button btnBack;
        private Button button1;
    }
}