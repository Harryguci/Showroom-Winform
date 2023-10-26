using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShowroomManagement.Models
{
    public class Account
    {
        public Account()
        {
            Username = Password = string.Empty;    
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? EmployeeId { get; set; }
        public int? Level { get; set; } = 0;
        public bool? Deleted { get; set; } = false;
        public DateTime? CreateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }
}
