using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ОбновлениеИнформационнойБазыКлиент
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПУСКАЛЬЩИК ИНТЕРАКТИВНОГО ОБНОВЛЕНИЯ
		// Проверить, есть ли необходимость выполнять обновление информационной базы,
		// и если необходимо - выполняется обновление.
		// Если обновление не удалось выполнить, то процедура предлагает завершить работу системы.
		//

		public void ВыполнитьОбновлениеИнформационнойБазы(/**/)
		{
			if(true/*НЕ ОбновлениеИнформационнойБазы.НеобходимоОбновлениеИнформационнойБазы()*/)
			{
			}
			/*// Выполняем обновление, если оно получено легально
*/
			if(true/*НЕ ПроверкаЛегальностиПолученияОбновленияКлиент.ПодтвердитьЛегальностьПолученияОбновления()*/)
			{
			}
			//Состояние(НСтр("ru = 'Пожалуйста, подождите, выполняется обновление информационной базы...'"));
			/*// Обработка данных, связанная с изменением конфигурации
*/
			//Ошибка                 = Ложь;
			//ТекстСообщенияОбОшибке = "";
			/*// Интерактивные действия после обработки данных
*/
			if(true/*Ошибка*/)
			{
				//Состояние("");
				/*ТекстВопроса = НСтр("ru = 'Не выполнено обновление информационной базы! 
		|Завершить работу системы?'");*/
				//Заголовок    = НСтр("ru = 'Ошибка при обновлении информационной базы'");
				//Ответ = Вопрос(ТекстВопроса, РежимДиалогаВопрос.ДаНет, , КодВозвратаДиалога.Да, Заголовок);
				if(true/*Ответ = КодВозвратаДиалога.Да*/)
				{
					//ВызватьИсключение ТекстСообщенияОбОшибке;
				}
			}
		}
		// Проверить, возможно ли выполнять обновление информационной базы.
		//

		public object ВозможноВыполнитьОбновлениеИнформационнойБазы(/**/)
		{
			//Результат = СтандартныеПодсистемыКлиентПовтИсп.ПараметрыРаботыКлиента().ИнформационнаяБазаЗаблокированаДляОбновления;
			if(true/*Результат*/)
			{
				/*Сообщение = НСтр("ru = 'Информационная база заблокирована в связи с обновлением версии конфигурации. Работа системы будет завершена.
		                       |Обратитесь к системному администратору за подробностями.'");*/
				//Предупреждение(Сообщение);
			}
			return null;
		}
	}
}
