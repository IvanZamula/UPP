﻿Ext.require(['Данные.Справочники.ТарифыБанковНаДенежныеПереводы'], function () 
{
	Ext.define('Справочники.ТарифыБанковНаДенежныеПереводы.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:400px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Тарифы банков на денежные переводы',
	
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
					width:'24',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'63',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'150',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Процент',
					width:'56',
					dataIndex:'Процент',
					flex:1,
				},
				{
					text:'Минимальный тариф',
					width:'126',
					dataIndex:'МинимальныйТариф',
					flex:1,
				},
				{
					text:'Максимальный тариф',
					width:'126',
					dataIndex:'МаксимальныйТариф',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Данные.Справочники.ТарифыБанковНаДенежныеПереводы").data,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоСсылке/100', timeout: 3},
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
						name:'Процент',
					},
					{
						name:'МинимальныйТариф',
					},
					{
						name:'МаксимальныйТариф',
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
						Ext.require(['Справочники.ТарифыБанковНаДенежныеПереводы.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТарифыБанковНаДенежныеПереводы.ФормаСпискаСобытия");
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