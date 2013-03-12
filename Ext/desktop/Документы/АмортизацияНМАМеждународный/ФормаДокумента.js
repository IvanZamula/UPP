﻿Ext.define('Документы.АмортизацияНМАМеждународный.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:644px;height:361px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Амортизация НМА (международный)',
	
	items:
	[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:90px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'от:',
			style: 'position:absolute;left:172px;top:33px;width:16px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:190px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:57px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:90px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:309px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:90px;top:309px;width:546px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:100px;width:628px;height:24px;',
			items:
			[
				{
					text:'Заполнить',
				},
				'-',
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:124px;width:628px;height:180px;',
			height: 180,width: 628,
			columns:
			[
				{
					text:'№',
					width:'28',
				},
				{
					text:'НМА',
					width:'220',
				},
				{
					text:'Метод начисления ',
					width:'120',
				},
				{
					text:'Количество выпущенной продукции',
					width:'188',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:644px;height:25px;',
			items:
			[
				{
					text:'',
				},
				{
					text:'',
				},
				{
					text:'Движения документа по регистрам',
				},
				'-',
				'-',
				{
					text:'Структура подчиненности документа',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:336px;width:644px;height:25px;',
			items:
			[
				'-',
				'-',
				{
					text:'Печать',
				},
				{
					text:'OK',
				},
				'-',
				{
					text:'Закрыть',
				},
				{
					text:'Записать',
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Ответственный:',
			style: 'position:absolute;left:335px;top:57px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:425px;top:57px;width:211px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Месяц начисления:',
			style: 'position:absolute;left:319px;top:33px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПредставлениеПериодаРегистрации',
			style: 'position:absolute;left:425px;top:33px;width:137px;height:19px;',
		},
	]
});