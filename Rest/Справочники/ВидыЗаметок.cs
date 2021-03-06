﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyZametok
	[Маршрут("Справочники/ВидыЗаметок","")]
	public class ВидыЗаметокЗапрос: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыЗаметок/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыЗаметок/ПоСсылке","{Ссылка}")]
	public class ВидыЗаметокНайтиПоСсылке: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыЗаметок/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыЗаметок/ПоКоду","{Код}")]
	public class ВидыЗаметокНайтиПоКоду: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыЗаметок/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыЗаметок/ПоНаименованию","{Наименование}")]
	public class ВидыЗаметокНайтиПоНаименованию: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЗаметокВыбратьПоСсылке: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЗаметокВыбратьПоКоду: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public decimal ___Мин {get; set;}
		public decimal ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЗаметок/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЗаметокВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЗаметок/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыЗаметокСтраницаПоСсылке: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЗаметок/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыЗаметокСтраницаПоКоду: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЗаметок/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыЗаметокСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыЗаметок,IReturn<ВидыЗаметокСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыЗаметокОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВидыЗаметокСервис : Service
	{
		
		public object Get(ВидыЗаметокЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗаметокНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ВидыЗаметок.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВидыЗаметокОтвет() { Ответ = "ВидыЗаметок c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыЗаметокНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = Запрос.Код;
			var Ссылка = V82.Справочники.ВидыЗаметок.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыЗаметокОтвет() {Ответ = "ВидыЗаметок c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыЗаметокНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗаметокВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВидыЗаметок.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВидыЗаметокВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗаметокВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗаметокСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗаметокСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗаметокСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыЗаметокЗапрос Запрос)
		{
			return new ВидыЗаметокОтвет {Ответ = "ВидыЗаметок, "};
		}

		public object Post(ВидыЗаметокЗапрос ЗапросВидыЗаметок)
		{
			var Ссылка = (СправочникиСсылка.ВидыЗаметок)ЗапросВидыЗаметок;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}