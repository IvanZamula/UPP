﻿Ext.require(['Данные.Справочники.СтатьиЗатрат'], function () 
{
	Ext.define('Справочники.СтатьиЗатрат.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:708px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Статьи затрат',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:182px;top:33px;width:518px;height:280px;',
			height: 280,width: 518,
			columns:
			[
				{
					text:'',
					width:'33',
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
					width:'173',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Вид затрат',
					width:'100',
					dataIndex:'ВидЗатрат',
					flex:1,
				},
				{
					text:'Статус мат. затрат',
					width:'116',
					dataIndex:'СтатусМатериальныхЗатрат',
					flex:1,
				},
				{
					text:'Характер затрат',
					width:'126',
					dataIndex:'ХарактерЗатрат',
					flex:1,
				},
				{
					text:'Вид расходов (НУ)',
					width:'140',
					dataIndex:'ВидЗатратНалоговогоУчета',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.СтатьиЗатрат").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СтатьиЗатрат/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
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
						name:'ВидЗатрат',
					},
					{
						name:'СтатусМатериальныхЗатрат',
					},
					{
						name:'ХарактерЗатрат',
					},
					{
						name:'ВидЗатратНалоговогоУчета',
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
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СтатьиЗатрат.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СтатьиЗатрат.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			id: 'СправочникДерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:167px;height:280px;',
			height: 280,width: 167,
			columns:
			[
				{
					text:'Наименование',
					width:'350',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.СтатьиЗатрат").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СтатьиЗатрат/ВыбратьПоСсылке/100', timeout: 3},
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
						var грид = Ext.getCmp('СправочникДерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СтатьиЗатрат.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СтатьиЗатрат.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:708px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
	]
	});
});