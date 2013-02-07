using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РасчетЕСНПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ДЛЯ ОБЕСПЕЧЕНИЯ ПРОВЕДЕНИЯ И ЗАПИСИ ДОКУМЕНТА

		public void ДополнительныеДействияПередЗаписью(/*ДокументОбъект*/)
		{
			/*// очистим табличные части документа
*/
			if(true/*НачалоМесяца(ДокументОбъект.ПериодРегистрации) < НачалоМесяца(ПроведениеРасчетовДополнительный.ПолучитьДатуВступленияВСилуИзмененийПоСоциальнымПособиям2006())*/)
			{
				//ДокументОбъект.ПособияПоУходуЗаРебенкомДоПолутораЛет.Очистить();
				//ДокументОбъект.ПособияСоциальномуСтрахованию.Очистить();
			}
		}

		public void ДополнительныеДействияОбработкиПроведения(/*ДокументОбъект, ВыборкаПоШапкеДокумента, Заголовок, Отказ*/)
		{
			if(true/*НачалоМесяца(ВыборкаПоШапкеДокумента.ПериодРегистрации) >= НачалоМесяца(ПроведениеРасчетовДополнительный.ПолучитьДатуВступленияВСилуИзмененийПоСоциальнымПособиям2006())*/)
			{
				//ДокументОбъект.Движения.ПособияСоциальномуСтрахованию.мВыполнятьДополнительныеДвижения	= Истина;
				//ДокументОбъект.Движения.ПособияПоУходуЗаРебенкомДоПолутораЛет.мВыполнятьДополнительныеДвижения	= Истина;
				if(true/*НЕ Отказ*/)
				{
					//Выборка = РасчетЕСНДополнительный.СформироватьЗапросПоПособияСоциальномуСтрахованию(ДокументОбъект.Ссылка).Выбрать();
					while(true/*Выборка.Следующий()*/)
					{
						//ЗаполнитьЗначенияСвойств(ДокументОбъект.Движения.ПособияСоциальномуСтрахованию.Добавить(), Выборка);
					}
					//;;
				}
				if(true/*НЕ Отказ*/)
				{
					//Выборка = РасчетЕСНДополнительный.СформироватьЗапросПоПособияПоУходуЗаРебенкомДоПолутораЛет(ДокументОбъект.Ссылка).Выбрать();
					while(true/*Выборка.Следующий()*/)
					{
						//ЗаполнитьЗначенияСвойств(ДокументОбъект.Движения.ПособияПоУходуЗаРебенкомДоПолутораЛет.Добавить(),Выборка);
					}
					/*;
			Выборка = РасчетЕСНДополнительный.СформироватьЗапросЗаработкиПолучателейПособияПоУходуЗаРебенкомДоПолутораЛет(ДокументОбъект.Ссылка).Выбрать();*/
					while(true/*Выборка.Следующий()*/)
					{
						//ЗаполнитьЗначенияСвойств(ДокументОбъект.Движения.ЗаработкиПолучателейПособияПоУходуЗаРебенкомДоПолутораЛет.Добавить(),Выборка);
					}
					//;;
				}
			}
		}

		public void СформироватьДвиженияПоДоходам(/*ДокументОбъект, ВыборкаПоШапкеДокумента, Заголовок, Отказ, НаборЗаписей = Неопределено*/)
		{
			//ВыборкаПоДоходам = РасчетЕСНДополнительный.СформироватьЗапросПоДоходам(ВыборкаПоШапкеДокумента).Выбрать();
			while(true/*ВыборкаПоДоходам.Следующий()*/)
			{
				//РасчетЕСНДополнительный.ПроверитьЗаполнениеСтрокиДохода(ВыборкаПоДоходам, Отказ, Заголовок);
				if(true/*Не Отказ*/)
				{
					if(true/*НаборЗаписей = Неопределено*/)
					{
						//РасчетЕСНДополнительный.ДобавитьСтрокуВДвиженияПоДоходам(ДокументОбъект, ВыборкаПоДоходам, ВыборкаПоШапкеДокумента);
					}
				}
			}
			//;;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ РАСЧЕТА ЕСН

		public void РасчетСкидок(/*ДокументОбъект, ВыборкаПоШапкеДокумента*/)
		{
			//Отказ = Ложь;
			/*// Запишем данные о доходах из табличной части в регистр расчета
*/
			//НаборЗаписейДополнительный = РегистрыРасчета.ЕСНДополнительныеНачисления.СоздатьНаборЗаписей();
			//НаборЗаписейДополнительный.Отбор.Регистратор.Значение = ВыборкаПоШапкеДокумента.Ссылка;
			//ВыборкаПоДоходам = РасчетЕСНДополнительный.СформироватьЗапросПоДоходам(ВыборкаПоШапкеДокумента).Выбрать();
			while(true/*ВыборкаПоДоходам.Следующий()*/)
			{
				if(true/*ВыборкаПоДоходам.ТипСтроки = "Дополнительные начисления"*/)
				{
					//РасчетЕСНДополнительный.ПроверитьЗаполнениеСтрокиДохода(ВыборкаПоДоходам, Отказ);
					if(true/*Не Отказ*/)
					{
						//СтрокаНабора = НаборЗаписейДополнительный.Добавить();
						//ЗаполнитьЗначенияСвойств(СтрокаНабора,ВыборкаПоДоходам);
						//ЗаполнитьЗначенияСвойств(СтрокаНабора,ВыборкаПоШапкеДокумента);
					}
				}
			}
			if(true/*Отказ*/)
			{
			}
			/*// запишем движения
*/
			//НаборЗаписейДополнительный.Записать();
			/*// Вызовем функцию расчета скидок по набору записей регистра о дополнительных доходах 
*/
			//РасчетЕСНДополнительный.РасчетСкидокКДоходам(ВыборкаПоШапкеДокумента, НаборЗаписейДополнительный);
			//ДокументОбъект.ДополнительныеНачисления.Загрузить(НаборЗаписейДополнительный.Выгрузить());
			/*// Очистим ранее записанные в регистры расчетов сведения о доходах
*/
			//НаборЗаписейДополнительный.Очистить();
			//НаборЗаписейДополнительный.Записать();
		}
		// РасчетСкидокКДоходам()
		// заполнение доходов и расчет документа
		//

		public void Автозаполнение(/*ДокументОбъект, ВыборкаПоШапкеДокумента, ОграничениеНаСотрудников, Отказ*/)
		{
			/*// Создадим ссылки на наборы записей о доходах
*/
			//НаборЗаписейОсновной = РегистрыРасчета.ЕСНОсновныеНачисления.СоздатьНаборЗаписей();
			//НаборЗаписейОсновной.Отбор.Регистратор.Значение = ДокументОбъект.Ссылка;
			//НаборЗаписейДополнительный = РегистрыРасчета.ЕСНДополнительныеНачисления.СоздатьНаборЗаписей();
			//НаборЗаписейДополнительный.Отбор.Регистратор.Значение = ДокументОбъект.Ссылка;
			//ПособияСоциальномуСтрахованию 		  = ДокументОбъект.ПособияСоциальномуСтрахованию;
			//ПособияПоУходуЗаРебенкомДоПолутораЛет = ДокументОбъект.ПособияПоУходуЗаРебенкомДоПолутораЛет;
			//ОсновныеНачисления 		 = ДокументОбъект.ОсновныеНачисления;
			//ДополнительныеНачисления = ДокументОбъект.ДополнительныеНачисления;
			/*//подготовим таблицу для регистрации ошибок
*/
			//ТаблицаОшибок = Новый ТаблицаЗначений;
			//ТаблицаОшибок.Колонки.Добавить("Сотрудник");
			//ТаблицаОшибок.Колонки.Добавить("ВидРасчета");
			//ТаблицаОшибок.Колонки.Добавить("ПериодДействияНачало");
			//ТаблицаОшибок.Колонки.Добавить("ПериодДействияКонец");
			//ТаблицаОшибок.Колонки.Добавить("Сторно");
			//ТаблицаОшибок.Колонки.Добавить("КодОшибки");
			//ТаблицаОшибок.Колонки.Добавить("Регистратор");
			//ТаблицаОшибок.Колонки.Добавить("НомерСтроки");
			//ТаблицаОшибок.Колонки.Добавить("ВидПособияСоциальногоСтрахования");
			/*// Автозаполним наборы записей о доходах
*/
			//Отказ = РасчетЕСНДополнительный.АвтозаполнениеНаборовЗаписейОДоходах(ДокументОбъект, ВыборкаПоШапкеДокумента, НаборЗаписейОсновной, НаборЗаписейДополнительный, ОграничениеНаСотрудников, ТаблицаОшибок);
			/*// Расчет скидок к доходам
*/
			//НаборЗаписейДополнительный.Прочитать();
			//РасчетЕСНДополнительный.РасчетСкидокКДоходам(ВыборкаПоШапкеДокумента, НаборЗаписейДополнительный);
			//НаборЗаписейДополнительный.Записать();
			if(true/*НачалоМесяца(ВыборкаПоШапкеДокумента.ПериодРегистрации) < НачалоМесяца(ПроведениеРасчетовДополнительный.ПолучитьДатуВступленияВСилуИзмененийПоСоциальнымПособиям2006())*/)
			{
				/*// Считаем наборы записей о доходах и выгрузим их в табличные части документа
*/
				//НаборЗаписейОсновной.Прочитать();
				//ВременнаяТаблица = НаборЗаписейОсновной.Выгрузить();
				//ВременнаяТаблица.Свернуть("ВидРасчета,Сотрудник,ФизЛицо,КодДоходаЕСН,ОблагаетсяЕНВД,ПериодДействияНачало,ПериодДействияКонец,Сторно, ДокументОснование","Результат");
				//ДокументОбъект.ОсновныеНачисления.Загрузить(ВременнаяТаблица);
				/*// НаборЗаписейДополнительный уже считан, не сворачиваем записи, нам нужды детальные записи по доп. начислениям
*/
				//ДокументОбъект.ДополнительныеНачисления.Загрузить(НаборЗаписейДополнительный.Выгрузить());
			}
			if(true/*Отказ*/)
			{
				/*// есть ошибки в сборе данных по отражению начислений
*/
				//ТекстСообщения = "Расчет ЕСН не произведен! Для автоматического учета начислений при расчете ЕСН не хватает данных.";
				//ОбщегоНазначенияЗК.КомментарийРасчета(ТекстСообщения, , , , Перечисления.ВидыСообщений.Ошибка);
				if(true/*ТаблицаОшибок.Количество() > 0*/)
				{
					/*// сообщим пользователю об ошибках
*/
					/*//отсортируем таблицу ошибок по кодам
*/
					//ТаблицаОшибок.Сортировать("КодОшибки, ВидРасчета");
					//НовыйУчетПособий = НачалоМесяца(ВыборкаПоШапкеДокумента.ПериодРегистрации) >= НачалоМесяца(ПроведениеРасчетовДополнительный.ПолучитьДатуВступленияВСилуИзмененийПоСоциальнымПособиям2006());
					//СтруктураПоискаНачисления = Новый Структура("Сотрудник,ВидРасчета,ПериодДействияНачало,ПериодДействияКонец,ДокументОснование,Сторно");
					//СтруктураПоискаДополнительныеНачисления = Новый Структура("Сотрудник,ВидРасчета,ДокументОснование,Сторно");
					/*// коды ошибок
*/
					/*// 1 - сторно, нет данных отражения в учете начисления в прошлых периодах
*/
					/*// 2 - нет доли ЕНВД для пособий, доля ЕНВД по базовым начислениям
*/
					/*// 3 - нет данных по базе, нужен код ЕСН и доля ЕНВД
*/
					/*// 4 - нет данных по базе, нужен код ЕСН 
*/
					/*// 5 - нет данных по базе, нужна доля ЕНВД
*/
					/*// 6 - не заполнен код дохода ЕСН у вида расчета
*/
					/*// 7 - не заполнен код дохода ЕСН у вида расчета, нужна доля ЕНВД
*/
					//ТекущийКодОшибки = 0;
					//ТекущийВидРасчета = ПланыВидовРасчета.ОсновныеНачисленияОрганизаций.ПустаяСсылка();
				}
			}
		}
		// Автозаполнение()

		public void ОбработатьДанныеДляРасчетаЕСН(/*ДокументОбъект, ДанныеДляРасчетаЕСН, Отказ*/)
		{
			if(true/*Отказ*/)
			{
			}
			//ДокументОбъект.ИсчисленныйЕСН.Загрузить(ДанныеДляРасчетаЕСН.Выгрузить());
		}

		public object ПолучитьТекстЗапросаУчетнаяПолитика(/**/)
		{
			/*// УчетнаяПолитикаНалоговыйУчет
*/
			/*// Таблица УчетнаяПолитикаНалоговыйУчет - это список периодов, когда организация переходила на УСН
*/
			/*// поля:
*/
			/*//		УСН, 
*/
			/*//		Месяц - месяц налогового периода
*/
			/*// Описание:	
*/
			/*//	Выбираем Из Периоды (таблица - список периодов с начала года по текущий период)
*/
			/*//	Внутреннее соединение с "псевдосрезом" последних регистра УчетнаяПолитикаНалоговыйУчет
*/
			/*//	по равенству периодов
*/
			/*//  условие: что организация использует УСН
*/
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	МЕСЯЦ(Периоды.Период) КАК Месяц,
	|	""поле УСН"" КАК УСН
	|ПОМЕСТИТЬ ВТУчетнаяПолитикаНалоговыйУчет
	|ИЗ
	|	(ВЫБРАТЬ
	|		Периоды.Период КАК Период,
	|		МАКСИМУМ(УчетнаяПолитикаНалоговыйУчет.Период) КАК ПериодРегистра
	|	ИЗ
	|		ВТПериоды КАК Периоды
	|			ВНУТРЕННЕЕ СОЕДИНЕНИЕ РегистрСведений.УчетнаяПолитикаНалоговыйУчет КАК УчетнаяПолитикаНалоговыйУчет
	|			ПО Периоды.Период >= УчетнаяПолитикаНалоговыйУчет.Период
	|				И (УчетнаяПолитикаНалоговыйУчет.Организация = &парамГоловнаяОрганизация)
	|	
	|	СГРУППИРОВАТЬ ПО
	|		Периоды.Период) КАК Периоды
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ РегистрСведений.УчетнаяПолитикаНалоговыйУчет КАК УчетнаяПолитикаНалоговыйУчет
	|		ПО Периоды.ПериодРегистра = УчетнаяПолитикаНалоговыйУчет.Период
	|			И (УчетнаяПолитикаНалоговыйУчет.Организация = &парамГоловнаяОрганизация)
	|			И &ДопУсловие
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Месяц";*/
			//ТекстЗапроса = СтрЗаменить(ТекстЗапроса,"РегистрСведений.УчетнаяПолитикаНалоговыйУчет", ЗаполнениеРегламентированнойОтчетностиПереопределяемый.ИмяУчетнойПолитики());
			//ТекстЗапроса = СтрЗаменить(ТекстЗапроса, """поле УСН""", ЗаполнениеРегламентированнойОтчетностиПереопределяемый.ТекстПоляУСН4аФСС());
			//ТекстЗапроса = СтрЗаменить(ТекстЗапроса, "&ДопУсловие", ЗаполнениеРегламентированнойОтчетностиПереопределяемый.ТекстПоляУсловияУСН());
			return null;
		}
	}
}
