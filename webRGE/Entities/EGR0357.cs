using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR0357 : BaseEntity
	{
		public string CACT { get; set; }
		public string CINCL { get; set; }
		public DateTime? DCRTA { get; set; }
		public DateTime? DFROM { get; set; }
		public DateTime? DLVDA { get; set; }
		public DateTime? DOP { get; set; }
		public DateTime? DTO { get; set; }
		public long? NGR04001 { get; set; }
		public long? NGR04003 { get; set; }
		public long? NGRN { get; set; }
		public int? NKFFS { get; set; }
		public int? NKFOKOGU { get; set; }
		public int? NKFOPF { get; set; }
		public int? NKOKOGU { get; set; }
		public int? NKOPF { get; set; }
		public int? NKVFS { get; set; }
		public int? NSI00012 { get; set; }
		public int? NSI00113 { get; set; }
		public int? NSI00203 { get; set; }
		public int? NSI00221 { get; set; }
		public int? NSI00222 { get; set; }
		public int? NSI00246 { get; set; }
	}
}