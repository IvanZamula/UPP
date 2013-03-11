﻿Ext.define('Документы.ВосстановлениеНДС.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 709,
	iconCls: 'bogus',
	title: '',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:98px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:198px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:709px;height:25px;',
			items:
			[
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'ДействиеОткрытьСвойства',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'ДействиеОткрытьКатегории',
				},
				{
					text:'ПроводкиДтКт',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель1',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:396px;width:709px;height:25px;',
			items:
			[
				{
					text:'Действие2',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие1',
				},
				{
					text:'Печать',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель2',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:94px;top:369px;width:607px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:98px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:81px;width:693px;height:282px;',
			height: 282,width: 693,
			items:
			[
				{
					title:'НДСкВосстановлению',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:679px;height:221px;',
			height: 221,width: 679,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ВидЦенности',
				},
				{
					text:'Поставщик',
				},
				{
					text:'ДоговорКонтрагента',
				},
				{
					text:'СчетФактура',
				},
				{
					text:'СчетУчетаНДС',
				},
				{
					text:'ДокументОплаты',
				},
				{
					text:'ДатаОплаты',
				},
				{
					text:'СуммаБезНДС',
				},
				{
					text:'СтавкаНДС',
				},
				{
					text:'НДС',
				},
				{
					text:'ЗаписьДополнительногоЛиста',
				},
				{
					text:'КорректируемыйПериод',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:679px;height:24px;',
			items:
			[
				{
					text:'ПодменюЗаполнить',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'СнятьПризнакДопЛиста',
				},
				{
					text:'Разделитель',
				},
				{
					text:'УстановитьПризнакДопЛиста',
				},
				{
					text:'Заполнить',
				},
				{
					text:'Разделитель',
				},
			]
		},
					]
				},
				{
					title:'Дополнительно',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:92px;top:6px;width:282px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ОтразитьВКнигеПродаж',
			style: 'position:absolute;left:475px;top:57px;width:151px;height:19px;',
		},
	]
});