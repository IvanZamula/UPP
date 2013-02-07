using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РаботаСДиалогамиПереопределяемый
	{
		// Этот модуль предназачен для реализации алгоритмов работы форм и
		// содержит процедуры и функции работы с формами и элементами форм,
		// а также подготовки данных для представления информации в формах.
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ОФОРМЛЕНИЯ ФОРМЫ
		// Процедура предназначена для управления видимостью элементов формы,
		// вызывается в обработчиках событий "ПриОткрытии" форм, при изменении реквизита Организация
		//
		// Параметры:
		//  ЭлементыФормы  - массив с коллекцией ЭУ формы, видимость которых необходимо определить
		//  УчетнаяПолитикаПоПерсоналу - структура, содержит данные учетной политики
		//    предприятия или конкретной организации
		//

		public void УстановитьВидимостьЭУПоУчетнойПолитикеПоПерсоналу(/*ЭлементыФормы,УчетнаяПолитикаПоПерсоналу,Организация = Неопределено*/)
		{
			//ИспользуютсяНачисленияВВалюте			= Ложь;
			//ПоказыватьТабельныеНомераВДокументах	= Ложь;
			//ПоддерживатьНесколькоСхемМотивации		= Ложь;
			if(true/*Организация = Неопределено*/)
			{
				if(true/*УчетнаяПолитикаПоПерсоналу <> Неопределено*/)
				{
					if(true/*Не УчетнаяПолитикаПоПерсоналу.Свойство("ИспользуютсяНачисленияВВалюте",ИспользуютсяНачисленияВВалюте)*/)
					{
						//ИспользуютсяНачисленияВВалюте = Ложь;
					}
					if(true/*Не УчетнаяПолитикаПоПерсоналу.Свойство("ПоказыватьТабельныеНомераВДокументах",ПоказыватьТабельныеНомераВДокументах)*/)
					{
						//ПоказыватьТабельныеНомераВДокументах = Ложь;
					}
					if(true/*Не УчетнаяПолитикаПоПерсоналу.Свойство("ПоддерживатьНесколькоСхемМотивации",ПоддерживатьНесколькоСхемМотивации)*/)
					{
						//ПоддерживатьНесколькоСхемМотивации = Ложь;
					}
				}
			}
			//ТипКолонкаТабличногоПоля = Тип("КолонкаТабличногоПоля");
			//ТипПолеВвода = Тип("ПолеВвода");
			//ТипНадпись = Тип("Надпись");
			//ТипПанель  = Тип("Панель");
		}
		// УстановитьВидимостьЭУПоУчетнойПолитикеПоПерсоналу()
		//Процедура предназначена для управления видимостью элементов формы, относящихся к Бухучету
		// вызывается в обработчиках событий "ПриОткрытии" форм, при изменении реквизита Организация
		//
		// Параметры:
		//  СтруктураЭУ  - ключ: имя группы ЭУ, значение: массив с коллекцией ЭУ формы, видимость которых необходимо определить
		//  ВидимостьНУСчета - переменная, в которой возвращается
		//  Организация - организация,
		//

		public void УстановитьВидимостьЭУБухучета(/*СтруктураЭУ, ВидимостьНУСчета = Ложь , Организация, Дата*/)
		{
			//ДатаПериода = КонецМесяца(Дата);
			/*// на эту дату получаем значение учетной политики
*/
			//СтруктураПараметровПеременныхВеденияУчета = ОтражениеЗарплатыВРеглУчетеДополнительный.ПолучитьСтруктураПараметровПеременныхВеденияУчета(Организация, ДатаПериода);
			//УСН = СтруктураПараметровПеременныхВеденияУчета.УСН;
			//ОбъектНалогообложенияУСНДДоходыМинусРасходы = СтруктураПараметровПеременныхВеденияУчета.ОбъектНалогообложенияУСН = Перечисления.ОбъектыНалогообложенияПоУСН.ДоходыМинусРасходы;
			//ВидимостьУСН = УСН и ОбъектНалогообложенияУСНДДоходыМинусРасходы;
			//ВидимостьИП = СтруктураПараметровПеременныхВеденияУчета.ПредпринимательНаОСН;
			//ВидимостьНУСчета = НЕ УСН и СтруктураПараметровПеременныхВеденияУчета.ЗаполнятьСчетаНУ;
			//ВидимостьНУ = НЕ ВидимостьНУСчета и СтруктураПараметровПеременныхВеденияУчета.ЗаполнятьДанныеНУ;
			//ВидимостьУчетПоПодразделениям = СтруктураПараметровПеременныхВеденияУчета.УчетПоПодразделениямНаСчетах;
			//ВидимостьОКАТОКПП = СтруктураПараметровПеременныхВеденияУчета.ЗаполнятьОКАТОКПП;
			//ТипКолонкаТабличногоПоля = Тип("КолонкаТабличногоПоля");
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ОБРАБОТКИ ИНФОРМАЦИИ В ФОРМЕ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПОДГОТОВКИ ИНФОРМАЦИИ В ФОРМЕ
		// Формирует представление переданного код дохода с "предметной" точки зрения
		//
		// Параметры
		//  , КодДоходаЕСН - СправочникСсылка.ДоходыЕСН - описываемый код дохода
		//
		// Возвращаемое значение:
		//   строка - сформированное представление
		//

		public object ПолучитьПредставлениеКодаДоходаПоЕСН(/*КодДоходаЕСН*/)
		{
			if(true/*КодДоходаЕСН = Справочники.ДоходыЕСН.ВыплатыЗаСчетПрибыли*/)
			{
				//РасшифровкаКодДоходаЕСН = "Не является объектом налогообложения по ЕСН (в части Федерального бюджета, ФОМС и ФСС) и взносами на обязательное пенсионное страхование согласно п.3 ст. 236 НК РФ (выплаты за счет прибыли)";
			}
			return null;
		}
		// ПолучитьПредставлениеСпособаОтраженияНачисленияВУчетах()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПРЕДСТАВЛЕНИЯ ИНФОРМАЦИИ В ФОРМЕ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ФОРМИРОВАНИЯ И ОБРАБОТКИ МЕНЮ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ и ФУНКЦИИ ИНФОРМИРОВАНИЯ ПОЛЬЗОВАТЕЛЯ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ОБРАБОТКИ СВОЙСТВ И КАТЕГОРИЙ ДОКУМЕНТОВ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ РАБОТЫ С ИСТОРИЕЙ ВВОДА ЗНАЧЕНИЙ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЧИЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Вызывает процедуру показа Веб страницы и передает в нее адрес страницы с отзывом о конфигурации
		//

		public void ПерейтиНаСтраницуОтзывОПрограмме(/**/)
		{
			//РаботаСДиалогамиЗК.ПоказатьВебСтраницу("www.1c.ru/usability/inquirer/upp.jsp", "Отзыв о программе", "ОтзывОПрограмме");
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ФОРМИРОВАНИЯ И ОБРАБОТКИ МЕНЮ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ЗАПОЛНЕНИЯ РЕКВИЗИТОВ В ФОРМЕ
		////////////////////////////////////////////////////////////////////////////////
		// процедуры поддержки команд в журналах документов
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПОДГОТОВКИ ИНФОРМАЦИИ В ФОРМЕ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ДЛЯ ОБЕСПЕЧЕНИЯ ВВОДА ДАТЫ КАК МЕСЯЦА
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ МЕХАНИЗМА КОММЕНТИРОВАНИЯ ДЕЙСТВИЙ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ МЕХАНИЗМА ВСТРОЕННОЙ СПРАВКИ
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ДЛЯ ИЗМЕНЕНИЯ ВИДИМОСТИ ПАНЕЛЕЙ
		///////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПЛАНОВ ВИДОВ РАСЧЕТА
		// Функция возвращает структуру с отборами для выбора из ПланыВидовРасчета.ОсновныеНачисленияОрганизаций
		// в.р., являющегося надбавкой
		// структура параметров отбора может использоваться в процедурах АвтоПодборТекстаВЭлементеУправления
		//
		// Параметры
		//  ВидДоговора  - ВидДоговора
		//
		// Возвращаемое значение:
		//   Структура   - структура, ключ - имя реквизита ПВР, значение - массив со значениями отбора
		//

		public object ПолучитьСтруктуруОтборовНадбавокСотрудника(/*ВидДоговора*/)
		{
			//ВидыВремени = Новый Массив;
			//ВидыВремени.Добавить(Перечисления.ВидыВремени.ДополнительноОплачиваемоеВПределахНормы);
			//СтруктураПараметров = Новый Структура("ВидВремени", ВидыВремени);
			//СсылкаПредопределенный = Новый Массив;
			//СсылкаПредопределенный.Добавить(Ложь);
			//СтруктураПараметров.Вставить("Предопределенный", СсылкаПредопределенный);
			//СпоcобыРасчета = Новый Массив;
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ПоМесячнойТарифнойСтавкеПоДням);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ПоМесячнойТарифнойСтавкеПоЧасам);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ПоДневнойТарифнойСтавке);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ПоЧасовойТарифнойСтавке);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ОтСтажаПоМесячнойТарифнойСтавкеПоДням);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ОтСтажаПоМесячнойТарифнойСтавкеПоЧасам);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ОтСтажаПоДневнойТарифнойСтавке);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ОтСтажаПоЧасовойТарифнойСтавке);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ОтСтажаПроцентом);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.Процентом);
			//СпоcобыРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ПроизвольнаяФормула);
			//СтруктураПараметров.Вставить("СпособРасчета", СпоcобыРасчета);
			return null;
		}
		// Функция возвращает структуру с отборами для выбора из ПланыВидовРасчета.ОсновныеНачисленияОрганизаций
		// основного начисления сотрудника, регистрирующего отработанное время
		// структура параметров отбора может использоваться в процедурах АвтоПодборТекстаВЭлементеУправления
		//
		// Параметры
		//  ВидДоговора  - ВидДоговора
		//
		// Возвращаемое значение:
		//   Структура   - структура, ключ - имя реквизита ПВР, значение - массив со значениями отбора
		//

		public object ПолучитьСтруктуруОтборовОсновногоНачисленияСотрудника(/*ВидДоговора*/)
		{
			//ВидыВремени = Новый Массив;
			//ВидыВремени.Добавить(Перечисления.ВидыВремени.ОтработанноеВПределахНормы);
			//СтруктураПараметров = Новый Структура("ВидВремени", ВидыВремени);
			return null;
		}
	}
}
