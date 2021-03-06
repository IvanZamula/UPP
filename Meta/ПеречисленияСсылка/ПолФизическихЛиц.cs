﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum ПолФизическихЛиц
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"7f241253-8e14-4077-a67f-4b1ffa2ace25\", \"Представление\":\"Мужской\"}")]
		Мужской = 0,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"40a3ad5b-aeea-4c8f-924d-11f868bd95e0\", \"Представление\":\"Женский\"}")]
		Женский = 1,
	}
	public static partial class ПолФизическихЛиц_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Мужской = new Guid("1f4b7fa6-2afa-25ce-4077-8e147f241253");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Женский = new Guid("f8114d92-bd68-e095-4c8f-aeea40a3ad5b");
		public static ПолФизическихЛиц Получить(this ПолФизическихЛиц Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПолФизическихЛиц Получить(this ПолФизическихЛиц Значение, Guid Ссылка)
		{
			if(Ссылка == Мужской)
			{
				return ПолФизическихЛиц.Мужской;
			}
			else if(Ссылка == Женский)
			{
				return ПолФизическихЛиц.Женский;
			}
			return ПолФизическихЛиц.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПолФизическихЛиц Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПолФизическихЛиц Значение)
		{
			switch (Значение)
			{
				case ПолФизическихЛиц.Мужской: return Мужской;
				case ПолФизическихЛиц.Женский: return Женский;
			}
			return Guid.Empty;
		}
	}
}