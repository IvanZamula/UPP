﻿Ext.define('Документы.НДФЛВозвратНалога.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:668px;height:367px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Возврат налога на доходы физических лиц',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:322px;top:33px;width:88px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:410px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:490px;top:33px;width:20px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:510px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:33px;width:76px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:84px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:314px;width:76px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:84px;top:314px;width:576px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:322px;top:57px;width:88px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:410px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВозврат',
			text: 'Возврат за:',
			style: 'position:absolute;left:8px;top:57px;width:76px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:105px;width:652px;height:24px;',
			items:
			[
				'-',
				{
					text:'Подбор',
				},
				{
					text:'Действие10',
				},
				'-',
				{
					text:'Действие13',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие15',
				},
				{
					text:'Действие16',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие14',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:129px;width:652px;height:179px;',
			height: 179,width: 652,
			columns:
			[
				{
					text:'№',
					width:'28',
				},
				{
					text:'Сотрудник',
					width:'110',
				},
				{
					text:'Суммы возврата налога',
					width:'264',
				},
				{
					text:'По ставке 13 (30)%',
					width:'102',
				},
				{
					text:'По ставке 9 (15, 30)%',
					width:'79',
				},
				{
					text:'По ставке 35 (30)%',
					width:'84',
				},
				{
					text:'Для обособленного подразделения',
					width:'200',
				},
				{
					text:'Код по ОКАТО',
					width:'100',
				},
				{
					text:'КПП',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:25px;',
			items:
			[
				{
					text:'Действие4',
				},
				{
					text:'Действие6',
				},
				'-',
				'-',
				'-',
				{
					text:'',
				},
				'-',
				{
					text:'Действие1',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Зарплата к выплате',
				},
				'-',
				'-',
				'-',
				'-',
				{
					text:'Действие3',
				},
				'-',
				{
					text:'Структура подчиненности документа',
				},
				{
					text:'Действие1',
				},
				{
					text:'Сотрудниками, имеющими переплату по НДФЛ',
				},
				{
					text:'',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие2',
				},
				'-',
				{
					text:'Действие',
				},
				'-',
				{
					text:'Действие2',
				},
				{
					text:'',
				},
				{
					text:'Действие6',
				},
				'-',
				'-',
				{
					text:'Действие7',
				},
				{
					text:'Движения документа по регистрам',
				},
				'-',
				{
					text:'Редактировать номер',
				},
				{
					text:'Действие5',
				},
				'-',
				{
					text:'Действие5',
				},
				{
					text:'Действие4',
				},
				{
					text:'Рассчитать',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:341px;width:668px;height:25px;',
			items:
			[
				'-',
				{
					text:'Закрыть',
				},
				{
					text:'OK',
				},
				'-',
				{
					text:'Записать',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МесяцНалоговогоПериода',
			style: 'position:absolute;left:84px;top:57px;width:220px;height:19px;',
		},
	]
});