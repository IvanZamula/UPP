using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ИзменениеАктуальностиЭлементовПереопределяемый
	{
		///////////////////////////////////////////////////////////////////////////////
		// ОБРАБОТЧИКИ СОБЫТИЙ ФОРМЫ ЭЛЕМЕНТА

		public void ФормаЭлементаПередОткрытиемДополнительно(/*Форма, ДополнительныеДействия*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаЭлементаПередОткрытиемДополнительно

		public void ФормаЭлементаПриОткрытииДополнительно(/*Форма*/)
		{
			//Форма.ЭлементыФормы.ПанельАктуальность.Свертка = РежимСверткиЭлементаУправления.Верх;
		}
		// ФормаЭлементаПередОткрытиемДополнительно

		public void ФормаЭлементаПослеЗаписиДополнительно(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаЭлементаПослеЗаписиДополнительно

		public void ВыполнитьДополнительныеДействияФормыЭлемента(/*Элемент, Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ВыполнитьДополнительныеДействияФормыЭлемента

		public void ФормаЭлементаПередЗаписьюДополнительно(/*Форма, СправочникОбъект, Отказ*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаЭлементаПередЗаписьюДополнительно
		///////////////////////////////////////////////////////////////////////////////
		// ОБРАБОТЧИКИ СОБЫТИЙ ФОРМЫ СПИСКА

		public void ФормаСпискаПередОткрытиемДополнительно(/*Форма, ДополнительныеДействия, Список*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПередОткрытиемДополнительно

		public void ФормаСпискаПриОткрытииДополнительно(/*Форма, Список*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПриОткрытииДополнительно

		public void ФормаСпискаПриЗакрытииДополнительно(/*Форма, Список*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПриЗакрытииДополнительно

		public void ВыполнитьДополнительныеДействияФормыСписка(/*Элемент, Форма, Список*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПриЗакрытииДополнительно

		public void ФормаСпискаОформлениеСпискаДополнительно(/*Форма, ПолеСписка, ОформленияСтрок, ПервыеПодразделения = Неопределено*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
	}
}
