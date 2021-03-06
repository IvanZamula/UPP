﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SpecifikaciiNomenklatury
	[Маршрут("Справочники/СпецификацииНоменклатуры","")]
	public class СпецификацииНоменклатурыЗапрос: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыЗапрос>
	{
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ПоСсылке","{Ссылка}")]
	public class СпецификацииНоменклатурыНайтиПоСсылке: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ПоКоду","{Код}")]
	public class СпецификацииНоменклатурыНайтиПоКоду: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ПоНаименованию","{Наименование}")]
	public class СпецификацииНоменклатурыНайтиПоНаименованию: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СпецификацииНоменклатурыВыбратьПоСсылке: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СпецификацииНоменклатурыВыбратьПоКоду: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СпецификацииНоменклатурыВыбратьПоНаименованию: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СпецификацииНоменклатурыСтраницаПоСсылке: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СпецификацииНоменклатурыСтраницаПоКоду: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СпецификацииНоменклатурыСтраницаПоНаименованию: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпецификацииНоменклатуры/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class СпецификацииНоменклатурыИерархияВыбратьПоСсылке: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпецификацииНоменклатуры/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class СпецификацииНоменклатурыИерархияСтраницаПоСсылке: V82.СправочникиСсылка.СпецификацииНоменклатуры,IReturn<СпецификацииНоменклатурыИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СпецификацииНоменклатурыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СпецификацииНоменклатурыСервис : Service
	{
		
		public object Get(СпецификацииНоменклатурыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СпецификацииНоменклатурыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.СпецификацииНоменклатуры.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СпецификацииНоменклатурыОтвет() { Ответ = "СпецификацииНоменклатуры c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СпецификацииНоменклатурыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СпецификацииНоменклатуры.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СпецификацииНоменклатурыОтвет() {Ответ = "СпецификацииНоменклатуры c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СпецификацииНоменклатурыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СпецификацииНоменклатурыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СпецификацииНоменклатуры.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СпецификацииНоменклатурыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СпецификацииНоменклатурыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СпецификацииНоменклатурыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СпецификацииНоменклатурыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СпецификацииНоменклатурыСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СпецификацииНоменклатурыИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СпецификацииНоменклатуры.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СпецификацииНоменклатурыИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(СпецификацииНоменклатурыЗапрос Запрос)
		{
			return new СпецификацииНоменклатурыОтвет {Ответ = "СпецификацииНоменклатуры, "};
		}

		public object Post(СпецификацииНоменклатурыЗапрос ЗапросСпецификацииНоменклатуры)
		{
			var Ссылка = (СправочникиСсылка.СпецификацииНоменклатуры)ЗапросСпецификацииНоменклатуры;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}