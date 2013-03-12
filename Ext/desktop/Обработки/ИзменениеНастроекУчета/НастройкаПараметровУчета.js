﻿Ext.define('Обработки.ИзменениеНастроекУчета.НастройкаПараметровУчета',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:765px;height:468px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка параметров учета',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:443px;width:765px;height:25px;',
			items:
			[
				'-',
				{
					text:'Закрыть',
				},
				'-',
				'-',
				{
					text:'ОК',
				},
				{
					text:'Записать',
				},
				'-',
				{
					text:'Печать',
				},
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:8px;width:195px;height:427px;',
			height: 427,width: 195,
			columns:
			[
				{
					text:'Представление',
					width:'100',
				},
				{
					text:'Имя раздела',
					width:'100',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:209px;top:8px;width:548px;height:427px;',
			height: 427,width: 548,
			items:
			[
				{
					title:'Производство',
					items:
					[
		{
			xtype: 'label',
			name: 'ИнфНадписьЕдиницаИзмеренияВеса',
			text: 'Единица измерения, в которой указываются весовые характеристики товарно-материальных ценностей.',
			style: 'position:absolute;left:12px;top:132px;width:385px;height:32px;',
		},
		{
			xtype: 'label',
			name: 'ИнфНадписьЕдиницаИзмеренияОбъема',
			text: 'Единица измерения, в которой указываются характеристики объема товарно-материальных ценностей.',
			style: 'position:absolute;left:12px;top:196px;width:385px;height:32px;',
		},
		{
			xtype: 'label',
			name: 'ИнфНадписьДополнительнаяКолонкаПечатныхФормДокументов',
			text: 'Определяет, нужно ли при печати документов выводить дополнительную колонку, содержащую код или артикул товаров.',
			style: 'position:absolute;left:12px;top:68px;width:385px;height:32px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалютаРегУчета',
			text: 'По отношению к этой валюте указываются курсы других валют.
Для РФ валюта регламентированного учета - рубль.',
			style: 'position:absolute;left:12px;top:68px;width:336px;height:31px;',
		},
		{
			xtype: 'label',
			name: 'ТекстВажнойНадписи',
			text: '',
			style: 'position:absolute;left:52px;top:195px;width:332px;height:20px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалютаМеждУчета',
			text: 'Обычно валюта международного учета в РФ - рубль.',
			style: 'position:absolute;left:12px;top:164px;width:276px;height:18px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать версии спецификаций',
			style: 'position:absolute;left:12px;top:80px;width:212px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать наработку',
			style: 'position:absolute;left:12px;top:144px;width:152px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать лимиты отпуска материалов',
			style: 'position:absolute;left:12px;top:112px;width:240px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтратегияАвторезервированияПоЗаказам',
			text: 'Стратегия авторезервирования по заказам:',
			style: 'position:absolute;left:12px;top:48px;width:232px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать только сборочные спецификации',
			style: 'position:absolute;left:12px;top:48px;width:272px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПериодичностьДоступностиКлючевыхРесурсовПредприятия',
			text: 'Периодичность доступности ключевых ресурсов предприятия:',
			style: 'position:absolute;left:12px;top:48px;width:327px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись27',
			text: 'Определяет период, в рамках которого задаются показатели доступности ключевых ресурсов. Используется для оценки исполнимости планов.',
			style: 'position:absolute;left:12px;top:70px;width:521px;height:28px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела',
			text: 'Заказы',
			style: 'position:absolute;left:12px;top:6px;width:80px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела3',
			text: 'Учет товаров',
			style: 'position:absolute;left:12px;top:6px;width:140px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела4',
			text: 'Производство',
			style: 'position:absolute;left:12px;top:6px;width:144px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела5',
			text: 'Планирование',
			style: 'position:absolute;left:12px;top:6px;width:156px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела6',
			text: 'Валюты',
			style: 'position:absolute;left:12px;top:6px;width:80px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'Надпись30',
			text: 'Валюта регламентированного учета:',
			style: 'position:absolute;left:12px;top:48px;width:196px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись31',
			text: 'Валюта управленческого учета:',
			style: 'position:absolute;left:12px;top:111px;width:196px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись32',
			text: 'Валюта международного учета:',
			style: 'position:absolute;left:12px;top:144px;width:196px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела7',
			text: 'Печать, единицы измерения',
			style: 'position:absolute;left:12px;top:6px;width:284px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'Надпись33',
			text: 'Дополнительная колонка печатных форм документов:',
			style: 'position:absolute;left:12px;top:48px;width:284px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись34',
			text: 'Единица измерения веса:',
			style: 'position:absolute;left:12px;top:112px;width:284px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись35',
			text: 'Единица измерения объема:',
			style: 'position:absolute;left:12px;top:176px;width:284px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись16',
			text: 'Указывать склады в табличной части документов:',
			style: 'position:absolute;left:12px;top:152px;width:260px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись50',
			text: 'Указывать заказы в табличной части документов:',
			style: 'position:absolute;left:12px;top:144px;width:260px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела14',
			text: 'Заказы на производство',
			style: 'position:absolute;left:12px;top:6px;width:256px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСпособЗакрытияПотребностейЗаказовНаПроизводство',
			text: 'Способ закрытия потребностей заказов на производство:',
			style: 'position:absolute;left:44px;top:96px;width:302px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела15',
			text: 'Режим учета затрат',
			style: 'position:absolute;left:12px;top:6px;width:292px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'Надпись52',
			text: 'Последовательность списания партий:',
			style: 'position:absolute;left:32px;top:184px;width:228px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись53',
			text: 'Списывать партии при отражении документов:',
			style: 'position:absolute;left:32px;top:120px;width:250px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ГруппаПроекты',
			text: 'Проекты',
			style: 'position:absolute;left:12px;top:8px;width:99px;height:26px;',
		},
		{
			xtype: 'label',
			name: 'Надпись57',
			text: 'Дополнительная детализация продаж, закупок, движения денежных средств, затрат и планирования в разрезе проектов.',
			style: 'position:absolute;left:12px;top:72px;width:422px;height:28px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРазделаВзаиморасчеты',
			text: 'Взаиморасчеты',
			style: 'position:absolute;left:12px;top:6px;width:156px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСпособКонтроляДнейЗадолженности',
			text: 'Способ контроля дней задолженности:',
			style: 'position:absolute;left:12px;top:48px;width:208px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НастройкаОпределениеВремениПроведенияПлатежногоДокумента',
			text: 'Если у документа совпадают даты регистрации и оплаты, то проводить его:',
			style: 'position:absolute;left:12px;top:76px;width:402px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела16',
			text: 'Расчеты с персоналом',
			style: 'position:absolute;left:12px;top:6px;width:241px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'Надпись59',
			text: 'Способ ведения расчетов с персоналом в регламентированном учете:',
			style: 'position:absolute;left:12px;top:48px;width:443px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись60',
			text: 'На счетах бухгалтерского и налогового учета:
70      "Расчеты с персоналом по оплате труда"
76.04 "Расчеты по депонированным суммам"
97.01 "Расходы на оплату труда будущих периодов"',
			style: 'position:absolute;left:12px;top:108px;width:333px;height:62px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРасширеннаяАналитикаДатаНачала',
			text: '',
			style: 'position:absolute;left:320px;top:48px;width:202px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'РежимИспользованияРасширеннойАналитики',
			text: '',
			style: 'position:absolute;left:32px;top:72px;width:308px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись62',
			text: 'Вести управленческий учет затрат по организациям:',
			style: 'position:absolute;left:32px;top:272px;width:277px;height:22px;',
		},
					]
				},
				{
					title:'Заказы',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Указывать серии при резервировании',
			style: 'position:absolute;left:12px;top:264px;width:224px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать внутренние заказы',
			style: 'position:absolute;left:12px;top:228px;width:224px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Для документов поступления',
			style: 'position:absolute;left:28px;top:168px;width:172px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Для документов реализации',
			style: 'position:absolute;left:28px;top:192px;width:172px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Учитывать возвраты товара покупателем',
			style: 'position:absolute;left:12px;top:300px;width:269px;height:19px;',
		},
					]
				},
				{
					title:'Заказы на производство',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать заказы на производство',
			style: 'position:absolute;left:12px;top:48px;width:224px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Вести учет потребностей заказов на производство в материалах и полуфабрикатах',
			style: 'position:absolute;left:28px;top:72px;width:450px;height:19px;',
		},
					]
				},
				{
					title:'Планирование',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПериодичностьДоступностиКлючевыхРесурсовПредприятия',
			style: 'position:absolute;left:343px;top:48px;width:190px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Вести планирование производства по сменам',
			style: 'position:absolute;left:12px;top:116px;width:260px;height:20px;',
		},
					]
				},
				{
					title:'Валюты',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВалютаУправленческогоУчета',
			style: 'position:absolute;left:212px;top:111px;width:83px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВалютаРегламентированногоУчета',
			style: 'position:absolute;left:212px;top:48px;width:83px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВалютаМеждународногоУчета',
			style: 'position:absolute;left:212px;top:144px;width:83px;height:19px;',
		},
					]
				},
				{
					title:'Учет товаров',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать характеристики номенклатуры',
			style: 'position:absolute;left:12px;top:48px;width:256px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать серии номенклатуры',
			style: 'position:absolute;left:12px;top:72px;width:256px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Вести учет возвратной тары',
			style: 'position:absolute;left:12px;top:120px;width:256px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать серийные номера',
			style: 'position:absolute;left:12px;top:96px;width:256px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Для документов поступления',
			style: 'position:absolute;left:28px;top:176px;width:172px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Для документов реализации',
			style: 'position:absolute;left:28px;top:200px;width:172px;height:19px;',
		},
					]
				},
				{
					title:'Печать, единицы',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДополнительнаяКолонкаПечатныхФормДокументов',
			style: 'position:absolute;left:300px;top:48px;width:104px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЕдиницаИзмеренияВеса',
			style: 'position:absolute;left:300px;top:112px;width:104px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЕдиницаИзмеренияОбъема',
			style: 'position:absolute;left:300px;top:176px;width:104px;height:19px;',
		},
					]
				},
				{
					title:'Режим учета затрат',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'В регламентированном учете',
			style: 'position:absolute;left:48px;top:160px;width:176px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'В управленческом учете',
			style: 'position:absolute;left:48px;top:140px;width:176px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаВеденияУПУПоОрганизациям',
			text: 'Детализация учета ...',
			style: 'position:absolute;left:344px;top:272px;width:178px;height:22px;',
		},
		{
			xtype: 'button',
			name: 'ДетализацияРасширеннойАналитикиУчетаНоменклатурыИЗатрат',
			text: 'Детализация учета ...',
			style: 'position:absolute;left:344px;top:72px;width:178px;height:22px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Списывать партии расходным ордером',
			style: 'position:absolute;left:32px;top:248px;width:250px;height:19px;',
		},
					]
				},
				{
					title:'Проекты',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Вести учет по проектам',
			style: 'position:absolute;left:12px;top:52px;width:141px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать виды распределения по проектам',
			style: 'position:absolute;left:28px;top:108px;width:406px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Вести учет затрат по проектам',
			style: 'position:absolute;left:28px;top:132px;width:177px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Указывать проекты в табличной части документов',
			style: 'position:absolute;left:48px;top:152px;width:331px;height:19px;',
		},
					]
				},
				{
					title:'Взаиморасчеты',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СпособКонтроляДнейЗадолженности',
			style: 'position:absolute;left:224px;top:48px;width:190px;height:19px;',
		},
					]
				},
				{
					title:'Расчеты с персоналом',
					items:
					[
					]
				},
				{
					title:'НДС',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись72',
			text: 'НДС',
			style: 'position:absolute;left:12px;top:6px;width:354px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'Надпись88',
			text: 'Указание наименования продавца в счете-фактуре:',
			style: 'position:absolute;left:12px;top:48px;width:354px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПрименяетсяС1',
			text: 'Применяется с:',
			style: 'position:absolute;left:39px;top:215px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНачалаУказанияСокращенногоНаименованияПродавцаВСчетеФактуре',
			style: 'position:absolute;left:128px;top:215px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись90',
			text: 'В соответствии с Постановлением Правительства РФ от 26 мая 2009 г. № 451 «О внесении изменений в Постановление Правительства Российской Федерации от 2 декабря 2000 г. № 914» в счете-фактуре необходимо указывать полное и сокращенное наименование продавца в соответствии с учредительными документами. Это изменение вступает в силу с 9 июня 2009 г. и действует до даты вступления в силу постановления Правительства РФ 
от 26 декабря 2011 г. № 1137.',
			style: 'position:absolute;left:39px;top:120px;width:414px;height:92px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачалоПримененияИсправленныхСчетовФактур',
			style: 'position:absolute;left:128px;top:297px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ПрименяетсяС_',
			text: 'Применяется с:',
			style: 'position:absolute;left:39px;top:297px;width:83px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись95',
			text: 'До установленной даты учет НДС ведется в соответствии с Постановлением Правительства РФ от 2 декабря 2000 г. N 914',
			style: 'position:absolute;left:39px;top:320px;width:414px;height:27px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Учет НДС ведется в соответствии с постановлением Правительства РФ от 26 декабря 2011 г. № 1137 "О формах и правилах заполнения (ведения) документов, применяемых при расчетах по налогу на добавленную стоимость"',
			style: 'position:absolute;left:12px;top:244px;width:490px;height:44px;',
		},
					]
				},
				{
					title:'НДС в валюте',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись96',
			text: 'НДС в валюте',
			style: 'position:absolute;left:12px;top:6px;width:354px;height:25px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНачалаПересчетаСуммыНДСвРубляхПоДокументамВИностраннойВалютеПоСтавкеНДС',
			style: 'position:absolute;left:131px;top:148px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись73',
			text: 'Для документов в иностранной валюте сумма НДС в рублях рассчитывается:',
			style: 'position:absolute;left:12px;top:49px;width:406px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись97',
			text: 'Применяется с:',
			style: 'position:absolute;left:45px;top:148px;width:84px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись75',
			text: 'Сумма НДС в рублях соответствует рублевой сумме документа, умноженной на ставку НДС. При выборе этого варианта необходимо указать дату, начиная с которой он будет применяться. Если дата не имеет значения, рекомендуется указать 01.01.1980.',
			style: 'position:absolute;left:45px;top:97px;width:495px;height:46px;',
		},
		{
			xtype: 'label',
			name: 'Надпись76',
			text: 'Сумма НДС в рублях соответствует валютной сумме НДС, умноженной на курс валюты.',
			style: 'position:absolute;left:45px;top:204px;width:495px;height:20px;',
		},
					]
				},
				{
					title:'Налог на прибыль',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись91',
			text: 'Налог на прибыль',
			style: 'position:absolute;left:6px;top:6px;width:375px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалоОценкиДоходовИРасходовВНУПоКурсуАвансов',
			text: 'Применяется с:',
			style: 'position:absolute;left:36px;top:123px;width:85px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НачалоОценкиДоходовИРасходовВНУПоКурсуАвансов',
			style: 'position:absolute;left:132px;top:123px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИнфоНалогНаПрибыльАвансы2',
			text: 'До установленной даты стоимость имущества и услуг определяется по курсу на дату поступления или реализации',
			style: 'position:absolute;left:36px;top:143px;width:356px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'Надпись92',
			text: 'Стоимость имущества и услуг, предварительно оплаченных по договору в валюте, определяется по курсу на дату:',
			style: 'position:absolute;left:6px;top:42px;width:375px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалоОценкиДоходовИРасходовВНУПоКурсуАвансов1',
			text: 'Применяется с:',
			style: 'position:absolute;left:46px;top:273px;width:85px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНачалаУчетаПостоянныхРазницВКурсовыхРазницахПоРасчетамВУЕ',
			style: 'position:absolute;left:142px;top:273px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИнфоНалогНаПрибыльАвансы3',
			text: 'Суммовая разница определяется без учета НДС.
НДС не учитывается в составе расходов для целей налогообложения прибыли',
			style: 'position:absolute;left:46px;top:293px;width:413px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'Надпись93',
			text: 'Порядок поддержки ПБУ18/02 при учете суммовых разниц',
			style: 'position:absolute;left:6px;top:198px;width:375px;height:19px;',
		},
					]
				},
				{
					title:'Розничные продажи',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись94',
			text: 'Розничные продажи',
			style: 'position:absolute;left:12px;top:6px;width:209px;height:25px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать оплату платежными картами',
			style: 'position:absolute;left:12px;top:48px;width:272px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать оплату банковскими кредитами',
			style: 'position:absolute;left:12px;top:72px;width:272px;height:19px;',
		},
					]
				},
				{
					title:'Себестоимость',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'В регламентированном учете',
			style: 'position:absolute;left:28px;top:124px;width:176px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'В управленческом учете',
			style: 'position:absolute;left:28px;top:100px;width:176px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись51',
			text: 'Вести учет себестоимости МПЗ по складам:',
			style: 'position:absolute;left:12px;top:76px;width:250px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРаздела18',
			text: 'Себестоимость',
			style: 'position:absolute;left:12px;top:6px;width:292px;height:30px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Тип цен плановой себестоимости номенклатуры:',
			style: 'position:absolute;left:12px;top:48px;width:260px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТипЦенПлановойСебестоимостиНоменклатуры',
			style: 'position:absolute;left:270px;top:48px;width:196px;height:19px;',
		},
					]
				},
				{
					title:'Способы распределения затрат',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьРаздела19',
			text: 'Способы распределения затрат',
			style: 'position:absolute;left:12px;top:6px;width:350px;height:30px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:12px;top:48px;width:528px;height:371px;',
			height: 371,width: 528,
			items:
			[
				{
					title:'Расширенная аналитика',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись65',
			text: 'Данные настройки используются в режиме расширенной аналитики учета и затрат.
Режим расширенной аналитики устанавливается в разделе "Режим учета затрат".',
			style: 'position:absolute;left:0px;top:0px;width:468px;height:60px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Изменять способы распределения затрат',
			style: 'position:absolute;left:0px;top:0px;width:244px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись67',
			text: 'В общем случае включать не следует. Подробнее см. справку',
			style: 'position:absolute;left:0px;top:25px;width:468px;height:17px;',
		},
					]
				},
				{
					title:'Традиционный режим',
				},
			]
		},
					]
				},
			]
		},
	]
});