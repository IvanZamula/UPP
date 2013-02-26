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
	///Конвертации из информационных баз 1С:Предприятия
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class КонвертацииИзИнформационныхБаз1СПредприятия77:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("79589a37-9879-48a2-a789-c94c3cd18325");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191824.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*25*/ Наименование {get;set;}
		public string/*(50)*/ ИдентификаторКонфигурации {get;set;}//Идентификатор конфигурации
		public string/*(0)*/ Конфигурация {get;set;}
		public string/*(8)*/ НомерРелиза {get;set;}//Номер релиза
		public string/*(10)*/ КонвертацияПомощник {get;set;}//Помощник выгрузки
		public string/*(10)*/ КонвертацияОбработка {get;set;}//Обработка выгрузки
		public string/*(10)*/ КонвертацияПравила {get;set;}//Правила выгрузки
		public ХранилищеЗначения ХранилищеПомощник {get;set;}//Хранилище помощника
		public ХранилищеЗначения ХранилищеОписаниеПомощника {get;set;}//Хранилище описания помощника
		public ХранилищеЗначения ХранилищеОбработка {get;set;}//Хранилище обработки выгрузки
		public ХранилищеЗначения ХранилищеПравила {get;set;}//Хранилище правил выгрузки
		public string/*(256)*/ ИдентификаторЭлемента {get;set;}//Идентификатор элемента
		
		public КонвертацииИзИнформационныхБаз1СПредприятия77()
		{
		}
		
		public КонвертацииИзИнформационныхБаз1СПредприятия77(byte[] УникальныйИдентификатор)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)
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
							ИдентификаторКонфигурации = Читалка.GetString(6);
							Конфигурация = Читалка.GetString(7);
							НомерРелиза = Читалка.GetString(8);
							КонвертацияПомощник = Читалка.GetString(9);
							КонвертацияОбработка = Читалка.GetString(10);
							КонвертацияПравила = Читалка.GetString(11);
							ИдентификаторЭлемента = Читалка.GetString(16);
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
		
		public V82.СправочникиОбъект.КонвертацииИзИнформационныхБаз1СПредприятия77  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.КонвертацииИзИнформационныхБаз1СПредприятия77();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.ИдентификаторКонфигурации = ИдентификаторКонфигурации;
			Объект.Конфигурация = Конфигурация;
			Объект.НомерРелиза = НомерРелиза;
			Объект.КонвертацияПомощник = КонвертацияПомощник;
			Объект.КонвертацияОбработка = КонвертацияОбработка;
			Объект.КонвертацияПравила = КонвертацияПравила;
			Объект.ХранилищеПомощник = ХранилищеПомощник;
			Объект.ХранилищеОписаниеПомощника = ХранилищеОписаниеПомощника;
			Объект.ХранилищеОбработка = ХранилищеОбработка;
			Объект.ХранилищеПравила = ХранилищеПравила;
			Объект.ИдентификаторЭлемента = ИдентификаторЭлемента;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77 ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77(УникальныйИдентификатор);
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