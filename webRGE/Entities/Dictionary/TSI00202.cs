using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webRGE.Entities.Dictionary
{
	public class TSI00202
	{
		/// <summary>
		///Признак актуальности
		/// </summary>
		public string CACT { get; set; }
		public string CATNAME { get; set; }
		public string CATNAMECONV { get; set; }
		public string CATSHORTNAME { get; set; }
		/// <summary>
		///Комментарий
		/// </summary>
		public string COMMENTARY { get; set; }
		/// <summary>
		///Статус записи
		/// </summary>
		public string CSTATUS { get; set; }
		/// <summary>
		///Код типа а/т единицы (О/Г/Р/В/С)
		/// </summary>
		public string CTAE { get; set; }
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
		///Наименование района
		/// </summary>
		public string NAMEDISTR { get; set; }
		/// <summary>
		///Наименование области
		/// </summary>
		public string NAMEREGION { get; set; }
		public int? NKCATEGORY { get; set; }
		/// <summary>
		///Ключ сеанса
		/// </summary>
		public int? NKEYS { get; set; }
		/// <summary>
		///Код справочника(ОГК) "Система обозначений объектов админимтративно-территориального делеения и населенных пунктов - TSI00202_N"(S_Soato)
		/// </summary>
		public string NKSOATO { get; set; }
		/// <summary>
		///Код узла в который направляется запись
		/// </summary>
		public int? NKUZA { get; set; }
		/// <summary>
		///Номер операции
		/// </summary>
		public int? NOP { get; set; }
		/// <summary>
		///Ключ справочника(ОГК) "Система обозначений объектов административно-территориального деления и населенных пунктов - TSI00202_N"(S_Soato)
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int? NSI00202 { get; set; }
		public int? NSI00239 { get; set; }
		public int? NSI00245 { get; set; }
		/// <summary>
		///Статус документа
		/// </summary>
		public int? NSTDOK { get; set; }
		/// <summary>
		///Статус обмена
		/// </summary>
		public int? NSTOBM { get; set; }
		/// <summary>
		///Ид
		/// </summary>
		public int? OBJECTNUMBER { get; set; }
		/// <summary>
		///Старший СОАТО
		/// </summary>
		public string SOATODEPEND { get; set; }
		public int? UIDOPERIN { get; set; }
		public int? UIDOPEROUT { get; set; }
		public string VAL_NAME { get; set; }
		/// <summary>
		///Код СОАТО(Символьный)
		/// </summary>
		public string VKSOATO { get; set; }
		/// <summary>
		///Центр а/т единицы
		/// </summary>
		public string VNCENTR { get; set; }
		public string VNP { get; set; }
		/// <summary>
		///Полное наименование СОАТО
		/// </summary>
		public string VNSFULL { get; set; }
		/// <summary>
		///Наименование а/т единицы
		/// </summary>
		public string VNSOATO { get; set; }
		/// <summary>
		///Полное наименование СОАТО (без Республики Беларусь и сельсовета)
		/// </summary>
		public string VNSSHORT { get; set; }
		public string VSELSOVET { get; set; }
	}
}