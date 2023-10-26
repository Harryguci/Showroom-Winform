using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ShowroomManagement.Models
{
    public class Products
    {
        public Products()
        {
            Serial = ProductName = string.Empty;
        }
        public string Serial { get; set; }

        public string ProductName { get; set; }

        public int? PurchasePrice { get; set; }
        
        public int? SalePrice { get; set; }
        
        public int? Quantity { get; set; }
        
        public string? Status { get; set; }

        public bool? Deleted { get; set; }
    }   
}
