﻿Ext.define('Справочники.ФизическиеЛица.ФормаВводаДанныхНДФЛСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','ДатаРождения','ИНН','КодИМНС','Комментарий','СтраховойНомерПФР','Пол','Пол.Ссылка','Пол.Представление','МестоРождения','ОсновноеИзображение','ОсновноеИзображение.Ссылка','ОсновноеИзображение.Представление','МестоРожденияКодПоОКАТО','ГруппаДоступаФизическогоЛица','ГруппаДоступаФизическогоЛица.Ссылка','ГруппаДоступаФизическогоЛица.Представление','ЛьготаПриНачисленииПособий','ЛьготаПриНачисленииПособий.Ссылка','ЛьготаПриНачисленииПособий.Представление','ИмеетНаучныеТруды','ИмеетИзобретения',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/ФизическиеЛица/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.ФизическиеЛица.ФормаЭлемента'], function ()
				{
					var количество = хранилище.getCount();
					if (количество == 0)
					{
						var массивЗначений = строкаЗначений;
					}
					else
					{
						var массивЗначений = хранилище.data.items[0].data;
					};
					var окно = Ext.create('Справочники.ФизическиеЛица.ФормаЭлемента',
					{
						Хранилище: массивЗначений.Родитель,
					});
					var форма = окно.down('form');
					форма.getForm().setValues(массивЗначений);
					if (окно)
					{
						окно.show();
						return окно;
					}
				});
			},
			scope: this
		});
	}
});