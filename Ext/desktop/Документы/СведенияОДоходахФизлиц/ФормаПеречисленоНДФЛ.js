﻿Ext.require(['Данные.Документы.СведенияОДоходахФизлиц'], function () 
{
	Ext.define('Документы.СведенияОДоходахФизлиц.ФормаПеречисленоНДФЛ',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:619px;height:347px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочно',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'fieldset',
			title: 'Всего за налоговый период',
			style: 'position:absolute;left:12px;top:172px;width:599px;height:16px;',
		},
		{
			xtype: 'fieldset',
			title: 'Удержано и перечислено по физическим лицам',
			style: 'position:absolute;left:12px;top:8px;width:599px;height:16px;',
		},
		{
			id: 'ПеречисленоНДФЛПоФизлицам',
			xtype: 'grid',
			style: 'position:absolute;left:12px;top:26px;width:599px;height:140px;',
			height: 140,width: 599,
			columns:
			[
				{
					text:'№',
					width:'25',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Физ лицо',
					width:'103',
					dataIndex:'ФизЛицо',
					flex:1,
				},
				{
					text:'Ставка',
					width:'50',
					dataIndex:'Ставка',
					flex:1,
				},
				{
					text:'КБК',
					width:'73',
					dataIndex:'КБК',
					flex:1,
				},
				{
					text:'Код по ОКАТО',
					width:'84',
					dataIndex:'КодПоОКАТО',
					flex:1,
				},
				{
					text:'Перечислено',
					width:'100',
					dataIndex:'Перечислено',
					flex:1,
				},
				{
					text:'Удержано (справочно)',
					width:'87',
					dataIndex:'Удержано',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СведенияОДоходахФизлиц/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'ФизЛицо',
					},
					{
						name:'Ставка',
					},
					{
						name:'КБК',
					},
					{
						name:'КодПоОКАТО',
					},
					{
						name:'Перечислено',
					},
					{
						name:'Удержано',
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
						var грид = Ext.getCmp('ПеречисленоНДФЛПоФизлицам');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СведенияОДоходахФизлиц.ФормаПеречисленоНДФЛСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СведенияОДоходахФизлиц.ФормаПеречисленоНДФЛСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			id: 'ПеречисленоНДФЛВсего',
			xtype: 'grid',
			style: 'position:absolute;left:12px;top:190px;width:599px;height:149px;',
			height: 149,width: 599,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Ставка',
					width:'100',
					dataIndex:'Ставка',
					flex:1,
				},
				{
					text:'КБК',
					width:'100',
					dataIndex:'КБК',
					flex:1,
				},
				{
					text:'Код по ОКАТО',
					width:'122',
					dataIndex:'КодПоОКАТО',
					flex:1,
				},
				{
					text:'Перечислено',
					width:'106',
					dataIndex:'Перечислено',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СведенияОДоходахФизлиц/ВыбратьПоСсылке/100', timeout: 3},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'Ставка',
					},
					{
						name:'КБК',
					},
					{
						name:'КодПоОКАТО',
					},
					{
						name:'Перечислено',
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
						var грид = Ext.getCmp('ПеречисленоНДФЛВсего');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СведенияОДоходахФизлиц.ФормаПеречисленоНДФЛСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СведенияОДоходахФизлиц.ФормаПеречисленоНДФЛСобытия");
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
	]
	});
});