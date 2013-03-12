﻿Ext.define('Обработки.ЗакрытиеКассовойСмены.ОтчетКассовойСменыБезГашения',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:314px;height:93px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Отчет кассовой смены без гашения',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:314px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:68px;width:314px;height:25px;',
			items:
			[
				'-',
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'Снять X-отчет ',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьИнформация',
			text: 'Снятие  на фискальном регистраторе отчета кассовой смены без гашения',
			style: 'position:absolute;left:8px;top:33px;width:298px;height:27px;',
		},
	]
});