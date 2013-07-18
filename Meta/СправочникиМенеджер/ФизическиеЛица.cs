﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ФизическиеЛица:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ФизическиеЛица НайтиПоСсылке(Guid _Ссылка)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static СправочникиСсылка.ФизическиеЛица НайтиПоКоду(string Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static СправочникиВыборка.ФизическиеЛица Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)  Where _Folder = 0x01 ";
					var Выборка = new V82.СправочникиВыборка.ФизическиеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ФизическиеЛица ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ФизическиеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ФизическиеЛица ВыбратьПоКоду(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ФизическиеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ФизическиеЛица ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ФизическиеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ФизическиеЛица СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ФизическиеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ФизическиеЛица СтраницаПоКоду(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ФизическиеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ФизическиеЛица СтраницаПоНаименованию(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2197 [ДатаРождения]
					,_Fld2198 [ИНН]
					,_Fld2199 [КодИМНС]
					,_Fld2200 [Комментарий]
					,_Fld2201 [СтраховойНомерПФР]
					,_Fld2202RRef [Пол]
					,_Fld2203 [МестоРождения]
					,_Fld2204RRef [ОсновноеИзображение]
					,_Fld2205 [МестоРожденияКодПоОКАТО]
					,_Fld21297RRef [ГруппаДоступаФизическогоЛица]
					,_Fld26650RRef [ЛьготаПриНачисленииПособий]
					,_Fld26651 [ИмеетНаучныеТруды]
					,_Fld26652 [ИмеетИзобретения]
					From _Reference190(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ФизическиеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ФизическиеЛица();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.ФизическиеЛица.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаРождения = Читалка.GetDateTime(8);
								Ссылка.ИНН = Читалка.GetString(9);
								Ссылка.КодИМНС = Читалка.GetString(10);
								Ссылка.Комментарий = Читалка.GetString(11);
								Ссылка.СтраховойНомерПФР = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
								Ссылка.МестоРождения = Читалка.GetString(14);
								Ссылка.ОсновноеИзображение = V82.СправочникиСсылка.ХранилищеДополнительнойИнформации.ВзятьИзКэша((byte[])Читалка.GetValue(15));
								Ссылка.МестоРожденияКодПоОКАТО = Читалка.GetString(16);
								Ссылка.ГруппаДоступаФизическогоЛица = V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц.ВзятьИзКэша((byte[])Читалка.GetValue(17));
								Ссылка.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
								Ссылка.ИмеетНаучныеТруды = ((byte[])Читалка.GetValue(19))[0]==1;
								Ссылка.ИмеетИзобретения = ((byte[])Читалка.GetValue(20))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ФизическиеЛица СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ФизическиеЛица();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ИНН = "";
			Объект.КодИМНС = "";
			Объект.Комментарий = "";
			Объект.СтраховойНомерПФР = "";
			Объект.МестоРождения = "";
			Объект.МестоРожденияКодПоОКАТО = "";
			Объект.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка;
			Объект.ОсновноеИзображение = new V82.СправочникиСсылка.ХранилищеДополнительнойИнформации();
			Объект.ГруппаДоступаФизическогоЛица = new V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц();
			Объект.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка;
			return Объект;
		}
		
		public static V82.СправочникиОбъект.ФизическиеЛица СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.ФизическиеЛица();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.ИНН = "";
			Объект.КодИМНС = "";
			Объект.Комментарий = "";
			Объект.СтраховойНомерПФР = "";
			Объект.МестоРождения = "";
			Объект.МестоРожденияКодПоОКАТО = "";
			Объект.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка;
			Объект.ОсновноеИзображение = new V82.СправочникиСсылка.ХранилищеДополнительнойИнформации();
			Объект.ГруппаДоступаФизическогоЛица = new V82.СправочникиСсылка.ГруппыДоступаФизическихЛиц();
			Объект.ЛьготаПриНачисленииПособий = V82.Перечисления/*Ссылка*/.ВидыЛьготПриНачисленииБольничных.ПустаяСсылка;
			return Объект;
		}
	}
}