using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR04D : BaseEntity
	{
		public DateTime? DOP { get; set; }
		public long? NGR04001 { get; set; }
		public long? NGR04004 { get; set; }
		public long? NGR04004A { get; set; }
		public long? NGRN { get; set; }
		public int? NKOP { get; set; }
		public int? NSI00223 { get; set; }
	}
}