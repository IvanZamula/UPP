﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/KlassifikatorStranMira")]
	[Route("/Catalogs/KlassifikatorStranMira/{Code}")]
	public class KlassifikatorStranMiraRequest/*КлассификаторСтранМираЗапрос*/: V82.СправочникиСсылка.КлассификаторСтранМира,IReturn<KlassifikatorStranMiraRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlassifikatorStranMiraResponse//КлассификаторСтранМираОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlassifikatorStranMiras")]
	[Route("/Catalogs/KlassifikatorStranMiras/{Codes}")]
	public class KlassifikatorStranMirasRequest/*КлассификаторСтранМираЗапрос*/: IReturn<List<KlassifikatorStranMiraRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlassifikatorStranMirasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlassifikatorStranMirasResponse//КлассификаторСтранМираОтвет
	{
		public string Result {get;set;}
	}


	public class KlassifikatorStranMiraService /*КлассификаторСтранМираСервис*/ : Service
	{
		public object Any(KlassifikatorStranMiraRequest request)
		{
			return new KlassifikatorStranMiraResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlassifikatorStranMiraRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.КлассификаторСтранМира.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new KlassifikatorStranMiraResponse() {Result = "КлассификаторСтранМира c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(KlassifikatorStranMirasRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.КлассификаторСтранМира>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.КлассификаторСтранМира.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}
