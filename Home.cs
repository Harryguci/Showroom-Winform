using Microsoft.IdentityModel.Tokens;
using ShowroomData.Util;
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

namespace ShowroomData
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            HandleGUI();
        }
        public void HandleGUI()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void panelContent_Resize(object sender, EventArgs e)
        {
            lblHeadingPage.Location = new Point((panel1.Width - lblHeadingPage.Width) / 2,
                lblHeadingPage.Location.Y);
            flowLayoutPanel2.Width = panelContent.Width - 100;
            flowLayoutPanel2.Height = panelContent.Height - 100;

            int minWidth = Math.Max(flowLayoutPanel2.Width / 3 - 100, 200);
            minWidth = Math.Min(250, minWidth);

            Size btnSize = new Size(minWidth, minWidth);

            btnCustomers.Size = btnSize;
            btnEmployees.Size = btnSize;
            btnPuchaInvoices.Size = btnSize;
            btnProducts.Size = btnSize;
            btnSource.Size = btnSize;
            btnPuchaInvoices.Size = btnSize;
            btnServices.Size = btnSize;
            btnSaleInvoice.Size = btnSize;
        }
        private void HandleChangeForm(object sender, EventArgs e)
        {
            if (sender == btnProducts)
            {
                ProductsGrid productsGrid = new ProductsGrid();

                productsGrid.FormClosed += (sender, args) => {
                    Show();
                };

                Hide();
                productsGrid.Show();

                return;   
            }

            string? formName = null;
            if (sender.Equals(btnCustomers))
            {
                formName = TableName.CUSTOMERS;
            }
            else if (sender.Equals(btnEmployees))
            {
                formName = TableName.EMPLOYEES;
            }
            else if (sender.Equals(btnSource))
            {
                formName = TableName.SOURCE;
            }
            else if (sender.Equals(btnPuchaInvoices))
            {
                formName = TableName.PURCHASEINVOICES;
            }
            else if (sender.Equals(btnProducts))
            {
                formName = TableName.PRODUCTS;
            }

            if (formName == null) formName = "employees";

            ListForm form = new ListForm(formName);
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Show();
        }
    }
}
