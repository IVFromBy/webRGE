using Microsoft.EntityFrameworkCore;
using System;

namespace webRGE.Entities.Reports
{
    [Keyless]
    public class HistoryManager
    {
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public string VNAIM { get; set; }
        public string VNDOLGNP { get; set; }
        public string VNVDOCA { get; set; }
        public string VNSTRANP { get; set; }
        public int? NINDEX { get; set; }
        public string NKSOATO { get; set; }
        public string VNSFULL { get; set; }
        public string VNTNPP { get; set; }
        public string VNP { get; set; }
        public string VNTULP { get; set; }
        public string VULITSA { get; set; }
        public string VDOM { get; set; }
        public string VKORP { get; set; }
        public string VPOM { get; set; }
        public string VNTPOMP { get; set; }
        public string VADRPRIM { get; set; }
        public string VEMAIL { get; set; }
        public string VTELWORK { get; set; }
        public string VTELHOME { get; set; }
        public string VTELSOT { get; set; }
        public string VNVDOK { get; set; }
        public string VDOCSER { get; set; }
        public string VDOCNUM { get; set; }
        public DateTime? DDOC { get; set; }
        public DateTime? DDOCEND { get; set; }
        public string VDOCORG { get; set; }
        public string CLN { get; set; }
        public DateTime? DR { get; set; }
        public string VMR { get; set; }        
    }
}
