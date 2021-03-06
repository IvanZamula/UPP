﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Упр)
	///</summary>
	[DataContract]
	public enum СтадииВзаимоотношенийСПокупателями
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"59116f1e-54ad-4b72-9245-fe91f8aea102\", \"Представление\":\"ПотенциальныйПокупатель\"}")]
		ПотенциальныйПокупатель = 0,//Потенциальный покупатель
		[EnumMember(Value = "{\"Ссылка\":\"444e6214-600b-4247-8ee7-c43085ea94d7\", \"Представление\":\"РазовыйПокупатель\"}")]
		РазовыйПокупатель = 1,//Разовый покупатель
		[EnumMember(Value = "{\"Ссылка\":\"045171f2-378c-468b-808e-84263ded1d27\", \"Представление\":\"ПостоянныйПокупатель\"}")]
		ПостоянныйПокупатель = 2,//Постоянный покупатель
		[EnumMember(Value = "{\"Ссылка\":\"f77da32b-5b01-4d56-a738-768b14270e6b\", \"Представление\":\"ПотерянныйПокупатель\"}")]
		ПотерянныйПокупатель = 3,//Потерянный покупатель
	}
	public static partial class СтадииВзаимоотношенийСПокупателями_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПотенциальныйПокупатель = new Guid("91fe4592-aef8-02a1-4b72-54ad59116f1e");//Потенциальный покупатель
		public static readonly Guid РазовыйПокупатель = new Guid("30c4e78e-ea85-d794-4247-600b444e6214");//Разовый покупатель
		public static readonly Guid ПостоянныйПокупатель = new Guid("26848e80-ed3d-271d-468b-378c045171f2");//Постоянный покупатель
		public static readonly Guid ПотерянныйПокупатель = new Guid("8b7638a7-2714-6b0e-4d56-5b01f77da32b");//Потерянный покупатель
		public static СтадииВзаимоотношенийСПокупателями Получить(this СтадииВзаимоотношенийСПокупателями Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СтадииВзаимоотношенийСПокупателями Получить(this СтадииВзаимоотношенийСПокупателями Значение, Guid Ссылка)
		{
			if(Ссылка == ПотенциальныйПокупатель)
			{
				return СтадииВзаимоотношенийСПокупателями.ПотенциальныйПокупатель;
			}
			else if(Ссылка == РазовыйПокупатель)
			{
				return СтадииВзаимоотношенийСПокупателями.РазовыйПокупатель;
			}
			else if(Ссылка == ПостоянныйПокупатель)
			{
				return СтадииВзаимоотношенийСПокупателями.ПостоянныйПокупатель;
			}
			else if(Ссылка == ПотерянныйПокупатель)
			{
				return СтадииВзаимоотношенийСПокупателями.ПотерянныйПокупатель;
			}
			return СтадииВзаимоотношенийСПокупателями.ПустаяСсылка;
		}
		public static byte[] Ключ(this СтадииВзаимоотношенийСПокупателями Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СтадииВзаимоотношенийСПокупателями Значение)
		{
			switch (Значение)
			{
				case СтадииВзаимоотношенийСПокупателями.ПотенциальныйПокупатель: return ПотенциальныйПокупатель;
				case СтадииВзаимоотношенийСПокупателями.РазовыйПокупатель: return РазовыйПокупатель;
				case СтадииВзаимоотношенийСПокупателями.ПостоянныйПокупатель: return ПостоянныйПокупатель;
				case СтадииВзаимоотношенийСПокупателями.ПотерянныйПокупатель: return ПотерянныйПокупатель;
			}
			return Guid.Empty;
		}
	}
}