using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class Notification
    {
        public Notification(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public string Title { get; set; }

        public string Content { get; set; }
        public string? pictureUrl { get; set; }
    }
}
