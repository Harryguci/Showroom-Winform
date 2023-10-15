using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class HelperDialog : Form
    {
        private Panel contentPanel;

        public HelperDialog(Panel _contentPanel)
        {
            InitializeComponent();
            contentPanel = _contentPanel;
            Controls.Add(contentPanel);
        }
        //
        // [Handle Events]
        //
        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void Layout_Resize(object sender, EventArgs e)
        {
            contentPanel.Location = new Point((Width - contentPanel.Width) / 2, contentPanel.Location.Y);
            pictureBox1.Location = new Point((panel2.Width - pictureBox1.Width) / 2, pictureBox1.Location.Y);
        }

        //
        // [Helper Methods]
        //

        public static HelperDialog Create(Panel _contentPanel)
        {
            return new HelperDialog(_contentPanel);
        }

        public static HelperDialog Create(string _heading, string content)
        {
            Label _lblHeading = new Label();
            Label _label1 = new Label();

            // 
            // lblHeading
            // 
            _lblHeading.AutoSize = true;
            _lblHeading.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Point);
            _lblHeading.Location = new Point(285, 39);
            _lblHeading.Name = "lblHeading";
            _lblHeading.Size = new Size(115, 33);
            _lblHeading.TabIndex = 0;
            _lblHeading.Text = _heading;
            // 
            // label1
            // 
            _label1.AutoSize = true;
            _label1.Location = new Point(100, 95);
            _label1.Name = "label1";
            _label1.TabIndex = 1;
            _label1.Text = content;
            _label1.AutoSize = false;
            _label1.TextAlign = ContentAlignment.MiddleCenter;
            _label1.Dock = DockStyle.Fill;
            //
            // panel1
            //
            Panel _contentPanel = new Panel()
            {
                Location = new Point(0, 123),
                Name = "panel1",
                Size = new Size(688, 392),
                TabIndex = 8
            };

            _contentPanel.Controls.Add(_lblHeading);
            _contentPanel.Controls.Add(_label1);

            HelperDialog helperDialog = new HelperDialog(_contentPanel);

            return helperDialog;
        }
    }
}
