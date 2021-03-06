﻿Ext.require(['Данные.Справочники.РасходыБудущихПериодов'], function () 
{
	Ext.define('Справочники.РасходыБудущихПериодов.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаСписка',
	style: 'position:absolute;width:780px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Расходы будущих периодов',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:195px;top:33px;width:577px;height:380px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 4, Координата: 0},
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
			Высота:380,
			Ширина:577,
			Верх:33,
			Лево:195,
			height: 380,width: 577,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'72',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'220',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Вид РБП',
					width:'220',
					dataIndex:'ВидРБП.Представление',
					flex:1,
				},
				{
					text:'Способ признания расходов',
					width:'100',
					dataIndex:'СпособПризнанияРасходов.Представление',
					flex:1,
				},
				{
					text:'Сумма',
					width:'80',
					dataIndex:'Сумма',
					flex:1,
				},
				{
					text:'Начало списания',
					width:'80',
					dataIndex:'ДатаНачалаСписания',
					flex:1,
				},
				{
					text:'Окончание списания',
					width:'80',
					dataIndex:'ДатаОкончанияСписания',
					flex:1,
				},
				{
					text:'Подразделение',
					width:'120',
					dataIndex:'Подразделение.Представление',
					flex:1,
				},
				{
					text:'Подразделение (орг.)',
					width:'120',
					dataIndex:'ПодразделениеОрганизации.Представление',
					flex:1,
				},
				{
					text:'Статья затрат',
					width:'120',
					dataIndex:'СтатьяЗатрат.Представление',
					flex:1,
				},
				{
					text:'Счет',
					width:'80',
					dataIndex:'СчетБУ.Представление',
					flex:1,
				},
				{
					text:'Счет (НУ)',
					width:'80',
					dataIndex:'СчетНУ.Представление',
					flex:1,
				},
				{
					text:'Хар-р затрат',
					width:'120',
					dataIndex:'ХарактерЗатрат',
					flex:1,
				},
				{
					text:'Вид аналитики',
					width:'284',
					dataIndex:'ВидАналитики',
					flex:1,
				},
				{
					text:'Вид аналитики (доп.)',
					width:'284',
					dataIndex:'ВидАналитикиДоп',
					flex:1,
				},
				{
					text:'Вид субконто 1',
					width:'94',
					dataIndex:'ВидСубконто1',
					flex:1,
				},
				{
					text:'Вид субконто 2',
					width:'94',
					dataIndex:'ВидСубконто2',
					flex:1,
				},
				{
					text:'Вид субконто 3',
					width:'94',
					dataIndex:'ВидСубконто3',
					flex:1,
				},
				{
					text:'Вид субконто 1 (НУ)',
					width:'78',
					dataIndex:'ВидСубконтоНУ1',
					flex:1,
				},
				{
					text:'Вид субконто 2 (НУ)',
					width:'78',
					dataIndex:'ВидСубконтоНУ2',
					flex:1,
				},
				{
					text:'Вид субконто 3 (НУ)',
					width:'78',
					dataIndex:'ВидСубконтоНУ3',
					flex:1,
				},
				{
					text:'Аналитика',
					width:'129',
					dataIndex:'Аналитика',
					flex:1,
				},
				{
					text:'Номенклатурная группа',
					width:'202',
					dataIndex:'НоменклатурнаяГруппа.Представление',
					flex:1,
				},
				{
					text:'Номенклатурная группа (доп)',
					width:'155',
					dataIndex:'НоменклатурнаяГруппаДоп',
					flex:1,
				},
				{
					text:'Способ распределения затрат на выпуск',
					width:'165',
					dataIndex:'СпособРаспределенияЗатратНаВыпуск.Представление',
					flex:1,
				},
				{
					text:'Субконто 1',
					width:'101',
					dataIndex:'Субконто1',
					flex:1,
				},
				{
					text:'Субконто 2',
					width:'108',
					dataIndex:'Субконто2',
					flex:1,
				},
				{
					text:'Субконто 3',
					width:'124',
					dataIndex:'Субконто3',
					flex:1,
				},
				{
					text:'Субконто 1 (НУ)',
					width:'101',
					dataIndex:'СубконтоНУ1.Представление',
					flex:1,
				},
				{
					text:'Субконто 2 (НУ)',
					width:'108',
					dataIndex:'СубконтоНУ2.Представление',
					flex:1,
				},
				{
					text:'Субконто 3 (НУ)',
					width:'123',
					dataIndex:'СубконтоНУ3.Представление',
					flex:1,
				},
				{
					text:'Продукция',
					width:'102',
					dataIndex:'Продукция.Представление',
					flex:1,
				},
				{
					text:'Характеристика продукции',
					width:'108',
					dataIndex:'ХарактеристикаПродукции.Представление',
					flex:1,
				},
				{
					text:'Серия продукции',
					width:'123',
					dataIndex:'СерияПродукции.Представление',
					flex:1,
				},
				{
					text:'Объект строительства',
					width:'111',
					dataIndex:'ОбъектСтроительства.Представление',
					flex:1,
				},
				{
					text:'Способ строительства',
					width:'129',
					dataIndex:'СпособСтроительства.Представление',
					flex:1,
				},
				{
					text:'Вид актива',
					width:'100',
					dataIndex:'ВидАктива.Представление',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.РасходыБудущихПериодов").data,
					fields: ['Ссылка','Родитель.Представление','Картинка','Код','Наименование','ВидРБП.Представление','СпособПризнанияРасходов.Представление','Сумма','ДатаНачалаСписания','ДатаОкончанияСписания','Подразделение.Представление','ПодразделениеОрганизации.Представление','СтатьяЗатрат.Представление','СчетБУ.Представление','СчетНУ.Представление','ХарактерЗатрат','ВидАналитики','ВидАналитикиДоп','ВидСубконто1','ВидСубконто2','ВидСубконто3','ВидСубконтоНУ1','ВидСубконтоНУ2','ВидСубконтоНУ3','Аналитика','НоменклатурнаяГруппа.Представление','НоменклатурнаяГруппаДоп','СпособРаспределенияЗатратНаВыпуск.Представление','Субконто1','Субконто2','Субконто3','СубконтоНУ1.Представление','СубконтоНУ2.Представление','СубконтоНУ3.Представление','Продукция.Представление','ХарактеристикаПродукции.Представление','СерияПродукции.Представление','ОбъектСтроительства.Представление','СпособСтроительства.Представление','ВидАктива.Представление',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/РасходыБудущихПериодов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Код',
					},
					{
						name:'Наименование',
					},
					{
						name:'ВидРБП',
					},
					{
						name:'СпособПризнанияРасходов',
					},
					{
						name:'Сумма',
					},
					{
						name:'ДатаНачалаСписания',
					},
					{
						name:'ДатаОкончанияСписания',
					},
					{
						name:'Подразделение',
					},
					{
						name:'ПодразделениеОрганизации',
					},
					{
						name:'СтатьяЗатрат',
					},
					{
						name:'СчетБУ',
					},
					{
						name:'СчетНУ',
					},
					{
						name:'ХарактерЗатрат',
					},
					{
						name:'ВидАналитики',
					},
					{
						name:'ВидАналитикиДоп',
					},
					{
						name:'ВидСубконто1',
					},
					{
						name:'ВидСубконто2',
					},
					{
						name:'ВидСубконто3',
					},
					{
						name:'ВидСубконтоНУ1',
					},
					{
						name:'ВидСубконтоНУ2',
					},
					{
						name:'ВидСубконтоНУ3',
					},
					{
						name:'Аналитика',
					},
					{
						name:'НоменклатурнаяГруппа',
					},
					{
						name:'НоменклатурнаяГруппаДоп',
					},
					{
						name:'СпособРаспределенияЗатратНаВыпуск',
					},
					{
						name:'Субконто1',
					},
					{
						name:'Субконто2',
					},
					{
						name:'Субконто3',
					},
					{
						name:'СубконтоНУ1',
					},
					{
						name:'СубконтоНУ2',
					},
					{
						name:'СубконтоНУ3',
					},
					{
						name:'Продукция',
					},
					{
						name:'ХарактеристикаПродукции',
					},
					{
						name:'СерияПродукции',
					},
					{
						name:'ОбъектСтроительства',
					},
					{
						name:'СпособСтроительства',
					},
					{
						name:'ВидАктива',
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
						var грид = Ext.getCmp('СправочникСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.РасходыБудущихПериодов.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.РасходыБудущихПериодов.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: 'ДействияФормы',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ДействияФормы', Граница: 'Верхняя', Номер: 2, Координата: 0},
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
			Ширина:780,
			Верх:0,
			Лево:0,
			width: 780,
			height: 25,
			items:
			[
				{
					id:'',
					text:'',
					tooltip:'Добавить',
					iconCls:'x-copy',
				},
				{
					id:'',
					text:'',
					tooltip:'Новая группа',
					iconCls:'x-CreateFolder',
				},
				{
					id:'',
					text:'',
					tooltip:'Скопировать',
					iconCls:'x-copy',
				},
				{
					id:'',
					text:'',
					tooltip:'Изменить',
					iconCls:'x-Change',
				},
				{
					id:'',
					text:'',
					tooltip:'Установить пометку удаления',
					iconCls:'x-Delete',
				},
			]
		},
		{
			id: 'Дерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:174px;height:380px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 4, Координата: 0},
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
			Высота:380,
			Ширина:174,
			Верх:33,
			Лево:8,
			height: 380,width: 174,
			columns:
			[
				{
					text:'Код',
					width:'88',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'361',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.РасходыБудущихПериодов").data,
					fields: ['Ссылка','Родитель.Представление','Код','Наименование',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/РасходыБудущихПериодов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Код',
					},
					{
						name:'Наименование',
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
						var грид = Ext.getCmp('Дерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.РасходыБудущихПериодов.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.РасходыБудущихПериодов.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
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