﻿Ext.define('Отчеты.РегламентированныйОтчетПрибыль.ОсновнаяФорма',
	{
	extend: 'Ext.window.Window',
	height: 255,width: 276,
	iconCls: 'bogus',
	title: 'Декларация по налогу на прибыль',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:230px;width:276px;height:25px;',
			items:
			[
				{
					text:'ОК',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
				{
					text:'Справка',
				},
				{
					text:'Разделитель1',
				},
			]
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущийПериод',
			text: '',
			style: 'position:absolute;left:100px;top:105px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующийПериод',
			text: '',
			style: 'position:absolute;left:248px;top:105px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаВыбораФормы',
			text: 'Выбрать форму',
			style: 'position:absolute;left:14px;top:203px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:8px;top:27px;width:260px;height:19px;',
		},
	]
});