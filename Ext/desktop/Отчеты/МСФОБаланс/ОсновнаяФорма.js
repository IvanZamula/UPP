﻿Ext.define('Отчеты.МСФОБаланс.ОсновнаяФорма',
	{
	extend: 'Ext.window.Window',
	height: 269,width: 276,
	iconCls: 'bogus',
	title: 'Баланс по МСФО',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:244px;width:276px;height:25px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ОК',
				},
			]
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущийПериод',
			text: '',
			style: 'position:absolute;left:20px;top:124px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующийПериод',
			text: '',
			style: 'position:absolute;left:224px;top:124px;width:21px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:8px;top:27px;width:260px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаВыбораФормы',
			text: 'Выбрать форму',
			style: 'position:absolute;left:8px;top:217px;width:100px;height:19px;',
		},
	]
});