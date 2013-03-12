﻿Ext.define('Отчеты.СправкаРасчетНормированияРасходов.Отчет',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:604px;height:416px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Нормирование расходов',
	
	items:
	[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Организация:',
			style: 'position:absolute;left:178px;top:33px;width:72px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:252px;top:33px;width:344px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:604px;height:25px;',
			items:
			[
				{
					text:'Сформировать',
				},
				{
					text:'Подписи',
				},
				'-',
				{
					text:'Заголовок',
				},
				'-',
				{
					text:'Сформировать',
				},
				'-',
				{
					text:'Подписи',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие',
				},
				{
					text:'Заголовок',
				},
				'-',
				{
					text:'Настройка',
				},
				'-',
				{
					text:'Действие1',
				},
				'-',
			]
		},
		{
			xtype: 'label',
			name: 'НадписьПериод',
			text: 'Период:',
			style: 'position:absolute;left:8px;top:33px;width:53px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПредставлениеПериодаРегистрации',
			style: 'position:absolute;left:61px;top:33px;width:109px;height:19px;',
		},
	]
});