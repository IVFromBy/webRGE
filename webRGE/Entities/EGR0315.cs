using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR0315 : BaseEntity
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
		public int? NSI00114 { get; set; }
		public string VKVDN { get; set; }
	}
}