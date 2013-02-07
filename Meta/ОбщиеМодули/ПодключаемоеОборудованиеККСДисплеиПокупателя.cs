using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудованиеККСДисплеиПокупателя
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
			//ВыходныеПараметры = Новый Массив();
			//ПараметрыПодключения.Вставить("ИДУстройства", Неопределено);
			/*// Проверка настроенных параметров
*/
			//Порт       = Неопределено;
			//Скорость   = Неопределено;
			//Четность   = Неопределено;
			//БитыДанных = Неопределено;
			//СтопБиты   = Неопределено;
			//Параметры.Свойство("Порт",         Порт);
			/*//Параметры.Свойство("Скорость",     Скорость);
*/
			/*//Параметры.Свойство("Четность",     Четность);
*/
			/*//Параметры.Свойство("БитыДанных",   БитыДанных);
*/
			/*//Параметры.Свойство("СтопБиты",     СтопБиты);         
*/
			if(true/*Порт              = Неопределено*/)
			{
				//ВыходныеПараметры.Добавить(999);
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
				//Результат = Ложь;
			}
			//МассивЗначений = Новый Массив;
			//МассивЗначений.Добавить(Параметры.Порт);
			//МассивЗначений.Добавить(Параметры.Скорость);
			//МассивЗначений.Добавить(Параметры.Четность);
			//МассивЗначений.Добавить(Параметры.БитыДанных);
			//МассивЗначений.Добавить(Параметры.СтопБиты);
			if(true/*Результат*/)
			{
				//Ответ = ОбъектДрайвера.Подключить(МассивЗначений, ПараметрыПодключения.ИДУстройства);
				if(true/*НЕ Ответ*/)
				{
					//Результат = Ложь;
					//ВыходныеПараметры.Очистить();
					//ВыходныеПараметры.Добавить(999);
					//ВыходныеПараметры.Добавить("");
					//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
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
			//ОбъектДрайвера.Отключить(ПараметрыПодключения.ИДУстройства);
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			//Результат = Истина;
			//ВыходныеПараметры = Новый Массив();
			/*// Вывод строк на дисплей
*/
			if(true/*Команда = "ВывестиСтрокуНаДисплейПокупателя" ИЛИ Команда = "DisplayText"*/)
			{
				//СтрокаТекста = ВходныеПараметры[0];
				//Результат = ВывестиСтрокуНаДисплейПокупателя(ОбъектДрайвера, Параметры, ПараметрыПодключения, СтрокаТекста, ВыходныеПараметры);
				/*// Очистка дисплея
*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция осуществляет вывод списка строк на дисплей покупателя.
		//

		public object ВывестиСтрокуНаДисплейПокупателя(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, СтрокаТекста, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//МассивСтрок = Новый Массив();
			//МассивСтрок.Добавить(ПостроитьПоле(СтрПолучитьСтроку(СтрокаТекста, 1), 20));
			//МассивСтрок.Добавить(ПостроитьПоле(СтрПолучитьСтроку(СтрокаТекста, 2), 20));
			//Ответ = ОбъектДрайвера.ВывестиСтрокуНаДисплейПокупателя(ПараметрыПодключения.ИДУстройства, МассивСтрок);
			if(true/*Не Ответ*/)
			{
				//Результат = Ложь;
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить("");
				//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
			}
			return null;
		}
		// Функция осуществляет очистку дисплея покупателя.
		//

		public object ОчиститьДисплейПокупателя(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//Ответ = ОбъектДрайвера.ОчиститьДисплейПокупателя(ПараметрыПодключения.ИДУстройства);
			if(true/*Не Ответ*/)
			{
				//Результат = Ложь;
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить("");
				//ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);
			}
			return null;
		}
		// Функция возвращает параметры вывода на дисплей покупателя)

		public object ПолучитьПараметрыВывода(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ВыходныеПараметры.Очистить();
			//ВыходныеПараметры.Добавить(20);
			//ВыходныеПараметры.Добавить(2);
			return null;
		}
		// Функция осуществляет тестирование устройства.
		//

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//РезультатТеста = "";
			//МассивЗначений = Новый Массив;
			//МассивЗначений.Добавить(Параметры.Порт);
			//МассивЗначений.Добавить(Параметры.Скорость);
			//МассивЗначений.Добавить(Параметры.Четность);
			//МассивЗначений.Добавить(Параметры.БитыДанных);
			//МассивЗначений.Добавить(Параметры.СтопБиты);
			//Результат = ОбъектДрайвера.ТестУстройства(МассивЗначений, РезультатТеста);
			//ВыходныеПараметры.Добавить(?(Результат, 0, 999));
			//ВыходныеПараметры.Добавить(РезультатТеста);
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
		// Обрезает передаваемую строку по длине поля. если поле слишком короткое - дополняет пробелами

		public object ПостроитьПоле(/*Текст, ДлинаПоля*/)
		{
			if(true/*СтрДлина(Текст) < ДлинаПоля*/)
			{
				//ТекстПолный = Текст;
				//КолвоПробелов = ДлинаПоля - СтрДлина(ТекстПолный);
			}
			return null;
		}
	}
}
