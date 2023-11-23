using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShowroomData
{
    public partial class CreateSchedule : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        public CreateSchedule(Form? _parent)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //if (_parent != null && _parent.GetType() == typeof(Layout))
            //    parent = (Layout?)_parent;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;


            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        // Constructor

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

        private void ScheduleForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }



        /* private void ScheduleForm_Load(object sender, EventArgs e)
         {

             txtId.Text = AutoCreateId();
         }*/

        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 DriveId From TestDrive Order By DriveId DESC");
            string? id = tb.Rows[0]["DriveId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(2, id.Length - 2));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "TD" + id;
            }
            else
            {
                id = "TD001";
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
                idEmployees = txtIdEmployees.Text.Trim(),
                idClients = txtIdClients.Text.Trim(),
                note = txtNote.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            if (curr.idClients.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id khách hàng");
                return false;
            }
            if (curr.idEmployees.Length <= 0)
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
            // Earse current data
            TextBox[] textBoxes = { txtId, txtIdClients, txtIdEmployees, txtNote, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
            bookdateDateTimePicker.Value = DateTime.Now;
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n");

            helperDialog.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            txtId.Text = AutoCreateId();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới lịch lái thử này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text,
                idEmployees = txtIdEmployees.Text.Trim(),
                idClients = txtIdClients.Text.Trim(),
                bookdate = bookdateDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                note = txtNote.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            String query = "INSERT INTO TestDrive (DriveId, EmployeeId, ClientId, BookDate, Note, Status)\r\nVALUES\r\n  " +
                "  (N'" + curr.id + "', N'" + curr.idEmployees + "', N'" + curr.idClients + "', '" + curr.bookdate + "', N'" + curr.note + "', N'" + curr.status + "')  ";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();
            MessageBox.Show("driveid : " + curr.id + "\nEmployeeid :" + curr.idEmployees + "\nClientId : " + curr.idClients + "\n", "Tai khoan ban vua dang ki la!!!", MessageBoxButtons.OK);
            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtIdClients, txtIdEmployees, txtNote, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
        }
    }
}
