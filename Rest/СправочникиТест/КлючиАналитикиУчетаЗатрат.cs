﻿
using System;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceClient.Web;
using V82.Справочники;

namespace V82.Rest.СправочникиТест
{
	public class КлючиАналитикиУчетаЗатрат:V82.Rest.СправочникиТест.СправочникТест
	{
		public static КлючиАналитикиУчетаЗатратЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/КлючиАналитикиУчетаЗатрат/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			КлючиАналитикиУчетаЗатратЗапрос КлючиАналитикиУчетаЗатратЗапрос = null;
			try
			{
				КлючиАналитикиУчетаЗатратЗапрос = Клиент.Get(new КлючиАналитикиУчетаЗатратЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return КлючиАналитикиУчетаЗатратЗапрос;
		}
		public static КлючиАналитикиУчетаЗатратЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/КлючиАналитикиУчетаЗатрат/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			КлючиАналитикиУчетаЗатратЗапрос КлючиАналитикиУчетаЗатратЗапрос = null;
			try
			{
				КлючиАналитикиУчетаЗатратЗапрос = Клиент.Get(new КлючиАналитикиУчетаЗатратЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return КлючиАналитикиУчетаЗатратЗапрос;
		}
		public static void ЗаписатьНовый(КлючиАналитикиУчетаЗатратЗапрос КлючиАналитикиУчетаЗатратЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/КлючиАналитикиУчетаЗатрат?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КлючиАналитикиУчетаЗатратОтвет = Клиент.Post(КлючиАналитикиУчетаЗатратЗапрос);
		}
		public static void Записать(КлючиАналитикиУчетаЗатратЗапрос КлючиАналитикиУчетаЗатратЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/КлючиАналитикиУчетаЗатрат?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КлючиАналитикиУчетаЗатратОтвет = Клиент.Put(КлючиАналитикиУчетаЗатратЗапрос);
		}
		public static void Удалить(КлючиАналитикиУчетаЗатратЗапрос КлючиАналитикиУчетаЗатратЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/КлючиАналитикиУчетаЗатрат?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КлючиАналитикиУчетаЗатратОтвет = Клиент.Delete(КлючиАналитикиУчетаЗатратЗапрос);
		}
	}
}