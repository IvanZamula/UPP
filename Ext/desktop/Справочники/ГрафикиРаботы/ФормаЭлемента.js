﻿Ext.define('Справочники.ГрафикиРаботы.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:813px;height:530px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Графики работы',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:505px;width:813px;height:25px;',
			items:
			[
				{
					text:'Записать',
				},
				'-',
				{
					text:'Действие',
				},
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
				'-',
				'-',
			]
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:8px;width:79px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:95px;top:8px;width:368px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ЗаполнитьГрафик',
			text: 'Заполнить график',
			style: 'position:absolute;left:8px;top:35px;width:128px;height:27px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:72px;width:797px;height:425px;',
			height: 425,width: 797,
			columns:
			[
				{
					text:'Месяц',
					width:'94',
				},
				{
					text:'Всего',
					width:'44',
				},
				{
					text:'дней',
					width:'44',
				},
				{
					text:'часов',
					width:'44',
				},
				{
					text:'Вечерних',
					width:'44',
				},
				{
					text:'Ночных',
					width:'44',
				},
				{
					text:'Часов за день',
					width:'98',
				},
				{
					text:'Из них вечерних',
					width:'98',
				},
				{
					text:'Из них ночных',
					width:'98',
				},
				{
					text:'1',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'2',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'3',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'4',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'5',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'6',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'7',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'8',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'9',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'10',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'11',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'12',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'13',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'14',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'15',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'16',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'17',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'18',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'19',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'20',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'21',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'22',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'23',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'24',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'25',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'26',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'27',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'28',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'29',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'30',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'31',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'',
					width:'30',
				},
			]
		},
		{
			xtype: 'label',
			name: 'ПараметрыГрафика',
			text: 'График пятидневка, 40-часовая рабочая неделя, выходные суббота и воскресенье.',
			style: 'position:absolute;left:155px;top:35px;width:308px;height:28px;',
		},
		{
			xtype: 'label',
			name: 'НадписьГод',
			text: 'Год:',
			style: 'position:absolute;left:712px;top:8px;width:25px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерТекущегоГода',
			style: 'position:absolute;left:742px;top:8px;width:63px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'СсылкаИзменитьПараметрыЗаполнения',
			text: 'Изменить параметры заполнения графика...',
			style: 'position:absolute;left:628px;top:34px;width:177px;height:34px;',
		},
	]
});