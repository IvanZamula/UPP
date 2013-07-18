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
	public partial class ЦиклыОбмена:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("96a1d76f-5dd2-49e0-9b68-523b824bab2e");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012003.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*10*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*150*/ Наименование {get;set;}
		public V82.СправочникиСсылка.УчетныеЗаписиДокументооборота УчетнаяЗапись {get;set;}//Учетная запись
		public V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена Тип {get;set;}
		public string/*(100)*/ Идентификатор {get;set;}//Идентификатор цикла обмена
		public object Предмет {get;set;}
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public object ВнешняяОрганизация {get;set;}//Внешняя организация
		public DateTime ДатаСоздания {get;set;}//Дата создания
		public DateTime ДатаЗакрытия {get;set;}//Дата закрытия
		public DateTime ДатаПоследнегоСообщения {get;set;}//Дата последнего сообщения
		public object ВидОтчета {get;set;}//Вид отчета
		public DateTime ДатаНачалаПериода {get;set;}//Дата начала периода
		public DateTime ДатаОкончанияПериода {get;set;}//Дата окончания периода
		public decimal/*(3)*/ ВидДокумента {get;set;}//Вид документа
		public V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН ВидУслуги {get;set;}//Вид услуги
		public V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН ФорматОтвета {get;set;}//Формат ответа
		public string/*(16)*/ Период {get;set;}
		public V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена Вид {get;set;}
		public V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС ФорматДокументооборота {get;set;}//Формат документооборота
		
		public ЦиклыОбмена()
		{
		}
		
		public ЦиклыОбмена(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public ЦиклыОбмена(byte[] УникальныйИдентификатор,int Глубина)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23880RRef [УчетнаяЗапись]
					,_Fld23881RRef [Тип]
					,_Fld23882 [Идентификатор]
					,_Fld23883_TYPE [Предмет_Тип],_Fld23883_RRRef [Предмет],_Fld23883_RTRef [Предмет_Вид]
					,_Fld23884RRef [Организация]
					,_Fld23885_TYPE [ВнешняяОрганизация_Тип],_Fld23885_RRRef [ВнешняяОрганизация],_Fld23885_RTRef [ВнешняяОрганизация_Вид]
					,_Fld23886 [ДатаСоздания]
					,_Fld23887 [ДатаЗакрытия]
					,_Fld23888 [ДатаПоследнегоСообщения]
					,_Fld23889_TYPE [ВидОтчета_Тип],_Fld23889_RRRef [ВидОтчета],_Fld23889_RTRef [ВидОтчета_Вид]
					,_Fld23890 [ДатаНачалаПериода]
					,_Fld23891 [ДатаОкончанияПериода]
					,_Fld23892 [ВидДокумента]
					,_Fld23893RRef [ВидУслуги]
					,_Fld23894RRef [ФорматОтвета]
					,_Fld23895 [Период]
					,_Fld23896RRef [Вид]
					,_Fld23897RRef [ФорматДокументооборота]
					From _Reference23136(NOLOCK)
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
							Код = Читалка.GetString(4);
							Наименование = Читалка.GetString(5);
								УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6),Глубина+1);
								Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Идентификатор = Читалка.GetString(8);
								Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12),Глубина+1);
								ДатаСоздания = Читалка.GetDateTime(16);
								ДатаЗакрытия = Читалка.GetDateTime(17);
								ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
								ДатаНачалаПериода = Читалка.GetDateTime(22);
								ДатаОкончанияПериода = Читалка.GetDateTime(23);
								ВидДокумента = Читалка.GetDecimal(24);
								ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
								ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
								Период = Читалка.GetString(27);
								Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
								ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
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
		
		public V82.СправочникиОбъект.ЦиклыОбмена  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ЦиклыОбмена();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.УчетнаяЗапись = УчетнаяЗапись;
			Объект.Тип = Тип;
			Объект.Идентификатор = Идентификатор;
			Объект.Предмет = Предмет;
			Объект.Организация = Организация;
			Объект.ВнешняяОрганизация = ВнешняяОрганизация;
			Объект.ДатаСоздания = ДатаСоздания;
			Объект.ДатаЗакрытия = ДатаЗакрытия;
			Объект.ДатаПоследнегоСообщения = ДатаПоследнегоСообщения;
			Объект.ВидОтчета = ВидОтчета;
			Объект.ДатаНачалаПериода = ДатаНачалаПериода;
			Объект.ДатаОкончанияПериода = ДатаОкончанияПериода;
			Объект.ВидДокумента = ВидДокумента;
			Объект.ВидУслуги = ВидУслуги;
			Объект.ФорматОтвета = ФорматОтвета;
			Объект.Период = Период;
			Объект.Вид = Вид;
			Объект.ФорматДокументооборота = ФорматДокументооборота;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.ЦиклыОбмена ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.ЦиклыОбмена)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.ЦиклыОбмена(УникальныйИдентификатор);
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