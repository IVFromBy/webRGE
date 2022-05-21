using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{
    [Keyless]
    public class q0355
    {
        public long NGRN { get; set; }
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VCPD { get; set; }
        public string VCPDDOP { get; set; }
        
    }
}
