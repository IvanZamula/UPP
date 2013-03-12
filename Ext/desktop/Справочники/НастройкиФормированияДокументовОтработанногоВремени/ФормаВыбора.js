﻿Ext.define('Справочники.НастройкиФормированияДокументовОтработанногоВремени.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:645px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Настройки формирования документов отработанного времени',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:159px;top:33px;width:478px;height:259px;',
			height: 259,width: 478,
			columns:
			[
				{
					text:'',
					width:'39',
				},
				{
					text:'Код',
					width:'63',
				},
				{
					text:'Наименование',
					width:'175',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:145px;height:259px;',
			height: 259,width: 145,
			columns:
			[
				{
					text:'Наименование',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:645px;height:25px;',
			items:
			[
				{
					text:'Действия формы выбрать',
				},
				'-',
			]
		},
	]
});