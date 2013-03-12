﻿Ext.define('Документы.СправкаДругогоСтрахователяОЗаработке.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:682px;height:327px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справка другого страхователя о заработке',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:682px;height:25px;',
			items:
			[
				'-',
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Открыть категории',
				},
				{
					text:'Действие6',
				},
				'-',
				{
					text:'',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие3',
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
					text:'Действие3',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие5',
				},
				'-',
				'-',
				{
					text:'Действие5',
				},
				{
					text:'Открыть свойства',
				},
				'-',
				'-',
				{
					text:'Действие4',
				},
				'-',
				'-',
				{
					text:'Движения документа по регистрам',
				},
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Редактировать номер',
				},
				'-',
				'-',
				{
					text:'Действие4',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:302px;width:682px;height:25px;',
			items:
			[
				{
					text:'Записать',
				},
				{
					text:'Закрыть',
				},
				'-',
				'-',
				{
					text:'OK',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:361px;top:33px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:454px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОт',
			text: 'от:',
			style: 'position:absolute;left:534px;top:33px;width:20px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:554px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:33px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:113px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:361px;top:58px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:454px;top:58px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаботник',
			text: 'Сотрудник:',
			style: 'position:absolute;left:8px;top:58px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Сотрудник',
			style: 'position:absolute;left:113px;top:58px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Страхователь',
			style: 'position:absolute;left:113px;top:83px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:275px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:96px;top:275px;width:578px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтрахователь',
			text: 'Страхователь:',
			style: 'position:absolute;left:8px;top:83px;width:100px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:136px;width:666px;height:132px;',
			height: 132,width: 666,
			columns:
			[
				{
					text:'№',
					width:'28',
				},
				{
					text:'Расчетный год',
					width:'100',
				},
				{
					text:'Заработок',
					width:'100',
				},
				{
					text:'Дней болезни, ухода за детьми и др.',
					width:'200',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:112px;width:666px;height:24px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Действие6',
				},
				'-',
				{
					text:'Действие2',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие7',
				},
				'-',
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьПериодРаботыС',
			text: 'Период работы с:',
			style: 'position:absolute;left:361px;top:83px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПериодРаботыС',
			style: 'position:absolute;left:454px;top:83px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПериодРаботыПо',
			text: 'по:',
			style: 'position:absolute;left:537px;top:83px;width:16px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПериодРаботыПо',
			style: 'position:absolute;left:554px;top:83px;width:80px;height:19px;',
		},
	]
});