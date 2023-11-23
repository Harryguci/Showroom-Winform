using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class SalesInvoice
    {
        public SalesInvoice()
        {
            InSaleId = ClientId = ProductId = string.Empty;
        }
        public string InSaleId { get; set; }
        public string ClientId { get; set; }
        public string EmployeeId { get; set; }
        public string ProductId { get; set; }
        public DateTime? SaleDate { get; set; }
        public string? Status { get; set; }
        public int? QuantitySale { get; set; }
        public bool? Deleted { get; set; }
    }
}
