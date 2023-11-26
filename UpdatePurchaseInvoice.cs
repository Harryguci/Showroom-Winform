﻿using ShowroomData.Models;
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
    public partial class UpdatePurchaseInvoice : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private Layout? parent;

        public UpdatePurchaseInvoice(PurchaseInvoice purchaseInvoice, Form? _parent)
        {
            InitializeComponent();
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
            txtIdInvoice.Text = purchaseInvoice.InEnterId;
            txtIdSupplier.Text = purchaseInvoice.SourceId;
            txtIdProduct.Text = purchaseInvoice.ProductId;
            dayDateTimePicker.Value = purchaseInvoice.EnteredDate != null ? purchaseInvoice.EnteredDate.Value : DateTime.Now;
            txtQuantity.Text = purchaseInvoice.QuantityPurchase.ToString();
            txtStatus.Text = purchaseInvoice.Status;
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
        private void UpdatePurchaseInvoiceForm_Resize(object sender, EventArgs e)
        {
            lblHeading.Location = new Point((panel1.Width - lblHeading.Width) / 2,
                lblHeading.Location.Y);
        }

        private void UpdatePurchaseInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (MessageBox.Show("Cập nhật hóa đơn này?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var curr = new
            {
                id = txtIdInvoice.Text.Trim(),
                idSupplier = txtIdSupplier.Text.Trim(),
                idProduct = txtIdProduct.Text.Trim(),
                day = dayDateTimePicker.Value.ToString("yyyy-MM-dd"),
                start = DateTime.Now.ToString("yyyy-MM-dd"),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };

            // Handle Create
            string query = $" UPDATE PurchaseInvoices SET SourceId = N'{curr.idSupplier}', ProductId = N'{curr.idProduct}', " +
                $" Date = N'{curr.day}', QuantityPurchase = N'{curr.quantity}', Status = N'{curr.status}', " +
                $" Deleted = 0 WHERE InEnterId = N'{curr.id}' ";

            // Excute the query
            processDb.UpdateData(query);

            // Earse current data
            CleanForm();

            //
            Dispose();
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            HelperDialog helperDialog = HelperDialog.Create("Trợ giúp",
                "- Bắt buộc nhập đầy đủ thông tin\n" +
                "- Số lượng chỉ có thể nhập số");

            helperDialog.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?.\nDữ liệu chưa lưu sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo)
               == DialogResult.Yes) Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ ký tự không hợp lệ
            }
        }

        //
        // [Helper Methods]
        //
        private bool ValidateForm()
        {
            var curr = new
            {
                idSupplier = txtIdSupplier.Text.Trim(),
                idProduct = txtIdProduct.Text.Trim(),
                quantity = txtQuantity.Text.Trim(),
                status = txtStatus.Text.Trim()
            };


            if (curr.idSupplier.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id nhà cung cấp");
                return false;
            }
            if (curr.idProduct.Length <= 0)
            {
                MessageBox.Show("Bạn phải nhập id sản phẩm");
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}