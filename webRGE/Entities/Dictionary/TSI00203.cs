using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00203
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
		///Код справочника(OГK) "Организационно-правовые формы юридических лиц и индивидуальных предпринимателей" -TSI00203(S_opf)
		/// </summary>
		public int? NKOPF { get; set; }
		/// <summary>
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		/// <summary>
		///Минисальный размер уставного фонда
		/// </summary>
		public int? NMUF { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Ключ справочника(OГK) "Организационно-правовые формы юридических лиц и индивидуальных предпринимателей" -TSI00203(S_opf)
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00203 { get; set; }
		/// <summary>
		///Статус документа
		/// </summary>
		public int? NSTDOK { get; set; }
		/// <summary>
		///Статус обмена
		/// </summary>
		public int? NSTOBM { get; set; }
		/// <summary>
		///Слова обязательно содержащиеся в наименовании
		/// </summary>
		public string VCONTAINEDWORDS { get; set; }
		/// <summary>
		///Наименование на белорусском(краткое)
		/// </summary>
		public string VNOPFBK { get; set; }
		/// <summary>
		///Наименование на белорусском(полное)
		/// </summary>
		public string VNOPFBP { get; set; }
		/// <summary>
		///Наименование на белорусском(единственное число краткое)
		/// </summary>
		public string VNOPFEBK { get; set; }
		/// <summary>
		///Наименование на белорусском(единственное число полное)
		/// </summary>
		public string VNOPFEBP { get; set; }
		/// <summary>
		///Наименование(единственное число краткое)
		/// </summary>
		public string VNOPFEK { get; set; }
		/// <summary>
		///Наименование(единственное число полное)
		/// </summary>
		public string VNOPFEP { get; set; }
		/// <summary>
		///Наименование(краткое)
		/// </summary>
		public string VNOPFK { get; set; }
		/// <summary>
		///Наименование(полное)
		/// </summary>
		public string VNOPFP { get; set; }
	}
}