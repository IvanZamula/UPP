﻿Ext.define('Документы.Увольнение.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:1000px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Увольнения',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:984px;height:380px;',
			height: 380,width: 984,
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
			style: 'position:absolute;left:0px;top:0px;width:1000px;height:25px;',
			items:
			[
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
				{
					text:'Действие9',
				},
				'-',
				{
					text:'Действие11',
				},
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
					text:'Действие7',
				},
				'-',
				'-',
				{
					text:'Действие3',
				},
				'-',
				'-',
				{
					text:'Действие5',
				},
				{
					text:'',
				},
				{
					text:'Действие2',
				},
				'-',
				{
					text:'Действие2',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие8',
				},
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Действие9',
				},
				'-',
				{
					text:'Действие',
				},
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие4',
				},
				'-',
				'-',
				{
					text:'Действие10',
				},
				{
					text:'Действие12',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Действие13',
				},
				{
					text:'',
				},
				{
					text:'Действие8',
				},
				'-',
				{
					text:'Действие1',
				},
				'-',
				{
					text:'Увольнение из организаций',
				},
				{
					text:'Действие5',
				},
				'-',
				'-',
				'-',
				'-',
				{
					text:'Действие4',
				},
				{
					text:'Действие',
				},
			]
		},
	]
});