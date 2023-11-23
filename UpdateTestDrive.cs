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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShowroomData
{
    public partial class UpdateTestDrive : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        public UpdateTestDrive(TestDrive testDrive, Form? _parent)
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
            txtId.Text = testDrive.DriveId;
            txtIdClients.Text = testDrive.ClientId;
            txtIdEmployees.Text = testDrive.EmployeeId;
            bookdateDateTimePicker.Value = testDrive.BookDate != null ? testDrive.BookDate.Value : DateTime.Now;
            txtNote.Text = testDrive.Note;
            txtStatus.Text = testDrive.Status;
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
        private void UpdateTestDriveForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void UpdateTestDrive_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật lịch lái thử này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text.Trim(),
                idEmployees = txtIdEmployees.Text.Trim(),
                idClients = txtIdClients.Text.Trim(),
                bookdate = bookdateDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                note = txtNote.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $" UPDATE TestDrive SET EmployeeId = N'{curr.idEmployees}', ClientId = N'{curr.idClients}'," +
                $" BookDate = '{curr.bookdate}', Note = N'{curr.note}', " +
                $" Status = N'{curr.status}' WHERE DriveId = N'{curr.id}' ";

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
                "- Bắt buộc nhập đầy đủ thông tin\n");

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
                idClient = txtIdClients.Text.Trim(),
                idEmployee = txtIdEmployees.Text.Trim(),
                note = txtNote.Text.Trim(),
                status = txtStatus.Text.Trim()
            };


            if (curr.idClient.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id khách hàng");
                return false;
            }
            if (curr.idEmployee.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id nhân viên");
                return false;
            }
            if (curr.note.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng");
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
    }
}
