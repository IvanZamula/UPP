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
	///Список настроек закрытия месяца
	///</summary>
	public partial class НастройкиЗакрытияМесяца:СправочникМенеджер
	{
		
		public static СправочникиСсылка.НастройкиЗакрытияМесяца НайтиПоСсылке(Guid _Ссылка)
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
					,_Description [Наименование]
					,_Fld19545 [ДатаНачалаДействияНастройки]
					,_Fld19546 [ОтражатьВУправленческомУчете]
					,_Fld19547 [ОтражатьВБухгалтерскомУчете]
					,_Fld19548 [ОтражатьВНалоговомУчете]
					,_Fld26538 [ВариантНастройки]
					From _Reference19543(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиЗакрытияМесяца();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиЗакрытияМесяца.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачалаДействияНастройки = Читалка.GetDateTime(7);
								Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ВариантНастройки = Читалка.GetDecimal(11);
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
		
		public static СправочникиВыборка.НастройкиЗакрытияМесяца Выбрать()
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
					,_Description [Наименование]
					,_Fld19545 [ДатаНачалаДействияНастройки]
					,_Fld19546 [ОтражатьВУправленческомУчете]
					,_Fld19547 [ОтражатьВБухгалтерскомУчете]
					,_Fld19548 [ОтражатьВНалоговомУчете]
					,_Fld26538 [ВариантНастройки]
					From _Reference19543(NOLOCK)  Where _Folder = 0x01 ";
					var Выборка = new V82.СправочникиВыборка.НастройкиЗакрытияМесяца();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиЗакрытияМесяца();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиЗакрытияМесяца.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачалаДействияНастройки = Читалка.GetDateTime(7);
								Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ВариантНастройки = Читалка.GetDecimal(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиЗакрытияМесяца ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Description [Наименование]
					,_Fld19545 [ДатаНачалаДействияНастройки]
					,_Fld19546 [ОтражатьВУправленческомУчете]
					,_Fld19547 [ОтражатьВБухгалтерскомУчете]
					,_Fld19548 [ОтражатьВНалоговомУчете]
					,_Fld26538 [ВариантНастройки]
					From _Reference19543(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиЗакрытияМесяца();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиЗакрытияМесяца();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиЗакрытияМесяца.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачалаДействияНастройки = Читалка.GetDateTime(7);
								Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ВариантНастройки = Читалка.GetDecimal(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиЗакрытияМесяца ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Description [Наименование]
					,_Fld19545 [ДатаНачалаДействияНастройки]
					,_Fld19546 [ОтражатьВУправленческомУчете]
					,_Fld19547 [ОтражатьВБухгалтерскомУчете]
					,_Fld19548 [ОтражатьВНалоговомУчете]
					,_Fld26538 [ВариантНастройки]
					From _Reference19543(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиЗакрытияМесяца();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиЗакрытияМесяца();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиЗакрытияМесяца.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачалаДействияНастройки = Читалка.GetDateTime(7);
								Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ВариантНастройки = Читалка.GetDecimal(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиЗакрытияМесяца СтраницаПоСсылке(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld19545 [ДатаНачалаДействияНастройки]
					,_Fld19546 [ОтражатьВУправленческомУчете]
					,_Fld19547 [ОтражатьВБухгалтерскомУчете]
					,_Fld19548 [ОтражатьВНалоговомУчете]
					,_Fld26538 [ВариантНастройки]
					From _Reference19543(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиЗакрытияМесяца();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиЗакрытияМесяца();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиЗакрытияМесяца.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачалаДействияНастройки = Читалка.GetDateTime(7);
								Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ВариантНастройки = Читалка.GetDecimal(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиЗакрытияМесяца СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld19545 [ДатаНачалаДействияНастройки]
					,_Fld19546 [ОтражатьВУправленческомУчете]
					,_Fld19547 [ОтражатьВБухгалтерскомУчете]
					,_Fld19548 [ОтражатьВНалоговомУчете]
					,_Fld26538 [ВариантНастройки]
					From _Reference19543(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиЗакрытияМесяца();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиЗакрытияМесяца();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиЗакрытияМесяца.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачалаДействияНастройки = Читалка.GetDateTime(7);
								Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ВариантНастройки = Читалка.GetDecimal(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НастройкиЗакрытияМесяца СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиЗакрытияМесяца();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			return Объект;
		}
		
		public static V82.СправочникиОбъект.НастройкиЗакрытияМесяца СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиЗакрытияМесяца();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			return Объект;
		}
	}
}