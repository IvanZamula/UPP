﻿Ext.define('Справочники.ЗаявкиКандидатов.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:649px;height:400px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Кандидаты',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:633px;height:335px;',
			height: 335,width: 633,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'',
					width:'21',
				},
				{
					text:'Код',
					width:'80',
				},
				{
					text:'Наименование',
					width:'120',
				},
				{
					text:'Состояние',
					width:'100',
				},
				{
					text:'Физическое лицо',
					width:'100',
				},
				{
					text:'Организация',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:649px;height:25px;',
			items:
			[
				'-',
				{
					text:'',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие8',
				},
				'-',
				{
					text:'Действие5',
				},
				'-',
				{
					text:'Действие1',
				},
				{
					text:'Действие7',
				},
				'-',
				'-',
				{
					text:'',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие4',
				},
				'-',
				'-',
				{
					text:'Действие8',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие7',
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
					text:'Действие3',
				},
				'-',
				{
					text:'Действие9',
				},
				{
					text:'Действие1',
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
				'-',
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:341px;top:33px;width:300px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Организация:',
			style: 'position:absolute;left:248px;top:33px;width:88px;height:19px;',
		},
	]
});