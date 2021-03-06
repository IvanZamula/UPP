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
	public partial class ПрофилиПолномочийПользователей:СправочникОбъект
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
		public V82.СправочникиСсылка.ПрофилиПолномочийПользователей Родитель {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public bool ЭтоГруппа {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public string/*(100)*/ ОсновнойИнтерфейс {get;set;}//Основной интерфейс
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
						Insert Into _Reference22678(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld22735)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Наименование
						,@ОсновнойИнтерфейс)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference22678
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Description	= @Наименование
						,_Fld22735	= @ОсновнойИнтерфейс
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ОсновнойИнтерфейс", ОсновнойИнтерфейс);
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
					Команда.CommandText = @"Delete _Reference22678
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// МЕХАНИЗМ ОБНОВЛЕНИЯ ДАННЫХ ПОЛЬЗОВАТЕЛЕЙ ИБ

		public object СоставРолейИзменен(/*СтарыйСоставРолей*/)
		{
			if(true/*СтарыйСоставРолей.Количество() <> СоставРолей.Количество()*/)
			{
			}
			//СоставРолейКопия = СоставРолей.Выгрузить(,"ИмяРоли");
			//СоставРолейКопия.Сортировать("ИмяРоли");
			//СтарыйСоставРолей.Сортировать("ИмяРоли");
			/*// Сортируем здесь, чтобы был одинаковый алгоритм сортировки
*/
			//ИндексСтроки = 0;
			return null;
		}
		// СоставРолейИзменен
		// Функция возвращает структуру содержащую изменения этого профиля
		//

		public object ПолучитьСтуктуруИзменений(/**/)
		{
			//СтруктураИзменений = Новый Структура;
			if(true/*ЭтоНовый()*/)
			{
			}
			if(true/*СоставРолейИзменен(Ссылка.СоставРолей.Выгрузить())*/)
			{
				//СтруктураИзменений.Вставить("СоставРолей");
			}
			if(true/*Ссылка.ОсновнойИнтерфейс <> ОсновнойИнтерфейс*/)
			{
				//СтруктураИзменений.Вставить("ОсновнойИнтерфейс");
			}
			return null;
		}
		// ПолучитьСтуктуруИзменений
		// Процедура обновляет даные пользователей ИБ, имеющих данный профиль
		//

		public void ОбновитьДанныеПользователейИБ(/*Отказ*/)
		{
			if(true/*ЭтоГруппа*/)
			{
			}
			//СтруктураИзменений = ПолучитьСтуктуруИзменений();
			if(true/*СтруктураИзменений.Количество() = 0*/)
			{
			}
			//СтруктураДанных = Новый Структура;
			if(true/*СтруктураИзменений.Свойство("СоставРолей")*/)
			{
				//МассивРолей = СоставРолей.ВыгрузитьКолонку("ИмяРоли");
				//СтруктураДанных.Вставить("СоставРолей", МассивРолей);
			}
			if(true/*СтруктураИзменений.Свойство("ОсновнойИнтерфейс")*/)
			{
				//СтруктураДанных.Вставить("ОсновнойИнтерфейс", ОсновнойИнтерфейс);
			}
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("ПрофильПолномочий", Ссылка);
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	Пользователи.Код КАК ИмяПользователя
	|ИЗ
	|	Справочник.Пользователи КАК Пользователи
	|ГДЕ
	|	Пользователи.ПрофильПолномочийПользователя = &ПрофильПолномочий";*/
			//Запрос.Текст = ТекстЗапроса;
			//Результат = Запрос.Выполнить();
			//Выборка = Результат.Выбрать();
			while(true/*Выборка.Следующий()*/)
			{
				//УправлениеПользователями.ИзменитьДанныеПользователяИБ(Выборка.ИмяПользователя, СтруктураДанных);
			}
			//;;
		}
		// ОбновитьРолиПользователейИБ
		////////////////////////////////////////////////////////////////////////////////
		// СОБЫТИЯ ОБЪЕКТА

		public void ПередЗаписью(/*Отказ*/)
		{
			//ОбновитьДанныеПользователейИБ(Отказ);
		}
	}
}