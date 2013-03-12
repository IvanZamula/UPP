﻿Ext.define('Справочники.Кассы.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:515px;height:189px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Кассы',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:405px;top:84px;width:40px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:447px;top:84px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:84px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:94px;top:84px;width:310px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРодитель',
			text: 'Группа касс:',
			style: 'position:absolute;left:8px;top:57px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Родитель',
			style: 'position:absolute;left:94px;top:57px;width:413px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалютаДенежныхСредств',
			text: 'Валюта:',
			style: 'position:absolute;left:8px;top:108px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВалютаДенежныхСредств',
			style: 'position:absolute;left:94px;top:108px;width:80px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:515px;height:25px;',
			items:
			[
				'-',
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:164px;width:515px;height:25px;',
			items:
			[
				'-',
				{
					text:'Записать',
				},
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'OK',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственноеЛицо',
			text: 'Ответственное лицо:',
			style: 'position:absolute;left:8px;top:129px;width:84px;height:27px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ОтветственноеЛицо',
			style: 'position:absolute;left:94px;top:134px;width:310px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаИстория',
			text: 'История...',
			style: 'position:absolute;left:431px;top:134px;width:76px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВладелец',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:33px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Владелец',
			style: 'position:absolute;left:94px;top:33px;width:413px;height:19px;',
		},
	]
});