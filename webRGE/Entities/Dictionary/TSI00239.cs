using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00239
	{
		public string CACT { get; set; }
		public string CSTATUS { get; set; }
		public DateTime? DFROM { get; set; }
		public DateTime? DOP { get; set; }
		public DateTime? DTO { get; set; }
		public int? NKEYS { get; set; }
		public int? NKTNP { get; set; }
		public int? NKUZA { get; set; }
		public int? NOP { get; set; }
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00239 { get; set; }
		public int? NSTDOK { get; set; }
		public int? NSTOBM { get; set; }
		public string VNTNPK { get; set; }
		public string VNTNPP { get; set; }
	}
}