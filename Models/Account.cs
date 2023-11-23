using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int? Level { get; set; } = 0;
        public bool? Deleted { get; set; } = false;
        public DateTime? CreateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }
}
