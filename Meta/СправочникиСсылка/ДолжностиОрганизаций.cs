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
	///(Регл)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ДолжностиОрганизаций:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("28f291da-0cd8-4243-828b-e5f78069363d");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191709.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*9*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*100*/ Наименование {get;set;}
		public V82.СправочникиСсылка.СпискиПрофессийДолжностейЛьготногоПенсионногоОбеспечения КодПозицииСписка {get;set;}//Код позиции списка
		public V82.СправочникиСсылка.ОснованияВыслугиЛет ОснованиеВыслугиЛет {get;set;}//Основание выслуги лет
		public bool АУП {get;set;}//Административно-управленческий персонал
		public V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляВоинскогоУчета КатегорияВоинскогоУчета {get;set;}//Категория воинского учета
		public string/*(6)*/ КодПоОКПДТР {get;set;}//Код по ОКПДТР
		public V82.СправочникиСсылка.Должности Должность {get;set;}//Должность кадрового плана
		///<summary>
		///(Регл)
		///</summary>
		public V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляСтатистическогоУчета КатегорияСтатистическогоУчета {get;set;}//Категория статистического учета
		public bool ЯвляетсяДолжностьюЛетногоЭкипажа {get;set;}//Является должностью летного экипажа
		public bool ЯвляетсяШахтерскойДолжностью {get;set;}//Является шахтерской должностью
		public V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляУчетаЗабронированныхС2011Года КатегорияУчетаЗабронированных {get;set;}//Категория учета забронированных
		public bool ЯвляетсяФармацевтическойДолжностью {get;set;}//Является фармацевтической должностью
		
		public ДолжностиОрганизаций()
		{
		}
		
		public ДолжностиОрганизаций(byte[] УникальныйИдентификатор)
		{
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2276RRef [КодПозицииСписка]
					,_Fld2277RRef [ОснованиеВыслугиЛет]
					,_Fld2278 [АУП]
					,_Fld2279RRef [КатегорияВоинскогоУчета]
					,_Fld2280 [КодПоОКПДТР]
					,_Fld2281RRef [Должность]
					,_Fld2282RRef [КатегорияСтатистическогоУчета]
					,_Fld2283 [ЯвляетсяДолжностьюЛетногоЭкипажа]
					,_Fld2284 [ЯвляетсяШахтерскойДолжностью]
					,_Fld2285RRef [КатегорияУчетаЗабронированных]
					,_Fld2286 [ЯвляетсяФармацевтическойДолжностью]
					From _Reference92(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
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
							Код = Читалка.GetString(4);
							Наименование = Читалка.GetString(5);
							КодПозицииСписка = new V82.СправочникиСсылка.СпискиПрофессийДолжностейЛьготногоПенсионногоОбеспечения((byte[])Читалка.GetValue(6));
							ОснованиеВыслугиЛет = new V82.СправочникиСсылка.ОснованияВыслугиЛет((byte[])Читалка.GetValue(7));
							АУП = ((byte[])Читалка.GetValue(8))[0]==1;
							КатегорияВоинскогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляВоинскогоУчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							КодПоОКПДТР = Читалка.GetString(10);
							Должность = new V82.СправочникиСсылка.Должности((byte[])Читалка.GetValue(11));
							КатегорияСтатистическогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляСтатистическогоУчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(12));
							ЯвляетсяДолжностьюЛетногоЭкипажа = ((byte[])Читалка.GetValue(13))[0]==1;
							ЯвляетсяШахтерскойДолжностью = ((byte[])Читалка.GetValue(14))[0]==1;
							КатегорияУчетаЗабронированных = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							ЯвляетсяФармацевтическойДолжностью = ((byte[])Читалка.GetValue(16))[0]==1;
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
		
		public V82.СправочникиОбъект.ДолжностиОрганизаций  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ДолжностиОрганизаций();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.КодПозицииСписка = КодПозицииСписка;
			Объект.ОснованиеВыслугиЛет = ОснованиеВыслугиЛет;
			Объект.АУП = АУП;
			Объект.КатегорияВоинскогоУчета = КатегорияВоинскогоУчета;
			Объект.КодПоОКПДТР = КодПоОКПДТР;
			Объект.Должность = Должность;
			Объект.КатегорияСтатистическогоУчета = КатегорияСтатистическогоУчета;
			Объект.ЯвляетсяДолжностьюЛетногоЭкипажа = ЯвляетсяДолжностьюЛетногоЭкипажа;
			Объект.ЯвляетсяШахтерскойДолжностью = ЯвляетсяШахтерскойДолжностью;
			Объект.КатегорияУчетаЗабронированных = КатегорияУчетаЗабронированных;
			Объект.ЯвляетсяФармацевтическойДолжностью = ЯвляетсяФармацевтическойДолжностью;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.ДолжностиОрганизаций ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.ДолжностиОрганизаций)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.ДолжностиОрганизаций(УникальныйИдентификатор);
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