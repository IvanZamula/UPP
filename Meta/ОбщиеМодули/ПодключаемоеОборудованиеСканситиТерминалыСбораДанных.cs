using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудованиеСканситиТерминалыСбораДанных
	{
		///////////////////////////////////////////////////////////////////////////////
		// ПРОГРАММНЫЙ ИНТЕРФЕЙС
		// Функция осуществляет подключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера   - <*>
		//           - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ПодключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ПараметрыПодключения.Вставить("ИДУстройства", "");
			//ВыходныеПараметры = Новый Массив();
			/*// Проверка параметров устройства
*/
			//Порт                     = Неопределено;
			//Скорость                 = Неопределено;
			//ТипСвязи                 = Неопределено;
			//НомерБазы                = Неопределено;
			//НомерДокумента           = Неопределено;
			//ОчищатьДокумент          = Неопределено;
			//ВыбиратьИсточникЗагрузки = Неопределено;
			//ФорматБазы               = Неопределено;
			//ФорматДокумента          = Неопределено;
			//Модель                   = Неопределено;
			//Параметры.Свойство("Порт"                    , Порт);
			//Параметры.Свойство("Скорость"                , Скорость);
			//Параметры.Свойство("ТипСвязи"                , ТипСвязи);
			//Параметры.Свойство("НомерБазы"               , НомерБазы);
			//Параметры.Свойство("НомерДокумента"          , НомерДокумента);
			//Параметры.Свойство("ОчищатьДокумент"         , ОчищатьДокумент);
			//Параметры.Свойство("ВыбиратьИсточникЗагрузки", ВыбиратьИсточникЗагрузки);
			//Параметры.Свойство("ФорматБазы"              , ФорматБазы);
			//Параметры.Свойство("ФорматДокумента"         , ФорматДокумента);
			//Параметры.Свойство("Модель",                   Модель);
			if(true/*Порт                     = Неопределено
	 Или Скорость                 = Неопределено
	 Или ТипСвязи                 = Неопределено
	 Или НомерБазы                = Неопределено
	 Или НомерДокумента           = Неопределено
	 Или ОчищатьДокумент          = Неопределено
	 Или ВыбиратьИсточникЗагрузки = Неопределено
	 Или ФорматБазы               = Неопределено
	 Или ФорматДокумента          = Неопределено
	 Или Модель                   = Неопределено*/)
			{
				//ВыходныеПараметры.Добавить(999);
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
				//Результат = Ложь;
			}
			if(true/*Результат*/)
			{
				//МассивЗначений = Новый Массив;
				//МассивЗначений.Добавить(Порт);
				//МассивЗначений.Добавить(Скорость);
				//МассивЗначений.Добавить(ТипСвязи);
				if(true/*ОбъектДрайвера.Подключить(МассивЗначений, ПараметрыПодключения.ИДУстройства)*/)
				{
					//ВыходныеПараметры.Добавить("");
					/*// Источник событий
*/
					//ВыходныеПараметры.Добавить(Неопределено);
					/*// Список событий
*/
				}
			}
			return null;
		}
		// Функция осуществляет отключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера - <*>
		//         - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ОтключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Ложь;
			/*// Обязательные выходные
*/
			//ВыходныеПараметры = Новый Массив();
			if(true/*НЕ ОбъектДрайвера.Отключить(ПараметрыПодключения.ИДУстройства)*/)
			{
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить("");
				//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
			}
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			//Результат = Истина;
			//ВыходныеПараметры = Новый Массив();
			/*// Выгрузка таблицы в устройство
*/
			if(true/*Команда = "ВыгрузитьТаблицу" ИЛИ Команда = "UploadDirectory"*/)
			{
				//ТаблицаВыгрузки = ВходныеПараметры[1];
				/*Результат = ВыгрузитьТаблицу(ОбъектДрайвера, Параметры, ПараметрыПодключения,
		                             ТаблицаВыгрузки, ВыходныеПараметры);*/
				/*// Загрузка таблицы из устройства
*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция осуществляет подготовку процедуры выгрузки данных в терминал.
		//

		public object НачатьВыгрузку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//Ответ = ОбъектДрайвера.НачатьЗагрузку(Параметры.НомерБазы);
			if(true/*НЕ (Ответ = 0)*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить("");
				//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
				//Результат = Ложь;
			}
			return null;
		}
		// Функция осуществляет выгрузку строки в терминал сбора данных.
		//
		// Параметры:
		//  Объект                         - <*>
		//                                 - Объект драйвера торгового оборудования.
		//
		//  Штрихкод                       - <Строка>
		//                                 - Штрихкод товара.
		//
		//  Номенклатура                   - <СправочникСсылка.Номенклатура>
		//                                 - Номенклатура.
		//
		//  ЕдиницаИзмерения               - <СправочникСсылка.ЕдиницыИзмерения>
		//                                 - Единица измерения номенклатуры.
		//
		//  ХарактеристикаНоменклатуры     - <СправочникСсылка.ХарактеристикиНоменклатуры>
		//                                 - Характеристика номенклатуры.
		//
		//  СерияНоменклатуры              - <СправочникСсылка.СерииНоменклатуры>
		//                                 - Серия номенклатуры.
		//
		//  Качество                       - <СправочникСсылка.Качество>
		//                                 - Качество.
		//
		//  Цена                           - <Число>
		//                                 - Цена номенклатуры.
		//
		//  Количество                     - <Число>
		//                                 - Количество номенклатуры.
		//
		// Возвращаемое значение:
		//  <ПеречислениеСсылка.ТООшибки*> - Результат работы функции
		//

		public object ВыгрузитьСтроку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                        Штрихкод, Номенклатура, ЕдиницаИзмерения,
                        ХарактеристикаНоменклатуры, СерияНоменклатуры,
                        Качество, Цена, Количество, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			/*// Обрезание поля "Номенклатура" связана с настройками задач ТСД, где по умолчанию наименование 40 символов
*/
			if(true/*Параметры.ФорматБазы.Количество() > 0*/)
			{
				//КоличествоПолей = Параметры.ФорматБазы.Количество();
			}
			//Ответ = ОбъектДрайвера.ДобавитьЗапись(КоличествоПолей);
			if(true/*НЕ (Ответ = 0)*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить("");
				//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
				//Результат = Ложь;
			}
			return null;
		}
		// Функция осуществляет завершение процедуры выгрузки данных в терминал сбора данных.
		//

		public object ЗавершитьВыгрузку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ОбъектДрайвера.ЗавершитьЗагрузку();
			return null;
		}
		// Функция осуществляет подготовку процедуры загрузки данных из терминала сбора данных.
		//

		public object НачатьЗагрузку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, Количество, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ПараметрыПодключения.Вставить("ПоследнийИсточникЗагрузки", "Документ");
			if(true/*Параметры.ВыбиратьИсточникЗагрузки*/)
			{
				//СписокИсточниковЗагрузки = Новый СписокЗначений();
				//СписокИсточниковЗагрузки.Добавить("Документ", НСтр("ru='Документ терминала сбора данных'"));
				//СписокИсточниковЗагрузки.Добавить("База",     НСтр("ru='База терминала сбора данных'"));
				//ИсточникЗагрузки = СписокИсточниковЗагрузки.ВыбратьЭлемент(НСтр("ru='Выберите источник загрузки данных'"));
				if(true/*ИсточникЗагрузки <> Неопределено*/)
				{
					//ПараметрыПодключения.ПоследнийИсточникЗагрузки = ИсточникЗагрузки.Значение;
					if(true/*ПараметрыПодключения.ПоследнийИсточникЗагрузки = "Документ"*/)
					{
						//Количество = ОбъектДрайвера.ЧислоЗаписей(0, Параметры.НомерДокумента);
					}
				}
			}
			if(true/*Количество > 0*/)
			{
				if(true/*ПараметрыПодключения.ПоследнийИсточникЗагрузки = "Документ"*/)
				{
					//ОбъектДрайвера.НачатьЧтение(0, Параметры.НомерДокумента);
				}
			}
			return null;
		}
		// Функция осуществляет загрузку строки из терминала сбора данных.
		//
		// Параметры:
		//  Объект                         - <*>
		//                                 - Объект драйвера торгового оборудования.
		//
		//  Штрихкод                       - <Строка>
		//                                 - Штрихкод, соответствующий данной номенклатуре.
		//
		//  Количество                     - <Число>
		//                                 - Выходной параметр; количество номенклатуры.
		//
		// Возвращаемое значение:
		//  <ПеречислениеСсылка.ТООшибки*> - Результат работы функции.
		//

		public object ЗагрузитьСтроку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, Штрихкод, Количество, ВыходныеПараметры*/)
		{
			//Результат  = Истина;
			//Штрихкод   = Неопределено;
			//Количество = Неопределено;
			//Ответ = ОбъектДрайвера.ЧитатьЗапись();
			if(true/*Ответ > 0*/)
			{
				if(true/*Параметры.ФорматДокумента.Количество() > 0*/)
				{
				}
			}
			return null;
		}
		// Функция осуществляет завершение процедуры загрузки данных из терминала сбора данных.
		//
		// Параметры:
		//  Объект                         - <*>
		//                                 - Объект драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <ПеречислениеСсылка.ТООшибки*> - Результат работы функции.
		//

		public object ЗавершитьЗагрузку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//Ответ = ОбъектДрайвера.ЗавершитьЧтение();
			if(true/*НЕ (Ответ = 0)*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить("");
				//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
				//Результат = Ложь;
			}
			return null;
		}
		// Функция осуществляет выгрузку строки в терминал сбора данных.
		//

		public object ВыгрузитьТаблицу(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ТаблицаВыгрузки, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			if(true/*ТаблицаВыгрузки.Количество() = 0*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить(НСтр("ru='Нет данных для выгрузки.'"));
			}
			//Результат = НачатьВыгрузку(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
			if(true/*Результат*/)
			{
				//ТекущийПроцент = 0;
				//ПроцентИнкремент = 100 / ТаблицаВыгрузки.Количество();
				//ОбъектДрайвера.РазделительБД = 11;
				if(true/*Результат*/)
				{
					//Результат = ЗавершитьВыгрузку(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
				}
			}
			return null;
		}
		// Функция осуществляет загрузку строки из терминала сбора данных.
		//

		public object ЗагрузитьТаблицу(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат  = Истина;
			//Штрихкод   = Неопределено;
			//Количество = Неопределено;
			//Результат = НачатьЗагрузку(ОбъектДрайвера, Параметры, ПараметрыПодключения, Количество, ВыходныеПараметры);
			if(true/*Результат*/)
			{
				//ТекущийПроцент = 0;
				//ПроцентИнкремент = 100 / Количество;
				//ВыходныеПараметры.Добавить(Новый Массив());
			}
			if(true/*Результат*/)
			{
				//Результат = ЗавершитьЗагрузку(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
				if(true/*Не Результат*/)
				{
					//ВыходныеПараметры.Очистить();
					//ВыходныеПараметры.Добавить(999);
					//ВыходныеПараметры.Добавить("");
					//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
					//Результат = Ложь;
				}
			}
			return null;
		}
		// Функция возвращает версию установленного драйвера
		//

		public object ПолучитьВерсиюДрайвера(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ВыходныеПараметры.Добавить(НСтр("ru='Установлен'"));
			//ВыходныеПараметры.Добавить(НСтр("ru='Не определена'"));
			return null;
		}
		// Функция осуществляет снятие отчёта без гашения.
		//

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//РезультатТеста = "";
			//МассивЗначений = Новый Массив;
			//МассивЗначений.Добавить(Параметры.Порт);
			//МассивЗначений.Добавить(Параметры.Скорость);
			//МассивЗначений.Добавить(Параметры.ТипСвязи);
			//Результат = ОбъектДрайвера.ТестУстройства(МассивЗначений, РезультатТеста);
			//ВыходныеПараметры.Добавить(?(Результат, 0, 999));
			//ВыходныеПараметры.Добавить(РезультатТеста);
			return null;
		}
	}
}
