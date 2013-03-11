﻿Ext.define('Отчеты.РегламентированныйОтчетАлкоПриложение1.ФормаОтчета2009Кв4',
	{
	extend: 'Ext.window.Window',
	height: 448,width: 800,
	iconCls: 'bogus',
	title: 'Декларация об объёмах производства и оборота этилового спирта',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:800px;height:25px;',
			items:
			[
				{
					text:'ВыбратьВариантОчисткиОтчета',
				},
				{
					text:'Справка',
				},
				{
					text:'Выгрузка',
				},
				{
					text:'ПодменюОчистить',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Выгрузить',
				},
				{
					text:'Поиск',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'РасширитьПолеБланка',
				},
				{
					text:'КнопкаЗаполнитьСведенияОбОрганизации',
				},
				{
					text:'КнопкаНастройкаСтраниц',
				},
				{
					text:'Проверить',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель4',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:423px;width:800px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'СохранитьИЗакрыть',
				},
				{
					text:'ПодменюПечати',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Записать',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:79px;width:784px;height:312px;',
			height: 312,width: 784,
			items:
			[
				{
					title:'Титульный',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтраницуТитульный',
			text: 'Добавить',
			style: 'position:absolute;left:525px;top:264px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтраницуТитульный',
			text: 'Удалить',
			style: 'position:absolute;left:611px;top:264px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущаяСтраницаТитульный',
			text: '',
			style: 'position:absolute;left:396px;top:264px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующаяСтраницаТитульный',
			text: '',
			style: 'position:absolute;left:485px;top:264px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерейтиНаСтраницуТитульный',
			text: 'Перейти',
			style: 'position:absolute;left:696px;top:264px;width:80px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:239px;width:770px;height:21px;',
			height: 21,width: 770,
			items:
			[
				{
					title:'Страница1',
					items:
					[
					]
				},
			]
		},
					]
				},
				{
					title:'ФизЛица',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтраницуФизЛица',
			text: 'Добавить',
			style: 'position:absolute;left:525px;top:264px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтраницуФизЛица',
			text: 'Удалить',
			style: 'position:absolute;left:611px;top:264px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущаяСтраницаФизЛица',
			text: '',
			style: 'position:absolute;left:396px;top:264px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующаяСтраницаФизЛица',
			text: '',
			style: 'position:absolute;left:485px;top:264px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерейтиНаСтраницуФизЛица',
			text: 'Перейти',
			style: 'position:absolute;left:696px;top:264px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Декларация',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиДекларация',
			text: 'Добавить',
			style: 'position:absolute;left:611px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиДекларация',
			text: 'Удалить',
			style: 'position:absolute;left:696px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтраницуДекларация',
			text: 'Добавить',
			style: 'position:absolute;left:525px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтраницуДекларация',
			text: 'Удалить',
			style: 'position:absolute;left:611px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущаяСтраницаДекларация',
			text: '',
			style: 'position:absolute;left:396px;top:241px;width:21px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующаяСтраницаДекларация',
			text: '',
			style: 'position:absolute;left:485px;top:241px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерейтиНаСтраницуДекларация',
			text: 'Перейти',
			style: 'position:absolute;left:696px;top:241px;width:80px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:784px;height:46px;',
			height: 46,width: 784,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаДатаСдачи',
			style: 'position:absolute;left:103px;top:23px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерКорректировки',
			style: 'position:absolute;left:331px;top:23px;width:49px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:391px;width:784px;height:24px;',
			height: 24,width: 784,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:263px;top:5px;width:521px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Статус',
			style: 'position:absolute;left:47px;top:5px;width:119px;height:19px;',
		},
					]
				},
			]
		},
	]
});