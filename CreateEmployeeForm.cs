using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShowroomData
{
    public partial class CreateEmployeeForm : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        public CreateEmployeeForm(Form? _parent)
        {
            InitializeComponent();


            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout?)_parent;

            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //
        // [Handle Dragging the Form]
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        //
        // [Handle Events]
        //
        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CreateEmployeeForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4 };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tạo mới nhân viên này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var curr = new
            {
                id = textBox1.Text,
                lastName = textBox3.Text,
                firstName = textBox2.Text,
                sdt = textBox4.Text,
                birth = dateTimePicker1.Value.ToString("yyyy-MM-dd")
            };
            // Handle Create
            string query = $"INSERT INTO Employees (EmployeeId, FirstName, LastName, DateBirth, CCCD, Position, StartDate, Salary, Email, SaleId) " +
                $"VALUES (N'{curr.id}',N'{curr.firstName}',N'{curr.lastName}','{curr.birth}', " +
                $"N'',N'','{DateTime.Now.ToString("yyyy-MM-dd")}',5500000, N'', NULL)";

            processDb.UpdateData(query);

            // Earse current data
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4 };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;
            textBox1.Text = CreateId();

            // Update the data grid view in The list Form
            if (parent != null)
                parent.RefeshData();
        }

        private string CreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 EmployeeId From Employees Order By EmployeeId DESC");
            string? id = tb.Rows[0]["EmployeeId"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(1, id.Length - 1));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "e" + id;
            }
            else
            {
                id = "E001";
            }
            return id;
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = CreateId();
        }
        //
        //
        //
    }
}
