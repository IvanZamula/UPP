using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ТиповыеОтчетыПереопределяемый
	{

		public object ПолучитьЗаголовокОтчетаПереопределяемая(/*ОтчетОбъект, ФормаОтчета = Неопределено*/)
		{
			//Заголовок = "";
			if(true/*ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(ОтчетОбъект)*/)
			{
				if(true/*НЕ ЗначениеЗаполнено(ОтчетОбъект.ПроизвольныйОтчет)*/)
				{
					//ЗаголовокОтчета = "<Проивзольный отчет не выбран>";
				}
			}
			if(true/*ТиповыеОтчеты.ЭтоСтараяВерсияОтчета(ОтчетОбъект)*/)
			{
				if(true/*ЗначениеЗаполнено(ОтчетОбъект.СохраненнаяНастройка)*/)
				{
					//ТекстСохраненнаяНастройка = " (" + ОтчетОбъект.СохраненнаяНастройка + ")";
				}
			}
			//Заголовок = ЗаголовокОтчета + ТекстСохраненнаяНастройка;
			return null;
		}

		public object ПолучитьСхемуКомпоновкиОбъектаПереопределяемая(/*ОтчетОбъект*/)
		{
			if(true/*ТипЗнч(ОтчетОбъект) = Тип("СправочникСсылка.ПроизвольныеОтчеты")*/)
			{
				//СКД = ОтчетОбъект.СхемаКомпоновкиДанных.Получить();
			}
			return null;
		}

		public object ПолучитьИдентификаторОбъектаПереопределяемая(/*ОтчетОбъект*/)
		{
			if(true/*ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(ОтчетОбъект)*/)
			{
			}
			return null;
		}

		public object ЭтоСтараяВерсияОтчетаПереопределяемая(/*ОтчетОбъект*/)
		{
			//Возврат Не ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(ОтчетОбъект) И (Найти(ТиповыеОтчеты.ПолучитьИдентификаторОбъекта(ОтчетОбъект), "ОтчетОбъект") = 0 ИЛИ (ОтчетОбъект.Метаданные().Реквизиты.Найти("НастройкаПериода") <> Неопределено));
			return null;
		}

		public object ПолучитьПараметрыПанелиПользователяПоУмолчаниюПереопределяемая(/*ОтчетОбъект, ФормаОтчета = Неопределено*/)
		{
			//ДеревоНастроекСтандартныхСтраниц  = Новый ДеревоЗначений;
			//ДеревоНастроекСтандартныхСтраниц.Колонки.Добавить("Использование");
			//ДеревоНастроекСтандартныхСтраниц.Колонки.Добавить("Имя");
			//ДеревоНастроекСтандартныхСтраниц.Колонки.Добавить("Представление");
			//АналитическиеОтборы = ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(ДеревоНастроекСтандартныхСтраниц, Истина, "Период", "Период");
			if(true/*ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(ОтчетОбъект)*/)
			{
				//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(ДеревоНастроекСтандартныхСтраниц, Ложь, "ПроизвольныйОтчет", "Произвольный отчет");
				//АналитическиеОтборы = ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(ДеревоНастроекСтандартныхСтраниц, Ложь, "АналитическиеОтборы", "Аналитические отборы");
				//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(АналитическиеОтборы, Истина, "КоличествоЗаписей", "Ограничение на количество записей");
				//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(АналитическиеОтборы, Истина, "Порог", "Порог существенности");
				//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(АналитическиеОтборы, Истина, "Индикаторы", "Индикаторы (тренд, состояние)");
				//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(АналитическиеОтборы, Истина, "ABCКлассификация", "ABC - Классификация");
				//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(АналитическиеОтборы, Истина, "СкрытьНулевые", "Скрытие нулевых строк и колонок");
			}
			//Параметры  = ложь;
			//Показатели = ложь;
			//Отбор      = ложь;
			//Порядок    = ложь;
			if(true/*ФормаОтчета <> Неопределено*/)
			{
				if(true/*ФормаОтчета.ЭлементыФормы.Найти("ПанельЗакладок") <> Неопределено*/)
				{
					//Страницы = ФормаОтчета.ЭлементыФормы.ПанельЗакладок.Страницы;
					//Параметры  = ?(Страницы.Найти("Параметры") <> Неопределено И Страницы.Параметры.Видимость, Страницы.Параметры.Видимость, Параметры);
					//Показатели = ?(Страницы.Найти("Показатели") <> Неопределено И Страницы.Показатели.Видимость, Страницы.Показатели.Видимость, Показатели);
					//Отбор      = ?(Страницы.Найти("Отбор") <> Неопределено И Страницы.Отбор.Видимость, Страницы.Отбор.Видимость, Отбор);
					//Порядок    = ?(Страницы.Найти("Порядок") <> Неопределено И Страницы.Порядок.Видимость, Страницы.Порядок.Видимость, Порядок);
				}
			}
			//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(ДеревоНастроекСтандартныхСтраниц, Параметры, "Параметры", "Параметры");
			//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(ДеревоНастроекСтандартныхСтраниц, Показатели, "Показатели", "Показатели");
			//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(ДеревоНастроекСтандартныхСтраниц, Отбор, "Отбор", "Отбор");
			//ТиповыеОтчеты.ДобавитьИЗаполнитьСтроку(ДеревоНастроекСтандартныхСтраниц, Порядок, "Порядок", "Сортировка");
			//Параметры = Новый Структура;
			//Параметры.Вставить("ДеревоНастроекСтандартныхСтраниц", ДеревоНастроекСтандартныхСтраниц);
			//Параметры.Вставить("Отборы", Новый ТаблицаЗначений);
			//Группировки = Новый ТаблицаЗначений;
			//Группировки.Колонки.Добавить("Группировка");
			//Группировки.Колонки.Добавить("Представление");
			//Группировки.Колонки.Добавить("ПредставлениеСтрок");
			//Группировки.Колонки.Добавить("ПредставлениеКолонок");
			//Группировки.Колонки.Добавить("НастраиватьИерархию");
			//Группировки.Колонки.Добавить("Использование");
			//Параметры.Вставить("Группировки", Группировки);
			//СписокДоступныхОтносительныхПериодов = Новый СписокЗначений;
			//СписокДоступныхОтносительныхПериодов.Добавить("Предыдущий", "Предыдущий", Истина);
			//СписокДоступныхОтносительныхПериодов.Добавить("СНачала", "С начала текущего", Истина);
			//СписокДоступныхОтносительныхПериодов.Добавить("Текущий", "Текущий", Истина);
			//СписокДоступныхОтносительныхПериодов.Добавить("ДоКонца", "До конца текущего", Истина);
			//СписокДоступныхОтносительныхПериодов.Добавить("Следующий", "Следующий", Истина);
			//Параметры.Вставить("СписокДоступныхОтносительныхПериодов", СписокДоступныхОтносительныхПериодов);
			//Параметры.Вставить("ПроизвольныйПериод", Истина);
			//ДополнительныеНастройкиОтчета = Новый Массив;
			/*//Если ДополнительныеНастройкиОтчета.Количество = Тип("ДиаграммаГанта")  тогда
*/
			/*//	Параметры.Вставить("ВыводитьДиаграммуГантаВОтчете", Истина);
*/
			/*//	Параметры.Вставить("ПризнакВыводаДиаграммыГантаНаПанель", Истина);
*/
			/*//КонецЕсли;
*/
			//ДоступныеПериодичности = Новый ТаблицаЗначений;
			//ДоступныеПериодичности.Колонки.Добавить("Периодичность");
			//ДоступныеПериодичности.Колонки.Добавить("РассчитыватьЧерез");
			//ДоступныеПериодичности.Колонки.Добавить("Использование");
			//ТиповыеОтчеты.ДобавитьСтрокуПериодичности(ДоступныеПериодичности, "Год",       Истина);
			//ТиповыеОтчеты.ДобавитьСтрокуПериодичности(ДоступныеПериодичности, "Полугодие", Истина);
			//ТиповыеОтчеты.ДобавитьСтрокуПериодичности(ДоступныеПериодичности, "Квартал",   Истина);
			//ТиповыеОтчеты.ДобавитьСтрокуПериодичности(ДоступныеПериодичности, "Месяц",     Истина);
			//ТиповыеОтчеты.ДобавитьСтрокуПериодичности(ДоступныеПериодичности, "Декада",    Истина);
			//ТиповыеОтчеты.ДобавитьСтрокуПериодичности(ДоступныеПериодичности, "Неделя",    Истина);
			//ТиповыеОтчеты.ДобавитьСтрокуПериодичности(ДоступныеПериодичности, "День",      Истина);
			//Параметры.Вставить("ДоступныеПериодичности", ДоступныеПериодичности);
			return null;
		}

		public void ДополнитьЗначенияНастроекПанелиПользователяПоумолчанию(/*ЗначенияНастроек, ОтчетОбъект*/)
		{
			if(true/*ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(ОтчетОбъект)*/)
			{
				//ПроцедурыПроизвольныхОтчетов.ЗаполнитьЗначенияАналитическихОтборовПоумолчанию(ЗначенияНастроек);
			}
		}

		public object ПолучитьТаблицуДоступныхВариантовПереопределяемая(/*НастраиваемыйОбъект, Пользователь = Неопределено, СПомеченнымиНаУдаление = Ложь, ТипНастройки = Неопределено, СписокДоступныхНастроек = Неопределено*/)
		{
			if(true/*Пользователь = Неопределено*/)
			{
				//Пользователь = глЗначениеПеременной("глТекущийПользователь");
			}
			if(true/*ТипНастройки = Неопределено*/)
			{
				//ТипНастройки = Перечисления.ТипыНастроек.ПроизвольныеНастройки;
			}
			//Запрос = Новый Запрос;
			/*Запрос.Текст = 
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	СохраненныеНастройкиПользователи.Ссылка,
	|	СохраненныеНастройкиПользователи.Ссылка.Наименование КАК Наименование,
	|	МАКСИМУМ(ВЫБОР
	|			КОГДА СохраненныеНастройкиПользователи.ПравоИзменения
	|					ИЛИ &ПолныеПрава
	|				ТОГДА ИСТИНА
	|			ИНАЧЕ ЛОЖЬ
	|		КОНЕЦ) КАК ПравоИзменения,
	|	СохраненныеНастройкиПользователи.Ссылка.Описание
	|ИЗ
	|	Справочник.СохраненныеНастройки.Пользователи КАК СохраненныеНастройкиПользователи
	|ГДЕ
	|	СохраненныеНастройкиПользователи.Ссылка.НастраиваемыйОбъект = &НастраиваемыйОбъект
	|	И (СохраненныеНастройкиПользователи.Пользователь.Ссылка = &Пользователь
	|			ИЛИ СохраненныеНастройкиПользователи.Пользователь.Ссылка В
	|				(ВЫБРАТЬ
	|					ГруппыПользователейПользователиГруппы.Ссылка
	|				ИЗ
	|					Справочник.ГруппыПользователей.ПользователиГруппы КАК ГруппыПользователейПользователиГруппы
	|				ГДЕ
	|					ГруппыПользователейПользователиГруппы.Пользователь.Ссылка = &Пользователь)
	|			ИЛИ СохраненныеНастройкиПользователи.Пользователь.Ссылка = ЗНАЧЕНИЕ(Справочник.ГруппыПользователей.ВсеПользователи)
	|				И СохраненныеНастройкиПользователи.Ссылка В (&СписокДоступныхНастроек)
	|				И СохраненныеНастройкиПользователи.Ссылка.Предопределенный
	|			ИЛИ СохраненныеНастройкиПользователи.Пользователь.Ссылка = ЗНАЧЕНИЕ(Справочник.ГруппыПользователей.ВсеПользователи)
	|				И &СписокДоступныхНастроекНеопределен
	|				И СохраненныеНастройкиПользователи.Ссылка.Предопределенный
	|			ИЛИ СохраненныеНастройкиПользователи.Пользователь.Ссылка = ЗНАЧЕНИЕ(Справочник.ГруппыПользователей.ВсеПользователи)
	|				И (НЕ СохраненныеНастройкиПользователи.Ссылка.Предопределенный))
	|	И (&СПомеченнымиНаУдаление
	|			ИЛИ (НЕ СохраненныеНастройкиПользователи.Ссылка.ПометкаУдаления))
	|	И СохраненныеНастройкиПользователи.Ссылка.ТипНастройки = &ТипНастройки
	|
	|СГРУППИРОВАТЬ ПО
	|	СохраненныеНастройкиПользователи.Ссылка,
	|	СохраненныеНастройкиПользователи.Ссылка.Наименование,
	|	СохраненныеНастройкиПользователи.Ссылка.Описание
	|
	|УПОРЯДОЧИТЬ ПО
	|	Наименование
	|АВТОУПОРЯДОЧИВАНИЕ";*/
			//Запрос.УстановитьПараметр("Пользователь",                       Пользователь);
			//Запрос.УстановитьПараметр("НастраиваемыйОбъект",                НастраиваемыйОбъект);
			//Запрос.УстановитьПараметр("СписокДоступныхНастроек",            СписокДоступныхНастроек);
			//Запрос.УстановитьПараметр("СписокДоступныхНастроекНеопределен", СписокДоступныхНастроек = Неопределено);
			if(true/*Найти(НастраиваемыйОбъект, "ОтчетОбъект") > 0 
		ИЛИ ТипЗнч(НастраиваемыйОбъект) = Тип("СправочникСсылка.ПроизвольныеОтчеты")*/)
			{
				//Запрос.УстановитьПараметр("ТипНастройки", Перечисления.ТипыНастроек.НастройкиОтчета);
			}
			//Запрос.УстановитьПараметр("ПолныеПрава", РольДоступна("ПолныеПрава"));
			//Запрос.УстановитьПараметр("СПомеченнымиНаУдаление", СПомеченнымиНаУдаление);
			return null;
		}

		public void ДополнитьЗначенияНастроекПанелиПользователя(/*ЗначенияНастроек, ОтчетОбъект, ФормаОтчета*/)
		{
			if(true/*ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(ОтчетОбъект)*/)
			{
				//ПроцедурыПроизвольныхОтчетов.ЗаполнитьЗначенияАналитическихОтборов(ЗначенияНастроек, ФормаОтчета.ЭлементыФормы);
			}
		}

		public void ПослеВыводаПанелиПользователя(/*ОтчетОбъект, ФормаОтчета, ДеревоНастроекСтандартныхСтраниц, ЗначенияНастроек*/)
		{
			if(true/*ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(ОтчетОбъект)*/)
			{
				/*// Управление видимостью аналитических отборов для Аналитического отчета
*/
				//НастройкаСтраницы = ДеревоНастроекСтандартныхСтраниц.Строки.Найти("АналитическиеОтборы", "Имя");
				//ФормаОтчета.НарисоватьАналитическиеОтборы(НастройкаСтраницы, ЗначенияНастроек);
			}
		}

		public object ПолучитьОтчетДляРасшифровкиПереопределяемая(/*ОтчетОбъект*/)
		{
			if(true/*ТиповыеОтчеты.ЭтоВнешнийОбъект(ОтчетОбъект)*/)
			{
				//НовыйОтчет = ВнешниеОтчеты.Создать(ОтчетОбъект.ИспользуемоеИмяФайла);
			}
			if(true/*ПроцедурыПроизвольныхОтчетов.ЭтоПроизвольныйОтчет(НовыйОтчет)*/)
			{
				//НовыйОтчет.УстановитьПроизвольныйОтчет(ОтчетОбъект.ПроизвольныйОтчет, ОтчетОбъект.СохраненнаяНастройка);
			}
			//НовыйОтчет.ЗначенияНастроекПанелиПользователя = Неопределено;
			return null;
		}
		//
	}
}
