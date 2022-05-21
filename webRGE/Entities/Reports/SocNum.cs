using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{
    [Keyless]
    public class SocNum
    {
        public long NGRN { get; set; }
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VSOC { get; set; }
        public string DOPINFO { get; set; }
        
    }
}
