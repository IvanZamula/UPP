﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SerijjnyeNomera
	[Маршрут("Справочники/СерийныеНомера","")]
	public class СерийныеНомераЗапрос: V82.СправочникиСсылка.СерийныеНомера,IReturn<СерийныеНомераЗапрос>
	{
	}
	[Маршрут("Справочники/СерийныеНомера/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СерийныеНомера/ПоСсылке","{Ссылка}")]
	public class СерийныеНомераНайтиПоСсылке: V82.СправочникиСсылка.СерийныеНомера,IReturn<СерийныеНомераНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СерийныеНомера/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СерийныеНомера/ПоКоду","{Код}")]
	public class СерийныеНомераНайтиПоКоду: V82.СправочникиСсылка.СерийныеНомера,IReturn<СерийныеНомераНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СерийныеНомера/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СерийныеНомера/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СерийныеНомера/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СерийныеНомераВыбратьПоСсылке: V82.СправочникиСсылка.СерийныеНомера,IReturn<СерийныеНомераВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СерийныеНомера/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СерийныеНомера/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СерийныеНомера/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СерийныеНомераВыбратьПоКоду: V82.СправочникиСсылка.СерийныеНомера,IReturn<СерийныеНомераВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СерийныеНомера/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СерийныеНомераСтраницаПоСсылке: V82.СправочникиСсылка.СерийныеНомера,IReturn<СерийныеНомераСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СерийныеНомера/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СерийныеНомераСтраницаПоКоду: V82.СправочникиСсылка.СерийныеНомера,IReturn<СерийныеНомераСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СерийныеНомераОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СерийныеНомераСервис : Service
	{
		
		public object Get(СерийныеНомераЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СерийныеНомераНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.СерийныеНомера.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СерийныеНомераОтвет() { Ответ = "СерийныеНомера c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СерийныеНомераНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СерийныеНомера.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СерийныеНомераОтвет() {Ответ = "СерийныеНомера c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СерийныеНомераВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СерийныеНомера.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СерийныеНомераВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СерийныеНомераСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СерийныеНомераСтраницаПоКоду Запрос)
		{
			return null;
		}

		public object Any(СерийныеНомераЗапрос Запрос)
		{
			return new СерийныеНомераОтвет {Ответ = "СерийныеНомера, "};
		}

		public object Post(СерийныеНомераЗапрос ЗапросСерийныеНомера)
		{
			var Ссылка = (СправочникиСсылка.СерийныеНомера)ЗапросСерийныеНомера;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}