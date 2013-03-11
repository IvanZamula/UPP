﻿Ext.define('Документы.КорректировкаДолгаПоВозвратнойТаре.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 387,width: 648,
	iconCls: 'bogus',
	title: 'Корректировка долга по возвратной таре',
	
	items:
	[
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
			name: 'Комментарий',
			style: 'position:absolute;left:94px;top:335px;width:546px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:648px;height:25px;',
			items:
			[
				{
					text:'Разделитель9',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'ПодменюВидаОперации',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель1',
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
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:156px;width:632px;height:152px;',
			height: 152,width: 632,
			items:
			[
				{
					title:'Тара',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:0px;width:618px;height:24px;',
			items:
			[
				{
					text:'Подбор',
				},
				{
					text:'ЗаполнитьОстаткамиПоДоговору',
				},
				{
					text:'ПодменюЗаполнить',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:618px;height:102px;',
			height: 102,width: 618,
			columns:
			[
				{
					text:'Номер строки',
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
					text:'Количество',
				},
				{
					text:'Цена',
				},
				{
					text:'Сумма',
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
			name: 'ПодразделениеКомпании',
			style: 'position:absolute;left:92px;top:75px;width:214px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:412px;top:75px;width:212px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СуммаВзаиморасчетов',
			style: 'position:absolute;left:93px;top:28px;width:80px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДоговорКонтрагента',
			style: 'position:absolute;left:420px;top:105px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Контрагент',
			style: 'position:absolute;left:94px;top:105px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:94px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Сделка',
			style: 'position:absolute;left:94px;top:129px;width:220px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерерассчитатьДолг',
			text: '',
			style: 'position:absolute;left:625px;top:129px;width:15px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Всего',
			style: 'position:absolute;left:560px;top:313px;width:80px;height:17px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Основание',
			style: 'position:absolute;left:420px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВалютаДокумента',
			style: 'position:absolute;left:94px;top:81px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КурсДокумента',
			style: 'position:absolute;left:234px;top:81px;width:80px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:362px;width:648px;height:25px;',
			items:
			[
				{
					text:'ОК',
				},
				{
					text:'Печать',
				},
				{
					text:'Записать',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'РазделительЗакрыть',
				},
				{
					text:'РазделительЗаписать',
				},
				{
					text:'Закрыть1',
				},
			]
		},
	]
});