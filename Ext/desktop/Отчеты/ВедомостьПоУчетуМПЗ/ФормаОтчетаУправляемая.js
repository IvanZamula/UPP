﻿Ext.require(['Данные.Отчеты.ВедомостьПоУчетуМПЗ'], function () 
{
	Ext.define('Отчеты.ВедомостьПоУчетуМПЗ.ФормаОтчетаУправляемая',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:0px;height:0px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: '',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		],
	}],
	dockedItems:
	[
	]
	});
});