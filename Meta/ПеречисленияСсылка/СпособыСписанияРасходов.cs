﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum СпособыСписанияРасходов
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"8ed0d760-ede2-4270-aab0-c5a2458b798b\", \"Представление\":\"ИспользоватьНазначениеИспользования\"}")]
		ИспользоватьНазначениеИспользования = 0,//Использовать назначение использования
		[EnumMember(Value = "{\"Ссылка\":\"da76841f-f247-46e8-b72e-a65a0eb668e5\", \"Представление\":\"ИспользоватьСтатьюЗатратДокумента\"}")]
		ИспользоватьСтатьюЗатратДокумента = 1,//Использовать статью затрат документа
	}
	public static partial class СпособыСписанияРасходов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ИспользоватьНазначениеИспользования = new Guid("a2c5b0aa-8b45-8b79-4270-ede28ed0d760");//Использовать назначение использования
		public static readonly Guid ИспользоватьСтатьюЗатратДокумента = new Guid("5aa62eb7-b60e-e568-46e8-f247da76841f");//Использовать статью затрат документа
		public static СпособыСписанияРасходов Получить(this СпособыСписанияРасходов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыСписанияРасходов Получить(this СпособыСписанияРасходов Значение, Guid Ссылка)
		{
			if(Ссылка == ИспользоватьНазначениеИспользования)
			{
				return СпособыСписанияРасходов.ИспользоватьНазначениеИспользования;
			}
			else if(Ссылка == ИспользоватьСтатьюЗатратДокумента)
			{
				return СпособыСписанияРасходов.ИспользоватьСтатьюЗатратДокумента;
			}
			return СпособыСписанияРасходов.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыСписанияРасходов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыСписанияРасходов Значение)
		{
			switch (Значение)
			{
				case СпособыСписанияРасходов.ИспользоватьНазначениеИспользования: return ИспользоватьНазначениеИспользования;
				case СпособыСписанияРасходов.ИспользоватьСтатьюЗатратДокумента: return ИспользоватьСтатьюЗатратДокумента;
			}
			return Guid.Empty;
		}
	}
}