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
	///(Упр)
	///</summary>
	public partial class ТипыЦенНоменклатуры:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ТипыЦенНоменклатуры НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
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
		
		public static СправочникиСсылка.ТипыЦенНоменклатуры НайтиПоКоду(string Код)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
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
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры Выбрать()
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2107RRef [ВалютаЦены]
					,_Fld2108RRef [БазовыйТипЦен]
					,_Fld2109 [Рассчитывается]
					,_Fld2110 [ПроцентСкидкиНаценки]
					,_Fld2111 [ЦенаВключаетНДС]
					,_Fld2112RRef [ПорядокОкругления]
					,_Fld2113 [ОкруглятьВБольшуюСторону]
					,_Fld2114 [Комментарий]
					,_Fld2115RRef [СпособРасчетаЦены]
					From _Reference181(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.БазовыйТипЦен = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(13);
								Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ТипыЦенНоменклатуры СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ТипыЦенНоменклатуры();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ВалютаЦены = new V82.СправочникиСсылка.Валюты();
			Объект.БазовыйТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка;
			Объект.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка;
			return Объект;
		}
	}
}