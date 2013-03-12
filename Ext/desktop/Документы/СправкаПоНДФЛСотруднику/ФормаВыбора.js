﻿Ext.define('Документы.СправкаПоНДФЛСотруднику.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:562px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справки о доходах (2-НДФЛ) для сотрудников',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:546px;height:380px;',
			height: 380,width: 546,
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
					text:'Период',
					width:'80',
				},
				{
					text:'Сотрудник',
					width:'120',
				},
				{
					text:'ОКАТО/КПП',
					width:'86',
				},
				{
					text:'Назначение справки',
					width:'120',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:562px;height:25px;',
			items:
			[
				{
					text:'Действие13',
				},
				{
					text:'',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие1',
				},
				'-',
				{
					text:'Действие4',
				},
				{
					text:'Печать',
				},
				'-',
				'-',
				{
					text:'Действие5',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие2',
				},
				'-',
				{
					text:'Действие11',
				},
				'-',
				{
					text:'Действие9',
				},
				'-',
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Действие3',
				},
				'-',
				{
					text:'Действие8',
				},
				{
					text:'Действие5',
				},
				'-',
				{
					text:'Действие4',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие7',
				},
				'-',
				{
					text:'',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие14',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие',
				},
				{
					text:'',
				},
				{
					text:'Печать',
				},
				'-',
				'-',
				'-',
				'-',
				{
					text:'Действие1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие2',
				},
			]
		},
	]
});