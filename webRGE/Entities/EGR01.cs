using Microsoft.EntityFrameworkCore;
using System;
using webRGE.Entities.Base;

namespace webRGE.Entities
{

    [Index("NGRN")]
    public class EGR01 : BaseEntity
    {
        public DateTime? DFROM { get; set; }
        public DateTime? DOP { get; set; }
        public DateTime? DTO { get; set; }
        public long? NGR04001 { get; set; }
        public long? NGRN { get; set; }
        public int? NKNOTREG { get; set; }
        public int? NKSCRT { get; set; }
        public int? NKSLKV { get; set; }
        public int? NKSOST { get; set; }
        public int? NKUZ { get; set; }
        public int? NKUZCRT { get; set; }
        public int? NKUZLKV { get; set; }
        public int? NKVOB { get; set; }
        public int? NSI00208 { get; set; }
        public int? NSI00211 { get; set; }
        public int? NSI00212 { get; set; }
        public int? NSI00212CRT { get; set; }
        public int? NSI00212LKV { get; set; }
        public int? NSI00219 { get; set; }
        public int? NSI00228 { get; set; }
        public int? NSI00243 { get; set; }
        public string VNRCRT { get; set; }
        public string VNRLKV { get; set; }
    }
}