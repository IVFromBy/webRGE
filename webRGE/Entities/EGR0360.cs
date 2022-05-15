using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR0360 : BaseEntity
	{
		public string CACT { get; set; }
		public string CINCL { get; set; }
		public string CLN { get; set; }
		public DateTime? DCRTA { get; set; }
		public DateTime? DDOC { get; set; }
		public DateTime? DDOCEND { get; set; }
		public DateTime? DFROM { get; set; }
		public DateTime? DLVDA { get; set; }
		public DateTime? DOP { get; set; }
		public DateTime? DR { get; set; }
		public DateTime? DTO { get; set; }
		public long? NGR04001 { get; set; }
		public long? NGR04003 { get; set; }
		public long? NGRN { get; set; }
		public int? NKVDOK { get; set; }
		public int? NPOL { get; set; }
		public int? NSI00206 { get; set; }
		public string VDOCNUM { get; set; }
		public string VDOCORG { get; set; }
		public string VDOCSER { get; set; }
		public string VFIO { get; set; }
		public string VFIOB { get; set; }
		public string VMR { get; set; }
		public string VPRIM { get; set; }
	}
}