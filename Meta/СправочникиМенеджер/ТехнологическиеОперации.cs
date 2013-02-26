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
	public partial class ТехнологическиеОперации:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ТехнологическиеОперации НайтиПоКоду(string Код)
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
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
		
		public static СправочникиВыборка.ТехнологическиеОперации Выбрать()
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТехнологическиеОперации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТехнологическиеОперации ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТехнологическиеОперации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТехнологическиеОперации ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТехнологическиеОперации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТехнологическиеОперации ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТехнологическиеОперации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТехнологическиеОперации СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТехнологическиеОперации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТехнологическиеОперации СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТехнологическиеОперации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТехнологическиеОперации СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld3906RRef [ОсновнаяСтатьяЗатратНаПроизводство]
					,_Fld3907RRef [СпособОтраженияЗарплатыВБухучете]
					,_Fld3908RRef [ОсновнойСпособРаспределенияЗатратНаВыпуск]
					,_Fld3909RRef [ОсновнаяНоменклатурнаяГруппа]
					,_Fld3910 [Расценка]
					,_Fld3911RRef [БазоваяЕдиницаИзмерения]
					,_Fld3912RRef [Валюта]
					,_Fld3913 [НормаВремени]
					,_Fld3914 [Коэффициент]
					From _Reference264(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТехнологическиеОперации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТехнологическиеОперации();
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
							Ссылка.ОсновнаяСтатьяЗатратНаПроизводство = V82.СправочникиСсылка.СтатьиЗатрат.ВзятьИзКэша((byte[])Читалка.GetValue(6));
							Ссылка.СпособОтраженияЗарплатыВБухучете = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.ОсновнойСпособРаспределенияЗатратНаВыпуск = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ОсновнаяНоменклатурнаяГруппа = V82.СправочникиСсылка.НоменклатурныеГруппы.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.Расценка = Читалка.GetDecimal(10);
							Ссылка.БазоваяЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(12));
							Ссылка.НормаВремени = Читалка.GetDecimal(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ТехнологическиеОперации СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ТехнологическиеОперации();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ОсновнаяСтатьяЗатратНаПроизводство = new V82.СправочникиСсылка.СтатьиЗатрат();
			Объект.СпособОтраженияЗарплатыВБухучете = new V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
			Объект.ОсновнойСпособРаспределенияЗатратНаВыпуск = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
			Объект.ОсновнаяНоменклатурнаяГруппа = new V82.СправочникиСсылка.НоменклатурныеГруппы();
			Объект.БазоваяЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
			Объект.Валюта = new V82.СправочникиСсылка.Валюты();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.ТехнологическиеОперации СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.ТехнологическиеОперации();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.ОсновнаяСтатьяЗатратНаПроизводство = new V82.СправочникиСсылка.СтатьиЗатрат();
			Объект.СпособОтраженияЗарплатыВБухучете = new V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
			Объект.ОсновнойСпособРаспределенияЗатратНаВыпуск = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
			Объект.ОсновнаяНоменклатурнаяГруппа = new V82.СправочникиСсылка.НоменклатурныеГруппы();
			Объект.БазоваяЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
			Объект.Валюта = new V82.СправочникиСсылка.Валюты();
			return Объект;
		}
	}
}