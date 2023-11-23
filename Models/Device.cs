using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class Device
    {
        public Device()
        {
            DeviceId = DeviceName = String.Empty;
        }
        public string DeviceId { get; set; }

        public string DeviceName { get; set; }
        
        public DateTime? DateEntry { get; set; }
       
        public string? Status { get; set; }
        
        public int? Price { get; set; }
    }
}
