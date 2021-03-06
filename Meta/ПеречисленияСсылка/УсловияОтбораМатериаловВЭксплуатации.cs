﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum УсловияОтбораМатериаловВЭксплуатации
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"9c5aa9b7-06ab-4d05-8291-550091be2046\", \"Представление\":\"СОкончившимсяСрокомЭксплуатации\"}")]
		СОкончившимсяСрокомЭксплуатации = 0,//С окончившимся сроком эксплуатации
		[EnumMember(Value = "{\"Ссылка\":\"b8f763d2-6ba8-4896-9b4d-336a0295a807\", \"Представление\":\"СНеокончившимсяСрокомЭксплуатации\"}")]
		СНеокончившимсяСрокомЭксплуатации = 1,//С неокончившимся сроком эксплуатации
		[EnumMember(Value = "{\"Ссылка\":\"5d6950d8-f5b5-4d2d-9095-35417d70972b\", \"Представление\":\"НаходящимисяВЭксплуатацииБолееМесяцев\"}")]
		НаходящимисяВЭксплуатацииБолееМесяцев = 2,//Находящимися в эксплуатации более ... месяцев
		[EnumMember(Value = "{\"Ссылка\":\"e0924897-4fa4-4ed6-81ec-132f1ac610e3\", \"Представление\":\"НаходящимисяВЭксплуатацииМенееМесяцев\"}")]
		НаходящимисяВЭксплуатацииМенееМесяцев = 3,//Находящимися в эксплуатации менее ... месяцев
		[EnumMember(Value = "{\"Ссылка\":\"cb658bcc-b9e7-40e0-b5fd-fc7e288e765c\", \"Представление\":\"ДоОкончанияСрокаЭксплуатацииМенееМесяцев\"}")]
		ДоОкончанияСрокаЭксплуатацииМенееМесяцев = 4,//До окончания срока эксплуатации осталось менее ... месяцев
		[EnumMember(Value = "{\"Ссылка\":\"bf90c442-7137-4203-a111-56ffca9a56bc\", \"Представление\":\"ДоОкончанияСрокаЭксплуатацииБолееМесяцев\"}")]
		ДоОкончанияСрокаЭксплуатацииБолееМесяцев = 5,//До окончания срока эксплуатации осталось более ... месяцев
		[EnumMember(Value = "{\"Ссылка\":\"7f02fb4f-6aba-4a97-adfc-38d6c38581bb\", \"Представление\":\"МОЛ\"}")]
		МОЛ = 6,
	}
	public static partial class УсловияОтбораМатериаловВЭксплуатации_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СОкончившимсяСрокомЭксплуатации = new Guid("00559182-be91-4620-4d05-06ab9c5aa9b7");//С окончившимся сроком эксплуатации
		public static readonly Guid СНеокончившимсяСрокомЭксплуатации = new Guid("6a334d9b-9502-07a8-4896-6ba8b8f763d2");//С неокончившимся сроком эксплуатации
		public static readonly Guid НаходящимисяВЭксплуатацииБолееМесяцев = new Guid("41359590-707d-2b97-4d2d-f5b55d6950d8");//Находящимися в эксплуатации более ... месяцев
		public static readonly Guid НаходящимисяВЭксплуатацииМенееМесяцев = new Guid("2f13ec81-c61a-e310-4ed6-4fa4e0924897");//Находящимися в эксплуатации менее ... месяцев
		public static readonly Guid ДоОкончанияСрокаЭксплуатацииМенееМесяцев = new Guid("7efcfdb5-8e28-5c76-40e0-b9e7cb658bcc");//До окончания срока эксплуатации осталось менее ... месяцев
		public static readonly Guid ДоОкончанияСрокаЭксплуатацииБолееМесяцев = new Guid("ff5611a1-9aca-bc56-4203-7137bf90c442");//До окончания срока эксплуатации осталось более ... месяцев
		public static readonly Guid МОЛ = new Guid("d638fcad-85c3-bb81-4a97-6aba7f02fb4f");
		public static УсловияОтбораМатериаловВЭксплуатации Получить(this УсловияОтбораМатериаловВЭксплуатации Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static УсловияОтбораМатериаловВЭксплуатации Получить(this УсловияОтбораМатериаловВЭксплуатации Значение, Guid Ссылка)
		{
			if(Ссылка == СОкончившимсяСрокомЭксплуатации)
			{
				return УсловияОтбораМатериаловВЭксплуатации.СОкончившимсяСрокомЭксплуатации;
			}
			else if(Ссылка == СНеокончившимсяСрокомЭксплуатации)
			{
				return УсловияОтбораМатериаловВЭксплуатации.СНеокончившимсяСрокомЭксплуатации;
			}
			else if(Ссылка == НаходящимисяВЭксплуатацииБолееМесяцев)
			{
				return УсловияОтбораМатериаловВЭксплуатации.НаходящимисяВЭксплуатацииБолееМесяцев;
			}
			else if(Ссылка == НаходящимисяВЭксплуатацииМенееМесяцев)
			{
				return УсловияОтбораМатериаловВЭксплуатации.НаходящимисяВЭксплуатацииМенееМесяцев;
			}
			else if(Ссылка == ДоОкончанияСрокаЭксплуатацииМенееМесяцев)
			{
				return УсловияОтбораМатериаловВЭксплуатации.ДоОкончанияСрокаЭксплуатацииМенееМесяцев;
			}
			else if(Ссылка == ДоОкончанияСрокаЭксплуатацииБолееМесяцев)
			{
				return УсловияОтбораМатериаловВЭксплуатации.ДоОкончанияСрокаЭксплуатацииБолееМесяцев;
			}
			else if(Ссылка == МОЛ)
			{
				return УсловияОтбораМатериаловВЭксплуатации.МОЛ;
			}
			return УсловияОтбораМатериаловВЭксплуатации.ПустаяСсылка;
		}
		public static byte[] Ключ(this УсловияОтбораМатериаловВЭксплуатации Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this УсловияОтбораМатериаловВЭксплуатации Значение)
		{
			switch (Значение)
			{
				case УсловияОтбораМатериаловВЭксплуатации.СОкончившимсяСрокомЭксплуатации: return СОкончившимсяСрокомЭксплуатации;
				case УсловияОтбораМатериаловВЭксплуатации.СНеокончившимсяСрокомЭксплуатации: return СНеокончившимсяСрокомЭксплуатации;
				case УсловияОтбораМатериаловВЭксплуатации.НаходящимисяВЭксплуатацииБолееМесяцев: return НаходящимисяВЭксплуатацииБолееМесяцев;
				case УсловияОтбораМатериаловВЭксплуатации.НаходящимисяВЭксплуатацииМенееМесяцев: return НаходящимисяВЭксплуатацииМенееМесяцев;
				case УсловияОтбораМатериаловВЭксплуатации.ДоОкончанияСрокаЭксплуатацииМенееМесяцев: return ДоОкончанияСрокаЭксплуатацииМенееМесяцев;
				case УсловияОтбораМатериаловВЭксплуатации.ДоОкончанияСрокаЭксплуатацииБолееМесяцев: return ДоОкончанияСрокаЭксплуатацииБолееМесяцев;
				case УсловияОтбораМатериаловВЭксплуатации.МОЛ: return МОЛ;
			}
			return Guid.Empty;
		}
	}
}