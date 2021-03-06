﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//SvedeniyaOTrudovomStazheIZarabotkeSZV4
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4","")]
	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4Запрос: V82.ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4,IReturn<СведенияОТрудовомСтажеИЗаработкеСЗВ4Запрос>
	{
	}
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ПоСсылке","{Ссылка}")]
	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4НайтиПоСсылке: V82.ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4,IReturn<СведенияОТрудовомСтажеИЗаработкеСЗВ4НайтиПоСсылке>
	{
	}
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ПоНомеру","{Номер}")]
	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4НайтиПоНомеру: V82.ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4,IReturn<СведенияОТрудовомСтажеИЗаработкеСЗВ4НайтиПоНомеру>
	{
	}
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4ВыбратьПоСсылке: V82.ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4,IReturn<СведенияОТрудовомСтажеИЗаработкеСЗВ4ВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4ВыбратьПоНомеру: V82.ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4,IReturn<СведенияОТрудовомСтажеИЗаработкеСЗВ4ВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4СтраницаПоСсылке: V82.ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4,IReturn<СведенияОТрудовомСтажеИЗаработкеСЗВ4СтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/СведенияОТрудовомСтажеИЗаработкеСЗВ4/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4СтраницаПоНомеру: V82.ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4,IReturn<СведенияОТрудовомСтажеИЗаработкеСЗВ4СтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СведенияОТрудовомСтажеИЗаработкеСЗВ4Ответ
	{
		public string Ответ {get;set;}
	}

	public partial class СведенияОТрудовомСтажеИЗаработкеСЗВ4Сервис : Service
	{
		
		public object Get(СведенияОТрудовомСтажеИЗаработкеСЗВ4Запрос Запрос)
		{
			return null;
		}
		
		public object Get(СведенияОТрудовомСтажеИЗаработкеСЗВ4НайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.СведенияОТрудовомСтажеИЗаработкеСЗВ4.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СведенияОТрудовомСтажеИЗаработкеСЗВ4Ответ() { Ответ = "СведенияОТрудовомСтажеИЗаработкеСЗВ4 c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СведенияОТрудовомСтажеИЗаработкеСЗВ4НайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.СведенияОТрудовомСтажеИЗаработкеСЗВ4.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new СведенияОТрудовомСтажеИЗаработкеСЗВ4Ответ() {Ответ = "СведенияОТрудовомСтажеИЗаработкеСЗВ4 c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СведенияОТрудовомСтажеИЗаработкеСЗВ4ВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.СведенияОТрудовомСтажеИЗаработкеСЗВ4.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СведенияОТрудовомСтажеИЗаработкеСЗВ4ВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(СведенияОТрудовомСтажеИЗаработкеСЗВ4СтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СведенияОТрудовомСтажеИЗаработкеСЗВ4СтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(СведенияОТрудовомСтажеИЗаработкеСЗВ4Запрос Запрос)
		{
			return new СведенияОТрудовомСтажеИЗаработкеСЗВ4Ответ {Ответ = "СведенияОТрудовомСтажеИЗаработкеСЗВ4, "};
		}

		public object Post(СведенияОТрудовомСтажеИЗаработкеСЗВ4Запрос ЗапросСведенияОТрудовомСтажеИЗаработкеСЗВ4)
		{
			var Ссылка = (ДокументыСсылка.СведенияОТрудовомСтажеИЗаработкеСЗВ4)ЗапросСведенияОТрудовомСтажеИЗаработкеСЗВ4;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}