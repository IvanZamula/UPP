﻿Ext.define('Документы.ИнвентаризацияТоваровОтданныхНаКомиссию.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:740px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Инвентаризации товаров отданных на комиссию',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:724px;height:380px;',
			height: 380,width: 724,
			columns:
			[
				{
					text:' ',
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
					text:'Контрагент',
					width:'120',
				},
				{
					text:'Организация',
					width:'120',
				},
				{
					text:'Подразделение',
					width:'125',
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
			style: 'position:absolute;left:0px;top:0px;width:740px;height:25px;',
			items:
			[
				{
					text:'Печать по умолчанию',
				},
				'-',
			]
		},
	]
});