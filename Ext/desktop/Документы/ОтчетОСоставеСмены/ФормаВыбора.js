﻿Ext.define('Документы.ОтчетОСоставеСмены.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:400px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Отчеты о составе смены',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:384px;height:259px;',
			height: 259,width: 384,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Дата',
					width:'120',
				},
				{
					text:'Номер',
					width:'80',
				},
				{
					text:'Начало смены',
					width:'120',
				},
				{
					text:'Смена',
					width:'120',
				},
				{
					text:'Подразделение',
					width:'120',
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
			style: 'position:absolute;left:0px;top:0px;width:400px;height:25px;',
			items:
			[
				{
					text:'&Скопировать',
				},
				{
					text:'Справка',
				},
				'-',
				'-',
				{
					text:'Обновить',
				},
				{
					text:'Установить пометку удаления',
				},
				{
					text:'&Изменить',
				},
				{
					text:'&Добавить',
				},
				{
					text:'Выбрать',
				},
				'-',
			]
		},
	]
});