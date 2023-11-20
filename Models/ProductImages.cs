using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ShowroomData.Models
{
    public class ProductImages
    {
        public int Id { get; set; }
        public string? Serial { get; set; }
        public string? Url_image { get; set; }
    }
}
