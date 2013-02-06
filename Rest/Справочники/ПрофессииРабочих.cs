﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/ProfessiiRabochikh")]
	[Route("/Catalogs/ProfessiiRabochikh/{Code}")]
	public class ProfessiiRabochikhRequest/*ПрофессииРабочихЗапрос*/: V82.СправочникиСсылка.ПрофессииРабочих,IReturn<ProfessiiRabochikhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProfessiiRabochikhResponse//ПрофессииРабочихОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProfessiiRabochikhs")]
	[Route("/Catalogs/ProfessiiRabochikhs/{Codes}")]
	public class ProfessiiRabochikhsRequest/*ПрофессииРабочихЗапрос*/: IReturn<List<ProfessiiRabochikhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProfessiiRabochikhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProfessiiRabochikhsResponse//ПрофессииРабочихОтвет
	{
		public string Result {get;set;}
	}


	public class ProfessiiRabochikhService /*ПрофессииРабочихСервис*/ : Service
	{
		public object Any(ProfessiiRabochikhRequest request)
		{
			return new ProfessiiRabochikhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProfessiiRabochikhRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.ПрофессииРабочих.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ProfessiiRabochikhResponse() {Result = "ПрофессииРабочих c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(ProfessiiRabochikhsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ПрофессииРабочих>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.ПрофессииРабочих.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}
