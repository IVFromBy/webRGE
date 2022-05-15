using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR0331 : BaseEntity
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
		public string NGRNTEMP { get; set; }
		public int? NINDEX { get; set; }
		public string NKSOATO { get; set; }
		public int? NKSTRAN { get; set; }
		public int? NKTNP { get; set; }
		public int? NKTPOM { get; set; }
		public int? NKTUL { get; set; }
		public int? NSI00201 { get; set; }
		public int? NSI00202 { get; set; }
		public int? NSI00226 { get; set; }
		public int? NSI00227 { get; set; }
		public int? NSI00239 { get; set; }
		public long? NUNN { get; set; }
		public string VADRPRIM { get; set; }
		public string VDISTRICT { get; set; }
		public string VDOM { get; set; }
		public string VEMAIL { get; set; }
		public string VFN { get; set; }
		public string VFNB { get; set; }
		public string VKORP { get; set; }
		public string VN { get; set; }
		public string VNAIM { get; set; }
		public string VNAIMB { get; set; }
		public string VNB { get; set; }
		public string VNP { get; set; }
		public string VPOM { get; set; }
		public string VPRIM { get; set; }
		public string VREGION { get; set; }
		public string VTELS { get; set; }
		public string VULITSA { get; set; }
	}
}