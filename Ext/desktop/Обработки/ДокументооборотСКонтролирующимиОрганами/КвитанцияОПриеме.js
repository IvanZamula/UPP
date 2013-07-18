﻿Ext.require(['Данные.Обработки.ДокументооборотСКонтролирующимиОрганами'], function () 
{
	Ext.define('Обработки.ДокументооборотСКонтролирующимиОрганами.КвитанцияОПриеме',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:563px;height:411px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Квитанция о приеме',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Имя обработанного файла:',
			style: 'position:absolute;left:8px;top:46px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИмяОбрабФайла',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:47px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Идентификатор файла:',
			style: 'position:absolute;left:8px;top:72px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИдФайл',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:73px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Идентификатор документа:',
			style: 'position:absolute;left:8px;top:98px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИдДок',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:99px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Дата и время представления:',
			style: 'position:absolute;left:8px;top:124px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ДатаВремяПредст',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:125px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Дата поступления отчета:',
			style: 'position:absolute;left:8px;top:280px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ДатаПост',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:281px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Код формы по КНД:',
			style: 'position:absolute;left:8px;top:150px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КНД',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:151px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'Наименование формы:',
			style: 'position:absolute;left:8px;top:176px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НаимОтч',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:177px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись8',
			text: 'Номер корректировки:',
			style: 'position:absolute;left:8px;top:202px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НомКорр',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:203px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись9',
			text: 'Отчетный год:',
			style: 'position:absolute;left:8px;top:254px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ОтчетГод',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:255px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись10',
			text: 'Отчетный период:',
			style: 'position:absolute;left:8px;top:228px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ОтчетныйПериод',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:229px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись11',
			text: 'Рег. номер отчетности в НО:',
			style: 'position:absolute;left:8px;top:332px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'РегНом',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:333px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись12',
			text: 'Проверившая программа:',
			style: 'position:absolute;left:8px;top:358px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ПрогрКомпл',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:359px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись14',
			text: 'Дата принятия отчета:',
			style: 'position:absolute;left:8px;top:306px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ДатаПрин',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:307px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись15',
			text: 'Налоговый орган:',
			style: 'position:absolute;left:8px;top:8px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НалоговыйОрган',
			width: 362,
			height: 19,
			style: 'position:absolute;left:193px;top:9px;width:362px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: '',
			style: 'position:absolute;left:8px;top:36px;width:547px;height:3px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:386px;width:563px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Закрыть',
				},
			]
		},
	]
	});
});