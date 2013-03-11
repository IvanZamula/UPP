﻿Ext.define('Справочники.НастройкиФормированияДокументовПоОрдерам.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	height: 317,width: 561,
	iconCls: 'bogus',
	title: 'Настройка формирования документов по ордерам',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:98px;top:57px;width:455px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Родитель',
			style: 'position:absolute;left:98px;top:33px;width:455px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:98px;top:265px;width:455px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:561px;height:25px;',
			items:
			[
				{
					text:'Подменю',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:292px;width:561px;height:25px;',
			items:
			[
				{
					text:'Разделитель1',
				},
				{
					text:'ОсновныеДействияФормыЗакрыть',
				},
				{
					text:'ОсновныеДействияФормыОК',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ОсновныеДействияФормыСохранить',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:84px;width:545px;height:173px;',
			height: 173,width: 545,
			items:
			[
				{
					title:'Отбор',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачалоОбработки',
			style: 'position:absolute;left:457px;top:8px;width:80px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:531px;height:116px;',
			height: 116,width: 531,
			columns:
			[
				{
					text:'Использование',
				},
				{
					text:'ЛевоеЗначениеДляПодробногоОтображенияЭлемента',
				},
				{
					text:'ВидыСравненияДляПодробногоОтображенияЭлемента',
				},
				{
					text:'ПравоеЗначениеДляПодробногоОтображенияЭлемента',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияЭлемента',
				},
				{
					text:'ПредставлениеДляКраткогоОтображенияЭлемента',
				},
				{
					text:'ЛевоеЗначениеДляКраткогоОтображенияЭлемента',
				},
				{
					text:'ВидыСравненияДляКраткогоОтображенияЭлемента',
				},
				{
					text:'ПравоеЗначениеДляКраткогоОтображенияЭлемента',
				},
				{
					text:'ТипДляПодробногоОтображенияГруппы',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияГруппы',
				},
				{
					text:'ТипДляКраткогоОтображенияГруппы',
				},
				{
					text:'ЛевоеЗначениеДляПодробногоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ВидыСравненияДляПодробногоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ПравоеЗначениеДляПодробногоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ПрименениеДляПодробногоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ЛевоеЗначениеДляКраткогоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ВидыСравненияДляКраткогоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ПравоеЗначениеДляКраткогоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ПрименениеДляКраткогоОтображенияЭлементаЛокальногоОтбора',
				},
				{
					text:'ТипДляПодробногоОтображенияГруппыЛокальногоОтбора',
				},
				{
					text:'ПрименениеДляПодробногоОтображенияГруппыЛокальногоОтбора',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияГруппыЛокальногоОтбора',
				},
				{
					text:'ТипДляКраткогоОтображенияГруппыЛокальногоОтбора',
				},
				{
					text:'ПрименениеДляКраткогоОтображенияГруппыЛокальногоОтбора',
				},
				{
					text:'ЛевоеЗначениеДляПодробногоОтображенияЭлементаГлавногоОтбора',
				},
				{
					text:'ВидыСравненияДляПодробногоОтображенияЭлементаГлавногоОтбора',
				},
				{
					text:'ПравоеЗначениеДляПодробногоОтображенияЭлементаГлавногоОтбора',
				},
				{
					text:'РежимОтображенияДляПодробногоОтображенияЭлементаГлавногоОтбора',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияЭлементаГлавногоОтбора',
				},
				{
					text:'ТипДляПодробногоОтображенияГруппыГлавногоОтбора',
				},
				{
					text:'РежимОтображенияДляПодробногоОтображенияГруппыГлавногоОтбора',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияГруппыГлавногоОтбора',
				},
				{
					text:'ЛевоеЗначениеДляПодробногоОтображенияЭлементаСДатой',
				},
				{
					text:'ВидыСравненияДляПодробногоОтображенияЭлементаСДатой',
				},
				{
					text:'ПравоеЗначениеДляПодробногоОтображенияЭлементаСДатой',
				},
				{
					text:'ДатаПравоеЗначениеДляПодробногоОтображенияЭлементаСДатой',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияЭлементаСДатой',
				},
				{
					text:'ЛевоеЗначениеДляКраткогоОтображенияЭлементаСДатой',
				},
				{
					text:'ВидыСравненияДляКраткогоОтображенияЭлементаСДатой',
				},
				{
					text:'ПравоеЗначениеДляКраткогоОтображенияЭлементаСДатой',
				},
				{
					text:'ДатаПравоеЗначениеДляКраткогоОтображенияЭлементаСДатой',
				},
				{
					text:'ЛевоеЗначениеДляПодробногоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ВидыСравненияДляПодробногоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ПравоеЗначениеДляПодробногоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ДатаПравоеЗначениеДляПодробногоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ПрименениеДляПодробногоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ЛевоеЗначениеДляКраткогоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ВидыСравненияДляКраткогоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ПравоеЗначениеДляКраткогоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ДатаПравоеЗначениеДляКраткогоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ПрименениеДляКраткогоОтображенияЭлементаЛокальногоОтбораСДатой',
				},
				{
					text:'ЛевоеЗначениеДляПодробногоОтображенияЭлементаГлавногоОтбораСДатой',
				},
				{
					text:'ВидыСравненияДляПодробногоОтображенияЭлементаГлавногоОтбораСДатой',
				},
				{
					text:'ПравоеЗначениеДляПодробногоОтображенияЭлементаГлавногоОтбораСДатой',
				},
				{
					text:'ДатаПравоеЗначениеДляПодробногоОтображенияЭлементаГлавногоОтбораСДатой',
				},
				{
					text:'РежимОтображенияДляПодробногоОтображенияЭлементаГлавногоОтбораСДатой',
				},
				{
					text:'ПредставлениеДляПодробногоОтображенияЭлементаГлавногоОтбораСДатой',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:238px;height:24px;',
			items:
			[
			]
		},
					]
				},
				{
					title:'Параметры',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПериодДетализации',
			style: 'position:absolute;left:94px;top:54px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ШаблонРегулярногоДокумента',
			style: 'position:absolute;left:94px;top:30px;width:443px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВидРегулярногоДокумента',
			style: 'position:absolute;left:94px;top:6px;width:443px;height:19px;',
		},
					]
				},
				{
					title:'Расписание',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Задержка',
			style: 'position:absolute;left:278px;top:54px;width:40px;height:19px;',
		},
					]
				},
			]
		},
	]
});