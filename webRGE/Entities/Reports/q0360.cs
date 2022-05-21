using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{
    [Keyless]
    public class q0360
    {
        public long NGRN { get; set; }
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VFIO { get; set; }
        public string VFIOB { get; set; }
        public string VNVDOK { get; set; }
        public string VDOCSER { get; set; }
        public string VDOCNUM { get; set; }
        public DateTime? DDOC { get; set; }
        public DateTime? DDOCEND { get; set; }
        public string VDOCORG { get; set; }
        public string CLN { get; set; }
        public int? NPOL { get; set; }
        public string VMR { get; set; }
        public DateTime? DR { get; set; }
        public string VPRIM { get; set; }

    }
}
