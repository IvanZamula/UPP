﻿Ext.define('Справочники.ТиповыеАнкеты.ФормаОбязательногоВопроса',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:294px;height:303px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка обязательности ответа на вопрос',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:278px;width:294px;height:25px;',
			items:
			[
				'-',
				{
					text:'ОК',
				},
				{
					text:'Отмена',
				},
				'-',
				{
					text:'Действие',
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Надпись1',
			style: 'position:absolute;left:25px;top:109px;width:261px;height:27px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВопросУсловия',
			style: 'position:absolute;left:25px;top:140px;width:261px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'получен ответ',
			style: 'position:absolute;left:25px;top:163px;width:80px;height:16px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответ',
			style: 'position:absolute;left:160px;top:183px;width:126px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Надпись3',
			style: 'position:absolute;left:8px;top:8px;width:278px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:159px;top:182px;width:127px;height:88px;',
			height: 88,width: 127,
			columns:
			[
				{
					text:'Значение списка',
					width:'100',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'УсловиеОтвета',
			style: 'position:absolute;left:25px;top:183px;width:129px;height:19px;',
		},
	]
});