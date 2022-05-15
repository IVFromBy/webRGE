using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00212
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
		public string NKEYS { get; set; }
		/// <summary>
		///Код справочника "Фасеты ОКОГУ" - TSI00221
		/// </summary>
		public int? NKFOKOGU { get; set; }
		/// <summary>
		///Признак участия в операции (регистрация/ликвидация)
		/// </summary>
		public int? NKIND { get; set; }
		public int? NKLOKOGU { get; set; }
		/// <summary>
		///Код(новый) справочника(ОГК) "Органы государственной власти и управления" - TSI00113
		/// </summary>
		public int? NKOKOGU { get; set; }
		/// <summary>
		///Код ОКПО
		/// </summary>
		public int? NKOKPO { get; set; }
		/// <summary>
		///Код справочника(ОГК) "Система обозначений объектов админимтративно-территориального делеения и населенных пунктов - TSI00202"(S_Soato)
		/// </summary>
		public long? NKSOATO { get; set; }
		/// <summary>
		///Код справочника "Узлы/органы" - TSI00212
		/// </summary>
		public int? NKUZ { get; set; }
		/// <summary>
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		/// <summary>
		///Код старшего узла
		/// </summary>
		public int? NKUZS { get; set; }
		public int? NKUZTO { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Ключ справочника(ОГК) "Органы государственной власти и управления"-TSI00113
		/// </summary>
		public int? NSI00113 { get; set; }
		/// <summary>
		///Ключ справочника(ОГК) "Система обозначений объектов административно-территориального деления и населенных пунктов - TSI00202"(S_Soato)
		/// </summary>
		public int? NSI00202 { get; set; }
		/// <summary>
		///Ключ справочника "Узлы/органы" - TSI00212
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00212 { get; set; }
		/// <summary>
		///Ключ старшего узла
		/// </summary>
		public int? NSI00212S { get; set; }
		/// <summary>
		///Ключ справочника "Фасеты ОКОГУ" - TSI00221
		/// </summary>
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
		///Код УНН
		/// </summary>
		public long? NUNN { get; set; }
		public string VDBLINK { get; set; }
		public string VNOPKPP { get; set; }
		public string VNOPKPR { get; set; }
		/// <summary>
		///Узел/орган (краткое)
		/// </summary>
		public string VNUZK { get; set; }
		/// <summary>
		///Узел/орган (полное)
		/// </summary>
		public string VNUZP { get; set; }
		public string VUSRNAME { get; set; }
	}
}