﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PeredachaOS
	[Маршрут("Документы/ПередачаОС","")]
	public class ПередачаОСЗапрос: V82.ДокументыСсылка.ПередачаОС,IReturn<ПередачаОСЗапрос>
	{
	}
	[Маршрут("Документы/ПередачаОС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПередачаОС/ПоСсылке","{Ссылка}")]
	public class ПередачаОСНайтиПоСсылке: V82.ДокументыСсылка.ПередачаОС,IReturn<ПередачаОСНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПередачаОС/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПередачаОС/ПоНомеру","{Номер}")]
	public class ПередачаОСНайтиПоНомеру: V82.ДокументыСсылка.ПередачаОС,IReturn<ПередачаОСНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПередачаОС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПередачаОС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПередачаОС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПередачаОСВыбратьПоСсылке: V82.ДокументыСсылка.ПередачаОС,IReturn<ПередачаОСВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПередачаОС/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПередачаОС/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПередачаОС/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПередачаОСВыбратьПоНомеру: V82.ДокументыСсылка.ПередачаОС,IReturn<ПередачаОСВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПередачаОС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПередачаОССтраницаПоСсылке: V82.ДокументыСсылка.ПередачаОС,IReturn<ПередачаОССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПередачаОС/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПередачаОССтраницаПоНомеру: V82.ДокументыСсылка.ПередачаОС,IReturn<ПередачаОССтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПередачаОСОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПередачаОССервис : Service
	{
		
		public object Get(ПередачаОСЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПередачаОСНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПередачаОС.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПередачаОСОтвет() { Ответ = "ПередачаОС c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПередачаОСНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПередачаОС.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПередачаОСОтвет() {Ответ = "ПередачаОС c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПередачаОСВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПередачаОС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПередачаОСВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПередачаОССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПередачаОССтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПередачаОСЗапрос Запрос)
		{
			return new ПередачаОСОтвет {Ответ = "ПередачаОС, "};
		}

		public object Post(ПередачаОСЗапрос ЗапросПередачаОС)
		{
			var Ссылка = (ДокументыСсылка.ПередачаОС)ЗапросПередачаОС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}