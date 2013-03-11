﻿Ext.define('Документы.РеестрСведенийВФССОПособияхПриРожденииРебенка.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 500,width: 800,
	iconCls: 'bogus',
	title: 'Реестры сведений в ФСС о пособиях при рождении ребенка',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:56px;width:784px;height:436px;',
			height: 436,width: 784,
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
					text:'КраткийСоставДокумента',
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
			style: 'position:absolute;left:0px;top:0px;width:800px;height:25px;',
			items:
			[
				{
					text:'Действие8',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю1',
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
					text:'Подменю',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
				{
					text:'Печать',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие2',
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
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие3',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие12',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель1',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:784px;height:19px;',
			height: 19,width: 784,
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