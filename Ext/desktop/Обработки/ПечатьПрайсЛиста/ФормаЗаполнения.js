﻿Ext.require(['Данные.Обработки.ПечатьПрайсЛиста'], function () 
{
	Ext.define('Обработки.ПечатьПрайсЛиста.ФормаЗаполнения',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаЗаполнения',
	style: 'position:absolute;width:671px;height:445px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Печать прайс-листа',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанель',
			style: 'position:absolute;left:0px;top:0px;width:671px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанель', Граница: 'Верхняя', Номер: 55, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:671,
			Верх:0,
			Лево:0,
			width: 671,
			height: 25,
			items:
			[
				'-',
				{
					xtype: 'splitbutton',
					id:'Подменю',
					text:'',
					menu: [
				{
					text:'Отбор',
					tooltip:'Отбор',
				},
				{
					text:'Сформировать',
					tooltip:'Сформировать',
				},
				'-',
					]
				},
				'-',
				{
					id:'Сформировать',
					text:'Сформировать',
					tooltip:'Сформировать',
				},
				{
					id:'Отбор',
					text:'Отбор',
					tooltip:'Отбор',
				},
				'-',
				{
					id:'Настройка',
					text:'Настройка...',
					tooltip:'Дополнительная настройка',
				},
				'-',
				{
					id:'Действие1',
					text:'Восстановить значения...',
					tooltip:'Восстановить значения',
					iconCls:'x-RestoreValues',
				},
				{
					id:'Действие2',
					text:'Сохранить значения...',
					tooltip:'Сохранить значения',
					iconCls:'x-SaveValues',
				},
				{
					id:'Действие',
					text:'Справка',
					tooltip:'Открыть справку',
				},
			]
		},
		{
			xtype: 'panel',
			id: 'ПанельОтбор',
			style: 'position:absolute;left:7px;top:57px;width:657px;height:46px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:46,
			Ширина:657,
			Верх:57,
			Лево:7,
			Групповой: true,
			height: 46,width: 657,
			tabBar:{hidden:true},
			items:
			[
				{
					id: 'Страница2',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'ПолеНастройкиНоменклатура',
			width: 441,
			height: 19,
			style: 'position:absolute;left:216px;top:1px;width:441px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 72, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ПолеНастройкиНоменклатура', Граница: 'Верхняя', Номер: 71, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:441,
			Верх:1,
			Лево:216,
		},
		{
			xtype: 'combobox',
			id: 'ПолеВидаСравненияНоменклатура',
			style: 'position:absolute;left:109px;top:1px;width:102px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 73, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ПолеВидаСравненияНоменклатура', Граница: 'Верхняя', Номер: 72, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:102,
			Верх:1,
			Лево:109,
			width: 102,
			height: 19,
		},
		{
			xtype: 'checkbox',
			id: 'ФлажокНастройкиНоменклатура',
			boxLabel: 'Номенклатура',
			style: 'position:absolute;left:0px;top:1px;width:103px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ФлажокНастройкиНоменклатура', Граница: 'Левая', Номер: 73, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ФлажокНастройкиНоменклатура', Граница: 'Верхняя', Номер: 73, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:103,
			Верх:1,
			Лево:0,
		},
		{
			xtype: 'checkbox',
			id: 'ФлажокНастройкиЦеноваяГруппа',
			boxLabel: 'Ценовая группа',
			style: 'position:absolute;left:0px;top:24px;width:104px;height:20px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ФлажокНастройкиЦеноваяГруппа', Граница: 'Левая', Номер: 94, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ФлажокНастройкиЦеноваяГруппа', Граница: 'Верхняя', Номер: 94, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:20,
			Ширина:104,
			Верх:24,
			Лево:0,
		},
		{
			xtype: 'combobox',
			id: 'ПолеВидаСравненияЦеноваяГруппа',
			style: 'position:absolute;left:109px;top:24px;width:102px;height:20px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 94, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ПолеВидаСравненияЦеноваяГруппа', Граница: 'Верхняя', Номер: 95, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:20,
			Ширина:102,
			Верх:24,
			Лево:109,
			width: 102,
			height: 20,
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'ПолеНастройкиЦеноваяГруппа',
			width: 441,
			height: 20,
			style: 'position:absolute;left:216px;top:24px;width:441px;height:20px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 95, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ПолеНастройкиЦеноваяГруппа', Граница: 'Верхняя', Номер: 96, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:20,
			Ширина:441,
			Верх:24,
			Лево:216,
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'ПолеНастройкиТипЦен',
			width: 441,
			height: 19,
			style: 'position:absolute;left:223px;top:105px;width:441px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 75, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 70, Координата: 0},
					Нижняя: { Элемент: 'ПолеНастройкиТипЦен', Граница: 'Верхняя', Номер: 74, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:441,
			Верх:105,
			Лево:223,
		},
		{
			xtype: 'combobox',
			id: 'ПолеВидаСравненияТипЦен',
			style: 'position:absolute;left:116px;top:105px;width:102px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 76, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 70, Координата: 0},
					Нижняя: { Элемент: 'ПолеВидаСравненияТипЦен', Граница: 'Верхняя', Номер: 75, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:102,
			Верх:105,
			Лево:116,
			width: 102,
			height: 19,
		},
		{
			xtype: 'checkbox',
			id: 'ФлажокНастройкиТипЦен',
			boxLabel: 'Тип цен',
			style: 'position:absolute;left:7px;top:105px;width:103px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ФлажокНастройкиТипЦен', Граница: 'Левая', Номер: 76, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 70, Координата: 0},
					Нижняя: { Элемент: 'ФлажокНастройкиТипЦен', Граница: 'Верхняя', Номер: 76, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:103,
			Верх:105,
			Лево:7,
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			trigger3Cls: 'x-form-search-trigger',
			id: 'Организация',
			name: 'Организация.Представление',
			width: 365,
			height: 20,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:299px;top:33px;width:365px;height:20px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Организация', Граница: 'Верхняя', Номер: 78, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:20,
			Ширина:365,
			Верх:33,
			Лево:299,
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.ПечатьПрайсЛиста.ФормаЗаполненияСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ПечатьПрайсЛиста.ФормаЗаполненияСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.ПечатьПрайсЛиста.ФормаЗаполненияСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ПечатьПрайсЛиста.ФормаЗаполненияСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			id: 'Надпись2',
			text: 'Организация:',
			style: 'position:absolute;left:223px;top:33px;width:71px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Надпись2', Граница: 'Левая', Номер: 87, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Надпись2', Граница: 'Верхняя', Номер: 87, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:71,
			Верх:33,
			Лево:223,
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			id: 'ПолеВводаДатаНач',
			width: 102,
			height: 19,
			style: 'position:absolute;left:116px;top:33px;width:102px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ПолеВводаДатаНач', Граница: 'Левая', Номер: 92, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ПолеВводаДатаНач', Граница: 'Верхняя', Номер: 92, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:102,
			Верх:33,
			Лево:116,
		},
		{
			xtype: 'label',
			id: 'Надпись5',
			text: 'На дату:',
			style: 'position:absolute;left:7px;top:33px;width:104px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Надпись5', Граница: 'Левая', Номер: 93, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Надпись5', Граница: 'Верхняя', Номер: 93, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:104,
			Верх:33,
			Лево:7,
		},
		],
	}],
	dockedItems:
	[
	],
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
						//ПривязкаГраниц(item, item.ПозицияЭлемента);
						if (item.Групповой)
						{
							var элемент = Ext.getCmp(item.id).items.items[0].items.items;
							for (var i = 0; i < элемент.length; i++ ) 
							{
								var текЭлемент = элемент[i];
								//ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
							}
						}
					});
				}
				форма.ПервоеОткрытие = false;
			}
		}
	}
	});
});