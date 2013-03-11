﻿Ext.define('Обработки.РегламентныйПересчетПоМоделямБюджетирования.Форма',
	{
	extend: 'Ext.window.Window',
	height: 328,width: 457,
	iconCls: 'bogus',
	title: 'Обработка  Регламентный пересчет по моделям бюджетирования',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:457px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:303px;width:457px;height:25px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие1',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНач',
			style: 'position:absolute;left:70px;top:57px;width:96px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаКон',
			style: 'position:absolute;left:186px;top:57px;width:96px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:284px;top:57px;width:19px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВвода1',
			style: 'position:absolute;left:70px;top:33px;width:233px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:189px;width:441px;height:106px;',
			height: 106,width: 441,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'РасчетПоМоделиБюджетирования',
				},
				{
					text:'Сценарий',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:165px;width:441px;height:24px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'Заполнить',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие8',
				},
			]
		},
	]
});