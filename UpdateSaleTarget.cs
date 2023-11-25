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
    public partial class UpdateSaleTarget : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        public UpdateSaleTarget(SalesTarget salesTarget, Form? _parent)
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
            // Fill the data of the product which you want to change info.
            //
            txtId.Text = salesTarget.SaleId;
            txtIdEmployee.Text = salesTarget.EmployeeId;
            txtTarget.Text = salesTarget.Target.ToString();
            startDateTimePicker.Value = salesTarget.StartDate != null ? salesTarget.StartDate.Value : DateTime.Now;
            endDateTimePicker.Value = salesTarget.EndDate != null ? salesTarget.EndDate.Value : DateTime.Now;
            txtStatus.Text = salesTarget.Status;
            txtReward.Text = salesTarget.Reward.ToString();
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
        private void UpdateSaleTargetForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void UpdateSaleTarget_Load(object sender, EventArgs e)
        {

        }

        private void txtTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật mục tiêu này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text.Trim(),
                endDay = endDateTimePicker.Value.ToString("yyyy-MM-dd"),
                startDay = startDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                target = txtTarget.Text.Trim(),
                status = txtStatus.Text.Trim(),
                idEmployee = txtIdEmployee.Text.Trim(),
                reward = txtReward.Text.Trim()
            };

            // Handle Create
            string query = $" UPDATE SalesTargets SET EmployeeId = N'{curr.idEmployee}', StartDate = N'{curr.startDay}', EndDate = N'{curr.endDay}', " +
                $" Total = 0, Target = N'{curr.target}', Status = N'{curr.status}', Reward = N'{curr.reward}' " +
                $" WHERE SaleId = N'{curr.id}' ";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            Dispose();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Mục tiêu chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                target = txtTarget.Text.Trim(),
                idEmployee = txtIdEmployee.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            if (curr.target.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập mục tiêu");
                return false;
            }
            if (curr.status.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập trạng thái");
                return false;
            }
            if (curr.idEmployee.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên");
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
    }
}
