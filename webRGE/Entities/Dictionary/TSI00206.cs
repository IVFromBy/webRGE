using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00206
	{
		public string CACT { get; set; }
		public string CSTATUS { get; set; }
		public DateTime? DFROM { get; set; }
		public DateTime? DOP { get; set; }
		public DateTime? DTO { get; set; }
		public int? NKEYS { get; set; }
		public int? NKUZA { get; set; }
		public int? NKVDOK { get; set; }
		public int? NKVOB { get; set; }
		public int? NOP { get; set; }
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00206 { get; set; }
		public int? NSI00211 { get; set; }
		public int? NSTDOK { get; set; }
		public int? NSTOBM { get; set; }
		public string VANSWER { get; set; }
		public string VCLASS { get; set; }
		public string VNVDOK { get; set; }
		public string VNVDOKK { get; set; }
		public string VNVDOKRP { get; set; }
	}
}