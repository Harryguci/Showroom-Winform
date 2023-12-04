using ShowroomData.ComponentGUI;
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
    public partial class CreateDevice : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        public CreateDevice(Form? _parent)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //if (_parent != null && _parent.GetType() == typeof(Layout))
            //    parent = (Layout?)_parent;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;
            RoundTextBox.SetPadding(txtId, new Padding(5));
            RoundTextBox.SetPadding(txtName, new Padding(5));
            RoundTextBox.SetPadding(txtPrice, new Padding(5));
            RoundTextBox.SetPadding(txtStatus, new Padding(5));

            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }


        #region Handle Form Dragging

        //
        // [Handle Dragging the Form]
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //
        // [Handle Events]
        //

        private void DiviceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 DeviceId From Devices Order By DeviceId DESC");
            string? id = tb.Rows[0]["DeviceId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(1, id.Length - 1));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "D" + id;
            }
            else
            {
                id = "D001";
            }
            return id;
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                nameDevice = txtName.Text.Trim(),
                price = txtPrice.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            if (curr.nameDevice.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên thiêt bị");
                return false;
            }
            if (curr.price.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập giá thiết bị");
                return false;
            }
            if (curr.status.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập trạng thái");
                return false;
            }

            return true;
        }

        private void CleanForm()
        {
            // Earse current data
            TextBox[] textBoxes = { txtName, txtPrice, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
            dayDateTimePicker.Value = DateTime.Now;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới thiết bị này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text,
                nameDevice = txtName.Text.Trim(),
                day = dayDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                price = txtPrice.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO Devices (DeviceId, Name, DateEntry, Price, Status) " +
                $"VALUES (N'{curr.id}',N'{curr.nameDevice}',N'{curr.day}', " +
                $"N'{curr.price}',N'{curr.status}')";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void Device_Load(object sender, EventArgs e)
        {
            txtId.Text = AutoCreateId();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtName, txtPrice, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Số lượng chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }
    }
}
