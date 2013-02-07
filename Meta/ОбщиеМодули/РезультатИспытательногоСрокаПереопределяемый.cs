using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РезультатИспытательногоСрокаПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта
		// Формирует запрос по шапке документа
		//
		// Параметры:
		//  Режим       - режим проведения
		//
		// Возвращаемое значение:
		//  Результат запроса
		//

		public object СформироватьЗапросПоШапке(/*Режим, Ссылка*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			//Запрос = Новый Запрос;
			/*// Установим параметры запроса
*/
			//Запрос.УстановитьПараметр("ДокументСсылка",	Ссылка);
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				//СтрокаСоединения = "Док.Сотрудник = НамеченныеСобытияПоПерсоналу.Сотрудник";
			}
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	Док.Ссылка,
	|	Док.Дата,
	|	Док.ДатаИзменения,
	|	Док.Сотрудник,
	|	Док.Сотрудник.Физлицо КАК Физлицо,
	|	Док.Сотрудник.ОбособленноеПодразделение КАК Организация,
	|	Док.Результат,"+РезультатИспытательногоСрокаДополнительный.ДополнитьЗапросПоШапке()+"
	|	ВЫБОР
	|		КОГДА СостояниеРаботниковНаИспытательномСроке.Состояние = ЗНАЧЕНИЕ(Перечисление.СостоянияРаботникаНаИспытательномСроке.ПринятНаИспытательныйСрок)
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК КандидатПринятНаИспытательныйСрок,
	|	ВЫБОР
	|		КОГДА СостояниеРаботниковНаИспытательномСроке.Период = Док.ДатаИзменения
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК ЕстьРешение,
	|	НамеченныеСобытияПоПерсоналу.ПланируемоеСобытие
	|ИЗ
	|	Документ.РезультатИспытательногоСрока КАК Док
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.НамеченныеСобытияПоПерсоналу КАК НамеченныеСобытияПоПерсоналу
	|		ПО "+СтрокаСоединения+"
	|			И (НАЧАЛОПЕРИОДА(Док.ДатаИзменения, ДЕНЬ) = НамеченныеСобытияПоПерсоналу.ДатаИзменения)
	|			И ВЫБОР
	|				КОГДА Док.Результат = ЗНАЧЕНИЕ(Перечисление.РезультатыИспытательногоСрока.Отрицательный)
	|					ТОГДА НамеченныеСобытияПоПерсоналу.ПланируемоеСобытие = ЗНАЧЕНИЕ(Перечисление.НамеченныеСобытияПоПерсоналу.УвольнениеПослеИспытательногоСрока)
	|				КОГДА Док.Результат = ЗНАЧЕНИЕ(Перечисление.РезультатыИспытательногоСрока.Продлен)
	|					ТОГДА НамеченныеСобытияПоПерсоналу.ПланируемоеСобытие = ЗНАЧЕНИЕ(Перечисление.НамеченныеСобытияПоПерсоналу.РезультатИспытательногоСрока)
	|				ИНАЧЕ ЛОЖЬ
	|			КОНЕЦ
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СостояниеРаботниковНаИспытательномСроке КАК СостояниеРаботниковНаИспытательномСроке
	|			ВНУТРЕННЕЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
	|				МАКСИМУМ(СостояниеРаботниковНаИспытательномСроке.Период) КАК ДатаЗначения,
	|				Док.Сотрудник.Физлицо КАК ФизЛицо
	|			ИЗ
	|				Документ.РезультатИспытательногоСрока КАК Док
	|					ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СостояниеРаботниковНаИспытательномСроке КАК СостояниеРаботниковНаИспытательномСроке
	|					ПО СостояниеРаботниковНаИспытательномСроке.Физлицо = Док.Сотрудник.Физлицо
	|						И СостояниеРаботниковНаИспытательномСроке.Период <= Док.ДатаИзменения
	|			ГДЕ
	|				Док.Ссылка = &ДокументСсылка
	|			
	|			СГРУППИРОВАТЬ ПО
	|				Док.Сотрудник.Физлицо) КАК СписокДат
	|			ПО СостояниеРаботниковНаИспытательномСроке.Период = СписокДат.ДатаЗначения
	|				И СостояниеРаботниковНаИспытательномСроке.Физлицо = СписокДат.ФизЛицо
	|		ПО Док.Сотрудник.Физлицо = СостояниеРаботниковНаИспытательномСроке.Физлицо
	|ГДЕ
	|	Док.Ссылка = &ДокументСсылка";*/
			return null;
		}
		// СформироватьЗапросПоШапке()

		public void ДополнитьДвижение(/*Движение, ВыборкаПоШапкеДокумента*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				//Движение.Сотрудник		= ВыборкаПоШапкеДокумента.Сотрудник;
				//Движение.Организация	= ВыборкаПоШапкеДокумента.Организация;
			}
		}

		public void ПроверитьЗаполнениеШапкиДополнительно(/*ВыборкаПоШапкеДокумента, Отказ, Заголовок*/)
		{
			//РезультатИспытательногоСрокаДополнительный.ПроверитьЗаполнениеШапкиДополнительно(ВыборкаПоШапкеДокумента, Отказ, Заголовок);
		}

		public void ДополнитьДвижениеСостоянияРаботникаНаИспытательномСроке(/*Движение, ВыборкаПоШапкеДокумента*/)
		{
			//РезультатИспытательногоСрокаДополнительный.ДополнитьДвижениеСостоянияРаботникаНаИспытательномСроке(Движение, ВыборкаПоШапкеДокумента);
		}

		public void ДобавитьСтрокуВДвиженияПоРегистрамСведенийПродленДополнительно(/*Движения, ВыборкаПоШапкеДокумента*/)
		{
			//РезультатИспытательногоСрокаДополнительный.ДобавитьСтрокуВДвиженияПоРегистрамСведенийПродленДополнительно(Движения, ВыборкаПоШапкеДокумента);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public void ПриИзмененииРешенияДополнительно(/*ЭтаФорма, ЭлементыФормы, Результат*/)
		{
			//РезультатИспытательногоСрокаДополнительный.ПриИзмененииРешенияДополнительно(ЭтаФорма, ЭлементыФормы, Результат);
		}

		public void ПередОткрытиемДополнительно(/*ЭтаФорма, ЭлементыФормы*/)
		{
			//РезультатИспытательногоСрокаДополнительный.ПередОткрытиемДополнительно(ЭтаФорма, ЭлементыФормы);
		}
	}
}
