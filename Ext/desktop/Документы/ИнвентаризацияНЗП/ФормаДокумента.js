﻿Ext.define('Документы.ИнвентаризацияНЗП.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 435,width: 652,
	iconCls: 'bogus',
	title: 'Инвентаризация незавершенного производства',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:652px;height:25px;',
			items:
			[
				{
					text:'ДействиеОткрытьСвойства1',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'ДействиеОткрытьКатегории1',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:410px;width:652px;height:25px;',
			items:
			[
				{
					text:'Печать',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:96px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:196px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:96px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Подразделение',
			style: 'position:absolute;left:96px;top:81px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:97px;top:383px;width:547px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НоменклатурнаяГруппа',
			style: 'position:absolute;left:143px;top:130px;width:173px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Заказ',
			style: 'position:absolute;left:424px;top:130px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПодразделениеОрганизации',
			style: 'position:absolute;left:424px;top:81px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:97px;top:359px;width:547px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:161px;width:636px;height:190px;',
			height: 190,width: 636,
			items:
			[
				{
					title:'Материалы',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:622px;height:25px;',
			items:
			[
				{
					text:'ПодменюЗаполнить',
				},
				{
					text:'ЗаполнитьПоОстаткамРегл',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ЗаполнитьОстаткамиМатериаловВПроизводстве',
				},
				{
					text:'ЗаполнитьПоНормативамУпр',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ЗаполнитьПоОстаткамУпр',
				},
				{
					text:'ЗаполнитьПоНормативамРегл',
				},
				{
					text:'Подбор',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:32px;width:622px;height:132px;',
			height: 132,width: 622,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'Код',
				},
				{
					text:'Артикул',
				},
				{
					text:'Номенклатура',
				},
				{
					text:'ХарактеристикаНоменклатуры',
				},
				{
					text:'СерияНоменклатуры',
				},
				{
					text:'СтатьяЗатрат',
				},
				{
					text:'ЕдиницаМест',
				},
				{
					text:'КоэффициентМест',
				},
				{
					text:'КоличествоМест',
				},
				{
					text:'Количество',
				},
				{
					text:'Единица',
				},
				{
					text:'Коэффициент',
				},
				{
					text:'КоличествоНеИспользованноеВПроизводстве',
				},
				{
					text:'НоменклатурнаяГруппа',
				},
				{
					text:'Заказ',
				},
				{
					text:'СчетЗатрат',
				},
				{
					text:'СчетЗатратНУ',
				},
			]
		},
					]
				},
				{
					title:'ПрочиеЗатраты',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:622px;height:133px;',
			height: 133,width: 622,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'СтатьяЗатрат',
				},
				{
					text:'СпособРаспределенияЗатратНаВыпуск',
				},
				{
					text:'Заказ',
				},
				{
					text:'НоменклатурнаяГруппа',
				},
				{
					text:'Сумма',
				},
				{
					text:'СуммаРегл',
				},
				{
					text:'СуммаНал',
				},
				{
					text:'СчетЗатрат',
				},
				{
					text:'СчетЗатратНУ',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:622px;height:24px;',
			items:
			[
				{
					text:'КоманднаяПанельПрочиеЗатратыЗаполнитьУпр',
				},
				{
					text:'КоманднаяПанельПрочиеЗатратыЗаполнитьРегл',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Подбор',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ПодменюЗаполнить',
				},
				{
					text:'Заполнить',
				},
			]
		},
					]
				},
			]
		},
	]
});