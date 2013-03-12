﻿Ext.define('Документы.ВозвратНаРаботуОрганизаций.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:516px;height:404px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Возврат на работу в организацию',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:84px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:176px;top:33px;width:16px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:94px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:194px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:516px;height:25px;',
			items:
			[
				{
					text:'Открыть категории',
				},
				'-',
				{
					text:'Открыть свойства',
				},
				'-',
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Редактировать номер',
				},
				{
					text:'Структура подчиненности документа',
				},
				'-',
			]
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:353px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:94px;top:353px;width:414px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:148px;width:500px;height:160px;',
			height: 160,width: 500,
			columns:
			[
				{
					text:'№',
					width:'28',
				},
				{
					text:'Таб. №',
					width:'83',
				},
				{
					text:'Сотрудник',
					width:'158',
				},
				{
					text:'Дата возврата',
					width:'127',
				},
				{
					text:'Занимать ставку',
					width:'100',
				},
				{
					text:'Сторно',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:124px;width:500px;height:24px;',
			items:
			[
				{
					text:'Списком сотрудников',
				},
				{
					text:'Действие15',
				},
				'-',
				{
					text:'Скопировать',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие13',
				},
				{
					text:'Добавить',
				},
				{
					text:'Удалить',
				},
				'-',
				{
					text:'Подбор',
				},
				'-',
				{
					text:'Действие16',
				},
				{
					text:'Изменить',
				},
				{
					text:'Действие17',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:268px;top:379px;width:248px;height:25px;',
			items:
			[
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'Записать',
				},
				{
					text:'ОК',
				},
				'-',
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:57px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:94px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:81px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:94px;top:81px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПредупреждение',
			text: '',
			style: 'position:absolute;left:30px;top:314px;width:265px;height:33px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:295px;top:314px;width:83px;height:33px;',
			height: 33,width: 83,
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:379px;top:314px;width:129px;height:33px;',
			height: 33,width: 129,
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:379px;width:268px;height:25px;',
			items:
			[
				{
					text:'Строки нескольких сотрудников',
				},
				{
					text:'Строки текущего сотрудника',
				},
				'-',
				'-',
				{
					text:'Отменить исправление',
				},
				{
					text:'Весь документ',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:30px;top:224px;width:389px;height:24px;',
			items:
			[
				{
					text:'',
				},
				{
					text:'Действие9',
				},
				{
					text:'Скопировать',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие8',
				},
				'-',
				{
					text:'Действие12',
				},
				{
					text:'Действие',
				},
				'-',
				{
					text:'Действие1',
				},
				{
					text:'',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие10',
				},
				{
					text:'Изменить',
				},
				'-',
				{
					text:'Действие6',
				},
				{
					text:'Удалить',
				},
				{
					text:'Добавить',
				},
				{
					text:'Действие4',
				},
			]
		},
	]
});