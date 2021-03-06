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
	///(Упр)
	///</summary>
	public partial class АктуализацияБюджетов:ДокументМенеджер
	{
		
		public static ДокументыСсылка.АктуализацияБюджетов НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld2761RRef [Сценарий]
					,_Fld2762 [ДатаНачала]
					,_Fld2763 [ДатаКонца]
					,_Fld2764RRef [Ответственный]
					,_Fld2765 [Комментарий]
					,_Fld2766RRef [Состояние]
					,_Fld2767 [АктуализироватьБюджеты]
					,_Fld2768 [ПеренестиТранзакции]
					From _Document208(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.АктуализацияБюджетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(4);
							Ссылка.ДатаКонца = Читалка.GetDateTime(5);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.АктуализироватьБюджеты = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ПеренестиТранзакции = ((byte[])Читалка.GetValue(10))[0]==1;
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
		
		public static ДокументыСсылка.АктуализацияБюджетов НайтиПоНомеру(string Номер)
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
					,_Fld2761RRef [Сценарий]
					,_Fld2762 [ДатаНачала]
					,_Fld2763 [ДатаКонца]
					,_Fld2764RRef [Ответственный]
					,_Fld2765 [Комментарий]
					,_Fld2766RRef [Состояние]
					,_Fld2767 [АктуализироватьБюджеты]
					,_Fld2768 [ПеренестиТранзакции]
					From _Document208(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.АктуализацияБюджетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(4);
							Ссылка.ДатаКонца = Читалка.GetDateTime(5);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.АктуализироватьБюджеты = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ПеренестиТранзакции = ((byte[])Читалка.GetValue(10))[0]==1;
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
		
		public static ДокументыВыборка.АктуализацияБюджетов Выбрать()
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
					,_Fld2761RRef [Сценарий]
					,_Fld2762 [ДатаНачала]
					,_Fld2763 [ДатаКонца]
					,_Fld2764RRef [Ответственный]
					,_Fld2765 [Комментарий]
					,_Fld2766RRef [Состояние]
					,_Fld2767 [АктуализироватьБюджеты]
					,_Fld2768 [ПеренестиТранзакции]
					From _Document208(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.АктуализацияБюджетов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.АктуализацияБюджетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(4);
							Ссылка.ДатаКонца = Читалка.GetDateTime(5);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.АктуализироватьБюджеты = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ПеренестиТранзакции = ((byte[])Читалка.GetValue(10))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.АктуализацияБюджетов ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2761RRef [Сценарий]
					,_Fld2762 [ДатаНачала]
					,_Fld2763 [ДатаКонца]
					,_Fld2764RRef [Ответственный]
					,_Fld2765 [Комментарий]
					,_Fld2766RRef [Состояние]
					,_Fld2767 [АктуализироватьБюджеты]
					,_Fld2768 [ПеренестиТранзакции]
					From _Document208(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.АктуализацияБюджетов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.АктуализацияБюджетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(4);
							Ссылка.ДатаКонца = Читалка.GetDateTime(5);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.АктуализироватьБюджеты = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ПеренестиТранзакции = ((byte[])Читалка.GetValue(10))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.АктуализацияБюджетов ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld2761RRef [Сценарий]
					,_Fld2762 [ДатаНачала]
					,_Fld2763 [ДатаКонца]
					,_Fld2764RRef [Ответственный]
					,_Fld2765 [Комментарий]
					,_Fld2766RRef [Состояние]
					,_Fld2767 [АктуализироватьБюджеты]
					,_Fld2768 [ПеренестиТранзакции]
					From _Document208(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.АктуализацияБюджетов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.АктуализацияБюджетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(4);
							Ссылка.ДатаКонца = Читалка.GetDateTime(5);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.АктуализироватьБюджеты = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ПеренестиТранзакции = ((byte[])Читалка.GetValue(10))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.АктуализацияБюджетов СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2761RRef [Сценарий]
					,_Fld2762 [ДатаНачала]
					,_Fld2763 [ДатаКонца]
					,_Fld2764RRef [Ответственный]
					,_Fld2765 [Комментарий]
					,_Fld2766RRef [Состояние]
					,_Fld2767 [АктуализироватьБюджеты]
					,_Fld2768 [ПеренестиТранзакции]
					From _Document208(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.АктуализацияБюджетов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.АктуализацияБюджетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(4);
							Ссылка.ДатаКонца = Читалка.GetDateTime(5);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.АктуализироватьБюджеты = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ПеренестиТранзакции = ((byte[])Читалка.GetValue(10))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.АктуализацияБюджетов СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld2761RRef [Сценарий]
					,_Fld2762 [ДатаНачала]
					,_Fld2763 [ДатаКонца]
					,_Fld2764RRef [Ответственный]
					,_Fld2765 [Комментарий]
					,_Fld2766RRef [Состояние]
					,_Fld2767 [АктуализироватьБюджеты]
					,_Fld2768 [ПеренестиТранзакции]
					From _Document208(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.АктуализацияБюджетов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.АктуализацияБюджетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(4);
							Ссылка.ДатаКонца = Читалка.GetDateTime(5);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.АктуализироватьБюджеты = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ПеренестиТранзакции = ((byte[])Читалка.GetValue(10))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.АктуализацияБюджетов СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.АктуализацияБюджетов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.Состояние = V82.Перечисления/*Ссылка*/.СостоянияОбъектов.ПустаяСсылка;
			return Объект;
		}
	}
}