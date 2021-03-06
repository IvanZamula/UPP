﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"a7440c1d-c7d1-4436-87f3-f0948f36cc0e\", \"Представление\":\"АвтоматическиПередФормированиемОтчета\"}")]
		АвтоматическиПередФормированиемОтчета = 0,//Автоматически перед формированием отчета
		[EnumMember(Value = "{\"Ссылка\":\"679d7bfc-0365-4dba-acba-e5b84bfa9f23\", \"Представление\":\"АвтоматическиПослеФормированияОтчета\"}")]
		АвтоматическиПослеФормированияОтчета = 1,//Автоматически после формирования отчета
		[EnumMember(Value = "{\"Ссылка\":\"15093523-1d1e-4687-84f8-a7aee1ca7398\", \"Представление\":\"Вручную\"}")]
		Вручную = 2,
	}
	public static partial class СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid АвтоматическиПередФормированиемОтчета = new Guid("94f0f387-368f-0ecc-4436-c7d1a7440c1d");//Автоматически перед формированием отчета
		public static readonly Guid АвтоматическиПослеФормированияОтчета = new Guid("b8e5baac-fa4b-239f-4dba-0365679d7bfc");//Автоматически после формирования отчета
		public static readonly Guid Вручную = new Guid("aea7f884-cae1-9873-4687-1d1e15093523");
		public static СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального Получить(this СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального Получить(this СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального Значение, Guid Ссылка)
		{
			if(Ссылка == АвтоматическиПередФормированиемОтчета)
			{
				return СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального.АвтоматическиПередФормированиемОтчета;
			}
			else if(Ссылка == АвтоматическиПослеФормированияОтчета)
			{
				return СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального.АвтоматическиПослеФормированияОтчета;
			}
			else if(Ссылка == Вручную)
			{
				return СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального.Вручную;
			}
			return СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального Значение)
		{
			switch (Значение)
			{
				case СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального.АвтоматическиПередФормированиемОтчета: return АвтоматическиПередФормированиемОтчета;
				case СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального.АвтоматическиПослеФормированияОтчета: return АвтоматическиПослеФормированияОтчета;
				case СпособыЗапускаВнешнихОбработокВОтчетахНаБазеУниверсального.Вручную: return Вручную;
			}
			return Guid.Empty;
		}
	}
}