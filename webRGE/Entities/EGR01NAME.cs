using System;
using webRGE.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Entities
{

	[Index("NGRN")]
	public class EGR01NAME : BaseEntity
	{
		public DateTime? DFROM { get; set; }
		public DateTime? DTO { get; set; }
		public int? NGRN { get; set; }
		public int? NKSOST { get; set; }
		public int? NSI00219 { get; set; }
		public string VFIO { get; set; }
		public string VFN { get; set; }
		public string VN { get; set; }
		public string VNAIM { get; set; }
	}
}