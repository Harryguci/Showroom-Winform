using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ShowroomData.Models
{
    public class Products
    {
        public string Serial { get; set; }
        public string ProductName { get; set; }
        public int? PurchasePrice { get; set; }
        public int? SalePrice { get; set; }
        public int? Quantity { get; set; }
        public string? Status { get; set; }
        public bool? Deleted { get; set; } = false;
        public List<ProductImages>? ImageUrls { get; set; }
        public Products()
        {
            Serial = string.Empty;
            ProductName = string.Empty;
        }
    }   
}
