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
	public class СтатьиОтчетаОПрибыляхИУбытках:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СтатьиОтчетаОПрибыляхИУбыткахЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиОтчетаОПрибыляхИУбытках/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиОтчетаОПрибыляхИУбыткахЗапрос СтатьиОтчетаОПрибыляхИУбыткахЗапрос = null;
			try
			{
				СтатьиОтчетаОПрибыляхИУбыткахЗапрос = Клиент.Get(new СтатьиОтчетаОПрибыляхИУбыткахЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиОтчетаОПрибыляхИУбыткахЗапрос;
		}
		public static СтатьиОтчетаОПрибыляхИУбыткахЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиОтчетаОПрибыляхИУбытках/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиОтчетаОПрибыляхИУбыткахЗапрос СтатьиОтчетаОПрибыляхИУбыткахЗапрос = null;
			try
			{
				СтатьиОтчетаОПрибыляхИУбыткахЗапрос = Клиент.Get(new СтатьиОтчетаОПрибыляхИУбыткахЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиОтчетаОПрибыляхИУбыткахЗапрос;
		}
		public static СтатьиОтчетаОПрибыляхИУбыткахЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиОтчетаОПрибыляхИУбытках/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиОтчетаОПрибыляхИУбыткахЗапрос СтатьиОтчетаОПрибыляхИУбыткахЗапрос = null;
			try
			{
				СтатьиОтчетаОПрибыляхИУбыткахЗапрос = Клиент.Get(new СтатьиОтчетаОПрибыляхИУбыткахЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиОтчетаОПрибыляхИУбыткахЗапрос;
		}
		public static void ЗаписатьНовый(СтатьиОтчетаОПрибыляхИУбыткахЗапрос СтатьиОтчетаОПрибыляхИУбыткахЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиОтчетаОПрибыляхИУбытках?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиОтчетаОПрибыляхИУбыткахОтвет = Клиент.Post(СтатьиОтчетаОПрибыляхИУбыткахЗапрос);
		}
		public static void Записать(СтатьиОтчетаОПрибыляхИУбыткахЗапрос СтатьиОтчетаОПрибыляхИУбыткахЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиОтчетаОПрибыляхИУбытках?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиОтчетаОПрибыляхИУбыткахОтвет = Клиент.Put(СтатьиОтчетаОПрибыляхИУбыткахЗапрос);
		}
		public static void Удалить(СтатьиОтчетаОПрибыляхИУбыткахЗапрос СтатьиОтчетаОПрибыляхИУбыткахЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиОтчетаОПрибыляхИУбытках?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиОтчетаОПрибыляхИУбыткахОтвет = Клиент.Delete(СтатьиОтчетаОПрибыляхИУбыткахЗапрос);
		}
	}
}