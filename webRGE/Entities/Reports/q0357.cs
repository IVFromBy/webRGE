using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{
    [Keyless]
    public class q0357
    {
        public long NGRN { get; set; }
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VNOPFP { get; set; }
        public string VNFOPF { get; set; }
        public string VNVFSP { get; set; }
        public string VNFFSP { get; set; }
        public string VKOKOGUP { get; set; }
        public string VNFOKOGU { get; set; }
        
    }
}
