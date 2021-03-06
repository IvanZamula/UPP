﻿
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиТест
{
	public partial class УчетныеЗаписиДокументооборота: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника УчетныеЗаписиДокументооборота. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.УчетныеЗаписиДокументооборота.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,5);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,150);//"Наименование " + НомерЭлемента;

				Объект.ИмяПользователяPOP3 = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ПарольPOP3 = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.СерверPOP3 = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ПортPOP3 = ГенераторСлучайныхЧисел.Следующий(99999);
				Объект.ИмяПользователяSMTP = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ПарольSMTP = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.СерверSMTP = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ПортSMTP = ГенераторСлучайныхЧисел.Следующий(99999);
				Объект.ТребуетсяSMTPАутентификация = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.АдресЭлектроннойПочты = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.НалоговыйОрган = V82.Справочники/*Менеджер*/.НалоговыеОрганы.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.НалоговыеОрганы();
				Объект.СерверДокументооборота = V82.Справочники/*Менеджер*/.СерверыДокументооборота.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.СерверыДокументооборота();
				Объект.СертификатРуководителя = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,40);
				Объект.СертификатГлавногоБухгалтера = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,40);
				Объект.СертификатДляШифрования = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,40);
				Объект.УдалитьАвтоматическоеОпределениеНабораПодписей = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИспользуютсяСъемныеКлючевыеНосители = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.УдалитьНестандартныеТаймауты = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.УдалитьТаймаутНалоговогоОргана = ГенераторСлучайныхЧисел.Следующий(99);
				Объект.УдалитьТаймаутНалогоплательщика = ГенераторСлучайныхЧисел.Следующий(99);
				Объект.УдалитьИспользуетсяОбособленнымиПодразделениями = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОбменНапрямую = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОбменНапрямуюСФСГС = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.НеФормироватьПодтвержденияАвтоматически = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РежимАвтонастройки = (V82.Перечисления/*Ссылка*/.РежимыАвтонастройкиУчетнойЗаписиДокументооборота)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.РежимыАвтонастройкиУчетнойЗаписиДокументооборота));
				Объект.ИспользоватьСервисОнлайнПроверкиОтчетов = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ПредназначенаДляДокументооборотаСФНС = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ПредназначенаДляДокументооборотаСПФР = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ПредназначенаДляДокументооборотаСФСГС = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИдентификаторСпецоператора = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3);
				Объект.ИдентификаторАбонента = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,43);
				Объект.ИдентификаторСистемыОтправителяПФР = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,40);
				Объект.ИдентификаторСистемыОтправителяФСГС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,40);
				Объект.ЯвляетсяУчетнойЗаписьюУполномоченногоПредставителя = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИННУполномоченногоПредставителя = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,12);
				Объект.КППУполномоченногоПредставителя = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);
				Объект.ПолноеНаименованиеУполномоченногоПредставителя = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.СтатусУчетнойЗаписи = (V82.Перечисления/*Ссылка*/.СтатусыУчетнойЗаписиДокументооборота)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СтатусыУчетнойЗаписиДокументооборота));
				Объект.СпецоператорСвязи = (V82.Перечисления/*Ссылка*/.СпецоператорыСвязи)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СпецоператорыСвязи));

				Объект.Записать();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void Удалить1000()
		{
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.УчетныеЗаписиДокументооборота.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника УчетныеЗаписиДокументооборота. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.УчетныеЗаписиДокументооборота.Выбрать())
				{
					НомерЭлемента++;
					Ссылка.СериализацияProtoBuf(Поток);
					Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
					Console.CursorLeft = 0;
				}
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void СериализацияJson1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияJson 1000 элементов справочника УчетныеЗаписиДокументооборота. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.УчетныеЗаписиДокументооборота.Выбрать())
			{
				НомерЭлемента++;
				Ссылка.СериализацияJson();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}