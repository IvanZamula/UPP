﻿Ext.define('Справочники.ОбъектыСтроительства.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:709px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Объекты строительства',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:229px;top:33px;width:472px;height:280px;',
			height: 280,width: 472,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Код',
					width:'80',
				},
				{
					text:'Наименование',
					width:'220',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:709px;height:25px;',
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:217px;height:280px;',
			height: 280,width: 217,
			columns:
			[
				{
					text:'Наименование',
					width:'120',
				},
			]
		},
	]
});