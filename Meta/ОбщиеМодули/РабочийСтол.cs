using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РабочийСтол
	{

		public object УстановитьЗакладку(/*ИмяЗакладки, ЭлементыФормы*/)
		{
			//ТекущаяСтраницаИмя = ЭлементыФормы.ОсновнаяПанель.ТекущаяСтраница.Имя;
			//ЭлементыФормы.ОсновнаяПанель.ТекущаяСтраница = ЭлементыФормы.ОсновнаяПанель.Страницы[ИмяЗакладки];
			//ЭлементыФормы[ТекущаяСтраницаИмя + "Активная"].Видимость = Ложь;
			//ЭлементыФормы[ТекущаяСтраницаИмя].Видимость = Истина;
			//ЭлементыФормы[ИмяЗакладки + "Активная"].Видимость = Истина;
			//ЭлементыФормы[ИмяЗакладки].Видимость = Ложь;
			return null;
		}

		public void УстановитьИмяТекущегоПользователя(/*ЗаголовокНадписи*/)
		{
			/*// заполним команду Мои настройки представлением текущего пользователя
*/
			if(true/*Не ПустаяСтрока(ИмяПользователя())*/)
			{
				//ЗаголовокНадписи = ОбщегоНазначения.ПолучитьПредставленияОбъектов(глЗначениеПеременной("глТекущийПользователь"));
			}
		}

		public void УстановитьОсновнуюОрганизацию(/*ЗаголовокНадписиОсновнойОрганизации, ЗаголовокКомандыОсновнойОрганизации, ОбъектОбработка*/)
		{
			//ОбъектОбработка.ОсновнаяОрганизация = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновнаяОрганизация");
			//ЗаголовокНадписиОсновнойОрганизации = ОбщегоНазначения.ПолучитьПредставленияОбъектов(ОбъектОбработка.ОсновнаяОрганизация);
			//ЗаголовокКомандыОсновнойОрганизации = ?(ЗначениеЗаполнено(ОбъектОбработка.ОсновнаяОрганизация), "Изменить ", "Установить ") + ОбщегоНазначения.ПреобразоватьСтрокуИнтерфейса("основную организацию");
		}

		public object ОтсечьЦифры(/*ИсходнаяСтрока*/)
		{
			//ФинальнаяСтрока = ИсходнаяСтрока;
			//КодСимвола = КодСимвола(Прав(ИсходнаяСтрока, 1));
			if(true/*(КодСимвола >= 48 И КодСимвола <= 57)*/)
			{
				//ФинальнаяСтрока = Лев(ИсходнаяСтрока, СтрДлина(ИсходнаяСтрока) - 1);
			}
			return null;
		}
		// ОтсечьЦифры()

		public void ОбработкаИсключения(/*ИнформацияОбОшибке*/)
		{
			//ПричинаОшибки = ИнформацияОбОшибке.Причина;
			/*Предупреждение(?(ПричинаОшибки = Неопределено,
					 "При выполнении действия произошла ошибка.",
					 ПричинаОшибки.Описание));*/
		}
		// ОбработкаИсключения()

		public void ОбработатьОткрытиеФормы(/*Элемент, Менеджер = Неопределено, ФормаСписка = Истина, ИмяФормы = Неопределено*/)
		{
			//ИмяОбъектаМетаданных = ОтсечьЦифры(Элемент.Имя);
		}
		// ОткрытьДокумент()

		public void ФормаОбработкиПисьмоВТехподдержку(/*Элемент, ФормаОбработки*/)
		{
			//УправлениеЭлектроннойПочтой.ОтправитьСообщениеВОтделТехническойПоддержки();
		}

		public void ФормаОбработкиНаписатьОтзыв(/*Элемент, ФормаОбработки*/)
		{
			//РаботаСДиалогамиПереопределяемый.ПерейтиНаСтраницуОтзывОПрограмме();
		}

		public void ФормаОбработкиСайт1С(/*Элемент, ФормаОбработки*/)
		{
			//РаботаСДиалогамиЗК.ПоказатьВебСтраницу("http://www.1c.ru", "Сайт фирмы 1С", "Сайт1С");
		}

		public void ФормаОбработкиМониторЗаконодательства(/*Элемент, ФормаОбработки*/)
		{
			//РаботаСДиалогамиЗК.ПоказатьВебСтраницу("http://v8.1c.ru/lawmonitor/");
		}

		public void ФормаОбработкиСайтБУХру(/*Элемент, ФормаОбработки*/)
		{
			//РаботаСДиалогамиЗК.ПоказатьВебСтраницу("http://www.buh.ru/");
		}

		public void ФормаОбработкиСайтИТС(/*Элемент, ФормаОбработки*/)
		{
			//РаботаСДиалогамиЗК.ПоказатьВебСтраницу("http://its.1c.ru/");
		}

		public void ФормаОбработкиПоказатьСтраницуКонфигурации(/*Элемент, ФормаОбработки*/)
		{
			//РаботаСДиалогамиЗК.ПоказатьВебСтраницу("");
		}

		public void УстановитьВидимостьЭлементовУправленияОрганизациями(/*ЭлементыФормы*/)
		{
			if(true/*Найти(ВРег(Метаданные.Имя), "БАЗОВАЯ") > 0*/)
			{
				//УправлениеОрганизациямиДоступно = Ложь;
			}
			//ЭлементыФормы.ПанельНашиОрганизации.Видимость = УправлениеОрганизациямиДоступно;
			//ЭлементыФормы.УстановитьОсновнуюОрганизацию.Видимость = УправлениеОрганизациямиДоступно;
		}
		// Показывает веб-страницы в обработке Обозреватель
		//
		// Параметры
		//  АдресСтраницы  – Строка – адрес просматриваемой страницы
		//  ЗаголовокОкна  – Строка – заголовок окна обработки
		//
		// Если передается пустая строка АдресСтраницы, то в обработке Обозреватель
		// просматривается веб-страница конфигурации
		//

		public void ПоказатьВебСтраницу(/*АдресСтраницы, ЗаголовокОкна = Неопределено*/)
		{
		}
		// Формирует список ссылок для указанной страницы
		//
		// Параметры
		//  ИмяСтраницы  - Строка - имя выбранной страницы формы
		//

		public void ЗаполнитьТаблицуСсылок(/*ТабличноеПолеСписокСсылокНаИТС, ИмяСтраницы, ФормаОбработки*/)
		{
			//ТабличноеПолеСписокСсылокНаИТС.Очистить();
			//СтруктураОтбора = Новый Структура("ИмяРаздела", ИмяСтраницы);
			//НайденныеСсылки = ФормаОбработки.СписокСсылокНаСайтеИТС.НайтиСтроки(СтруктураОтбора);
			//ТабличноеПолеСписокСсылокНаИТС = ФормаОбработки.СписокСсылокНаСайтеИТС.Скопировать(НайденныеСсылки);
			//ТабличноеПолеСписокСсылокНаИТС.Сортировать("Порядок");
		}
		// ЗаполнитьТаблицуСсылок()
		// Читает список ссылок в глобальную переменную модуля
		//

		public void ПрочитатьСсылки(/*ФормаОбработки*/)
		{
			/*Запрос = Новый Запрос("ВЫБРАТЬ
                      |	СсылкиНаСайтеИТС.ИмяРаздела,
                      |	СсылкиНаСайтеИТС.ПредставлениеСсылки,
                      |	СсылкиНаСайтеИТС.Гиперссылка,
                      |	СсылкиНаСайтеИТС.Порядок
                      |ИЗ
                      |	РегистрСведений.СсылкиНаСайтеИТС КАК СсылкиНаСайтеИТС
                      |
                      |УПОРЯДОЧИТЬ ПО
                      |	СсылкиНаСайтеИТС.Порядок");*/
			//ФормаОбработки.СписокСсылокНаСайтеИТС = Запрос.Выполнить().Выгрузить();
		}
		// Обработчик события перед открытием формы рабочего стола
		//
		// Параметры
		//  ФормаОбработки  - Форма рабочего стола
		//

		public void ФормаОбработкиПередОткрытием(/*ФормаОбработки*/)
		{
			//ПрочитатьСсылки(ФормаОбработки);
			//ЗаполнитьТаблицуСсылок(ФормаОбработки.ТабличноеПолеСписокСсылокНаИТС, ВРег(ФормаОбработки.ЭлементыФормы.ОсновнаяПанель.ТекущаяСтраница.Имя), ФормаОбработки);
			/*// Восстановим режим свертки панели ИТС предыдущего сеанса работы
*/
			/*// Если ранее значение не сохранялось, значит свертки нет - панель отображается
*/
			//РежимСверткиПанелиИТС = ВосстановитьЗначение("РабочийСтолРежимСверткиПанелиИТС");
			//ОбработатьВидимостьПанелиИТС(ФормаОбработки, ?(РежимСверткиПанелиИТС = Неопределено, РежимСверткиЭлементаУправления.Нет, РежимСверткиПанелиИТС));
		}
		// РабочийСтолПриОткрытии()
		// Обработчик события перед закрытием формы рабочего стола
		//
		// Параметры
		//  ФормаОбработки  - Форма рабочего стола
		//

		public void ФормаОбработкиПередЗакрытием(/*ФормаОбработки*/)
		{
			/*// Сохраним режим свертки панели ИТС, для установки режима при последующем открытии формы
*/
			//СохранитьЗначение("РабочийСтолРежимСверткиПанелиИТС", ФормаОбработки.ЭлементыФормы.ПанельИТС.Свертка);
		}
		// ФормаОбработкиПередЗакрытием()
		// Обрабатывает отображение / скрытие панели ИТС
		//
		// Параметры
		//  ФормаОбработки           - Форма рабочего стола
		//  НовоеСостояниеСвертки    - <СистемноеПеречисление.РежимСверткиЭлементаУправления> - режим свертки,
		//								который необходимо установить, если параметр не передан - это означает,
		//								что нужно установить режим противоположный текущему.
		//

		public void ОбработатьВидимостьПанелиИТС(/*ФормаОбработки, НовоеСостояниеСвертки = Неопределено*/)
		{
			if(true/*НовоеСостояниеСвертки = Неопределено*/)
			{
				if(true/*ФормаОбработки.ЭлементыФормы.ПанельИТС.Свертка = РежимСверткиЭлементаУправления.Нет*/)
				{
					//НовоеСостояниеСвертки = РежимСверткиЭлементаУправления.Право;
				}
			}
			//ФормаОбработки.МатериалыСайтаИТС = (НовоеСостояниеСвертки = РежимСверткиЭлементаУправления.Нет);
			//ФормаОбработки.ЭлементыФормы.ПанельИТС.Свертка = НовоеСостояниеСвертки;
		}
		// ОбработатьВидимостьПанелиИТС()
	}
}
