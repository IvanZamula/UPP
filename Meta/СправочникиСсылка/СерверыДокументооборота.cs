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
	public partial class СерверыДокументооборота:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("8d022181-754b-4519-a068-b804f167df60");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012007.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*5*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*150*/ Наименование {get;set;}
		public string/*(255)*/ АдресЭлектроннойПочтыФНС {get;set;}//Адрес электронной почты для документооборота с ФНС
		public decimal/*(5)*/ ДлительностьОжиданияСервера {get;set;}//Длительность ожидания сервера
		public string/*(40)*/ Сертификат {get;set;}
		public string/*(255)*/ АдресЭлектроннойПочтыПФР {get;set;}//Адрес электронной почты для документооборота с ПФР
		public string/*(255)*/ АдресЭлектроннойПочтыФСГС {get;set;}//Адрес электронной почты для документооборота с Росстатом
		
		public СерверыДокументооборота()
		{
		}
		
		public СерверыДокументооборота(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public СерверыДокументооборота(byte[] УникальныйИдентификатор,int Глубина)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23742 [АдресЭлектроннойПочтыФНС]
					,_Fld23743 [ДлительностьОжиданияСервера]
					,_Fld23744 [Сертификат]
					,_Fld23745 [АдресЭлектроннойПочтыПФР]
					,_Fld23746 [АдресЭлектроннойПочтыФСГС]
					From _Reference23126(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  ";
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
							Код = Читалка.GetString(4);
							Наименование = Читалка.GetString(5);
								АдресЭлектроннойПочтыФНС = Читалка.GetString(6);
								ДлительностьОжиданияСервера = Читалка.GetDecimal(7);
								Сертификат = Читалка.GetString(8);
								АдресЭлектроннойПочтыПФР = Читалка.GetString(9);
								АдресЭлектроннойПочтыФСГС = Читалка.GetString(10);
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
		
		public V82.СправочникиОбъект.СерверыДокументооборота  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.СерверыДокументооборота();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.АдресЭлектроннойПочтыФНС = АдресЭлектроннойПочтыФНС;
			Объект.ДлительностьОжиданияСервера = ДлительностьОжиданияСервера;
			Объект.Сертификат = Сертификат;
			Объект.АдресЭлектроннойПочтыПФР = АдресЭлектроннойПочтыПФР;
			Объект.АдресЭлектроннойПочтыФСГС = АдресЭлектроннойПочтыФСГС;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.СерверыДокументооборота ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.СерверыДокументооборота)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.СерверыДокументооборота(УникальныйИдентификатор);
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