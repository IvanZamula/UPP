﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыЛицензийНаПродажуАлкоголя
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"919f66dd-58ea-4d84-91bc-1e78b1189b54\", \"Представление\":\"Пиво\"}")]
		Пиво = 0,//Пиво или пивной напиток 
		[EnumMember(Value = "{\"Ссылка\":\"ad897246-6358-47fd-adb6-fdd2c2652419\", \"Представление\":\"АлкогольнаяПродукция\"}")]
		АлкогольнаяПродукция = 1,//Алкогольная продукция
		[EnumMember(Value = "{\"Ссылка\":\"86994c83-1c81-430c-9515-5d22fb150b9d\", \"Представление\":\"СпиртосодержащаяПищеваяПродукция\"}")]
		СпиртосодержащаяПищеваяПродукция = 2,//Спиртосодержащая пищевая продукция
		[EnumMember(Value = "{\"Ссылка\":\"9a3ddcb9-b275-450b-bcd1-271bc40c7723\", \"Представление\":\"СпиртосодержащаяНеПищеваяПродукция\"}")]
		СпиртосодержащаяНеПищеваяПродукция = 3,//Спиртосодержащая не пищевая продукция
	}
	public static partial class ВидыЛицензийНаПродажуАлкоголя_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Пиво = new Guid("781ebc91-18b1-549b-4d84-58ea919f66dd");//Пиво или пивной напиток 
		public static readonly Guid АлкогольнаяПродукция = new Guid("d2fdb6ad-65c2-1924-47fd-6358ad897246");//Алкогольная продукция
		public static readonly Guid СпиртосодержащаяПищеваяПродукция = new Guid("225d1595-15fb-9d0b-430c-1c8186994c83");//Спиртосодержащая пищевая продукция
		public static readonly Guid СпиртосодержащаяНеПищеваяПродукция = new Guid("1b27d1bc-0cc4-2377-450b-b2759a3ddcb9");//Спиртосодержащая не пищевая продукция
		public static ВидыЛицензийНаПродажуАлкоголя Получить(this ВидыЛицензийНаПродажуАлкоголя Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыЛицензийНаПродажуАлкоголя Получить(this ВидыЛицензийНаПродажуАлкоголя Значение, Guid Ссылка)
		{
			if(Ссылка == Пиво)
			{
				return ВидыЛицензийНаПродажуАлкоголя.Пиво;
			}
			else if(Ссылка == АлкогольнаяПродукция)
			{
				return ВидыЛицензийНаПродажуАлкоголя.АлкогольнаяПродукция;
			}
			else if(Ссылка == СпиртосодержащаяПищеваяПродукция)
			{
				return ВидыЛицензийНаПродажуАлкоголя.СпиртосодержащаяПищеваяПродукция;
			}
			else if(Ссылка == СпиртосодержащаяНеПищеваяПродукция)
			{
				return ВидыЛицензийНаПродажуАлкоголя.СпиртосодержащаяНеПищеваяПродукция;
			}
			return ВидыЛицензийНаПродажуАлкоголя.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыЛицензийНаПродажуАлкоголя Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыЛицензийНаПродажуАлкоголя Значение)
		{
			switch (Значение)
			{
				case ВидыЛицензийНаПродажуАлкоголя.Пиво: return Пиво;
				case ВидыЛицензийНаПродажуАлкоголя.АлкогольнаяПродукция: return АлкогольнаяПродукция;
				case ВидыЛицензийНаПродажуАлкоголя.СпиртосодержащаяПищеваяПродукция: return СпиртосодержащаяПищеваяПродукция;
				case ВидыЛицензийНаПродажуАлкоголя.СпиртосодержащаяНеПищеваяПродукция: return СпиртосодержащаяНеПищеваяПродукция;
			}
			return Guid.Empty;
		}
	}
}