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
            btnBack = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnSmallBack = new Button();
            lblHeadingPage = new Label();
            panelContent = new Panel();
            panelFooter = new Panel();
            component11 = new Component1(components);
            toolTip1 = new ToolTip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelContent.SuspendLayout();
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
            flowLayoutPanel1.Controls.Add(btnBack);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 544);
            flowLayoutPanel1.TabIndex = 0;
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
            panel2.MouseDown += Form_MouseDown;
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
            btnRefresh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnUpdateInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 50, 150);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 362);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 51);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSmallBack);
            panel1.Controls.Add(lblHeadingPage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 100);
            panel1.TabIndex = 1;
            panel1.MouseDown += Form_MouseDown;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackgroundImage = Properties.Resources.arrow_down;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(854, 15);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSmallForm_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = Properties.Resources.increase_size_option;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(894, 15);
            button1.Name = "button1";
            button1.Size = new Size(22, 22);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnChangeSize_Click;
            // 
            // btnSmallBack
            // 
            btnSmallBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSmallBack.BackgroundImage = Properties.Resources.back;
            btnSmallBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnSmallBack.FlatAppearance.BorderSize = 0;
            btnSmallBack.FlatStyle = FlatStyle.Flat;
            btnSmallBack.Location = new Point(922, 12);
            btnSmallBack.Name = "btnSmallBack";
            btnSmallBack.Size = new Size(30, 30);
            btnSmallBack.TabIndex = 3;
            toolTip1.SetToolTip(btnSmallBack, "Quay lại");
            btnSmallBack.UseVisualStyleBackColor = true;
            btnSmallBack.Click += btnBack_Click;
            // 
            // lblHeadingPage
            // 
            lblHeadingPage.AutoSize = true;
            lblHeadingPage.Font = new Font("Roboto", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeadingPage.ForeColor = Color.FromArgb(50, 50, 150);
            lblHeadingPage.Location = new Point(389, 26);
            lblHeadingPage.Name = "lblHeadingPage";
            lblHeadingPage.Size = new Size(188, 48);
            lblHeadingPage.TabIndex = 1;
            lblHeadingPage.Text = "Welcome";
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(panelFooter);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(136, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(964, 444);
            panelContent.TabIndex = 2;
            panelContent.MouseDown += Form_MouseDown;
            // 
            // panelFooter
            // 
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 316);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(964, 128);
            panelFooter.TabIndex = 0;
            panelFooter.MouseDown += Form_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1100, 544);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ListForm";
            Text = "Showroom - Management System";
            FormClosing += Layout_FormClosing;
            FormClosed += Layout_FormClosed;
            Load += Form_Load;
            Resize += Layout_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContent.ResumeLayout(false);
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
        //private Button button1;
        private Component1 component11;
        private Button btnBack;
        private Panel panelFooter;
        private Button btnSmallBack;
        private ToolTip toolTip1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Button button2;
    }
}