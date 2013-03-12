﻿Ext.define('Отчеты.РегламентированныйОтчетСтатистикаФорма11К.ФормаОтчета2005Кв1',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:716px;height:395px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Статистика: Форма 11К: ""Сведения о наличии и движении основных фондов (средств) некоммерческих организаций',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:716px;height:25px;',
			items:
			[
				'-',
				'-',
				{
					text:'Поиск',
				},
				{
					text:'Расширить поле бланка',
				},
				'-',
				{
					text:'Действие2',
				},
				{
					text:'Обновить',
				},
				'-',
				{
					text:'Очистить',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:370px;width:716px;height:25px;',
			items:
			[
				{
					text:'Записать',
				},
				{
					text:'Закрыть',
				},
				'-',
				'-',
				'-',
				{
					text:'ОК',
				},
			]
		},
		{
			xtype: 'label',
			name: '_ИндикаторВнешнегоОтчета',
			text: 'Внешний отчет',
			style: 'position:absolute;left:630px;top:5px;width:78px;height:15px;',
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
			style: 'position:absolute;left:318px;top:0px;width:49px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:340px;width:700px;height:22px;',
			height: 22,width: 700,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:183px;top:3px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:263px;top:3px;width:437px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Статус',
			style: 'position:absolute;left:47px;top:3px;width:119px;height:19px;',
		},
					]
				},
			]
		},
	]
});