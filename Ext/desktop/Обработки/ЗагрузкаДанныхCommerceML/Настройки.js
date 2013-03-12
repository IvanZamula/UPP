﻿Ext.define('Обработки.ЗагрузкаДанныхCommerceML.Настройки',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:442px;height:132px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройки загрузки данных',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:107px;width:442px;height:25px;',
			items:
			[
				{
					text:'ОК',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Записывать документы в режиме обмена данными',
			style: 'position:absolute;left:8px;top:8px;width:283px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарийКДокументамИСправочникам',
			text: 'Начало комментария для документов и справочников:',
			style: 'position:absolute;left:8px;top:57px;width:283px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:31px;top:80px;width:403px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Автоматически создавать недостающие договоры',
			style: 'position:absolute;left:8px;top:32px;width:283px;height:19px;',
		},
	]
});