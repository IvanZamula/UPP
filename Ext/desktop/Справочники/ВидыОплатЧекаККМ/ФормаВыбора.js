﻿Ext.require(['Данные.Справочники.ВидыОплатЧекаККМ'], function () 
{
	Ext.define('Справочники.ВидыОплатЧекаККМ.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:594px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Виды оплат чека ККМ',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:174px;top:33px;width:412px;height:280px;',
			height: 280,width: 412,
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
					width:'40',
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
					text:'Тип оплаты',
					width:'100',
					dataIndex:'ТипОплаты',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.ВидыОплатЧекаККМ").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ВидыОплатЧекаККМ/ВыбратьПоСсылке/100', timeout: 3},
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
						name:'ТипОплаты',
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
						Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаВыбораСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			id: 'СправочникДерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:160px;height:280px;',
			height: 280,width: 160,
			columns:
			[
				{
					text:'Наименование',
					width:'137',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.ВидыОплатЧекаККМ").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ВидыОплатЧекаККМ/ВыбратьПоСсылке/100', timeout: 3},
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
						Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаВыбораСобытия");
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
			style: 'position:absolute;left:0px;top:0px;width:594px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
			]
		},
	]
	});
});