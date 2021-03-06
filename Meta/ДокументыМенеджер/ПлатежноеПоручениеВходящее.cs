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
	///(Общ)
	///</summary>
	public partial class ПлатежноеПоручениеВходящее:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ПлатежноеПоручениеВходящее НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld8571RRef [ВалютаДокумента]
					,_Fld8572RRef [ВидОперации]
					,_Fld8569RRef [ДоговорКонтрагента]
					,_Fld8562_TYPE [ДокументОснование_Тип],_Fld8562_RRRef [ДокументОснование],_Fld8562_RTRef [ДокументОснование_Вид]
					,_Fld8577 [Комментарий]
					,_Fld8567RRef [Контрагент]
					,_Fld8564 [НомерВходящегоДокумента]
					,_Fld8563 [ДатаВходящегоДокумента]
					,_Fld8574 [Оплачено]
					,_Fld8565RRef [Организация]
					,_Fld8578RRef [Ответственный]
					,_Fld8573 [ОтраженоВОперУчете]
					,_Fld8585 [ОтражатьВНалоговомУчете]
					,_Fld8575 [ДатаОплаты]
					,_Fld8576 [ЧастичнаяОплата]
					,_Fld8580RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld8582RRef [СубконтоКт1]
					,_Fld8579 [ОтражатьВБухгалтерскомУчете]
					,_Fld8583RRef [СубконтоКт2]
					,_Fld8584RRef [СубконтоКт3]
					,_Fld8570 [СуммаДокумента]
					,_Fld8568RRef [СчетКонтрагента]
					,_Fld8566RRef [СчетОрганизации]
					,_Fld8581RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld8586 [Содержание_УСН]
					,_Fld8587 [Графа4_УСН]
					,_Fld8588 [Графа5_УСН]
					,_Fld8589 [Графа6_УСН]
					,_Fld8590 [Графа7_УСН]
					,_Fld8591 [ДоходыЕНВД_УСН]
					,_Fld8592 [РасходыЕНВД_УСН]
					,_Fld8593 [НДС_УСН]
					,_Fld8594 [РучнаяНастройка_УСН]
					,_Fld8595RRef [Подразделение]
					,_Fld8596 [НазначениеПлатежа]
					,_Fld8597RRef [СчетУчетаРасчетовСКонтрагентомНУ]
					,_Fld8598RRef [СубконтоНУКт1]
					,_Fld8599RRef [СубконтоНУКт2]
					,_Fld8600RRef [СубконтоНУКт3]
					,_Fld8601RRef [СтатьяЗатрат]
					,_Fld8602RRef [НоменклатурнаяГруппа]
					,_Fld8603RRef [ПодразделениеЗатраты]
					,_Fld8604RRef [ПодразделениеОрганизацииЗатраты]
					,_Fld8605 [СуммаУслуг]
					From _Document388(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПлатежноеПоручениеВходящее();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.НомерВходящегоДокумента = Читалка.GetString(11);
							Ссылка.ДатаВходящегоДокумента = Читалка.GetDateTime(12);
							Ссылка.Оплачено = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ОтраженоВОперУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ДатаОплаты = Читалка.GetDateTime(18);
							Ссылка.ЧастичнаяОплата = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(25);
							Ссылка.Содержание_УСН = Читалка.GetString(29);
							Ссылка.Графа4_УСН = Читалка.GetDecimal(30);
							Ссылка.Графа5_УСН = Читалка.GetDecimal(31);
							Ссылка.Графа6_УСН = Читалка.GetDecimal(32);
							Ссылка.Графа7_УСН = Читалка.GetDecimal(33);
							Ссылка.ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							Ссылка.РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(35))[0]==1;
							Ссылка.НДС_УСН = Читалка.GetDecimal(36);
							Ссылка.РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(37))[0]==1;
							Ссылка.НазначениеПлатежа = Читалка.GetString(39);
							Ссылка.СуммаУслуг = Читалка.GetDecimal(48);
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
		
		public static ДокументыСсылка.ПлатежноеПоручениеВходящее НайтиПоНомеру(string Номер)
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
					,_Fld8571RRef [ВалютаДокумента]
					,_Fld8572RRef [ВидОперации]
					,_Fld8569RRef [ДоговорКонтрагента]
					,_Fld8562_TYPE [ДокументОснование_Тип],_Fld8562_RRRef [ДокументОснование],_Fld8562_RTRef [ДокументОснование_Вид]
					,_Fld8577 [Комментарий]
					,_Fld8567RRef [Контрагент]
					,_Fld8564 [НомерВходящегоДокумента]
					,_Fld8563 [ДатаВходящегоДокумента]
					,_Fld8574 [Оплачено]
					,_Fld8565RRef [Организация]
					,_Fld8578RRef [Ответственный]
					,_Fld8573 [ОтраженоВОперУчете]
					,_Fld8585 [ОтражатьВНалоговомУчете]
					,_Fld8575 [ДатаОплаты]
					,_Fld8576 [ЧастичнаяОплата]
					,_Fld8580RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld8582RRef [СубконтоКт1]
					,_Fld8579 [ОтражатьВБухгалтерскомУчете]
					,_Fld8583RRef [СубконтоКт2]
					,_Fld8584RRef [СубконтоКт3]
					,_Fld8570 [СуммаДокумента]
					,_Fld8568RRef [СчетКонтрагента]
					,_Fld8566RRef [СчетОрганизации]
					,_Fld8581RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld8586 [Содержание_УСН]
					,_Fld8587 [Графа4_УСН]
					,_Fld8588 [Графа5_УСН]
					,_Fld8589 [Графа6_УСН]
					,_Fld8590 [Графа7_УСН]
					,_Fld8591 [ДоходыЕНВД_УСН]
					,_Fld8592 [РасходыЕНВД_УСН]
					,_Fld8593 [НДС_УСН]
					,_Fld8594 [РучнаяНастройка_УСН]
					,_Fld8595RRef [Подразделение]
					,_Fld8596 [НазначениеПлатежа]
					,_Fld8597RRef [СчетУчетаРасчетовСКонтрагентомНУ]
					,_Fld8598RRef [СубконтоНУКт1]
					,_Fld8599RRef [СубконтоНУКт2]
					,_Fld8600RRef [СубконтоНУКт3]
					,_Fld8601RRef [СтатьяЗатрат]
					,_Fld8602RRef [НоменклатурнаяГруппа]
					,_Fld8603RRef [ПодразделениеЗатраты]
					,_Fld8604RRef [ПодразделениеОрганизацииЗатраты]
					,_Fld8605 [СуммаУслуг]
					From _Document388(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПлатежноеПоручениеВходящее();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.НомерВходящегоДокумента = Читалка.GetString(11);
							Ссылка.ДатаВходящегоДокумента = Читалка.GetDateTime(12);
							Ссылка.Оплачено = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ОтраженоВОперУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ДатаОплаты = Читалка.GetDateTime(18);
							Ссылка.ЧастичнаяОплата = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(25);
							Ссылка.Содержание_УСН = Читалка.GetString(29);
							Ссылка.Графа4_УСН = Читалка.GetDecimal(30);
							Ссылка.Графа5_УСН = Читалка.GetDecimal(31);
							Ссылка.Графа6_УСН = Читалка.GetDecimal(32);
							Ссылка.Графа7_УСН = Читалка.GetDecimal(33);
							Ссылка.ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							Ссылка.РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(35))[0]==1;
							Ссылка.НДС_УСН = Читалка.GetDecimal(36);
							Ссылка.РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(37))[0]==1;
							Ссылка.НазначениеПлатежа = Читалка.GetString(39);
							Ссылка.СуммаУслуг = Читалка.GetDecimal(48);
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
		
		public static ДокументыВыборка.ПлатежноеПоручениеВходящее Выбрать()
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
					,_Fld8571RRef [ВалютаДокумента]
					,_Fld8572RRef [ВидОперации]
					,_Fld8569RRef [ДоговорКонтрагента]
					,_Fld8562_TYPE [ДокументОснование_Тип],_Fld8562_RRRef [ДокументОснование],_Fld8562_RTRef [ДокументОснование_Вид]
					,_Fld8577 [Комментарий]
					,_Fld8567RRef [Контрагент]
					,_Fld8564 [НомерВходящегоДокумента]
					,_Fld8563 [ДатаВходящегоДокумента]
					,_Fld8574 [Оплачено]
					,_Fld8565RRef [Организация]
					,_Fld8578RRef [Ответственный]
					,_Fld8573 [ОтраженоВОперУчете]
					,_Fld8585 [ОтражатьВНалоговомУчете]
					,_Fld8575 [ДатаОплаты]
					,_Fld8576 [ЧастичнаяОплата]
					,_Fld8580RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld8582RRef [СубконтоКт1]
					,_Fld8579 [ОтражатьВБухгалтерскомУчете]
					,_Fld8583RRef [СубконтоКт2]
					,_Fld8584RRef [СубконтоКт3]
					,_Fld8570 [СуммаДокумента]
					,_Fld8568RRef [СчетКонтрагента]
					,_Fld8566RRef [СчетОрганизации]
					,_Fld8581RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld8586 [Содержание_УСН]
					,_Fld8587 [Графа4_УСН]
					,_Fld8588 [Графа5_УСН]
					,_Fld8589 [Графа6_УСН]
					,_Fld8590 [Графа7_УСН]
					,_Fld8591 [ДоходыЕНВД_УСН]
					,_Fld8592 [РасходыЕНВД_УСН]
					,_Fld8593 [НДС_УСН]
					,_Fld8594 [РучнаяНастройка_УСН]
					,_Fld8595RRef [Подразделение]
					,_Fld8596 [НазначениеПлатежа]
					,_Fld8597RRef [СчетУчетаРасчетовСКонтрагентомНУ]
					,_Fld8598RRef [СубконтоНУКт1]
					,_Fld8599RRef [СубконтоНУКт2]
					,_Fld8600RRef [СубконтоНУКт3]
					,_Fld8601RRef [СтатьяЗатрат]
					,_Fld8602RRef [НоменклатурнаяГруппа]
					,_Fld8603RRef [ПодразделениеЗатраты]
					,_Fld8604RRef [ПодразделениеОрганизацииЗатраты]
					,_Fld8605 [СуммаУслуг]
					From _Document388(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПлатежноеПоручениеВходящее();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПлатежноеПоручениеВходящее();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.НомерВходящегоДокумента = Читалка.GetString(11);
							Ссылка.ДатаВходящегоДокумента = Читалка.GetDateTime(12);
							Ссылка.Оплачено = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ОтраженоВОперУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ДатаОплаты = Читалка.GetDateTime(18);
							Ссылка.ЧастичнаяОплата = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(25);
							Ссылка.Содержание_УСН = Читалка.GetString(29);
							Ссылка.Графа4_УСН = Читалка.GetDecimal(30);
							Ссылка.Графа5_УСН = Читалка.GetDecimal(31);
							Ссылка.Графа6_УСН = Читалка.GetDecimal(32);
							Ссылка.Графа7_УСН = Читалка.GetDecimal(33);
							Ссылка.ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							Ссылка.РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(35))[0]==1;
							Ссылка.НДС_УСН = Читалка.GetDecimal(36);
							Ссылка.РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(37))[0]==1;
							Ссылка.НазначениеПлатежа = Читалка.GetString(39);
							Ссылка.СуммаУслуг = Читалка.GetDecimal(48);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПлатежноеПоручениеВходящее ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld8571RRef [ВалютаДокумента]
					,_Fld8572RRef [ВидОперации]
					,_Fld8569RRef [ДоговорКонтрагента]
					,_Fld8562_TYPE [ДокументОснование_Тип],_Fld8562_RRRef [ДокументОснование],_Fld8562_RTRef [ДокументОснование_Вид]
					,_Fld8577 [Комментарий]
					,_Fld8567RRef [Контрагент]
					,_Fld8564 [НомерВходящегоДокумента]
					,_Fld8563 [ДатаВходящегоДокумента]
					,_Fld8574 [Оплачено]
					,_Fld8565RRef [Организация]
					,_Fld8578RRef [Ответственный]
					,_Fld8573 [ОтраженоВОперУчете]
					,_Fld8585 [ОтражатьВНалоговомУчете]
					,_Fld8575 [ДатаОплаты]
					,_Fld8576 [ЧастичнаяОплата]
					,_Fld8580RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld8582RRef [СубконтоКт1]
					,_Fld8579 [ОтражатьВБухгалтерскомУчете]
					,_Fld8583RRef [СубконтоКт2]
					,_Fld8584RRef [СубконтоКт3]
					,_Fld8570 [СуммаДокумента]
					,_Fld8568RRef [СчетКонтрагента]
					,_Fld8566RRef [СчетОрганизации]
					,_Fld8581RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld8586 [Содержание_УСН]
					,_Fld8587 [Графа4_УСН]
					,_Fld8588 [Графа5_УСН]
					,_Fld8589 [Графа6_УСН]
					,_Fld8590 [Графа7_УСН]
					,_Fld8591 [ДоходыЕНВД_УСН]
					,_Fld8592 [РасходыЕНВД_УСН]
					,_Fld8593 [НДС_УСН]
					,_Fld8594 [РучнаяНастройка_УСН]
					,_Fld8595RRef [Подразделение]
					,_Fld8596 [НазначениеПлатежа]
					,_Fld8597RRef [СчетУчетаРасчетовСКонтрагентомНУ]
					,_Fld8598RRef [СубконтоНУКт1]
					,_Fld8599RRef [СубконтоНУКт2]
					,_Fld8600RRef [СубконтоНУКт3]
					,_Fld8601RRef [СтатьяЗатрат]
					,_Fld8602RRef [НоменклатурнаяГруппа]
					,_Fld8603RRef [ПодразделениеЗатраты]
					,_Fld8604RRef [ПодразделениеОрганизацииЗатраты]
					,_Fld8605 [СуммаУслуг]
					From _Document388(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПлатежноеПоручениеВходящее();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПлатежноеПоручениеВходящее();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.НомерВходящегоДокумента = Читалка.GetString(11);
							Ссылка.ДатаВходящегоДокумента = Читалка.GetDateTime(12);
							Ссылка.Оплачено = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ОтраженоВОперУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ДатаОплаты = Читалка.GetDateTime(18);
							Ссылка.ЧастичнаяОплата = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(25);
							Ссылка.Содержание_УСН = Читалка.GetString(29);
							Ссылка.Графа4_УСН = Читалка.GetDecimal(30);
							Ссылка.Графа5_УСН = Читалка.GetDecimal(31);
							Ссылка.Графа6_УСН = Читалка.GetDecimal(32);
							Ссылка.Графа7_УСН = Читалка.GetDecimal(33);
							Ссылка.ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							Ссылка.РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(35))[0]==1;
							Ссылка.НДС_УСН = Читалка.GetDecimal(36);
							Ссылка.РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(37))[0]==1;
							Ссылка.НазначениеПлатежа = Читалка.GetString(39);
							Ссылка.СуммаУслуг = Читалка.GetDecimal(48);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПлатежноеПоручениеВходящее ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld8571RRef [ВалютаДокумента]
					,_Fld8572RRef [ВидОперации]
					,_Fld8569RRef [ДоговорКонтрагента]
					,_Fld8562_TYPE [ДокументОснование_Тип],_Fld8562_RRRef [ДокументОснование],_Fld8562_RTRef [ДокументОснование_Вид]
					,_Fld8577 [Комментарий]
					,_Fld8567RRef [Контрагент]
					,_Fld8564 [НомерВходящегоДокумента]
					,_Fld8563 [ДатаВходящегоДокумента]
					,_Fld8574 [Оплачено]
					,_Fld8565RRef [Организация]
					,_Fld8578RRef [Ответственный]
					,_Fld8573 [ОтраженоВОперУчете]
					,_Fld8585 [ОтражатьВНалоговомУчете]
					,_Fld8575 [ДатаОплаты]
					,_Fld8576 [ЧастичнаяОплата]
					,_Fld8580RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld8582RRef [СубконтоКт1]
					,_Fld8579 [ОтражатьВБухгалтерскомУчете]
					,_Fld8583RRef [СубконтоКт2]
					,_Fld8584RRef [СубконтоКт3]
					,_Fld8570 [СуммаДокумента]
					,_Fld8568RRef [СчетКонтрагента]
					,_Fld8566RRef [СчетОрганизации]
					,_Fld8581RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld8586 [Содержание_УСН]
					,_Fld8587 [Графа4_УСН]
					,_Fld8588 [Графа5_УСН]
					,_Fld8589 [Графа6_УСН]
					,_Fld8590 [Графа7_УСН]
					,_Fld8591 [ДоходыЕНВД_УСН]
					,_Fld8592 [РасходыЕНВД_УСН]
					,_Fld8593 [НДС_УСН]
					,_Fld8594 [РучнаяНастройка_УСН]
					,_Fld8595RRef [Подразделение]
					,_Fld8596 [НазначениеПлатежа]
					,_Fld8597RRef [СчетУчетаРасчетовСКонтрагентомНУ]
					,_Fld8598RRef [СубконтоНУКт1]
					,_Fld8599RRef [СубконтоНУКт2]
					,_Fld8600RRef [СубконтоНУКт3]
					,_Fld8601RRef [СтатьяЗатрат]
					,_Fld8602RRef [НоменклатурнаяГруппа]
					,_Fld8603RRef [ПодразделениеЗатраты]
					,_Fld8604RRef [ПодразделениеОрганизацииЗатраты]
					,_Fld8605 [СуммаУслуг]
					From _Document388(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПлатежноеПоручениеВходящее();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПлатежноеПоручениеВходящее();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.НомерВходящегоДокумента = Читалка.GetString(11);
							Ссылка.ДатаВходящегоДокумента = Читалка.GetDateTime(12);
							Ссылка.Оплачено = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ОтраженоВОперУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ДатаОплаты = Читалка.GetDateTime(18);
							Ссылка.ЧастичнаяОплата = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(25);
							Ссылка.Содержание_УСН = Читалка.GetString(29);
							Ссылка.Графа4_УСН = Читалка.GetDecimal(30);
							Ссылка.Графа5_УСН = Читалка.GetDecimal(31);
							Ссылка.Графа6_УСН = Читалка.GetDecimal(32);
							Ссылка.Графа7_УСН = Читалка.GetDecimal(33);
							Ссылка.ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							Ссылка.РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(35))[0]==1;
							Ссылка.НДС_УСН = Читалка.GetDecimal(36);
							Ссылка.РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(37))[0]==1;
							Ссылка.НазначениеПлатежа = Читалка.GetString(39);
							Ссылка.СуммаУслуг = Читалка.GetDecimal(48);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПлатежноеПоручениеВходящее СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld8571RRef [ВалютаДокумента]
					,_Fld8572RRef [ВидОперации]
					,_Fld8569RRef [ДоговорКонтрагента]
					,_Fld8562_TYPE [ДокументОснование_Тип],_Fld8562_RRRef [ДокументОснование],_Fld8562_RTRef [ДокументОснование_Вид]
					,_Fld8577 [Комментарий]
					,_Fld8567RRef [Контрагент]
					,_Fld8564 [НомерВходящегоДокумента]
					,_Fld8563 [ДатаВходящегоДокумента]
					,_Fld8574 [Оплачено]
					,_Fld8565RRef [Организация]
					,_Fld8578RRef [Ответственный]
					,_Fld8573 [ОтраженоВОперУчете]
					,_Fld8585 [ОтражатьВНалоговомУчете]
					,_Fld8575 [ДатаОплаты]
					,_Fld8576 [ЧастичнаяОплата]
					,_Fld8580RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld8582RRef [СубконтоКт1]
					,_Fld8579 [ОтражатьВБухгалтерскомУчете]
					,_Fld8583RRef [СубконтоКт2]
					,_Fld8584RRef [СубконтоКт3]
					,_Fld8570 [СуммаДокумента]
					,_Fld8568RRef [СчетКонтрагента]
					,_Fld8566RRef [СчетОрганизации]
					,_Fld8581RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld8586 [Содержание_УСН]
					,_Fld8587 [Графа4_УСН]
					,_Fld8588 [Графа5_УСН]
					,_Fld8589 [Графа6_УСН]
					,_Fld8590 [Графа7_УСН]
					,_Fld8591 [ДоходыЕНВД_УСН]
					,_Fld8592 [РасходыЕНВД_УСН]
					,_Fld8593 [НДС_УСН]
					,_Fld8594 [РучнаяНастройка_УСН]
					,_Fld8595RRef [Подразделение]
					,_Fld8596 [НазначениеПлатежа]
					,_Fld8597RRef [СчетУчетаРасчетовСКонтрагентомНУ]
					,_Fld8598RRef [СубконтоНУКт1]
					,_Fld8599RRef [СубконтоНУКт2]
					,_Fld8600RRef [СубконтоНУКт3]
					,_Fld8601RRef [СтатьяЗатрат]
					,_Fld8602RRef [НоменклатурнаяГруппа]
					,_Fld8603RRef [ПодразделениеЗатраты]
					,_Fld8604RRef [ПодразделениеОрганизацииЗатраты]
					,_Fld8605 [СуммаУслуг]
					From _Document388(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПлатежноеПоручениеВходящее();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПлатежноеПоручениеВходящее();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.НомерВходящегоДокумента = Читалка.GetString(11);
							Ссылка.ДатаВходящегоДокумента = Читалка.GetDateTime(12);
							Ссылка.Оплачено = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ОтраженоВОперУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ДатаОплаты = Читалка.GetDateTime(18);
							Ссылка.ЧастичнаяОплата = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(25);
							Ссылка.Содержание_УСН = Читалка.GetString(29);
							Ссылка.Графа4_УСН = Читалка.GetDecimal(30);
							Ссылка.Графа5_УСН = Читалка.GetDecimal(31);
							Ссылка.Графа6_УСН = Читалка.GetDecimal(32);
							Ссылка.Графа7_УСН = Читалка.GetDecimal(33);
							Ссылка.ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							Ссылка.РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(35))[0]==1;
							Ссылка.НДС_УСН = Читалка.GetDecimal(36);
							Ссылка.РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(37))[0]==1;
							Ссылка.НазначениеПлатежа = Читалка.GetString(39);
							Ссылка.СуммаУслуг = Читалка.GetDecimal(48);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПлатежноеПоручениеВходящее СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld8571RRef [ВалютаДокумента]
					,_Fld8572RRef [ВидОперации]
					,_Fld8569RRef [ДоговорКонтрагента]
					,_Fld8562_TYPE [ДокументОснование_Тип],_Fld8562_RRRef [ДокументОснование],_Fld8562_RTRef [ДокументОснование_Вид]
					,_Fld8577 [Комментарий]
					,_Fld8567RRef [Контрагент]
					,_Fld8564 [НомерВходящегоДокумента]
					,_Fld8563 [ДатаВходящегоДокумента]
					,_Fld8574 [Оплачено]
					,_Fld8565RRef [Организация]
					,_Fld8578RRef [Ответственный]
					,_Fld8573 [ОтраженоВОперУчете]
					,_Fld8585 [ОтражатьВНалоговомУчете]
					,_Fld8575 [ДатаОплаты]
					,_Fld8576 [ЧастичнаяОплата]
					,_Fld8580RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld8582RRef [СубконтоКт1]
					,_Fld8579 [ОтражатьВБухгалтерскомУчете]
					,_Fld8583RRef [СубконтоКт2]
					,_Fld8584RRef [СубконтоКт3]
					,_Fld8570 [СуммаДокумента]
					,_Fld8568RRef [СчетКонтрагента]
					,_Fld8566RRef [СчетОрганизации]
					,_Fld8581RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld8586 [Содержание_УСН]
					,_Fld8587 [Графа4_УСН]
					,_Fld8588 [Графа5_УСН]
					,_Fld8589 [Графа6_УСН]
					,_Fld8590 [Графа7_УСН]
					,_Fld8591 [ДоходыЕНВД_УСН]
					,_Fld8592 [РасходыЕНВД_УСН]
					,_Fld8593 [НДС_УСН]
					,_Fld8594 [РучнаяНастройка_УСН]
					,_Fld8595RRef [Подразделение]
					,_Fld8596 [НазначениеПлатежа]
					,_Fld8597RRef [СчетУчетаРасчетовСКонтрагентомНУ]
					,_Fld8598RRef [СубконтоНУКт1]
					,_Fld8599RRef [СубконтоНУКт2]
					,_Fld8600RRef [СубконтоНУКт3]
					,_Fld8601RRef [СтатьяЗатрат]
					,_Fld8602RRef [НоменклатурнаяГруппа]
					,_Fld8603RRef [ПодразделениеЗатраты]
					,_Fld8604RRef [ПодразделениеОрганизацииЗатраты]
					,_Fld8605 [СуммаУслуг]
					From _Document388(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПлатежноеПоручениеВходящее();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПлатежноеПоручениеВходящее();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.НомерВходящегоДокумента = Читалка.GetString(11);
							Ссылка.ДатаВходящегоДокумента = Читалка.GetDateTime(12);
							Ссылка.Оплачено = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ОтраженоВОперУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ДатаОплаты = Читалка.GetDateTime(18);
							Ссылка.ЧастичнаяОплата = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(25);
							Ссылка.Содержание_УСН = Читалка.GetString(29);
							Ссылка.Графа4_УСН = Читалка.GetDecimal(30);
							Ссылка.Графа5_УСН = Читалка.GetDecimal(31);
							Ссылка.Графа6_УСН = Читалка.GetDecimal(32);
							Ссылка.Графа7_УСН = Читалка.GetDecimal(33);
							Ссылка.ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							Ссылка.РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(35))[0]==1;
							Ссылка.НДС_УСН = Читалка.GetDecimal(36);
							Ссылка.РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(37))[0]==1;
							Ссылка.НазначениеПлатежа = Читалка.GetString(39);
							Ссылка.СуммаУслуг = Читалка.GetDecimal(48);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ПлатежноеПоручениеВходящее СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ПлатежноеПоручениеВходящее();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.НомерВходящегоДокумента = "";
			Объект.Содержание_УСН = "";
			Объект.НазначениеПлатежа = "";
			Объект.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка;
			return Объект;
		}
	}
}