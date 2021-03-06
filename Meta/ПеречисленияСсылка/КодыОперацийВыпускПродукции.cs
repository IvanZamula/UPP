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
	public enum КодыОперацийВыпускПродукции
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"bec63613-5362-46bf-8ee2-adc437ccaaf8\", \"Представление\":\"ВозвратМатериаловИзПроизводстваРасч\"}")]
		ВозвратМатериаловИзПроизводстваРасч = 0,//Возврат материалов из производства по расчетной стоимости
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"b71d0ceb-cb2e-42bc-a346-fff5ad428245\", \"Представление\":\"ВыпускПродукцииПоФиксированнойСтоимости\"}")]
		ВыпускПродукцииПоФиксированнойСтоимости = 1,//Выпуск продукции по фиксированной стоимости
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"6aec3dfd-d927-42af-a155-36b7b59a1d57\", \"Представление\":\"ВыпускПродукцииФиксВнешниеУслуги\"}")]
		ВыпускПродукцииФиксВнешниеУслуги = 2,//Выпуск продукции фикс (внешние услуги)
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"5af7367f-d033-4f4f-bd62-052b2e5b271f\", \"Представление\":\"ВыпускПродукцииФиксВнутрУслугиНаПостЗатраты\"}")]
		ВыпускПродукцииФиксВнутрУслугиНаПостЗатраты = 3,//Выпуск продукции фикс (внутр. услуги на постоянные затраты)
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"68910de2-1cf6-41d6-989b-c4ee182afaa9\", \"Представление\":\"ВыпускПродукцииФиксВнутрУслугиНаПроизводство\"}")]
		ВыпускПродукцииФиксВнутрУслугиНаПроизводство = 4,//Выпуск продукции фикс (внутр. услуги на производство)
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"c8aa55d8-e5fe-4304-a0d0-f61b93c96bc9\", \"Представление\":\"ВыпускПродукцииФиксВнутрУслугиНаСчет\"}")]
		ВыпускПродукцииФиксВнутрУслугиНаСчет = 5,//Выпуск продукции фикс (внутр. услуги на счета бух.учета)
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"478be3ee-57c3-421e-a77b-7ab8c6babc78\", \"Представление\":\"ВыпускПродукцииФиксНаСклад\"}")]
		ВыпускПродукцииФиксНаСклад = 6,//Выпуск продукции фикс. (на склад)
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"31fada0c-539c-48ea-b4a9-e037187e03c9\", \"Представление\":\"СписаниеНЗП\"}")]
		СписаниеНЗП = 7,//Списание НЗП
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"14b61ab7-f7fb-4cad-949a-c8f1c6efe8cc\", \"Представление\":\"ФормированиеФактСебестоимости\"}")]
		ФормированиеФактСебестоимости = 8,//Формирование фактической себестоимости
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"b511ec17-17ac-4f73-a404-1164287443e8\", \"Представление\":\"ОприходованиеНЗП\"}")]
		ОприходованиеНЗП = 9,//Оприходование НЗП
		[EnumMember(Value = "{\"Ссылка\":\"0019f34b-48e4-4ff9-842b-b7cc02066b6b\", \"Представление\":\"КорректировкаНЗПРасч\"}")]
		КорректировкаНЗПРасч = 10,//Корректировка незавершенного производства по расчетной стоимости
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"cb0c1f7e-0bc6-4f84-88c3-c8d4b024616b\", \"Представление\":\"ВозвратМатериаловИзПроизводстваФикс\"}")]
		ВозвратМатериаловИзПроизводстваФикс = 11,//Возврат материалов из производства по фиксированной стоимости
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"fe3f720b-d20a-44f0-b043-6c08f8cece75\", \"Представление\":\"СписаниеНЗПФикс\"}")]
		СписаниеНЗПФикс = 12,//Списание НЗП по фиксированной стоимости
		[EnumMember(Value = "{\"Ссылка\":\"a3760a75-a547-4145-8cd5-c0a68e3730a8\", \"Представление\":\"КорректировкаНЗПФикс\"}")]
		КорректировкаНЗПФикс = 13,//Корректировка незавершенного производства по фиксированной стоимости
	}
	public static partial class КодыОперацийВыпускПродукции_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратМатериаловИзПроизводстваРасч = new Guid("c4ade28e-cc37-f8aa-46bf-5362bec63613");//Возврат материалов из производства по расчетной стоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыпускПродукцииПоФиксированнойСтоимости = new Guid("f5ff46a3-42ad-4582-42bc-cb2eb71d0ceb");//Выпуск продукции по фиксированной стоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыпускПродукцииФиксВнешниеУслуги = new Guid("b73655a1-9ab5-571d-42af-d9276aec3dfd");//Выпуск продукции фикс (внешние услуги)
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыпускПродукцииФиксВнутрУслугиНаПостЗатраты = new Guid("2b0562bd-5b2e-1f27-4f4f-d0335af7367f");//Выпуск продукции фикс (внутр. услуги на постоянные затраты)
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыпускПродукцииФиксВнутрУслугиНаПроизводство = new Guid("eec49b98-2a18-a9fa-41d6-1cf668910de2");//Выпуск продукции фикс (внутр. услуги на производство)
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыпускПродукцииФиксВнутрУслугиНаСчет = new Guid("1bf6d0a0-c993-c96b-4304-e5fec8aa55d8");//Выпуск продукции фикс (внутр. услуги на счета бух.учета)
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыпускПродукцииФиксНаСклад = new Guid("b87a7ba7-bac6-78bc-421e-57c3478be3ee");//Выпуск продукции фикс. (на склад)
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеНЗП = new Guid("37e0a9b4-7e18-c903-48ea-539c31fada0c");//Списание НЗП
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ФормированиеФактСебестоимости = new Guid("f1c89a94-efc6-cce8-4cad-f7fb14b61ab7");//Формирование фактической себестоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ОприходованиеНЗП = new Guid("641104a4-7428-e843-4f73-17acb511ec17");//Оприходование НЗП
		public static readonly Guid КорректировкаНЗПРасч = new Guid("ccb72b84-0602-6b6b-4ff9-48e40019f34b");//Корректировка незавершенного производства по расчетной стоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратМатериаловИзПроизводстваФикс = new Guid("d4c8c388-24b0-6b61-4f84-0bc6cb0c1f7e");//Возврат материалов из производства по фиксированной стоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеНЗПФикс = new Guid("086c43b0-cef8-75ce-44f0-d20afe3f720b");//Списание НЗП по фиксированной стоимости
		public static readonly Guid КорректировкаНЗПФикс = new Guid("a6c0d58c-378e-a830-4145-a547a3760a75");//Корректировка незавершенного производства по фиксированной стоимости
		public static КодыОперацийВыпускПродукции Получить(this КодыОперацийВыпускПродукции Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static КодыОперацийВыпускПродукции Получить(this КодыОперацийВыпускПродукции Значение, Guid Ссылка)
		{
			if(Ссылка == ВозвратМатериаловИзПроизводстваРасч)
			{
				return КодыОперацийВыпускПродукции.ВозвратМатериаловИзПроизводстваРасч;
			}
			else if(Ссылка == ВыпускПродукцииПоФиксированнойСтоимости)
			{
				return КодыОперацийВыпускПродукции.ВыпускПродукцииПоФиксированнойСтоимости;
			}
			else if(Ссылка == ВыпускПродукцииФиксВнешниеУслуги)
			{
				return КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнешниеУслуги;
			}
			else if(Ссылка == ВыпускПродукцииФиксВнутрУслугиНаПостЗатраты)
			{
				return КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнутрУслугиНаПостЗатраты;
			}
			else if(Ссылка == ВыпускПродукцииФиксВнутрУслугиНаПроизводство)
			{
				return КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнутрУслугиНаПроизводство;
			}
			else if(Ссылка == ВыпускПродукцииФиксВнутрУслугиНаСчет)
			{
				return КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнутрУслугиНаСчет;
			}
			else if(Ссылка == ВыпускПродукцииФиксНаСклад)
			{
				return КодыОперацийВыпускПродукции.ВыпускПродукцииФиксНаСклад;
			}
			else if(Ссылка == СписаниеНЗП)
			{
				return КодыОперацийВыпускПродукции.СписаниеНЗП;
			}
			else if(Ссылка == ФормированиеФактСебестоимости)
			{
				return КодыОперацийВыпускПродукции.ФормированиеФактСебестоимости;
			}
			else if(Ссылка == ОприходованиеНЗП)
			{
				return КодыОперацийВыпускПродукции.ОприходованиеНЗП;
			}
			else if(Ссылка == КорректировкаНЗПРасч)
			{
				return КодыОперацийВыпускПродукции.КорректировкаНЗПРасч;
			}
			else if(Ссылка == ВозвратМатериаловИзПроизводстваФикс)
			{
				return КодыОперацийВыпускПродукции.ВозвратМатериаловИзПроизводстваФикс;
			}
			else if(Ссылка == СписаниеНЗПФикс)
			{
				return КодыОперацийВыпускПродукции.СписаниеНЗПФикс;
			}
			else if(Ссылка == КорректировкаНЗПФикс)
			{
				return КодыОперацийВыпускПродукции.КорректировкаНЗПФикс;
			}
			return КодыОперацийВыпускПродукции.ПустаяСсылка;
		}
		public static byte[] Ключ(this КодыОперацийВыпускПродукции Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this КодыОперацийВыпускПродукции Значение)
		{
			switch (Значение)
			{
				case КодыОперацийВыпускПродукции.ВозвратМатериаловИзПроизводстваРасч: return ВозвратМатериаловИзПроизводстваРасч;
				case КодыОперацийВыпускПродукции.ВыпускПродукцииПоФиксированнойСтоимости: return ВыпускПродукцииПоФиксированнойСтоимости;
				case КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнешниеУслуги: return ВыпускПродукцииФиксВнешниеУслуги;
				case КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнутрУслугиНаПостЗатраты: return ВыпускПродукцииФиксВнутрУслугиНаПостЗатраты;
				case КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнутрУслугиНаПроизводство: return ВыпускПродукцииФиксВнутрУслугиНаПроизводство;
				case КодыОперацийВыпускПродукции.ВыпускПродукцииФиксВнутрУслугиНаСчет: return ВыпускПродукцииФиксВнутрУслугиНаСчет;
				case КодыОперацийВыпускПродукции.ВыпускПродукцииФиксНаСклад: return ВыпускПродукцииФиксНаСклад;
				case КодыОперацийВыпускПродукции.СписаниеНЗП: return СписаниеНЗП;
				case КодыОперацийВыпускПродукции.ФормированиеФактСебестоимости: return ФормированиеФактСебестоимости;
				case КодыОперацийВыпускПродукции.ОприходованиеНЗП: return ОприходованиеНЗП;
				case КодыОперацийВыпускПродукции.КорректировкаНЗПРасч: return КорректировкаНЗПРасч;
				case КодыОперацийВыпускПродукции.ВозвратМатериаловИзПроизводстваФикс: return ВозвратМатериаловИзПроизводстваФикс;
				case КодыОперацийВыпускПродукции.СписаниеНЗПФикс: return СписаниеНЗПФикс;
				case КодыОперацийВыпускПродукции.КорректировкаНЗПФикс: return КорректировкаНЗПФикс;
			}
			return Guid.Empty;
		}
	}
}