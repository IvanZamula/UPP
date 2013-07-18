﻿Ext.require(['Данные.Обработки.ТекущиеСделки'], function () 
{
	Ext.define('Обработки.ТекущиеСделки.ФормаОтборов',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:478px;height:260px;',
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
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:235px;width:478px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'ОК',
				},
				'-',
				{
					text:'Отмена',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:8px;width:462px;height:219px;',
			height: 219,width: 462,
			items:
			[
				{
					title:'Отбор',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Контрагент',
			style: 'position:absolute;left:6px;top:30px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияКонтрагент',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:30px;width:118px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораКонтрагент',
			width: 220,
			height: 19,
			style: 'position:absolute;left:234px;top:30px;width:220px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Ответственный',
			style: 'position:absolute;left:6px;top:54px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: true,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияПользователь',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:54px;width:118px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'ЗначениеОтбораПользователь',
			width: 220,
			height: 19,
			style: 'position:absolute;left:234px;top:54px;width:220px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сумма',
			style: 'position:absolute;left:6px;top:78px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияСумма',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:78px;width:118px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ЗначениеОтбораСумма',
			style: 'position:absolute;left:234px;top:78px;width:220px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Вид документа',
			style: 'position:absolute;left:6px;top:102px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияТипДокумента',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:102px;width:118px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораТипДокумента',
			width: 220,
			height: 19,
			style: 'position:absolute;left:234px;top:102px;width:220px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Договор',
			style: 'position:absolute;left:6px;top:126px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияДоговор',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:126px;width:118px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Номер',
			style: 'position:absolute;left:6px;top:150px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияНомер',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:150px;width:118px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораНомер',
			width: 220,
			height: 19,
			style: 'position:absolute;left:234px;top:150px;width:220px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Вид операции',
			style: 'position:absolute;left:6px;top:174px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияВидОперации',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:174px;width:118px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораВидОперации',
			width: 220,
			height: 19,
			style: 'position:absolute;left:234px;top:174px;width:220px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Дата',
			style: 'position:absolute;left:6px;top:6px;width:100px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ВидСравненияДата',
			width: 118,
			height: 19,
			style: 'position:absolute;left:111px;top:6px;width:118px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораДата',
			width: 220,
			height: 19,
			style: 'position:absolute;left:234px;top:6px;width:220px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ЗначениеОтбораДатаНач',
			width: 106,
			height: 19,
			style: 'position:absolute;left:234px;top:6px;width:106px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ЗначениеОтбораДатаКон',
			width: 106,
			height: 19,
			style: 'position:absolute;left:348px;top:6px;width:106px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораДоговор',
			width: 220,
			height: 19,
			style: 'position:absolute;left:234px;top:126px;width:220px;height:19px;',
		},
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
	]
	});
});