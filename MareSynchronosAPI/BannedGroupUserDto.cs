using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareSynchronos.API
{
    public record BannedGroupUserDto
    {
        public string UID { get; set; }
        public string Reason { get; set; }
        public DateTime BannedOn { get; set; }
        public string BannedBy { get; set; }
    }
}
