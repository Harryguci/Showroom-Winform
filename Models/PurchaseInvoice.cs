using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class PurchaseInvoice
    {
        public PurchaseInvoice() {
            InEnterId = SourceId = string.Empty;
        }
        public string InEnterId { get; set; }
        public string SourceId { get; set; }
        public string ProductID { get; set; }
        public DateTime? EnteredDate { get; set; }
        public int? QuantityPurchase { get; set; }
        public string? Status { get; set; }
        public bool? Deleted { get; set; }
    }
}
