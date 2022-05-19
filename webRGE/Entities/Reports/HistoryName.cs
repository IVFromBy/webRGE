using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{
    [Keyless]
    public class HistoryName
    {
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VNAIM { get; set; }
        public string VNAIMB { get; set; }
        public string VN { get; set; }
        public string VNB { get; set; }
        public string VFN { get; set; }
        public string VFNB { get; set; }        
                
    }
}
