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
	public partial class Встречи:ДокументМенеджер
	{
		
		public static ДокументыСсылка.Встречи НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld20037 [ДатаНачала]
					,_Fld20038 [ДатаОкончания]
					,_Fld20039RRef [Помещение]
					,_Fld20040RRef [Ответственный]
					,_Fld20041 [Комментарий]
					,_Fld20042 [КраткийСоставДокумента]
					,_Fld22992 [ВстречаСКандидатом]
					,_Fld22993RRef [ЗаявкаКандидата]
					From _Document19656(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.Встречи();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(3);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(8);
							Ссылка.ВстречаСКандидатом = ((byte[])Читалка.GetValue(9))[0]==1;
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
		
		public static ДокументыСсылка.Встречи НайтиПоНомеру(string Номер)
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
					,_Fld20037 [ДатаНачала]
					,_Fld20038 [ДатаОкончания]
					,_Fld20039RRef [Помещение]
					,_Fld20040RRef [Ответственный]
					,_Fld20041 [Комментарий]
					,_Fld20042 [КраткийСоставДокумента]
					,_Fld22992 [ВстречаСКандидатом]
					,_Fld22993RRef [ЗаявкаКандидата]
					From _Document19656(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.Встречи();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(3);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(8);
							Ссылка.ВстречаСКандидатом = ((byte[])Читалка.GetValue(9))[0]==1;
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
		
		public static ДокументыВыборка.Встречи Выбрать()
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
					,_Fld20037 [ДатаНачала]
					,_Fld20038 [ДатаОкончания]
					,_Fld20039RRef [Помещение]
					,_Fld20040RRef [Ответственный]
					,_Fld20041 [Комментарий]
					,_Fld20042 [КраткийСоставДокумента]
					,_Fld22992 [ВстречаСКандидатом]
					,_Fld22993RRef [ЗаявкаКандидата]
					From _Document19656(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.Встречи();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.Встречи();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(3);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(8);
							Ссылка.ВстречаСКандидатом = ((byte[])Читалка.GetValue(9))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.Встречи ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld20037 [ДатаНачала]
					,_Fld20038 [ДатаОкончания]
					,_Fld20039RRef [Помещение]
					,_Fld20040RRef [Ответственный]
					,_Fld20041 [Комментарий]
					,_Fld20042 [КраткийСоставДокумента]
					,_Fld22992 [ВстречаСКандидатом]
					,_Fld22993RRef [ЗаявкаКандидата]
					From _Document19656(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.Встречи();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.Встречи();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(3);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(8);
							Ссылка.ВстречаСКандидатом = ((byte[])Читалка.GetValue(9))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.Встречи ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld20037 [ДатаНачала]
					,_Fld20038 [ДатаОкончания]
					,_Fld20039RRef [Помещение]
					,_Fld20040RRef [Ответственный]
					,_Fld20041 [Комментарий]
					,_Fld20042 [КраткийСоставДокумента]
					,_Fld22992 [ВстречаСКандидатом]
					,_Fld22993RRef [ЗаявкаКандидата]
					From _Document19656(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.Встречи();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.Встречи();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(3);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(8);
							Ссылка.ВстречаСКандидатом = ((byte[])Читалка.GetValue(9))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.Встречи СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld20037 [ДатаНачала]
					,_Fld20038 [ДатаОкончания]
					,_Fld20039RRef [Помещение]
					,_Fld20040RRef [Ответственный]
					,_Fld20041 [Комментарий]
					,_Fld20042 [КраткийСоставДокумента]
					,_Fld22992 [ВстречаСКандидатом]
					,_Fld22993RRef [ЗаявкаКандидата]
					From _Document19656(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.Встречи();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.Встречи();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(3);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(8);
							Ссылка.ВстречаСКандидатом = ((byte[])Читалка.GetValue(9))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.Встречи СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld20037 [ДатаНачала]
					,_Fld20038 [ДатаОкончания]
					,_Fld20039RRef [Помещение]
					,_Fld20040RRef [Ответственный]
					,_Fld20041 [Комментарий]
					,_Fld20042 [КраткийСоставДокумента]
					,_Fld22992 [ВстречаСКандидатом]
					,_Fld22993RRef [ЗаявкаКандидата]
					From _Document19656(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.Встречи();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.Встречи();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаНачала = Читалка.GetDateTime(3);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(8);
							Ссылка.ВстречаСКандидатом = ((byte[])Читалка.GetValue(9))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.Встречи СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.Встречи();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.КраткийСоставДокумента = "";
			return Объект;
		}
	}
}