using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class НачислениеПоБольничномуЛистуСервис
	{

		public object ПроцентОплатыБольничногоПоСтраховомуСтажу(/*Лет*/)
		{
			//Возврат ?(Лет >= 8, 100,?(Лет >= 5, 80, 60));
			return null;
		}

		public void ПрочитатьДанныеОЛьготах(/*Объект*/)
		{
			//Сотрудник = Объект.Сотрудник;
			if(true/*ЗначениеЗаполнено(Объект.Сотрудник)*/)
			{
				//Запрос = Новый Запрос;
				if(true/*Объект.ПериодРегистрации < ПроведениеРасчетов.ДатаЗаменыЕСНСтраховымиВзносами() Или Объект.ПричинаНетрудоспособности = Перечисления.ПричиныНетрудоспособности.ТравмаНаПроизводстве*/)
				{
					/*Запрос.Текст = 
			"ВЫБРАТЬ
			|	СотрудникиОрганизаций.Физлицо,
			|	ЗНАЧЕНИЕ(Перечисление.ВыплатыПособийЗаСчетФедеральногоБюджета.ПустаяСсылка) КАК ВыплатаЗаСчетФедеральногоБюджета
			|ИЗ
			|	Справочник.СотрудникиОрганизаций КАК СотрудникиОрганизаций
			|ГДЕ
			|	СотрудникиОрганизаций.Ссылка = &Ссылка";*/
				}
				//Запрос.УстановитьПараметр("Ссылка", Сотрудник);
				//Выборка = Запрос.Выполнить().Выбрать();
				//Выборка.Следующий();
				//ЗаполнитьЗначенияСвойств(Объект, Выборка);
			}
			//Объект.ПрименятьЛьготыПриНачисленииПособия = ЗначениеЗаполнено(Объект.ВыплатаЗаСчетФедеральногоБюджета);
		}

		public void ПрочитатьРазмерыПособия(/*Объект, ДополнительныеДанные, ТолькоДополнительныеДанные, ГоловнаяОрганизация = Неопределено*/)
		{
			/*// обновляем дополнительные данные
*/
			//НачислениеПоБольничномуЛистуПереопределяемый.ОбновитьРазмерыПособия(Объект, ДополнительныеДанные, Истина);
			if(true/*ТолькоДополнительныеДанные*/)
			{
			}
			if(true/*ГоловнаяОрганизация = Неопределено*/)
			{
				//ГоловнаяОрганизация = ОбщегоНазначения.ГоловнаяОрганизация(Объект.Организация);
			}
			//ДатаНачалаСобытия			= Объект.ДатаНачалаСобытия;
			//Сотрудник					= Объект.Сотрудник;
			//Физлицо						= Объект.Физлицо;
			//ПричинаНетрудоспособности	= Объект.ПричинаНетрудоспособности;
			//ДатаНачала					= Объект.ДатаНачала;
			//ДатаОкончания				= Объект.ДатаОкончания;
			/*// пересчитываем стаж
*/
			//Лет	= 0;
			//Месяцев = 0;
			//ДатаСтажа = '00010101';
			if(true/*ЗначениеЗаполнено(ДатаНачалаСобытия)*/)
			{
				//ДатаСтажа = ПроведениеРасчетов.ПолучитьНачалоСтажаДляБольничногоЛиста(ДатаНачалаСобытия, Физлицо, ГоловнаяОрганизация);
				if(true/*ЗначениеЗаполнено(ДатаСтажа)*/)
				{
					//ОбщегоНазначения.РазобратьРазностьДат(ДатаНачалаСобытия, ДатаСтажа, Лет, Месяцев);
					if(true/*Лет * 12 + Месяцев >= 6*/)
					{
						//Объект.ОграничениеПособия = Перечисления.ВидыОграниченияПособия.ОбщееОграничение;
					}
				}
			}
			//Объект.СтажЛет = Лет;
			//Объект.СтажМесяцев = Месяцев;
			/*// определяем процент оплаты и ограничение
*/
			if(true/*ПричинаНетрудоспособности = Перечисления.ПричиныНетрудоспособности.ТравмаНаПроизводстве*/)
			{
				//Объект.ПроцентОплаты = 100;
				//Объект.ОграничениеПособия = Перечисления.ВидыОграниченияПособия.БезОграничений;
			}
			/*// уточняем процент оплаты и ограничение для некоторых ситуаций
*/
			//НачислениеПоБольничномуЛистуПереопределяемый.ОбновитьРазмерыПособия(Объект, Ложь, Ложь);
			/*// определяем параметры с учетом льгот сотрудника
*/
			if(true/*ЗначениеЗаполнено(Объект.ВыплатаЗаСчетФедеральногоБюджета) И ПричинаНетрудоспособности <> Перечисления.ПричиныНетрудоспособности.ТравмаНаПроизводстве*/)
			{
				//Объект.ПроцентОплатыБезЛьгот = Объект.ПроцентОплаты;
				//Объект.ОграничениеПособияБезЛьгот = Объект.ОграничениеПособия;
				//Объект.СтажБезНестраховыхПериодовЛет = Объект.СтажЛет;
				//Объект.СтажБезНестраховыхПериодовСтажМесяцев = Объект.СтажМесяцев;
				if(true/*Объект.ВыплатаЗаСчетФедеральногоБюджета = Перечисления.ВыплатыПособийЗаСчетФедеральногоБюджета.ЗачетНестраховыхПериодов*/)
				{
					if(true/*ДатаНачалаСобытия = '00010101'*/)
					{
						//Объект.ПроцентОплаты = 100;
						//Объект.СтажЛет = 0;
						//Объект.СтажМесяцев = 0;
					}
				}
			}
		}

		public void ОпределитьРазмерыПособияПоСтажу(/*ПричинаНетрудоспособности, Лет, Месяцев, Процент, Ограничение*/)
		{
			if(true/*ПричинаНетрудоспособности = Перечисления.ПричиныНетрудоспособности.ТравмаНаПроизводстве*/)
			{
			}
			//Ограничение = ?(Лет * 12 + Месяцев >= 6, Перечисления.ВидыОграниченияПособия.ОбщееОграничение, Перечисления.ВидыОграниченияПособия.ОграничениеВРазмереММОТ);
			if(true/*ПричинаНетрудоспособности = Перечисления.ПричиныНетрудоспособности.ПоБеременностиИРодам*/)
			{
			}
			//Процент = ПроцентОплатыБольничногоПоСтраховомуСтажу(Лет);
		}
		///// ПРОЦЕДУРЫ ОБРАБОТКИ ДВУМЕРНОГО СКАНЕРА ШТРИХКОДОВ /////

		public object ДатаИзСтроки(/*ДатаСтрокой*/)
		{
			if(true/*ПустаяСтрока(ДатаСтрокой) Или СтрДлина(ДатаСтрокой) <> 10 Или ОбщегоНазначения.РазложитьСтрокуВМассивПодстрок(ДатаСтрокой, "-").Количество() <> 3*/)
			{
			}
			return null;
		}

		public object ЭтоДвумерныйШтрихкодБольничного(/*ОписаниеСобытия*/)
		{
			//Возврат Найти(ОписаниеСобытия.Данные, "!!8!!") = 1;
			return null;
		}

		public object ОбработатьСобытиеОтСканераШтрихкода(/*ОписаниеСобытия, ОписаниеОшибки = ""*/)
		{
			if(true/*Не ПравоДоступа("ИнтерактивноеДобавление", Метаданные.Документы.НачислениеПоБольничномуЛисту)*/)
			{
				//ОписаниеОшибки = НСтр("ru = 'У текущего пользователя нет прав на ввод начислений по больничному листу!'");
			}
			//СписокПараметров = ОбщегоНазначения.РазложитьСтрокуВМассивПодстрок(Сред(ОписаниеСобытия.Данные, 7), "!");
			if(true/*СписокПараметров.Количество() = 0*/)
			{
				//ОписаниеОшибки = НСтр("ru = 'В считанном штрихкоде отсутствуют сведения о листке нетрудоспособности!'");
			}
			/*// Прочитаем и заполним структуру реквизитов в зависимости от версии
*/
			/*// Имена полей в структуре должны совпадать с именами реквизитов документа
*/
			//СтруктураРеквизитов = Новый Структура;
			if(true/*СписокПараметров[0] = "01"*/)
			{
				//СтруктураРеквизитов.Вставить("НомерВходящегоДокумента",							СписокПараметров[1]);
				//ВходящийНомерПервичногоЛистка	= СписокПараметров[2];
				//СтруктураРеквизитов.Вставить("ЯвляетсяПродолжениемБолезни",						СписокПараметров[3] = "0");
				//СтруктураРеквизитов.Вставить("ЯвляетсяДубликатом",								СписокПараметров[4] = "1");
				//СтруктураРеквизитов.Вставить("ДатаВыдачиБольничного",							ДатаИзСтроки(СписокПараметров[5]));
				//СтруктураРеквизитов.Вставить("НаименованиеЛПУ",									СписокПараметров[6]);
				//СтруктураРеквизитов.Вставить("АдресЛПУ",										СписокПараметров[7]);
				//СтруктураРеквизитов.Вставить("ОГРН_ЛПУ",										СписокПараметров[8]);
				//СтруктураРеквизитов.Вставить("Фамилия",											СписокПараметров[9]);
				//СтруктураРеквизитов.Вставить("Имя",												СписокПараметров[10]);
				//СтруктураРеквизитов.Вставить("Отчество",										СписокПараметров[11]);
				//ДатаРожденияСотрудника	= ДатаИзСтроки(СписокПараметров[12]);
				//ВидЗанятостиСотрудника	= ?(СписокПараметров[15] = "0", Перечисления.ВидыЗанятостиВОрганизации.Совместительство, Перечисления.ВидыЗанятостиВОрганизации.ОсновноеМестоРаботы);
				//НаименованиеОрганизации	= СписокПараметров[14];
				//СтруктураРеквизитов.Вставить("КодПричиныНетрудоспособности",					СписокПараметров[16]);
				//СтруктураРеквизитов.Вставить("ДополнительныйКодПричиныНетрудоспособности",		СписокПараметров[17]);
				//СтруктураРеквизитов.Вставить("ВторойКодПричиныНетрудоспособности",				СписокПараметров[18]);
				//СтруктураРеквизитов.Вставить("НомерЛисткаПоОсновномуМестуРаботы",				СписокПараметров[19]);
				//СтруктураРеквизитов.Вставить("ДатаИзмененияКодаПричиныНетрудоспособности",		ДатаИзСтроки(СписокПараметров[21]));
				//СтруктураРеквизитов.Вставить("ДатаОкончанияПутевки",							ДатаИзСтроки(СписокПараметров[22]));
				//СтруктураРеквизитов.Вставить("НомерПутевки",									СписокПараметров[23]);
				//СтруктураРеквизитов.Вставить("ОГРН_Санатория",									СписокПараметров[24]);
				//УходЗаБольнымЧленомСемьи = Новый Массив;
				if(true/*СписокПараметров[28] <> ""*/)
				{
					//УходЗаБольнымЧленомСемьи.Добавить(Новый Структура("ВозрастЛет, ВозрастМесяцев, РодственнаяСвязь, ФИО", СписокПараметров[25], СписокПараметров[26], СписокПараметров[27], СписокПараметров[28]));
				}
				if(true/*СписокПараметров[32] <> ""*/)
				{
					//УходЗаБольнымЧленомСемьи.Добавить(Новый Структура("ВозрастЛет, ВозрастМесяцев, РодственнаяСвязь, ФИО", СписокПараметров[29], СписокПараметров[30], СписокПараметров[31], СписокПараметров[32]));
				}
				//СтруктураРеквизитов.Вставить("УходЗаБольнымЧленомСемьи",						УходЗаБольнымЧленомСемьи);
				//СтруктураРеквизитов.Вставить("ПоставленаНаУчетВРанниеСрокиБеременности",		СписокПараметров[33] = "1");
				//СтруктураРеквизитов.Вставить("ПериодНахожденияВСтационареСРебенкомС",			ДатаИзСтроки(СписокПараметров[34]));
				//СтруктураРеквизитов.Вставить("ПериодНахожденияВСтационареСРебенкомПо",			ДатаИзСтроки(СписокПараметров[35]));
				//СтруктураРеквизитов.Вставить("КодНарушенияРежима",								СписокПараметров[36]);
				//СтруктураРеквизитов.Вставить("ДатаНарушенияРежима",								ДатаИзСтроки(СписокПараметров[37]));
				//СтруктураРеквизитов.Вставить("ДатаНаправленияВБюроМСЭ",							ДатаИзСтроки(СписокПараметров[38]));
				//СтруктураРеквизитов.Вставить("ДатаРегистрацииДокументовМСЭ",					ДатаИзСтроки(СписокПараметров[39]));
				//СтруктураРеквизитов.Вставить("ДатаОсвидетельствованияМСЭ",						ДатаИзСтроки(СписокПараметров[40]));
				//СтруктураРеквизитов.Вставить("ГруппаИнвалидности",								СписокПараметров[41]);
				//СтруктураРеквизитов.Вставить("УстановленаИзмененаГруппаИнвалидности ",			СписокПараметров[41] <> "");
				//СтруктураРеквизитов.Вставить("ДатаНачала",										ДатаИзСтроки(СписокПараметров[42]));
				//СтруктураРеквизитов.Вставить("ДатаНачалаОплаты",								ДатаИзСтроки(СписокПараметров[42]));
				//СтруктураРеквизитов.Вставить("ДатаНачалаСобытия",								?(Не СтруктураРеквизитов.ЯвляетсяПродолжениемБолезни, ДатаИзСтроки(СписокПараметров[42]), Дата(1, 1, 1)));
				//СтруктураРеквизитов.Вставить("ДатаОкончания",									ДатаИзСтроки(СписокПараметров[43]));
				//ОсвобождениеОтРаботыВЛисткеНетрудоспособности = Новый Массив;
				if(true/*СписокПараметров[42] <> ""*/)
				{
					//ОсвобождениеОтРаботыВЛисткеНетрудоспособности.Добавить(Новый Структура("ДатаНачала, ДатаОкончания, ДолжностьВрача, ФИОВрача", ДатаИзСтроки(СписокПараметров[42]), ДатаИзСтроки(СписокПараметров[43]), СписокПараметров[44], СписокПараметров[45]));
				}
				if(true/*СписокПараметров[46] <> ""*/)
				{
					//ОсвобождениеОтРаботыВЛисткеНетрудоспособности.Добавить(Новый Структура("ДатаНачала, ДатаОкончания, ДолжностьВрача, ФИОВрача", ДатаИзСтроки(СписокПараметров[46]), ДатаИзСтроки(СписокПараметров[47]), СписокПараметров[48], СписокПараметров[49]));
				}
				if(true/*СписокПараметров[50] <> ""*/)
				{
					//ОсвобождениеОтРаботыВЛисткеНетрудоспособности.Добавить(Новый Структура("ДатаНачала, ДатаОкончания, ДолжностьВрача, ФИОВрача", ДатаИзСтроки(СписокПараметров[50]), ДатаИзСтроки(СписокПараметров[51]), СписокПараметров[52], СписокПараметров[53]));
				}
				//СтруктураРеквизитов.Вставить("ОсвобождениеОтРаботыВЛисткеНетрудоспособности",	ОсвобождениеОтРаботыВЛисткеНетрудоспособности);
				//СтруктураРеквизитов.Вставить("НовыйСтатусНетрудопособного",						СписокПараметров[54]);
				//СтруктураРеквизитов.Вставить("ДатаНовыйСтатусНетрудопособного",					ДатаИзСтроки(СписокПараметров[55]));
				//СтруктураРеквизитов.Вставить("ДатаВыходаНаРаботу",								ДатаИзСтроки(СписокПараметров[56]));
				//СтруктураРеквизитов.Вставить("НомерЛисткаПродолжения",							СокрЛП(СписокПараметров[57]));
				if(true/*СтруктураРеквизитов.КодПричиныНетрудоспособности = "01" Или СтруктураРеквизитов.КодПричиныНетрудоспособности = "02"*/)
				{
					//СтруктураРеквизитов.Вставить("ПричинаНетрудоспособности",					Перечисления.ПричиныНетрудоспособности.ОбщееЗаболевание);
					//СтруктураРеквизитов.Вставить("СлучайУходаЗаБольнымРебенком",				Перечисления.СлучаиУходаЗаБольнымиДетьми.ПустаяСсылка());
				}
			}
			if(true/*СтруктураРеквизитов.Свойство("ОГРН_ЛПУ")*/)
			{
				//СтруктураРеквизитов.Вставить("ЛПУ", Справочники.МедицинскиеОрганизации.НайтиПоРеквизиту("ОГРН",СтруктураРеквизитов.ОГРН_ЛПУ));
			}
			/*// Проверим наличие документа в ИБ
*/
			//СтруктураБольничных = ПолныеПраваЗК.НайтиБольничныеЛистыПоВходящемуНомеру(СтруктураРеквизитов.НомерВходящегоДокумента, ВходящийНомерПервичногоЛистка);
			//БольничныйЛист = СтруктураБольничных.БольничныйЛист;
			//СтруктураРеквизитов.Вставить("ПервичныйБольничныйЛист",	СтруктураБольничных.ПервичныйЛист);
			/*// Проверим, есть ли у текущего пользователя доступ к этому документу, а заодно прочитаем существующие значения документа
*/
			//СтруктураРеквизитовСуществующегоДокумента = Новый Структура("Сотрудник,Физлицо,ПервичныйБольничныйЛист,ЯвляетсяПродолжениемБолезни,ДатаНачала,ДатаОкончания,ПричинаНетрудоспособности");
			if(true/*БольничныйЛист <> Неопределено*/)
			{
				//Запрос = Новый Запрос;
				//Запрос.УстановитьПараметр("БольничныйЛист",	БольничныйЛист);
				/*Запрос.Текст =
		"ВЫБРАТЬ РАЗРЕШЕННЫЕ ПЕРВЫЕ 1
		|	НачислениеПоБольничномуЛисту.Сотрудник,
		|	НачислениеПоБольничномуЛисту.Физлицо,
		|	НачислениеПоБольничномуЛисту.ПервичныйБольничныйЛист,
		|	НачислениеПоБольничномуЛисту.ЯвляетсяПродолжениемБолезни,
		|	НачислениеПоБольничномуЛисту.ДатаНачала,
		|	НачислениеПоБольничномуЛисту.ДатаОкончания,
		|	НачислениеПоБольничномуЛисту.ПричинаНетрудоспособности
		|ИЗ
		|	Документ.НачислениеПоБольничномуЛисту КАК НачислениеПоБольничномуЛисту
		|ГДЕ
		|	НачислениеПоБольничномуЛисту.Ссылка = &БольничныйЛист
		|	И (НЕ НачислениеПоБольничномуЛисту.ПометкаУдаления)
		|
		|УПОРЯДОЧИТЬ ПО
		|	НачислениеПоБольничномуЛисту.ПериодРегистрации УБЫВ,
		|	НачислениеПоБольничномуЛисту.МоментВремени УБЫВ";*/
				//Результат = Запрос.Выполнить();
				if(true/*Результат.Пустой()*/)
				{
					//ОписаниеОшибки = "Документ начисления по больничному листу с входящим номером '" + СтруктураРеквизитов.НомерВходящегоДокумента + "' найден в базе, но не доступен текущему пользователю.";
				}
				//Выборка = Результат.Выбрать();
				//Выборка.Следующий();
				//ЗаполнитьЗначенияСвойств(СтруктураРеквизитовСуществующегоДокумента, Выборка);
			}
			/*// Проверим доступ к первичному больничному листу
*/
			if(true/*Не СтруктураБольничных.ПервичныйЛист.Пустая()*/)
			{
				//Запрос = Новый Запрос;
				//Запрос.УстановитьПараметр("БольничныйЛист",	СтруктураБольничных.ПервичныйЛист);
				/*Запрос.Текст =
		"ВЫБРАТЬ РАЗРЕШЕННЫЕ ПЕРВЫЕ 1
		|	НачислениеПоБольничномуЛисту.Сотрудник,
		|	НачислениеПоБольничномуЛисту.Физлицо
		|ИЗ
		|	Документ.НачислениеПоБольничномуЛисту КАК НачислениеПоБольничномуЛисту
		|ГДЕ
		|	НачислениеПоБольничномуЛисту.Ссылка = &БольничныйЛист
		|	И (НЕ НачислениеПоБольничномуЛисту.ПометкаУдаления)
		|
		|УПОРЯДОЧИТЬ ПО
		|	НачислениеПоБольничномуЛисту.ПериодРегистрации УБЫВ,
		|	НачислениеПоБольничномуЛисту.МоментВремени УБЫВ";*/
				//Результат = Запрос.Выполнить();
				if(true/*Результат.Пустой()*/)
				{
					//ОписаниеОшибки = "Первичный документ начисления по больничному листу с входящим номером '" + СтруктураРеквизитов.НомерВходящегоДокумента + "' найден в базе, но не доступен текущему пользователю.";
				}
				//Выборка = Результат.Выбрать();
				//Выборка.Следующий();
				//ЗаполнитьЗначенияСвойств(СтруктураРеквизитовСуществующегоДокумента, Выборка);
			}
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Фамилия",		СтруктураРеквизитов.Фамилия);
			//Запрос.УстановитьПараметр("Имя",			СтруктураРеквизитов.Имя);
			//Запрос.УстановитьПараметр("Отчество",		СтруктураРеквизитов.Отчество);
			//Запрос.УстановитьПараметр("ДатаРождения",	ДатаРожденияСотрудника);
			//Запрос.УстановитьПараметр("ВидЗанятости",	ВидЗанятостиСотрудника);
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ ПЕРВЫЕ 1
	|	Сотрудники.Ссылка КАК Сотрудник,
	|	Сотрудники.Физлицо,
	|	Сотрудники.ТекущееОбособленноеПодразделение КАК Организация
	|ИЗ
	|	Справочник.СотрудникиОрганизаций КАК Сотрудники
	|ГДЕ
	|	Сотрудники.Физлицо В
	|			(ВЫБРАТЬ
	|				ФИОФизЛицСрезПоследних.ФизЛицо
	|			ИЗ
	|				РегистрСведений.ФИОФизЛиц.СрезПоследних КАК ФИОФизЛицСрезПоследних
	|			ГДЕ
	|				ФИОФизЛицСрезПоследних.Фамилия = &Фамилия
	|				И ФИОФизЛицСрезПоследних.Имя = &Имя
	|				И ФИОФизЛицСрезПоследних.Отчество = &Отчество
	|				И ФИОФизЛицСрезПоследних.ФизЛицо.ДатаРождения = &ДатаРождения)
	|	И Сотрудники.ВидЗанятости = &ВидЗанятости
	|	И (НЕ Сотрудники.ПометкаУдаления)
	|	И Сотрудники.Актуальность
	|
	|УПОРЯДОЧИТЬ ПО
	|	Сотрудники.ДатаПриемаНаРаботу УБЫВ";*/
			//Выборка = Запрос.Выполнить().Выбрать();
			if(true/*Выборка.Следующий()*/)
			{
				//СтруктураРеквизитов.Вставить("Сотрудник",	Выборка.Сотрудник);
				//СтруктураРеквизитов.Вставить("Физлицо",		Выборка.Физлицо);
				//СтруктураРеквизитов.Вставить("Организация",	Выборка.Организация);
			}
			/*// Проверим реквизиты существующего больничного на расхождения с данными сканера
*/
			//ПерезаполнитьДокумент = Истина;
			if(true/*БольничныйЛист <> Неопределено*/)
			{
				//ЕстьРазличия = Ложь;
				//ТекстВопроса = "Найденный документ по начислению больничного листа имеет следующие расхождения:";
				//ТекстВопроса = ТекстВопроса + Символы.ПС + "Выполнить перезаполнение документа?";
				if(true/*ЕстьРазличия*/)
				{
					//Ответ = Вопрос(ТекстВопроса, РежимДиалогаВопрос.ДаНет, , КодВозвратаДиалога.Нет);
					//ПерезаполнитьДокумент = Ответ = КодВозвратаДиалога.Да;
				}
			}
			//Запрос.УстановитьПараметр("НаименованиеОрганизации",	НаименованиеОрганизации);
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	Организации.Ссылка КАК Организация
	|ИЗ
	|	Справочник.Организации КАК Организации
	|ГДЕ
	|	(Организации.НаименованиеСокращенное = &НаименованиеОрганизации
	|			ИЛИ Организации.Наименование = &НаименованиеОрганизации)
	|
	|УПОРЯДОЧИТЬ ПО
	|	Организации.ПометкаУдаления УБЫВ";*/
			//Выборка = Запрос.Выполнить().Выбрать();
			if(true/*Выборка.Следующий()*/)
			{
				//СтруктураРеквизитов.Вставить("Организация",	Выборка.Организация);
			}
			if(true/*БольничныйЛист = Неопределено*/)
			{
				/*// Создадим новый документ
*/
				//Форма = Документы.НачислениеПоБольничномуЛисту.ПолучитьФормуНовогоДокумента(, , СтруктураРеквизитов.НомерВходящегоДокумента);
			}
			if(true/*ПерезаполнитьДокумент*/)
			{
				//ЗаполнитьЗначенияСвойств(Форма, СтруктураРеквизитов);
				//Форма.УходЗаБольнымЧленомСемьи.Очистить();
				//Форма.ОсвобождениеОтРаботыВЛисткеНетрудоспособности.Очистить();
				//Форма.ЗаполнитьОтсканированныйДокумент();
			}
			//Форма.Открыть();
			//Форма.Модифицированность = ПерезаполнитьДокумент;
			return null;
		}
	}
}
