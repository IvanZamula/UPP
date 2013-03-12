﻿Ext.define('Справочники.ПричиныСписания.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:350px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Причины списания',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:334px;height:280px;',
			height: 280,width: 334,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Код',
					width:'40',
				},
				{
					text:'Наименование',
					width:'220',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:350px;height:25px;',
			items:
			[
			]
		},
	]
});