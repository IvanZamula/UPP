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
	///<summary>
	///Торговое оборудование, которое может быть подключено.
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ТорговоеОборудование:СправочникОбъект
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
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///Используемая обработка обслуживания торгового оборудования.
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public V82.СправочникиСсылка.ОбработкиОбслуживанияТО ОбработкаОбслуживания {get;set;}//Обработка обслуживания
		///<summary>
		///Модель торгового оборудования.
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public string/*(256)*/ Модель {get;set;}
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
						Insert Into _Reference183(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2127RRef
						,_Fld2128)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@ОбработкаОбслуживания
						,@Модель)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference183
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2127RRef	= @ОбработкаОбслуживания
						,_Fld2128	= @Модель
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ОбработкаОбслуживания", ОбработкаОбслуживания.Ссылка);
					Команда.Parameters.AddWithValue("Модель", Модель);
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
					Команда.CommandText = @"Delete _Reference183
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		///////////////////////////////////////////////////////////////////////////////
		//// ОБРАБОТЧИКИ СОБЫТИЙ
		// Процедура - обработчик события "Перед записью".
		//
		// Параметры:
		//  Отказ - <Булево>
		//        - Признак отказа от записи элемента. Если в теле
		//          процедуры-обработчика установить данному параметру
		//          значение Истина, запись элемента выполнена не будет.
		//          Значение по умолчанию: Ложь.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*Не ОбменДанными.Загрузка*/)
			{
				//Ошибки = "";
				if(true/*ПустаяСтрока(Модель)*/)
				{
					//Ошибки = " - Не указана модель торгового оборудования.";
				}
				if(true/*НЕ ЗначениеЗаполнено(ОбработкаОбслуживания)*/)
				{
					/*Ошибки = Ошибки + ?(ПустаяСтрока(Ошибки),
			                    "",
			                    "
			                    |")
			                + " - Не указана обработка обслуживания.";*/
				}
				if(true/*Не ЭтоНовый() И Ссылка.ОбработкаОбслуживания <> ОбработкаОбслуживания И ЕстьСсылкиНаЗаписьСправочника()*/)
				{
					/*Ошибки = Ошибки + ?(ПустаяСтрока(Ошибки),
			                    "",
			                    "
			                    |")
			                + " - Для данной модели уже существует подключенное торговое оборудование.
			                  |   Изменение обработки обслуживания невозможно.";*/
				}
				if(true/*Не ПустаяСтрока(Ошибки)*/)
				{
					/*ОбщегоНазначения.СообщитьОбОшибке("При попытке записи элемента с кодом """ + Код + """ были обнаружены ошибки:
			                 |" + Ошибки);*/
					//Отказ = Истина;
				}
			}
		}
		// Функция проверяет, имеют ли в регистре сведений "Торговое оборудование" ссылки на данный элемент справочника, и возвращает ответ.
		//
		// Параметры
		//
		// Возвращаемое значение:
		//  <Булево>  - ответ на вопрос "Есть ли ссылки на текущую запись справочника?"
		//

		public object ЕстьСсылкиНаЗаписьСправочника(/**/)
		{
			/*Запрос = Новый Запрос("
	|ВЫБРАТЬ
	|	РегТО.Модель,
	|	РегТО.Вид
	|ИЗ
	|	РегистрСведений.ТорговоеОборудование КАК РегТО
	|ГДЕ
	|	РегТО.Модель = &СправочникТО
	|");*/
			//Запрос.УстановитьПараметр("СправочникТО", Ссылка);
			return null;
		}
		// ПолучитьОбработки()
	}
}