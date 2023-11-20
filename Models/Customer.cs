using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ShowroomData.Models
{
    public class Customer
    {
        public Customer() {
            ClientId = string.Empty;
            Firstname = string.Empty;
            Lastname = string.Empty;
        }
        public string ClientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Cccd { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public bool Gender { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
