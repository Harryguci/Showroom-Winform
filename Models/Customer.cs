using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class Customer
    {
        public Customer() {
            ClientId = Firstname = Lastname = string.Empty;
        }
        public string ClientId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime? DateBirth { get; set; }

        public string? Phone { get; set; }

        public bool? Gender { get; set; }

        public string? Cccd { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public bool? Deleted { get; set; }
    }
}
