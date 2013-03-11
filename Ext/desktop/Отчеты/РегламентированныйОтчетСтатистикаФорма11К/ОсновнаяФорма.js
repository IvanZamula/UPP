﻿Ext.define('Отчеты.РегламентированныйОтчетСтатистикаФорма11К.ОсновнаяФорма',
	{
	extend: 'Ext.window.Window',
	height: 236,width: 276,
	iconCls: 'bogus',
	title: 'Статистика: Форма 11-К: ""Сведения о наличии и движении основных фондов (средств) и других нефинансовых активов',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:211px;width:276px;height:25px;',
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
			style: 'position:absolute;left:17px;top:85px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующийПериод',
			text: '',
			style: 'position:absolute;left:222px;top:85px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаВыбораФормы',
			text: 'Выбрать форму',
			style: 'position:absolute;left:17px;top:184px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:8px;top:27px;width:260px;height:19px;',
		},
	]
});