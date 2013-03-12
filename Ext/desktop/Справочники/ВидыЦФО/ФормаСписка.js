﻿Ext.define('Справочники.ВидыЦФО.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:474px;height:361px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Виды ЦФО',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:174px;top:33px;width:292px;height:320px;',
			height: 320,width: 292,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Код',
					width:'81',
				},
				{
					text:'Наименование',
					width:'220',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:474px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:160px;height:320px;',
			height: 320,width: 160,
			columns:
			[
				{
					text:'Наименование',
					width:'160',
				},
			]
		},
	]
});