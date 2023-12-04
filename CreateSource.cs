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
    public partial class CreateSource : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private bool isCreateOne = false;
        public CreateSource(Form? _parent, bool isCreateOne = false)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;
            RoundTextBox.SetPadding(txtIdSuppliers, new Padding(5));
            RoundTextBox.SetPadding(txtNameSuppliers, new Padding(5));


            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.isCreateOne = isCreateOne;
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

        private void SourceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 SourceId From Source Order By SourceId DESC");
            string? id = tb.Rows[0]["SourceId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(2, id.Length - 2));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "SU" + id;
            }
            else
            {
                id = "SU001";
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
                idSuppliers = txtIdSuppliers.Text.Trim(),
                nameSuppliers = txtNameSuppliers.Text.Trim()
            };

            if (curr.nameSuppliers.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp");
                return false;
            }

            return true;
        }

        private void CleanForm()
        {
            // Earse current data
            TextBox[] textBoxes = { txtNameSuppliers };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdSuppliers.Text = AutoCreateId();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới nhà cung cấp này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                idSuppliers = txtIdSuppliers.Text,
                nameSuppliers = txtNameSuppliers.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO Source (SourceId, Name) " +
                $"VALUES (N'{curr.idSuppliers}',N'{curr.nameSuppliers}') ";

            // Excute the query
            processDb.UpdateData(query);

            // Inform
            MessageBox.Show("Tạo thành công", "Thông báo");
            // Earse current data
            CleanForm();

            // Check if Create one to close the form
            if (isCreateOne) Close();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtNameSuppliers };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdSuppliers.Text = AutoCreateId();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n");

            helperDialog.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Source_Load(object sender, EventArgs e)
        {
            txtIdSuppliers.Text = AutoCreateId();
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
