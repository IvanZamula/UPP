﻿Ext.define('Документы.НДФЛПодтверждениеПраваНаИмущественныйВычет.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:517px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Подтверждение права на имущественный вычет',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:501px;height:259px;',
			height: 259,width: 501,
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
					text:'Налоговый период',
					width:'80',
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
			style: 'position:absolute;left:0px;top:0px;width:517px;height:25px;',
			items:
			[
				{
					text:'Действие',
				},
				'-',
				{
					text:'Действие11',
				},
				{
					text:'Действие5',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Действие10',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие8',
				},
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Действие',
				},
				'-',
				'-',
				{
					text:'Действие2',
				},
				'-',
				'-',
				{
					text:'Действие6',
				},
				'-',
				{
					text:'Действие4',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие7',
				},
				'-',
				{
					text:'Действие8',
				},
				'-',
				{
					text:'Действие2',
				},
				'-',
				{
					text:'Действие9',
				},
				'-',
				{
					text:'Действие14',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие10',
				},
				'-',
				{
					text:'Действие4',
				},
				'-',
				{
					text:'Действие5',
				},
				'-',
				'-',
				{
					text:'Действие13',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие1',
				},
				{
					text:'',
				},
				{
					text:'Действие12',
				},
			]
		},
	]
});