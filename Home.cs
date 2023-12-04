using ShowroomData.Util;

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

            int minWidth = Math.Max(flowLayoutPanel2.Width / 4 - 40, 200);
            minWidth = Math.Min(200, minWidth);

            Size btnSize = new Size(minWidth, minWidth);
            btnCustomers.Size = btnEmployees.Size = btnPuchaInvoices.Size
                = btnProducts.Size = btnSource.Size = btnPuchaInvoices.Size
                = btnDevices.Size = btnSaleInvoice.Size = btnTask.Size = btnAccounts.Size = btnSize;


        }
        private void HandleChangeForm(object sender, EventArgs e)
        {
            string? formName = null;

            if (sender.Equals(btnCustomers))
                formName = TableName.CUSTOMERS;
            else if (sender.Equals(btnEmployees))
                formName = TableName.EMPLOYEES;
            else if (sender.Equals(btnSource))
                formName = TableName.SOURCE;
            else if (sender.Equals(btnPuchaInvoices))
                formName = TableName.PURCHASEINVOICES;
            else if (sender.Equals(btnProducts))
            {
                // formName = TableName.PRODUCTS;
                ProductsGrid productsGrid = new ProductsGrid();

                productsGrid.FormClosed += (sender, args) =>
                    Show();

                Hide();
                productsGrid.Show();

                return;
            }
            else if (sender.Equals(btnDevices))
                formName = TableName.DEVICES;
            else if (sender.Equals(btnSaleInvoice))
                formName = TableName.SALEINVOICES;
            else if (sender.Equals(btnTask))
            {
                if (Layout2.CURR_USER.Level_account < 2)
                {
                    MessageBox.Show("Bạn không được cấp quyền để xem",
                        "Thông Báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                formName = TableName.TASKS;
            }
            else if (sender.Equals(btnAccounts))
                if (Layout2.CURR_USER.Level_account < 2)
                {
                    MessageBox.Show("Bạn không được cấp quyền để xem",
                        "Thông Báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                    formName = TableName.ACCOUNT;
            else
                formName = "employees";

            ListForm form = new ListForm(formName);
            form.Show();
            Hide(); // Hide the current Form.
            form.FormClosed += (s, args) => Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) return;

            Layout2 login = new Layout2();
            Layout2.CURR_USER = new Models.Account();
            login.FormClosed += (sender, args) =>
            {
                Close();
            };

            Hide();
            login.Show();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.FormClosed += (sender, args) => Show();

            Hide();
            report.Show();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            SearchAll searchForm = new SearchAll();
            searchForm.TopMost = true;
            searchForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListForm taskForm = new ListForm(TableName.TASKS);
            taskForm.FormClosed += (f, args) => Show();
            Hide();
            taskForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnCurrAccount.Text = Layout2.CURR_USER.Username;
        }

        private void btnCurrAccount_Click(object sender, EventArgs e)
        {
            UserAccount userAccountForm = new UserAccount();
            userAccountForm.FormClosed += (sender, args) =>
            {
                Show();
            };

            Hide();
            userAccountForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Layout2.CURR_USER.Level_account < 2)
            {
                MessageBox.Show("Bạn không được cấp quyền để xem",
                      "Thông Báo", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                return;
            }
            Layout3 sign = new Layout3();
            sign.TopMost = true;
            sign.FormClosed += (sender, args) => Show();
            //Hide();
            sign.ShowDialog();
        }


        string temptooltiptext = "";
        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font tooltipFont = new Font("Roboto", 20.0f);
            e.DrawBackground();
            //e.DrawBorder();
            temptooltiptext = e.ToolTipText;
            e.Graphics.DrawString(e.ToolTipText,
                tooltipFont, Brushes.White,
                new PointF(2, 2));
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = TextRenderer.MeasureText(
                toolTip1.GetToolTip(e.AssociatedControl),
                new Font("Roboto", 20.0f));
        }
    }
}
