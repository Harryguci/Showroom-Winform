using Microsoft.Identity.Client.Extensibility;
using ShowroomData.ComponentGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ShowroomData
{
    public partial class Report : Form
    {
        private ProcessDatabase processDb = new ProcessDatabase();
        private string _reportType = "month";
        private Color _cbtnActive = Color.FromArgb(50, 50, 150);
        private Color _cbtnDisable = Color.FromArgb(200, 200, 200);

        public Report(string reportType = "month")
        {
            InitializeComponent();
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            WindowState = FormWindowState.Maximized;
            txtYear.Text = DateTime.Now.Year.ToString();

            this._reportType = reportType;

            RoundTextBox.SetPadding(txtYear, new Padding(5, 5, 1, 1));
            RoundTextBox.SetPadding(txtEmployeeQuery, new Padding(5, 5, 1, 1));
            txtEmployeeQuery.Visible = false;
            lblEmployeeName.Visible = false;
            lblMonth.Visible = false;
            txtMonth.Visible = false;

            // Default Styles
            lblTitle.Text = "BÁO CÁO THEO THÁNG";
            btnChangeMonth.BackColor = _cbtnActive;
            btnChange3Months.BackColor = _cbtnDisable;
            btnChangeYear.BackColor = _cbtnDisable;
            btnChangeSource.BackColor = _cbtnDisable;
            btnChangeEmployee.BackColor = _cbtnDisable;
        }

        private void Report_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point((Width - pictureBox1.Width) / 2, pictureBox1.Top);
            lblTitle.Size = new Size(Width, lblTitle.Height);
        }

        private void HandleData()
        {
            if (_reportType == "month")
                RenderReportMonths();
            else if (_reportType == "3months")
                RenderReport3Months();
            else if (_reportType == "year")
                RenderReportYear();
            else if (_reportType == "employee")
                RenderReportEmployee();
        }

        private void RenderReportMonths()
        {
            DataTable table = new DataTable($"Showroom Report {txtYear.Text.Trim()}");

            table.Columns.Add("Tháng", typeof(string));
            table.Columns.Add("Tổng số lượng bán", typeof(int));
            table.Columns.Add("Tổng số lượng nhập", typeof(int));
            table.Columns.Add("Tổng doanh thu", typeof(decimal));
            table.Columns.Add("Tổng tiền nhập", typeof(decimal));
            table.Columns.Add("Tổng lợi nhuận", typeof(decimal));

            List<int> qSaleQuantities = new List<int>();
            List<int> qPurchaseQuantities = new List<int>();
            List<decimal> qTotals = new List<decimal>();
            List<decimal> qProfits = new List<decimal>();
            List<decimal> qPurchaseCosts = new List<decimal>();

            int year = Convert.ToInt32(txtYear.Text.Trim());

            for (int i = 1; i <= 12; i++)
            {
                var qSale = processDb.GetData($"SELECT SUM(QuantitySale) AS quantity FROM SalesInvoices WHERE MONTH(SalesInvoices.Date) = {i} AND YEAR(SalesInvoices.Date) = {year}");
                var qPurchase = processDb.GetData($"SELECT SUM(QuantityPurchase) AS quantity FROM PurchaseInvoices WHERE MONTH(PurchaseInvoices.Date) = {i} AND YEAR(PurchaseInvoices.Date) = {year}");
                var qTotal = processDb.GetData($"SELECT SUM(SalesInvoices.QuantitySale * PRODUCTS.SalePrice) AS TOTAL \r\nFROM SalesInvoices\r\nJOIN Products ON SalesInvoices.ProductId = Products.Serial\r\nWHERE YEAR(SalesInvoices.Date) = {year} AND MONTH(SalesInvoices.Date) = {i}");
                var qPurchaseCost = processDb.GetData($"SELECT SUM(PurchaseInvoices.QuantityPurchase * PRODUCTS.PurchasePrice) AS TOTAL \r\nFROM PurchaseInvoices\r\nJOIN Products ON PurchaseInvoices.ProductId = Products.Serial\r\nWHERE YEAR(PurchaseInvoices.Date) = {year} AND MONTH(PurchaseInvoices.Date) = {i}");
                try
                {
                    qSaleQuantities.Add(qSale.Rows[0].Field<int>("quantity"));
                }
                catch
                {
                    qSaleQuantities.Add(0);
                }
                try
                {
                    qPurchaseQuantities.Add(qPurchase.Rows[0].Field<int>("quantity"));
                }
                catch
                {
                    qPurchaseQuantities.Add(0);
                }

                try
                {
                    qTotals.Add(qTotal.Rows[0].Field<int>("TOTAL"));
                }
                catch
                {
                    qTotals.Add(0);
                }

                try
                {
                    qPurchaseCosts.Add(qPurchaseCost.Rows[0].Field<int>("TOTAL"));
                }
                catch
                {
                    qPurchaseCosts.Add(0);
                }

                qProfits.Add((qTotals[i - 1] - qPurchaseCosts[i - 1]));

                table.Rows.Add($"Tháng {i}",
                    qSaleQuantities[i - 1],
                    qPurchaseQuantities[i - 1],
                    qTotals[i - 1],
                    qPurchaseCosts[i - 1],
                    qProfits[i - 1]);
            }


            string allName = "Cả năm";
            int allSaleQuanity = 0;
            int allPurchaseQuantity = 0;
            decimal allTotal = 0;
            decimal allPurchaseCost = 0;
            decimal allProfit = 0;

            for (int i = 0; i <= 11; i++)
            {
                allSaleQuanity += qSaleQuantities[i];
                allPurchaseQuantity += qPurchaseQuantities[i];
                allTotal += qTotals[i];
                allPurchaseCost += qPurchaseCosts[i];
                allProfit += qProfits[i];
            }

            table.Rows.Add(allName, allSaleQuanity, allPurchaseQuantity,
                allTotal, allPurchaseCost, allProfit);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[2].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[3].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[4].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[5].Width = (dataGridView1.Width - 140) / 5;

            // Styles
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.EnableHeadersVisualStyles = false;
            // Create a DataGridViewCellStyle object for the header
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.FromArgb(50, 50, 150); // Set the background color
            style.ForeColor = Color.White; // Set the foreground color
            style.Font = new Font("Roboto", 12f, FontStyle.Bold); // Set the font style

            // Apply the style to the header
            dataGridView1.ColumnHeadersDefaultCellStyle = style;
        }
        private void RenderReport3Months()
        {
            DataTable table = new DataTable($"Showroom Report {txtYear.Text.Trim()}");

            table.Columns.Add("Quý", typeof(string));
            table.Columns.Add("Tổng số lượng bán", typeof(int));
            table.Columns.Add("Tổng số lượng nhập", typeof(int));
            table.Columns.Add("Tổng doanh thu", typeof(decimal));
            table.Columns.Add("Tổng tiền nhập", typeof(decimal));
            table.Columns.Add("Tổng lợi nhuận", typeof(decimal));

            List<int> qSaleQuantities = new List<int>();
            List<int> qPurchaseQuantities = new List<int>();
            List<decimal> qTotals = new List<decimal>();
            List<decimal> qProfits = new List<decimal>();
            List<decimal> qPurchaseCosts = new List<decimal>();

            int year = Convert.ToInt32(txtYear.Text.Trim());

            for (int i = 1; i <= 12; i++)
            {
                var qSale = processDb.GetData($"SELECT SUM(QuantitySale) AS quantity FROM SalesInvoices WHERE MONTH(SalesInvoices.Date) = {i} AND YEAR(SalesInvoices.Date) = {year}");
                var qPurchase = processDb.GetData($"SELECT SUM(QuantityPurchase) AS quantity FROM PurchaseInvoices WHERE MONTH(PurchaseInvoices.Date) = {i} AND YEAR(PurchaseInvoices.Date) = {year}");
                var qTotal = processDb.GetData($"SELECT SUM(SalesInvoices.QuantitySale * PRODUCTS.SalePrice) AS TOTAL \r\nFROM SalesInvoices\r\nJOIN Products ON SalesInvoices.ProductId = Products.Serial\r\nWHERE YEAR(SalesInvoices.Date) = {year} AND MONTH(SalesInvoices.Date) = {i}");
                var qPurchaseCost = processDb.GetData($"SELECT SUM(PurchaseInvoices.QuantityPurchase * PRODUCTS.PurchasePrice) AS TOTAL \r\nFROM PurchaseInvoices\r\nJOIN Products ON PurchaseInvoices.ProductId = Products.Serial\r\nWHERE YEAR(PurchaseInvoices.Date) = {year} AND MONTH(PurchaseInvoices.Date) = {i}");
                try
                {
                    qSaleQuantities.Add(qSale.Rows[0].Field<int>("quantity"));
                }
                catch
                {
                    qSaleQuantities.Add(0);
                }
                try
                {
                    qPurchaseQuantities.Add(qPurchase.Rows[0].Field<int>("quantity"));
                }
                catch
                {
                    qPurchaseQuantities.Add(0);
                }

                try
                {
                    qTotals.Add(qTotal.Rows[0].Field<int>("TOTAL"));
                }
                catch
                {
                    qTotals.Add(0);
                }

                try
                {
                    qPurchaseCosts.Add(qPurchaseCost.Rows[0].Field<int>("TOTAL"));
                }
                catch
                {
                    qPurchaseCosts.Add(0);
                }

                qProfits.Add((qTotals[i - 1] - qPurchaseCosts[i - 1]));
            }

            for (int i = 0; i < 12; i += 3)
            {
                string tName = "Quý " + (i / 3 + 1).ToString();
                int tSaleQuantity = qSaleQuantities[i + 0] + qSaleQuantities[i + 1] + qSaleQuantities[i + 2];
                int tPurchaseQuantity = qPurchaseQuantities[i + 0] + qPurchaseQuantities[i + 1] + qPurchaseQuantities[i + 2];
                decimal tTotal = qTotals[i + 0] + qTotals[i + 1] + qTotals[i + 2];
                decimal tPurchaseCost = qPurchaseCosts[i + 0] + qPurchaseCosts[i + 1] + qPurchaseCosts[i + 2];
                decimal tProfit = qProfits[i + 0] + qProfits[i + 1] + qProfits[i + 2];

                table.Rows.Add(tName, tSaleQuantity, tPurchaseQuantity, tTotal, tPurchaseCost, tProfit);
            }


            string allName = "Cả năm";
            int allSaleQuanity = 0;
            int allPurchaseQuantity = 0;
            decimal allTotal = 0;
            decimal allPurchaseCost = 0;
            decimal allProfit = 0;

            for (int i = 0; i <= 11; i++)
            {
                allSaleQuanity += qSaleQuantities[i];
                allPurchaseQuantity += qPurchaseQuantities[i];
                allTotal += qTotals[i];
                allPurchaseCost += qPurchaseCosts[i];
                allProfit += qProfits[i];
            }

            table.Rows.Add(allName, allSaleQuanity, allPurchaseQuantity,
                allTotal, allPurchaseCost, allProfit);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[2].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[3].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[4].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[5].Width = (dataGridView1.Width - 140) / 5;

            // Styles
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.EnableHeadersVisualStyles = false;
            // Create a DataGridViewCellStyle object for the header
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.FromArgb(50, 50, 150); // Set the background color
            style.ForeColor = Color.White; // Set the foreground color
            style.Font = new Font("Roboto", 12f, FontStyle.Bold); // Set the font style

            // Apply the style to the header
            dataGridView1.ColumnHeadersDefaultCellStyle = style;
        }
        private void RenderReportEmployee()
        {
            var qEmployee = txtEmployeeQuery.Text.Trim().ToLower();
            DataTable query;
            int? year = DateTime.Now.Year;
            int? month = DateTime.Now.Month;

            try
            {
                year = Convert.ToInt32(txtYear.Text);
            }
            catch
            {
                year = null;
            }

            try
            {
                month = Convert.ToInt32(txtMonth.Text);
            }
            catch
            {
                month = null;
            }

            if (qEmployee.Length > 0 && qEmployee != null)
            {
                var t = "SELECT EMPLOYEES.EmployeeId, EMPLOYEES.FirstName, EMPLOYEES.LastName, " +
                    " SalesTargets.Total, SalesTargets.Target," +
                    " SalesTargets.StartDate, SalesTargets.EndDate " +
                    "FROM Employees JOIN SalesTargets ON" +
                    " EMPLOYEES.EmployeeId = SalesTargets.EmployeeId" +
                    $" WHERE " +
                    $"(EMPLOYEES.EmployeeId LIKE N'%{qEmployee}%'" +
                    $" OR EMPLOYEES.FirstName LIKE N'%{qEmployee}%'" +
                    $" OR EMPLOYEES.LastName LIKE N'%{qEmployee}%')";

                if (month != null && year != null)
                    t += $" AND YEAR(SalesTargets.EndDate) = {year} AND MONTH(SalesTargets.EndDate) = {month}";

                query = processDb.GetData(t);
            }
            else
            {
                var t =
                    "SELECT EMPLOYEES.EmployeeId, EMPLOYEES.FirstName, EMPLOYEES.LastName, " +
                    " SalesTargets.Total, SalesTargets.Target," +
                    " SalesTargets.StartDate, SalesTargets.EndDate " +
                    "FROM Employees JOIN SalesTargets ON" +
                    " EMPLOYEES.EmployeeId = SalesTargets.EmployeeId";
                if (year != null && month != null)
                {
                    t += $" WHERE YEAR(SalesTargets.EndDate) = {year} AND MONTH(SalesTargets.EndDate) = {month}";
                }

                query = processDb.GetData(t);
            }

            dataGridView1.DataSource = query;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = (panel1.Width - 200)
                    / dataGridView1.Columns.Count;
            }
        }
        private void RenderReportYear()
        {
            DataTable table = new DataTable($"Showroom Report {txtYear.Text.Trim()}");

            table.Columns.Add("Năm", typeof(string));
            table.Columns.Add("Tổng số lượng bán", typeof(int));
            table.Columns.Add("Tổng số lượng nhập", typeof(int));
            table.Columns.Add("Tổng doanh thu", typeof(decimal));
            table.Columns.Add("Tổng tiền nhập", typeof(decimal));
            table.Columns.Add("Tổng lợi nhuận", typeof(decimal));

            List<int> qSaleQuantities = new List<int>();
            List<int> qPurchaseQuantities = new List<int>();
            List<decimal> qTotals = new List<decimal>();
            List<decimal> qProfits = new List<decimal>();
            List<decimal> qPurchaseCosts = new List<decimal>();

            int year = Convert.ToInt32(txtYear.Text.Trim());
            int count = 0;

            for (int i = year - 10; i <= year; i++)
            {
                var qSale = processDb.GetData($"SELECT SUM(QuantitySale) AS quantity FROM SalesInvoices WHERE YEAR(SalesInvoices.Date) = {i}");
                var qPurchase = processDb.GetData($"SELECT SUM(QuantityPurchase) AS quantity FROM PurchaseInvoices WHERE YEAR(PurchaseInvoices.Date) = {i}");
                var qTotal = processDb.GetData($"SELECT SUM(SalesInvoices.QuantitySale * PRODUCTS.SalePrice) AS TOTAL \r\nFROM SalesInvoices\r\nJOIN Products ON SalesInvoices.ProductId = Products.Serial\r\nWHERE YEAR(SalesInvoices.Date) = {i}");
                var qPurchaseCost = processDb.GetData($"SELECT SUM(PurchaseInvoices.QuantityPurchase * PRODUCTS.PurchasePrice) AS TOTAL \r\nFROM PurchaseInvoices\r\nJOIN Products ON PurchaseInvoices.ProductId = Products.Serial\r\nWHERE YEAR(PurchaseInvoices.Date) = {i}");
                try
                {
                    qSaleQuantities.Add(qSale.Rows[0].Field<int>("quantity"));
                }
                catch
                {
                    qSaleQuantities.Add(0);
                }
                try
                {
                    qPurchaseQuantities.Add(qPurchase.Rows[0].Field<int>("quantity"));
                }
                catch
                {
                    qPurchaseQuantities.Add(0);
                }

                try
                {
                    qTotals.Add(qTotal.Rows[0].Field<int>("TOTAL"));
                }
                catch
                {
                    qTotals.Add(0);
                }

                try
                {
                    qPurchaseCosts.Add(qPurchaseCost.Rows[0].Field<int>("TOTAL"));
                }
                catch
                {
                    qPurchaseCosts.Add(0);
                }

                qProfits.Add((qTotals[count] - qPurchaseCosts[count]));

                table.Rows.Add($"Năm {i}",
                    qSaleQuantities[count],
                    qPurchaseQuantities[count],
                    qTotals[count],
                    qPurchaseCosts[count],
                    qProfits[count]);

                count++;
            }

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[2].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[3].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[4].Width = (dataGridView1.Width - 140) / 5;
            dataGridView1.Columns[5].Width = (dataGridView1.Width - 140) / 5;

            // Styles
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.EnableHeadersVisualStyles = false;
            // Create a DataGridViewCellStyle object for the header
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.FromArgb(50, 50, 150); // Set the background color
            style.ForeColor = Color.White; // Set the foreground color
            style.Font = new Font("Roboto", 12f, FontStyle.Bold); // Set the font style

            // Apply the style to the header
            dataGridView1.ColumnHeadersDefaultCellStyle = style;
        }
        private void Report_Load(object sender, EventArgs e)
        {
            HandleData();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            HandleData();
        }

        private void ExportReportMonth()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            worksheet.Cells[2, 2] = "Báo cáo năm " + txtYear.Text.Trim();
            worksheet.Cells[2, 2].Font.Bold = true;
            worksheet.Cells[2, 2].Font.Size = 20;

            Excel.Range range = worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 4]];

            // Merge the cells into one
            range.Merge();

            worksheet.Cells[5, 1] = "Tháng";
            worksheet.Cells[5, 2] = "Số lượng bán";
            worksheet.Cells[5, 3] = "Số lượng nhập";
            worksheet.Cells[5, 4] = "Tổng doanh thu";
            worksheet.Cells[5, 5] = "Tổng tiền nhập";
            worksheet.Cells[5, 6] = "Tổng lợi nhuận";

            Excel.Range headerRange = worksheet.Range["A5:F5"];
            headerRange.Font.Bold = true;

            headerRange.Interior.Color = System.Drawing.Color.LightGray;

            headerRange.Font.Size = 14F;

            worksheet.Range["A5:F18"].Borders.Color = System.Drawing.Color.Black;

            // Format độ rộng
            int startColumn = 1; // Cột A
            int endColumn = 6; // Cột G
            int desiredWidth = 30; // Độ rộng mong muốn
            for (int col = startColumn; col <= endColumn; col++)
            {
                Excel.Range column1 = (Excel.Range)worksheet.Columns[col];
                column1.ColumnWidth = desiredWidth;
            }

            // căn chỉnh 
            Excel.Range dataRangee = worksheet.UsedRange;

            for (int col = 1; col <= dataRangee.Columns.Count; col++)
            {
                Excel.Range column = (Excel.Range)dataRangee.Columns[col];

                // Kiểm tra nếu cột không thuộc A1, A2, A3 và nằm trong khoảng từ A đến H
                if (column.Cells[1, 1].Address != "$A$1" && column.Cells[1, 1].Address != "$A$2" && column.Cells[1, 1].Address != "$A$3" && col >= 1 && col <= 8)
                {
                    column.HorizontalAlignment = Excel.Constants.xlCenter; // Căn giữa ngang
                    column.VerticalAlignment = Excel.Constants.xlCenter; // Căn giữa dọc
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    worksheet.Cells[i + 6, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save file...";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show("Lưu file thành công");
            }
        }
        private void ExportReport3Months()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            worksheet.Cells[2, 2] = "Báo cáo năm " + txtYear.Text.Trim();
            worksheet.Cells[2, 2].Font.Bold = true;
            worksheet.Cells[2, 2].Font.Size = 20;

            Excel.Range range = worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 4]];

            // Merge the cells into one
            range.Merge();

            worksheet.Cells[5, 1] = "Quý";
            worksheet.Cells[5, 2] = "Số lượng bán";
            worksheet.Cells[5, 3] = "Số lượng nhập";
            worksheet.Cells[5, 4] = "Tổng doanh thu";
            worksheet.Cells[5, 5] = "Tổng tiền nhập";
            worksheet.Cells[5, 6] = "Tổng lợi nhuận";

            Excel.Range headerRange = worksheet.Range["A5:F5"];
            headerRange.Font.Bold = true;

            headerRange.Interior.Color = System.Drawing.Color.LightGray;

            headerRange.Font.Size = 14F;

            worksheet.Range["A5:F10"].Borders.Color = System.Drawing.Color.Black;

            // Format độ rộng
            int startColumn = 1; // Cột A
            int endColumn = 6; // Cột G
            int desiredWidth = 30; // Độ rộng mong muốn
            for (int col = startColumn; col <= endColumn; col++)
            {
                Excel.Range column1 = (Excel.Range)worksheet.Columns[col];
                column1.ColumnWidth = desiredWidth;
            }

            // căn chỉnh 
            Excel.Range dataRangee = worksheet.UsedRange;

            for (int col = 1; col <= dataRangee.Columns.Count; col++)
            {
                Excel.Range column = (Excel.Range)dataRangee.Columns[col];

                // Kiểm tra nếu cột không thuộc A1, A2, A3 và nằm trong khoảng từ A đến H
                if (column.Cells[1, 1].Address != "$A$1" && column.Cells[1, 1].Address != "$A$2" && column.Cells[1, 1].Address != "$A$3" && col >= 1 && col <= 8)
                {
                    column.HorizontalAlignment = Excel.Constants.xlCenter; // Căn giữa ngang
                    column.VerticalAlignment = Excel.Constants.xlCenter; // Căn giữa dọc
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    worksheet.Cells[i + 6, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save file...";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show("Lưu file thành công");
            }
        }
        private void ExportReportYear()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            worksheet.Cells[2, 2] = "Báo cáo từ năm " + (Convert.ToInt32(txtYear.Text.Trim()) - 10) + " đến " + txtYear.Text.Trim();
            worksheet.Cells[2, 2].Font.Bold = true;
            worksheet.Cells[2, 2].Font.Size = 20;

            Excel.Range range = worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 4]];

            // Merge the cells into one
            range.Merge();

            worksheet.Cells[5, 1] = "Năm";
            worksheet.Cells[5, 2] = "Số lượng bán";
            worksheet.Cells[5, 3] = "Số lượng nhập";
            worksheet.Cells[5, 4] = "Tổng doanh thu";
            worksheet.Cells[5, 5] = "Tổng tiền nhập";
            worksheet.Cells[5, 6] = "Tổng lợi nhuận";

            Excel.Range headerRange = worksheet.Range["A5:F5"];
            headerRange.Font.Bold = true;

            headerRange.Interior.Color = System.Drawing.Color.LightGray;

            headerRange.Font.Size = 14F;

            worksheet.Range["A5:F16"].Borders.Color = System.Drawing.Color.Black;

            // Format độ rộng
            int startColumn = 1; // Cột A
            int endColumn = 6; // Cột G
            int desiredWidth = 30; // Độ rộng mong muốn
            for (int col = startColumn; col <= endColumn; col++)
            {
                Excel.Range column1 = (Excel.Range)worksheet.Columns[col];
                column1.ColumnWidth = desiredWidth;
            }

            // căn chỉnh 
            Excel.Range dataRangee = worksheet.UsedRange;

            for (int col = 1; col <= dataRangee.Columns.Count; col++)
            {
                Excel.Range column = (Excel.Range)dataRangee.Columns[col];

                // Kiểm tra nếu cột không thuộc A1, A2, A3 và nằm trong khoảng từ A đến H
                if (column.Cells[1, 1].Address != "$A$1" && column.Cells[1, 1].Address != "$A$2" && column.Cells[1, 1].Address != "$A$3" && col >= 1 && col <= 8)
                {
                    column.HorizontalAlignment = Excel.Constants.xlCenter; // Căn giữa ngang
                    column.VerticalAlignment = Excel.Constants.xlCenter; // Căn giữa dọc
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    worksheet.Cells[i + 6, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save file...";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show("Lưu file thành công");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (_reportType == "month") ExportReportMonth();
            else if (_reportType == "3months") ExportReport3Months();
            else if (_reportType == "year") ExportReportYear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HandleData();
        }

        private void btn3Months_Click(object sender, EventArgs e)
        {
            txtEmployeeQuery.Visible = false;
            lblEmployeeName.Visible = false;
            lblMonth.Visible = false;
            txtMonth.Visible = false;

            _reportType = "3months";
            HandleData();

            // Change btn Styles
            lblTitle.Text = "Báo cáo theo quý".ToUpper();

            btnChangeMonth.BackColor = _cbtnDisable;
            btnChange3Months.BackColor = _cbtnActive;
            btnChangeYear.BackColor = _cbtnDisable;
            btnChangeSource.BackColor = _cbtnDisable;
            btnChangeEmployee.BackColor = _cbtnDisable;
        }

        private void btnChangeMonth_Click(object sender, EventArgs e)
        {
            txtEmployeeQuery.Visible = false;
            lblEmployeeName.Visible = false;
            lblMonth.Visible = false;
            txtMonth.Visible = false;
            _reportType = "month";
            HandleData();

            // Change btn Styles
            lblTitle.Text = "BÁO CÁO THEO THÁNG";

            btnChangeMonth.BackColor = _cbtnActive;
            btnChange3Months.BackColor = _cbtnDisable;
            btnChangeYear.BackColor = _cbtnDisable;
            btnChangeSource.BackColor = _cbtnDisable;
            btnChangeEmployee.BackColor = _cbtnDisable;
        }

        private void btnChangeYear_Click(object sender, EventArgs e)
        {
            txtEmployeeQuery.Visible = false;
            lblEmployeeName.Visible = false;
            lblMonth.Visible = false;
            txtMonth.Visible = false;
            _reportType = "year";
            HandleData();
            // Change btn Styles
            lblTitle.Text = "BÁO CÁO THEO NĂM";
            btnChangeMonth.BackColor = _cbtnDisable;
            btnChange3Months.BackColor = _cbtnDisable;
            btnChangeYear.BackColor = _cbtnActive;
            btnChangeSource.BackColor = _cbtnDisable;
            btnChangeEmployee.BackColor = _cbtnDisable;
        }

        private void btnChangeEmployee_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tính năng đang nâng cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEmployeeQuery.Visible = true;
            lblEmployeeName.Visible = true;
            lblMonth.Visible = true;
            txtMonth.Visible = true;

            _reportType = "employee";
            RenderReportEmployee();

            btnChangeMonth.BackColor = _cbtnDisable;
            btnChange3Months.BackColor = _cbtnDisable;
            btnChangeYear.BackColor = _cbtnDisable;
            btnChangeSource.BackColor = _cbtnDisable;
            btnChangeEmployee.BackColor = _cbtnActive;
        }

        private void btnChangeSource_Click(object sender, EventArgs e)
        {
            txtEmployeeQuery.Visible = false;
            lblEmployeeName.Visible = false;
            lblMonth.Visible = false;
            txtMonth.Visible = false;
            MessageBox.Show("Tính năng đang nâng cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar > '9' || e.KeyChar < '0'))
            {
                e.Handled = true;
            }

            // Check if the keypress is backspace
            if (e.KeyChar == (char)Keys.Back && txtYear.Text.Length <= 1)
            {
                e.Handled = true;
                txtYear.Text = DateTime.Now.Year.ToString();
            }
        }

        private void txtEmployeeQuery_TextChanged(object sender, EventArgs e)
        {
            string q = txtEmployeeQuery.Text.Trim().ToLower();
            RenderReportEmployee();
        }
    }
}
