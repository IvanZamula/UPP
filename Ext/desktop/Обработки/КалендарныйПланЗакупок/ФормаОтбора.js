﻿Ext.require(['Данные.Обработки.КалендарныйПланЗакупок'], function () 
{
	Ext.define('Обработки.КалендарныйПланЗакупок.ФормаОтбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:652px;height:319px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Отбор',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:8px;width:636px;height:276px;',
			height: 276,width: 636,
			items:
			[
				{
					title:'Основные',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Контрагент:',
			style: 'position:absolute;left:6px;top:56px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеКонтрагент',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:56px;width:246px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Номенклатура:',
			style: 'position:absolute;left:6px;top:6px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеДатаПотребности',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:106px;width:246px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ЗначениеДатаПотребностиНач',
			width: 120,
			height: 19,
			style: 'position:absolute;left:382px;top:106px;width:120px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ЗначениеДатаПотребностиКон',
			width: 120,
			height: 19,
			style: 'position:absolute;left:508px;top:106px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеНоменклатура',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:6px;width:246px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Заказ поставщику:',
			style: 'position:absolute;left:6px;top:81px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеЗаказПоставщику',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:81px;width:246px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Дата потребности:',
			style: 'position:absolute;left:6px;top:106px;width:116px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеНеобходимоеКоличество',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:131px;width:246px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеНеобходимоеКоличествоНач',
			style: 'position:absolute;left:382px;top:131px;width:120px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеНеобходимоеКоличествоКон',
			style: 'position:absolute;left:508px;top:131px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Необходимое количество:',
			style: 'position:absolute;left:6px;top:131px;width:156px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеЗаказанноеКоличество',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:156px;width:246px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеЗаказанноеКоличествоНач',
			style: 'position:absolute;left:382px;top:156px;width:120px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеЗаказанноеКоличествоКон',
			style: 'position:absolute;left:508px;top:156px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Заказанное количество:',
			style: 'position:absolute;left:6px;top:156px;width:148px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеЦенаУпрУчета',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:181px;width:246px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеЦенаУпрУчетаНач',
			style: 'position:absolute;left:382px;top:181px;width:120px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеЦенаУпрУчетаКон',
			style: 'position:absolute;left:508px;top:181px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Цена в валюте упр.учета:',
			style: 'position:absolute;left:6px;top:181px;width:152px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеСуммаУпрУчета',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:206px;width:246px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеСуммаУпрУчетаНач',
			style: 'position:absolute;left:382px;top:206px;width:120px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеСуммаУпрУчетаКон',
			style: 'position:absolute;left:508px;top:206px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сумма в валюте упр.учета:',
			style: 'position:absolute;left:6px;top:206px;width:156px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеСуммаВзаиморасчетов',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:231px;width:246px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеСуммаВзаиморасчетовНач',
			style: 'position:absolute;left:382px;top:231px;width:120px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеСуммаВзаиморасчетовКон',
			style: 'position:absolute;left:508px;top:231px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сумма в валюте взаиморасчетов:',
			style: 'position:absolute;left:6px;top:231px;width:192px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:6px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:56px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:81px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:106px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:131px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:156px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:181px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:206px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:231px;width:180px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Характеристика номенклатуры:',
			style: 'position:absolute;left:6px;top:31px;width:184px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеХарактеристикаНоменклатуры',
			width: 246,
			height: 19,
			style: 'position:absolute;left:382px;top:31px;width:246px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:200px;top:31px;width:180px;height:19px;',
		},
					]
				},
				{
					title:'Дополнительно',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Отбирать не заказанные товары',
			style: 'position:absolute;left:6px;top:6px;width:192px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Отбирать даты поставки заказов не заявленные в плане потребности',
			style: 'position:absolute;left:6px;top:46px;width:384px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Отбирать не выполненные даты потребности',
			style: 'position:absolute;left:6px;top:26px;width:256px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Отбирать измененные заказы',
			style: 'position:absolute;left:6px;top:94px;width:180px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Отбирать новые заказы',
			style: 'position:absolute;left:6px;top:114px;width:148px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Отбирать новые и измененные заказы',
			style: 'position:absolute;left:6px;top:74px;width:224px;height:15px;',
		},
					]
				},
			]
		},
		{
			xtype: 'button',
			name: 'КнопкаОК',
			text: 'ОК',
			style: 'position:absolute;left:478px;top:289px;width:80px;height:22px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаОтмена',
			text: 'Отмена',
			style: 'position:absolute;left:564px;top:289px;width:80px;height:22px;',
		},
		],
	}],
	dockedItems:
	[
	]
	});
});