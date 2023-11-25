using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class Source
    {
        public Source()
        {
            SourceId = Name = string.Empty;
        }
        public string SourceId { get; set; }
        public string Name { get; set; }
    }
}
