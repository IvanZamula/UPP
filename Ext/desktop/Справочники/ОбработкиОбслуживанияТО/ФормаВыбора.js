﻿Ext.define('Справочники.ОбработкиОбслуживанияТО.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:600px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Обработки обслуживания торгового оборудования',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:584px;height:259px;',
			height: 259,width: 584,
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
					text:'Вид торгового оборудования',
					width:'200',
				},
				{
					text:'Наименование',
					width:'300',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:25px;',
			items:
			[
				{
					text:'',
				},
				{
					text:'Действия формы выбрать',
				},
				'-',
				'-',
			]
		},
	]
});