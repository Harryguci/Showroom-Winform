using ShowroomData.Models;
using ShowroomData.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowroomData
{
    public partial class ProductsGrid : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        public ProductsGrid()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private Panel CreateProductCard(string? title = "Default Name", string? url = "",
            string? id = "", int? saletPrice = 0, int? purchasePrice = 0)
        {
            Panel panel0 = new Panel();
            Label label0 = new Label();
            Label labelSalePrice = new Label();
            Label labelPurchasePrice = new Label();

            PictureBox pictureBox0 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).BeginInit();
            // 
            // panel1
            // 
            panel0.Controls.Add(label0);
            panel0.Controls.Add(pictureBox0);
            panel0.Controls.Add(labelSalePrice);
            panel0.Controls.Add(labelPurchasePrice);
            panel0.Location = new Point(3, 3);
            panel0.Name = "panel1";
            panel0.Size = new Size(Math.Max(flowLayoutPanel1.Width / 4, 200) - 10, 255);
            panel0.TabIndex = 0;
            panel0.BackColor = Color.White;
            // 
            // label1
            // 
            label0.AutoSize = false;
            label0.Location = new Point(0, 171);
            label0.Name = "label" + id;
            label0.Size = new Size(panel0.Width + 20, 35);
            label0.TabIndex = 1;
            label0.Text = title;
            label0.TextAlign = ContentAlignment.MiddleCenter;
            label0.ForeColor = Color.FromArgb(50, 50, 200);
            label0.Font = new Font("Roboto", 16, FontStyle.Bold);
            // 
            // label2
            // 
            labelSalePrice.AutoSize = true;
            labelSalePrice.Location = new Point(30, 220);
            labelSalePrice.Name = "labelsale" + id;
            labelSalePrice.TabIndex = 1;
            labelSalePrice.Text = "Giá bán: " + saletPrice.ToString() + "TR.VND";
            labelSalePrice.TextAlign = ContentAlignment.MiddleCenter;
            labelSalePrice.ForeColor = Color.FromArgb(50, 50, 210);
            labelSalePrice.Font = new Font("Roboto", 9, FontStyle.Regular);
            // 
            // label2
            // 
            labelPurchasePrice.AutoSize = true;
            labelPurchasePrice.Location = new Point(30, 235);
            labelPurchasePrice.Name = "labelpurchase" + id;
            labelPurchasePrice.TabIndex = 1;
            labelPurchasePrice.Text = "Giá nhập: " + purchasePrice.ToString() + "TR.VND";
            labelPurchasePrice.TextAlign = ContentAlignment.MiddleCenter;
            labelPurchasePrice.ForeColor = Color.FromArgb(50, 50, 200);
            labelPurchasePrice.Font = new Font("Roboto", 9, FontStyle.Regular);
            // 
            // pictureBox1
            // 
            string rootPath = Path.GetDirectoryName(Application.ExecutablePath) ?? "";

            if (url == null)
                pictureBox0.Image = Properties.Resources.car;
            else
                pictureBox0.ImageLocation = Path.Combine(rootPath, url.Substring(1));

            pictureBox0.Location = new Point(0, 0);
            pictureBox0.Name = "pictureBox1";
            pictureBox0.Size = new Size(panel0.Width + 20, 158);
            pictureBox0.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox0.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox0.BackColor = Color.WhiteSmoke;
            pictureBox0.TabIndex = 0;
            pictureBox0.TabStop = false;

            ((System.ComponentModel.ISupportInitialize)pictureBox0).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel0.ResumeLayout(false);
            panel0.PerformLayout();

            flowLayoutPanel1.Controls.Add(panel0);
            return panel0;
        }

        private void ProductsGrid_Load(object sender, EventArgs e)
        {
            var query = processDb.GetData($"SELECT * FROM PRODUCTS");

            if (query.Rows.Count > 0)
            {
                foreach (DataRow row in query.Rows)
                {
                    string? id = row.Field<string>("Serial");

                    var product = new Products()
                    {
                        Serial = row.Field<string>("Serial"),
                        ProductName = row.Field<string>("ProductName"),
                        PurchasePrice = row.Field<int>("PurchasePrice"),
                        SalePrice = row.Field<int>("SalePrice"),
                        Quantity = row.Field<int>("Quantity"),
                        Status = row.Field<string>("Status"),
                        Deleted = row.Field<bool>("Deleted")
                    };

                    var imgs = processDb.GetData($"SELECT * FROM " +
                        $"Product_Images Where Serial = N'{product.Serial}'");
                    string? url = imgs.Rows[0].Field<string>("Url_image");


                    CreateProductCard(title: product.ProductName, url: url, id: product.Serial, saletPrice: product.SalePrice, purchasePrice: product.PurchasePrice);
                }
            }
        }

        private void ProductsGrid_Resize(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(Width - 300, Height);
            tabControl1.Location = new Point(300, 0);
            panel1.Size = new Size(300, Height);
            flowLayoutPanel1.Size = new Size(tabControl1.Width - 100, tabControl1.Height - 100);
            pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, pictureBox1.Top);

            textBox1.Size = textBox2.Size =
                comboBox1.Size = new Size(panel1.Width - 30, textBox1.Height);


            btnBack.Size = new Size(panel1.Width, btnBack.Height);
            btnShowList.Size = new Size(panel1.Width, btnShowList.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = comboBox1.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qName = textBox1.Text.ToLower().Trim();
                string qColor = comboBox1.Text.ToLower().Trim();
                int qCost = Convert.ToInt32(textBox2.Text.ToLower().Trim());
                var query = processDb.GetData($"SELECT * FROM Products Where " +
                    $"ProductName Like N'%{qName}%' " +
                    $"AND SalePrice < {qCost}");

                flowLayoutPanel1.Controls.Clear();

                if (query.Rows.Count > 0)
                {
                    foreach (DataRow row in query.Rows)
                    {
                        string? id = row.Field<string>("Serial");

                        var product = new Products()
                        {
                            Serial = row.Field<string>("Serial") ?? "",
                            ProductName = row.Field<string>("ProductName") ?? "",
                            PurchasePrice = row.Field<int>("PurchasePrice"),
                            SalePrice = row.Field<int>("SalePrice"),
                            Quantity = row.Field<int>("Quantity"),
                            Status = row.Field<string>("Status"),
                            Deleted = row.Field<bool>("Deleted")
                        };

                        var imgs = processDb.GetData($"SELECT * FROM " +
                            $"Product_Images Where Serial = N'{product.Serial}'");
                        string? url = imgs.Rows[0].Field<string>("Url_image");

                        CreateProductCard(title: product.ProductName, url: url, id: product.Serial,
                            saletPrice: product.SalePrice, purchasePrice: product.PurchasePrice);
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Giá không hợp lệ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string q = textBox1.Text.ToLower().Trim();

            var query = processDb.GetData($"SELECT * FROM Products Where ProductName Like N'%{q}%'");

            flowLayoutPanel1.Controls.Clear();

            if (query.Rows.Count > 0)
            {
                foreach (DataRow row in query.Rows)
                {
                    string? id = row.Field<string>("Serial");

                    var product = new Products()
                    {
                        Serial = row.Field<string>("Serial"),
                        ProductName = row.Field<string>("ProductName"),
                        PurchasePrice = row.Field<int>("PurchasePrice"),
                        SalePrice = row.Field<int>("SalePrice"),
                        Quantity = row.Field<int>("Quantity"),
                        Status = row.Field<string>("Status"),
                        Deleted = row.Field<bool>("Deleted")
                    };

                    var imgs = processDb.GetData($"SELECT * FROM " +
                        $"Product_Images Where Serial = N'{product.Serial}'");
                    string? url = imgs.Rows[0].Field<string>("Url_image");


                    CreateProductCard(title: product.ProductName, url: url, id: product.Serial, saletPrice: product.SalePrice, purchasePrice: product.PurchasePrice);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm(ListType.PRODUCTS);
            listForm.FormClosed += (sender, args) =>
            {
                Show();
            };

            Hide();
            listForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
