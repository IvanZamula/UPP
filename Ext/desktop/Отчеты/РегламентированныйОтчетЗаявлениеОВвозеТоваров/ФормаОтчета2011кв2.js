﻿Ext.define('Отчеты.РегламентированныйОтчетЗаявлениеОВвозеТоваров.ФормаОтчета2011кв2',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:670px;height:446px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Заявление о ввозе товаров и уплате косвенных налогов',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:670px;height:25px;',
			items:
			[
				{
					text:'Обновить',
				},
				{
					text:'Настройка...',
				},
				'-',
				'-',
				{
					text:'Выгрузить',
				},
				'-',
				'-',
				{
					text:'Очистить',
				},
				{
					text:'Справка',
				},
				'-',
				{
					text:'Расширить поле бланка',
				},
				'-',
				{
					text:'Поиск',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:421px;width:670px;height:25px;',
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
				'-',
				{
					text:'Записать',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:81px;width:654px;height:310px;',
			height: 310,width: 654,
			items:
			[
				{
					title:'Раздел1',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел1',
			text: 'Добавить',
			style: 'position:absolute;left:483px;top:267px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел1',
			text: 'Удалить',
			style: 'position:absolute;left:568px;top:267px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Раздел2',
				},
				{
					title:'Раздел3',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись31',
			text: 'Дополнительные страницы:',
			style: 'position:absolute;left:116px;top:241px;width:148px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись34',
			text: 'Дополнительные страницы:',
			style: 'position:absolute;left:116px;top:265px;width:148px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись35',
			text: 'Дополнительные страницы:',
			style: 'position:absolute;left:116px;top:241px;width:148px;height:19px;',
		},
					]
				},
				{
					title:'Приложение',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись26',
			text: 'Дополнительные строки:',
			style: 'position:absolute;left:349px;top:267px;width:132px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтраницуПриложение',
			text: 'Добавить',
			style: 'position:absolute;left:396px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтраницуПриложение',
			text: 'Удалить',
			style: 'position:absolute;left:481px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущаяСтраницаПриложение',
			text: '',
			style: 'position:absolute;left:266px;top:265px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующаяСтраницаПриложение',
			text: '',
			style: 'position:absolute;left:370px;top:265px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерейтиНаСтраницуПриложение',
			text: 'Перейти',
			style: 'position:absolute;left:566px;top:265px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Сведения о выписках банка',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтраницуСведения',
			text: 'Добавить',
			style: 'position:absolute;left:396px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтраницуСведения',
			text: 'Удалить',
			style: 'position:absolute;left:481px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущаяСтраницаСведения',
			text: '',
			style: 'position:absolute;left:266px;top:241px;width:20px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтатикСтраницСведения',
			text: '999 из 999',
			style: 'position:absolute;left:288px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующаяСтраницаСведения',
			text: '',
			style: 'position:absolute;left:370px;top:241px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерейтиНаСтраницуСведения',
			text: 'Перейти',
			style: 'position:absolute;left:566px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиСведения',
			text: 'Добавить',
			style: 'position:absolute;left:481px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиСведения',
			text: 'Удалить',
			style: 'position:absolute;left:566px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтатикСтраницПриложение',
			text: '999 из 999',
			style: 'position:absolute;left:288px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтатикСтраницЗачет',
			text: '999 из 999',
			style: 'position:absolute;left:288px;top:241px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Сведения о зачетах',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтраницуЗачет',
			text: 'Добавить',
			style: 'position:absolute;left:396px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтраницуЗачет',
			text: 'Удалить',
			style: 'position:absolute;left:481px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущаяСтраницаЗачет',
			text: '',
			style: 'position:absolute;left:266px;top:241px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующаяСтраницаЗачет',
			text: '',
			style: 'position:absolute;left:370px;top:241px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерейтиНаСтраницуЗачет',
			text: 'Перейти',
			style: 'position:absolute;left:566px;top:241px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиЗачет',
			text: 'Добавить',
			style: 'position:absolute;left:481px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиЗачет',
			text: 'Удалить',
			style: 'position:absolute;left:566px;top:265px;width:80px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: '_ИндикаторВнешнегоОтчета',
			text: 'Внешний отчет',
			style: 'position:absolute;left:584px;top:5px;width:78px;height:15px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:654px;height:48px;',
			height: 48,width: 654,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаТочностьЕдиницыИзмерения',
			style: 'position:absolute;left:222px;top:0px;width:32px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаДатаСдачи',
			style: 'position:absolute;left:82px;top:24px;width:80px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Отключить авторасчет вычисляемых ячеек',
			style: 'position:absolute;left:170px;top:24px;width:246px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерКорректировки',
			style: 'position:absolute;left:554px;top:24px;width:49px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:391px;width:654px;height:24px;',
			height: 24,width: 654,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:183px;top:5px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:263px;top:5px;width:391px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Статус',
			style: 'position:absolute;left:47px;top:5px;width:119px;height:19px;',
		},
					]
				},
			]
		},
	]
});