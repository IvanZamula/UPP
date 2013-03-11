﻿Ext.define('Отчеты.АнализСубконтоХозрасчетный.Форма',
	{
	extend: 'Ext.window.Window',
	height: 437,width: 731,
	iconCls: 'bogus',
	title: 'Анализ субконто',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:731px;height:25px;',
			items:
			[
				{
					text:'Разделитель6',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Настройка',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие2',
				},
				{
					text:'Настройка',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Субконто',
				},
				{
					text:'Заголовок',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Сформировать',
				},
				{
					text:'Заголовок',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Субконто',
				},
				{
					text:'Подменю',
				},
				{
					text:'Сформировать',
				},
				{
					text:'Разделитель4',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:523px;top:32px;width:200px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНач',
			style: 'position:absolute;left:66px;top:32px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаКон',
			style: 'position:absolute;left:166px;top:32px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:248px;top:32px;width:19px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:56px;width:715px;height:122px;',
			height: 122,width: 715,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:44px;width:320px;height:70px;',
			height: 70,width: 320,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ВидСубконто',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:19px;width:320px;height:24px;',
			items:
			[
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:326px;top:44px;width:388px;height:70px;',
			height: 70,width: 388,
			columns:
			[
				{
					text:'Использование',
				},
				{
					text:'Имя',
				},
				{
					text:'ВидСравнения',
				},
				{
					text:'Значение',
				},
				{
					text:'ЗначениеС',
				},
				{
					text:'ЗначениеПо',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:326px;top:19px;width:388px;height:24px;',
			items:
			[
			]
		},
					]
				},
			]
		},
	]
});