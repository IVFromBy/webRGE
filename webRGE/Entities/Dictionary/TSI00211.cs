using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00211
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
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		/// <summary>
		///Код справочника "Виды объектов" - TSI00211
		/// </summary>
		public int? NKVOB { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Ключ справочника "Виды объектов регистра"
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00211 { get; set; }
		/// <summary>
		///Статус документа
		/// </summary>
		public int? NSTDOK { get; set; }
		/// <summary>
		///Статус обмена
		/// </summary>
		public int? NSTOBM { get; set; }
		/// <summary>
		///Наименование объекта(краткое)
		/// </summary>
		public string VNVOBK { get; set; }
		/// <summary>
		///Наименование объекта(полное)
		/// </summary>
		public string VNVOBP { get; set; }
	}
}