﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class Контрагенты:СправочникОбъект
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
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public V82.СправочникиСсылка.Контрагенты Родитель {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public bool ЭтоГруппа {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(0)*/ НаименованиеПолное {get;set;}//Полное наименование
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ) Дополнительное описание
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public string/*(0)*/ ДополнительноеОписание {get;set;}//Дополнительное описание
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public V82.СправочникиСсылка.Контрагенты ГоловнойКонтрагент {get;set;}//Головной контрагент
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей ИсточникИнформацииПриОбращении {get;set;}//Источник информации при обращении
		///<summary>
		///(Регл) 
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(10)*/ КодПоОКПО {get;set;}//Код по ОКПО
		///<summary>
		///(Регл) Идентификационный номер налогоплательщика
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public string/*(12)*/ ИНН {get;set;}
		///<summary>
		///(Регл) Идентификационный номер налогоплательщика
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public string/*(9)*/ КПП {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public V82.Перечисления/*Ссылка*/.ЮрФизЛицо ЮрФизЛицо {get;set;}//Юр. / физ. лицо
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public V82.СправочникиСсылка.БанковскиеСчета ОсновнойБанковскийСчет {get;set;}//Основной банковский счет
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ОсновнойДоговорКонтрагента {get;set;}//Основной договор контрагента
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public V82.СправочникиСсылка.ВидыДеятельностиКонтрагентов ОсновнойВидДеятельности {get;set;}//Основной вид деятельности
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public string/*(0)*/ ДокументУдостоверяющийЛичность {get;set;}//Документ, удостоверяющий личность
		///<summary>
		///(Упр) Основной менеджер
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public V82.СправочникиСсылка.Пользователи ОсновнойМенеджерПокупателя {get;set;}//Основной менеджер покупателя
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public bool Покупатель {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(25)]
		public bool Поставщик {get;set;}
		///<summary>
		///(Общ) Расписание работы строкой
		///</summary>
		[DataMember]
		[ProtoMember(26)]
		public string/*(0)*/ РасписаниеРаботыСтрокой {get;set;}//Расписание работы строкой
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(27)]
		public decimal/*(3)*/ СрокВыполненияЗаказаПоставщиком {get;set;}//Срок выполнения заказа поставщиком (в днях)
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(28)]
		public V82.СправочникиСсылка.КонтактныеЛицаКонтрагентов ОсновноеКонтактноеЛицо {get;set;}//Основное контактное лицо
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(29)]
		public bool НеЯвляетсяРезидентом {get;set;}//Не является резидентом
		[DataMember]
		[ProtoMember(30)]
		public V82.СправочникиСсылка.КлассификаторОКОПФ ОКОПФ {get;set;}
		[DataMember]
		[ProtoMember(31)]
		public V82.СправочникиСсылка.Регионы Регион {get;set;}
		[DataMember]
		[ProtoMember(32)]
		public V82.СправочникиСсылка.ГруппыДоступаКонтрагентов ГруппаДоступаКонтрагента {get;set;}//Группа доступа контрагента
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для справочников.
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
						Insert Into _Reference78(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld1266
						,_Fld1264
						,_Fld1260
						,_Fld1258RRef
						,_Fld1262RRef
						,_Fld1263
						,_Fld1261
						,_Fld1265
						,_Fld1276RRef
						,_Fld1268RRef
						,_Fld1270RRef
						,_Fld1269RRef
						,_Fld1259
						,_Fld1271RRef
						,_Fld1272
						,_Fld1273
						,_Fld1274
						,_Fld1275
						,_Fld1267RRef
						,_Fld1277
						,_Fld1278RRef
						,_Fld1279RRef
						,_Fld21240RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@НаименованиеПолное
						,@Комментарий
						,@ДополнительноеОписание
						,@ГоловнойКонтрагент
						,@ИсточникИнформацииПриОбращении
						,@КодПоОКПО
						,@ИНН
						,@КПП
						,@ЮрФизЛицо
						,@ОсновнойБанковскийСчет
						,@ОсновнойДоговорКонтрагента
						,@ОсновнойВидДеятельности
						,@ДокументУдостоверяющийЛичность
						,@ОсновнойМенеджерПокупателя
						,@Покупатель
						,@Поставщик
						,@РасписаниеРаботыСтрокой
						,@СрокВыполненияЗаказаПоставщиком
						,@ОсновноеКонтактноеЛицо
						,@НеЯвляетсяРезидентом
						,@ОКОПФ
						,@Регион
						,@ГруппаДоступаКонтрагента)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference78
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld1266	= @НаименованиеПолное
						,_Fld1264	= @Комментарий
						,_Fld1260	= @ДополнительноеОписание
						,_Fld1258RRef	= @ГоловнойКонтрагент
						,_Fld1262RRef	= @ИсточникИнформацииПриОбращении
						,_Fld1263	= @КодПоОКПО
						,_Fld1261	= @ИНН
						,_Fld1265	= @КПП
						,_Fld1276RRef	= @ЮрФизЛицо
						,_Fld1268RRef	= @ОсновнойБанковскийСчет
						,_Fld1270RRef	= @ОсновнойДоговорКонтрагента
						,_Fld1269RRef	= @ОсновнойВидДеятельности
						,_Fld1259	= @ДокументУдостоверяющийЛичность
						,_Fld1271RRef	= @ОсновнойМенеджерПокупателя
						,_Fld1272	= @Покупатель
						,_Fld1273	= @Поставщик
						,_Fld1274	= @РасписаниеРаботыСтрокой
						,_Fld1275	= @СрокВыполненияЗаказаПоставщиком
						,_Fld1267RRef	= @ОсновноеКонтактноеЛицо
						,_Fld1277	= @НеЯвляетсяРезидентом
						,_Fld1278RRef	= @ОКОПФ
						,_Fld1279RRef	= @Регион
						,_Fld21240RRef	= @ГруппаДоступаКонтрагента
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("НаименованиеПолное", НаименованиеПолное);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("ДополнительноеОписание", ДополнительноеОписание);
					Команда.Parameters.AddWithValue("ГоловнойКонтрагент", ГоловнойКонтрагент.Ссылка);
					Команда.Parameters.AddWithValue("ИсточникИнформацииПриОбращении", ИсточникИнформацииПриОбращении.Ссылка);
					Команда.Parameters.AddWithValue("КодПоОКПО", КодПоОКПО);
					Команда.Parameters.AddWithValue("ИНН", ИНН);
					Команда.Parameters.AddWithValue("КПП", КПП);
					Команда.Parameters.AddWithValue("ЮрФизЛицо", ЮрФизЛицо.Ключ());
					Команда.Parameters.AddWithValue("ОсновнойБанковскийСчет", ОсновнойБанковскийСчет.Ссылка);
					Команда.Parameters.AddWithValue("ОсновнойДоговорКонтрагента", ОсновнойДоговорКонтрагента.Ссылка);
					Команда.Parameters.AddWithValue("ОсновнойВидДеятельности", ОсновнойВидДеятельности.Ссылка);
					Команда.Parameters.AddWithValue("ДокументУдостоверяющийЛичность", ДокументУдостоверяющийЛичность);
					Команда.Parameters.AddWithValue("ОсновнойМенеджерПокупателя", ОсновнойМенеджерПокупателя.Ссылка);
					Команда.Parameters.AddWithValue("Покупатель", Покупатель);
					Команда.Parameters.AddWithValue("Поставщик", Поставщик);
					Команда.Parameters.AddWithValue("РасписаниеРаботыСтрокой", РасписаниеРаботыСтрокой);
					Команда.Parameters.AddWithValue("СрокВыполненияЗаказаПоставщиком", СрокВыполненияЗаказаПоставщиком);
					Команда.Parameters.AddWithValue("ОсновноеКонтактноеЛицо", ОсновноеКонтактноеЛицо.Ссылка);
					Команда.Parameters.AddWithValue("НеЯвляетсяРезидентом", НеЯвляетсяРезидентом);
					Команда.Parameters.AddWithValue("ОКОПФ", ОКОПФ.Ссылка);
					Команда.Parameters.AddWithValue("Регион", Регион.Ссылка);
					Команда.Parameters.AddWithValue("ГруппаДоступаКонтрагента", ГруппаДоступаКонтрагента.Ссылка);
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
					Команда.CommandText = @"Delete _Reference78
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public void ПриКопировании(/*ОбъектКопирования*/)
		{
			if(true/*НЕ ЭтотОбъект.ЭтоГруппа*/)
			{
				//ЭтотОбъект.ОсновнойДоговорКонтрагента = Неопределено;
				//ЭтотОбъект.ОсновнойБанковскийСчет     = Неопределено;
			}
		}
		// Функция возвращает результат запроса по справочнику контрагентов с заданным головным контрагентом
		//
		// Параметры:
		//  ГоловнойКонтрагент - заданный головной контрагент
		//
		// Возвращаемое значение:
		//  Результат - результат работы запроса
		//

		public object ПолучитьКонтрагентовПоЗаданномуГоловномуКонтрагенту(/*ГоловнойКонтрагент*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("ГоловнойКонтрагент", ГоловнойКонтрагент);
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	Контрагенты.Ссылка КАК Контрагент
	|ИЗ
	|	Справочник.Контрагенты КАК Контрагенты
	|
	|ГДЕ
	|	Контрагенты.ГоловнойКонтрагент = &ГоловнойКонтрагент
	|
	|УПОРЯДОЧИТЬ ПО
	|	Контрагент";*/
			//Результат = Запрос.Выполнить();
			return null;
		}
		// ПолучитьКонтрагентовПоЗаданномуГоловномуКонтрагенту()
		// Процедура - обработчик события "ОбработкаЗаполнения".
		//

		public void ОбработкаЗаполнения(/*Основание*/)
		{
			if(true/*ТипЗнч(Основание) = Тип("СправочникСсылка.Организации")*/)
			{
				//Наименование           = Основание.Наименование;
				//ЮрФизЛицо              = Основание.ЮрФизЛицо;
				//НаименованиеПолное     = Основание.НаименованиеПолное;
				//ОсновнойБанковскийСчет = Основание.ОсновнойБанковскийСчет;
				//ИНН                    = Основание.ИНН;
				//КПП                    = Основание.КПП;
				//КодПоОКПО              = Основание.КодПоОКПО;
				//мОснование             = Основание;
			}
		}
		// ОбработкаЗаполнения()

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*НЕ ОбменДанными.Загрузка*/)
			{
				/*// Проверим основной вид деятельности контрагента
*/
				if(true/*ЗначениеЗаполнено(ОсновнойВидДеятельности) И ВидыДеятельности.Найти(ОсновнойВидДеятельности, "ВидДеятельности") = Неопределено*/)
				{
					//ОсновнойВидДеятельности = Справочники.ВидыДеятельностиКонтрагентов.ПустаяСсылка();
				}
				/*// установим головного контрагента если он не заполнен
*/
				if(true/*НЕ ЭтоГруппа*/)
				{
					if(true/*НЕ ЗначениеЗаполнено(ГоловнойКонтрагент)*/)
					{
						//ГоловнойКонтрагент = Ссылка;
					}
				}
			}
		}

		public void ПриЗаписи(/*Отказ*/)
		{
			if(true/*НЕ ОбменДанными.Загрузка*/)
			{
				if(true/*ЗначениеЗаполнено(ГоловнойКонтрагент) И ГоловнойКонтрагент <> Ссылка*/)
				{
					if(true/*ЗначениеЗаполнено(ГоловнойКонтрагент.ГоловнойКонтрагент) И ГоловнойКонтрагент.ГоловнойКонтрагент <> ГоловнойКонтрагент*/)
					{
						/*ОбщегоНазначения.СообщитьОбОшибке("Контрагент "+СокрЛП(ГоловнойКонтрагент)+" не может быть выбран головным, 
								|так как для него уже был назначен головной контрагент "+СокрЛП(ГоловнойКонтрагент.ГоловнойКонтрагент)+"!");*/
						//Отказ = Истина;
					}
				}
				if(true/*ЗначениеЗаполнено(мОснование)*/)
				{
					//НаборЗаписей = РегистрыСведений.СобственныеКонтрагенты.СоздатьНаборЗаписей();
					//ЗаписьРегистра = НаборЗаписей.Добавить();
					//ЗаписьРегистра.Контрагент = Ссылка;
					//ЗаписьРегистра.ВидСвязи   = Перечисления.ВидыСобственныхКонтрагентов.Организация;
					//ЗаписьРегистра.Объект     = мОснование;
					//НаборЗаписей.Записать(Ложь);
					//мОснование = "";
				}
			}
		}
	}
}