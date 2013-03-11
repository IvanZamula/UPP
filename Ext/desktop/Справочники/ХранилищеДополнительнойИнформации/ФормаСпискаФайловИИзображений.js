﻿Ext.define('Справочники.ХранилищеДополнительнойИнформации.ФормаСпискаФайловИИзображений',
	{
	extend: 'Ext.window.Window',
	height: 254,width: 651,
	iconCls: 'bogus',
	title: 'Хранилище дополнительной информации',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:10px;width:635px;height:236px;',
			height: 236,width: 635,
			items:
			[
				{
					title:'Изображения',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:435px;height:180px;',
			height: 180,width: 435,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'Наименование',
				},
				{
					text:'Объект',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:621px;height:24px;',
			items:
			[
				{
					text:'Подменю',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ОсновноеИзображение',
				},
				{
					text:'Действие7',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ОсновноеИзображение',
				},
				{
					text:'Действие5',
				},
				{
					text:'РазделительИзображения',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие3',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие2',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие8',
				},
			]
		},
					]
				},
				{
					title:'Файлы',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:621px;height:180px;',
			height: 180,width: 621,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'ИмяФайла',
				},
				{
					text:'Наименование',
				},
				{
					text:'Объект',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:621px;height:24px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Подменю',
				},
				{
					text:'СохранитьНаДиске1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие11',
				},
				{
					text:'ОткрытьФайлы1',
				},
				{
					text:'Действие4',
				},
				{
					text:'СохранитьНаДиске',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие5',
				},
				{
					text:'ДобавитьНесколькоФайлов',
				},
				{
					text:'Действие10',
				},
				{
					text:'Подменю',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие6',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие8',
				},
				{
					text:'ДобавитьНесколькоФайлов1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие1',
				},
				{
					text:'ОткрытьФайлы',
				},
			]
		},
					]
				},
			]
		},
	]
});