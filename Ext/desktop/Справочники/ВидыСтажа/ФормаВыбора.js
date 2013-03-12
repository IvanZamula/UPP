﻿Ext.define('Справочники.ВидыСтажа.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:425px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Виды стажа',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:409px;height:259px;',
			height: 259,width: 409,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Код',
					width:'80',
				},
				{
					text:'Наименование',
					width:'220',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:425px;height:25px;',
			items:
			[
				{
					text:'Действие4',
				},
				'-',
				'-',
				{
					text:'Действие2',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие1',
				},
				'-',
				'-',
				{
					text:'Действие6',
				},
				{
					text:'',
				},
				{
					text:'Действие8',
				},
				'-',
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие6',
				},
				'-',
				{
					text:'Действие5',
				},
				{
					text:'Действие2',
				},
				{
					text:'',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие3',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие10',
				},
				'-',
				{
					text:'',
				},
				{
					text:'Редактировать код номер',
				},
				{
					text:'Действие11',
				},
			]
		},
	]
});