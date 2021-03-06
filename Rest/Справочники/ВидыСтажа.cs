﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyStazha
	[Маршрут("Справочники/ВидыСтажа","")]
	public class ВидыСтажаЗапрос: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыСтажа/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыСтажа/ПоСсылке","{Ссылка}")]
	public class ВидыСтажаНайтиПоСсылке: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыСтажа/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыСтажа/ПоКоду","{Код}")]
	public class ВидыСтажаНайтиПоКоду: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыСтажа/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыСтажа/ПоНаименованию","{Наименование}")]
	public class ВидыСтажаНайтиПоНаименованию: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыСтажаВыбратьПоСсылке: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыСтажаВыбратьПоКоду: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыСтажа/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыСтажаВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыСтажа/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыСтажаСтраницаПоСсылке: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыСтажа/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыСтажаСтраницаПоКоду: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыСтажа/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыСтажаСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыСтажа,IReturn<ВидыСтажаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыСтажаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВидыСтажаСервис : Service
	{
		
		public object Get(ВидыСтажаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСтажаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ВидыСтажа.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВидыСтажаОтвет() { Ответ = "ВидыСтажа c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыСтажаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыСтажа.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыСтажаОтвет() {Ответ = "ВидыСтажа c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыСтажаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСтажаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВидыСтажа.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВидыСтажаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСтажаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСтажаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСтажаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСтажаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыСтажаЗапрос Запрос)
		{
			return new ВидыСтажаОтвет {Ответ = "ВидыСтажа, "};
		}

		public object Post(ВидыСтажаЗапрос ЗапросВидыСтажа)
		{
			var Ссылка = (СправочникиСсылка.ВидыСтажа)ЗапросВидыСтажа;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}