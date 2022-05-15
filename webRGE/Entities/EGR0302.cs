using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR0302 : BaseEntity
	{
		public string CACT { get; set; }
		public string CINCL { get; set; }
		public string CLN { get; set; }
		public DateTime? DCRTA { get; set; }
		public DateTime? DDOC { get; set; }
		public DateTime? DDOCA { get; set; }
		public DateTime? DDOCAEND { get; set; }
		public DateTime? DDOCEND { get; set; }
		public DateTime? DFROM { get; set; }
		public DateTime? DLVDA { get; set; }
		public DateTime? DOP { get; set; }
		public DateTime? DR { get; set; }
		public DateTime? DTO { get; set; }
		public long? NGR04001 { get; set; }
		public long? NGR04003 { get; set; }
		public long? NGRN { get; set; }
		public string NGRNS { get; set; }
		public string NGRNTEMP { get; set; }
		public int? NINDEX { get; set; }
		public int? NKDOLGN { get; set; }
		public string NKSOATO { get; set; }
		public int? NKSTRAN { get; set; }
		public int? NKTNP { get; set; }
		public int? NKTPOM { get; set; }
		public int? NKTUL { get; set; }
		public int? NKVDOK { get; set; }
		public int? NKVDOKA { get; set; }
		public int? NPOL { get; set; }
		public int? NSI00201 { get; set; }
		public int? NSI00202 { get; set; }
		public int? NSI00206 { get; set; }
		public int? NSI00206A { get; set; }
		public int? NSI00207 { get; set; }
		public int? NSI00226 { get; set; }
		public int? NSI00227 { get; set; }
		public int? NSI00239 { get; set; }
		public string NUNN { get; set; }
		public string VADRPRIM { get; set; }
		public string VDISTRICT { get; set; }
		public string VDOCANUM { get; set; }
		public string VDOCNUM { get; set; }
		public string VDOCORG { get; set; }
		public string VDOCSER { get; set; }
		public string VDOM { get; set; }
		public string VEMAIL { get; set; }
		public string VKORP { get; set; }
		public string VMR { get; set; }
		public string VNAIM { get; set; }
		public string VNAIMB { get; set; }
		public string VNP { get; set; }
		public string VPOM { get; set; }
		public string VPRIM { get; set; }
		public string VREGION { get; set; }
		public string VTELHOME { get; set; }
		public string VTELSOT { get; set; }
		public string VTELWORK { get; set; }
		public string VULITSA { get; set; }
	}
}