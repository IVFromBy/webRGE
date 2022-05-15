using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR0358 : BaseEntity
	{
		public string CACT { get; set; }
		public string CINCL { get; set; }
		public DateTime? DCRTA { get; set; }
		public DateTime? DFROM { get; set; }
		public DateTime? DLVDA { get; set; }
		public DateTime? DOP { get; set; }
		public DateTime? DTO { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NDG { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NDGI { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NDGM { get; set; }
		public long? NGR04001 { get; set; }
		public long? NGR04003 { get; set; }
		public long? NGRN { get; set; }
		public int? NKTUF { get; set; }
		public int? NKVALUT { get; set; }
		public int? NKVSUF { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NSDBI { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NSDII { get; set; }
		public int? NSI00204 { get; set; }
		public int? NSI00217 { get; set; }
		public int? NSI00218 { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NSPBI { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NSPII { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NUF { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NUFAM { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NUFAQ { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NUFI { get; set; }
		[Column(TypeName = "decimal(23,6)")]
		public decimal? NUFM { get; set; }
	}
}