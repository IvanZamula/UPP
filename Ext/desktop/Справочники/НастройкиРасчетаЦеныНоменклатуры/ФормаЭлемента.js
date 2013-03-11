﻿Ext.define('Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	height: 419,width: 531,
	iconCls: 'bogus',
	title: 'Настройка расчета цены номенклатуры',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:531px;height:25px;',
			items:
			[
				{
					text:'Разделитель2',
				},
				{
					text:'Подменю',
				},
				{
					text:'ВыполнитьБезРегламентногоЗадания',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:394px;width:531px;height:25px;',
			items:
			[
				{
					text:'ОсновныеДействияФормыСохранить',
				},
				{
					text:'ОсновныеДействияФормыЗакрыть',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ОсновныеДействияФормыОК',
				},
				{
					text:'Разделитель',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:84px;width:515px;height:275px;',
			height: 275,width: 515,
			items:
			[
				{
					title:'ПорядокРасчета',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:54px;width:501px;height:120px;',
			height: 120,width: 501,
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
			xtype: 'textfield',
			hideLabel: true,
			name: 'НастройкаРасчетаСебестоимости',
			style: 'position:absolute;left:267px;top:6px;width:240px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТипЦен',
			style: 'position:absolute;left:133px;top:206px;width:240px;height:19px;',
		},
					]
				},
				{
					title:'АвтоматическоеФормированиеДокументов',
					items:
					[
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:99px;top:57px;width:424px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Родитель',
			style: 'position:absolute;left:99px;top:33px;width:424px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:87px;top:367px;width:436px;height:19px;',
		},
	]
});