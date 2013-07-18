﻿Ext.require(['Данные.Документы.ЗаказНаОбслуживаниеОС'], function () 
{
	Ext.define('Документы.ЗаказНаОбслуживаниеОС.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:780px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Заказы на обслуживание ОС',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'Список',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:380px;',
			height: 380,width: 764,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Дата',
					width:'132',
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
					text:'Услуга',
					width:'120',
					dataIndex:'Услуга',
					flex:1,
				},
				{
					text:'Причина заказа на обслуживание',
					width:'120',
					dataIndex:'ПричинаЗаказаНаОбслуживаниеОС',
					flex:1,
				},
				{
					text:'Дата обслуживания',
					width:'80',
					dataIndex:'ДатаОбслуживанияОС',
					flex:1,
				},
				{
					text:'Вид обслуживания',
					width:'120',
					dataIndex:'ВидОбслуживанияОС',
					flex:1,
				},
				{
					text:'Ответственный',
					width:'120',
					dataIndex:'Ответственный',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЗаказНаОбслуживаниеОС/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
					{
						name:'Картинка',
					},
					{
						name:'Дата',
					},
					{
						name:'Номер',
					},
					{
						name:'Услуга',
					},
					{
						name:'ПричинаЗаказаНаОбслуживаниеОС',
					},
					{
						name:'ДатаОбслуживанияОС',
					},
					{
						name:'ВидОбслуживанияОС',
					},
					{
						name:'Ответственный',
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
						Ext.require(['Справочники.ЗаказНаОбслуживаниеОС.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ЗаказНаОбслуживаниеОС.ФормаСпискаСобытия");
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
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			dock: 'top',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Структура подчиненности документа',
				},
				'-',
					]
				},
			]
		},
	]
	});
});