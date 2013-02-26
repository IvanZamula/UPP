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
	public partial class ВерсииФайлов:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("b895f316-ff2a-4e61-9aa3-b079ed364916");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221190855.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*11*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*150*/ Наименование {get;set;}
		///<summary>
		///Автор - пользователь, создавший версию
		///</summary>
		public V82.СправочникиСсылка.Пользователи Автор {get;set;}
		///<summary>
		///Дата модификации файла - приведенная к Гринвичу (очищенная от смещения летнего времени и смещения зоны)
		///</summary>
		public DateTime ДатаМодификацииУниверсальная {get;set;}//Дата модификации универсальная
		///<summary>
		///Дата создания версии
		///</summary>
		public DateTime ДатаСоздания {get;set;}//Дата создания
		///<summary>
		///Файл версии зашифрован
		///</summary>
		public bool Зашифрован {get;set;}
		///<summary>
		///Индекс иконки, соответствующей расширению файла, для показа в списке
		///</summary>
		public decimal/*(10)*/ ИндексКартинки {get;set;}//Индекс картинки
		///<summary>
		///Комментарий к версии
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///Номер данной версии
		///</summary>
		public decimal/*(5)*/ НомерВерсии {get;set;}//Номер версии
		///<summary>
		///Файл версии подписан ЭЦП
		///</summary>
		public bool ПодписанЭЦП {get;set;}//Подписан ЭЦП
		///<summary>
		///Полное наименование (длиной до 256 символов)
		///</summary>
		public string/*(256)*/ ПолноеНаименование {get;set;}//Полное наименование
		///<summary>
		///Дополнительный путь к файлу на диске (в случае если ТипХраненияФайла - на диске)
		///</summary>
		public string/*(0)*/ ПутьКФайлу {get;set;}//Путь к файлу
		///<summary>
		///Размер файла версии
		///</summary>
		public decimal/*(10)*/ Размер {get;set;}
		///<summary>
		///Расширение файла версии
		///</summary>
		public string/*(10)*/ Расширение {get;set;}
		///<summary>
		///Родительская версия для данной версии - возможна древесная структура версий
		///</summary>
		public V82.СправочникиСсылка.ВерсииФайлов РодительскаяВерсия {get;set;}//Родительская версия
		///<summary>
		///Статус извлечения текста - для фонового задания извлечения текста
		///</summary>
		public V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов СтатусИзвлеченияТекста {get;set;}//Статус извлечения текста
		///<summary>
		///Текст, извлеченный из файла - для полнотекстового поиска
		///</summary>
		public ХранилищеЗначения ТекстХранилище {get;set;}//Текст
		///<summary>
		///Где хранятся файлы - в базе как ХранилищеЗначения или в каталоге на диске
		///</summary>
		public V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов ТипХраненияФайла {get;set;}//Тип хранения файла
		///<summary>
		///Ссылка на том (в случае если ТипХраненияФайла - на диске)
		///</summary>
		public V82.СправочникиСсылка.ТомаХраненияФайлов Том {get;set;}
		///<summary>
		///Файл версии
		///</summary>
		public ХранилищеЗначения ФайлХранилище {get;set;}//Файл
		
		public ВерсииФайлов()
		{
		}
		
		public ВерсииФайлов(byte[] УникальныйИдентификатор)
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
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)
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
							Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							ДатаСоздания = Читалка.GetDateTime(8);
							Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1;
							ИндексКартинки = Читалка.GetDecimal(10);
							Комментарий = Читалка.GetString(11);
							НомерВерсии = Читалка.GetDecimal(12);
							ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1;
							ПолноеНаименование = Читалка.GetString(14);
							ПутьКФайлу = Читалка.GetString(15);
							Размер = Читалка.GetDecimal(16);
							Расширение = Читалка.GetString(17);
							РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
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
		
		public V82.СправочникиОбъект.ВерсииФайлов  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ВерсииФайлов();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.Автор = Автор;
			Объект.ДатаМодификацииУниверсальная = ДатаМодификацииУниверсальная;
			Объект.ДатаСоздания = ДатаСоздания;
			Объект.Зашифрован = Зашифрован;
			Объект.ИндексКартинки = ИндексКартинки;
			Объект.Комментарий = Комментарий;
			Объект.НомерВерсии = НомерВерсии;
			Объект.ПодписанЭЦП = ПодписанЭЦП;
			Объект.ПолноеНаименование = ПолноеНаименование;
			Объект.ПутьКФайлу = ПутьКФайлу;
			Объект.Размер = Размер;
			Объект.Расширение = Расширение;
			Объект.РодительскаяВерсия = РодительскаяВерсия;
			Объект.СтатусИзвлеченияТекста = СтатусИзвлеченияТекста;
			Объект.ТекстХранилище = ТекстХранилище;
			Объект.ТипХраненияФайла = ТипХраненияФайла;
			Объект.Том = Том;
			Объект.ФайлХранилище = ФайлХранилище;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.ВерсииФайлов ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.ВерсииФайлов)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.ВерсииФайлов(УникальныйИдентификатор);
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