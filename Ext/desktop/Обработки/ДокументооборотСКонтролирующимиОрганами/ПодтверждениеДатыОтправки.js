﻿Ext.define('Обработки.ДокументооборотСКонтролирующимиОрганами.ПодтверждениеДатыОтправки',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:583px;height:109px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Подтверждение даты отправки',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:84px;width:583px;height:25px;',
			items:
			[
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Подтвердившая организация:',
			style: 'position:absolute;left:8px;top:57px;width:162px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ОрганизацияСтр',
			style: 'position:absolute;left:173px;top:57px;width:402px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Имя отправленного файла:',
			style: 'position:absolute;left:8px;top:32px;width:162px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяПоступившегоФайла',
			style: 'position:absolute;left:173px;top:32px;width:402px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Дата и время отправки:',
			style: 'position:absolute;left:8px;top:8px;width:162px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаОтправки',
			style: 'position:absolute;left:173px;top:8px;width:402px;height:19px;',
		},
	]
});