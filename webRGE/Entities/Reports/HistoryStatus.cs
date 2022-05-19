using Microsoft.EntityFrameworkCore;
using System;


namespace webRGE.Entities.Reports
{
    [Keyless]
    public class HistoryStatus
    {
        public long NGR04004 { get; set; }
        public DateTime DFROM { get; set; }
        public DateTime? DTO { get; set; }
        public int? NKOP { get; set; }
        public string VNOP { get; set; }
        public DateTime? DDOC { get; set; }
        public string VDOCN { get; set; }
        public int? NKUZD { get; set; }
        public string VNUZKD { get; set; }
        public int? NKUZR { get; set; }
        public string VNUZKR { get; set; }
        public string VNRESH { get; set; }
        public int? NKUZ { get; set; }
        public string VNUZK { get; set; }
        public int? NKOSN { get; set; }
        public string VNOSN { get; set; }
        public DateTime? DSROK { get; set; }
        public int? NKOPD { get; set; }
        public string VNOPD { get; set; }
        public int NGRN { get; set; }
    }
}
