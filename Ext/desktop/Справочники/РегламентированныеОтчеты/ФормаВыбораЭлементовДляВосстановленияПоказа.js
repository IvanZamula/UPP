﻿Ext.define('Справочники.РегламентированныеОтчеты.ФормаВыбораЭлементовДляВосстановленияПоказа',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:550px;height:361px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Скрытые отчеты',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:336px;width:550px;height:25px;',
			items:
			[
				{
					text:'ОК',
				},
				'-',
				'-',
				{
					text:'Закрыть',
				},
				{
					text:'Действие',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:36px;width:534px;height:292px;',
			height: 292,width: 534,
			columns:
			[
				{
					text:'',
					width:'21',
				},
				{
					text:'Код',
					width:'98',
				},
				{
					text:'Наименование',
					width:'350',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:10px;width:534px;height:25px;',
			items:
			[
				{
					text:'Установить флажки',
				},
				{
					text:'Снять флажки',
				},
			]
		},
	]
});