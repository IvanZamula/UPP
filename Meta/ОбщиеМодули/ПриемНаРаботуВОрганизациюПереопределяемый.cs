﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПриемНаРаботуВОрганизациюПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public void ДополнитьСтруктуруПечатныхФорм(/*СтруктураПечатныхФорм, ДокументОбъект*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ДополнитьСтруктуруПечатныхФорм(СтруктураПечатныхФорм, ДокументОбъект);
		}

		public object ПечатьДополнительныхФорм(/*ИмяМакета, Объект*/)
		{
			return null;
		}

		public object ВыполняетсяДополнительноеУсловиеИДействие(/*ИмяРегистра, Движение = Неопределено, ВыборкаПоРаботникиОрганизации, ВыборкаПоШапкеДокумента*/)
		{
			//мДлинаСуток = 86400;
			if(true/*НЕ ВыборкаПоРаботникиОрганизации.НапомнитьПоЗавершении*/)
			{
				if(true/*ИмяРегистра = "РаботникиОрганизаций"*/)
				{
					/*// Свойства
*/
					//Движение.ПериодЗавершения						= ВыборкаПоРаботникиОрганизации.ДатаУвольнения + мДлинаСуток;
					/*// Ресурсы
*/
					//Движение.ПодразделениеОрганизацииЗавершения		= ВыборкаПоРаботникиОрганизации.ПодразделениеОрганизации;
					//Движение.ДолжностьЗавершения					= ВыборкаПоРаботникиОрганизации.Должность;
					/*// Реквизиты
*/
					//Движение.ПричинаИзмененияСостоянияЗавершения	= Перечисления.ПричиныИзмененияСостояния.Увольнение;
					//Движение.ОбособленноеПодразделениеЗавершения	= ВыборкаПоШапкеДокумента.Организация;
				}
			}
			return null;
		}

		public object ВыполнятьДвижениеПоСостояниеРаботниковНаИспытательномСроке(/*ВыборкаПоРаботникиОрганизации*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			//ВедетсяНаборПерсонала = РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц;
			return null;
		}

		public void ЗаполнитьПоОснованию(/*Основание, ЭтотОбъект*/)
		{
			//ТипОснования = ТипЗнч(Основание);
			if(true/*ТипОснования = Тип("ДокументСсылка.ПриемНаРаботу")*/)
			{
				/*// Заполним реквизиты из стандартного набора.
*/
				//ЗаполнениеДокументов.ЗаполнитьШапкуДокументаПоОснованию(ЭтотОбъект, Основание);
				if(true/*Основание.Проведен*/)
				{
					//ТекущийПользователь = глЗначениеПеременной("глТекущийПользователь");
					//УчетнаяПолитикаПоПерсоналуОрганизации = глЗначениеПеременной("глУчетнаяПолитикаПоПерсоналуОрганизации");
					if(true/*ЭтотОбъект.Организация.Пустая()*/)
					{
						//ЭтотОбъект.Организация = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекущийПользователь, "ОсновнаяОрганизация");
					}
					//Запрос = Новый Запрос;
					//Запрос.УстановитьПараметр("Организация",			ЭтотОбъект.Организация);
					//Запрос.УстановитьПараметр("Регистратор",			Основание);
					/*Запрос.Текст =
			"ВЫБРАТЬ РАЗРЕШЕННЫЕ
			|	ПриемНаРаботуРаботники.Сотрудник,
			|	ПриемНаРаботуРаботники.Сотрудник.Физлицо КАК ФизЛицо,
			|	СоответствиеПодразделенийИПодразделенийОрганизаций.ПодразделениеОрганизации,
			|	ПриемНаРаботуРаботники.Должность КАК Должность,
			|	ПриемНаРаботуРаботники.ЗанимаемыхСтавок,
			|	ПриемНаРаботуРаботники.ДатаПриема,
			|	ВЫБОР
			|		КОГДА ПриемНаРаботуРаботники.ИспытательныйСрок = ЗНАЧЕНИЕ(Перечисление.ИспытательныйСрок.СИспытательнымСроком)
			|			ТОГДА РАЗНОСТЬДАТ(ПриемНаРаботуРаботники.ДатаПриема, ПриемНаРаботуРаботники.ДатаУвольнения, МЕСЯЦ)
			|		ИНАЧЕ 0
			|	КОНЕЦ КАК ИспытательныйСрок,
			|	ПриемНаРаботуРаботники.ДатаУвольнения,
			|	ПриемНаРаботуРаботники.ГрафикРаботы,
			|	ИСТИНА КАК НапомнитьПоЗавершении
			|ИЗ
			|	Документ.ПриемНаРаботу.Работники КАК ПриемНаРаботуРаботники
			|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СоответствиеПодразделенийИПодразделенийОрганизаций КАК СоответствиеПодразделенийИПодразделенийОрганизаций
			|		ПО (СоответствиеПодразделенийИПодразделенийОрганизаций.Организация = &Организация)
			|			И ПриемНаРаботуРаботники.Подразделение = СоответствиеПодразделенийИПодразделенийОрганизаций.Подразделение
			|ГДЕ
			|	ПриемНаРаботуРаботники.Ссылка = &Регистратор";*/
					//ЭтотОбъект.РаботникиОрганизации.Загрузить(Запрос.Выполнить().Выгрузить());
				}
			}
		}
		// Формирует запрос по таблице "ОсновныеНачисления" документа
		//
		// Параметры:
		//  нет
		//
		// Возвращаемое значение:
		//  Результат запроса.
		//

		public object СформироватьЗапросПоНачисления(/*КонтрольРазмераСтавокШтатногоРасписания, ЭтотОбъект*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.МенеджерВременныхТаблиц = Новый МенеджерВременныхТаблиц;
			//Запрос.УстановитьПараметр("ДокументСсылка", ЭтотОбъект.Ссылка);
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Ссылка,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.НомерСтроки,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Сотрудник КАК Сотрудник,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ВидРасчета,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Показатель1,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Валюта1,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Показатель2,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Валюта2,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Показатель3,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Валюта3,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Показатель4,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Валюта4,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Показатель5,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Валюта5,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Показатель6,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Валюта6,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ТарифныйРазряд1,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ТарифныйРазряд2,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ТарифныйРазряд3,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ТарифныйРазряд4,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ТарифныйРазряд5,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ТарифныйРазряд6,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ВидРасчета.СпособРасчета,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ВидРасчета.ЗачетОтработанногоВремени,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ВидРасчета.ТребуетВводаТарифногоРазряда,
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.ВидРасчета.ПроизвольнаяФормулаРасчета
	|ПОМЕСТИТЬ ВТДанныеНачислений
	|ИЗ
	|	Документ.ПриемНаРаботуВОрганизацию.ОсновныеНачисления КАК ПриемНаРаботуВОрганизациюОсновныеНачисления
	|ГДЕ
	|	ПриемНаРаботуВОрганизациюОсновныеНачисления.Ссылка = &ДокументСсылка
	|	И (НЕ ПриемНаРаботуВОрганизациюОсновныеНачисления.Сторно)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Сотрудник
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	ТЧРаботникиОрганизации.Сотрудник КАК Сотрудник,
	|	ТЧРаботникиОрганизации.ПодразделениеОрганизации,
	|	ТЧРаботникиОрганизации.Должность,
	|	ТЧРаботникиОрганизации.ЗанимаемыхСтавок,
	|	ТЧРаботникиОрганизации.ГрафикРаботы,
	|	ТЧРаботникиОрганизации.ДатаПриема,
	|	ТЧРаботникиОрганизации.ДатаУвольнения,
	|	ТЧРаботникиОрганизации.НапомнитьПоЗавершении
	|ПОМЕСТИТЬ ВТДанныеДокумента
	|ИЗ
	|	Документ.ПриемНаРаботуВОрганизацию.РаботникиОрганизации КАК ТЧРаботникиОрганизации
	|ГДЕ
	|	ТЧРаботникиОрганизации.Ссылка = &ДокументСсылка
	|	И (НЕ ТЧРаботникиОрганизации.Сторно)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Сотрудник
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ТЧНачисления.Ссылка КАК Ссылка,
	|	ТЧНачисления.НомерСтроки КАК НомерСтроки,
	|	ТЧНачисления.Сотрудник КАК Сотрудник,
	|	ТЧРаботникиОрганизации.ПодразделениеОрганизации,
	|	ТЧРаботникиОрганизации.Должность,
	|	ТЧРаботникиОрганизации.ЗанимаемыхСтавок,
	|	ТЧРаботникиОрганизации.ГрафикРаботы,
	|	ТЧРаботникиОрганизации.ДатаПриема КАК Период,
	|	ЗНАЧЕНИЕ(Перечисление.ВидыДействияСНачислением.Начать) КАК Действие,
	|	ВЫБОР
	|		КОГДА ТЧРаботникиОрганизации.ДатаУвольнения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|				И (НЕ ТЧРаботникиОрганизации.НапомнитьПоЗавершении)
	|			ТОГДА ДОБАВИТЬКДАТЕ(ТЧРаботникиОрганизации.ДатаУвольнения, ДЕНЬ, 1)
	|		ИНАЧЕ ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|	КОНЕЦ КАК ПериодЗавершения,
	|	ВЫБОР
	|		КОГДА ТЧРаботникиОрганизации.ДатаУвольнения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|				И (НЕ ТЧРаботникиОрганизации.НапомнитьПоЗавершении)
	|			ТОГДА ЗНАЧЕНИЕ(Перечисление.ВидыДействияСНачислением.Прекратить)
	|		ИНАЧЕ ЗНАЧЕНИЕ(Перечисление.ВидыДействияСНачислением.ПустаяСсылка)
	|	КОНЕЦ КАК ДействиеЗавершения,
	|	ТЧНачисления.ВидРасчета КАК ВидРасчета,
	|	ВЫБОР
	|		КОГДА ТЧНачисления.ВидРасчетаЗачетОтработанногоВремени
	|			ТОГДА """"
	|		ИНАЧЕ ТЧНачисления.ВидРасчета
	|	КОНЕЦ КАК ВидРасчетаИзмерение,
	|	ТЧНачисления.ВидРасчетаСпособРасчета КАК СпособРасчета,
	|	ТЧНачисления.ВидРасчетаЗачетОтработанногоВремени КАК ЗачетОтработанногоВремени,
	|	ТЧНачисления.ВидРасчетаТребуетВводаТарифногоРазряда КАК ТребуетВводаТарифногоРазряда,
	|	ТЧНачисления.ВидРасчетаПроизвольнаяФормулаРасчета КАК ПроизвольнаяФормулаРасчета,
	|	ТЧНачисления.Показатель1 КАК Показатель1,
	|	ТЧНачисления.Валюта1 КАК Валюта1,
	|	ТЧНачисления.ТарифныйРазряд1 КАК ТарифныйРазряд1,
	|	ТЧНачисления.Показатель2 КАК Показатель2,
	|	ТЧНачисления.Валюта2 КАК Валюта2,
	|	ТЧНачисления.ТарифныйРазряд2 КАК ТарифныйРазряд2,
	|	ТЧНачисления.Показатель3 КАК Показатель3,
	|	ТЧНачисления.Валюта3 КАК Валюта3,
	|	ТЧНачисления.ТарифныйРазряд3 КАК ТарифныйРазряд3,
	|	ТЧНачисления.Показатель4 КАК Показатель4,
	|	ТЧНачисления.Валюта4 КАК Валюта4,
	|	ТЧНачисления.ТарифныйРазряд4 КАК ТарифныйРазряд4,
	|	ТЧНачисления.Показатель5 КАК Показатель5,
	|	ТЧНачисления.Валюта5 КАК Валюта5,
	|	ТЧНачисления.ТарифныйРазряд5 КАК ТарифныйРазряд5,
	|	ТЧНачисления.Показатель6 КАК Показатель6,
	|	ТЧНачисления.Валюта6 КАК Валюта6,
	|	ТЧНачисления.ТарифныйРазряд6 КАК ТарифныйРазряд6
	|ИЗ
	|	ВТДанныеНачислений КАК ТЧНачисления
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТДанныеДокумента КАК ТЧРаботникиОрганизации
	|		ПО ТЧНачисления.Сотрудник = ТЧРаботникиОрганизации.Сотрудник
	|
	|УПОРЯДОЧИТЬ ПО
	|	НомерСтроки";*/
			return null;
		}
		// СформироватьЗапросПоНачисления()
		// Возвращает массив значений перечисления ВидыДоговоровСФизЛицами, для которых оформляется
		// приказ о приеме на работу по форме Т-1
		//
		// Параметры
		//  нет
		//
		// Возвращаемое значение:
		//   массив значений типа ПеречислениеСсылка.ВидыДоговоровСФизЛицами
		//

		public object ВидыТрудовыхДоговоров(/**/)
		{
			//МассивВидов = Новый Массив;
			//МассивВидов.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор);
			return null;
		}
		// ВидыТрудовыхДоговоров()

		public object ДополнительноеПолеТабличнойЧасти(/**/)
		{
			return null;
		}
		// ДополнительноеПолеТабличнойЧасти()

		public void ДобавитьДополнительноПоСтроке(/*ДокументОбъект, СтрокаТабличнойЧасти*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ДобавитьДополнительноПоСтроке(ДокументОбъект, СтрокаТабличнойЧасти);
		}

		public void ДобавитьДополнительныеДвижения(/*ДокументОбъект, Отказ, Заголовок*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ДобавитьДополнительныеДвижения(ДокументОбъект, Отказ, Заголовок);
		}

		public void ДозаполнитьСтрокуТаблицыРаботникиОрганизации(/*СтрокаТабличнойЧасти*/)
		{
			//СтрокаТабличнойЧасти.НапомнитьПоЗавершении = Истина;
		}

		public void ДвиженияНаДатуУвольненияДополнительно(/*Движение*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ДвиженияНаДатуУвольненияДополнительно(Движение);
		}

		public void ДополнитьДвиженияПоСостояниюРаботниковНаИспытательномСроке(/*Движение, ВыборкаПоРаботникиОрганизации*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ДополнитьДвиженияПоСостояниюРаботниковНаИспытательномСроке(Движение, ВыборкаПоРаботникиОрганизации);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public void ДополнитьКнопкиКоманднойПанели(/*КоманднаяПанель, Действие*/)
		{
			//ИспользоватьУправленческийУчетЗарплаты = глЗначениеПеременной("глИспользоватьУправленческийУчетЗарплаты");
			if(true/*ИспользоватьУправленческийУчетЗарплаты*/)
			{
				//КнопкаЗаполнитьПринятымиВКомпанию = КоманднаяПанель.Кнопки.Добавить("ЗаполнитьПринятымиВКомпанию", ТипКнопкиКоманднойПанели.Действие, "Работниками, принятыми в компанию", Действие);
				//КнопкаЗаполнитьПринятымиВКомпанию.Подсказка = "Работниками, принятыми в компанию";
				//КнопкаЗаполнитьПринятымиВКомпанию.ИзменяетДанные = Истина;
			}
		}

		public void ДополнитьСоставКолонок(/*Форма*/)
		{
			//РаботаСДиалогами.ВставитьКолонкуВТабличноеПоле(8, Форма.ЭлементыФормы.РаботникиОрганизации, "НапомнитьПоЗавершении", "Регистрировать увольнение отдельным документом", , "НапомнитьПоЗавершении", , Ложь, , ПоложениеКолонки.ВТойЖеКолонке);
			//ПриемНаРаботуВОрганизациюДополнительный.ДополнитьСоставКолонок(Форма);
		}
		// Процедура обеспечивает начальное значение реквизитов "ЗанимаемыхСтавок"
		//  и "ИспытательныйСрок"
		//
		// Параметры:
		//  Элемент - табличное поле, которое отображает т.ч.
		//  НоваяСтрока - булево, признак редактирования новой строки
		//

		public void РаботникиОрганизацииПриНачалеРедактирования(/*Элемент, НоваяСтрока*/)
		{
			if(true/*НоваяСтрока*/)
			{
				//Элемент.ТекущиеДанные.НапомнитьПоЗавершении = Истина;
			}
		}
		// РаботникиОрганизацииПриНачалеРедактирования()

		public void РаботникиОрганизацииПриПолученииДанных(/*Элемент, ОформленияСтрок, РаботникиОрганизации*/)
		{
			//ТолькоПросмотрНапоминания = РаботникиОрганизации.Итог("НапомнитьПоЗавершении") = РаботникиОрганизации.Количество();
			//ПриемНаРаботуВОрганизациюДополнительный.РаботникиОрганизацийПриПолученииДанныхДополнительно(Элемент, ОформленияСтрок);
		}

		public void ВыполнитьДополнительныеДействия(/*Кнопка, Объект, НастройкаПериода, Форма*/)
		{
			if(true/*Кнопка.Имя = "ЗаполнитьПринятымиВКомпанию"*/)
			{
				if(true/*Объект.РаботникиОрганизации.Количество()>0*/)
				{
					//ТекстВопроса = "Имеющийся список сотрудников будет очищен. Продолжить?";
					//Ответ  = Вопрос(ТекстВопроса, РежимДиалогаВопрос.ОКОтмена);
					if(true/*Ответ = КодВозвратаДиалога.Отмена*/)
					{
					}
				}
				if(true/*НастройкаПериода.Редактировать()*/)
				{
					//ПриемНаРаботуВОрганизациюДополнительный.ЗаполнитьТабличнуюЧастьРаботникиПринятымиВКомпанию(Объект, НастройкаПериода.ПолучитьДатуНачала(), НастройкаПериода.ПолучитьДатуОкончания());
				}
			}
			//ПриемНаРаботуВОрганизациюДополнительный.ВыполнитьДополнительныеДействия(Форма, Кнопка);
		}

		public void ПриИзмененииПодразделенияДолжностиДополнительно(/*ЭтаФорма*/)
		{
			//ДанныеСтроки = ЭтаФорма.ЭлементыФормы.РаботникиОрганизации.ТекущиеДанные;
			if(true/*НЕ ЗначениеЗаполнено(ДанныеСтроки.ГрафикРаботы)*/)
			{
				//ДанныеШР = ПроцедурыУправленияПерсоналомПереопределяемый.СведенияОПозицииШтатногоРасписания(ЭтаФорма.Дата, ДанныеСтроки.ПодразделениеОрганизации, ДанныеСтроки.Должность);
				if(true/*ДанныеШР.Количество() > 0*/)
				{
					//ДанныеСтроки.ГрафикРаботы = ДанныеШР[0].ГрафикРаботы;
				}
			}
		}

		public void ФормаДокументаПередОткрытиемДополнительно(/*Форма, ДополнительныеДействия, ДополнительныеОбработчики*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ФормаДокументаПередОткрытиемДополнительно(Форма, ДополнительныеДействия, ДополнительныеОбработчики);
		}

		public void ОбработатьДополнительноПриИзменении(/*Форма, Элемент*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ОбработатьДополнительноПриИзменении(Форма, Элемент);
		}

		public void УдалитьДополнительноПоСтроке(/*Форма, Сотрудник*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.УдалитьДополнительноПоСтроке(Форма, Сотрудник);
		}

		public void ФормаДокументаРаботникиПослеУдаленияСтрокиДополнительно(/*Форма*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ФормаДокументаРаботникиПослеУдаленияСтрокиДополнительно(Форма);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы списка

		public void ФормаСпискаПередОткрытиемДополнительно(/*ФормаСписка*/)
		{
			//ПриемНаРаботуВОрганизациюДополнительный.ФормаСпискаПередОткрытиемДополнительно(ФормаСписка);
		}
		// ФормаСпискаПередОткрытиемДополнительно
	}
}
