﻿Ext.define('Справочники.ТочкиМаршрута.ФормаГруппы',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:429px;height:109px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Группа Точки маршрута',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:315px;top:57px;width:40px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:357px;top:57px;width:64px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:57px;width:79px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:93px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьГруппа',
			text: 'Группа:',
			style: 'position:absolute;left:8px;top:33px;width:79px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Родитель',
			style: 'position:absolute;left:93px;top:33px;width:328px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:429px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:84px;width:429px;height:25px;',
			items:
			[
				'-',
				{
					text:'OK',
				},
				{
					text:'Записать',
				},
				{
					text:'Закрыть',
				},
				'-',
			]
		},
	]
});