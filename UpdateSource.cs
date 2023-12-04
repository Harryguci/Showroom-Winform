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
using System.Xml.Linq;

namespace ShowroomData
{
    public partial class UpdateSource : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private bool isChanged = false;
        private Source _source;
        public UpdateSource(Source source, Form? _parent)
        {
            InitializeComponent();
            _source = source;
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
            txtIdSuppliers.Text = source.SourceId;
            txtNameSuppliers.Text = source.Name;

            txtIdSuppliers.TextChanged += Value_Changed;
            txtNameSuppliers.TextChanged += Value_Changed;
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
        private void Value_Changed(object? sender, EventArgs e)
        {
            isChanged = true;
        }
        private void UpdateSourceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void UpdateSource_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật nhà cung cấp này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtIdSuppliers.Text.Trim(),
                name = txtNameSuppliers.Text.Trim()
            };

            // Handle Create
            string query = $" UPDATE Source SET Name = N'{curr.name}' WHERE SourceId = N'{curr.id}' ";

            // Excute the query
            processDb.UpdateData(query);

            // Inform
            MessageBox.Show("Cập nhật thành công");

            // Earse current data
            CleanForm();

            Close();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            //
            // Fill the data of the product which you want to change info.
            //
            txtIdSuppliers.Text = _source.SourceId;
            txtNameSuppliers.Text = _source.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!isChanged || MessageBox.Show("Bạn có chắc muốn thoát?\n" +
                " Thông tin chưa lưu sẽ bị xóa", "Thông báo", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
               "- Bắt buộc nhập đầy đủ thông tin\n");

            helperDialog.Show();
        }

        private void btnChangeFormSize_Clicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!isChanged || MessageBox.Show("Bạn có chắc muốn thoát?\n" +
                " Thông tin chưa lưu sẽ bị xóa", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                name = txtNameSuppliers.Text.Trim()
            };


            if (curr.name.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp");
                return false;
            }

            return true;
        }
        private void CleanForm()
        {
            txtIdSuppliers.Text = _source.SourceId;
            txtNameSuppliers.Text = _source.Name;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
