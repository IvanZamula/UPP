﻿Ext.define('Документы.ПринятиеКУчетуНМА.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:780px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Принятие к учету НМА',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:380px;',
			height: 380,width: 764,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'БУ',
					width:'20',
				},
				{
					text:'НУ',
					width:'20',
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
					text:'Нематериальный актив',
					width:'120',
				},
				{
					text:'Счет учета',
					width:'80',
				},
				{
					text:'Субконто 1',
					width:'120',
				},
				{
					text:'Субконто 2',
					width:'120',
				},
				{
					text:'Субконто 3',
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
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				'-',
				{
					text:'Дт/кт',
				},
				{
					text:'Дт/кт',
				},
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Выбрать',
				},
				'-',
				'-',
			]
		},
	]
});