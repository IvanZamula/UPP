﻿Ext.define('Отчеты.РегламентированныйОтчет4ФСС.ФормаОтчета2004Кв1',
	{
	extend: 'Ext.window.Window',
	height: 450,width: 780,
	iconCls: 'bogus',
	title: '4-ФСС',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'РасширитьПолеБланка',
				},
				{
					text:'Справка',
				},
				{
					text:'Заполнить',
				},
				{
					text:'Поиск',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'КнопкаЗаполнитьСведенияОбОрганизации',
				},
				{
					text:'КнопкаНастройкаСтраниц',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Очистить',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'РазделительЗаполнить',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:425px;width:780px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие2',
				},
				{
					text:'ПодменюПечати',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Записать',
				},
				{
					text:'СохранитьИЗакрыть',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:81px;width:764px;height:336px;',
			height: 336,width: 764,
			items:
			[
				{
					title:'Титульный',
				},
				{
					title:'Раздел1_1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:286px;width:640px;height:24px;',
			height: 24,width: 640,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел1_1',
			style: 'position:absolute;left:226px;top:5px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел1_1',
			style: 'position:absolute;left:353px;top:5px;width:287px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел1_2',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел1_2',
			text: 'Добавить',
			style: 'position:absolute;left:144px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел1_2',
			text: 'Удалить',
			style: 'position:absolute;left:230px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:265px;width:640px;height:24px;',
			height: 24,width: 640,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел1_2',
			style: 'position:absolute;left:226px;top:5px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел1_2',
			style: 'position:absolute;left:353px;top:5px;width:287px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел2_1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:284px;width:640px;height:26px;',
			height: 26,width: 640,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел2_1',
			style: 'position:absolute;left:226px;top:7px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел2_1',
			style: 'position:absolute;left:351px;top:7px;width:289px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел2_2',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел2_2',
			text: 'Добавить',
			style: 'position:absolute;left:592px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел2_2',
			text: 'Удалить',
			style: 'position:absolute;left:678px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:262px;width:640px;height:26px;',
			height: 26,width: 640,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел2_2',
			style: 'position:absolute;left:226px;top:7px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел2_2',
			style: 'position:absolute;left:351px;top:7px;width:289px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел2_3',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел2_3',
			text: 'Добавить',
			style: 'position:absolute;left:144px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел2_3',
			text: 'Удалить',
			style: 'position:absolute;left:230px;top:291px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Раздел2_4',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел2_4',
			text: 'Добавить',
			style: 'position:absolute;left:144px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел2_4',
			text: 'Удалить',
			style: 'position:absolute;left:230px;top:291px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Раздел3_1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:286px;width:640px;height:24px;',
			height: 24,width: 640,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел3_1',
			style: 'position:absolute;left:226px;top:5px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел3_1',
			style: 'position:absolute;left:352px;top:5px;width:288px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел3_2',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел3_2',
			text: 'Добавить',
			style: 'position:absolute;left:591px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел3_2',
			text: 'Удалить',
			style: 'position:absolute;left:677px;top:291px;width:80px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:265px;width:640px;height:24px;',
			height: 24,width: 640,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаЗначениеКорректировкиРаздел3_2',
			style: 'position:absolute;left:226px;top:5px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаКомментарийРаздел3_2',
			style: 'position:absolute;left:352px;top:5px;width:288px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:48px;',
			height: 48,width: 764,
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
			style: 'position:absolute;left:222px;top:0px;width:32px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаДатаСдачи',
			style: 'position:absolute;left:82px;top:23px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерКорректировки',
			style: 'position:absolute;left:302px;top:23px;width:49px;height:19px;',
		},
					]
				},
			]
		},
	]
});