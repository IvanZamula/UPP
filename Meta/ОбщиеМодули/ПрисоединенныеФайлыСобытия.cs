using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПрисоединенныеФайлыСобытия
	{
		////////////////////////////////////////////////////////////////////////////////
		// Обработчики событий обмена
		// Проверяет, что переданный элемент данных - это объект присоединенного файла
		//

		public object ЭтоЭлементПрисоединенныеФайлы(/*ЭлементДанных*/)
		{
			//Подстроки = СтроковыеФункцииКлиентСервер.РазложитьСтрокуВМассивПодстрок(ЭлементДанных.Метаданные().ПолноеИмя(), ".");
			if(true/*(Подстроки[0] = "Справочник" ИЛИ Подстроки[0] = "Catalog") И Прав(Подстроки[1], 19) = "ПрисоединенныеФайлы"*/)
			{
			}
			return null;
		}
	}
}
