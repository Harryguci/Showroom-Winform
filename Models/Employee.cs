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

        public Employee(string employeeId, string firstname, string lastname)
        {
            EmployeeId = employeeId;
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? Cccd { get; set; }
        public string? Position { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Salary { get; set; }
        public bool Gender { get; set; }
        public string? Email { get; set; }
        public string? SaleId { get; set; }
    }
}
