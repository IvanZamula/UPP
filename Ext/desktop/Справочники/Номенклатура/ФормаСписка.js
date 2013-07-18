﻿Ext.require(['Данные.Справочники.Номенклатура'], function () 
{
	Ext.define('Справочники.Номенклатура.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:793px;height:345px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Номенклатура',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'Список',
			xtype: 'grid',
			style: 'position:absolute;left:175px;top:57px;width:611px;height:130px;',
			height: 130,width: 611,
			columns:
			[
				{
					text:'',
					width:'39',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'40',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Артикул',
					width:'92',
					dataIndex:'Артикул',
					flex:1,
				},
				{
					text:'Наименование',
					width:'183',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Полное наименование',
					width:'184',
					dataIndex:'НаименованиеПолное',
					flex:1,
				},
				{
					text:'Вид номенклатуры',
					width:'110',
					dataIndex:'ВидНоменклатуры',
					flex:1,
				},
				{
					text:'Базовая единица измерения',
					width:'163',
					dataIndex:'БазоваяЕдиницаИзмерения',
					flex:1,
				},
				{
					text:'Единица хранения остатков',
					width:'167',
					dataIndex:'ЕдиницаХраненияОстатков',
					flex:1,
				},
				{
					text:'Номер ГТД',
					width:'220',
					dataIndex:'НомерГТД',
					flex:1,
				},
				{
					text:'Страна происхождения',
					width:'220',
					dataIndex:'СтранаПроисхождения',
					flex:1,
				},
				{
					text:'Ставка НДС',
					width:'100',
					dataIndex:'СтавкаНДС',
					flex:1,
				},
				{
					text:'Номенклатурная группа',
					width:'220',
					dataIndex:'НоменклатурнаяГруппа',
					flex:1,
				},
				{
					text:'Ценовая группа',
					width:'220',
					dataIndex:'ЦеноваяГруппа',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'220',
					dataIndex:'Комментарий',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.Номенклатура").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
					{
						name:'Картинка',
					},
					{
						name:'Код',
					},
					{
						name:'Артикул',
					},
					{
						name:'Наименование',
					},
					{
						name:'НаименованиеПолное',
					},
					{
						name:'ВидНоменклатуры',
					},
					{
						name:'БазоваяЕдиницаИзмерения',
					},
					{
						name:'ЕдиницаХраненияОстатков',
					},
					{
						name:'НомерГТД',
					},
					{
						name:'СтранаПроисхождения',
					},
					{
						name:'СтавкаНДС',
					},
					{
						name:'НоменклатурнаяГруппа',
					},
					{
						name:'ЦеноваяГруппа',
					},
					{
						name:'Комментарий',
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
						var грид = Ext.getCmp('Список');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.Номенклатура.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Номенклатура.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			id: 'Дерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:160px;height:130px;',
			height: 130,width: 160,
			columns:
			[
				{
					text:'Наименование',
					width:'80',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.Номенклатура").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
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
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.Номенклатура.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Номенклатура.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:793px;height:25px;',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				'-',
				{
					text:'Файлы',
				},
				{
					text:'Изображение',
				},
				{
					text:'Остатки товаров на складах',
				},
				'-',
					]
				},
				'-',
				{
					text:'Поиск по штрихкоду',
				},
				'-',
				{
					text:'Свойства',
				},
				{
					text:'Категории',
				},
				'-',
				'-',
				'-',
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:194px;width:160px;height:144px;',
			height: 144,width: 160,
			tabBar:{hidden:true},
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
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:175px;top:194px;width:611px;height:144px;',
			height: 144,width: 611,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			id: 'ТабличноеПолеОстаткиТоваров',
			xtype: 'grid',
			style: 'position:absolute;left:149px;top:20px;width:462px;height:101px;',
			height: 101,width: 462,
			columns:
			[
				{
					text:'Характеристика/Склад',
					width:'151',
					dataIndex:'ХарактеристикаСклад',
					flex:1,
				},
				{
					text:'Ячейка склада',
					width:'87',
					dataIndex:'МестоХранения',
					flex:1,
				},
				{
					text:'Общий',
					width:'60',
					dataIndex:'Общий',
					flex:1,
				},
				{
					text:'Свободный',
					width:'71',
					dataIndex:'Свободный',
					flex:1,
				},
				{
					text:'Своб.ожид.',
					width:'67',
					dataIndex:'СвободныйОжидаемый',
					flex:1,
				},
				{
					text:'В резерве',
					width:'74',
					dataIndex:'ВРезерве',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.Номенклатура").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
					{
						name:'ХарактеристикаСклад',
					},
					{
						name:'МестоХранения',
					},
					{
						name:'Общий',
					},
					{
						name:'Свободный',
					},
					{
						name:'СвободныйОжидаемый',
					},
					{
						name:'ВРезерве',
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
						var грид = Ext.getCmp('ТабличноеПолеОстаткиТоваров');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.Номенклатура.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Номенклатура.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'fieldset',
			title: 'Остатки товаров на складах',
			style: 'position:absolute;left:0px;top:0px;width:611px;height:16px;',
		},
		{
			id: 'СписокЦенОстатков',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:20px;width:143px;height:124px;',
			height: 124,width: 143,
			columns:
			[
				{
					text:'Типы цен',
					width:'132',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Ссылка',
					width:'81',
					dataIndex:'Ссылка',
					flex:1,
				},
				{
					text:'БазовыйТипЦен',
					width:'100',
					dataIndex:'БазовыйТипЦен',
					flex:1,
				},
				{
					text:'Рассчитывается',
					width:'100',
					dataIndex:'Рассчитывается',
					flex:1,
				},
				{
					text:'ОкруглятьВБольшуюСторону',
					width:'100',
					dataIndex:'ОкруглятьВБольшуюСторону',
					flex:1,
				},
				{
					text:'ПроцентСкидкиНаценки',
					width:'100',
					dataIndex:'ПроцентСкидкиНаценки',
					flex:1,
				},
				{
					text:'Префикс',
					width:'100',
					dataIndex:'Префикс',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.Номенклатура").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
					{
						name:'Наименование',
					},
					{
						name:'Ссылка',
					},
					{
						name:'БазовыйТипЦен',
					},
					{
						name:'Рассчитывается',
					},
					{
						name:'ОкруглятьВБольшуюСторону',
					},
					{
						name:'ПроцентСкидкиНаценки',
					},
					{
						name:'Префикс',
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
						var грид = Ext.getCmp('СписокЦенОстатков');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.Номенклатура.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Номенклатура.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'ВалютаЦены',
			width: 135,
			height: 19,
			style: 'position:absolute;left:476px;top:125px;width:135px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалютаЦены',
			text: 'Валюта:',
			style: 'position:absolute;left:427px;top:125px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипРасчета',
			text: 'Валюта цены:',
			style: 'position:absolute;left:150px;top:125px;width:73px;height:19px;text-align:left;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:225px;top:125px;width:195px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораСпискаНоменклатуры',
			width: 552,
			height: 19,
			style: 'position:absolute;left:234px;top:33px;width:552px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьЗначениеОтбораСпискаНоменклатуры',
			text: 'содержит:',
			style: 'position:absolute;left:175px;top:33px;width:57px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:8px;top:33px;width:160px;height:19px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:357px;top:95px;width:157px;height:24px;',
			dock: 'top',
			items:
			[
				{
					text:'Пометить все типы цен',
				},
				{
					text:'Отменить пометку всех типов цен',
				},
				{
					text:'Обновить',
				},
				'-',
				{
					text:'&Переместить вверх',
				},
				{
					text:'Переместить вниз',
				},
			]
		},
	]
	});
});