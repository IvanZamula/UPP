﻿Ext.define('Отчеты.ПланФактныйАнализПродаж.Форма',
	{
	extend: 'Ext.window.Window',
	height: 450,width: 780,
	iconCls: 'bogus',
	title: '',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:508px;height:25px;',
			items:
			[
				{
					text:'ВосстановитьНастройку',
				},
				{
					text:'НовыйОтчет',
				},
				{
					text:'ВосстановитьНастройку',
				},
				{
					text:'РазделительБыстрыеОтборыЗаголовокОтчета',
				},
				{
					text:'РазделительДействия',
				},
				{
					text:'СохранитьНастройку',
				},
				{
					text:'Настройка',
				},
				{
					text:'ЗаголовокОтчета',
				},
				{
					text:'РазделительСформировать',
				},
				{
					text:'РазделительСохранитьВосстановитьНастройку',
				},
				{
					text:'Сформировать',
				},
				{
					text:'РазделительБыстрыеОтборыЗаголовокОтчета',
				},
				{
					text:'РазделительНастройка',
				},
				{
					text:'РазделительСформировать',
				},
				{
					text:'Справка',
				},
				{
					text:'Справка',
				},
				{
					text:'НовыйОтчет',
				},
				{
					text:'БыстрыеОтборы',
				},
				{
					text:'РазделительНастройка',
				},
				{
					text:'Сформировать',
				},
				{
					text:'РазделительНовыйОтчет',
				},
				{
					text:'СохранитьНастройку',
				},
				{
					text:'Настройка',
				},
				{
					text:'Подменю',
				},
				{
					text:'ДействиеЗакрыть',
				},
				{
					text:'РазделительСохранитьВосстановитьНастройку',
				},
				{
					text:'ЗаголовокОтчета',
				},
				{
					text:'БыстрыеОтборы',
				},
				{
					text:'РазделительНовыйОтчет',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:513px;top:3px;width:259px;height:19px;',
			height: 19,width: 259,
			items:
			[
				{
					title:'СтраницаПроизвольныйПериод',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаДатаНач',
			style: 'position:absolute;left:57px;top:0px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаДатаКон',
			style: 'position:absolute;left:157px;top:0px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:239px;top:0px;width:20px;height:19px;',
		},
					]
				},
				{
					title:'СтраницаНаДату',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаНаДату',
			style: 'position:absolute;left:179px;top:0px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'СтраницаПериод',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаМинусПериод',
			text: '-',
			style: 'position:absolute;left:85px;top:0px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПлюсПериод',
			text: '+',
			style: 'position:absolute;left:239px;top:0px;width:20px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:508px;top:0px;width:272px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:73px;width:764px;height:80px;',
			height: 80,width: 764,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ТипДанных',
				},
				{
					text:'Сценарий',
				},
				{
					text:'ДатаНач',
				},
				{
					text:'ДатаКон',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:49px;width:764px;height:24px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'РежимВыбораДатПериодом',
				},
			]
		},
	]
});