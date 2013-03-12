﻿Ext.define('Документы.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:800px;height:400px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Реестры сведений в ФСС о ежемесячных пособиях по уходу',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:784px;height:359px;',
			height: 359,width: 784,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Дата',
					width:'132',
				},
				{
					text:'Номер',
					width:'80',
				},
				{
					text:'Организация',
					width:'120',
				},
				{
					text:'Сотрудники',
					width:'120',
				},
				{
					text:'Ответственный',
					width:'120',
				},
				{
					text:'Комментарий',
					width:'120',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:800px;height:25px;',
			items:
			[
				{
					text:'',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие10',
				},
				'-',
				{
					text:'Действие5',
				},
				'-',
				{
					text:'Действие6',
				},
				{
					text:'Действие10',
				},
				'-',
				'-',
				{
					text:'Действие11',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие2',
				},
				'-',
				{
					text:'',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие',
				},
				'-',
				{
					text:'Действие3',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие',
				},
				'-',
				{
					text:'Действие7',
				},
				{
					text:'',
				},
				'-',
				'-',
				{
					text:'Действие6',
				},
				{
					text:'Действия формы выбрать',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие4',
				},
				'-',
				{
					text:'Действие7',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие2',
				},
				{
					text:'Структура подчиненности документа',
				},
			]
		},
	]
});