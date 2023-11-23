using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class SalesTarget
    {
        public SalesTarget()
        {
            SaleId = String.Empty;
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
