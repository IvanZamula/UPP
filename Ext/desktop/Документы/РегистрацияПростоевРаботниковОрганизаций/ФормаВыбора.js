﻿Ext.define('Документы.РегистрацияПростоевРаботниковОрганизаций.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:551px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Регистрации простоев в организациях',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:535px;height:259px;',
			height: 259,width: 535,
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
					width:'180',
				},
				{
					text:'Сотрудник',
					width:'180',
				},
				{
					text:'Месяц начисления',
					width:'84',
				},
				{
					text:'Вид простоя',
					width:'120',
				},
				{
					text:'Дата начала',
					width:'84',
				},
				{
					text:'Дата окончания',
					width:'84',
				},
				{
					text:'Ответственный',
					width:'180',
				},
				{
					text:'Комментарий',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:551px;height:25px;',
			items:
			[
				{
					text:'Действие8',
				},
				{
					text:'',
				},
				{
					text:'Действие',
				},
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие6',
				},
				'-',
				{
					text:'Действие9',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие11',
				},
				{
					text:'',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие5',
				},
				{
					text:'Печать',
				},
				{
					text:'Действие1',
				},
				'-',
				{
					text:'Действие9',
				},
				{
					text:'Действие6',
				},
				{
					text:'',
				},
				{
					text:'Действие11',
				},
				{
					text:'',
				},
				{
					text:'Действие5',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие10',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие13',
				},
				'-',
				{
					text:'Действие10',
				},
				'-',
				{
					text:'Действие3',
				},
				'-',
				'-',
				'-',
				{
					text:'Действие7',
				},
				'-',
				{
					text:'Действие1',
				},
				'-',
				{
					text:'Действие4',
				},
				'-',
				'-',
				'-',
				'-',
				{
					text:'Действие14',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие2',
				},
			]
		},
	]
});