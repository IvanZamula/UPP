﻿Ext.define('Обработки.ПомощникНастройкиОбменаДаннымиУТУПП.ДополнительныеНастройкиФоновогоОбмена',
	{
	extend: 'Ext.window.Window',
	height: 209,width: 494,
	iconCls: 'bogus',
	title: 'Дополнительные настройки фонового обмена',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:184px;width:494px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Отмена',
				},
				{
					text:'ОК',
				},
			]
		},
		{
			xtype: 'button',
			name: 'ВыполнитьПодсчетОбъектовДляКоторыхНужноСопоставление',
			text: 'Подсчитать',
			style: 'position:absolute;left:328px;top:157px;width:124px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КоличествоОбъектовДляФоновогоОбмена',
			style: 'position:absolute;left:328px;top:133px;width:124px;height:19px;',
		},
	]
});