﻿Ext.define('Документы.УдалитьОтсутствиеНаРаботе.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:721px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Отсутствия на работе',
	
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
					text:'Подразделение',
					width:'120',
				},
				{
					text:'Работники',
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
				'-',
				{
					text:'Действие',
				},
				{
					text:'Подменю2',
				},
				'-',
				{
					text:'Движения документа по регистрам',
				},
			]
		},
	]
});