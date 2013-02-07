using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СтандартныеПодсистемыКлиентПереопределяемый
	{
		/////////////////////////////////////////////////////////////////////////////////
		// БазоваяФункциональность
		//
		// Вызывается при завершении работы системы, чтобы запросить список предупреждений,
		// выводимых пользователю пользователю.
		//
		// Параметры:
		//	Предупреждения - Массив - список предупреждений. Элемент массива - Структура с полями:
		//		ТекстФлажка - Строка - текст флажка.
		//		ПоясняющийТекст - Строка - текст, выводимый в форме сверху управляющего элемента (флажок или гиперссылка).
		//		ДействиеПриУстановленномФлажке - Структура с полями:
		//			Форма - путь к открываемой форме.
		//			ПараметрыФормы - произвольная структура параметров формы Форма.
		//		ТекстГиперссылки - Строка - текст гипперссылки.
		//		ДействиеПриНажатииГипперссылки - Структура с полями:
		//			Форма - Строка - путь к форме, которая должна открываться по нажатию на гиперссылку.
		//			ПараметрыФормы - Структура - произвольная структура параметров для вышеописанной формы.
		//			ПрикладнаяФормаПредупреждения - Строка - путь к форме, которая должна открываться сразу вместо
		//				универсальной формы в случае, когда в списке предупреждений оказывется только одно данное предупреждение.
		//			ПараметрыПрикладнойФормыПредупреждения - Структура - произвольная структура параметров для вышеописанной формы.
		//

		public void ПолучитьСписокПредупреждений(/*Предупреждения*/)
		{
		}
		// Вызывается при необходимости открыть форму списка активных пользователей,
		// которые в данный момент времени работают с системой.
		//
		// Пример реализации:
		// - при внедрении подсистемы "Завершение работы пользователей" можно использовать форму обработки АктивныеПользователи:
		//   ОткрытьФорму("Обработка.АктивныеПользователи.Форма.ФормаСпискаАктивныхПользователей");
		//

		public void ОткрытьСписокАктивныхПользователей(/**/)
		{
			/*// ЗавершениеРаботыПользователей
*/
			//ОткрытьФорму("Обработка.АктивныеПользователи.Форма.ФормаСпискаАктивныхПользователей");
			/*// Конец ЗавершениеРаботыПользователей
*/
		}
	}
}
