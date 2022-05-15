using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR04G : BaseEntity
	{
		public DateTime? DDOC { get; set; }
		public DateTime? DFROM { get; set; }
		public DateTime? DOP { get; set; }
		public DateTime? DSROK { get; set; }
		public DateTime? DTO { get; set; }
		public long? NGR04001 { get; set; }
		public long? NGR04004 { get; set; }
		public int? NGRN { get; set; }
		public int? NKOP { get; set; }
		public int? NKOSN { get; set; }
		public int? NKUZ { get; set; }
		public int? NKUZD { get; set; }
		public int? NKUZR { get; set; }
		public int? NSI00212 { get; set; }
		public int? NSI00212D { get; set; }
		public int? NSI00212R { get; set; }
		public int? NSI00213 { get; set; }
		public int? NSI00223 { get; set; }
		public string VDOCN { get; set; }
		public string VNRESH { get; set; }
	}
}