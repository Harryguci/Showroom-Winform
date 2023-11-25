namespace ShowroomData
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            panel1 = new ReaLTaiizor.Controls.Panel();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // hopeForm1
            // 
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Top;
            hopeForm1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = (Image)resources.GetObject("hopeForm1.Image");
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(1148, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "SHOWROOM - Dashboard";
            hopeForm1.ThemeColor = Color.Navy;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(hopePictureBox1);
            panel1.Controls.Add(crownLabel1);
            panel1.Cursor = Cursors.Hand;
            panel1.EdgeColor = SystemColors.Control;
            panel1.Location = new Point(481, 233);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(187, 177);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 4;
            panel1.Text = "panel1";
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.White;
            hopePictureBox1.BackgroundImage = Properties.Resources.customers;
            hopePictureBox1.BackgroundImageLayout = ImageLayout.Center;
            hopePictureBox1.Image = Properties.Resources.employees;
            hopePictureBox1.Location = new Point(8, 8);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(171, 133);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 1;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.ForeColor = Color.FromArgb(50, 50, 50);
            crownLabel1.Location = new Point(58, 157);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(61, 15);
            crownLabel1.TabIndex = 0;
            crownLabel1.Text = "Nhân viên";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 642);
            Controls.Add(panel1);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1560, 1032);
            MinimumSize = new Size(190, 40);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
    }
}