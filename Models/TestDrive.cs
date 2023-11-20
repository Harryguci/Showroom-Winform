using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace ShowroomData.Models
{
    public class TestDrive
    {
        public TestDrive()
        {
            DriveId = ClientId = EmployeeId = string.Empty;
        }
        public string DriveId { get; set; }
        public string ClientId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime BookDate { get; set; } = DateTime.Now;
        public string? Note { get; set; }
        public string? Status { get; set; }
    }
}
