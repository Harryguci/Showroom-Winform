using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomData.Models
{
    public class Device
    {
        public Device(string deviceId, string deviceName)
        {
            DeviceId = deviceId;
            DeviceName = deviceName;
        }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DateTime? DateEntry { get; set; }
        public string? Status { get; set; }
        public int? Price { get; set; }
    }
}
