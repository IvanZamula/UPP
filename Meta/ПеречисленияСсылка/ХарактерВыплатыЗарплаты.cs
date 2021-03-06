﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ХарактерВыплатыЗарплаты
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"b8e15f46-18ab-43c5-9d29-1a481b7af718\", \"Представление\":\"Зарплата\"}")]
		Зарплата = 0,
		[EnumMember(Value = "{\"Ссылка\":\"b238960e-5d60-458f-ad17-dfc84e55d4aa\", \"Представление\":\"ПлановыйАванс\"}")]
		ПлановыйАванс = 1,//Плановый аванс
		[EnumMember(Value = "{\"Ссылка\":\"1f0f503f-f17c-441e-bd60-68da6a11ebee\", \"Представление\":\"АвансЗаПервуюПоловинуМесяца\"}")]
		АвансЗаПервуюПоловинуМесяца = 2,//Аванс по расчету за первую половину месяца
		[EnumMember(Value = "{\"Ссылка\":\"989a9300-bd4d-42b0-89d3-c11b7be6b749\", \"Представление\":\"ПоБольничнымЛистам\"}")]
		ПоБольничнымЛистам = 3,//Пособия по больничным листам
		[EnumMember(Value = "{\"Ссылка\":\"6121e875-bbef-49f5-bf98-30efe72108ce\", \"Представление\":\"ПоБеременностиИРодам\"}")]
		ПоБеременностиИРодам = 4,//Отпуск по беременности и родам
		[EnumMember(Value = "{\"Ссылка\":\"e2f82212-f4ac-46c3-a984-3bb512d55851\", \"Представление\":\"Отпускные\"}")]
		Отпускные = 5,
		[EnumMember(Value = "{\"Ссылка\":\"af46dbde-c895-41ee-82bc-da2a610a0266\", \"Представление\":\"Командировочные\"}")]
		Командировочные = 6,
		[EnumMember(Value = "{\"Ссылка\":\"3ac549b0-c2ad-4a54-ac62-002af31d5c8a\", \"Представление\":\"Премии\"}")]
		Премии = 7,
		[EnumMember(Value = "{\"Ссылка\":\"75aeca61-0baa-4988-92de-6d70c95326b5\", \"Представление\":\"РасчетПриУвольнении\"}")]
		РасчетПриУвольнении = 8,//Расчет при увольнении
		[EnumMember(Value = "{\"Ссылка\":\"78660c35-6b8d-4e8e-8196-7099ceedeade\", \"Представление\":\"Дивиденды\"}")]
		Дивиденды = 9,//Начисленные дивиденды
		[EnumMember(Value = "{\"Ссылка\":\"21a8a9f2-4dd6-4819-ad9f-57f57455e320\", \"Представление\":\"ПрочиеРазовыеНачисления\"}")]
		ПрочиеРазовыеНачисления = 10,//Прочие разовые начисления
		[EnumMember(Value = "{\"Ссылка\":\"ebd4b6bf-9471-4034-899f-0619595ade6c\", \"Представление\":\"ПособияФСС\"}")]
		ПособияФСС = 11,//Единовременные пособия за счет ФСС
		[EnumMember(Value = "{\"Ссылка\":\"97918a52-ede3-41ae-9692-f18fdf9720b0\", \"Представление\":\"ВозвратНДФЛ\"}")]
		ВозвратНДФЛ = 12,//Возврат НДФЛ
		[EnumMember(Value = "{\"Ссылка\":\"b52e0de8-fb4d-4ebb-a7df-c6f5b3cf820f\", \"Представление\":\"Задолженность\"}")]
		Задолженность = 13,
	}
	public static partial class ХарактерВыплатыЗарплаты_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Зарплата = new Guid("481a299d-7a1b-18f7-43c5-18abb8e15f46");
		public static readonly Guid ПлановыйАванс = new Guid("c8df17ad-554e-aad4-458f-5d60b238960e");//Плановый аванс
		public static readonly Guid АвансЗаПервуюПоловинуМесяца = new Guid("da6860bd-116a-eeeb-441e-f17c1f0f503f");//Аванс по расчету за первую половину месяца
		public static readonly Guid ПоБольничнымЛистам = new Guid("1bc1d389-e67b-49b7-42b0-bd4d989a9300");//Пособия по больничным листам
		public static readonly Guid ПоБеременностиИРодам = new Guid("ef3098bf-21e7-ce08-49f5-bbef6121e875");//Отпуск по беременности и родам
		public static readonly Guid Отпускные = new Guid("b53b84a9-d512-5158-46c3-f4ace2f82212");
		public static readonly Guid Командировочные = new Guid("2adabc82-0a61-6602-41ee-c895af46dbde");
		public static readonly Guid Премии = new Guid("2a0062ac-1df3-8a5c-4a54-c2ad3ac549b0");
		public static readonly Guid РасчетПриУвольнении = new Guid("706dde92-53c9-b526-4988-0baa75aeca61");//Расчет при увольнении
		public static readonly Guid Дивиденды = new Guid("99709681-edce-deea-4e8e-6b8d78660c35");//Начисленные дивиденды
		public static readonly Guid ПрочиеРазовыеНачисления = new Guid("f5579fad-5574-20e3-4819-4dd621a8a9f2");//Прочие разовые начисления
		public static readonly Guid ПособияФСС = new Guid("19069f89-5a59-6cde-4034-9471ebd4b6bf");//Единовременные пособия за счет ФСС
		public static readonly Guid ВозвратНДФЛ = new Guid("8ff19296-97df-b020-41ae-ede397918a52");//Возврат НДФЛ
		public static readonly Guid Задолженность = new Guid("f5c6dfa7-cfb3-0f82-4ebb-fb4db52e0de8");
		public static ХарактерВыплатыЗарплаты Получить(this ХарактерВыплатыЗарплаты Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ХарактерВыплатыЗарплаты Получить(this ХарактерВыплатыЗарплаты Значение, Guid Ссылка)
		{
			if(Ссылка == Зарплата)
			{
				return ХарактерВыплатыЗарплаты.Зарплата;
			}
			else if(Ссылка == ПлановыйАванс)
			{
				return ХарактерВыплатыЗарплаты.ПлановыйАванс;
			}
			else if(Ссылка == АвансЗаПервуюПоловинуМесяца)
			{
				return ХарактерВыплатыЗарплаты.АвансЗаПервуюПоловинуМесяца;
			}
			else if(Ссылка == ПоБольничнымЛистам)
			{
				return ХарактерВыплатыЗарплаты.ПоБольничнымЛистам;
			}
			else if(Ссылка == ПоБеременностиИРодам)
			{
				return ХарактерВыплатыЗарплаты.ПоБеременностиИРодам;
			}
			else if(Ссылка == Отпускные)
			{
				return ХарактерВыплатыЗарплаты.Отпускные;
			}
			else if(Ссылка == Командировочные)
			{
				return ХарактерВыплатыЗарплаты.Командировочные;
			}
			else if(Ссылка == Премии)
			{
				return ХарактерВыплатыЗарплаты.Премии;
			}
			else if(Ссылка == РасчетПриУвольнении)
			{
				return ХарактерВыплатыЗарплаты.РасчетПриУвольнении;
			}
			else if(Ссылка == Дивиденды)
			{
				return ХарактерВыплатыЗарплаты.Дивиденды;
			}
			else if(Ссылка == ПрочиеРазовыеНачисления)
			{
				return ХарактерВыплатыЗарплаты.ПрочиеРазовыеНачисления;
			}
			else if(Ссылка == ПособияФСС)
			{
				return ХарактерВыплатыЗарплаты.ПособияФСС;
			}
			else if(Ссылка == ВозвратНДФЛ)
			{
				return ХарактерВыплатыЗарплаты.ВозвратНДФЛ;
			}
			else if(Ссылка == Задолженность)
			{
				return ХарактерВыплатыЗарплаты.Задолженность;
			}
			return ХарактерВыплатыЗарплаты.ПустаяСсылка;
		}
		public static byte[] Ключ(this ХарактерВыплатыЗарплаты Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ХарактерВыплатыЗарплаты Значение)
		{
			switch (Значение)
			{
				case ХарактерВыплатыЗарплаты.Зарплата: return Зарплата;
				case ХарактерВыплатыЗарплаты.ПлановыйАванс: return ПлановыйАванс;
				case ХарактерВыплатыЗарплаты.АвансЗаПервуюПоловинуМесяца: return АвансЗаПервуюПоловинуМесяца;
				case ХарактерВыплатыЗарплаты.ПоБольничнымЛистам: return ПоБольничнымЛистам;
				case ХарактерВыплатыЗарплаты.ПоБеременностиИРодам: return ПоБеременностиИРодам;
				case ХарактерВыплатыЗарплаты.Отпускные: return Отпускные;
				case ХарактерВыплатыЗарплаты.Командировочные: return Командировочные;
				case ХарактерВыплатыЗарплаты.Премии: return Премии;
				case ХарактерВыплатыЗарплаты.РасчетПриУвольнении: return РасчетПриУвольнении;
				case ХарактерВыплатыЗарплаты.Дивиденды: return Дивиденды;
				case ХарактерВыплатыЗарплаты.ПрочиеРазовыеНачисления: return ПрочиеРазовыеНачисления;
				case ХарактерВыплатыЗарплаты.ПособияФСС: return ПособияФСС;
				case ХарактерВыплатыЗарплаты.ВозвратНДФЛ: return ВозвратНДФЛ;
				case ХарактерВыплатыЗарплаты.Задолженность: return Задолженность;
			}
			return Guid.Empty;
		}
	}
}