﻿Ext.define('Справочники.ВнешниеОбработки.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	height: 386,width: 618,
	iconCls: 'bogus',
	title: 'Регистрация внешней обработки, печатной формы,  обработки по заполнению табличных частей',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:618px;height:25px;',
			items:
			[
				{
					text:'Права',
				},
				{
					text:'РазделительПрава',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:325px;top:33px;width:285px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВидОбработки',
			style: 'position:absolute;left:39px;top:57px;width:185px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:39px;top:33px;width:185px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:108px;width:602px;height:247px;',
			height: 247,width: 602,
			items:
			[
				{
					title:'СтраницаПринадлежность',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:22px;width:602px;height:24px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Очистить',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'СохранитьФайлНаДиск',
				},
				{
					text:'Подбор',
				},
				{
					text:'Действие3',
				},
				{
					text:'ЗаменитьФайл',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:47px;width:602px;height:200px;',
			height: 200,width: 602,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ПредставлениеОбъекта',
				},
				{
					text:'ТабличнаяЧасть',
				},
				{
					text:'ПредставлениеКнопки',
				},
				{
					text:'ПредставлениеОтбораПостроителя',
				},
				{
					text:'ИмяФайлаПечатнойФормы',
				},
				{
					text:'ЗаменяемаяПечатнаяФорма',
				},
				{
					text:'НастройкиПостроителяДляОтбора',
				},
				{
					text:'ТабличнаяЧастьИмя',
				},
				{
					text:'ХранилищеВнешнейОбработки',
				},
				{
					text:'ПредставлениеНастроекОбработки',
				},
				{
					text:'СпособЗапуска',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:325px;top:57px;width:285px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:361px;width:618px;height:25px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:527px;top:81px;width:83px;height:27px;',
			items:
			[
				{
					text:'ЗаменитьФайл',
				},
				{
					text:'УдалитьФайл',
				},
				{
					text:'СохранитьФайлНаДиск',
				},
			]
		},
	]
});