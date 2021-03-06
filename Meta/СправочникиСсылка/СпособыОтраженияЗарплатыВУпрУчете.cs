﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	///<summary>
	///(Упр)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class СпособыОтраженияЗарплатыВУпрУчете:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("d53d94b9-ba25-4f71-9de6-c2b1702f1df7");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928011927.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public bool Предопределенный {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*50*/ Наименование {get;set;}
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат {get;set;}//Статья затрат
		public V82.СправочникиСсылка.НоменклатурныеГруппы НоменклатурнаяГруппа {get;set;}//Номенклатурная группа
		public V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск СпособРаспределенияЗатрат {get;set;}//Способ распределения затрат
		public V82.СправочникиСсылка.ОбъектыСтроительства ОбъектСтроительства {get;set;}//Объект строительства
		
		public СпособыОтраженияЗарплатыВУпрУчете()
		{
		}
		
		public СпособыОтраженияЗарплатыВУпрУчете(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public СпособыОтраженияЗарплатыВУпрУчете(byte[] УникальныйИдентификатор,int Глубина)
		{
			if (Глубина>3)
			{
				return;
			}
			if (new Guid(УникальныйИдентификатор) == Guid.Empty)
			{
				return;
			}
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld1895RRef [СтатьяЗатрат]
					,_Fld1896RRef [НоменклатурнаяГруппа]
					,_Fld1897RRef [СпособРаспределенияЗатрат]
					,_Fld1898RRef [ОбъектСтроительства]
					From _Reference156(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  ";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Наименование = Читалка.GetString(4);
								СтатьяЗатрат = new V82.СправочникиСсылка.СтатьиЗатрат((byte[])Читалка.GetValue(5),Глубина+1);
								НоменклатурнаяГруппа = new V82.СправочникиСсылка.НоменклатурныеГруппы((byte[])Читалка.GetValue(6),Глубина+1);
								СпособРаспределенияЗатрат = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск((byte[])Читалка.GetValue(7),Глубина+1);
								ОбъектСтроительства = new V82.СправочникиСсылка.ОбъектыСтроительства((byte[])Читалка.GetValue(8),Глубина+1);
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.СправочникиОбъект.СпособыОтраженияЗарплатыВУпрУчете  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.СпособыОтраженияЗарплатыВУпрУчете();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Наименование = Наименование;
			Объект.СтатьяЗатрат = СтатьяЗатрат;
			Объект.НоменклатурнаяГруппа = НоменклатурнаяГруппа;
			Объект.СпособРаспределенияЗатрат = СпособРаспределенияЗатрат;
			Объект.ОбъектСтроительства = ОбъектСтроительства;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.СпособыОтраженияЗарплатыВУпрУчете ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.СпособыОтраженияЗарплатыВУпрУчете)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.СпособыОтраженияЗарплатыВУпрУчете(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}