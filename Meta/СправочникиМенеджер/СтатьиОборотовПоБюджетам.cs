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
	public partial class СтатьиОборотовПоБюджетам:СправочникМенеджер
	{
		
		public static СправочникиСсылка.СтатьиОборотовПоБюджетам НайтиПоКоду(string Код)
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
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
		
		public static СправочникиВыборка.СтатьиОборотовПоБюджетам Выбрать()
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтатьиОборотовПоБюджетам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтатьиОборотовПоБюджетам ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СтатьиОборотовПоБюджетам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтатьиОборотовПоБюджетам ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СтатьиОборотовПоБюджетам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтатьиОборотовПоБюджетам ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СтатьиОборотовПоБюджетам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтатьиОборотовПоБюджетам СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтатьиОборотовПоБюджетам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтатьиОборотовПоБюджетам СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтатьиОборотовПоБюджетам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтатьиОборотовПоБюджетам СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld3816 [НаименованиеПолное]
					,_Fld3817 [УчетПоКоличеству]
					,_Fld3818 [УчетПоСумме]
					,_Fld3819RRef [ИсточникДанныхДляЦены]
					,_Fld3820 [ПоказательИсточникаДанныхДляЦены]
					,_Fld3821RRef [ИсточникДанныхДляФакта]
					,_Fld3822 [ПоказательИсточникаДанныхДляФактаСум]
					,_Fld3823RRef [СпособОпределенияВалютыОборотаФакт]
					,_Fld3824 [ПоказательИсточникаДанныхДляФактаКол]
					,_Fld3825RRef [ЕдиницаИзмерения]
					,_Fld3826 [РазделениеПоКонтрагентам]
					,_Fld3827 [РазделениеПоНоменклатуре]
					,_Fld3828RRef [ОсновнаяВалюта]
					,_Fld3829RRef [ОсновноеЦФО]
					,_Fld3830RRef [ОсновнойПроект]
					,_Fld3831RRef [ОсновнойКонтрагент]
					,_Fld3832_TYPE [ОсновнаяНоменклатура_Тип],_Fld3832_RRRef [ОсновнаяНоменклатура],_Fld3832_RTRef [ОсновнаяНоменклатура_Вид]
					,_Fld3833 [Комментарий]
					,_Fld3834 [КоэффициентДляФактаСум]
					,_Fld3835 [КоэффициентДляФактаКол]
					From _Reference249(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтатьиОборотовПоБюджетам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиОборотовПоБюджетам();
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
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.УчетПоКоличеству = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.УчетПоСумме = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ИсточникДанныхДляЦены = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательИсточникаДанныхДляЦены = Читалка.GetString(10);
							Ссылка.ИсточникДанныхДляФакта = V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования.ВзятьИзКэша((byte[])Читалка.GetValue(11));
							Ссылка.ПоказательИсточникаДанныхДляФактаСум = Читалка.GetString(12);
							Ссылка.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Ссылка.ПоказательИсточникаДанныхДляФактаКол = Читалка.GetString(14);
							Ссылка.ЕдиницаИзмерения = V82.СправочникиСсылка.КлассификаторЕдиницИзмерения.ВзятьИзКэша((byte[])Читалка.GetValue(15));
							Ссылка.РазделениеПоКонтрагентам = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.РазделениеПоНоменклатуре = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсновнаяВалюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(18));
							Ссылка.ОсновноеЦФО = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(19));
							Ссылка.ОсновнойПроект = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Ссылка.ОсновнойКонтрагент = V82.СправочникиСсылка.Контрагенты.ВзятьИзКэша((byte[])Читалка.GetValue(21));
							Ссылка.Комментарий = Читалка.GetString(25);
							Ссылка.КоэффициентДляФактаСум = Читалка.GetDecimal(26);
							Ссылка.КоэффициентДляФактаКол = Читалка.GetDecimal(27);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.СтатьиОборотовПоБюджетам СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СтатьиОборотовПоБюджетам();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.НаименованиеПолное = "";
			Объект.ПоказательИсточникаДанныхДляЦены = "";
			Объект.ПоказательИсточникаДанныхДляФактаСум = "";
			Объект.ПоказательИсточникаДанныхДляФактаКол = "";
			Объект.Комментарий = "";
			Объект.ИсточникДанныхДляЦены = new V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования();
			Объект.ИсточникДанныхДляФакта = new V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования();
			Объект.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка;
			Объект.ЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
			Объект.ОсновнаяВалюта = new V82.СправочникиСсылка.Валюты();
			Объект.ОсновноеЦФО = new V82.СправочникиСсылка.Подразделения();
			Объект.ОсновнойПроект = new V82.СправочникиСсылка.Проекты();
			Объект.ОсновнойКонтрагент = new V82.СправочникиСсылка.Контрагенты();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.СтатьиОборотовПоБюджетам СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.СтатьиОборотовПоБюджетам();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.НаименованиеПолное = "";
			Объект.ПоказательИсточникаДанныхДляЦены = "";
			Объект.ПоказательИсточникаДанныхДляФактаСум = "";
			Объект.ПоказательИсточникаДанныхДляФактаКол = "";
			Объект.Комментарий = "";
			Объект.ИсточникДанныхДляЦены = new V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования();
			Объект.ИсточникДанныхДляФакта = new V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования();
			Объект.СпособОпределенияВалютыОборотаФакт = V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье.ПустаяСсылка;
			Объект.ЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
			Объект.ОсновнаяВалюта = new V82.СправочникиСсылка.Валюты();
			Объект.ОсновноеЦФО = new V82.СправочникиСсылка.Подразделения();
			Объект.ОсновнойПроект = new V82.СправочникиСсылка.Проекты();
			Объект.ОсновнойКонтрагент = new V82.СправочникиСсылка.Контрагенты();
			return Объект;
		}
	}
}