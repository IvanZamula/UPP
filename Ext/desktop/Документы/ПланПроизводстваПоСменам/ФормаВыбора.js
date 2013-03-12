﻿Ext.define('Документы.ПланПроизводстваПоСменам.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:628px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'План производства по сменам',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:612px;height:380px;',
			height: 380,width: 612,
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
					text:'Ответственный',
					width:'120',
				},
				{
					text:'Подразделение',
					width:'120',
				},
				{
					text:'Проект',
					width:'120',
				},
				{
					text:'Комментарий',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:628px;height:25px;',
			items:
			[
				'-',
				{
					text:'Перейти',
				},
				{
					text:'Движения документа по регистрам',
				},
				'-',
				{
					text:'Выбрать',
				},
			]
		},
	]
});