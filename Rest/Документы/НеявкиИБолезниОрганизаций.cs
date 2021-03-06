﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//NeyavkiIBolezniOrganizacijj
	[Маршрут("Документы/НеявкиИБолезниОрганизаций","")]
	public class НеявкиИБолезниОрганизацийЗапрос: V82.ДокументыСсылка.НеявкиИБолезниОрганизаций,IReturn<НеявкиИБолезниОрганизацийЗапрос>
	{
	}
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ПоСсылке","{Ссылка}")]
	public class НеявкиИБолезниОрганизацийНайтиПоСсылке: V82.ДокументыСсылка.НеявкиИБолезниОрганизаций,IReturn<НеявкиИБолезниОрганизацийНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ПоНомеру","{Номер}")]
	public class НеявкиИБолезниОрганизацийНайтиПоНомеру: V82.ДокументыСсылка.НеявкиИБолезниОрганизаций,IReturn<НеявкиИБолезниОрганизацийНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НеявкиИБолезниОрганизацийВыбратьПоСсылке: V82.ДокументыСсылка.НеявкиИБолезниОрганизаций,IReturn<НеявкиИБолезниОрганизацийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class НеявкиИБолезниОрганизацийВыбратьПоНомеру: V82.ДокументыСсылка.НеявкиИБолезниОрганизаций,IReturn<НеявкиИБолезниОрганизацийВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НеявкиИБолезниОрганизацийСтраницаПоСсылке: V82.ДокументыСсылка.НеявкиИБолезниОрганизаций,IReturn<НеявкиИБолезниОрганизацийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/НеявкиИБолезниОрганизаций/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class НеявкиИБолезниОрганизацийСтраницаПоНомеру: V82.ДокументыСсылка.НеявкиИБолезниОрганизаций,IReturn<НеявкиИБолезниОрганизацийСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НеявкиИБолезниОрганизацийОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НеявкиИБолезниОрганизацийСервис : Service
	{
		
		public object Get(НеявкиИБолезниОрганизацийЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НеявкиИБолезниОрганизацийНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.НеявкиИБолезниОрганизаций.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НеявкиИБолезниОрганизацийОтвет() { Ответ = "НеявкиИБолезниОрганизаций c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НеявкиИБолезниОрганизацийНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.НеявкиИБолезниОрганизаций.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new НеявкиИБолезниОрганизацийОтвет() {Ответ = "НеявкиИБолезниОрганизаций c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НеявкиИБолезниОрганизацийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.НеявкиИБолезниОрганизаций.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НеявкиИБолезниОрганизацийВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(НеявкиИБолезниОрганизацийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НеявкиИБолезниОрганизацийСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(НеявкиИБолезниОрганизацийЗапрос Запрос)
		{
			return new НеявкиИБолезниОрганизацийОтвет {Ответ = "НеявкиИБолезниОрганизаций, "};
		}

		public object Post(НеявкиИБолезниОрганизацийЗапрос ЗапросНеявкиИБолезниОрганизаций)
		{
			var Ссылка = (ДокументыСсылка.НеявкиИБолезниОрганизаций)ЗапросНеявкиИБолезниОрганизаций;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}