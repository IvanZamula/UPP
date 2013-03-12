﻿Ext.define('Документы.ТабельУчетаРабочегоВремениОрганизации.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:720px;height:420px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Табель учета рабочего времени',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:704px;height:379px;',
			height: 379,width: 704,
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
					width:'75',
				},
				{
					text:'Организация',
					width:'125',
				},
				{
					text:'Месяц',
					width:'84',
				},
				{
					text:'Подразделение',
					width:'120',
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
			style: 'position:absolute;left:0px;top:0px;width:720px;height:25px;',
			items:
			[
				{
					text:'Действие10',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие',
				},
				{
					text:'Печать',
				},
				{
					text:'Действие14',
				},
				'-',
				{
					text:'Действие5',
				},
				{
					text:'',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие6',
				},
				'-',
				'-',
				'-',
				'-',
				{
					text:'Действие5',
				},
				{
					text:'',
				},
				{
					text:'Действие8',
				},
				'-',
				'-',
				{
					text:'Действие2',
				},
				{
					text:'Движения документа по регистрам',
				},
				'-',
				{
					text:'Действие12',
				},
				{
					text:'Действие9',
				},
				{
					text:'Структура подчиненности документа',
				},
				'-',
				{
					text:'Действие9',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие7',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие11',
				},
				'-',
				'-',
				{
					text:'Действия формы выбрать',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие2',
				},
				'-',
				{
					text:'Действие8',
				},
				'-',
				{
					text:'Действие13',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Действие3',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие',
				},
			]
		},
	]
});