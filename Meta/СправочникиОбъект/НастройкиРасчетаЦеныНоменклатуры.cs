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
	public partial class НастройкиРасчетаЦеныНоменклатуры:СправочникОбъект
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
		public V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры Родитель {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public bool ЭтоГруппа {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///Формировать документы автоматически (регламентным заданием)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public bool ФормироватьДокументыАвтоматически {get;set;}//Формировать документы автоматически
		///<summary>
		///Уникальный идентификатор регламентного задания
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(36)*/ РегламентноеЗадание {get;set;}//Регламентное задание
		[DataMember]
		[ProtoMember(11)]
		public ХранилищеЗначения НастройкиКомпоновщика {get;set;}//Настройки компоновщика
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен {get;set;}//Тип цен
		[DataMember]
		[ProtoMember(13)]
		public V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете ВидОтраженияВУчете {get;set;}//Использовать данные
		[DataMember]
		[ProtoMember(14)]
		public decimal/*(1)*/ ПорядокФормированияЦены {get;set;}//Порядок формирования цены
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.НастройкиРасчетаСебестоимости НастройкаРасчетаСебестоимости {get;set;}//Настройка расчета себестоимости
		[DataMember]
		[ProtoMember(17)]
		public bool СоздаватьНовыйДокумент {get;set;}//Создавать новый документ
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
						Insert Into _Reference23111(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld23613
						,_Fld23614
						,_Fld23615
						,_Fld23616RRef
						,_Fld23617RRef
						,_Fld23618
						,_Fld23619
						,_Fld23620RRef
						,_Fld23621)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Наименование
						,@ФормироватьДокументыАвтоматически
						,@РегламентноеЗадание
						,@НастройкиКомпоновщика
						,@ТипЦен
						,@ВидОтраженияВУчете
						,@ПорядокФормированияЦены
						,@Комментарий
						,@НастройкаРасчетаСебестоимости
						,@СоздаватьНовыйДокумент)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference23111
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Description	= @Наименование
						,_Fld23613	= @ФормироватьДокументыАвтоматически
						,_Fld23614	= @РегламентноеЗадание
						,_Fld23615	= @НастройкиКомпоновщика
						,_Fld23616RRef	= @ТипЦен
						,_Fld23617RRef	= @ВидОтраженияВУчете
						,_Fld23618	= @ПорядокФормированияЦены
						,_Fld23619	= @Комментарий
						,_Fld23620RRef	= @НастройкаРасчетаСебестоимости
						,_Fld23621	= @СоздаватьНовыйДокумент
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ФормироватьДокументыАвтоматически", ФормироватьДокументыАвтоматически);
					Команда.Parameters.AddWithValue("РегламентноеЗадание", РегламентноеЗадание);
					Команда.Parameters.AddWithValue("НастройкиКомпоновщика",new byte[0]);
					Команда.Parameters.AddWithValue("ТипЦен", ТипЦен.Ссылка);
					Команда.Parameters.AddWithValue("ВидОтраженияВУчете", ВидОтраженияВУчете.Ключ());
					Команда.Parameters.AddWithValue("ПорядокФормированияЦены", ПорядокФормированияЦены);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("НастройкаРасчетаСебестоимости", НастройкаРасчетаСебестоимости.Ссылка);
					Команда.Parameters.AddWithValue("СоздаватьНовыйДокумент", СоздаватьНовыйДокумент);
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
					Команда.CommandText = @"Delete _Reference23111
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ОБЩИЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Выполняет проверку заполненности реквизитов.
		//
		// Параметры
		//	Заголовок - заголовок сообщения об ошибке
		//
		// Возвращаемое значение
		//	Истина  - все проверяемые реквизиты заполнены
		//	Ложь	- не все проверяемые реквизиты заполнены

		public object РеквизитыЗаполнены(/*Знач Заголовок*/)
		{
			//Отказ = Ложь;
			/*// Должны быть заполнены обязательные реквизиты
*/
			//СтруктураОбязательныхПолей = Новый Структура();
			//СтруктураОбязательныхПолей.Вставить("ТипЦен",			"Не указан тип цен, который будет заполняться информацией о себестоимости");
			//ЗаполнениеДокументов.ПроверитьЗаполнениеШапкиДокумента(ЭтотОбъект, СтруктураОбязательныхПолей, Отказ, Заголовок);
			return null;
		}
		// Подготавливает заголовок сообщений об ошибках при записи
		//
		// Возвращаемое значение
		//  Строка, заголовок сообщений

		public object ЗаголовокПриЗаписи(/**/)
		{
			return null;
		}
		// Возвращает имя объекта метаданных для создания регл. задания
		//
		// Возвращаемое значение
		//	Строка  - имя объекта метаданных

		public object ИмяРегламентногоЗадания(/**/)
		{
			return null;
		}
	}
}