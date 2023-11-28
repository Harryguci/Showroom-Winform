namespace ShowroomData
{
    partial class SearchAll
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
            textBox1 = new TextBox();
            btnClose = new Button();
            btnSearch = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 150);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 49);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 150);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(9, 17);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "SEARCH...";
            textBox1.Size = new Size(357, 16);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(50, 50, 150);
            btnClose.BackgroundImage = Properties.Resources.pngaaa_com_4834605;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.BottomCenter;
            btnClose.Location = new Point(450, 11);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(19, 27);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(50, 50, 150);
            btnSearch.BackgroundImage = Properties.Resources.clipart742441;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.ImageAlign = ContentAlignment.BottomCenter;
            btnSearch.Location = new Point(385, 6);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 37);
            btnSearch.TabIndex = 0;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(0, 49);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(478, 390);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // SearchAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(478, 439);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "SearchAll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchAll";
            Load += SearchAll_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button btnSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnClose;
    }
}