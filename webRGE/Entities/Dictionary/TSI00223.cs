using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00223
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
		public int? NFIX { get; set; }
		/// <summary>
		///Код справочника "Виды операций"- TSI00223(регистрационые действия внесение изменений и т
		/// </summary>
		public int? NKOP { get; set; }
		/// <summary>
		///Код главной операции
		/// </summary>
		public int? NKOPA { get; set; }
		/// <summary>
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		public int? NMAIN { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Признак действующей операции(1/0)
		/// </summary>
		public int? NREAL { get; set; }
		/// <summary>
		///Ключ справочника "Виды операций"- TSI00223(регистрационые действия внесение изменений и т
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00223 { get; set; }
		/// <summary>
		///Ключ главной операции
		/// </summary>
		public int? NSI00223A { get; set; }
		/// <summary>
		///Статус документа
		/// </summary>
		public int? NSTDOK { get; set; }
		/// <summary>
		///Статус обмена
		/// </summary>
		public int? NSTOBM { get; set; }
		/// <summary>
		///Вид операции
		/// </summary>
		public string VNOP { get; set; }
		/// <summary>
		///Вид операции(краткое)
		/// </summary>
		public string VNOPK { get; set; }
		public string VNOPKORR { get; set; }
		public string VNOPREP { get; set; }
	}
}