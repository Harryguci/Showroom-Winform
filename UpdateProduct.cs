using ShowroomData.Models;
using System.Data;
using System.Security.Policy;

namespace ShowroomData
{
    public partial class UpdateProduct : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private int indexImage = 0;
        private Products currProduct;

        // Constructor
        public UpdateProduct(Products product, Form? _parent)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            currProduct = product;
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
            txtName.Text = product.ProductName;
            txtId.Text = product.Serial;
            txtPurchasePrice.Text = product.PurchasePrice.ToString();
            txtSalePrice.Text = product.SalePrice.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            txtStatus.Text = product.Status;
            button4.Enabled = false;

            var imgs = processDb.GetData($"SELECT * FROM Product_Images Where Serial = N'{product.Serial}'");
            if (imgs.Rows.Count > 0)
            {

                foreach (DataRow row in imgs.Rows)
                {
                    ProductImages productImages = new ProductImages()
                    {
                        Id = row.Field<int>("Id"),
                        Serial = row.Field<string>("Serial"),
                        Url_image = row.Field<string>("Url_image")
                    };
                    currProduct.ImageUrls.Add(productImages);
                }

                if (currProduct.ImageUrls.Count > 0)
                {
                    string url = currProduct.ImageUrls[0].Url_image ?? "";
                    string rootPath = Path.GetDirectoryName(Application.ExecutablePath) ?? "";
                    url = Path.Combine(rootPath, url.Substring(1));
                    pictureBox2.ImageLocation = url;
                }
            }
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
        private void UpdateProductForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật sản phẩm này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtId.Text.Trim(),
                name = txtName.Text.Trim(),
                purchasePrice = txtPurchasePrice.Text.Trim(),
                salePrice = txtSalePrice.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $" UPDATE Products SET ProductName = N'{curr.name}', PurchasePrice = N'{curr.purchasePrice}', " +
                $" SalePrice = N'{curr.salePrice}', Quantity = N'{curr.quantity}', Status = N'{curr.status}', " +
                $" Deleted = 0 WHERE Serial = N'{curr.id}' ";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            var query = processDb.GetData($"SELECT * FROM PRODUCTS WHERE SERIAL = N'{currProduct.Serial}'");

            if (query != null && query.Rows.Count > 0)
            {
                List<ProductImages> imgs = currProduct.ImageUrls;
                currProduct = new Products()
                {
                    ProductName = query.Rows[0].Field<string>("ProductName")??"",
                    Serial = query.Rows[0].Field<string>("Serial") ?? "",
                    PurchasePrice = query.Rows[0].Field<int>("PurchasePrice"),
                    SalePrice = query.Rows[0].Field<int>("SalePrice"),
                    Quantity = query.Rows[0].Field<int>("Quantity"),
                    Status = query.Rows[0].Field<string>("Status"),
                    Deleted = query.Rows[0].Field<bool>("Deleted"),
                    ImageUrls = imgs
                };

                //
                // Fill the data of the product which you want to change info.
                //
                txtName.Text = currProduct.ProductName;
                txtId.Text = currProduct.Serial;
                txtPurchasePrice.Text = currProduct.PurchasePrice.ToString();
                txtSalePrice.Text = currProduct.SalePrice.ToString();
                txtQuantity.Text = currProduct.Quantity.ToString();
                txtStatus.Text = currProduct.Status;
                button4.Enabled = false;

                pictureBox2.ImageLocation = currProduct.ImageUrls[0].Url_image;
            }
        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Giá mua, giá bán, số lượng chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
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
                name = txtName.Text.Trim(),
                purchasePrice = txtPurchasePrice.Text.Trim(),
                salePrice = txtSalePrice.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };


            if (curr.name.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên");
                return false;
            }
            if (curr.purchasePrice.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập giá mua");
                return false;
            }
            if (curr.salePrice.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán");
                return false;
            }
            if (curr.quantity.Length <= 0)
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
            //TO DO
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                pictureBox2.ImageLocation = ofd.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indexImage--;
            if (indexImage < 0)
            {
                indexImage = 0;
            }

            if (indexImage == 0) button4.Enabled = false;
            else button4.Enabled = true;

            button5.Enabled = true;

            string rootPath = Path.GetDirectoryName(Application.ExecutablePath) ?? "";
            string url = currProduct.ImageUrls[indexImage].Url_image ?? "";
            url = Path.Combine(rootPath, url.Substring(1));

            pictureBox2.ImageLocation = url;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            indexImage++;
            if (indexImage >= currProduct.ImageUrls.Count())
            {
                indexImage = currProduct.ImageUrls.Count() - 1;
            }

            if (indexImage == currProduct.ImageUrls.Count() - 1) button5.Enabled = false;
            else button5.Enabled = true;

            button4.Enabled = true;

            string rootPath = Path.GetDirectoryName(Application.ExecutablePath) ?? "";
            string url = currProduct.ImageUrls[indexImage].Url_image ?? "";
            url = Path.Combine(rootPath, url.Substring(1));

            pictureBox2.ImageLocation = url;
        }
    }
}
