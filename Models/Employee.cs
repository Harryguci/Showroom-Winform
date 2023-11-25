using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ShowroomData.Models
{
    public class Employee
    {
        public Employee()
        {
            EmployeeId = Firstname = Lastname = Cccd = Position = string.Empty;
            Salary = 0;
        }

        public string EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? Phone { get; set; }
        public string? Cccd { get; set; }
        public string? Position { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Salary { get; set; }
        public string? Email { get; set; }
        public bool? Gender { get; set; }
        public bool Deleted { get; set; } = false;
        public string? Url_image { get; set; } = string.Empty;
    }
}
