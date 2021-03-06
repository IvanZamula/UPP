﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	[ProtoContract]
	[DataContract]
	public partial class НазначенияИспользования:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid Владелец {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*50*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.Перечисления/*Ссылка*/.СпособыПогашенияСтоимости СпособПогашенияСтоимости {get;set;}//Способ погашения стоимости
		[DataMember]
		[ProtoMember(10)]
		public decimal/*(4)*/ СрокПолезногоИспользования {get;set;}//Срок полезного использования
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(15.3)*/ Количество {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.ЕдиницыИзмерения ЕдиницаИзмерения {get;set;}//Единица измерения
		[DataMember]
		[ProtoMember(13)]
		public V82.СправочникиСсылка.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходов {get;set;}//Способ отражения расходов
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для справочников.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference87(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_OwnerIDRRef
						,_Code
						,_Description
						,_Fld1332RRef
						,_Fld1333
						,_Fld1334
						,_Fld1335RRef
						,_Fld1336RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Владелец
						,@Код
						,@Наименование
						,@СпособПогашенияСтоимости
						,@СрокПолезногоИспользования
						,@Количество
						,@ЕдиницаИзмерения
						,@СпособОтраженияРасходов)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference87
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_OwnerIDRRef	= @Владелец
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld1332RRef	= @СпособПогашенияСтоимости
						,_Fld1333	= @СрокПолезногоИспользования
						,_Fld1334	= @Количество
						,_Fld1335RRef	= @ЕдиницаИзмерения
						,_Fld1336RRef	= @СпособОтраженияРасходов
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Владелец", Владелец);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("СпособПогашенияСтоимости", СпособПогашенияСтоимости.Ключ());
					Команда.Parameters.AddWithValue("СрокПолезногоИспользования", СрокПолезногоИспользования);
					Команда.Parameters.AddWithValue("Количество", Количество);
					Команда.Parameters.AddWithValue("ЕдиницаИзмерения", ЕдиницаИзмерения.Ссылка);
					Команда.Parameters.AddWithValue("СпособОтраженияРасходов", СпособОтраженияРасходов.Ссылка);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference87
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		// Процедура - обработчик события "ПередЗаписью".
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*НЕ ОбменДанными.Загрузка И НЕ ЭтоГруппа*/)
			{
				if(true/*СпособПогашенияСтоимости.Пустая()*/)
				{
					//Сообщить("Укажите способ погашения стоимости!", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				if(true/*СпособОтраженияРасходов.Пустая()*/)
				{
					//Сообщить("Укажите способ отражения расходов!", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				if(true/*СрокПолезногоИспользования <= 0*/)
				{
					//Сообщить("Укажите срок полезного использования!", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
			}
		}
		// ПередЗаписью()
	}
}