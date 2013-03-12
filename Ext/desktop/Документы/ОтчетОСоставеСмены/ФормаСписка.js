﻿Ext.define('Документы.ОтчетОСоставеСмены.ФормаСписка',
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
					text:'Поиск по номеру...',
				},
				{
					text:'&Удалить',
				},
				{
					text:'Отключить отбор',
				},
				'-',
				{
					text:'&Скопировать',
				},
				{
					text:'Печать по умолчанию',
				},
				{
					text:'Поиск по номеру...',
				},
				{
					text:'&Скопировать',
				},
				{
					text:'Настройка списка...',
				},
				{
					text:'&Изменить',
				},
				{
					text:'Установить пометку удаления',
				},
				{
					text:'Отмена проведения',
				},
				'-',
				'-',
				'-',
				{
					text:'',
				},
				'-',
				'-',
				{
					text:'&Изменить',
				},
				{
					text:'Установить пометку удаления',
				},
				'-',
				'-',
				{
					text:'Отбор по значению в текущей колонке',
				},
				'-',
				'-',
				'-',
				{
					text:'Отбор по значению в текущей колонке',
				},
				'-',
				{
					text:'Установить отбор и сортировку списка...',
				},
				{
					text:'Установить интервал дат...',
				},
				{
					text:'&Добавить',
				},
				{
					text:'',
				},
				{
					text:'&Добавить',
				},
				'-',
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Отключить отбор',
				},
				'-',
				'-',
				{
					text:'Вывести список...',
				},
				{
					text:'',
				},
				{
					text:'Установить отбор и сортировку списка...',
				},
				{
					text:'',
				},
				{
					text:'',
				},
				{
					text:'Обновить',
				},
				{
					text:'Обновить',
				},
				{
					text:'Установить интервал дат...',
				},
				{
					text:'Справка',
				},
				{
					text:'',
				},
				{
					text:'Провести',
				},
			]
		},
	]
});