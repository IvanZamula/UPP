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
	///Настройки формирования документов отработанного времени
	///</summary>
	public partial class НастройкиФормированияДокументовОтработанногоВремени:СправочникМенеджер
	{
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени Выбрать()
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
					,_Description [Наименование]
					,_Fld2871 [ГраницаОбработки]
					,_Fld2872RRef [ПериодДетализации]
					,_Fld2873RRef [Организация]
					,_Fld2874RRef [СпособВводаДанных]
					,_Fld2875RRef [ПодразделениеОрганизации]
					,_Fld2876 [ФормироватьДокументыАвтоматически]
					,_Fld2877 [РегламентноеЗадание]
					,_Fld2878 [НеОбрабатыватьВсеДокументы]
					,_Fld2879 [Комментарий]
					,_Fld2880 [Задержка]
					From _Reference159(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ГраницаОбработки = Читалка.GetDateTime(5);
							Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.РегламентноеЗадание = Читалка.GetString(11);
							Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Задержка = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Description [Наименование]
					,_Fld2871 [ГраницаОбработки]
					,_Fld2872RRef [ПериодДетализации]
					,_Fld2873RRef [Организация]
					,_Fld2874RRef [СпособВводаДанных]
					,_Fld2875RRef [ПодразделениеОрганизации]
					,_Fld2876 [ФормироватьДокументыАвтоматически]
					,_Fld2877 [РегламентноеЗадание]
					,_Fld2878 [НеОбрабатыватьВсеДокументы]
					,_Fld2879 [Комментарий]
					,_Fld2880 [Задержка]
					From _Reference159(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ГраницаОбработки = Читалка.GetDateTime(5);
							Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.РегламентноеЗадание = Читалка.GetString(11);
							Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Задержка = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Description [Наименование]
					,_Fld2871 [ГраницаОбработки]
					,_Fld2872RRef [ПериодДетализации]
					,_Fld2873RRef [Организация]
					,_Fld2874RRef [СпособВводаДанных]
					,_Fld2875RRef [ПодразделениеОрганизации]
					,_Fld2876 [ФормироватьДокументыАвтоматически]
					,_Fld2877 [РегламентноеЗадание]
					,_Fld2878 [НеОбрабатыватьВсеДокументы]
					,_Fld2879 [Комментарий]
					,_Fld2880 [Задержка]
					From _Reference159(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ГраницаОбработки = Читалка.GetDateTime(5);
							Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.РегламентноеЗадание = Читалка.GetString(11);
							Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Задержка = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени СтраницаПоСсылке(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld2871 [ГраницаОбработки]
					,_Fld2872RRef [ПериодДетализации]
					,_Fld2873RRef [Организация]
					,_Fld2874RRef [СпособВводаДанных]
					,_Fld2875RRef [ПодразделениеОрганизации]
					,_Fld2876 [ФормироватьДокументыАвтоматически]
					,_Fld2877 [РегламентноеЗадание]
					,_Fld2878 [НеОбрабатыватьВсеДокументы]
					,_Fld2879 [Комментарий]
					,_Fld2880 [Задержка]
					From _Reference159(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ГраницаОбработки = Читалка.GetDateTime(5);
							Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.РегламентноеЗадание = Читалка.GetString(11);
							Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Задержка = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld2871 [ГраницаОбработки]
					,_Fld2872RRef [ПериодДетализации]
					,_Fld2873RRef [Организация]
					,_Fld2874RRef [СпособВводаДанных]
					,_Fld2875RRef [ПодразделениеОрганизации]
					,_Fld2876 [ФормироватьДокументыАвтоматически]
					,_Fld2877 [РегламентноеЗадание]
					,_Fld2878 [НеОбрабатыватьВсеДокументы]
					,_Fld2879 [Комментарий]
					,_Fld2880 [Задержка]
					From _Reference159(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ГраницаОбработки = Читалка.GetDateTime(5);
							Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(7));
							Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.РегламентноеЗадание = Читалка.GetString(11);
							Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Задержка = Читалка.GetDecimal(14);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка;
			Объект.ПодразделениеОрганизации = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка;
			Объект.ПодразделениеОрганизации = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			return Объект;
		}
	}
}