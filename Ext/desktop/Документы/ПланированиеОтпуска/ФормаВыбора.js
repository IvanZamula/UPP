﻿Ext.define('Документы.ПланированиеОтпуска.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:721px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Планирование отпусков',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:705px;height:380px;',
			height: 380,width: 705,
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
					text:'Сотрудники',
					width:'100',
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
			style: 'position:absolute;left:0px;top:0px;width:721px;height:25px;',
			items:
			[
				{
					text:'Действие7',
				},
				{
					text:'Действие13',
				},
				'-',
				{
					text:'Действие3',
				},
				{
					text:'Действие5',
				},
				{
					text:'',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
				'-',
				'-',
				{
					text:'',
				},
				'-',
				{
					text:'Действие7',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие6',
				},
				{
					text:'График отпусков организаций',
				},
				'-',
				{
					text:'',
				},
				'-',
				{
					text:'Действие12',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие4',
				},
				'-',
				'-',
				'-',
				{
					text:'',
				},
				{
					text:'Действие11',
				},
				'-',
				{
					text:'Действие14',
				},
				{
					text:'Действие2',
				},
				'-',
				'-',
				{
					text:'Действие10',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие1',
				},
				'-',
				'-',
				{
					text:'',
				},
				'-',
				'-',
				{
					text:'Действие4',
				},
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие10',
				},
				'-',
				{
					text:'Движения документа по регистрам',
				},
			]
		},
	]
});