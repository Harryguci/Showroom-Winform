using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShowroomManagement.Models
{
    public class SalesInvoice
    {
        public SalesInvoice()
        {
            InSaleId = ClientId = ProductId = string.Empty;
        }
        public string InSaleId { get; set; }
        public string ClientId { get; set; }
        public string ProductId { get; set; }
        public DateTime SaleDate { get; set; }
        public string? Status { get; set; }
        public int? QuantitySale { get; set; }
        public bool? Deleted { get; set; }
    }
}
