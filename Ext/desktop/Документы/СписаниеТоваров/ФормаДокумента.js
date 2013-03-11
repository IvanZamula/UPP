﻿Ext.define('Документы.СписаниеТоваров.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 409,width: 652,
	iconCls: 'bogus',
	title: 'Списание товаров',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:103px;top:32px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:203px;top:32px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:96px;top:357px;width:548px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:652px;height:25px;',
			items:
			[
				{
					text:'ДействиеОткрытьКатегории',
				},
				{
					text:'ПроводкиДтКтНУ',
				},
				{
					text:'ДействиеЗаполнитьИПровести',
				},
				{
					text:'ПодменюВидаОперации',
				},
				{
					text:'Подменю2',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'ДействиеОткрытьСвойства',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'ПроводкиДтКт',
				},
				{
					text:'ПоказатьСкрытьСчетаУчета',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПодразделениеКомпании',
			style: 'position:absolute;left:96px;top:333px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:424px;top:333px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:103px;top:56px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Основание',
			style: 'position:absolute;left:424px;top:80px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СкладКомпании',
			style: 'position:absolute;left:424px;top:56px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Всего',
			style: 'position:absolute;left:564px;top:309px;width:80px;height:17px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИнвентаризацияТоваровНаСкладе',
			style: 'position:absolute;left:103px;top:80px;width:220px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:384px;width:652px;height:25px;',
			items:
			[
				{
					text:'Печать',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Записать',
				},
				{
					text:'РазделительЗакрыть',
				},
				{
					text:'Закрыть1',
				},
				{
					text:'РазделительЗаписать',
				},
				{
					text:'ОК',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:128px;width:636px;height:176px;',
			height: 176,width: 636,
			items:
			[
				{
					title:'Товары',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:622px;height:120px;',
			height: 120,width: 622,
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
					text:'Цена',
				},
				{
					text:'Сумма',
				},
				{
					text:'ДокументРезерва',
				},
				{
					text:'НомерГТД',
				},
				{
					text:'СтранаПроисхождения',
				},
				{
					text:'СчетУчетаБУ',
				},
				{
					text:'ПринятыеСчетУчетаБУ',
				},
				{
					text:'СчетУчетаНУ',
				},
				{
					text:'ОтражениеВУСН',
				},
				{
					text:'Качество',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:622px;height:24px;',
			items:
			[
				{
					text:'ИзТерминалаСбораДанных',
				},
				{
					text:'ПодменюЗаполнить',
				},
				{
					text:'Проверить',
				},
				{
					text:'ДействиеПодбор',
				},
				{
					text:'ШтрихКоды',
				},
				{
					text:'ЗаполнитьПоИнвентаризации',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'ДействиеИзменить',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ПоискПоШтрихКоду',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель3',
				},
			]
		},
					]
				},
				{
					title:'Тара',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:622px;height:120px;',
			height: 120,width: 622,
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
					text:'Количество',
				},
				{
					text:'ЕдиницаХранения',
				},
				{
					text:'ДокументРезерва',
				},
				{
					text:'СчетУчетаБУ',
				},
				{
					text:'СчетУчетаНУ',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:622px;height:24px;',
			items:
			[
				{
					text:'Подбор',
				},
				{
					text:'Разделитель',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НДСвСтоимостиТоваров',
			style: 'position:absolute;left:103px;top:104px;width:220px;height:19px;',
		},
	]
});