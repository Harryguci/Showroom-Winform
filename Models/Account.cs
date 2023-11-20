using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ShowroomData.Models
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
        public string? ClientId { get; set; }
        public int? Level_account { get; set; } = 0;
        public bool? Deleted { get; set; } = false;
        public DateTime? CreateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }
}
