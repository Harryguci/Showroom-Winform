namespace ShowroomData
{
    partial class HelperDialog
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(134, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += Form_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 117);
            panel2.TabIndex = 9;
            panel2.MouseDown += Form_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.pngaaa_com_4834605;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(12, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 33);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_click;
            // 
            // HelperDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 513);
            Controls.Add(panel2);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "HelperDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Showroom - Management System";
            TopMost = true;
            MouseDown += Form_MouseDown;
            Resize += Layout_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnClose;
    }
}