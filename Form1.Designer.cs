﻿using System.Drawing.Printing;

namespace ShowroomData
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            savedBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(savedBtn);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 500);
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // savedBtn
            // 
            savedBtn.BackColor = Color.FromArgb(50, 50, 150);
            savedBtn.FlatAppearance.BorderSize = 0;
            savedBtn.FlatStyle = FlatStyle.Flat;
            savedBtn.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            savedBtn.ForeColor = Color.White;
            savedBtn.Location = new Point(0, 128);
            savedBtn.Margin = new Padding(0, 0, 0, 25);
            savedBtn.Name = "savedBtn";
            savedBtn.Size = new Size(136, 51);
            savedBtn.TabIndex = 1;
            savedBtn.Text = "Save";
            savedBtn.UseVisualStyleBackColor = true;
            savedBtn.Click += savedBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 150);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 204);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(136, 51);
            button1.TabIndex = 2;
            button1.Text = "Tất cả";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 50, 150);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 255);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(136, 51);
            button2.TabIndex = 3;
            button2.Text = "Tạo mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += createBtn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 50, 150);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 306);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(136, 51);
            button3.TabIndex = 4;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(50, 50, 150);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 357);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(136, 51);
            button4.TabIndex = 5;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(136, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 100);
            panel1.TabIndex = 1;
            panel1.MouseDown += Form_MouseDown;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(136, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(664, 400);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Showroom - Management System";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button savedBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}