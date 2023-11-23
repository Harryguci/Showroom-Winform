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
    public partial class CreateSaleTarget : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        public CreateSaleTarget(Form? _parent)
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

        private void SaleTargetForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 SaleId From SalesTargets Order By SaleId DESC");
            string? id = tb.Rows[0]["SaleId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(1, id.Length - 1));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "S" + id;
            }
            else
            {
                id = "S001";
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
            // Earse current data
            TextBox[] textBoxes = { txtTarget, txtStatus, txtIdEmployee };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
            startDateTimePicker.Value = DateTime.Now;
            endDateTimePicker.Value = DateTime.Now;
        }

        private void txtTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới mục tiêu này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text,
                target = txtTarget.Text.Trim(),
                startDay = startDateTimePicker.Value.ToString("yyyy-MM-dd"),
                endDay = endDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                status = txtStatus.Text.Trim(),
                idEmployee = txtIdEmployee.Text.Trim(),
                reward = txtReward.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO SalesTargets (SaleId, EmployeeId, StartDate, EndDate, Total, Target, Status, Reward) " +
                $"VALUES (N'{curr.id}', N'{curr.idEmployee}', N'{curr.startDay}', N'{curr.endDay}', 0, N'{curr.target}', " +
                $"N'{curr.status}', N'{curr.reward}')";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtTarget, txtStatus, txtIdEmployee };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtId.Text = AutoCreateId();
            txtReward.Text = "0.03";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Mục tiêu chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }

        private void SaleTarget_Load(object sender, EventArgs e)
        {
            txtId.Text = AutoCreateId();
            txtReward.Text = "0.03";
        }
    }
}
