﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class СведенияОВзносахИСтраховомСтажеСПВ1:ДокументМенеджер
	{
		
		public static ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1 НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld25346RRef [Организация]
					,_Fld25347 [Комментарий]
					,_Fld25348RRef [Ответственный]
					,_Fld25349 [КраткийСоставДокумента]
					,_Fld25350 [ПринятоВПФР]
					,_Fld25351 [НомерПачки]
					,_Fld25352RRef [КатегорияЗастрахованныхЛиц]
					,_Fld25353 [ОтчетныйПериод]
					,_Fld25354RRef [ТипСведенийСЗВ]
					,_Fld25355RRef [Руководитель]
					,_Fld25356RRef [ДолжностьРуководителя]
					,_Fld25357RRef [ФорматФайла]
					From _Document23170(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(6);
							Ссылка.ПринятоВПФР = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.НомерПачки = Читалка.GetString(8);
							Ссылка.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтчетныйПериод = Читалка.GetDateTime(10);
							Ссылка.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
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
		
		public static ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1 НайтиПоНомеру(string Номер)
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
					,_Fld25346RRef [Организация]
					,_Fld25347 [Комментарий]
					,_Fld25348RRef [Ответственный]
					,_Fld25349 [КраткийСоставДокумента]
					,_Fld25350 [ПринятоВПФР]
					,_Fld25351 [НомерПачки]
					,_Fld25352RRef [КатегорияЗастрахованныхЛиц]
					,_Fld25353 [ОтчетныйПериод]
					,_Fld25354RRef [ТипСведенийСЗВ]
					,_Fld25355RRef [Руководитель]
					,_Fld25356RRef [ДолжностьРуководителя]
					,_Fld25357RRef [ФорматФайла]
					From _Document23170(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(6);
							Ссылка.ПринятоВПФР = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.НомерПачки = Читалка.GetString(8);
							Ссылка.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтчетныйПериод = Читалка.GetDateTime(10);
							Ссылка.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
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
		
		public static ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1 Выбрать()
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
					,_Fld25346RRef [Организация]
					,_Fld25347 [Комментарий]
					,_Fld25348RRef [Ответственный]
					,_Fld25349 [КраткийСоставДокумента]
					,_Fld25350 [ПринятоВПФР]
					,_Fld25351 [НомерПачки]
					,_Fld25352RRef [КатегорияЗастрахованныхЛиц]
					,_Fld25353 [ОтчетныйПериод]
					,_Fld25354RRef [ТипСведенийСЗВ]
					,_Fld25355RRef [Руководитель]
					,_Fld25356RRef [ДолжностьРуководителя]
					,_Fld25357RRef [ФорматФайла]
					From _Document23170(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(6);
							Ссылка.ПринятоВПФР = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.НомерПачки = Читалка.GetString(8);
							Ссылка.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтчетныйПериод = Читалка.GetDateTime(10);
							Ссылка.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1 ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld25346RRef [Организация]
					,_Fld25347 [Комментарий]
					,_Fld25348RRef [Ответственный]
					,_Fld25349 [КраткийСоставДокумента]
					,_Fld25350 [ПринятоВПФР]
					,_Fld25351 [НомерПачки]
					,_Fld25352RRef [КатегорияЗастрахованныхЛиц]
					,_Fld25353 [ОтчетныйПериод]
					,_Fld25354RRef [ТипСведенийСЗВ]
					,_Fld25355RRef [Руководитель]
					,_Fld25356RRef [ДолжностьРуководителя]
					,_Fld25357RRef [ФорматФайла]
					From _Document23170(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(6);
							Ссылка.ПринятоВПФР = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.НомерПачки = Читалка.GetString(8);
							Ссылка.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтчетныйПериод = Читалка.GetDateTime(10);
							Ссылка.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1 ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld25346RRef [Организация]
					,_Fld25347 [Комментарий]
					,_Fld25348RRef [Ответственный]
					,_Fld25349 [КраткийСоставДокумента]
					,_Fld25350 [ПринятоВПФР]
					,_Fld25351 [НомерПачки]
					,_Fld25352RRef [КатегорияЗастрахованныхЛиц]
					,_Fld25353 [ОтчетныйПериод]
					,_Fld25354RRef [ТипСведенийСЗВ]
					,_Fld25355RRef [Руководитель]
					,_Fld25356RRef [ДолжностьРуководителя]
					,_Fld25357RRef [ФорматФайла]
					From _Document23170(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(6);
							Ссылка.ПринятоВПФР = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.НомерПачки = Читалка.GetString(8);
							Ссылка.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтчетныйПериод = Читалка.GetDateTime(10);
							Ссылка.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1 СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld25346RRef [Организация]
					,_Fld25347 [Комментарий]
					,_Fld25348RRef [Ответственный]
					,_Fld25349 [КраткийСоставДокумента]
					,_Fld25350 [ПринятоВПФР]
					,_Fld25351 [НомерПачки]
					,_Fld25352RRef [КатегорияЗастрахованныхЛиц]
					,_Fld25353 [ОтчетныйПериод]
					,_Fld25354RRef [ТипСведенийСЗВ]
					,_Fld25355RRef [Руководитель]
					,_Fld25356RRef [ДолжностьРуководителя]
					,_Fld25357RRef [ФорматФайла]
					From _Document23170(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(6);
							Ссылка.ПринятоВПФР = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.НомерПачки = Читалка.GetString(8);
							Ссылка.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтчетныйПериод = Читалка.GetDateTime(10);
							Ссылка.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1 СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld25346RRef [Организация]
					,_Fld25347 [Комментарий]
					,_Fld25348RRef [Ответственный]
					,_Fld25349 [КраткийСоставДокумента]
					,_Fld25350 [ПринятоВПФР]
					,_Fld25351 [НомерПачки]
					,_Fld25352RRef [КатегорияЗастрахованныхЛиц]
					,_Fld25353 [ОтчетныйПериод]
					,_Fld25354RRef [ТипСведенийСЗВ]
					,_Fld25355RRef [Руководитель]
					,_Fld25356RRef [ДолжностьРуководителя]
					,_Fld25357RRef [ФорматФайла]
					From _Document23170(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СведенияОВзносахИСтраховомСтажеСПВ1();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СведенияОВзносахИСтраховомСтажеСПВ1();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(6);
							Ссылка.ПринятоВПФР = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.НомерПачки = Читалка.GetString(8);
							Ссылка.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтчетныйПериод = Читалка.GetDateTime(10);
							Ссылка.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.СведенияОВзносахИСтраховомСтажеСПВ1 СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.СведенияОВзносахИСтраховомСтажеСПВ1();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.КраткийСоставДокумента = "";
			Объект.НомерПачки = "";
			Объект.КатегорияЗастрахованныхЛиц = V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР.ПустаяСсылка;
			Объект.ТипСведенийСЗВ = V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ.ПустаяСсылка;
			Объект.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка;
			return Объект;
		}
	}
}