﻿Ext.define('Документы.РассылкаАнкет.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 458,width: 449,
	iconCls: 'bogus',
	title: 'Рассылка анкет',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:449px;height:25px;',
			items:
			[
				{
					text:'Разделитель2',
				},
				{
					text:'ДействиеОткрытьСвойства',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие4',
				},
				{
					text:'ДействиеОткрытьКатегории',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ДействиеОткрытьСвойства',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие',
				},
				{
					text:'ДействиеОткрытьКатегории',
				},
				{
					text:'Подменю',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие4',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'РедактироватьКодНомер',
				},
				{
					text:'Действие3',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:433px;width:449px;height:25px;',
			items:
			[
				{
					text:'ОсновныеДействияФормыСохранить',
				},
				{
					text:'ОсновныеДействияФормыОК',
				},
				{
					text:'ОсновныеДействияФормыЗакрыть',
				},
				{
					text:'Отправить',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'РазделительПовторнойРассылки',
				},
				{
					text:'ПовторнаяРассылка',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:96px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:196px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Анкета',
			style: 'position:absolute;left:96px;top:57px;width:345px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:82px;width:433px;height:44px;',
			height: 44,width: 433,
			items:
			[
				{
					title:'ВнешнийПочтовыйКлиент',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЭлектронныйАдресОтветов',
			style: 'position:absolute;left:88px;top:0px;width:345px;height:19px;',
		},
					]
				},
				{
					title:'ВстроенныйПочтовыйКлиент',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'УчетнаяЗаписьДляОтправки',
			style: 'position:absolute;left:88px;top:0px;width:345px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЭлектронныйАдресОтветовВстроенныйПочтовыйКлиент',
			style: 'position:absolute;left:88px;top:25px;width:345px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:131px;width:433px;height:196px;',
			height: 196,width: 433,
			items:
			[
				{
					title:'Письмо',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТекстПисьма',
			style: 'position:absolute;left:6px;top:6px;width:419px;height:164px;',
		},
					]
				},
				{
					title:'Получатели',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:419px;height:24px;',
			items:
			[
				{
					text:'Действие4',
				},
				{
					text:'Действие3',
				},
				{
					text:'ПросмотрHTML',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие8',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие7',
				},
				{
					text:'Подбор',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:419px;height:139px;',
			height: 139,width: 419,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'Объект',
				},
				{
					text:'Получатель',
				},
			]
		},
					]
				},
				{
					title:'Вложения',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:419px;height:24px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:419px;height:139px;',
			height: 139,width: 419,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ИмяФайла',
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
			name: 'ПервичнаяРассылка',
			style: 'position:absolute;left:96px;top:356px;width:345px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:96px;top:381px;width:345px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:96px;top:406px;width:345px;height:19px;',
		},
	]
});