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
	[ProtoContract]
	[DataContract]
	public partial class СоглашенияОбИспользованииЭД:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("c000410b-b593-4ef1-8c9c-d464abe8dd86");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012001.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*100*/ Наименование {get;set;}
		public string/*(9)*/ Номер {get;set;}
		public DateTime Дата {get;set;}
		public V82.Перечисления/*Ссылка*/.СпособыОбменаЭД СпособОбменаЭД {get;set;}//Способ обмена
		public V82.Перечисления/*Ссылка*/.СтатусыСоглашенийЭД СтатусСоглашения {get;set;}//Статус соглашения
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		public string/*(10)*/ Партнер {get;set;}
		public string/*(50)*/ ИдентификаторОрганизации {get;set;}//Идентификатор
		public string/*(50)*/ ИдентификаторКонтрагента {get;set;}//Идентификатор контрагента
		public V82.СправочникиСсылка.СертификатыЭЦП СертификатОрганизацииДляРасшифровки {get;set;}//Сертификат расшифровки
		public ХранилищеЗначения СертификатКонтрагентаДляШифрования {get;set;}//Сертификат для шифрования
		public object АдресРесурсаОрганизации {get;set;}//Адрес ресурса организации
		public string/*(255)*/ АдресРесурсаКонтрагента {get;set;}//Адрес ресурса контрагента
		public DateTime СрокДействия {get;set;}//Срок действия
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}//Ответственный за обмен
		public string/*(0)*/ Комментарий {get;set;}
		public V82.СправочникиСсылка.СоглашенияОбИспользованииЭД ТиповоеСоглашение {get;set;}//Типовое соглашение
		public bool ПроверятьСертификатыПодписей {get;set;}//Проверять сертификаты подписей
		public bool ЭтоТиповое {get;set;}//Это типовое
		public bool ЭтоИнтеркампани {get;set;}//Это обмен между организациями
		public V82.СправочникиСсылка.СертификатыЭЦП СертификатАбонента {get;set;}//Сертификат
		public string/*(100)*/ ЛогинАбонента {get;set;}//Логин абонента
		
		public СоглашенияОбИспользованииЭД()
		{
		}
		
		public СоглашенияОбИспользованииЭД(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public СоглашенияОбИспользованииЭД(byte[] УникальныйИдентификатор,int Глубина)
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
					,_Fld23769 [Номер]
					,_Fld23770 [Дата]
					,_Fld23771RRef [СпособОбменаЭД]
					,_Fld23772RRef [СтатусСоглашения]
					,_Fld23773RRef [Организация]
					,_Fld23774RRef [Контрагент]
					,_Fld23775 [Партнер]
					,_Fld23776 [ИдентификаторОрганизации]
					,_Fld23777 [ИдентификаторКонтрагента]
					,_Fld23778RRef [СертификатОрганизацииДляРасшифровки]
					,_Fld23779 [СертификатКонтрагентаДляШифрования]
					,_Fld23780_TYPE [АдресРесурсаОрганизации_Тип],_Fld23780_RRRef [АдресРесурсаОрганизации],_Fld23780_RTRef [АдресРесурсаОрганизации_Вид]
					,_Fld23781 [АдресРесурсаКонтрагента]
					,_Fld23782 [СрокДействия]
					,_Fld23783RRef [Ответственный]
					,_Fld23784 [Комментарий]
					,_Fld23785RRef [ТиповоеСоглашение]
					,_Fld23786 [ПроверятьСертификатыПодписей]
					,_Fld23787 [ЭтоТиповое]
					,_Fld23788 [ЭтоИнтеркампани]
					,_Fld23789RRef [СертификатАбонента]
					,_Fld23790 [ЛогинАбонента]
					From _Reference23128(NOLOCK)
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
								Номер = Читалка.GetString(5);
								Дата = Читалка.GetDateTime(6);
								СпособОбменаЭД = V82.Перечисления/*Ссылка*/.СпособыОбменаЭД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								СтатусСоглашения = V82.Перечисления/*Ссылка*/.СтатусыСоглашенийЭД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(9),Глубина+1);
								Контрагент = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(10),Глубина+1);
								Партнер = Читалка.GetString(11);
								ИдентификаторОрганизации = Читалка.GetString(12);
								ИдентификаторКонтрагента = Читалка.GetString(13);
								СертификатОрганизацииДляРасшифровки = new V82.СправочникиСсылка.СертификатыЭЦП((byte[])Читалка.GetValue(14),Глубина+1);
								АдресРесурсаКонтрагента = Читалка.GetString(19);
								СрокДействия = Читалка.GetDateTime(20);
								Ответственный = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(21),Глубина+1);
								Комментарий = Читалка.GetString(22);
								ТиповоеСоглашение = new V82.СправочникиСсылка.СоглашенияОбИспользованииЭД((byte[])Читалка.GetValue(23),Глубина+1);
								ПроверятьСертификатыПодписей = ((byte[])Читалка.GetValue(24))[0]==1;
								ЭтоТиповое = ((byte[])Читалка.GetValue(25))[0]==1;
								ЭтоИнтеркампани = ((byte[])Читалка.GetValue(26))[0]==1;
								СертификатАбонента = new V82.СправочникиСсылка.СертификатыЭЦП((byte[])Читалка.GetValue(27),Глубина+1);
								ЛогинАбонента = Читалка.GetString(28);
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
		
		public V82.СправочникиОбъект.СоглашенияОбИспользованииЭД  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.СоглашенияОбИспользованииЭД();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Наименование = Наименование;
			Объект.Номер = Номер;
			Объект.Дата = Дата;
			Объект.СпособОбменаЭД = СпособОбменаЭД;
			Объект.СтатусСоглашения = СтатусСоглашения;
			Объект.Организация = Организация;
			Объект.Контрагент = Контрагент;
			Объект.Партнер = Партнер;
			Объект.ИдентификаторОрганизации = ИдентификаторОрганизации;
			Объект.ИдентификаторКонтрагента = ИдентификаторКонтрагента;
			Объект.СертификатОрганизацииДляРасшифровки = СертификатОрганизацииДляРасшифровки;
			Объект.СертификатКонтрагентаДляШифрования = СертификатКонтрагентаДляШифрования;
			Объект.АдресРесурсаОрганизации = АдресРесурсаОрганизации;
			Объект.АдресРесурсаКонтрагента = АдресРесурсаКонтрагента;
			Объект.СрокДействия = СрокДействия;
			Объект.Ответственный = Ответственный;
			Объект.Комментарий = Комментарий;
			Объект.ТиповоеСоглашение = ТиповоеСоглашение;
			Объект.ПроверятьСертификатыПодписей = ПроверятьСертификатыПодписей;
			Объект.ЭтоТиповое = ЭтоТиповое;
			Объект.ЭтоИнтеркампани = ЭтоИнтеркампани;
			Объект.СертификатАбонента = СертификатАбонента;
			Объект.ЛогинАбонента = ЛогинАбонента;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.СоглашенияОбИспользованииЭД ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.СоглашенияОбИспользованииЭД)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.СоглашенияОбИспользованииЭД(УникальныйИдентификатор);
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