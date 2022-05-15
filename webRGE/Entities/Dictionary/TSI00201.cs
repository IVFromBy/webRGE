using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00201
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
		///Ключ сеанса
		/// </summary>
		public int? NKEYS { get; set; }
		/// <summary>
		///Код справочника(ОГК) "Страны мира"- TSI00201(S_strana)
		/// </summary>
		public int? NKSTRAN { get; set; }
		/// <summary>
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Ключ справочника(ОГК) "Страны мира"- TSI00201(S_strana)
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00201 { get; set; }
		/// <summary>
		///Статус документа
		/// </summary>
		public int? NSTDOK { get; set; }
		/// <summary>
		///Статус обмена
		/// </summary>
		public int? NSTOBM { get; set; }
		/// <summary>
		///Обозначение 1 (сокращение)
		/// </summary>
		public string VALFA2 { get; set; }
		/// <summary>
		///Обозначение 2 (сокращение)
		/// </summary>
		public string VALFA3 { get; set; }
		/// <summary>
		///Наименование (краткое)
		/// </summary>
		public string VNSTRANK { get; set; }
		/// <summary>
		///Наименование (полное)
		/// </summary>
		public string VNSTRANP { get; set; }
	}
}