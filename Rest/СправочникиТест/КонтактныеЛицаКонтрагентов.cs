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
	public class КонтактныеЛицаКонтрагентов:V82.Rest.СправочникиТест.СправочникТест
	{
		public static КонтактныеЛицаКонтрагентовЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/КонтактныеЛицаКонтрагентов/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			КонтактныеЛицаКонтрагентовЗапрос КонтактныеЛицаКонтрагентовЗапрос = null;
			try
			{
				КонтактныеЛицаКонтрагентовЗапрос = Клиент.Get(new КонтактныеЛицаКонтрагентовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return КонтактныеЛицаКонтрагентовЗапрос;
		}
		public static КонтактныеЛицаКонтрагентовЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Справочники/КонтактныеЛицаКонтрагентов/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			КонтактныеЛицаКонтрагентовЗапрос КонтактныеЛицаКонтрагентовЗапрос = null;
			try
			{
				КонтактныеЛицаКонтрагентовЗапрос = Клиент.Get(new КонтактныеЛицаКонтрагентовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return КонтактныеЛицаКонтрагентовЗапрос;
		}
		public static КонтактныеЛицаКонтрагентовЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/КонтактныеЛицаКонтрагентов/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			КонтактныеЛицаКонтрагентовЗапрос КонтактныеЛицаКонтрагентовЗапрос = null;
			try
			{
				КонтактныеЛицаКонтрагентовЗапрос = Клиент.Get(new КонтактныеЛицаКонтрагентовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return КонтактныеЛицаКонтрагентовЗапрос;
		}
		public static void ЗаписатьНовый(КонтактныеЛицаКонтрагентовЗапрос КонтактныеЛицаКонтрагентовЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/КонтактныеЛицаКонтрагентов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КонтактныеЛицаКонтрагентовОтвет = Клиент.Post(КонтактныеЛицаКонтрагентовЗапрос);
		}
		public static void Записать(КонтактныеЛицаКонтрагентовЗапрос КонтактныеЛицаКонтрагентовЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/КонтактныеЛицаКонтрагентов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КонтактныеЛицаКонтрагентовОтвет = Клиент.Put(КонтактныеЛицаКонтрагентовЗапрос);
		}
		public static void Удалить(КонтактныеЛицаКонтрагентовЗапрос КонтактныеЛицаКонтрагентовЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/КонтактныеЛицаКонтрагентов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КонтактныеЛицаКонтрагентовОтвет = Клиент.Delete(КонтактныеЛицаКонтрагентовЗапрос);
		}
	}
}