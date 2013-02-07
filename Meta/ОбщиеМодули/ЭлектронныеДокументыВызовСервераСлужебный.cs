using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЭлектронныеДокументыВызовСервераСлужебный
	{
		////////////////////////////////////////////////////////////////////////////////
		// ЭлектронныеДокументыВызовСервераСлужебный: механизм обмена электронными документами.
		//
		////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЙ ПРОГРАММНЫЙ ИНТЕРФЕЙС
		////////////////////////////////////////////////////////////////////////////////
		// Регистрация объектов для обмена электронными документами
		// Обработчик события "ПередЗаписью" владельцев электронных документов.
		//
		// Параметры:
		//  Источник        - объект - владелец присоединенного файла,
		//  Отказ           - булево - признак отказа от записи,
		//  РежимЗаписи     - РежимЗаписиДокумента - режим записи владельца электронного документа,
		//  РежимПроведения - РежимПроведенияДокумента - режим проведения владельца электронного документа.
		//

		public void ЭлектронныеДокументыВладелецПередЗаписью(/*Источник, Отказ, РежимЗаписи, РежимПроведения*/)
		{
			/*// Пометим на удаление (снимем пометку) электронные документы, связанные с владельцем
*/
			if(true/*НЕ Источник.ЭтоНовый()*/)
			{
				//ИсточникСсылкаПометкаУдаления = ОбщегоНазначения.ПолучитьЗначениеРеквизита(Источник.Ссылка, "ПометкаУдаления");
				if(true/*Источник.ПометкаУдаления <> ИсточникСсылкаПометкаУдаления*/)
				{
					//ЭлектронныеДокументыСлужебный.ПометитьНаУдалениеЭлектронныеДокументыПоВладельцу(Источник.Ссылка);
				}
			}
			if(true/*НЕ Константы.ИспользоватьОбменЭД.Получить()*/)
			{
			}
			//ТипИсточника = ТипЗнч(Источник);
			/*// ЭД делаем только когда есть действующее соглашение об обмене
*/
			if(true/*(НЕ Источник.ДополнительныеСвойства.Свойство("ЕстьСоглашение") ИЛИ НЕ Источник.ДополнительныеСвойства.ЕстьСоглашение)
		И НЕ ТипИсточника = Тип("ДокументОбъект.ПакетЭД")*/)
			{
				//ПараметрыЭД = ЗаполнитьПараметрыЭДПоИсточнику(Источник);
				if(true/*НЕ ЭлектронныеДокументыСлужебный.ЕстьДействующееСоглашение(ПараметрыЭД)*/)
				{
				}
			}
			//Источник.ДополнительныеСвойства.Вставить("ЕстьСоглашение", Истина);
			if(true/*Источник.ОбменДанными.Загрузка*/)
			{
			}
			//ПроверитьМодификациюОбъектаДляОбменаЭД(Источник);
		}
		// Обработчик события "ПриЗаписи" владельцев электронных документов.
		//
		// Параметры:
		//  Источник - объект - владелец присоединенного файла,
		//  Отказ    - булево - признак отказа от записи.
		//

		public void ЭлектронныеДокументыВладелецПриЗаписи(/*Источник, Отказ*/)
		{
			if(true/*НЕ Источник.ДополнительныеСвойства.Свойство("ЕстьСоглашение")
		ИЛИ НЕ Источник.ДополнительныеСвойства.ЕстьСоглашение*/)
			{
				//ЭлектронныеДокументыСлужебный.ПроверитьНаличиеИУдалитьСостояниеДокумента(Источник.Ссылка);
			}
			if(true/*НЕ Источник.ДополнительныеСвойства.Свойство("ЗарегистрироватьОбъект")
		ИЛИ НЕ Источник.ДополнительныеСвойства.ЗарегистрироватьОбъект*/)
			{
			}
			//ЭлектронныеДокументыСлужебный.УстановитьНовуюВерсиюЭД(Источник.Ссылка);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Изменение электронных документов
		// Обработчик события "ПередЗаписью" электронных документов.
		//
		// Параметры:
		//  Источник - объект - электронный документ,
		//  Отказ    - булево - признак отказа от записи.
		//

		public void ПередЗаписьюЭлектронногоДокумента(/*Источник, Отказ*/)
		{
			if(true/*Источник.ОбменДанными.Загрузка*/)
			{
			}
			if(true/*Источник.ПометкаУдаления*/)
			{
				//ЭлектронныеДокументыСлужебный.ОбработатьУдалениеЭлектронногоДокумента(Источник.Ссылка);
			}
			if(true/*НЕ ЗначениеЗаполнено(Источник.НаправлениеЭД)
		ИЛИ НЕ ЗначениеЗаполнено(Источник.ВидЭД)
		ИЛИ НЕ ЗначениеЗаполнено(Источник.ВладелецФайла)
		ИЛИ ТипЗнч(Источник.ВладелецФайла) = Тип("ДокументСсылка.ПроизвольныйЭД")*/)
			{
			}
			if(true/*НЕ ЗначениеЗаполнено(Источник.Ссылка) ИЛИ Источник.Ссылка.СтатусЭД = Источник.СтатусЭД*/)
			{
				//Источник.ДополнительныеСвойства.Вставить("ЗаписатьСобытиеЖР", Ложь);
			}
			//Источник.ДополнительныеСвойства.Вставить("ЗаписатьСобытиеЖР", Истина);
			/*Источник.ДополнительныеСвойства.Вставить("СостояниеВерсииЭД", ЭлектронныеДокументыСлужебный.ОпределитьСостояниеВерсииПоСтатусуЭД(
		Источник.Ссылка));*/
		}
		// Обработчик события "ПриЗаписи" электронных документов.
		//
		// Параметры:
		//  Источник - объект - электронный документ,
		//  Отказ    - булево - признак отказа от записи.
		//

		public void ПриЗаписиЭлектронногоДокумента(/*Источник, Отказ*/)
		{
			if(true/*Источник.ДополнительныеСвойства.Свойство("ЗаписатьСобытиеЖР")
		И Источник.ДополнительныеСвойства.ЗаписатьСобытиеЖР*/)
			{
				//ЭлектронныеДокументыСлужебный.ЗаписатьСобытиеЖурналаРегистрацииПоОбменуЭД(Источник.Ссылка);
			}
			if(true/*Источник.ТипЭлементаВерсииЭД = Перечисления.ТипыЭлементовВерсииЭД.ПДО*/)
			{
			}
			//СостояниеВерсииЭД = Неопределено;
			if(true/*Источник.ДополнительныеСвойства.Свойство("СоглашениеЭД")*/)
			{
				//СостояниеВерсииЭД = ЭлектронныеДокументыСлужебный.ОпределитьСостояниеВерсииПоСтатусуЭД(Источник.Ссылка);
			}
			if(true/*Источник.ДополнительныеСвойства.Свойство("СостояниеВерсииЭД")*/)
			{
				//СледСостояниеВерсииЭД = Источник.ДополнительныеСвойства.СостояниеВерсииЭД;
				//СтруктураТекВерсииЭД  = ЭлектронныеДокументыСлужебный.ПолучитьСтруктуруВерсииЭД(Источник.ВладелецФайла);
				if(true/*СледСостояниеВерсииЭД <> СтруктураТекВерсииЭД.СостояниеВерсииЭД*/)
				{
					//ЭлектронныеДокументыСлужебный.ОбновитьВерсиюЭД(Источник.Ссылка);
				}
			}
		}
		////////////////////////////////////////////////////////////////////////////////
		// Прочие
		// Определяет параметры электронного документа по типу владельца.
		//
		// Параметры:
		//  Источник - объекта либо ссылка документа/справочника-источника.
		//
		// Возвращаемое значение:
		//  ПараметрыЭД - структура параметров источника, необходимых для определения
		//  	настроек обмена ЭД. Обязательные параметры: НаправлениеЭД, ВидЭД,
		//  	Контрагент, СоглашениеЭД или Организация.
		//

		public object ЗаполнитьПараметрыЭДПоИсточнику(/*Источник*/)
		{
			//ПараметрыЭД = ЭлектронныеДокументыСлужебный.СтруктураПараметровЭД();
			//ТипИсточника = ТипЗнч(Источник);
			if(true/*ТипИсточника = Тип("ДокументСсылка.ПроизвольныйЭД")
		ИЛИ ТипИсточника = Тип("ДокументОбъект.ПроизвольныйЭД")*/)
			{
				//ПараметрыЭД.ВидЭД         = Перечисления.ВидыЭД.ПроизвольныйЭД;
				//ПараметрыЭД.НаправлениеЭД = Источник.Направление;
				//ПараметрыЭД.Контрагент    = Источник.Контрагент;
				//ПараметрыЭД.Организация   = Источник.Организация;
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		////////////////////////////////////////////////////////////////////////////////
		// Регистрация объектов для обмена электронными документами

		public void ПроверитьМодификациюОбъектаДляОбменаЭД(/*Источник, ПризнакИзменения = Ложь*/)
		{
			if(true/*ПризнакИзменения ИЛИ Источник.ЭтоНовый()*/)
			{
				//ЗарегистрироватьОбъект = Истина;
			}
			//Источник.ДополнительныеСвойства.Вставить("ЗарегистрироватьОбъект", ЗарегистрироватьОбъект);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Определение модифицированности объекта, аналогичные подсистеме обмена данными

		public object НадоЗарегистрироватьОбъект(/*Источник, ОбъектМетаданных*/)
		{
			//ИмяОбъекта = ОбъектМетаданных.ПолноеИмя();
			//ТаблицаРеквизитовРегистрации = ЭлектронныеДокументыСлужебный.ПолучитьТаблицуКлючевыхРеквизитовОбъекта(ИмяОбъекта);
			if(true/*ТаблицаРеквизитовРегистрации.Количество() = 0*/)
			{
				/*// Если перечень реквизитов не задан, то считаем, что объект модифицирован всегда
*/
			}
			/*// Если дошли до конца, то объект не изменился по реквизитам регистрации;
*/
			/*// Регистрация не нужна
*/
			return null;
		}

		public object ОпределитьИзмененияВерсийОбъекта(/*Объект, СтрокаТаблицыРеквизитовРегистрации*/)
		{
			if(true/*ПустаяСтрока(СтрокаТаблицыРеквизитовРегистрации.ИмяТабличнойЧасти)*/)
			{
				/*ТаблицаРеквизитовРегистрацииВерсияОбъектаДоИзменения = ПолучитьТаблицуРеквизитовРегистрацииШапкиДоИзменения(Объект,
			СтрокаТаблицыРеквизитовРегистрации);*/
				/*ТаблицаРеквизитовРегистрацииВерсияОбъектаПослеИзменения = ПолучитьТаблицуРеквизитовРегистрацииШапкиПослеИзменения(
			Объект, СтрокаТаблицыРеквизитовРегистрации);*/
			}
			return null;
		}

		public object ПолучитьТаблицуРеквизитовРегистрацииШапкиДоИзменения(/*Объект, СтрокаТаблицыРеквизитовРегистрации*/)
		{
			return null;
		}

		public object ПолучитьТаблицуРеквизитовРегистрацииТабличнойЧастиДоИзменения(/*Объект, СтрокаТаблицыРеквизитовРегистрации*/)
		{
			return null;
		}

		public object ПолучитьТаблицуРеквизитовРегистрацииШапкиПослеИзменения(/*Объект, СтрокаТаблицыРеквизитовРегистрации*/)
		{
			//ТаблицаРеквизитовРегистрации = Новый ТаблицаЗначений;
			//СтруктураРеквизитовРегистрации = СтрокаТаблицыРеквизитовРегистрации.СтруктураРеквизитовОбъекта;
			//СтрокаТаблицы = ТаблицаРеквизитовРегистрации.Добавить();
			return null;
		}

		public object ПолучитьТаблицуРеквизитовРегистрацииТабличнойЧастиПослеИзменения(/*Объект, СтрокаТаблицыРеквизитовРегистрации*/)
		{
			/*ТаблицаРеквизитовРегистрации = Объект[СтрокаТаблицыРеквизитовРегистрации.ИмяТабличнойЧасти].Выгрузить(,
		СтрокаТаблицыРеквизитовРегистрации.РеквизитыОбъекта);*/
			return null;
		}
	}
}
