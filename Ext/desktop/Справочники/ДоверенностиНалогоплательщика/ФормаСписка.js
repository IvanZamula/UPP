﻿Ext.require(['Данные.Справочники.ДоверенностиНалогоплательщика'], function () 
{
	Ext.define('Справочники.ДоверенностиНалогоплательщика.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:400px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Доверенности налогоплательщика',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:384px;height:259px;',
			height: 259,width: 384,
			columns:
			[
				{
					text:'',
					width:'20',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'60',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'253',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Организация',
					width:'182',
					dataIndex:'Владелец',
					flex:1,
				},
				{
					text:'Дата окончания',
					width:'90',
					dataIndex:'ДатаОкончания',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.ДоверенностиНалогоплательщика").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ДоверенностиНалогоплательщика/ВыбратьПоСсылке/100', timeout: 3},
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
						name:'Владелец',
					},
					{
						name:'ДатаОкончания',
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
						Ext.require(['Справочники.ДоверенностиНалогоплательщика.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ДоверенностиНалогоплательщика.ФормаСпискаСобытия");
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
			style: 'position:absolute;left:0px;top:0px;width:400px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
	]
	});
});