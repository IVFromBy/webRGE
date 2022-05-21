using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{
    [Keyless]
    public class ActivityTypeExt3
    {
        public long NGRN { get; set; }
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VNVDNP { get; set; }
        
    }
}
