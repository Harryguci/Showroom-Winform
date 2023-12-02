using ShowroomData.ComponentGUI;
using ShowroomData.Models;
using System.Data;

namespace ShowroomData
{
    public partial class UpdateProduct : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private int indexImage = 0;
        private Products currProduct;
        private List<string> _images = new List<string>();
        private List<string> _allImages = new List<string>();
        private bool isChanged = false;

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
        }

        private void InfoChanged(object? sender, EventArgs e)
        {
            isChanged = true;
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

            foreach (var img in _images)
            {
                string path = Path.Combine("//images//uploaded", Path.GetFileName(img));
                string qProductImage = "INSERT PRODUCT_IMAGES (\"SERIAL\", \"URL_IMAGE\") VALUES " +
                    $"(N'{curr.id}', N'{path}')";

                while (path.Length > 0 && path[0] == '/')
                {
                    path = path.Substring(1);
                }

                File.Copy(img, Path.Combine(Directory.GetCurrentDirectory(), path));

                processDb.UpdateData(qProductImage);
            }

            // Excute the query
            processDb.UpdateData(query);

            foreach (var img in currProduct.ImageUrls)
            {
                if (img.Url_image == string.Empty || img.Url_image == null)
                {
                    processDb.UpdateData($"DELETE PRODUCT_IMAGES WHERE ID = {img.Id}");
                }
                else
                {
                    var t = img.Url_image;
                    while (t[0] == '/') t = t.Substring(1);
                    // t = Path.Combine(Directory.GetCurrentDirectory(), t);
                    processDb.UpdateData($"UPDATE PRODUCT_IMAGES set URl_IMAGE " +
                        $"= N'{t}' WHERE ID = {img.Id}");
                }
            }

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
                    ProductName = query.Rows[0].Field<string>("ProductName") ?? "",
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
                btnImageBack.Enabled = false;

                pictureBox2.ImageLocation = currProduct.ImageUrls[0].Url_image;
            }
        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            if (!isChanged)
                Close();
            else
            {
                MessageBox.Show("Bạn có muốn thoát? Thông tin chưa lưu sẽ bị xóa.",
                    "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Giá mua, giá bán, số lượng chỉ có thể nhập số");

            helperDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isChanged || MessageBox.Show("Bạn có muốn thoát?.\nDữ liệu chưa lưu sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo)
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
            isChanged = false;
        }
        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            //
            // Fill the data of the product which you want to change info.
            //
            txtName.Text = currProduct.ProductName;
            txtId.Text = currProduct.Serial;
            txtPurchasePrice.Text = currProduct.PurchasePrice.ToString();
            txtSalePrice.Text = currProduct.SalePrice.ToString();
            txtQuantity.Text = currProduct.Quantity.ToString();
            txtStatus.Text = currProduct.Status;

            txtName.TextChanged += InfoChanged;
            txtPurchasePrice.TextChanged += InfoChanged;
            txtSalePrice.TextChanged += InfoChanged;
            txtQuantity.TextChanged += InfoChanged;
            txtStatus.TextChanged += InfoChanged;

            Padding p = new Padding(5, 5, 1, 1);
            RoundTextBox.SetPadding(txtName, p);
            RoundTextBox.SetPadding(txtId, p);
            RoundTextBox.SetPadding(txtPurchasePrice, p);
            RoundTextBox.SetPadding(txtSalePrice, p);
            RoundTextBox.SetPadding(txtQuantity, p);
            RoundTextBox.SetPadding(txtStatus, p);


            var imgs = processDb.GetData($"SELECT * FROM Product_Images Where Serial = N'{currProduct.Serial}'");
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
                    if (productImages.Url_image != null)
                    {
                        var url = productImages.Url_image;
                        while (url.Length > 0 && url[0] == '/') url = url.Substring(1);
                        _allImages.Add(Path.Combine(Directory.GetCurrentDirectory(), url));
                    }
                }

                if (currProduct.ImageUrls.Count > 0)
                {
                    string url = currProduct.ImageUrls[0].Url_image ?? "";
                    string rootPath = Path.GetDirectoryName(Application.ExecutablePath) ?? "";
                    while (url.Length > 1 && url[0] == '/') url = url.Substring(1);
                    url = Path.Combine(rootPath, url);
                    pictureBox2.ImageLocation = url;
                }
            }


            if (currProduct.ImageUrls.Count == 0)
            {
                btnImageBack.Enabled = false;
                btnImageNext.Enabled = _allImages.Count != 0;
                btnChangeImage.Enabled = false;
            }
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                pictureBox2.ImageLocation = ofd.FileName;
                _images.Add(ofd.FileName);
                _allImages.Add(ofd.FileName);

                indexImage = _allImages.Count() - 1;
                btnChangeImage.Enabled = true;
                btnBack.Enabled = true;
            }
        }
        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                pictureBox2.ImageLocation = ofd.FileName;
                if (currProduct.ImageUrls.Count > indexImage)
                {
                    // _images[indexImage] = ofd.FileName;
                    currProduct.ImageUrls[indexImage].Url_image
                        = Path.Combine("images", "uploaded", Path.GetFileName(ofd.FileName));
                }
                _allImages[indexImage] = ofd.FileName;

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa ảnh?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            File.Delete(_allImages[indexImage]);
            _allImages.RemoveAt(indexImage);

            if (currProduct.ImageUrls.Count > indexImage)
            {
                currProduct.ImageUrls[indexImage].Url_image = string.Empty;
            }

            indexImage--;
            if (indexImage < 0)
            {
                indexImage = 0;
                btnImageBack.Enabled = false;
                if (_allImages.Count == 0)
                {
                    pictureBox2.ImageLocation = string.Empty;
                    btnImageNext.Enabled = false;
                }
            }
            else pictureBox2.ImageLocation = _allImages[indexImage];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            indexImage--;
            if (indexImage < 0)
            {
                indexImage = 0;
            }

            btnImageNext.Enabled = indexImage != (_allImages.Count() - 1);
            btnImageBack.Enabled = indexImage != 0;

            string url = _allImages[indexImage] ?? "";
            pictureBox2.ImageLocation = url;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            indexImage++;
            if (indexImage >= _allImages.Count())
            {
                indexImage = _allImages.Count() - 1;
            }

            btnImageNext.Enabled = indexImage != (_allImages.Count() - 1);
            btnImageBack.Enabled = indexImage != 0;

            string url = _allImages[indexImage] ?? "";
            pictureBox2.ImageLocation = url;
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPurchasePrice.Text == string.Empty)
            {
                txtSalePrice.Text = string.Empty;
                return;
            }
            int purchasePrice = Convert.ToInt32(txtPurchasePrice.Text);
            int salePrice = (int)(purchasePrice * 1.2);

            txtSalePrice.Text = salePrice.ToString();
        }
    }
}
