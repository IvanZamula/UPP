﻿Ext.require(['Данные.Обработки.ИзменениеНастроекУчета'], function () 
{
	Ext.define('Обработки.ИзменениеНастроекУчета.ИспользованиеПартионногоУчетаПоСкладамРегл',
	{
	extend: 'Ext.window.Window',
	id: 'ИспользованиеПартионногоУчетаПоСкладамРегл',
	style: 'position:absolute;width:415px;height:116px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Установка параметра учета',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'checkbox',
			id: 'ВестиПартионныйУчетПоСкладамРегл',
			boxLabel: 'Вести учет себестоимости МПЗ по складам в регламентированном учете',
			style: 'position:absolute;left:8px;top:5px;width:399px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ВестиПартионныйУчетПоСкладамРегл', Граница: 'Левая', Номер: 4, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ВестиПартионныйУчетПоСкладамРегл', Граница: 'Верхняя', Номер: 4, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:399,
			Верх:5,
			Лево:8,
		},
		{
			xtype: 'label',
			id: 'Надпись41',
			text: 'Значение данной настройки влияет на ведение суммового учета для субконто "Склады" на счетах учета ТМЦ.\r\nИзменение данной настройки может занять продолжительное время.',
			style: 'position:absolute;left:48px;top:38px;width:359px;height:45px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Надпись41', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Надпись41', Граница: 'Верхняя', Номер: 6, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:45,
			Ширина:359,
			Верх:38,
			Лево:48,
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			id: 'ОсновныеДействияФормы',
			style: 'position:absolute;left:0px;top:91px;width:415px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'ОсновныеДействияФормы', Граница: 'Нижняя', Номер: 3, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:415,
			Верх:91,
			Лево:0,
			width: 415,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'ОК',
					text:'Изменить настройку',
					tooltip:'Сохранить значение настройки и закрыть форму',
				},
				'-',
				{
					id:'ОсновныеДействияФормыЗакрыть',
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
					handler: function () {this.up('window').close();},
				},
				'-',
				{
					id:'Действие',
					text:'Справка',
					tooltip:'Открыть справку',
				},
			]
		},
	],
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
						//ПривязкаГраниц(item, item.ПозицияЭлемента);
						if (item.Групповой)
						{
							var элемент = Ext.getCmp(item.id).items.items[0].items.items;
							for (var i = 0; i < элемент.length; i++ ) 
							{
								var текЭлемент = элемент[i];
								//ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
							}
						}
					});
				}
				форма.ПервоеОткрытие = false;
			}
		}
	}
	});
});