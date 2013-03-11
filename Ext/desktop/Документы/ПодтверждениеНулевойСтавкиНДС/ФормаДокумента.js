﻿Ext.define('Документы.ПодтверждениеНулевойСтавкиНДС.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 371,width: 654,
	iconCls: 'bogus',
	title: '',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:654px;height:25px;',
			items:
			[
				{
					text:'Разделитель5',
				},
				{
					text:'Подменю1',
				},
				{
					text:'ДействиеОткрытьКатегории1',
				},
				{
					text:'ПроводкиДтКтНУ',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'ПроводкиДтКт',
				},
				{
					text:'ДействиеОткрытьСвойства1',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:346px;width:654px;height:25px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Печать',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:91px;top:319px;width:555px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:94px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:194px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:94px;top:61px;width:220px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:87px;width:638px;height:224px;',
			height: 224,width: 638,
			items:
			[
				{
					title:'ДокументыРеализации',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:624px;height:159px;',
			height: 159,width: 624,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ВидЦенности',
				},
				{
					text:'Покупатель',
				},
				{
					text:'СчетФактура',
				},
				{
					text:'Событие',
				},
				{
					text:'ПродажиСНДС0',
				},
				{
					text:'СтавкаНДС',
				},
				{
					text:'НДС',
				},
				{
					text:'КурсоваяРазница',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:624px;height:24px;',
			items:
			[
				{
					text:'ПодменюЗаполнить',
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
			style: 'position:absolute;left:163px;top:50px;width:467px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СтатьяПрочихРасходов',
			style: 'position:absolute;left:163px;top:15px;width:467px;height:19px;',
		},
					]
				},
			]
		},
	]
});