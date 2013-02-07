using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудованиеАтолТерминалыСбораДанных
	{
		////////// ОБЩИЕ КОМАНДЫ ВСЕХ ОБРАБОТЧИКОВ //////////////
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
			//Порт            = Неопределено;
			//Скорость        = Неопределено;
			//IPПорт          = Неопределено;
			//Четность        = Неопределено;
			//БитыДанных      = Неопределено;
			//СтопБиты        = Неопределено;
			//ТаблицаВыгрузки = Неопределено;
			//ТаблицаЗагрузки = Неопределено;
			//Разделитель     = Неопределено;
			//ФорматВыгрузки  = Неопределено;
			//ФорматЗагрузки  = Неопределено;
			//Модель          = Неопределено;
			//Наименование    = Неопределено;
			//Параметры.Свойство("Порт"           , Порт);
			//Параметры.Свойство("Скорость"       , Скорость);
			//Параметры.Свойство("IPПорт"         , IPПорт);
			//Параметры.Свойство("Четность"       , Четность);
			//Параметры.Свойство("БитыДанных"     , БитыДанных);
			//Параметры.Свойство("СтопБиты"       , СтопБиты);
			//Параметры.Свойство("ТаблицаВыгрузки", ТаблицаВыгрузки);
			//Параметры.Свойство("ТаблицаЗагрузки", ТаблицаЗагрузки);
			//Параметры.Свойство("Разделитель"    , Разделитель);
			//Параметры.Свойство("ФорматВыгрузки" , ФорматВыгрузки);
			//Параметры.Свойство("ФорматЗагрузки" , ФорматЗагрузки);
			//Параметры.Свойство("Модель"         , Модель);
			//Параметры.Свойство("Наименование"   , Наименование);
			if(true/*Порт            = Неопределено
	 Или Скорость        = Неопределено
	 Или IPПорт          = Неопределено
	 Или Четность        = Неопределено
	 Или БитыДанных      = Неопределено
	 Или СтопБиты        = Неопределено
	 Или ТаблицаВыгрузки = Неопределено
	 Или ТаблицаЗагрузки = Неопределено
	 Или Разделитель     = Неопределено
	 Или ФорматВыгрузки  = Неопределено
	 Или ФорматЗагрузки  = Неопределено
	 Или Модель          = Неопределено
	 Или Наименование    = Неопределено*/)
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
				//ОбъектДрайвера.ДобавитьУстройство();
				if(true/*ОбъектДрайвера.Результат = 0*/)
				{
					//ПараметрыПодключения.ИДУстройства = ОбъектДрайвера.НомерТекущегоУстройства;
					//ОбъектДрайвера.НаименованиеТекущегоУстройства = Параметры.Наименование;
					//ОбъектДрайвера.Модель = Число(Параметры.Модель);
					//ОбъектДрайвера.НомерПорта     = Параметры.Порт;
					//ОбъектДрайвера.СкоростьОбмена = Параметры.Скорость;
					//ОбъектДрайвера.ПортIP         = Параметры.IPПорт;
					//ОбъектДрайвера.Четность       = Параметры.Четность;
					//ОбъектДрайвера.БитыДанных     = Параметры.БитыДанных;
					//ОбъектДрайвера.СтопБиты       = Параметры.СтопБиты;
					//ОбъектДрайвера.Разделитель    = Параметры.Разделитель;
					//ОбъектДрайвера.УстройствоВключено = 1;
					if(true/*ОбъектДрайвера.Результат <> 0*/)
					{
						//ВыходныеПараметры.Очистить();
						//ВыходныеПараметры.Добавить(999);
						//ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);
						//ОбъектДрайвера.УдалитьУстройство();
						//ПараметрыПодключения.ИДУстройства = Неопределено;
						//Результат = Ложь;
					}
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
			//Результат = Истина;
			//ВыходныеПараметры = Новый Массив();
			//ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;
			//ОбъектДрайвера.УстройствоВключено = 0;
			//ОбъектДрайвера.УдалитьУстройство();
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
		/////////////////////////////////////
		// Функции-исполнители команд
		///////// СПЕЦИФИЧНЫЕ ПО ТИПУ ОБОРУДОВАНИЯ КОМАНДЫ ////////////////
		// Функция осуществляет выгрузку строки в терминал сбора данных.
		//

		public object ВыгрузитьТаблицу(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ТаблицаВыгрузки, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//Результат = НачатьВыгрузку(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
			if(true/*Результат*/)
			{
				if(true/*Результат*/)
				{
					//Результат = ЗавершитьВыгрузку(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
				}
			}
			return null;
		}
		// ВыгрузитьСтроку()
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
				//ВыходныеПараметры.Добавить(Новый Массив());
			}
			if(true/*Результат*/)
			{
				//Результат = ЗавершитьЗагрузку(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
				if(true/*Не Результат*/)
				{
					//ВыходныеПараметры.Очистить();
					//ВыходныеПараметры.Добавить(999);
					//ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);
					//Результат = Ложь;
				}
			}
			return null;
		}
		// ЗагрузитьСтроку()
		///////////// ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ОБРАБОТЧИКА ////////////////
		// Функция осуществляет подготовку процедуры выгрузки данных в терминал.
		//

		public object НачатьВыгрузку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;
			//ОбъектДрайвера.НомерФормы = Параметры.ТаблицаВыгрузки;
			//ОбъектДрайвера.НачатьДобавление();
			if(true/*ОбъектДрайвера.Результат <> 0*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);
				//Результат = Ложь;
			}
			return null;
		}
		// НачатьВыгрузку()
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
			//Результат         = Истина;
			if(true/*Параметры.ФорматВыгрузки.Количество() > 0*/)
			{
			}
			//ОбъектДрайвера.УстановитьЗапись();
			if(true/*ОбъектДрайвера.Результат <> 0*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);
				//Результат = Ложь;
			}
			return null;
		}
		// ВыгрузитьСтроку()
		// Функция осуществляет завершение процедуры выгрузки данных в терминал сбора данных.
		//

		public object ЗавершитьВыгрузку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ОбъектДрайвера.ПоказатьПрогресс = Истина;
			//ОбъектДрайвера.РежимДобавления  = 1;
			//ОбъектДрайвера.ЗакончитьДобавление();
			if(true/*ОбъектДрайвера.Результат <> 0*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);
				//Результат = Ложь;
			}
			return null;
		}
		// ЗавершитьВыгрузку()
		// Функция осуществляет подготовку процедуры загрузки данных из терминала сбора данных.
		//

		public object НачатьЗагрузку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, Количество, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;
			//ОбъектДрайвера.НомерФормы       = Параметры.ТаблицаЗагрузки;
			//ОбъектДрайвера.ПоказатьПрогресс = Истина;
			//ОбъектДрайвера.НачалоОтчета();
			if(true/*ОбъектДрайвера.Результат = 0*/)
			{
				//Количество = ОбъектДрайвера.КоличествоЗаписейОтчета;
			}
			return null;
		}
		// НачатьЗагрузку()
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
			//ОбъектДрайвера.ПолучитьЗапись();
			if(true/*ОбъектДрайвера.Результат = 0*/)
			{
				if(true/*Параметры.ФорматЗагрузки.Количество() > 0*/)
				{
				}
			}
			return null;
		}
		// ЗагрузитьСтроку()
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
			//ОбъектДрайвера.КонецОтчета();
			if(true/*ОбъектДрайвера.Результат <> 0*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);
				//Результат = Ложь;
			}
			return null;
		}
		// ЗавершитьЗагрузку()
		// Функция осуществляет тестирование устройства.
		//

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//Результат = ПодключитьУстройство(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
			//ВыходныеПараметры.Добавить(?(Результат, 0, 999));
			//ВыходныеПараметры.Добавить(?(Результат, "", НСтр("ru='Ошибка при подключении устройства'")));
			//ОтключитьУстройство(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
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
	}
}
