using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00113
	{
		/// <summary>
		///Признак актуальности
		/// </summary>
		public string CACT { get; set; }
		/// <summary>
		///Статус записи
		/// </summary>
		public string CSTATUS { get; set; }
		/// <summary>
		///Дата начала действия
		/// </summary>
		public DateTime? DFROM { get; set; }
		/// <summary>
		///Дата операции
		/// </summary>
		public DateTime? DOP { get; set; }
		/// <summary>
		///Дата окончания действия
		/// </summary>
		public DateTime? DTO { get; set; }
		/// <summary>
		///Код(новый) справочника(ОГК) "Органы государственной власти и управления" - TSI00113
		/// </summary>
		public int? NKOKOGU { get; set; }
		/// <summary>
		///Код(старый) справочника(ОГК) "Органы государственной власти и управления" - TSI00113
		/// </summary>
		public int? NKSOOU { get; set; }
		/// <summary>
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Ключ справочника(ОГК) "Органы государственной власти и управления"-TSI00113
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00113 { get; set; }
		/// <summary>
		///Ключ старой записи
		/// </summary>
		public long? NSI00113S { get; set; }
		/// <summary>
		///Статус документа
		/// </summary>
		public int? NSTDOK { get; set; }
		/// <summary>
		///Статус обмена
		/// </summary>
		public int? NSTOBM { get; set; }
		public string VKOKOGUK2 { get; set; }
		/// <summary>
		///Наименование органа государственной власти(краткое)
		/// </summary>
		public string VKOKOGUK { get; set; }
		/// <summary>
		///Наименование органа государственной власти(полное)
		/// </summary>
		public string VKOKOGUP { get; set; }
	}
}