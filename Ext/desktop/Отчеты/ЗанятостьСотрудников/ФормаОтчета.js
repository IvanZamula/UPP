﻿Ext.define('Отчеты.ЗанятостьСотрудников.ФормаОтчета',
	{
	extend: 'Ext.window.Window',
	height: 538,width: 838,
	iconCls: 'bogus',
	title: 'Шаблон типового отчета',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:525px;top:134px;width:306px;height:398px;',
			height: 398,width: 306,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:306px;height:372px;',
			height: 372,width: 306,
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
					text:'Использование',
				},
				{
					text:'Параметр',
				},
				{
					text:'Значение',
				},
				{
					text:'ПараметрСДатой',
				},
				{
					text:'ЗначениеСДатой',
				},
				{
					text:'ДатаЗначениеСДатой',
				},
				{
					text:'ДатаНачала',
				},
				{
					text:'ДатаОкончания',
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
					]
				},
				{
					title:'Показатели',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:292px;height:136px;',
			height: 136,width: 292,
			columns:
			[
				{
					text:'Использование',
				},
				{
					text:'Представление',
				},
				{
					text:'Поле',
				},
			]
		},
					]
				},
				{
					title:'Порядок',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:253px;height:83px;',
			height: 83,width: 253,
			columns:
			[
				{
					text:'Использование',
				},
				{
					text:'Поле',
				},
				{
					text:'ТипУпорядочивания',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:269px;top:22px;width:24px;height:52px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Действие',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:372px;width:306px;height:26px;',
			items:
			[
				{
					text:'СписокВариантов',
				},
				{
					text:'СкопироватьТекущуюНастройку',
				},
				{
					text:'Разделитель',
				},
				{
					text:'РедактироватьПараметрыПанели',
				},
				{
					text:'ДействияСоСформированнымОтчетом',
				},
				{
					text:'СохранитьНастройку',
				},
				{
					text:'ИзменитьВариант',
				},
				{
					text:'Разделитель',
				},
				{
					text:'РедактироватьПолномочия',
				},
				{
					text:'ВывестиКопиюРезультатаВТабличныйДокумент',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'СравнитьТекущийРезультатССохраненным',
				},
				{
					text:'Заголовок',
				},
				{
					text:'Сохранить',
				},
				{
					text:'РедактироватьСтруктуруОтчетаАдминистратора',
				},
				{
					text:'СохранитьРезультатВНастройке',
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
					text:'РедактироватьСтруктуруОтчетаАдминистратора',
				},
				{
					text:'РедактироватьПолномочия',
				},
				{
					text:'РедактироватьПараметрыПанели',
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
					title:'ГоризонтальныеОтборы',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:136px;top:101px;width:120px;height:24px;',
			items:
			[
				{
					text:'Действие',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:658px;top:101px;width:173px;height:24px;',
			items:
			[
				{
					text:'ПанельПользователя',
				},
				{
					text:'Действие1',
				},
				{
					text:'ПанельВариантов',
				},
			]
		},
	]
});