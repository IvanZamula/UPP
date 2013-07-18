﻿Ext.require(['Данные.Справочники.ГодовыеГрафикиАмортизацииОС'], function () 
{
	Ext.define('Справочники.ГодовыеГрафикиАмортизацииОС.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:418px;height:277px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Годовые графики амортизации ОС',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:328px;top:33px;width:40px;height:19px;text-align:center;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Код',
			width: 40,
			height: 19,
			style: 'position:absolute;left:370px;top:33px;width:40px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:33px;width:96px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Наименование',
			width: 220,
			height: 19,
			style: 'position:absolute;left:106px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Прочие сведения:',
			style: 'position:absolute;left:8px;top:57px;width:96px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 304,
			height: 19,
			style: 'position:absolute;left:106px;top:57px;width:304px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:252px;width:417px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'OK',
				},
				'-',
				{
					text:'Записать',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'fieldset',
			title: ' Коэффициенты распределения по месяцам:',
			style: 'position:absolute;left:8px;top:84px;width:402px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент1',
			text: 'Январь:',
			style: 'position:absolute;left:20px;top:105px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент1',
			style: 'position:absolute;left:82px;top:105px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент2',
			text: 'Февраль:',
			style: 'position:absolute;left:20px;top:129px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент2',
			style: 'position:absolute;left:82px;top:129px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент3',
			text: 'Март:',
			style: 'position:absolute;left:20px;top:153px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент3',
			style: 'position:absolute;left:82px;top:153px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент4',
			text: 'Апрель:',
			style: 'position:absolute;left:20px;top:177px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент4',
			style: 'position:absolute;left:82px;top:177px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент5',
			text: 'Май:',
			style: 'position:absolute;left:20px;top:201px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент5',
			style: 'position:absolute;left:82px;top:201px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент6',
			text: 'Июнь:',
			style: 'position:absolute;left:20px;top:225px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент6',
			style: 'position:absolute;left:82px;top:225px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент7',
			text: 'Июль:',
			style: 'position:absolute;left:202px;top:105px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент7',
			style: 'position:absolute;left:264px;top:105px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент8',
			text: 'Август:',
			style: 'position:absolute;left:202px;top:129px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент8',
			style: 'position:absolute;left:264px;top:129px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент9',
			text: 'Сентябрь:',
			style: 'position:absolute;left:202px;top:153px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент9',
			style: 'position:absolute;left:264px;top:153px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент10',
			text: 'Октябрь:',
			style: 'position:absolute;left:202px;top:177px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент10',
			style: 'position:absolute;left:264px;top:177px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент11',
			text: 'Ноябрь:',
			style: 'position:absolute;left:202px;top:201px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент11',
			style: 'position:absolute;left:264px;top:201px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоэффициент12',
			text: 'Декабрь:',
			style: 'position:absolute;left:202px;top:225px;width:60px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Коэффициент12',
			style: 'position:absolute;left:264px;top:225px;width:80px;height:19px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:417px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
	]
	});
});