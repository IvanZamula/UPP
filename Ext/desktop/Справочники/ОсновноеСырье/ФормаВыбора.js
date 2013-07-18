﻿Ext.require(['Данные.Справочники.ОсновноеСырье'], function () 
{
	Ext.define('Справочники.ОсновноеСырье.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:336px;height:447px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Основное сырье',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:320px;height:220px;',
			height: 220,width: 320,
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
			],
			store:
			{
				data: Ext.create("Данные.Справочники.ОсновноеСырье").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОсновноеСырье/ВыбратьПоСсылке/100', timeout: 3},
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
						Ext.require(['Справочники.ОсновноеСырье.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОсновноеСырье.ФормаВыбораСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			id: 'Состав',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:259px;width:320px;height:180px;',
			height: 180,width: 320,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Основной материал и его аналоги',
					width:'220',
					dataIndex:'Номенклатура',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.ОсновноеСырье").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОсновноеСырье/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'Номенклатура',
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
						var грид = Ext.getCmp('Состав');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ОсновноеСырье.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОсновноеСырье.ФормаВыбораСобытия");
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
			style: 'position:absolute;left:0px;top:0px;width:336px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
	]
	});
});