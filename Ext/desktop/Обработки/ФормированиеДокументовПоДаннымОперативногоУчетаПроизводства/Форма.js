﻿Ext.require(['Данные.Обработки.ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства'], function () 
{
	Ext.define('Обработки.ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства.Форма',
	{
	extend: 'Ext.window.Window',
	id: 'Форма',
	style: 'position:absolute;width:532px;height:292px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Формирование документов по данным оперативного учета производства',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'label',
			id: 'НадписьДата',
			text: 'по:',
			style: 'position:absolute;left:158px;top:32px;width:18px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьДата', Граница: 'Верхняя', Номер: 1, Координата: 0},
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
			Ширина:18,
			Верх:32,
			Лево:158,
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			id: 'ДатаОкончанияПериода',
			width: 80,
			height: 19,
			style: 'position:absolute;left:176px;top:32px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ДатаОкончанияПериода', Граница: 'Верхняя', Номер: 2, Координата: 0},
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
			Ширина:80,
			Верх:32,
			Лево:176,
		},
		{
			xtype: 'label',
			id: 'НадписьНастройка',
			text: 'Настройка:',
			style: 'position:absolute;left:8px;top:8px;width:68px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьНастройка', Граница: 'Левая', Номер: 3, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьНастройка', Граница: 'Верхняя', Номер: 3, Координата: 0},
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
			Ширина:68,
			Верх:8,
			Лево:8,
		},
		{
			xtype: 'label',
			id: 'НадписьГраницаНачала',
			text: 'За период с: ',
			style: 'position:absolute;left:8px;top:32px;width:68px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьГраницаНачала', Граница: 'Верхняя', Номер: 7, Координата: 0},
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
			Ширина:68,
			Верх:32,
			Лево:8,
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			id: 'ДатаНачалаПериода',
			width: 80,
			height: 19,
			style: 'position:absolute;left:76px;top:32px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ДатаНачалаПериода', Граница: 'Верхняя', Номер: 8, Координата: 0},
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
			Ширина:80,
			Верх:32,
			Лево:76,
		},
		{
			xtype: 'panel',
			id: 'Панель',
			style: 'position:absolute;left:8px;top:59px;width:516px;height:200px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:200,
			Ширина:516,
			Верх:59,
			Лево:8,
			Групповой: true,
			height: 200,width: 516,
			items:
			[
				{
					id: 'СформированныеДокументы',
					items:
					[
		{
			id: 'СформированныеДокументы',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:502px;height:144px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:144,
			Ширина:502,
			Верх:30,
			Лево:6,
			height: 144,width: 502,
			columns:
			[
				{
					text:'N',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'',
					width:'21',
					dataIndex:'Флаг',
					flex:1,
				},
				{
					text:'',
					width:'32',
					dataIndex:'Статус',
					flex:1,
				},
				{
					text:'Дата',
					width:'120',
					dataIndex:'Дата',
					flex:1,
				},
				{
					text:'Номер',
					width:'80',
					dataIndex:'Номер',
					flex:1,
				},
				{
					text:'Документ',
					width:'120',
					dataIndex:'Документ',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'НомерСтроки',
					},
					{
						name:'Флаг',
					},
					{
						name:'Статус',
					},
					{
						name:'Дата',
					},
					{
						name:'Номер',
					},
					{
						name:'Документ',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('СформированныеДокументы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства.ФормаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанельСформированныеДокументы',
			style: 'position:absolute;left:6px;top:6px;width:502px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельСформированныеДокументы', Граница: 'Верхняя', Номер: 20, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:502,
			Верх:6,
			Лево:6,
			width: 502,
			height: 24,
			items:
			[
				{
					id:'УстановитьФлажки',
					text:'Установить пометки на все строки',
					tooltip:'Установить пометки на все строки',
				},
				{
					id:'СнятьФлажки',
					text:'Убрать пометки всех строк',
					tooltip:'Убрать пометки всех строк',
				},
				'-',
				{
					id:'Провести',
					text:'Провести документы',
					tooltip:'Провести документы',
				},
				{
					id:'УстановитьПометкуУдаления',
					text:'Установить/снять пометку удаления',
					tooltip:'Установить/снять пометку удаления',
				},
				'-',
				{
					id:'Печать',
					text:'Печать',
					tooltip:'Печать документов',
				},
				'-',
				{
					id:'Обновить',
					text:'Обновить',
					tooltip:'Обновить',
				},
				'-',
				{
					xtype: 'splitbutton',
					id:'ПодменюПерейти',
					text:'Перейти',
					menu: [
				{
					text:'Движения документа по регистрам',
					tooltip:'',
				},
				{
					text:'Структура подчиненности документа',
					tooltip:'',
				},
				'-',
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанельКонтекстноеМенюСформированныеДокументы',
			style: 'position:absolute;left:20px;top:80px;width:436px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельКонтекстноеМенюСформированныеДокументы', Граница: 'Верхняя', Номер: 25, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:436,
			Верх:80,
			Лево:20,
			width: 436,
			height: 24,
			items:
			[
				{
					id:'УстановитьФлажки',
					text:'Установить пометки на все строки',
					tooltip:'Установить пометки на все строки',
				},
				{
					id:'СнятьФлажки',
					text:'Убрать пометки всех строк',
					tooltip:'Убрать пометки всех строк',
				},
				'-',
				{
					id:'Провести',
					text:'Провести документы',
					tooltip:'Провести документы',
				},
				{
					id:'УстановитьПометкуУдаления',
					text:'Установить/снять пометку удаления',
					tooltip:'Установить/снять пометку удаления',
				},
				'-',
				{
					id:'Печать',
					text:'Печать',
					tooltip:'Печать документов',
				},
				'-',
				{
					id:'Обновить',
					text:'Обновить',
					tooltip:'Обновить',
				},
				'-',
				{
					id:'Действие2',
					text:'&Переместить вверх',
					tooltip:'',
				},
				{
					id:'Действие3',
					text:'&Переместить вниз',
					tooltip:'',
				},
				{
					id:'Действие4',
					text:'Сортировать по возрастанию',
					tooltip:'Открыть конструктор настроек',
				},
				{
					id:'Действие5',
					text:'Сортировать по убыванию',
					tooltip:'',
				},
				'-',
				{
					id:'Действие6',
					text:'Установить отбор и сортировку списка...',
					tooltip:'Отбор и сортировка',
					iconCls:'x-FilterAndSort',
				},
				{
					id:'Действие',
					text:'Отбор по значению в текущей колонке',
					tooltip:'Отбор по значению в текущей колонке',
					iconCls:'x-FilterByCurrentValue',
				},
				{
					id:'Действие1',
					text:'Отключить отбор',
					tooltip:'Отключить отбор',
					iconCls:'x-ClearFilter',
				},
				'-',
				{
					id:'Действие7',
					text:'Настройка списка...',
					tooltip:'Настройка списка',
					iconCls:'x-ListSettings',
				},
				{
					id:'Действие8',
					text:'Вывести список...',
					tooltip:'Вывести список',
					iconCls:'x-OutputList',
				},
			]
		},
					]
				},
				{
					id: 'УчтенныеДокументы',
					items:
					[
		{
			id: 'УчтенныеДокументы',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:502px;height:144px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:144,
			Ширина:502,
			Верх:30,
			Лево:6,
			height: 144,width: 502,
			columns:
			[
				{
					text:'N',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'',
					width:'21',
					dataIndex:'Флаг',
					flex:1,
				},
				{
					text:'',
					width:'32',
					dataIndex:'Статус',
					flex:1,
				},
				{
					text:'Дата',
					width:'120',
					dataIndex:'Дата',
					flex:1,
				},
				{
					text:'Номер',
					width:'80',
					dataIndex:'Номер',
					flex:1,
				},
				{
					text:'Документ',
					width:'120',
					dataIndex:'Документ',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'НомерСтроки',
					},
					{
						name:'Флаг',
					},
					{
						name:'Статус',
					},
					{
						name:'Дата',
					},
					{
						name:'Номер',
					},
					{
						name:'Документ',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('УчтенныеДокументы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ФормированиеДокументовПоДаннымОперативногоУчетаПроизводства.ФормаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанельУчтенныеДокументы',
			style: 'position:absolute;left:6px;top:6px;width:502px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельУчтенныеДокументы', Граница: 'Верхняя', Номер: 21, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:502,
			Верх:6,
			Лево:6,
			width: 502,
			height: 24,
			items:
			[
				{
					id:'УстановитьФлажки',
					text:'Установить пометки на все строки',
					tooltip:'Установить пометки на все строки',
				},
				{
					id:'СнятьФлажки',
					text:'Убрать пометки всех строк',
					tooltip:'Убрать пометки всех строк',
				},
				'-',
				{
					id:'Провести',
					text:'Провести документы',
					tooltip:'0ebc47b-f4d9-439c-acd3-fdc624fbac2',
					iconCls:'x-Post',
				},
				{
					id:'УстановитьПометкуУдаления',
					text:'Установить/снять пометку удаления',
					tooltip:'Установить/снять пометку удаления',
				},
				'-',
				{
					id:'Печать',
					text:'Печать',
					tooltip:'Печать документов',
				},
				'-',
				{
					id:'Обновить',
					text:'Обновить',
					tooltip:'Обновить',
				},
			]
		},
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанельКонтекстноеМенюУчтенныеДокументы',
			style: 'position:absolute;left:20px;top:80px;width:436px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельКонтекстноеМенюУчтенныеДокументы', Граница: 'Верхняя', Номер: 27, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:436,
			Верх:80,
			Лево:20,
			width: 436,
			height: 24,
			items:
			[
				{
					id:'УстановитьФлажки',
					text:'Установить пометки на все строки',
					tooltip:'Установить пометки на все строки',
				},
				{
					id:'СнятьФлажки',
					text:'Убрать пометки всех строк',
					tooltip:'Убрать пометки всех строк',
				},
				'-',
				{
					id:'Провести',
					text:'Провести документы',
					tooltip:'Провести документы',
				},
				{
					id:'УстановитьПометкуУдаления',
					text:'Установить/снять пометку удаления',
					tooltip:'Установить/снять пометку удаления',
				},
				'-',
				{
					id:'Печать',
					text:'Печать',
					tooltip:'Печать документов',
				},
				'-',
				{
					id:'Обновить',
					text:'Обновить',
					tooltip:'Обновить',
				},
				'-',
				{
					id:'Действие2',
					text:'&Переместить вверх',
					tooltip:'',
				},
				{
					id:'Действие3',
					text:'&Переместить вниз',
					tooltip:'',
				},
				{
					id:'Действие4',
					text:'Сортировать по возрастанию',
					tooltip:'Открыть конструктор настроек',
				},
				{
					id:'Действие5',
					text:'Сортировать по убыванию',
					tooltip:'',
				},
				'-',
				{
					id:'Действие6',
					text:'Установить отбор и сортировку списка...',
					tooltip:'Отбор и сортировка',
					iconCls:'x-FilterAndSort',
				},
				{
					id:'Действие',
					text:'Отбор по значению в текущей колонке',
					tooltip:'Отбор по значению в текущей колонке',
					iconCls:'x-FilterByCurrentValue',
				},
				{
					id:'Действие1',
					text:'Отключить отбор',
					tooltip:'Отключить отбор',
					iconCls:'x-ClearFilter',
				},
				'-',
				{
					id:'Действие7',
					text:'Настройка списка...',
					tooltip:'Настройка списка',
					iconCls:'x-ListSettings',
				},
				{
					id:'Действие8',
					text:'Вывести список...',
					tooltip:'Вывести список',
					iconCls:'x-OutputList',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'Настройка',
			width: 448,
			height: 19,
			style: 'position:absolute;left:76px;top:8px;width:448px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Настройка', Граница: 'Верхняя', Номер: 15, Координата: 0},
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
			Ширина:448,
			Верх:8,
			Лево:76,
		},
		{
			xtype: 'button',
			id: 'КнопкаВыбораПериода',
			text: '...',
			style: 'position:absolute;left:258px;top:32px;width:19px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'КнопкаВыбораПериода', Граница: 'Левая', Номер: 28, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КнопкаВыбораПериода', Граница: 'Верхняя', Номер: 28, Координата: 0},
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
			Ширина:19,
			Верх:32,
			Лево:258,
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			id: 'ОсновныеДействияФормы',
			style: 'position:absolute;left:0px;top:267px;width:532px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'ОсновныеДействияФормы', Граница: 'Нижняя', Номер: 6, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
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
			Ширина:532,
			Верх:267,
			Лево:0,
			width: 532,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'СформироватьДокументы',
					text:'Сформировать документы',
					tooltip:'Сформировать документы',
				},
				'-',
				{
					id:'ОсновныеДействияФормыЗакрыть',
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
					handler: function () {this.up('window').close();},
				},
				'-',
				{
					id:'Действие5',
					text:'Справка',
					tooltip:'Открыть справку',
				},
			]
		},
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