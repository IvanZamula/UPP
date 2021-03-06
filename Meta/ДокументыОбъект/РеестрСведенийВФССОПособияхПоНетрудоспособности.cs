﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	[ProtoContract]
	[DataContract]
	public partial class РеестрСведенийВФССОПособияхПоНетрудоспособности:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public string/*(135)*/ НаименованиеТерриториальногоОрганаФСС {get;set;}//Наименование территориального органа ФСС
		[DataMember]
		[ProtoMember(13)]
		public string/*(14)*/ РегистрационныйНомерФСС {get;set;}//Регистрационный номер ФСС
		[DataMember]
		[ProtoMember(14)]
		public string/*(14)*/ ДополнительныйКодФСС {get;set;}//Дополнительный код ФСС
		[DataMember]
		[ProtoMember(15)]
		public string/*(5)*/ КодПодчиненностиФСС {get;set;}//Код подчиненности ФСС
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.ФизическиеЛица Руководитель {get;set;}
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьРуководителя {get;set;}//Должность руководителя
		[DataMember]
		[ProtoMember(18)]
		public string/*(100)*/ КраткийСоставДокумента {get;set;}//Краткий состав документа
		[DataMember]
		[ProtoMember(19)]
		public string/*(12)*/ ИНН {get;set;}
		[DataMember]
		[ProtoMember(20)]
		public string/*(9)*/ КПП {get;set;}
		[DataMember]
		[ProtoMember(21)]
		public string/*(15)*/ ОГРН {get;set;}
		[DataMember]
		[ProtoMember(22)]
		public V82.СправочникиСсылка.ФизическиеЛица РеестрСоставил {get;set;}//Реестр составил
		[DataMember]
		[ProtoMember(23)]
		public string/*(30)*/ ТелефонСоставителя {get;set;}//Телефон составителя
		[DataMember]
		[ProtoMember(24)]
		public string/*(40)*/ АдресЭлектроннойПочтыСоставителя {get;set;}//Адрес электронной почты составителя
		[DataMember]
		[ProtoMember(25)]
		public V82.СправочникиСсылка.ФизическиеЛица ГлавныйБухгалтер {get;set;}//Главный бухгалтер
		[DataMember]
		[ProtoMember(26)]
		public bool ВыводитьПодписиВРеестрПособий {get;set;}//Выводить подписи в реестр пособий
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document23168(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld25099RRef
						,_Fld25100RRef
						,_Fld25101
						,_Fld25102
						,_Fld25103
						,_Fld25104
						,_Fld25105
						,_Fld25106RRef
						,_Fld25107RRef
						,_Fld25108
						,_Fld25109
						,_Fld25110
						,_Fld25111
						,_Fld25112RRef
						,_Fld25113
						,_Fld25114
						,_Fld25115RRef
						,_Fld25116)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@Организация
						,@Ответственный
						,@Комментарий
						,@НаименованиеТерриториальногоОрганаФСС
						,@РегистрационныйНомерФСС
						,@ДополнительныйКодФСС
						,@КодПодчиненностиФСС
						,@Руководитель
						,@ДолжностьРуководителя
						,@КраткийСоставДокумента
						,@ИНН
						,@КПП
						,@ОГРН
						,@РеестрСоставил
						,@ТелефонСоставителя
						,@АдресЭлектроннойПочтыСоставителя
						,@ГлавныйБухгалтер
						,@ВыводитьПодписиВРеестрПособий)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document23168
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld25099RRef	= @Организация
						,_Fld25100RRef	= @Ответственный
						,_Fld25101	= @Комментарий
						,_Fld25102	= @НаименованиеТерриториальногоОрганаФСС
						,_Fld25103	= @РегистрационныйНомерФСС
						,_Fld25104	= @ДополнительныйКодФСС
						,_Fld25105	= @КодПодчиненностиФСС
						,_Fld25106RRef	= @Руководитель
						,_Fld25107RRef	= @ДолжностьРуководителя
						,_Fld25108	= @КраткийСоставДокумента
						,_Fld25109	= @ИНН
						,_Fld25110	= @КПП
						,_Fld25111	= @ОГРН
						,_Fld25112RRef	= @РеестрСоставил
						,_Fld25113	= @ТелефонСоставителя
						,_Fld25114	= @АдресЭлектроннойПочтыСоставителя
						,_Fld25115RRef	= @ГлавныйБухгалтер
						,_Fld25116	= @ВыводитьПодписиВРеестрПособий
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("НаименованиеТерриториальногоОрганаФСС", НаименованиеТерриториальногоОрганаФСС);
					Команда.Parameters.AddWithValue("РегистрационныйНомерФСС", РегистрационныйНомерФСС);
					Команда.Parameters.AddWithValue("ДополнительныйКодФСС", ДополнительныйКодФСС);
					Команда.Parameters.AddWithValue("КодПодчиненностиФСС", КодПодчиненностиФСС);
					Команда.Parameters.AddWithValue("КраткийСоставДокумента", КраткийСоставДокумента);
					Команда.Parameters.AddWithValue("ИНН", ИНН);
					Команда.Parameters.AddWithValue("КПП", КПП);
					Команда.Parameters.AddWithValue("ОГРН", ОГРН);
					Команда.Parameters.AddWithValue("ТелефонСоставителя", ТелефонСоставителя);
					Команда.Parameters.AddWithValue("АдресЭлектроннойПочтыСоставителя", АдресЭлектроннойПочтыСоставителя);
					Команда.Parameters.AddWithValue("ВыводитьПодписиВРеестрПособий", ВыводитьПодписиВРеестрПособий);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Document23168
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}