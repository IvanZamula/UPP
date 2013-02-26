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
	public partial class СпецификацииНоменклатуры:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("d0670ea3-f15c-478a-8cb1-a55c65c2f089");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191717.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public Guid Родитель {get;set;}
		public bool ЭтоГруппа {get;set;}
		public string/*9*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаУтверждения {get;set;}//Дата утверждения
		public V82.Перечисления/*Ссылка*/.ВидыСпецификаций ВидСпецификации {get;set;}//Вид спецификации
		public bool Активная {get;set;}
		public string/*(5)*/ КодВерсии {get;set;}//Код версии
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		public bool ИспользоватьВозвратныеОтходы {get;set;}//Использовать возвратные отходы
		public bool ИспользоватьПараметрыВыпускаПродукции {get;set;}//Использовать параметры выпуска продукции
		public bool ИспользоватьДокументацию {get;set;}//Использовать документацию
		public bool ИспользоватьВидНорматива {get;set;}//Использовать вид норматива
		public bool ИспользоватьВидВоспроизводства {get;set;}//Использовать вид воспроизводства
		public bool ИспользоватьУказаниеНорматива {get;set;}//Использовать указание норматива
		public bool ИспользоватьФормулы {get;set;}//Использовать формулы
		public bool ИспользоватьУправлениеСписанием {get;set;}//Использовать управление списанием
		public V82.СправочникиСсылка.НазначенияИспользованияСпецификаций Назначение {get;set;}
		
		public СпецификацииНоменклатуры()
		{
		}
		
		public СпецификацииНоменклатуры(byte[] УникальныйИдентификатор)
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
					,_Fld3578RRef [Состояние]
					,_Fld3579 [ДатаУтверждения]
					,_Fld3580RRef [ВидСпецификации]
					,_Fld3581 [Активная]
					,_Fld3582 [КодВерсии]
					,_Fld3583 [Комментарий]
					,_Fld3584RRef [Ответственный]
					,_Fld3585 [ИспользоватьВозвратныеОтходы]
					,_Fld3586 [ИспользоватьПараметрыВыпускаПродукции]
					,_Fld3587 [ИспользоватьДокументацию]
					,_Fld3588 [ИспользоватьВидНорматива]
					,_Fld3589 [ИспользоватьВидВоспроизводства]
					,_Fld3590 [ИспользоватьУказаниеНорматива]
					,_Fld3591 [ИспользоватьФормулы]
					,_Fld3592 [ИспользоватьУправлениеСписанием]
					,_Fld3593RRef [Назначение]
					From _Reference239(NOLOCK)
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
							Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							ДатаУтверждения = Читалка.GetDateTime(7);
							ВидСпецификации = V82.Перечисления/*Ссылка*/.ВидыСпецификаций.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Активная = ((byte[])Читалка.GetValue(9))[0]==1;
							КодВерсии = Читалка.GetString(10);
							Комментарий = Читалка.GetString(11);
							Ответственный = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(12));
							ИспользоватьВозвратныеОтходы = ((byte[])Читалка.GetValue(13))[0]==1;
							ИспользоватьПараметрыВыпускаПродукции = ((byte[])Читалка.GetValue(14))[0]==1;
							ИспользоватьДокументацию = ((byte[])Читалка.GetValue(15))[0]==1;
							ИспользоватьВидНорматива = ((byte[])Читалка.GetValue(16))[0]==1;
							ИспользоватьВидВоспроизводства = ((byte[])Читалка.GetValue(17))[0]==1;
							ИспользоватьУказаниеНорматива = ((byte[])Читалка.GetValue(18))[0]==1;
							ИспользоватьФормулы = ((byte[])Читалка.GetValue(19))[0]==1;
							ИспользоватьУправлениеСписанием = ((byte[])Читалка.GetValue(20))[0]==1;
							Назначение = new V82.СправочникиСсылка.НазначенияИспользованияСпецификаций((byte[])Читалка.GetValue(21));
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
		
		public V82.СправочникиОбъект.СпецификацииНоменклатуры  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.СпецификацииНоменклатуры();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Родитель = Родитель;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.Состояние = Состояние;
			Объект.ДатаУтверждения = ДатаУтверждения;
			Объект.ВидСпецификации = ВидСпецификации;
			Объект.Активная = Активная;
			Объект.КодВерсии = КодВерсии;
			Объект.Комментарий = Комментарий;
			Объект.Ответственный = Ответственный;
			Объект.ИспользоватьВозвратныеОтходы = ИспользоватьВозвратныеОтходы;
			Объект.ИспользоватьПараметрыВыпускаПродукции = ИспользоватьПараметрыВыпускаПродукции;
			Объект.ИспользоватьДокументацию = ИспользоватьДокументацию;
			Объект.ИспользоватьВидНорматива = ИспользоватьВидНорматива;
			Объект.ИспользоватьВидВоспроизводства = ИспользоватьВидВоспроизводства;
			Объект.ИспользоватьУказаниеНорматива = ИспользоватьУказаниеНорматива;
			Объект.ИспользоватьФормулы = ИспользоватьФормулы;
			Объект.ИспользоватьУправлениеСписанием = ИспользоватьУправлениеСписанием;
			Объект.Назначение = Назначение;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.СпецификацииНоменклатуры ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.СпецификацииНоменклатуры)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.СпецификацииНоменклатуры(УникальныйИдентификатор);
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