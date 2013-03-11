﻿Ext.define('Документы.НачислениеПоБольничномуЛисту.ФормаОтраженияВУчете',
	{
	extend: 'Ext.window.Window',
	height: 344,width: 644,
	iconCls: 'bogus',
	title: 'Отражение в учете пособия по документу',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:319px;width:644px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Действие6',
				},
				{
					text:'ДействиеОК',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:156px;width:628px;height:155px;',
			height: 155,width: 628,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'Период',
				},
				{
					text:'Сумма',
				},
				{
					text:'ДополнительныйРезультат',
				},
				{
					text:'СчетДт',
				},
				{
					text:'ПодразделениеДт',
				},
				{
					text:'СубконтоДт1',
				},
				{
					text:'СубконтоДт2',
				},
				{
					text:'СубконтоДт3',
				},
				{
					text:'Колонка1',
				},
				{
					text:'СчетКт',
				},
				{
					text:'ПодразделениеКт',
				},
				{
					text:'СубконтоКт1',
				},
				{
					text:'СубконтоКт2',
				},
				{
					text:'СубконтоКт3',
				},
				{
					text:'ОблагаетсяЕНВД',
				},
				{
					text:'КодДоходаЕСН',
				},
				{
					text:'СчетДтНУ',
				},
				{
					text:'СубконтоДтНУ1',
				},
				{
					text:'СубконтоДтНУ2',
				},
				{
					text:'СубконтоДтНУ3',
				},
				{
					text:'СчетКтНУ',
				},
				{
					text:'СубконтоКтНУ1',
				},
				{
					text:'СубконтоКтНУ2',
				},
				{
					text:'СубконтоКтНУ3',
				},
				{
					text:'ОтражениеВУСН',
				},
				{
					text:'СуммаНУ',
				},
				{
					text:'СуммаПР',
				},
				{
					text:'СуммаВР',
				},
				{
					text:'ВидНачисленийОплатыТрудаПоСтатье255НК',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:132px;width:628px;height:24px;',
			items:
			[
				{
					text:'Действие11',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие10',
				},
				{
					text:'Сформировать',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие15',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие16',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:54px;width:628px;height:62px;',
			height: 62,width: 628,
			items:
			[
				{
					title:'ЕНВД',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПодпадаетПодЕНВД',
			style: 'position:absolute;left:153px;top:37px;width:74px;height:19px;',
		},
					]
				},
			]
		},
	]
});