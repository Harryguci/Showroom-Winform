using ShowroomData.ComponentGUI;
using ShowroomData.Models;
using ShowroomData.Util;
using System.Data;

namespace ShowroomData
{
    public partial class ProductsGrid : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        public ProductsGrid()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            tabControl1.SelectedIndexChanged += tabPage_ChangeFocus;

            Padding tPadding = new Padding(5, 5, 1, 1);
            RoundTextBox.SetPadding(textBox1, tPadding);
            RoundTextBox.SetPadding(txtPurchasePriceMax, tPadding);
            RoundTextBox.SetPadding(txtPurchasePriceMin, tPadding);
            RoundTextBox.SetPadding(txtSalePriceMax, tPadding);
            RoundTextBox.SetPadding(txtSalePriceMin, tPadding);
        }

        private FlowLayoutPanel CreateOneProductCard(string? title = "Default Name",
            string? url = "",
            string? id = "",
            int? saletPrice = 0,
            int? purchasePrice = 0)
        {
            Panel panel0 = new Panel();
            Label label0 = new Label();
            Label labelSalePrice = new Label();
            Label labelPurchasePrice = new Label();
            PictureBox pictureBox0 = new PictureBox();

            if (tabControl1.SelectedTab == tabPage1) flowLayoutPanel1.SuspendLayout();
            else if (tabControl1.SelectedTab == tabPage2) flowLayoutPanel2.SuspendLayout();
            else if (tabControl1.SelectedTab == tabPage3) flowLayoutPanel3.SuspendLayout();
            else if (tabControl1.SelectedTab == tabPage4) flowLayoutPanel4.SuspendLayout();
            else if (tabControl1.SelectedTab == tabPage5) flowLayoutPanel5.SuspendLayout();
            else if (tabControl1.SelectedTab == tabPage6) flowLayoutPanel6.SuspendLayout();

            panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).BeginInit();
            // 
            // panel1
            // 
            panel0.Controls.Add(labelSalePrice);
            panel0.Controls.Add(labelPurchasePrice);
            panel0.Controls.Add(label0);
            panel0.Controls.Add(pictureBox0);
            panel0.Location = new Point(3, 3);
            panel0.Name = "panel1";
            panel0.Size = new Size(Math.Max(flowLayoutPanel1.Width / 4, 200) - 10, 255);
            panel0.TabIndex = 0;
            panel0.BackColor = Color.FromArgb(30, 30, 30);
            panel0.Margin = new Padding(0, 10, 0, 10);
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
            label0.ForeColor = Color.FromArgb(255, 255, 255);
            label0.Font = new Font("Roboto", 16, FontStyle.Bold);
            label0.Cursor = Cursors.Hand;
            label0.MouseHover += (label0, args) =>
                {
                    if (label0 == null) return;

                    ((Label)label0).ForeColor = Color.FromArgb(150, 150, 255);
                };
            label0.MouseLeave += (label0, args) =>
            {
                if (label0 == null) return;

                ((Label)label0).ForeColor = Color.FromArgb(255, 255, 255);
            };
            label0.Click += (label0, args) =>
            {
                var q = processDb.GetData($"SELECT * FROM PRODUCTS WHERE SERIAL = N'{id}'");
                if (q == null || q.Rows.Count == 0) return;

                Products currProduct = new Products()
                {
                    ProductName = q.Rows[0].Field<string>("ProductName") ?? "",
                    Serial = q.Rows[0].Field<string>("Serial") ?? "",
                    PurchasePrice = q.Rows[0].Field<int>("PurchasePrice"),
                    SalePrice = q.Rows[0].Field<int>("SalePrice"),
                    Quantity = q.Rows[0].Field<int>("Quantity"),
                    Status = q.Rows[0].Field<string>("Status") ?? "",
                    Deleted = q.Rows[0].Field<bool>("Deleted")
                };

                UpdateProduct detailProduct = new UpdateProduct(currProduct, this);
                detailProduct.Show();
            };

            // 
            // label2
            // 
            int contentTop = 210;
            labelSalePrice.AutoSize = true;
            labelSalePrice.Location = new Point(panel0.Left + 50, contentTop);
            labelSalePrice.Name = "labelsale" + id;
            labelSalePrice.TabIndex = 1;
            labelSalePrice.Text = "Giá bán: " + saletPrice.ToString() + "TR.VND";
            labelSalePrice.TextAlign = ContentAlignment.MiddleCenter;
            labelSalePrice.ForeColor = Color.FromArgb(255, 255, 255);
            labelSalePrice.Font = new Font("Roboto", 9, FontStyle.Regular);
            // 
            // label2
            // 
            labelPurchasePrice.AutoSize = true;
            labelPurchasePrice.Location = new Point(panel0.Left + 50, contentTop + 20);
            labelPurchasePrice.Name = "labelpurchase" + id;
            labelPurchasePrice.TabIndex = 1;
            labelPurchasePrice.Text = "Giá nhập: " + purchasePrice.ToString() + "TR.VND";
            labelPurchasePrice.TextAlign = ContentAlignment.MiddleCenter;
            labelPurchasePrice.ForeColor = Color.FromArgb(255, 255, 255);
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
            pictureBox0.BackColor = Color.FromArgb(0, 30, 30, 30);
            pictureBox0.TabIndex = 0;
            pictureBox0.TabStop = false;
            ((System.ComponentModel.ISupportInitialize)pictureBox0).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);

            if (tabControl1.SelectedTab == tabPage1) flowLayoutPanel1.ResumeLayout(false);
            else if (tabControl1.SelectedTab == tabPage2) flowLayoutPanel2.ResumeLayout(false);
            else if (tabControl1.SelectedTab == tabPage3) flowLayoutPanel3.ResumeLayout(false);
            else if (tabControl1.SelectedTab == tabPage4) flowLayoutPanel4.ResumeLayout(false);
            else if (tabControl1.SelectedTab == tabPage5) flowLayoutPanel5.ResumeLayout(false);
            else if (tabControl1.SelectedTab == tabPage6) flowLayoutPanel6.ResumeLayout(false);

            panel0.ResumeLayout(false);
            panel0.PerformLayout();

            if (tabControl1.SelectedTab == tabPage1) flowLayoutPanel1.Controls.Add(panel0);
            else if (tabControl1.SelectedTab == tabPage2) flowLayoutPanel2.Controls.Add(panel0);
            else if (tabControl1.SelectedTab == tabPage3) flowLayoutPanel3.Controls.Add(panel0);
            else if (tabControl1.SelectedTab == tabPage4) flowLayoutPanel4.Controls.Add(panel0);
            else if (tabControl1.SelectedTab == tabPage5) flowLayoutPanel5.Controls.Add(panel0);
            else if (tabControl1.SelectedTab == tabPage6) flowLayoutPanel6.Controls.Add(panel0);

            if (tabControl1.SelectedTab == tabPage1)
                return flowLayoutPanel1;
            else if (tabControl1.SelectedTab == tabPage2)
                return flowLayoutPanel2;
            else if (tabControl1.SelectedTab == tabPage3)
                return flowLayoutPanel3;
            else if (tabControl1.SelectedTab == tabPage4)
                return flowLayoutPanel4;
            else if (tabControl1.SelectedTab == tabPage5)
                return flowLayoutPanel5;
            else if (tabControl1.SelectedTab == tabPage6)
                return flowLayoutPanel6;
            else return flowLayoutPanel1;
        }

        private void LoadTabData()
        {
            DataTable query;
            string qName = textBox1.Text.ToLower().Trim();
            string qColor = comboBox1.Text.ToLower().Trim();
            int qCost = Convert.ToInt32(txtSalePriceMin.Text.ToLower().Trim().Length == 0 ? "0"
                : txtSalePriceMin.Text.ToLower().Trim());
            int qPurchaseCost = Convert.ToInt32(txtPurchasePriceMin.Text.ToLower().Trim().Length == 0 ? "0"
                : txtPurchasePriceMin.Text.ToLower());

            int qMaxCost = Convert.ToInt32(txtSalePriceMax.Text.ToLower().Trim().Length == 0 ? "0"
                : txtSalePriceMax.Text.ToLower().Trim());
            int qPurchaseMaxCost = Convert.ToInt32(txtPurchasePriceMax.Text.ToLower().Trim().Length == 0 ? "0"
                : txtPurchasePriceMax.Text.ToLower());

            if (qMaxCost == 0) qMaxCost = 99999;
            if (qPurchaseMaxCost == 0) qPurchaseMaxCost = 99999;

            if (tabControl1.SelectedTab == tabPage1) query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE ProductName Like N'%{qName}%'");
            else if (tabControl1.SelectedTab == tabPage2) query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE ProductName Like N'%{tabPage2.Text.ToLower().Trim()}%'");
            else if (tabControl1.SelectedTab == tabPage3) query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE ProductName Like N'%{tabPage3.Text.ToLower().Trim()}%'");
            else if (tabControl1.SelectedTab == tabPage4) query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE ProductName Like N'%{tabPage4.Text.ToLower().Trim()}%'");
            else if (tabControl1.SelectedTab == tabPage5) query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE ProductName Like N'%{tabPage5.Text.ToLower().Trim()}%'");
            else if (tabControl1.SelectedTab == tabPage6) query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE ProductName Like N'%{tabPage6.Text.ToLower().Trim()}%'");
            else query = processDb.GetData($"SELECT * FROM PRODUCTS");

            if (query.Rows.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                flowLayoutPanel3.Controls.Clear();
                flowLayoutPanel4.Controls.Clear();
                flowLayoutPanel5.Controls.Clear();
                flowLayoutPanel6.Controls.Clear();

                foreach (DataRow row in query.Rows)
                {
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

                    if (!product.ProductName.ToLower().Contains(qName)) continue;
                    if (product.SalePrice < qCost || product.SalePrice > qMaxCost) continue;
                    if (product.PurchasePrice < qPurchaseCost || product.PurchasePrice > qPurchaseMaxCost) continue;

                    var imgs = processDb.GetData($"SELECT * FROM " +
                        $"Product_Images Where Serial = N'{product.Serial}'");

                    string? url = imgs.Rows[0].Field<string>("Url_image");

                    CreateOneProductCard(title: product.ProductName,
                        url: url, id: product.Serial, saletPrice: product.SalePrice,
                        purchasePrice: product.PurchasePrice);
                }
            }
        }

        private void ProductsGrid_Load(object sender, EventArgs e)
        {
            LoadTabData();
        }

        private void ProductsGrid_Resize(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(Width - 300, Height);
            tabControl1.Location = new Point(300, 0);
            panel1.Size = new Size(300, Height);
            flowLayoutPanel1.Size = new Size(tabControl1.Width, tabControl1.Height);
            flowLayoutPanel2.Size = new Size(tabControl1.Width, tabControl1.Height);
            flowLayoutPanel3.Size = new Size(tabControl1.Width, tabControl1.Height);
            flowLayoutPanel4.Size = new Size(tabControl1.Width, tabControl1.Height);
            flowLayoutPanel5.Size = new Size(tabControl1.Width, tabControl1.Height);
            flowLayoutPanel6.Size = new Size(tabControl1.Width, tabControl1.Height);
            pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, pictureBox1.Top);

            textBox1.Size = txtSalePriceMin.Size = txtSalePriceMax.Size =
                txtPurchasePriceMin.Size = txtPurchasePriceMax.Size =
                comboBox1.Size = new Size(panel1.Width - 30, textBox1.Height);

            btnSearch.Size = new Size(panel1.Width - btnReset.Width - 40, btnSearch.Height);

            btnBack.Size = new Size(panel1.Width, btnBack.Height);
            btnShowList.Size = new Size(panel1.Width, btnShowList.Height);

            btnBack.Location = new Point(0, Height - btnShowList.Height * 2 - 10);
            btnShowList.Location = new Point(0, Height - btnShowList.Height - 10);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = txtSalePriceMin.Text = comboBox1.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTabData();
        }

        private void btnShowList_Click(object sender, EventArgs e)
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

        private void tabPage_ChangeFocus(object? sender, EventArgs e)
        {
            LoadTabData();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            LoadTabData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
