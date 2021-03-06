﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ObrabotkiObsluzhivaniyaTO
	[Маршрут("Справочники/ОбработкиОбслуживанияТО","")]
	public class ОбработкиОбслуживанияТОЗапрос: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОЗапрос>
	{
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ПоСсылке","{Ссылка}")]
	public class ОбработкиОбслуживанияТОНайтиПоСсылке: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ПоКоду","{Код}")]
	public class ОбработкиОбслуживанияТОНайтиПоКоду: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ПоНаименованию","{Наименование}")]
	public class ОбработкиОбслуживанияТОНайтиПоНаименованию: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбработкиОбслуживанияТОВыбратьПоСсылке: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбработкиОбслуживанияТОВыбратьПоКоду: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбработкиОбслуживанияТОВыбратьПоНаименованию: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОбработкиОбслуживанияТОСтраницаПоСсылке: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОбработкиОбслуживанияТОСтраницаПоКоду: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОбработкиОбслуживанияТО/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОбработкиОбслуживанияТОСтраницаПоНаименованию: V82.СправочникиСсылка.ОбработкиОбслуживанияТО,IReturn<ОбработкиОбслуживанияТОСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОбработкиОбслуживанияТООтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОбработкиОбслуживанияТОСервис : Service
	{
		
		public object Get(ОбработкиОбслуживанияТОЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОбработкиОбслуживанияТОНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ОбработкиОбслуживанияТО.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОбработкиОбслуживанияТООтвет() { Ответ = "ОбработкиОбслуживанияТО c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОбработкиОбслуживанияТОНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОбработкиОбслуживанияТО.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОбработкиОбслуживанияТООтвет() {Ответ = "ОбработкиОбслуживанияТО c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОбработкиОбслуживанияТОНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОбработкиОбслуживанияТОВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ОбработкиОбслуживанияТО.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОбработкиОбслуживанияТОВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОбработкиОбслуживанияТОВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОбработкиОбслуживанияТОСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОбработкиОбслуживанияТОСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОбработкиОбслуживанияТОСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОбработкиОбслуживанияТОЗапрос Запрос)
		{
			return new ОбработкиОбслуживанияТООтвет {Ответ = "ОбработкиОбслуживанияТО, "};
		}

		public object Post(ОбработкиОбслуживанияТОЗапрос ЗапросОбработкиОбслуживанияТО)
		{
			var Ссылка = (СправочникиСсылка.ОбработкиОбслуживанияТО)ЗапросОбработкиОбслуживанияТО;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}