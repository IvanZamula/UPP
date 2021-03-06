﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЭлектронныеДокументы1СТакскомКлиентСлужебный
	{
		////////////////////////////////////////////////////////////////////////////////
		// ЭлектронныеДокументы1СТакскомКлиентЙ: механизм обмена электронными документами.
		//
		////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЙ ПРОГРАММНЫЙ ИНТЕРФЕЙС
		////////////////////////////////////////////////////////////////////////////////
		// Работа с извещением о получении
		// Только для внутреннего использования

		public object СформироватьПодписатьЭДИзвещениеОПолучении(/*МассивЭД*/)
		{
			//ВозвращаемоеЗначение = Ложь;
			//КолСформированных = 0;
			//КолУтвержденных   = 0;
			//КолПодписанных    = 0;
			//КолПодготовленных = 0;
			//ВызватьОповещение = Ложь;
			if(true/*ТипЗнч(МассивЭД) = Тип("Массив")*/)
			{
			}
			if(true/*ВызватьОповещение*/)
			{
				//Оповестить("ОбновитьСостояниеЭД");
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Авторизация на сервере Такском

		public object ПолучитьМаркерОЭДО(/*Соглашение, Соединение = Неопределено, ПарольКСертификату = Неопределено*/)
		{
			//Маркер = Неопределено;
			if(true/*НЕ ЗначениеЗаполнено(Соединение)*/)
			{
				//Соединение = ЭлектронныеДокументы1СТакскомСлужебный.ПолучитьСоединение();
			}
			//ПараметрыСоглашения = ОбщегоНазначения.ПолучитьЗначенияРеквизитов(Соглашение, "СертификатАбонента, Наименование");
			//СертификатАбонента  = ПараметрыСоглашения.СертификатАбонента;
			if(true/*ЗначениеЗаполнено(СертификатАбонента)*/)
			{
				/*ПараметрыСертификатаАбонента = ОбщегоНазначения.ПолучитьЗначенияРеквизитов(СертификатАбонента,
			"ЗапомнитьПарольКСертификату, ПарольПользователя, ФайлСертификата");*/
				if(true/*ПарольКСертификату = Неопределено*/)
				{
					if(true/*ПараметрыСертификатаАбонента.ЗапомнитьПарольКСертификату*/)
					{
						//ПарольКСертификату = ПараметрыСертификатаАбонента.ПарольПользователя;
					}
				}
				if(true/*ПарольКСертификату <> Неопределено*/)
				{
					//АдресРесурса = "CertificateLogin";
					//ИмяФайлаРезультата = ЭлектронныеДокументыСлужебный.ТекущееИмяВременногоФайла("txt");
					//СертификатПодписи = ЭлектронныеДокументыСлужебный.ТекущееИмяВременногоФайла("cer");
					//ДвоичныеДанныеСертификата = ПараметрыСертификатаАбонента.ФайлСертификата.Получить();
					//ДвоичныеДанныеСертификата.Записать(СертификатПодписи);
					//Заголовки = "";
					/*ЭлектронныеДокументы1СТакскомСлужебный.ДобавитьпараметрВЗаголовок(Заголовки, "Integrator-Id",
				"1C_22BFE9D5-E77D-424A-BC6D-D8A3496C05FE");*/
					//Маркер = РасшифроватьМаркер(ИмяФайлаРезультата, СертификатПодписи, ПарольКСертификату);
					//УдалитьФайлы(ИмяФайлаРезультата);
					//УдалитьФайлы(СертификатПодписи);
				}
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		////////////////////////////////////////////////////////////////////////////////
		// Авторизация на сервере Такском

		public object РасшифроватьМаркер(/*ИмяФайлаРезультата, СертификатПодписи, ПарольКСертификатуОператора*/)
		{
			if(true/*ЗначениеЗаполнено(ПарольКСертификатуОператора)*/)
			{
				//МенеджерКриптографии.ПарольДоступаКЗакрытомуКлючу = ПарольКСертификатуОператора;
			}
			//ФайлРасшифрованногоМаркера = ЭлектронныеДокументыСлужебный.ТекущееИмяВременногоФайла("txt");
			//РасшифрованныеДвоичныеДанные.Записать(ФайлРасшифрованногоМаркера);
			//ФайлРезультата = Новый ТекстовыйДокумент;
			//ФайлРезультата.Прочитать(ФайлРасшифрованногоМаркера, КодировкаТекста.UTF8);
			//УдалитьФайлы(ФайлРасшифрованногоМаркера);
			//Результат = ФайлРезультата.ПолучитьТекст();
			return null;
		}
	}
}
