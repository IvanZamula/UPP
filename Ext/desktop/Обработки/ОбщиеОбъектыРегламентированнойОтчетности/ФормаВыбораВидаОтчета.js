﻿Ext.define('Обработки.ОбщиеОбъектыРегламентированнойОтчетности.ФормаВыбораВидаОтчета',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:537px;height:406px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Выберите вид отчета',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:521px;height:283px;',
			height: 283,width: 521,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Наименование',
					width:'120',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:537px;height:25px;',
			items:
			[
				{
					text:'',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие7',
				},
				{
					text:'Подробнее об отчете',
				},
				'-',
				{
					text:'',
				},
				'-',
				'-',
				{
					text:'Действия формы выбрать',
				},
				'-',
				{
					text:'Действие8',
				},
				{
					text:'Действие9',
				},
				'-',
				'-',
				{
					text:'Действие10',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОписаниеОтчета',
			text: '',
			style: 'position:absolute;left:8px;top:340px;width:521px;height:58px;',
		},
	]
});