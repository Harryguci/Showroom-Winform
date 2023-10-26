using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ShowroomManagement.Models
{
    public class SalesTarget
    {
        public SalesTarget()
        {
            SaleId = String.Empty;
        }
        public string SaleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Total { get; set; }
        public int Target { get; set; }
        public string? Status { get; set; }
        public float? Reward { get; set; }
    }
}
