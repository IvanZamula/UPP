using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЖурналРегистрацииКлиент
	{
		// Процедура открывает форму для просмотра дополнительных данных события
		//

		public void ОткрытьДанныеДляПросмотра(/*ТекущиеДанные*/)
		{
			if(true/*ТекущиеДанные = Неопределено Или ТекущиеДанные.Данные = Неопределено*/)
			{
				//Предупреждение(НСтр("ru = 'Эта запись журнала регистрации не связана с данными (см. колонку ""Данные"")'"));
			}
		}
		// ОткрытьДанныеДляПросмотра
		// Процедура открывает форму просмотра события обработки "Журнал регистрации"
		//  для отображения в ней подробных данных выбранного события
		//

		public void ПросмотрТекущегоСобытияВОтдельномОкне(/*Данные*/)
		{
			if(true/*Данные = Неопределено*/)
			{
			}
			//ПараметрыФормы = Новый Структура;
			//ПараметрыФормы.Вставить("Дата",                    Данные.Дата);
			//ПараметрыФормы.Вставить("ИмяПользователя",         Данные.ИмяПользователя);
			//ПараметрыФормы.Вставить("ПредставлениеПриложения", Данные.ПредставлениеПриложения);
			//ПараметрыФормы.Вставить("Компьютер",               Данные.Компьютер);
			//ПараметрыФормы.Вставить("Событие",                 Данные.Событие);
			//ПараметрыФормы.Вставить("ПредставлениеСобытия",    Данные.ПредставлениеСобытия);
			//ПараметрыФормы.Вставить("Комментарий",             Данные.Комментарий);
			//ПараметрыФормы.Вставить("ПредставлениеМетаданных", Данные.ПредставлениеМетаданных);
			//ПараметрыФормы.Вставить("Данные",                  Данные.Данные);
			//ПараметрыФормы.Вставить("ПредставлениеДанных",     Данные.ПредставлениеДанных);
			//ПараметрыФормы.Вставить("Транзакция",              Данные.Транзакция);
			//ПараметрыФормы.Вставить("СтатусТранзакции",        Данные.СтатусТранзакции);
			//ПараметрыФормы.Вставить("Сеанс",                   Данные.Сеанс);
			//ПараметрыФормы.Вставить("РабочийСервер",           Данные.РабочийСервер);
			//ПараметрыФормы.Вставить("ОсновнойIPПорт",          Данные.ОсновнойIPПорт);
			//ПараметрыФормы.Вставить("ВспомогательныйIPПорт",   Данные.ВспомогательныйIPПорт);
			if(true/*ЗначениеЗаполнено(Данные.АдресДанных)*/)
			{
				//ПараметрыФормы.Вставить("АдресДанных", Данные.АдресДанных);
			}
			//ОткрытьФорму("Обработка.ЖурналРегистрации.Форма.ФормаСобытия", ПараметрыФормы);
		}
		// ПросмотрТекущегоСобытияВОтдельномОкне
		// Функция запрашивает у пользователя ограничение периода
		// и включает его в отбор журнала регистрации
		//
		// Параметры:
		//	ИнтервалДат - СтандартныйПериод, интервал дат отбора
		//	ОтборЖурналаРегистрации - Структура, отбор журнала регистрации
		//

		public object УстановитьИнтервалДатДляПросмотра(/*ИнтервалДат, ОтборЖурналаРегистрации*/)
		{
			//ИнтервалУстановлен = Ложь;
			/*// Получение текущего периода
*/
			//ДатаНачала    = Неопределено;
			//ДатаОкончания = Неопределено;
			//ОтборЖурналаРегистрации.Свойство("ДатаНачала", ДатаНачала);
			//ОтборЖурналаРегистрации.Свойство("ДатаОкончания", ДатаОкончания);
			//ДатаНачала    = ?(ТипЗнч(ДатаНачала)    = Тип("Дата"), ДатаНачала, '00010101000000');
			//ДатаОкончания = ?(ТипЗнч(ДатаОкончания) = Тип("Дата"), ДатаОкончания, '00010101000000');
			if(true/*ИнтервалДат.ДатаНачала <> ДатаНачала*/)
			{
				//ИнтервалДат.ДатаНачала = ДатаНачала;
			}
			if(true/*ИнтервалДат.ДатаОкончания <> ДатаОкончания*/)
			{
				//ИнтервалДат.ДатаОкончания = ДатаОкончания;
			}
			/*// Редактирование текущего периода
*/
			//Диалог = Новый ДиалогРедактированияСтандартногоПериода;
			//Диалог.Период = ИнтервалДат;
			if(true/*Диалог.Редактировать()*/)
			{
				/*// Обновление текущего периода
*/
				//ИнтервалДат = Диалог.Период;
				if(true/*ИнтервалДат.ДатаНачала = '00010101000000'*/)
				{
					//ОтборЖурналаРегистрации.Удалить("ДатаНачала");
				}
				if(true/*ИнтервалДат.ДатаОкончания = '00010101000000'*/)
				{
					//ОтборЖурналаРегистрации.Удалить("ДатаОкончания");
				}
				//ИнтервалУстановлен = Истина;
			}
			return null;
		}
		// УстановитьИнтервалДатДляПросмотра
		// Процедура выполняет обработку выбора отдельного события в таблице событий
		//

		public void СобытияВыбор(/*ТекущиеДанные, Поле, ИнтервалДат, ОтборЖурналаРегистрации*/)
		{
			if(true/*ТекущиеДанные = Неопределено*/)
			{
			}
			if(true/*Поле.Имя = "Данные" Или Поле.Имя = "ПредставлениеДанных"*/)
			{
				if(true/*ТекущиеДанные.Данные <> Неопределено И (ТипЗнч(ТекущиеДанные.Данные) <> Тип("Строка") И ЗначениеЗаполнено(ТекущиеДанные.Данные))*/)
				{
					//ОткрытьДанныеДляПросмотра(ТекущиеДанные);
				}
			}
			if(true/*Поле.Имя = "Дата"*/)
			{
				//УстановитьИнтервалДатДляПросмотра(ИнтервалДат, ОтборЖурналаРегистрации);
			}
			//ПросмотрТекущегоСобытияВОтдельномОкне(ТекущиеДанные);
		}
		// СобытияВыбор
		// Процедура заполняет отбор в соответствии с значением в текущей колонке событий
		//

		public object УстановитьОтборПоЗначениюВТекущейКолонке(/*ТекущиеДанные, ТекущийЭлемент, ОтборЖурналаРегистрации, КолонкиИсключения*/)
		{
			if(true/*ТекущиеДанные = Неопределено*/)
			{
			}
			//ИмяКолонкиПредставления = ТекущийЭлемент.Имя;
			if(true/*КолонкиИсключения.Найти(ИмяКолонкиПредставления) <> Неопределено*/)
			{
			}
			//ЗначениеОтбора = ТекущиеДанные[ИмяКолонкиПредставления];
			//Представление  = ТекущиеДанные[ИмяКолонкиПредставления];
			//ИмяЭлементаОтбора = ИмяКолонкиПредставления;
			if(true/*ИмяКолонкиПредставления = "ИмяПользователя"*/)
			{
				//ИмяЭлементаОтбора = "Пользователь";
				//ЗначениеОтбора = ТекущиеДанные["Пользователь"];
			}
			/*// По пустым строкам не отбираем
*/
			if(true/*ТипЗнч(ЗначениеОтбора) = Тип("Строка") И ПустаяСтрока(ЗначениеОтбора)*/)
			{
				/*// Для пользователя по умолчанию имя пустое, разрешаем отбирать
*/
				if(true/*ИмяКолонкиПредставления <> "ИмяПользователя"*/)
				{
				}
			}
			//ТекущееЗначение = Неопределено;
			if(true/*ОтборЖурналаРегистрации.Свойство(ИмяЭлементаОтбора, ТекущееЗначение)*/)
			{
				/*// Уже установлен отбор
*/
				//ОтборЖурналаРегистрации.Удалить(ИмяЭлементаОтбора);
			}
			return null;
		}
	}
}
