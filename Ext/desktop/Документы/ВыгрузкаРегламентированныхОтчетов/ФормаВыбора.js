﻿Ext.define('Документы.ВыгрузкаРегламентированныхОтчетов.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 391,width: 704,
	iconCls: 'bogus',
	title: 'Выгрузка регламентированных отчетов',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:704px;height:25px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие14',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие4',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие8',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие9',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие8',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Подменю',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:688px;height:151px;',
			height: 151,width: 688,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'Дата1',
				},
				{
					text:'Номер1',
				},
				{
					text:'Период',
				},
				{
					text:'Организация',
				},
				{
					text:'Комментарий',
				},
				{
					text:'ПериодПо',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:190px;width:688px;height:193px;',
			height: 193,width: 688,
			items:
			[
				{
					title:'Отчеты',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:674px;height:161px;',
			height: 161,width: 674,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'Основание',
				},
			]
		},
					]
				},
				{
					title:'ТекстыВыгрузки',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:182px;height:161px;',
			height: 161,width: 182,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'Тип',
				},
				{
					text:'ИмяФайла',
				},
				{
					text:'Текст',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТекстВыгрузки',
			style: 'position:absolute;left:194px;top:6px;width:486px;height:161px;',
		},
					]
				},
			]
		},
	]
});