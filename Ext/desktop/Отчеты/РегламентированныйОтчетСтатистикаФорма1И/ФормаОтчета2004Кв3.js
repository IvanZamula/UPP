﻿Ext.define('Отчеты.РегламентированныйОтчетСтатистикаФорма1И.ФормаОтчета2004Кв3',
	{
	extend: 'Ext.window.Window',
	height: 395,width: 716,
	iconCls: 'bogus',
	title: 'Статистика: Форма 1-Инвест',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:716px;height:25px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'КнопкаЗаполнитьСведенияОбОрганизации',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Очистить',
				},
				{
					text:'Поиск',
				},
				{
					text:'РасширитьПолеБланка',
				},
				{
					text:'Разделитель5',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:370px;width:716px;height:25px;',
			items:
			[
				{
					text:'ПодменюПечати',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'СохранитьИЗакрыть',
				},
				{
					text:'Записать',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:700px;height:27px;',
			height: 27,width: 700,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаДатаСдачи',
			style: 'position:absolute;left:82px;top:0px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерКорректировки',
			style: 'position:absolute;left:308px;top:0px;width:49px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:337px;width:700px;height:25px;',
			height: 25,width: 700,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:263px;top:6px;width:437px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Статус',
			style: 'position:absolute;left:47px;top:6px;width:119px;height:19px;',
		},
					]
				},
			]
		},
	]
});