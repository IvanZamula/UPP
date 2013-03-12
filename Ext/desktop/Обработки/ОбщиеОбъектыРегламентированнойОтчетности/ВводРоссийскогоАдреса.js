﻿Ext.define('Обработки.ОбщиеОбъектыРегламентированнойОтчетности.ВводРоссийскогоАдреса',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:333px;height:298px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Ввод адреса',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:333px;height:25px;',
			items:
			[
				'-',
				{
					text:'Классификатор',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:273px;width:333px;height:25px;',
			items:
			[
				{
					text:'OK',
				},
				{
					text:'Отмена',
				},
				'-',
			]
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Регион:',
			style: 'position:absolute;left:8px;top:57px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Регион',
			style: 'position:absolute;left:99px;top:57px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'Район:',
			style: 'position:absolute;left:8px;top:103px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Район',
			style: 'position:absolute;left:99px;top:105px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись8',
			text: 'Город:',
			style: 'position:absolute;left:8px;top:129px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Город',
			style: 'position:absolute;left:99px;top:129px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись9',
			text: 'Нас. пункт:',
			style: 'position:absolute;left:8px;top:153px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НаселенныйПункт',
			style: 'position:absolute;left:99px;top:153px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись10',
			text: 'Улица:',
			style: 'position:absolute;left:8px;top:177px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Улица',
			style: 'position:absolute;left:99px;top:177px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись11',
			text: 'Дом:',
			style: 'position:absolute;left:8px;top:201px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дом',
			style: 'position:absolute;left:99px;top:201px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись12',
			text: 'Корпус:',
			style: 'position:absolute;left:148px;top:201px;width:48px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Корпус',
			style: 'position:absolute;left:201px;top:201px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись13',
			text: 'Кв.:',
			style: 'position:absolute;left:249px;top:201px;width:29px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Квартира',
			style: 'position:absolute;left:280px;top:201px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись18',
			text: 'Представление:',
			style: 'position:absolute;left:8px;top:225px;width:86px;height:19px;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			name: 'Представление',
			style: 'position:absolute;left:99px;top:225px;width:226px;height:40px;',
		},
		{
			xtype: 'label',
			name: 'Надпись14',
			text: 'Индекс:',
			style: 'position:absolute;left:210px;top:33px;width:45px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Индекс',
			style: 'position:absolute;left:265px;top:33px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись19',
			text: 'Код страны:',
			style: 'position:absolute;left:8px;top:33px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КодСтраны',
			style: 'position:absolute;left:99px;top:33px;width:43px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись20',
			text: 'Код региона:',
			style: 'position:absolute;left:8px;top:80px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КодРегиона',
			style: 'position:absolute;left:99px;top:81px;width:27px;height:19px;',
		},
	]
});