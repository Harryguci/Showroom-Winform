namespace ShowroomData
{
    partial class ListForm
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
            btnRefresh = new Button();
            btnCreate = new Button();
            btnUpdateInfo = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            button1 = new Button();
            lblHeadingPage = new Label();
            panelContent = new Panel();
            component11 = new Component1(components);
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.Controls.Add(btnCreate);
            flowLayoutPanel1.Controls.Add(btnUpdateInfo);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 544);
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
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(50, 50, 150);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(0, 128);
            btnRefresh.Margin = new Padding(0, 0, 0, 30);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 51);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button1_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(50, 50, 150);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(0, 209);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(136, 51);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Tạo mới";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += createBtn_Click;
            // 
            // btnUpdateInfo
            // 
            btnUpdateInfo.BackColor = Color.FromArgb(50, 50, 100);
            btnUpdateInfo.Enabled = false;
            btnUpdateInfo.FlatAppearance.BorderSize = 0;
            btnUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateInfo.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInfo.ForeColor = Color.White;
            btnUpdateInfo.Location = new Point(0, 260);
            btnUpdateInfo.Margin = new Padding(0);
            btnUpdateInfo.Name = "btnUpdateInfo";
            btnUpdateInfo.Size = new Size(136, 51);
            btnUpdateInfo.TabIndex = 4;
            btnUpdateInfo.Text = "Sửa";
            btnUpdateInfo.UseVisualStyleBackColor = false;
            btnUpdateInfo.Click += updateInfoBtn_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(50, 50, 100);
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 311);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 51);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblHeadingPage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 100);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = Properties.Resources.back;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(916, 12);
            button1.Name = "button1";
            button1.Size = new Size(45, 39);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblHeadingPage
            // 
            lblHeadingPage.AutoSize = true;
            lblHeadingPage.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeadingPage.Location = new Point(388, 37);
            lblHeadingPage.Name = "lblHeadingPage";
            lblHeadingPage.Size = new Size(150, 38);
            lblHeadingPage.TabIndex = 1;
            lblHeadingPage.Text = "Welcome";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(136, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(964, 444);
            panelContent.TabIndex = 2;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1100, 544);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ListForm";
            Text = "Showroom - Management System";
            FormClosing += Layout_FormClosing;
            FormClosed += Layout_FormClosed;
            Load += Layout_Load;
            Resize += Layout_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnRefresh;
        private Button btnCreate;
        private Button btnUpdateInfo;
        private Button btnDelete;
        private Label lblHeadingPage;
        private Panel panelContent;
        private Button button1;
        private Component1 component11;
    }
}