﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//KorrektirovkaKachestvaTovarov
	[Маршрут("Документы/КорректировкаКачестваТоваров","")]
	public class КорректировкаКачестваТоваровЗапрос: V82.ДокументыСсылка.КорректировкаКачестваТоваров,IReturn<КорректировкаКачестваТоваровЗапрос>
	{
	}
	[Маршрут("Документы/КорректировкаКачестваТоваров/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/КорректировкаКачестваТоваров/ПоСсылке","{Ссылка}")]
	public class КорректировкаКачестваТоваровНайтиПоСсылке: V82.ДокументыСсылка.КорректировкаКачестваТоваров,IReturn<КорректировкаКачестваТоваровНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/КорректировкаКачестваТоваров/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/КорректировкаКачестваТоваров/ПоНомеру","{Номер}")]
	public class КорректировкаКачестваТоваровНайтиПоНомеру: V82.ДокументыСсылка.КорректировкаКачестваТоваров,IReturn<КорректировкаКачестваТоваровНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/КорректировкаКачестваТоваров/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/КорректировкаКачестваТоваров/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/КорректировкаКачестваТоваров/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КорректировкаКачестваТоваровВыбратьПоСсылке: V82.ДокументыСсылка.КорректировкаКачестваТоваров,IReturn<КорректировкаКачестваТоваровВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/КорректировкаКачестваТоваров/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/КорректировкаКачестваТоваров/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/КорректировкаКачестваТоваров/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class КорректировкаКачестваТоваровВыбратьПоНомеру: V82.ДокументыСсылка.КорректировкаКачестваТоваров,IReturn<КорректировкаКачестваТоваровВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/КорректировкаКачестваТоваров/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КорректировкаКачестваТоваровСтраницаПоСсылке: V82.ДокументыСсылка.КорректировкаКачестваТоваров,IReturn<КорректировкаКачестваТоваровСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/КорректировкаКачестваТоваров/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class КорректировкаКачестваТоваровСтраницаПоНомеру: V82.ДокументыСсылка.КорректировкаКачестваТоваров,IReturn<КорректировкаКачестваТоваровСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КорректировкаКачестваТоваровОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КорректировкаКачестваТоваровСервис : Service
	{
		
		public object Get(КорректировкаКачестваТоваровЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КорректировкаКачестваТоваровНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.КорректировкаКачестваТоваров.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КорректировкаКачестваТоваровОтвет() { Ответ = "КорректировкаКачестваТоваров c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КорректировкаКачестваТоваровНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.КорректировкаКачестваТоваров.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new КорректировкаКачестваТоваровОтвет() {Ответ = "КорректировкаКачестваТоваров c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КорректировкаКачестваТоваровВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.КорректировкаКачестваТоваров.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КорректировкаКачестваТоваровВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(КорректировкаКачестваТоваровСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КорректировкаКачестваТоваровСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(КорректировкаКачестваТоваровЗапрос Запрос)
		{
			return new КорректировкаКачестваТоваровОтвет {Ответ = "КорректировкаКачестваТоваров, "};
		}

		public object Post(КорректировкаКачестваТоваровЗапрос ЗапросКорректировкаКачестваТоваров)
		{
			var Ссылка = (ДокументыСсылка.КорректировкаКачестваТоваров)ЗапросКорректировкаКачестваТоваров;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}