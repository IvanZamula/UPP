﻿Ext.define('Документы.ЗаказПокупателя.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:780px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Заказы покупателей',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:380px;',
			height: 380,width: 764,
			columns:
			[
				{
					text:' ',
					width:'32',
				},
				{
					text:'БУ',
					width:'20',
				},
				{
					text:'НУ',
					width:'20',
				},
				{
					text:'ОУ',
					width:'21',
				},
				{
					text:'Дата',
					width:'132',
				},
				{
					text:'Номер',
					width:'80',
				},
				{
					text:'Вид операции',
					width:'120',
				},
				{
					text:'Сумма',
					width:'80',
				},
				{
					text:'Валюта',
					width:'60',
				},
				{
					text:'Контрагент',
					width:'120',
				},
				{
					text:'Дата оплаты',
					width:'84',
				},
				{
					text:'Дата отгрузки',
					width:'84',
				},
				{
					text:'Склад-группа',
					width:'120',
				},
				{
					text:'Организация',
					width:'120',
				},
				{
					text:'Подразделение',
					width:'162',
				},
				{
					text:'Ответственный',
					width:'120',
				},
				{
					text:'Комментарий',
					width:'120',
				},
				{
					text:'Состояние ЭД',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				{
					text:'Перезаполнить данными из электронного документа',
				},
				{
					text:'Открыть актуальный электронный документ',
				},
				'-',
				{
					text:'Файлы',
				},
				'-',
				'-',
				'-',
				{
					text:'Список электронных документов',
				},
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Сформировать, подписать и отправить',
				},
				{
					text:'Анализ',
				},
				'-',
				{
					text:'Печать по умолчанию',
				},
				{
					text:'Сформировать новый электронный документ',
				},
				'-',
			]
		},
	]
});