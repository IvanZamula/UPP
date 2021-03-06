﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Регл)
	///</summary>
	[DataContract]
	public enum НДФЛСтавкиНалогообложенияРезидента
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"26110db6-f218-405f-b769-67bdabea2946\", \"Представление\":\"Ставка09\"}")]
		Ставка09 = 0,//9% (30%, 15%)
		[EnumMember(Value = "{\"Ссылка\":\"4798ce86-2297-486b-a614-612ccd6e93a7\", \"Представление\":\"Ставка13\"}")]
		Ставка13 = 1,//13% (30%)
		[EnumMember(Value = "{\"Ссылка\":\"341c20d6-c04a-4ae2-922d-c66d0c9a4669\", \"Представление\":\"Ставка35\"}")]
		Ставка35 = 2,//35% (30%)
	}
	public static partial class НДФЛСтавкиНалогообложенияРезидента_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Ставка09 = new Guid("bd6769b7-eaab-4629-405f-f21826110db6");//9% (30%, 15%)
		public static readonly Guid Ставка13 = new Guid("2c6114a6-6ecd-a793-486b-22974798ce86");//13% (30%)
		public static readonly Guid Ставка35 = new Guid("6dc62d92-9a0c-6946-4ae2-c04a341c20d6");//35% (30%)
		public static НДФЛСтавкиНалогообложенияРезидента Получить(this НДФЛСтавкиНалогообложенияРезидента Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static НДФЛСтавкиНалогообложенияРезидента Получить(this НДФЛСтавкиНалогообложенияРезидента Значение, Guid Ссылка)
		{
			if(Ссылка == Ставка09)
			{
				return НДФЛСтавкиНалогообложенияРезидента.Ставка09;
			}
			else if(Ссылка == Ставка13)
			{
				return НДФЛСтавкиНалогообложенияРезидента.Ставка13;
			}
			else if(Ссылка == Ставка35)
			{
				return НДФЛСтавкиНалогообложенияРезидента.Ставка35;
			}
			return НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка;
		}
		public static byte[] Ключ(this НДФЛСтавкиНалогообложенияРезидента Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this НДФЛСтавкиНалогообложенияРезидента Значение)
		{
			switch (Значение)
			{
				case НДФЛСтавкиНалогообложенияРезидента.Ставка09: return Ставка09;
				case НДФЛСтавкиНалогообложенияРезидента.Ставка13: return Ставка13;
				case НДФЛСтавкиНалогообложенияРезидента.Ставка35: return Ставка35;
			}
			return Guid.Empty;
		}
	}
}