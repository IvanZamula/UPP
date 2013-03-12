﻿Ext.define('Документы.СправкаОЗаработкеДляРасчетаПособий.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:780px;height:420px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справки о заработке для расчета пособий',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:379px;',
			height: 379,width: 764,
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
					text:'Сотрудник',
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
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				{
					text:'Действие4',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие9',
				},
				'-',
				{
					text:'Действие2',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие11',
				},
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие',
				},
				'-',
				'-',
				{
					text:'Действия формы выбрать',
				},
				'-',
				{
					text:'',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие5',
				},
				'-',
				{
					text:'',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие4',
				},
				'-',
				{
					text:'',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие6',
				},
				'-',
				{
					text:'Действие8',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие12',
				},
				'-',
				'-',
				'-',
			]
		},
	]
});