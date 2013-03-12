﻿Ext.define('Документы.ИзменениеСпециальногоКоэффициентаНМА.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:622px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Изменения понижающего коэффициента для расчета амортизации НМА (налоговый учет)',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:606px;height:380px;',
			height: 380,width: 606,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'НУ',
					width:'20',
				},
				{
					text:'Дата',
					width:'123',
				},
				{
					text:'Номер',
					width:'89',
				},
				{
					text:'Проведен',
					width:'0',
				},
				{
					text:'Организация',
					width:'201',
				},
				{
					text:'Ответственный',
					width:'120',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:622px;height:25px;',
			items:
			[
				{
					text:'Движения документа по регистрам',
				},
				'-',
				{
					text:'Структура подчиненности документа',
				},
			]
		},
	]
});