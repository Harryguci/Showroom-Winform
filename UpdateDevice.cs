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
    public partial class UpdateDevice : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        // Constructor
        public UpdateDevice(Device device, Form? _parent)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;

            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            //
            // Fill the data of the device which you want to change info.
            //
            txtId.Text = device.DeviceId;
            txtName.Text = device.DeviceName;
            dayDateTimePicker.Value = device.DateEntry != null ? device.DateEntry.Value : DateTime.Now;
            txtPrice.Text = device.Price.ToString();
            txtStatus.Text = device.Status;
        }


        #region HANDLE FORM DRAGGING

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
        private void UpdateDeviceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật thiết bị này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text.Trim(),
                name = txtName.Text.Trim(),
                day = dayDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                price = txtPrice.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $" UPDATE Devices SET Name = N'{curr.name}', DateEntry = N'{curr.day}'," +
                $" Price = '{curr.price}', Status = N'{curr.status}' WHERE DeviceId = '{curr.id}'";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            Dispose();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Giá chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?.\nDữ liệu chưa lưu sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes) Close();
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                name = txtName.Text.Trim(),
                price = txtPrice.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            if (curr.name.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên thiết bị");
                return false;
            }
            if (curr.price.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập giá");
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void UpdateDevice_Load(object sender, EventArgs e)
        {

        }
    }
}
