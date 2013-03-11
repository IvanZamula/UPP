﻿Ext.define('Документы.ПередачаСЗВ4вПФР.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 1000,
	iconCls: 'bogus',
	title: 'Описи сведений АДВ-6-2 (до 2010 года - Ведомости уплаты АДВ-11)',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:984px;height:356px;',
			height: 356,width: 984,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'Дата',
				},
				{
					text:'Номер',
				},
				{
					text:'Организация',
				},
				{
					text:'ОтчетныйПериод',
				},
				{
					text:'КраткийСоставДокумента',
				},
				{
					text:'ЗаполненПринятымиСведениями',
				},
				{
					text:'Ответственный',
				},
				{
					text:'Комментарий',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:1000px;height:25px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие6',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие5',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Действие11',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие9',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ДействиеПечать',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие12',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие4',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие8',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие7',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Разделитель3',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:984px;height:19px;',
			height: 19,width: 984,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:92px;top:0px;width:220px;height:19px;',
		},
					]
				},
			]
		},
	]
});