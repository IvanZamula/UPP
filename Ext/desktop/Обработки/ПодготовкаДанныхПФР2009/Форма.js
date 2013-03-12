﻿Ext.define('Обработки.ПодготовкаДанныхПФР2009.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:970px;height:548px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Подготовка данных СЗВ-4',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Учреждение:',
			style: 'position:absolute;left:8px;top:8px;width:70px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:93px;top:8px;width:249px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Год',
			text: 'Год:',
			style: 'position:absolute;left:364px;top:8px;width:25px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'РасчетныйПериод',
			style: 'position:absolute;left:393px;top:8px;width:72px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Тип сведений:',
			style: 'position:absolute;left:727px;top:8px;width:77px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДанныеОСтажеФизлица',
			text: '  Состав пачки',
			style: 'position:absolute;left:8px;top:243px;width:954px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНазваниеПачки',
			text: '  Документы, пачки документов',
			style: 'position:absolute;left:8px;top:57px;width:954px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:81px;width:275px;height:24px;',
			items:
			[
				{
					text:'Удалить',
				},
				'-',
				{
					text:'АДВ-11',
				},
				'-',
				{
					text:'Перенести',
				},
				{
					text:'Обновить',
				},
				{
					text:'Принято ПФР',
				},
				{
					text:'СЗВ-4',
				},
				'-',
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:105px;width:275px;height:130px;',
			height: 130,width: 275,
			columns:
			[
				{
					text:'Пачка',
					width:'100',
				},
				{
					text:'Номер пачки',
					width:'100',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:300px;top:81px;width:662px;height:154px;',
			height: 154,width: 662,
			items:
			[
				{
					title:'АДВ11',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись21',
			text: 'Дата заполнения:',
			style: 'position:absolute;left:0px;top:0px;width:96px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаСоставления',
			style: 'position:absolute;left:96px;top:0px;width:136px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНомерВПачке',
			text: 'Номер пачки:',
			style: 'position:absolute;left:247px;top:0px;width:73px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерПачки',
			style: 'position:absolute;left:320px;top:0px;width:92px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись23',
			text: 'Ведомость составлена по состоянию на дату:',
			style: 'position:absolute;left:444px;top:0px;width:102px;height:43px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаДействия',
			style: 'position:absolute;left:546px;top:24px;width:92px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись28',
			text: 'Дата заполнения:',
			style: 'position:absolute;left:0px;top:0px;width:93px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:0px;top:24px;width:93px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный1',
			text: 'Ответственный:',
			style: 'position:absolute;left:0px;top:24px;width:96px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Исполнитель1',
			style: 'position:absolute;left:96px;top:24px;width:316px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:69px;width:662px;height:85px;',
			height: 85,width: 662,
			items:
			[
				{
					title:'',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:24px;width:662px;height:59px;',
			height: 59,width: 662,
			columns:
			[
				{
					text:'N',
					width:'28',
				},
				{
					text:'Тип строки',
					width:'100',
				},
				{
					text:'Год',
					width:'100',
				},
				{
					text:'Страховая часть',
					width:'100',
				},
				{
					text:'Накопительная часть',
					width:'118',
				},
				{
					text:'Дополнительный тариф',
					width:'130',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:662px;height:24px;',
			items:
			[
				{
					text:'Действие1',
				},
				{
					text:'Заполнить расчетами с ПФР',
				},
				{
					text:'Действие',
				},
				'-',
				{
					text:'Действие2',
				},
				{
					text:'&Добавить строку',
				},
				'-',
			]
		},
					]
				},
				{
					title:'',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись29',
			text: 'Данные о уплате взносов доступны только расчетчику!',
			style: 'position:absolute;left:25px;top:9px;width:291px;height:18px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'СЗВ4',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТерриториальныеУсловия',
			style: 'position:absolute;left:167px;top:120px;width:66px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипФормы',
			text: 'Тип формы:',
			style: 'position:absolute;left:0px;top:50px;width:88px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВидКорректировки',
			text: 'Вид корректировки:',
			style: 'position:absolute;left:480px;top:0px;width:131px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаСоставления1',
			style: 'position:absolute;left:98px;top:0px;width:117px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНомерВпачкеСЗВ4',
			text: 'Номер пачки:',
			style: 'position:absolute;left:230px;top:0px;width:71px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерПачки1',
			style: 'position:absolute;left:306px;top:0px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Исполнитель',
			style: 'position:absolute;left:98px;top:24px;width:300px;height:19px;',
		},
					]
				},
				{
					title:'',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьСостояниеПодготовкиДокументов',
			text: 'Данные для передачи еще не готовы. Необходимо создать хотя бы одну пачку документов.',
			style: 'position:absolute;left:30px;top:519px;width:493px;height:21px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВерсияФормата',
			text: 'Формат файла:',
			style: 'position:absolute;left:487px;top:8px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ФорматФайла',
			style: 'position:absolute;left:576px;top:8px;width:123px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'Печать',
			text: '&Печать',
			style: 'position:absolute;left:622px;top:519px;width:76px;height:21px;',
		},
		{
			xtype: 'button',
			name: 'ПоказатьФайл',
			text: 'Показать &файл',
			style: 'position:absolute;left:699px;top:519px;width:118px;height:21px;',
		},
		{
			xtype: 'button',
			name: 'НаДиск',
			text: 'На &диск',
			style: 'position:absolute;left:818px;top:519px;width:81px;height:21px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:266px;width:954px;height:243px;',
			height: 243,width: 954,
			items:
			[
				{
					title:'СЗВ4',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:24px;width:275px;height:219px;',
			height: 219,width: 275,
			columns:
			[
				{
					text:'N',
					width:'28',
				},
				{
					text:'Физ лицо',
					width:'200',
				},
				{
					text:'Адрес для информирования',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:275px;height:24px;',
			items:
			[
				{
					text:'Действие3',
				},
				{
					text:'Перенести',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие1',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:290px;top:131px;width:664px;height:112px;',
			height: 112,width: 664,
			items:
			[
				{
					title:'Страница СЗВ41',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:664px;height:24px;',
			items:
			[
				{
					text:'Действие12',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие16',
				},
				'-',
				'-',
				{
					text:'Действие11',
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
					text:'Действие10',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие15',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:24px;width:664px;height:88px;',
			height: 88,width: 664,
			columns:
			[
				{
					text:'Период',
					width:'120',
				},
				{
					text:'Начало',
					width:'60',
				},
				{
					text:'Окончание',
					width:'60',
				},
				{
					text:'',
					width:'30',
				},
				{
					text:'Территориальные условия',
					width:'30',
				},
				{
					text:'Условия труда',
					width:'120',
				},
				{
					text:'Код особых условий труда',
					width:'60',
				},
				{
					text:'Код позиции списка',
					width:'60',
				},
				{
					text:'Исчисление страхового стажа',
					width:'160',
				},
				{
					text:'Код',
					width:'60',
				},
				{
					text:'Месяцы',
					width:'30',
				},
				{
					text:'Дни',
					width:'30',
				},
				{
					text:'Вид отпуска',
					width:'40',
				},
				{
					text:'Досрочное назначение пенсии',
					width:'150',
				},
				{
					text:'Код',
					width:'60',
				},
				{
					text:'Часы/месяцы',
					width:'30',
				},
				{
					text:'Минуты',
					width:'30',
				},
				{
					text:'Ставка',
					width:'30',
				},
			]
		},
					]
				},
				{
					title:'Страница СЗВ42',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись19',
			text: 'Начало периода:',
			style: 'position:absolute;left:12px;top:13px;width:88px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись20',
			text: 'Конец периода:',
			style: 'position:absolute;left:12px;top:37px;width:88px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СтажРаботыНачалоПериода',
			style: 'position:absolute;left:106px;top:13px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СтажРаботыОкончаниеПериода',
			style: 'position:absolute;left:106px;top:37px;width:80px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:290px;top:0px;width:664px;height:108px;',
			height: 108,width: 664,
			items:
			[
				{
					title:'Страница со всеми взносами',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МесяцыБолезни',
			style: 'position:absolute;left:225px;top:66px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтпускВН',
			text: 'Отпуск по временной нетрудоспособности:',
			style: 'position:absolute;left:0px;top:66px;width:225px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МесяцыОтпускаЗаСвойСчет',
			style: 'position:absolute;left:225px;top:89px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтпускБСЗП',
			text: 'Отпуск без сохранения заработной платы:',
			style: 'position:absolute;left:0px;top:89px;width:225px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСЗПДней',
			text: 'дней',
			style: 'position:absolute;left:375px;top:89px;width:32px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДниОтпускаЗаСвойСчет',
			style: 'position:absolute;left:324px;top:89px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись13',
			text: 'месяцев',
			style: 'position:absolute;left:270px;top:89px;width:54px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВНДней',
			text: 'дней',
			style: 'position:absolute;left:375px;top:66px;width:32px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись15',
			text: 'месяцев',
			style: 'position:absolute;left:270px;top:66px;width:54px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДниБолезни',
			style: 'position:absolute;left:324px;top:66px;width:45px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'АдресДляИнформирования',
			style: 'position:absolute;left:476px;top:89px;width:188px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:21px;width:467px;height:19px;',
			height: 19,width: 467,
			items:
			[
				{
					title:'',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоНаСтраховуюЧастьПФР',
			style: 'position:absolute;left:59px;top:0px;width:75px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоНаНакопительнуюЧастьПФР',
			style: 'position:absolute;left:224px;top:0px;width:75px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаСтраховуюЧасть',
			text: 'Страховая:',
			style: 'position:absolute;left:0px;top:0px;width:57px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНакопительнаяЧасть',
			text: 'Накопительная:',
			style: 'position:absolute;left:140px;top:0px;width:82px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись31',
			text: 'Данные о начисленных взносах доступны только расчетчику!',
			style: 'position:absolute;left:24px;top:0px;width:443px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:304px;top:0px;width:163px;height:19px;',
			height: 19,width: 163,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоПоДополнительномуТарифу',
			style: 'position:absolute;left:90px;top:0px;width:73px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПоДополнительномуТарифу',
			text: 'Дополнительная:',
			style: 'position:absolute;left:0px;top:0px;width:90px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:476px;top:0px;width:188px;height:64px;',
			height: 64,width: 188,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоПоВсейОрганизацииНаСтраховуюЧастьПФР',
			style: 'position:absolute;left:115px;top:21px;width:71px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаСтраховуюЧасть1',
			text: 'Страховая часть:',
			style: 'position:absolute;left:0px;top:21px;width:89px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоПоВсейОрганизацииНаНакопительнуюЧастьПФР',
			style: 'position:absolute;left:115px;top:45px;width:71px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНакопительнаяЧасть1',
			text: 'Накопительная часть:',
			style: 'position:absolute;left:0px;top:45px;width:113px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Страница без всех взносов',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МесяцыБолезни1',
			style: 'position:absolute;left:225px;top:66px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтпускВН1',
			text: 'Отпуск по временной нетрудоспособности:',
			style: 'position:absolute;left:0px;top:66px;width:225px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МесяцыОтпускаЗаСвойСчет1',
			style: 'position:absolute;left:225px;top:89px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтпускБСЗП1',
			text: 'Отпуск без сохранения заработной платы:',
			style: 'position:absolute;left:0px;top:89px;width:225px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСЗПДней1',
			text: 'дней',
			style: 'position:absolute;left:375px;top:89px;width:32px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДниОтпускаЗаСвойСчет1',
			style: 'position:absolute;left:324px;top:89px;width:45px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись32',
			text: 'месяцев',
			style: 'position:absolute;left:270px;top:89px;width:54px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВНДней1',
			text: 'дней',
			style: 'position:absolute;left:375px;top:66px;width:32px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись33',
			text: 'месяцев',
			style: 'position:absolute;left:270px;top:66px;width:54px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДниБолезни1',
			style: 'position:absolute;left:324px;top:66px;width:45px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'АдресДляИнформирования1',
			style: 'position:absolute;left:439px;top:65px;width:225px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:21px;width:664px;height:19px;',
			height: 19,width: 664,
			items:
			[
				{
					title:'',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоНаСтраховуюЧастьПФР1',
			style: 'position:absolute;left:60px;top:0px;width:110px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоНаНакопительнуюЧастьПФР1',
			style: 'position:absolute;left:304px;top:0px;width:110px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаСтраховуюЧасть2',
			text: 'Страховая:',
			style: 'position:absolute;left:0px;top:0px;width:57px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНакопительнаяЧасть2',
			text: 'Накопительная:',
			style: 'position:absolute;left:217px;top:0px;width:82px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:425px;top:0px;width:239px;height:19px;',
			height: 19,width: 239,
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачисленоПоДополнительномуТарифу1',
			style: 'position:absolute;left:129px;top:0px;width:110px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПоДополнительномуТарифу1',
			text: 'Дополнительная:',
			style: 'position:absolute;left:33px;top:0px;width:90px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись34',
			text: 'Данные о начисленных взносах доступны только расчетчику!',
			style: 'position:absolute;left:24px;top:0px;width:640px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Пустая страница',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:0px;width:940px;height:226px;',
			height: 226,width: 940,
			columns:
			[
				{
					text:'',
					width:'0',
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'button',
			name: 'Проверить',
			text: 'Проверить',
			style: 'position:absolute;left:526px;top:519px;width:95px;height:21px;',
		},
		{
			xtype: 'button',
			name: 'Сформировать',
			text: 'Заполнить',
			style: 'position:absolute;left:8px;top:32px;width:80px;height:21px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаОК',
			text: 'ОК',
			style: 'position:absolute;left:901px;top:519px;width:36px;height:21px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВвода1',
			style: 'position:absolute;left:43px;top:148px;width:45px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'Справка',
			text: '',
			style: 'position:absolute;left:939px;top:519px;width:23px;height:21px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДокументы2010',
			text: 'Данные за 2010 год формируются в документе "Опись сведений АДВ-6-2"!',
			style: 'position:absolute;left:93px;top:32px;width:478px;height:21px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПерейти',
			text: 'Перейти к списку документов',
			style: 'position:absolute;left:576px;top:32px;width:158px;height:21px;',
		},
	]
});