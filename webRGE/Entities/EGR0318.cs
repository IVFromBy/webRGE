using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR0318 : BaseEntity
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
		public int? NGRN { get; set; }
		public long? NKLVD { get; set; }
		public int? NSI00230 { get; set; }
	}
}