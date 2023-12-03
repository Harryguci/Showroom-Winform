﻿namespace ShowroomData
{
    partial class UserAccount
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
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            flowpanelFooter = new FlowLayoutPanel();
            panelContent = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            txtEmployeeId = new ComponentGUI.RoundTextBox();
            txtRole = new ComponentGUI.RoundTextBox();
            txtConfirmPassword = new ComponentGUI.RoundTextBox();
            label2 = new Label();
            txtPassword = new ComponentGUI.RoundTextBox();
            label1 = new Label();
            txtUsername = new ComponentGUI.RoundTextBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            button2 = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(50, 50, 150);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1155, 171);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(502, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowpanelFooter
            // 
            flowpanelFooter.Dock = DockStyle.Bottom;
            flowpanelFooter.Location = new Point(0, 656);
            flowpanelFooter.Name = "flowpanelFooter";
            flowpanelFooter.Size = new Size(1155, 42);
            flowpanelFooter.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(panel1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 171);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1155, 485);
            panelContent.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(37, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 453);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(698, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(389, 443);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtEmployeeId);
            panel2.Controls.Add(txtRole);
            panel2.Controls.Add(txtConfirmPassword);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblConfirmPassword);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(lblUsername);
            panel2.Location = new Point(22, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 443);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(513, 111);
            button1.Name = "button1";
            button1.Size = new Size(68, 32);
            button1.TabIndex = 2;
            button1.Text = "Đổi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnToggle_Click;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.BackColor = SystemColors.Control;
            txtEmployeeId.BorderRadius = 5;
            txtEmployeeId.Location = new Point(174, 274);
            txtEmployeeId.Multiline = true;
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(333, 35);
            txtEmployeeId.TabIndex = 1;
            // 
            // txtRole
            // 
            txtRole.BackColor = SystemColors.Control;
            txtRole.BorderRadius = 5;
            txtRole.Location = new Point(174, 216);
            txtRole.Multiline = true;
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(333, 35);
            txtRole.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Control;
            txtConfirmPassword.BorderRadius = 5;
            txtConfirmPassword.Location = new Point(174, 164);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(333, 35);
            txtConfirmPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 277);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderRadius = 5;
            txtPassword.Location = new Point(174, 108);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(333, 35);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 219);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Quyền truy cập";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderRadius = 5;
            txtUsername.Location = new Point(174, 54);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(333, 35);
            txtUsername.TabIndex = 1;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(44, 167);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 0;
            lblConfirmPassword.Text = "Nhập lại mật khẩu";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(44, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(44, 57);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(85, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // button2
            // 
            button2.Location = new Point(174, 333);
            button2.Name = "button2";
            button2.Size = new Size(68, 32);
            button2.TabIndex = 2;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSave_Click;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 698);
            Controls.Add(panelContent);
            Controls.Add(flowpanelFooter);
            Controls.Add(panelHeader);
            Name = "UserAccount";
            Text = "UserAccount";
            Load += UserAccount_Load;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowpanelFooter;
        private Panel panelContent;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private ComponentGUI.RoundTextBox txtEmployeeId;
        private ComponentGUI.RoundTextBox txtRole;
        private ComponentGUI.RoundTextBox txtConfirmPassword;
        private Label label2;
        private ComponentGUI.RoundTextBox txtPassword;
        private Label label1;
        private ComponentGUI.RoundTextBox txtUsername;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Button button1;
        private Button button2;
    }
}