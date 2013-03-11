﻿Ext.define('Документы.СправкаПоНДФЛСотруднику.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 1000,
	iconCls: 'bogus',
	title: 'Справки о доходах (2-НДФЛ) для сотрудников',
	
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
					text:'НалоговыйПериод',
				},
				{
					text:'Организация',
				},
				{
					text:'Сотрудник',
				},
				{
					text:'ОКАТО_КПП',
				},
				{
					text:'НазначениеСправки',
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
					text:'Разделитель',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие8',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'ДействиеПечать',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие9',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие13',
				},
				{
					text:'Подменю',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие5',
				},
				{
					text:'Подменю1',
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