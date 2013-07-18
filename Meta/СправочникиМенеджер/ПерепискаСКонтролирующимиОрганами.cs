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
	public partial class ПерепискаСКонтролирующимиОрганами:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ПерепискаСКонтролирующимиОрганами НайтиПоСсылке(Guid _Ссылка)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
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
		
		public static СправочникиСсылка.ПерепискаСКонтролирующимиОрганами НайтиПоКоду(string Код)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
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
		
		public static СправочникиВыборка.ПерепискаСКонтролирующимиОрганами Выбрать()
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.ПерепискаСКонтролирующимиОрганами();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ПерепискаСКонтролирующимиОрганами ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ПерепискаСКонтролирующимиОрганами();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ПерепискаСКонтролирующимиОрганами ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ПерепискаСКонтролирующимиОрганами();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ПерепискаСКонтролирующимиОрганами ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ПерепискаСКонтролирующимиОрганами();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ПерепискаСКонтролирующимиОрганами СтраницаПоСсылке(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ПерепискаСКонтролирующимиОрганами();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ПерепискаСКонтролирующимиОрганами СтраницаПоКоду(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ПерепискаСКонтролирующимиОрганами();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ПерепискаСКонтролирующимиОрганами СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23678RRef [Тип]
					,_Fld23679RRef [Статус]
					,_Fld23680RRef [Организация]
					,_Fld23681_TYPE [Отправитель_Тип],_Fld23681_RRRef [Отправитель],_Fld23681_RTRef [Отправитель_Вид]
					,_Fld23682_TYPE [Получатель_Тип],_Fld23682_RRRef [Получатель],_Fld23682_RTRef [Получатель_Вид]
					,_Fld23683 [Содержание]
					,_Fld23684 [ДатаСообщения]
					,_Fld23685 [ДатаОтправки]
					,_Fld23686 [Идентификатор]
					,_Fld23687 [ИдентификаторОснования]
					,_Fld23688 [Ретроконверсия]
					From _Reference23118(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ПерепискаСКонтролирующимиОрганами();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПерепискаСКонтролирующимиОрганами();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
								Ссылка.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.Содержание = Читалка.GetString(15);
								Ссылка.ДатаСообщения = Читалка.GetDateTime(16);
								Ссылка.ДатаОтправки = Читалка.GetDateTime(17);
								Ссылка.Идентификатор = Читалка.GetString(18);
								Ссылка.ИдентификаторОснования = Читалка.GetString(19);
								Ссылка.Ретроконверсия = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ПерепискаСКонтролирующимиОрганами СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ПерепискаСКонтролирующимиОрганами();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Содержание = "";
			Объект.Идентификатор = "";
			Объект.ИдентификаторОснования = "";
			Объект.Тип = V82.Перечисления/*Ссылка*/.ТипыПерепискиСКонтролирующимиОрганами.ПустаяСсылка;
			Объект.Статус = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка;
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			return Объект;
		}
	}
}