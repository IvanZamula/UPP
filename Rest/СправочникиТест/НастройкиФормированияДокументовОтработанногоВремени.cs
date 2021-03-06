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
	public class НастройкиФормированияДокументовОтработанногоВремени:V82.Rest.СправочникиТест.СправочникТест
	{
		public static НастройкиФормированияДокументовОтработанногоВремениЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/НастройкиФормированияДокументовОтработанногоВремени/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			НастройкиФормированияДокументовОтработанногоВремениЗапрос НастройкиФормированияДокументовОтработанногоВремениЗапрос = null;
			try
			{
				НастройкиФормированияДокументовОтработанногоВремениЗапрос = Клиент.Get(new НастройкиФормированияДокументовОтработанногоВремениЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return НастройкиФормированияДокументовОтработанногоВремениЗапрос;
		}
		public static НастройкиФормированияДокументовОтработанногоВремениЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/НастройкиФормированияДокументовОтработанногоВремени/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			НастройкиФормированияДокументовОтработанногоВремениЗапрос НастройкиФормированияДокументовОтработанногоВремениЗапрос = null;
			try
			{
				НастройкиФормированияДокументовОтработанногоВремениЗапрос = Клиент.Get(new НастройкиФормированияДокументовОтработанногоВремениЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return НастройкиФормированияДокументовОтработанногоВремениЗапрос;
		}
		public static void ЗаписатьНовый(НастройкиФормированияДокументовОтработанногоВремениЗапрос НастройкиФормированияДокументовОтработанногоВремениЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/НастройкиФормированияДокументовОтработанногоВремени?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var НастройкиФормированияДокументовОтработанногоВремениОтвет = Клиент.Post(НастройкиФормированияДокументовОтработанногоВремениЗапрос);
		}
		public static void Записать(НастройкиФормированияДокументовОтработанногоВремениЗапрос НастройкиФормированияДокументовОтработанногоВремениЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/НастройкиФормированияДокументовОтработанногоВремени?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var НастройкиФормированияДокументовОтработанногоВремениОтвет = Клиент.Put(НастройкиФормированияДокументовОтработанногоВремениЗапрос);
		}
		public static void Удалить(НастройкиФормированияДокументовОтработанногоВремениЗапрос НастройкиФормированияДокументовОтработанногоВремениЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/НастройкиФормированияДокументовОтработанногоВремени?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var НастройкиФормированияДокументовОтработанногоВремениОтвет = Клиент.Delete(НастройкиФормированияДокументовОтработанногоВремениЗапрос);
		}
	}
}