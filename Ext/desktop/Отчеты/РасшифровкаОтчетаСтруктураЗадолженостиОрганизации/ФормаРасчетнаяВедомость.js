﻿Ext.require(['Данные.Отчеты.РасшифровкаОтчетаСтруктураЗадолженостиОрганизации'], function () 
{
	Ext.define('Отчеты.РасшифровкаОтчетаСтруктураЗадолженостиОрганизации.ФормаРасчетнаяВедомость',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаРасчетнаяВедомость',
	style: 'position:absolute;width:879px;height:487px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Расшифровка отчета ',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		],
	}],
	dockedItems:
	[
	],
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
						//ПривязкаГраниц(item, item.ПозицияЭлемента);
						if (item.Групповой)
						{
							var элемент = Ext.getCmp(item.id).items.items[0].items.items;
							for (var i = 0; i < элемент.length; i++ ) 
							{
								var текЭлемент = элемент[i];
								//ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
							}
						}
					});
				}
				форма.ПервоеОткрытие = false;
			}
		}
	}
	});
});