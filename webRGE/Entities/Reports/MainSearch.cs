using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{

    [Keyless]
    public class MainSearch
    {
        public int? NGRN { get; set; }
        public string VNAIM { get; set; }
        public string VN { get; set; }
        public string VFN { get; set; }
        public string VFIO { get; set; }
        public DateTime? DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VNSOSTK { get; set; }
    }
}
