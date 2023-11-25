using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShowroomData.Models
{
    public class SalesTarget
    {
        public SalesTarget()
        {
            SaleId = string.Empty;
        }
        public string SaleId { get; set; }

        public string? EmployeeId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Total { get; set; }

        public int? Target { get; set; }

        public string? Status { get; set; }

        public double? Reward { get; set; }
    }
}
