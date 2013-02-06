﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/Rezervy")]
	[Route("/Catalogs/Rezervy/{Code}")]
	public class RezervyRequest/*РезервыЗапрос*/: V82.СправочникиСсылка.Резервы,IReturn<RezervyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RezervyResponse//РезервыОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Rezervys")]
	[Route("/Catalogs/Rezervys/{Codes}")]
	public class RezervysRequest/*РезервыЗапрос*/: IReturn<List<RezervyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RezervysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RezervysResponse//РезервыОтвет
	{
		public string Result {get;set;}
	}


	public class RezervyService /*РезервыСервис*/ : Service
	{
		public object Any(RezervyRequest request)
		{
			return new RezervyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RezervyRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.Резервы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new RezervyResponse() {Result = "Резервы c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(RezervysRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.Резервы>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.Резервы.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}
