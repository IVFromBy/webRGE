using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00221
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
		///Код справочника "Фасеты ОКОГУ" - TSI00221
		/// </summary>
		public int? NKFOKOGU { get; set; }
		/// <summary>
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Ключ справочника "Фасеты ОКОГУ" - TSI00221
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00221 { get; set; }
		/// <summary>
		///Статус документа
		/// </summary>
		public int? NSTDOK { get; set; }
		/// <summary>
		///Статус обмена
		/// </summary>
		public int? NSTOBM { get; set; }
		/// <summary>
		///Наименование фасета ОКОГУ
		/// </summary>
		public string VNFOKOGU { get; set; }
	}
}