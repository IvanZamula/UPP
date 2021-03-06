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
	public enum ВариантыАвтоподбораНоменклатуры
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"035027a5-b75c-4e93-a86e-ccc5b51bcd8f\", \"Представление\":\"ПолучитьИзСвойства\"}")]
		ПолучитьИзСвойства = 0,//Получить из свойства
		[EnumMember(Value = "{\"Ссылка\":\"5430ec2d-ffed-48b3-949b-3d38a2b6df9c\", \"Представление\":\"УказываетсяДляСвойства\"}")]
		УказываетсяДляСвойства = 1,//Указывается для свойства
	}
	public static partial class ВариантыАвтоподбораНоменклатуры_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПолучитьИзСвойства = new Guid("c5cc6ea8-1bb5-8fcd-4e93-b75c035027a5");//Получить из свойства
		public static readonly Guid УказываетсяДляСвойства = new Guid("383d9b94-b6a2-9cdf-48b3-ffed5430ec2d");//Указывается для свойства
		public static ВариантыАвтоподбораНоменклатуры Получить(this ВариантыАвтоподбораНоменклатуры Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВариантыАвтоподбораНоменклатуры Получить(this ВариантыАвтоподбораНоменклатуры Значение, Guid Ссылка)
		{
			if(Ссылка == ПолучитьИзСвойства)
			{
				return ВариантыАвтоподбораНоменклатуры.ПолучитьИзСвойства;
			}
			else if(Ссылка == УказываетсяДляСвойства)
			{
				return ВариантыАвтоподбораНоменклатуры.УказываетсяДляСвойства;
			}
			return ВариантыАвтоподбораНоменклатуры.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВариантыАвтоподбораНоменклатуры Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВариантыАвтоподбораНоменклатуры Значение)
		{
			switch (Значение)
			{
				case ВариантыАвтоподбораНоменклатуры.ПолучитьИзСвойства: return ПолучитьИзСвойства;
				case ВариантыАвтоподбораНоменклатуры.УказываетсяДляСвойства: return УказываетсяДляСвойства;
			}
			return Guid.Empty;
		}
	}
}