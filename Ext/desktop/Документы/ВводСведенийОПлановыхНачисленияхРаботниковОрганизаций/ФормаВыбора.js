﻿Ext.define('Документы.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:620px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Сведения о плановых начислениях сотрудников организации (ввод)',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:604px;height:380px;',
			height: 380,width: 604,
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
			style: 'position:absolute;left:0px;top:0px;width:620px;height:25px;',
			items:
			[
				'-',
				{
					text:'Действие6',
				},
				{
					text:'Действие2',
				},
				{
					text:'',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие6',
				},
				'-',
				'-',
				'-',
				'-',
				{
					text:'Действие8',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие13',
				},
				{
					text:'Структура подчиненности документа',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие9',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие3',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Действие11',
				},
				{
					text:'',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие10',
				},
				{
					text:'Действие1',
				},
				'-',
				{
					text:'Действие10',
				},
				{
					text:'Действие3',
				},
				{
					text:'',
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
					text:'Действие',
				},
				'-',
				{
					text:'',
				},
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Действие7',
				},
				'-',
				{
					text:'Действие11',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие1',
				},
				'-',
				'-',
				{
					text:'Действие4',
				},
			]
		},
	]
});