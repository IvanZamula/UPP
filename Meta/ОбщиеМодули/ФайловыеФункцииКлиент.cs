﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ФайловыеФункцииКлиент
	{
		// Сохраняет подпись на диск

		public void СохранитьПодпись(/*АдресПодписи*/)
		{
			if(true/*НЕ ПодключитьРасширениеРаботыСФайлами()*/)
			{
			}
			//ДиалогОткрытияФайла = Новый ДиалогВыбораФайла(РежимДиалогаВыбораФайла.Сохранение);
			//Фильтр = НСтр("ru = 'Все файлы(*.p7s)|*.p7s'");
			//ДиалогОткрытияФайла.Фильтр = Фильтр;
			//ДиалогОткрытияФайла.МножественныйВыбор = Ложь;
			//ДиалогОткрытияФайла.Заголовок = НСтр("ru = 'Выберите файл для сохранения подписи'");
			if(true/*ДиалогОткрытияФайла.Выбрать()*/)
			{
				//ПолныйПутьПодписи = ДиалогОткрытияФайла.ПолноеИмяФайла;
				//Файл = Новый Файл(ПолныйПутьПодписи);
				//ПередаваемыеФайлы = Новый Массив;
				//Описание = Новый ОписаниеПередаваемогоФайла(ПолныйПутьПодписи, АдресПодписи);
				//ПередаваемыеФайлы.Добавить(Описание);
				//ПутьКФайлу = Файл.Путь;
				if(true/*Прав(ПутьКФайлу,1) <> "\"*/)
				{
					//ПутьКФайлу = ПутьКФайлу + "\";
				}
				/*// Сохраним Файл из БД на диск
*/
				//ПолучитьФайлы(ПередаваемыеФайлы,, ПутьКФайлу, Ложь);
				/*Текст = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(
			НСтр("ru = 'Подпись сохранена в файл ""%1""'"),
			ДиалогОткрытияФайла.ПолноеИмяФайла);*/
				//Состояние(Текст);
			}
		}
		// Проинициализировать параметр сеанса ПутьКРабочемуКаталогуПользователя, проверив корректность пути, и откорректировав если нужно
		//

		public void ПроинициализироватьПутьКРабочемуКаталогу(/**/)
		{
			//ИмяКаталога = ФайловыеФункцииКлиентПовтИсп.ПолучитьРабочийКаталогПользователя();
			/*// уже проинициализировано
*/
			if(true/*ИмяКаталога <> Неопределено И НЕ ПустаяСтрока(ИмяКаталога) И ПроверкаДоступаКРабочемуКаталогуВыполнена = Истина*/)
			{
			}
			if(true/*ИмяКаталога = Неопределено*/)
			{
				//ИмяКаталога = ПолучитьПутьККаталогуДанныхПользователя();
				if(true/*Не ПустаяСтрока(ИмяКаталога)*/)
				{
					//СохранитьПутьККаталогуВНастройках(ИмяКаталога);
				}
			}
			/*// Создать каталог для файлов
*/
			//ПроверкаДоступаКРабочемуКаталогуВыполнена = Истина;
		}
		// Функция получает путь к каталогу вида "C:\Documents and Settings\ИМЯ ПОЛЬЗОВАТЕЛЯ\Application Data\1C\ФайлыА8\"
		//

		public object ПолучитьПутьККаталогуДанныхПользователя(/**/)
		{
			//ИмяКаталога = "";
			if(true/*НЕ СтандартныеПодсистемыКлиентПовтИсп.ПараметрыРаботыКлиента().ЭтоБазоваяВерсияКонфигурации*/)
			{
				//Оболочка = Новый COMОбъект("WScript.Shell");
				//Путь = Оболочка.ExpandEnvironmentStrings("%APPDATA%");
				//Путь = Путь + "\1C\Файлы\";
				//Путь = Путь + ФайловыеФункцииКлиентПовтИсп.ПолучитьПерсональныеНастройкиРаботыСФайлами().ИмяКонфигурации + "\";
				//ИмяПользователя = ФайловыеФункцииКлиентПовтИсп.ПолучитьПерсональныеНастройкиРаботыСФайлами().ТекущийПользователь;
				//ИмяКаталога = Путь + ИмяПользователя;
				//ИмяКаталога = СтрЗаменить(ИмяКаталога, "<", " ");
				//ИмяКаталога = СтрЗаменить(ИмяКаталога, ">", " ");
				//ИмяКаталога = СокрЛП(ИмяКаталога);
				//ИмяКаталога = ИмяКаталога + "\";
			}
			//РасширениеПодключено = ПодключитьРасширениеРаботыСФайлами();
			if(true/*РасширениеПодключено*/)
			{
				//Режим = РежимДиалогаВыбораФайла.ВыборКаталога;
				//ДиалогОткрытияФайла = Новый ДиалогВыбораФайла(Режим);
				//ДиалогОткрытияФайла.ПолноеИмяФайла = "";
				//ДиалогОткрытияФайла.Каталог = "";
				//ДиалогОткрытияФайла.МножественныйВыбор = Ложь;
				//ДиалогОткрытияФайла.Заголовок = НСтр("ru = 'Выберите путь к локальному кэшу файлов'");
				if(true/*ДиалогОткрытияФайла.Выбрать()*/)
				{
					//ИмяКаталога = ДиалогОткрытияФайла.Каталог;
					//ИмяКаталога = ИмяКаталога + "\";
				}
			}
			return null;
		}
		// Сохраняет путь к рабочему каталогу в настройках
		//

		public void СохранитьПутьККаталогуВНастройках(/*ИмяКаталога*/)
		{
			//ОбщегоНазначения.ХранилищеОбщихНастроекСохранитьИОбновитьПовторноИспользуемыеЗначения("ЛокальныйКэшФайлов", "ПутьКЛокальномуКэшуФайлов", ИмяКаталога);
		}
		// открыть Windows проводник, выбрав в нем указанный файл
		//

		public object ОткрытьПроводникСФайлом(/*Знач ПолноеИмяФайла*/)
		{
			//ФайлНаДиске = Новый Файл(ПолноеИмяФайла);
			if(true/*ФайлНаДиске.Существует()*/)
			{
				if(true/*Лев(ПолноеИмяФайла, 0) <> """"*/)
				{
					//ПолноеИмяФайла = """" + ПолноеИмяФайла + """";
				}
				//ЗапуститьПриложение("explorer.exe /select, " + ПолноеИмяФайла);
			}
			return null;
		}
		// Добавляет ЭЦП из файла (файлов)
		//
		// Параметры
		//  ФайлСсылка  - любая ссылка - объект, в табличную часть которого будет занесена информация о ЭЦП
		//  МассивФайловПодписей  - Массив структур - массив структур (ПутьКФайлу, Комментарий)
		//  УникальныйИдентификатор - УникальныйИдентификатор - уникальный идентификатор формы
		//  ВладелецФайла  - любая ссылка - значение реквизита ВладелецФайла у ФайлСсылка

		public object СформироватьПодписиДляЗанесениюВБазу(/*ФайлСсылка, МассивФайловПодписей, УникальныйИдентификатор = Неопределено*/)
		{
			//Отказ = Ложь;
			//МенеджерКриптографии = ЭлектроннаяЦифроваяПодписьКлиент.ПолучитьМенеджерКриптографии(Отказ);
			if(true/*Отказ*/)
			{
			}
			//ДатаПодписи = ТекущаяДата();
			//МассивДанныхДляЗанесенияВБазу = Новый Массив;
			return null;
		}
		// Рекурсивно обойти каталоги и посчитать количество файлов и их суммарный размер
		//

		public void ОбходФайловРазмер(/*Путь, МассивФайлов, РазмерСуммарный, КоличествоСуммарное*/)
		{
		}
	}
}
