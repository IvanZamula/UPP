﻿Ext.define('Отчеты.РегламентированныйОтчетЕСН.ФормаОтчета2007Кв1',
	{
	extend: 'Ext.window.Window',
	height: 491,width: 721,
	iconCls: 'bogus',
	title: 'Декларация по ЕСН',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:721px;height:25px;',
			items:
			[
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Справка',
				},
				{
					text:'КнопкаЗаполнитьСведенияОбОрганизации',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'РазделительОтправка',
				},
				{
					text:'Подготовить',
				},
				{
					text:'Проверить',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ПоказатьЦиклыОбмена',
				},
				{
					text:'РазделительЗаполнить',
				},
				{
					text:'Отправка',
				},
				{
					text:'ПодменюОчистить',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Отправить',
				},
				{
					text:'Расшифровать',
				},
				{
					text:'Выгрузка',
				},
				{
					text:'ВыбратьВариантОчисткиОтчета',
				},
				{
					text:'РазделительРасшифровать',
				},
				{
					text:'ПодготовитьИПодписать',
				},
				{
					text:'Проверить',
				},
				{
					text:'РасширитьПолеБланка',
				},
				{
					text:'Поиск',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Заполнить',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'КнопкаНастройкаСтраниц',
				},
				{
					text:'Выгрузить',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:466px;width:721px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Записать',
				},
				{
					text:'СохранитьИЗакрыть',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ПодменюПечати',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:124px;width:705px;height:310px;',
			height: 310,width: 705,
			items:
			[
				{
					title:'Титульный',
				},
				{
					title:'Раздел1',
				},
				{
					title:'Раздел2',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:260px;width:691px;height:24px;',
			height: 24,width: 691,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел2',
			style: 'position:absolute;left:237px;top:5px;width:117px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел2',
			style: 'position:absolute;left:358px;top:5px;width:333px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел21',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:260px;width:691px;height:24px;',
			height: 24,width: 691,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел21',
			style: 'position:absolute;left:237px;top:5px;width:117px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел21',
			style: 'position:absolute;left:358px;top:5px;width:333px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел21Продолжение',
				},
				{
					title:'Раздел3',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел3',
			text: 'Добавить',
			style: 'position:absolute;left:531px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел3',
			text: 'Удалить',
			style: 'position:absolute;left:617px;top:265px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Раздел31',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:74px;width:705px;height:50px;',
			height: 50,width: 705,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаТочностьЕдиницыИзмерения',
			style: 'position:absolute;left:230px;top:0px;width:32px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаДатаСдачи',
			style: 'position:absolute;left:86px;top:24px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерКорректировки',
			style: 'position:absolute;left:559px;top:24px;width:49px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:434px;width:705px;height:24px;',
			height: 24,width: 705,
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
			style: 'position:absolute;left:263px;top:5px;width:442px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Статус',
			style: 'position:absolute;left:47px;top:5px;width:119px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:705px;height:37px;',
			height: 37,width: 705,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:2px;top:0px;width:703px;height:35px;',
			height: 35,width: 703,
			items:
			[
				{
					title:'Страница1',
					items:
					[
					]
				},
			]
		},
					]
				},
			]
		},
	]
});