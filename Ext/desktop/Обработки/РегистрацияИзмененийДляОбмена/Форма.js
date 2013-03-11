﻿Ext.define('Обработки.РегистрацияИзмененийДляОбмена.Форма',
	{
	extend: 'Ext.window.Window',
	height: 445,width: 702,
	iconCls: 'bogus',
	title: 'Регистрация изменений для обмена',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:420px;width:702px;height:25px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие2',
				},
				{
					text:'ЗарегистрированныеИзменения',
				},
				{
					text:'ОсновныеДействияФормыЗакрыть',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'УзелОбмена',
			style: 'position:absolute;left:85px;top:4px;width:609px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:128px;width:686px;height:284px;',
			height: 284,width: 686,
			columns:
			[
				{
					text:'Имя',
				},
				{
					text:'РежимАвтоРегистрации',
				},
				{
					text:'Удален',
				},
				{
					text:'КоличествоЗарегистрированных',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:100px;width:686px;height:24px;',
			items:
			[
				{
					text:'СвернутьДерево',
				},
				{
					text:'ПоказатьЗарегистрированныеИзмененияДанногоТипа',
				},
				{
					text:'Развернуть',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ПоказатьРезультатСтандартнойВыгрузки',
				},
				{
					text:'ДобавитьРегистрацию',
				},
				{
					text:'ОтменитьРегистрациюИзменения',
				},
			]
		},
		{
			xtype: 'button',
			name: 'УдалитьРегистрациюДляВсехОбъектов',
			text: 'Удалить всю регистрацию ...',
			style: 'position:absolute;left:328px;top:76px;width:167px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ЗарегистрироватьИзмененияДляВсехОбъектов',
			text: 'Зарегистрировать все ...',
			style: 'position:absolute;left:8px;top:76px;width:137px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ЗарегистрироватьИзмененияПоОдномуОбъекту',
			text: 'Зарегистрировать по одному ...',
			style: 'position:absolute;left:151px;top:76px;width:171px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаИзменитьНомера',
			text: 'Изменить номера сообщений...',
			style: 'position:absolute;left:500px;top:76px;width:167px;height:19px;',
		},
	]
});