using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }

        public Employee()
        {
          EmployeeId = Firstname = Lastname = string.Empty;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? Cccd { get; set; }
        public string? Position { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Salary { get; set; }
        public string? Email { get; set; }
        public string? SaleId { get; set; }
        public bool ? Deleted { get; set; }

    }
}
