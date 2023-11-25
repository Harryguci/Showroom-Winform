using ShowroomData.Models;
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
    public partial class Admin : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();

        public Admin()
        {
            InitializeComponent();
            HandleGUI();

            Resize += Admin_Resize;
        }

        public void HandleGUI()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            lblHeadingPage.Location = new Point((panel2.Width - lblHeadingPage.Width) / 2, lblHeadingPage.Location.Y);
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Xác nhận trước khi thoát
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Hủy sự kiện đóng cửa sổ
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo một sự kiện đóng form
            this.Close();
        }

        private void Admin_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel1.Size = new Size(Math.Min(Math.Max(Width / 5, 100), 250),
                flowLayoutPanel1.Size.Height);

            var childs = flowLayoutPanel1.Controls;
            for (int i = 0; i < childs.Count; i++)
            {
                childs[i].Size = new Size(flowLayoutPanel1.Width, childs[i].Height);
            }

            pictureBox1.Location = new Point(flowLayoutPanel1.Width / 2 - pictureBox1.Width / 2,
                pictureBox1.Top);
        }

        private void employee_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("employees");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("customers");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void device_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("devices");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void product_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("products");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void saleInvoice_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("salesinvoices");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void purchaseInvoice_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("purchaseinvoices");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void source_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("source");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void testDrive_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("testdrive");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }

        private void target_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm("salestargets");
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Close();
        }
    }
}
