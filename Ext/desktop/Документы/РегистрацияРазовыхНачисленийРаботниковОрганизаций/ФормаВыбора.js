﻿Ext.define('Документы.РегистрацияРазовыхНачисленийРаботниковОрганизаций.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:550px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Разовые начисления сотрудникам организаций',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:534px;height:259px;',
			height: 259,width: 534,
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
					text:'Месяц начисления',
					width:'84',
				},
				{
					text:'Сотрудники',
					width:'100',
				},
				{
					text:'Ответственный',
					width:'180',
				},
				{
					text:'Комментарий',
					width:'120',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:550px;height:25px;',
			items:
			[
				{
					text:'Действие4',
				},
				{
					text:'Действие1',
				},
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
					text:'Зарплата к выплате (начисленные суммы за вычетом налогов)',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие9',
				},
				'-',
				'-',
				'-',
				'-',
				'-',
				{
					text:'Действие3',
				},
				{
					text:'',
				},
				{
					text:'Зарплата к выплате (начисленные суммы)',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие2',
				},
				'-',
				{
					text:'',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие1',
				},
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие7',
				},
				'-',
				'-',
				{
					text:'Действие6',
				},
				'-',
				'-',
				{
					text:'Действие8',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие4',
				},
				{
					text:'Структура подчиненности документа',
				},
				'-',
				{
					text:'Действие10',
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
					text:'Действие5',
				},
				'-',
			]
		},
	]
});