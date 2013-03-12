﻿Ext.define('Отчеты.ОрганизационнаяСтруктура.ФормаОтчета',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:838px;height:596px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Шаблон типового отчета',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:525px;top:134px;width:306px;height:458px;',
			height: 458,width: 306,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:306px;height:432px;',
			height: 432,width: 306,
			items:
			[
				{
					title:'Параметры',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:292px;height:74px;',
			height: 74,width: 292,
			columns:
			[
				{
					text:'',
					width:'20',
				},
				{
					text:'Параметр',
					width:'100',
				},
				{
					text:'Значение',
					width:'100',
				},
				{
					text:'Параметр',
					width:'100',
				},
				{
					text:'Значение',
					width:'50',
				},
				{
					text:'Дата',
					width:'50',
				},
				{
					text:'Дата начала',
					width:'100',
				},
				{
					text:'Дата окончания',
					width:'100',
				},
			]
		},
					]
				},
				{
					title:'Отбор',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:292px;height:119px;',
			height: 119,width: 292,
			columns:
			[
				{
					text:'',
					width:'20',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'44',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Поле',
					width:'42',
				},
				{
					text:'Вид сравнения',
					width:'21',
				},
				{
					text:'Значение',
					width:'56',
				},
				{
					text:'Тип группы',
					width:'120',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Тип группы',
					width:'120',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'44',
				},
				{
					text:'Применение',
					width:'36',
				},
				{
					text:'Представление',
					width:'41',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'34',
				},
				{
					text:'Значение',
					width:'42',
				},
				{
					text:'Применение',
					width:'33',
				},
				{
					text:'Тип группы',
					width:'120',
				},
				{
					text:'Применение',
					width:'33',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Тип группы',
					width:'120',
				},
				{
					text:'Применение',
					width:'33',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'44',
				},
				{
					text:'Режим отображения',
					width:'33',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Тип группы',
					width:'120',
				},
				{
					text:'Режим отображения',
					width:'33',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'22',
				},
				{
					text:'Дата',
					width:'22',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'22',
				},
				{
					text:'Дата',
					width:'22',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'22',
				},
				{
					text:'Дата',
					width:'22',
				},
				{
					text:'Применение',
					width:'33',
				},
				{
					text:'Представление',
					width:'44',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'22',
				},
				{
					text:'Дата',
					width:'22',
				},
				{
					text:'Применение',
					width:'33',
				},
				{
					text:'Поле',
					width:'44',
				},
				{
					text:'Вид сравнения',
					width:'33',
				},
				{
					text:'Значение',
					width:'22',
				},
				{
					text:'Дата',
					width:'22',
				},
				{
					text:'Режим отображения',
					width:'33',
				},
				{
					text:'Представление',
					width:'44',
				},
			]
		},
					]
				},
				{
					title:'Показатели',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:292px;height:129px;',
			height: 129,width: 292,
			columns:
			[
				{
					text:'',
					width:'21',
				},
				{
					text:'Представление',
					width:'100',
				},
				{
					text:'Поле',
					width:'249',
				},
			]
		},
					]
				},
				{
					title:'Сортировка',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:253px;height:83px;',
			height: 83,width: 253,
			columns:
			[
				{
					text:'',
					width:'20',
				},
				{
					text:'Поле сортировки',
					width:'100',
				},
				{
					text:'Направление сортировки',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:269px;top:22px;width:24px;height:52px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'Действие1',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьВыполняетсяПерерисовкаПанели',
			text: 'Выполняется перерисовка панели...',
			style: 'position:absolute;left:0px;top:42px;width:306px;height:36px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:432px;width:306px;height:26px;',
			items:
			[
				'-',
				{
					text:'Сохранить вариант',
				},
				{
					text:'Сохранить сформированный отчет для сравнения',
				},
				'-',
				{
					text:'Сохранить вариант как...',
				},
				{
					text:'Список вариантов отчетов',
				},
				{
					text:'Показать сформированный отчет в отдельном окне',
				},
				'-',
				{
					text:'Панель пользователя',
				},
				{
					text:'Описание и Пользователи',
				},
				{
					text:'Сравнить сформированный отчет с сохраненным',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:838px;height:57px;',
			height: 57,width: 838,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:101px;top:0px;width:220px;height:25px;',
			items:
			[
				{
					text:'Настройка структуры',
				},
				{
					text:'Описание и Пользователи',
				},
				{
					text:'Панель пользователя',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'button',
			name: 'Сформировать',
			text: 'Сформировать',
			style: 'position:absolute;left:6px;top:98px;width:124px;height:30px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:9px;top:63px;width:821px;height:31px;',
			height: 31,width: 821,
			items:
			[
				{
					title:'Горизонтальные отборы',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:136px;top:101px;width:120px;height:24px;',
			items:
			[
				{
					text:'Печать',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:658px;top:101px;width:173px;height:24px;',
			items:
			[
				{
					text:'Настройки',
				},
				{
					text:'Панель вариантов',
				},
				{
					text:'Действие1',
				},
			]
		},
	]
});