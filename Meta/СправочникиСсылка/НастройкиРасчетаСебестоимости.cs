﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class НастройкиРасчетаСебестоимости:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("00093a0e-bee2-408a-8995-cd1f5efe314b");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012005.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public bool Предопределенный {get;set;}
		public V82.СправочникиСсылка.НастройкиРасчетаСебестоимости Родитель {get;set;}
		public bool ЭтоГруппа {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*100*/ Наименование {get;set;}
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public V82.СправочникиСсылка.НастройкиЗакрытияМесяца НастройкаЗакрытияМесяца {get;set;}//Настройка закрытия месяца
		public V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете ВидОтраженияВУчете {get;set;}//Вид отражения в учете
		///<summary>
		///Формировать документы автоматически (регламентным заданием)
		///</summary>
		public bool ФормироватьДокументыАвтоматически {get;set;}//Формировать документы автоматически
		///<summary>
		///Уникальный идентификатор регламентного задания
		///</summary>
		public string/*(36)*/ РегламентноеЗадание {get;set;}//Регламентное задание
		///<summary>
		///Количество месяцев, на которое дата проводимого документа меньше текущей даты
		///</summary>
		public decimal/*(2)*/ Задержка {get;set;}
		public string/*(0)*/ Комментарий {get;set;}
		
		public НастройкиРасчетаСебестоимости()
		{
		}
		
		public НастройкиРасчетаСебестоимости(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public НастройкиРасчетаСебестоимости(byte[] УникальныйИдентификатор,int Глубина)
		{
			if (Глубина>3)
			{
				return;
			}
			if (new Guid(УникальныйИдентификатор) == Guid.Empty)
			{
				return;
			}
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
					,_Fld23602RRef [Организация]
					,_Fld23603RRef [НастройкаЗакрытияМесяца]
					,_Fld23604RRef [ВидОтраженияВУчете]
					,_Fld23605 [ФормироватьДокументыАвтоматически]
					,_Fld23606 [РегламентноеЗадание]
					,_Fld23607 [Задержка]
					,_Fld23608 [Комментарий]
					From _Reference23110(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  -- and _Folder = 0x01  ";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Родитель = new V82.СправочникиСсылка.НастройкиРасчетаСебестоимости((byte[])Читалка.GetValue(4),Глубина+1);
							ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Наименование = Читалка.GetString(6);
							if(!ЭтоГруппа)
							{
								Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7),Глубина+1);
								НастройкаЗакрытияМесяца = new V82.СправочникиСсылка.НастройкиЗакрытияМесяца((byte[])Читалка.GetValue(8),Глубина+1);
								ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
								ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(10))[0]==1;
								РегламентноеЗадание = Читалка.GetString(11);
								Задержка = Читалка.GetDecimal(12);
								Комментарий = Читалка.GetString(13);
							}
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.СправочникиОбъект.НастройкиРасчетаСебестоимости  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиРасчетаСебестоимости();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Родитель = Родитель;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Наименование = Наименование;
			Объект.Организация = Организация;
			Объект.НастройкаЗакрытияМесяца = НастройкаЗакрытияМесяца;
			Объект.ВидОтраженияВУчете = ВидОтраженияВУчете;
			Объект.ФормироватьДокументыАвтоматически = ФормироватьДокументыАвтоматически;
			Объект.РегламентноеЗадание = РегламентноеЗадание;
			Объект.Задержка = Задержка;
			Объект.Комментарий = Комментарий;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.НастройкиРасчетаСебестоимости ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.НастройкиРасчетаСебестоимости)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.НастройкиРасчетаСебестоимости(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}