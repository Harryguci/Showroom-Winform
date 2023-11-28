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
    public partial class SearchAll : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        public SearchAll()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void SearchAll_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string q = textBox1.Text.Trim();

            var resProduct = processDb.GetData($"SELECT * FROM PRODUCTS WHERE PRODUCTNAME LIKE N'%{q}%' OR Serial LIKE N'%{q}%'");
            var resEmployee = processDb.GetData($"SELECT * FROM EMPLOYEES WHERE Firstname LIKE N'%{q}%' OR LastName Like N'%{q}%' OR EmployeeId Like N'%{q}%'");
            var resCustomer = processDb.GetData($"SELECT * FROM CUSTOMERS WHERE Firstname LIKE N'%{q}%' OR LastName Like N'%{q}%' OR CLIENTID LIKE N'%{q}%'");
            foreach (DataRow row in resProduct.Rows)
            {
                Label label = new Label()
                {
                    Text = row[0].ToString() + " | Sản phẩm",
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel1.Width, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.FromArgb(197, 255, 248),
                    Font = new Font("Roboto", 12F, FontStyle.Regular),
                    Margin = new Padding(0)
                };
                Products products = new Products()
                {
                    ProductName = (string)row[0],
                    Serial = (string)row[1],
                    PurchasePrice = (int)row[2],
                    SalePrice = (int)row[3],
                    Quantity = (int)row[4],
                    Status = (string)row[5],
                    Deleted = (bool)row[6]

                };
                label.Click += (label, args) =>
                {
                    UpdateProduct detailForm = new UpdateProduct(products, this);
                    Hide();
                    detailForm.FormClosed += (detailForm, args) =>
                    {
                        Show();
                    };
                    detailForm.TopMost = true;
                    detailForm.Show();
                };

                flowLayoutPanel1.Controls.Add(label);
            }

            foreach (DataRow row in resEmployee.Rows)
            {
                Label label = new Label()
                {
                    Text = $"{row[1]} {row[2]} | {row[0]} | Nhân viên",
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel1.Width, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.FromArgb(150, 239, 255),
                    Font = new Font("Roboto", 12F, FontStyle.Regular),
                    Margin = new Padding(0)
                };
                Employee employee = new Employee()
                {
                    EmployeeId = (string)row[0],
                    Firstname = (string)row[1],
                    Lastname = (string)row[2],
                    DateBirth = (DateTime)row[3],
                    Phone = (string)row[4],
                    Gender = (bool)row[5],
                    Cccd = (string)row[6],
                    Position = (string)row[7],
                    StartDate = (DateTime)row[8],
                    Salary = (int)row[9],
                    Email = (string)row[10],
                    Deleted = (bool)row[11],
                    Url_image = (string)row[12],
                };
                label.Click += (label, args) =>
                {
                    UpdateInfoForm detailForm = new UpdateInfoForm(employee, this);
                    Hide();
                    detailForm.FormClosed += (detailForm, args) =>
                    {
                        Show();
                    };
                    detailForm.TopMost = true;
                    detailForm.Show();
                };

                flowLayoutPanel1.Controls.Add(label);
            }

            foreach (DataRow row in resCustomer.Rows)
            {
                Label label = new Label()
                {
                    Text = $"{row[1]} {row[2]} | {row[0]} | KHách hàng",
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel1.Width, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.FromArgb(95, 189, 255),
                    ForeColor = Color.White,
                    Font = new Font("Roboto", 12F, FontStyle.Bold),
                    Margin = new Padding(0)
                };

                Customer customer = new Customer()
                {
                    ClientId = (string)row[0],
                    Firstname = (string)row[1],
                    Lastname = (string)row[2],
                    DateBirth = (DateTime)row[3],
                    PhoneNumber = (string)row[4],
                    Gender = (bool)row[5],
                    Cccd = (string)row[6],
                    Email = (string)row[7],
                    Address = (string)row[8],
                    Deleted = (bool)row[9]
                };

                label.Click += (label, args) =>
                {
                    UpdateCustomer detailForm = new UpdateCustomer(customer, this);
                    Hide();
                    detailForm.FormClosed += (detailForm, args) =>
                    {
                        Show();
                    };
                    detailForm.TopMost = true;
                    detailForm.Show();
                };

                flowLayoutPanel1.Controls.Add(label);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
