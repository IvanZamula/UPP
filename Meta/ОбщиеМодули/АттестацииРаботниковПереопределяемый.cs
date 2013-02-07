using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class АттестацииРаботниковПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции

		public void ДобавитьЭлементыУправления(/*ЭтаФорма*/)
		{
			//ЭтаФорма.ЭлементыФормы.Работники.Колонки.Добавить("ФизЛицо");
			//ЭтаФорма.ЭлементыФормы.Работники.Колонки.ФизЛицо.Видимость = Ложь;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public object СформироватьЗапросДиаграммы(/*Диаграмма, Компетенция, НачПериода, КонПериода, Должность*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Компетенция",			Компетенция);
			//Запрос.УстановитьПараметр("ШкалаОценок",			Компетенция.ШкалаОценок);
			//Запрос.УстановитьПараметр("НачПериода",				НачПериода);
			//Запрос.УстановитьПараметр("КонПериода",				КонПериода);
			//Запрос.УстановитьПараметр("Должность",				Должность);
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	Шкала.Представление,
	|	ВЫРАЗИТЬ(Шкала.ВесОценки * ВЫБОР
	|			КОГДА ИтогиОжидания.ВесОценки = 0
	|				ТОГДА 1
	|			ИНАЧЕ ИтогиРезультат.Количество / ИтогиОжидания.ВесОценки
	|		КОНЕЦ КАК ЧИСЛО(3, 0)) КАК Ожидания,
	|	ЕСТЬNULL(Данные.Количество, 0) КАК Результат
	|ИЗ
	|	(ВЫБРАТЬ
	|		СоставОценочныхШкалКомпетенций.Наименование КАК Наименование,
	|		СоставОценочныхШкалКомпетенций.Ссылка КАК Ссылка,
	|		СоставОценочныхШкалКомпетенций.ПриоритетОценки КАК ПриоритетОценки,
	|		СоставОценочныхШкалКомпетенций.Представление КАК Представление,
	|		Веса.ВесОценки КАК ВесОценки
	|	ИЗ
	|		Справочник.СоставОценочныхШкалКомпетенций КАК СоставОценочныхШкалКомпетенций
	|			ЛЕВОЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
	|				КомпетенцииРаботниковОписаниеОценок.Оценка КАК Оценка,
	|				КомпетенцииРаботниковОписаниеОценок.ВесОценки КАК ВесОценки
	|			ИЗ
	|				Справочник.КомпетенцииРаботников.ОписаниеОценок КАК КомпетенцииРаботниковОписаниеОценок
	|			ГДЕ
	|				КомпетенцииРаботниковОписаниеОценок.Ссылка = &Компетенция) КАК Веса
	|			ПО СоставОценочныхШкалКомпетенций.Ссылка = Веса.Оценка
	|	ГДЕ
	|		СоставОценочныхШкалКомпетенций.Владелец = &ШкалаОценок) КАК Шкала
	|		ЛЕВОЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
	|			ОценкиКомпетенцийРаботников.Оценка КАК Оценка,
	|			СУММА(1) КАК Количество
	|		ИЗ
	|			РегистрСведений.ОценкиКомпетенцийРаботников.СрезПоследних(
	|				&КонПериода,
	|				Период МЕЖДУ &НачПериода И &КонПериода
	|				    И Компетенция = &Компетенция) КАК ОценкиКомпетенцийРаботников
	|				ВНУТРЕННЕЕ СОЕДИНЕНИЕ РегистрСведений.Работники.СрезПоследних(&КонПериода, ) КАК Работники
	|				ПО Работники.ФизЛицо = ОценкиКомпетенцийРаботников.ФизЛицо
	|		ГДЕ
	|			Работники.ПричинаИзмененияСостояния <> ЗНАЧЕНИЕ(Перечисление.ПричиныИзмененияСостояния.Увольнение)
	|			//УСЛОВИЕ_ДОЛЖНОСТЬ
	|		
	|		СГРУППИРОВАТЬ ПО
	|			ОценкиКомпетенцийРаботников.Оценка) КАК Данные
	|		ПО Шкала.Ссылка = Данные.Оценка,
	|	(ВЫБРАТЬ
	|		СУММА(1) КАК Количество
	|	ИЗ
	|		РегистрСведений.ОценкиКомпетенцийРаботников.СрезПоследних(
	|			&КонПериода,
	|			Период МЕЖДУ &НачПериода И &КонПериода
	|			    И Компетенция = &Компетенция) КАК ОценкиКомпетенцийРаботников
	|			ВНУТРЕННЕЕ СОЕДИНЕНИЕ РегистрСведений.Работники.СрезПоследних(&КонПериода, ) КАК Работники
	|			ПО Работники.ФизЛицо = ОценкиКомпетенцийРаботников.ФизЛицо
	|	ГДЕ
	|		Работники.ПричинаИзмененияСостояния <> ЗНАЧЕНИЕ(Перечисление.ПричиныИзмененияСостояния.Увольнение)
	|		//УСЛОВИЕ_ДОЛЖНОСТЬ
	|) КАК ИтогиРезультат,
	|	(ВЫБРАТЬ
	|		СУММА(КомпетенцииРаботниковОписаниеОценок.ВесОценки) КАК ВесОценки
	|	ИЗ
	|		Справочник.КомпетенцииРаботников.ОписаниеОценок КАК КомпетенцииРаботниковОписаниеОценок
	|	ГДЕ
	|		КомпетенцииРаботниковОписаниеОценок.Ссылка = &Компетенция) КАК ИтогиОжидания
	|
	|УПОРЯДОЧИТЬ ПО
	|	Шкала.ПриоритетОценки";*/
			if(true/*ЗначениеЗаполнено(Должность)*/)
			{
				//Запрос.Текст = СтрЗаменить(Запрос.Текст, "//УСЛОВИЕ_ДОЛЖНОСТЬ", "И Работники.Должность.Должность = &Должность");
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы

		public void ОткрытьФормуОтбора(/*Форма, ОбработкаОбъект*/)
		{
			//АттестацииРаботниковДополнительный.ОткрытьФормуОтбора(Форма, ОбработкаОбъект);
		}

		public void ПриОткрытииФормыДополнительно(/*ЭтаФорма, ЭтотОбъект*/)
		{
			//ДобавитьЭлементыУправления(ЭтаФорма);
			//ЭтаФорма.ЭлементыФормы.ПанельОрганизация.Свертка	= РежимСверткиЭлементаУправления.Верх;
			//АттестацииРаботниковДополнительный.ПриОткрытииФормыДополнительно(ЭтаФорма);
		}

		public void ДополнитьРеквизитыФормыДокументаАттестация(/*Форма, ТекущиеДанные*/)
		{
			//Форма.Физлицо	= ТекущиеДанные.Физлицо;
		}
	}
}
