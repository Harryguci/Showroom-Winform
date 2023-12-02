using ShowroomData.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShowroomData
{
    public partial class CreateProduct : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;
        private bool _isCreateOne = false;
        private List<string> _images = new List<string>();
        private int indexImage = 0;
        public CreateProduct(Form? _parent, bool isCreateOne = false)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //if (_parent != null && _parent.GetType() == typeof(Layout))
            //    parent = (Layout?)_parent;

            if (_parent != null && _parent.GetType() == typeof(Layout))
                parent = (Layout)_parent;
            _isCreateOne = isCreateOne;

            //
            // Enable resizing form size (without border)
            //
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
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

        private void PurchaseInvoiceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private string AutoCreateId()
        {
            DataTable tb = processDb.GetData("Select Top 1 Serial From Products Order By Serial DESC");
            string? id = tb.Rows[0]["Serial"].ToString();

            if (id != null)
            {
                int count = Convert.ToInt32(id.Substring(1, id.Length - 1));
                id = Convert.ToString(count + 1);

                while (id.Length < 3) id = "0" + id;
                id = "P" + id;
            }
            else
            {
                id = "P001";
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
                nameProduct = txtNameProduct.Text.Trim(),
                purchasePrice = txtPurchasePrice.Text.Trim(),
                salePrice = txtSalePrice.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            if (curr.nameProduct.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm");
                return false;
            }
            if (curr.purchasePrice.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán");
                return false;
            }
            if (curr.salePrice.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập giá mua");
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
            // Earse current data
            TextBox[] textBoxes = { txtNameProduct, txtPurchasePrice, txtSalePrice, txtQuantity, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdProduct.Text = AutoCreateId();
        }

        private void txtQuantity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Tạo mới sản phẩm này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                nameProduct = txtNameProduct.Text.Trim(),
                idProduct = txtIdProduct.Text.Trim(),
                purchasePrice = txtPurchasePrice.Text.Trim(),
                salePrice = txtSalePrice.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $"INSERT INTO Products (ProductName, Serial, PurchasePrice, SalePrice, Quantity, Status, Deleted) " +
                $"VALUES (N'{curr.nameProduct}',N'{curr.idProduct}',N'{curr.purchasePrice}','{curr.salePrice}', " +
                $"N'{curr.quantity}',N'{curr.status}', 0)";

            // Excute the query
            processDb.UpdateData(query);

            foreach (string img in _images)
            {
                var path = Path.Combine("images", "uploaded",
                    Path.GetFileName(img));
                string qProductImage = "INSERT PRODUCT_IMAGES (\"SERIAL\", \"URL_IMAGE\") VALUES " +
                    $"(N'{curr.idProduct}', N'{path}')";

                while (path.Length > 0 && path[0] == '/')
                {
                    path = path.Substring(1);
                }
                File.Copy(img, Path.Combine(Directory.GetCurrentDirectory(), path));
                processDb.UpdateData(qProductImage);
            }

            // Earse current data
            CleanForm();

            if (_isCreateOne) Close();

            // Refresh Data
            if (parent == null) return;
            parent.RefeshData();
            parent.Refresh();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtNameProduct, txtPurchasePrice, txtSalePrice, txtQuantity, txtStatus };
            for (int i = 0; i < textBoxes.Length; i++)
                textBoxes[i].Text = string.Empty;

            txtIdProduct.Text = AutoCreateId();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Giá mua, giá bán, số lượng chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
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

        private void Product_Load_1(object sender, EventArgs e)
        {
            txtIdProduct.Text = AutoCreateId();
            indexImage = 0;
            btnBackImage.Enabled = false;
            btnNextImage.Enabled = indexImage == 0 || indexImage == _images.Count - 1;
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int purchaseValue = Convert.ToInt32(txtPurchasePrice.Text);
                int salePrice = (int)(purchaseValue * 1.2);
                txtSalePrice.Text = salePrice.ToString();
            }
            catch
            {
                ;
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                pictureProductImage.ImageLocation = ofd.FileName;
                _images.Add(ofd.FileName);
                indexImage = _images.Count - 1;
                btnBackImage.Enabled = indexImage != 0;
                btnNextImage.Enabled = indexImage != _images.Count - 1;
                btnDeleteImage.Enabled = true;
            }
        }

        private void btnBackImage_Click(object sender, EventArgs e)
        {
            indexImage--;
            if (indexImage < 0) indexImage = 0;
            btnBackImage.Enabled = indexImage != 0;
            btnNextImage.Enabled = indexImage != _images.Count - 1;

            pictureProductImage.ImageLocation = _images[indexImage];
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            indexImage++;
            if (indexImage >= _images.Count - 1) indexImage = _images.Count - 1;
            btnBackImage.Enabled = indexImage != 0;
            btnNextImage.Enabled = indexImage != _images.Count - 1;

            pictureProductImage.ImageLocation = _images[indexImage];
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                pictureProductImage.ImageLocation = ofd.FileName;
                _images[indexImage] = ofd.FileName;
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (indexImage > 0 && indexImage < _images.Count)
            {
                _images.RemoveAt(indexImage);
                if (_images.Count == 0)
                {
                    pictureProductImage.ImageLocation = null;
                    btnDeleteImage.Enabled = false;
                }
                else if (_images.Count <= indexImage) indexImage--;
                else
                    pictureProductImage.ImageLocation = _images[indexImage];
            }
        }
    }
}
