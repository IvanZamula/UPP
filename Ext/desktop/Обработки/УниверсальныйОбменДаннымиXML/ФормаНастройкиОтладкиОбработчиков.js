﻿Ext.define('Обработки.УниверсальныйОбменДаннымиXML.ФормаНастройкиОтладкиОбработчиков',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:567px;height:360px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка отладки обработчиков',
	
	items:
	[
		{
			xtype: 'button',
			name: 'КнопкаВыгрузитьКодОбработчиков',
			text: 'Сформировать модуль отладки выгрузки',
			style: 'position:absolute;left:140px;top:119px;width:240px;height:27px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИмяФайлаВнешнейОбработкиОбработчиковСобытий',
			text: 'Имя файла внешней обработки с модулем отладки:',
			style: 'position:absolute;left:8px;top:286px;width:290px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяФайлаВнешнейОбработкиОбработчиковСобытий',
			style: 'position:absolute;left:8px;top:311px;width:551px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:336px;width:567px;height:24px;',
			items:
			[
				'-',
				{
					text:'Отмена',
				},
				{
					text:'Готово',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:290px;top:25px;width:269px;height:67px;',
			height: 67,width: 269,
			items:
			[
				{
					title:'Подсказка 0',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Алгоритмы не выгружаются. Режим удобно использовать, когда производить отладку алгоритмов не требуется. Алгоритмы будут выполняться, но их код недоступен для отладки.',
			style: 'position:absolute;left:0px;top:0px;width:269px;height:67px;',
		},
					]
				},
				{
					title:'Подсказка 1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'Алгоритмы выгружаются как отдельные процедуры. При вызове алгоритма происходит обращение к соответствующей процедуре обработки. Ограничения использования режима см. справку.',
			style: 'position:absolute;left:0px;top:0px;width:269px;height:67px;',
		},
					]
				},
				{
					title:'Подсказка 2',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Алгоритмы выгружаются как интегрированный код в обработчиках, т.е. взамен строки вызова алгоритма вставляется полный код алгоритма с учетом вложенных алгоритмов. Ограничения использования режима см. справку.',
			style: 'position:absolute;left:0px;top:0px;width:269px;height:67px;',
		},
					]
				},
			]
		},
		{
			xtype: 'button',
			name: 'КнопкаОткрытьФайл',
			text: '',
			style: 'position:absolute;left:386px;top:119px;width:38px;height:27px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: '1. После формирования модуля отладки необходимо скопировать в буфер обмена полученный код обработчиков.
2. Открыть конфигуратор и создать новую внешнюю обработку. В модуль обработки вставить содержимое буфера обмена. Сохранить обработку.
3. На завершающем четвертом шаге указать вновь созданную обработку как обработку с экспортными процедурами обработчиков.
',
			style: 'position:absolute;left:8px;top:179px;width:489px;height:80px;',
		},
	]
});