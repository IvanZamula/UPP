﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//InventarizaciyaRaschetovSkontragentami
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами","")]
	public class ИнвентаризацияРасчетовСконтрагентамиЗапрос: V82.ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами,IReturn<ИнвентаризацияРасчетовСконтрагентамиЗапрос>
	{
	}
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ПоСсылке","{Ссылка}")]
	public class ИнвентаризацияРасчетовСконтрагентамиНайтиПоСсылке: V82.ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами,IReturn<ИнвентаризацияРасчетовСконтрагентамиНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ПоНомеру","{Номер}")]
	public class ИнвентаризацияРасчетовСконтрагентамиНайтиПоНомеру: V82.ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами,IReturn<ИнвентаризацияРасчетовСконтрагентамиНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнвентаризацияРасчетовСконтрагентамиВыбратьПоСсылке: V82.ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами,IReturn<ИнвентаризацияРасчетовСконтрагентамиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнвентаризацияРасчетовСконтрагентамиВыбратьПоНомеру: V82.ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами,IReturn<ИнвентаризацияРасчетовСконтрагентамиВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИнвентаризацияРасчетовСконтрагентамиСтраницаПоСсылке: V82.ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами,IReturn<ИнвентаризацияРасчетовСконтрагентамиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ИнвентаризацияРасчетовСконтрагентами/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ИнвентаризацияРасчетовСконтрагентамиСтраницаПоНомеру: V82.ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами,IReturn<ИнвентаризацияРасчетовСконтрагентамиСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИнвентаризацияРасчетовСконтрагентамиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИнвентаризацияРасчетовСконтрагентамиСервис : Service
	{
		
		public object Get(ИнвентаризацияРасчетовСконтрагентамиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИнвентаризацияРасчетовСконтрагентамиНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ИнвентаризацияРасчетовСконтрагентами.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ИнвентаризацияРасчетовСконтрагентамиОтвет() { Ответ = "ИнвентаризацияРасчетовСконтрагентами c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИнвентаризацияРасчетовСконтрагентамиНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ИнвентаризацияРасчетовСконтрагентами.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ИнвентаризацияРасчетовСконтрагентамиОтвет() {Ответ = "ИнвентаризацияРасчетовСконтрагентами c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИнвентаризацияРасчетовСконтрагентамиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ИнвентаризацияРасчетовСконтрагентами.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИнвентаризацияРасчетовСконтрагентамиВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ИнвентаризацияРасчетовСконтрагентамиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИнвентаризацияРасчетовСконтрагентамиСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ИнвентаризацияРасчетовСконтрагентамиЗапрос Запрос)
		{
			return new ИнвентаризацияРасчетовСконтрагентамиОтвет {Ответ = "ИнвентаризацияРасчетовСконтрагентами, "};
		}

		public object Post(ИнвентаризацияРасчетовСконтрагентамиЗапрос ЗапросИнвентаризацияРасчетовСконтрагентами)
		{
			var Ссылка = (ДокументыСсылка.ИнвентаризацияРасчетовСконтрагентами)ЗапросИнвентаризацияРасчетовСконтрагентами;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}