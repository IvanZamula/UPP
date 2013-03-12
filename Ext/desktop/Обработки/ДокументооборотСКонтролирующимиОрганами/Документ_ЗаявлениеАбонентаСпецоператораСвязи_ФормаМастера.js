﻿Ext.define('Обработки.ДокументооборотСКонтролирующимиОрганами.Документ_ЗаявлениеАбонентаСпецоператораСвязи_ФормаМастера',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:668px;height:485px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Мастер заполнения заявления на подключение',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:460px;',
			height: 460,width: 668,
			items:
			[
				{
					title:'Старт',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Следуя подсказкам мастера, создайте и отправьте заявление на подключение к системе электронного документооборота с контролирующими органами.

На основании этого заявления будет создан и зарегистрирован сертификат ключа электронно-цифровой подписи и подключен защищенный документооборот с контролирующими органами (ФНС, ПФР, Росстат и ФСС), после чего вы сможете приступить к отправке отчетности и обмену прочими видами документов.

Для того чтобы приступить к настройке, нажмите кнопку "Далее >"',
			style: 'position:absolute;left:8px;top:140px;width:652px;height:152px;',
		},
		{
			xtype: 'label',
			name: 'Надпись37',
			text: 'Мастер заполнения заявления на подключение к электронному документообороту',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'Надпись59',
			text: 'Вас приветствует мастер заполнения заявления на подключение!',
			style: 'position:absolute;left:8px;top:92px;width:532px;height:20px;',
		},
					]
				},
				{
					title:'Номер основной поставки',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись60',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись61',
			text: 'Шаг 1 из 8. Регистрационный номер программы "1С:Предприятия 8"',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НомерОсновнойПоставки1с',
			style: 'position:absolute;left:160px;top:164px;width:164px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись62',
			text: 'Номер основной поставки:',
			style: 'position:absolute;left:8px;top:164px;width:144px;height:20px;',
		},
		{
			xtype: 'label',
			name: 'Надпись63',
			text: 'Укажите регистрационный номер программы "1С:Предприятия 8".

Обратите внимание! Наличие договора информационно-технологического сопровождения (1С:ИТС) уровня ПРОФ позволяет сдавать отчетность для одного юридического лица или индивидуального предпринимателя без дополнительной оплаты.',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:84px;',
		},
		{
			xtype: 'label',
			name: 'ОткрытьСтраницуИТС',
			text: 'Подробнее об ИТС...',
			style: 'position:absolute;left:160px;top:192px;width:164px;height:16px;',
		},
					]
				},
				{
					title:'Выбор УЦ',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись47',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись48',
			text: 'Шаг 2 из 8. Выбор удостоверяющего центра и специализированного оператора связи',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'Надпись46',
			text: 'Удостоверяющий центр:',
			style: 'position:absolute;left:8px;top:140px;width:128px;height:20px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СпецоператорИУЦ',
			style: 'position:absolute;left:148px;top:140px;width:508px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ОткрытьСтраницуУЦ',
			text: 'Подробнее об услугах на сайте удостоверяющего центра...',
			style: 'position:absolute;left:148px;top:168px;width:508px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'Надпись52',
			text: 'Выберите организацию-посредника, которая будет осуществлять функции удостоверяющего центра, издающего сертификат ключа электронно-цифровой подписи, и осуществлять поддержку электронного документооборота',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:48px;',
		},
					]
				},
				{
					title:'Используемый криптопровайдер',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись39',
			text: 'Шаг 3 из 8. Выбор криптопровайдера',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'СкачатьVipNetCSP',
			text: 'Сайт ОАО «ИнфоТеКС» - разработчика криптопровайдера VipNet CSP',
			style: 'position:absolute;left:32px;top:212px;width:528px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'СкачатьCryptoProCSP',
			text: 'Сайт компании КРИПТО-ПРО - разработчика криптопровайдера  CryptoPro CSP',
			style: 'position:absolute;left:32px;top:268px;width:532px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРекомендация',
			text: '',
			style: 'position:absolute;left:140px;top:352px;width:520px;height:93px;',
		},
		{
			xtype: 'label',
			name: 'Надпись53',
			text: 'Выберите криптопровайдер (средство криптографической защиты информации), используемый для защиты и обеспечения юридической значимости передаваемой информации. Более подробную информацию, например, об условиях приобретения и использования криптопровайдера, можно получить на сайте разработчика',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:76px;',
		},
		{
			xtype: 'label',
			name: 'Надпись43',
			text: 'Справочная информация',
			style: 'position:absolute;left:16px;top:328px;width:644px;height:16px;',
		},
					]
				},
				{
					title:'Соглашение о присоединении к регламенту УЦ',
					items:
					[
		{
			xtype: 'button',
			name: 'ВывестиСоглашениеНапечать',
			text: 'Печать',
			style: 'position:absolute;left:588px;top:431px;width:72px;height:20px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Подтверждаю, что принимаю условия соглашения о присоединении к регламенту удостоверяющего центра',
			style: 'position:absolute;left:8px;top:431px;width:568px;height:20px;',
		},
		{
			xtype: 'label',
			name: 'Надпись30',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись38',
			text: 'Шаг 4 из 8. Соглашение о предоставлении услуг',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'Надпись54',
			text: 'Ознакомьтесь с соглашением о присоединении к регламенту удостоверяющего центра',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:20px;',
		},
					]
				},
				{
					title:'Реквизиты',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись31',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись36',
			text: 'Шаг 5 из 8. Выбор организации - отправителя отчетности',
			style: 'position:absolute;left:8px;top:5px;width:656px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:116px;width:89px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:140px;top:116px;width:384px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименованиеПолное',
			text: 'Полное наименование:',
			style: 'position:absolute;left:8px;top:204px;width:128px;height:15px;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			name: 'НаименованиеПолное',
			style: 'position:absolute;left:140px;top:204px;width:520px;height:38px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКраткоеНаименование',
			text: 'Краткое наименование:',
			style: 'position:absolute;left:8px;top:180px;width:128px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КраткоеНаименование',
			style: 'position:absolute;left:140px;top:180px;width:520px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИНН',
			text: 'ИНН:',
			style: 'position:absolute;left:8px;top:248px;width:54px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИНН',
			style: 'position:absolute;left:140px;top:248px;width:110px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКПП',
			text: 'КПП:',
			style: 'position:absolute;left:8px;top:276px;width:54px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КПП',
			style: 'position:absolute;left:140px;top:276px;width:110px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРегистрационныйНомерПФР',
			text: 'Регистрационный номер ПФР:',
			style: 'position:absolute;left:376px;top:248px;width:164px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'РегистрационныйНомерПФР',
			style: 'position:absolute;left:548px;top:248px;width:110px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРегистрационныйНомерФСС',
			text: 'Регистрационный номер ФСС:',
			style: 'position:absolute;left:376px;top:276px;width:167px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'РегистрационныйНомерФСС',
			style: 'position:absolute;left:548px;top:276px;width:110px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьЮрАдрес',
			text: 'Юридический адрес:',
			style: 'position:absolute;left:8px;top:364px;width:128px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЮрАдрес',
			style: 'position:absolute;left:140px;top:364px;width:520px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьФактАдрес',
			text: 'Фактический адрес:',
			style: 'position:absolute;left:8px;top:388px;width:128px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ФактАдрес',
			style: 'position:absolute;left:140px;top:388px;width:520px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьЭлектАдрес',
			text: 'Электронная почта:',
			style: 'position:absolute;left:8px;top:436px;width:112px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЭлектАдрес',
			style: 'position:absolute;left:140px;top:436px;width:160px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТелефон',
			text: 'Телефон:',
			style: 'position:absolute;left:8px;top:412px;width:72px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Телефон',
			style: 'position:absolute;left:140px;top:412px;width:160px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТелефонМобильный',
			text: 'Дополнительный телефон:',
			style: 'position:absolute;left:324px;top:412px;width:163px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТелефонМобильный',
			style: 'position:absolute;left:504px;top:412px;width:156px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Крупнейшим налогоплательщиком',
			style: 'position:absolute;left:140px;top:300px;width:200px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: ' Обособленным подразделением',
			style: 'position:absolute;left:140px;top:320px;width:193px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименованиеПолное1',
			text: 'Организация является:',
			style: 'position:absolute;left:8px;top:300px;width:124px;height:15px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаОбновитьСведенияОбОрганизации',
			text: 'Обновить сведения',
			style: 'position:absolute;left:532px;top:116px;width:128px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись55',
			text: 'Выберите организацию, по которой предполагается осуществлять документооборот (сдавать отчетность), проверьте ее реквизиты и контактную информацию',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:40px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДополнительныйКодФСС',
			text: 'Дополнительный номер ФСС:',
			style: 'position:absolute;left:376px;top:300px;width:167px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДополнительныйКодФСС',
			style: 'position:absolute;left:548px;top:300px;width:110px;height:19px;',
		},
					]
				},
				{
					title:'',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Сотрудник',
			style: 'position:absolute;left:264px;top:160px;width:396px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись20',
			text: 'Вид документа:',
			style: 'position:absolute;left:8px;top:327px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДокументВидСотрудника',
			style: 'position:absolute;left:116px;top:327px;width:544px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись21',
			text: 'Серия:',
			style: 'position:absolute;left:8px;top:352px;width:44px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДокументСерияСотрудника',
			style: 'position:absolute;left:116px;top:353px;width:140px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись22',
			text: 'Номер:',
			style: 'position:absolute;left:264px;top:352px;width:40px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДокументНомерСотрудника',
			style: 'position:absolute;left:304px;top:353px;width:140px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись23',
			text: 'Дата выдачи:',
			style: 'position:absolute;left:448px;top:353px;width:72px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДокументДатаВыдачиСотрудника',
			style: 'position:absolute;left:520px;top:353px;width:140px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись24',
			text: 'Кем выдан :',
			style: 'position:absolute;left:8px;top:379px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДокументКемВыданСотрудника',
			style: 'position:absolute;left:116px;top:379px;width:544px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПодразделение2',
			text: 'Подразделение:',
			style: 'position:absolute;left:344px;top:270px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПодразделениеСотрудника',
			style: 'position:absolute;left:444px;top:269px;width:216px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДолжность2',
			text: 'Должность:',
			style: 'position:absolute;left:8px;top:269px;width:68px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДолжностьСотрудника',
			style: 'position:absolute;left:116px;top:269px;width:188px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Фамилия',
			style: 'position:absolute;left:116px;top:211px;width:140px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Имя',
			style: 'position:absolute;left:300px;top:211px;width:108px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Отчество',
			style: 'position:absolute;left:476px;top:211px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись33',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись40',
			text: 'Шаг 6 из 8. Выбор сотрудника - владельца ЭЦП',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДолжность3',
			text: 'Фамилия:',
			style: 'position:absolute;left:8px;top:211px;width:84px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДолжность4',
			text: 'Имя:',
			style: 'position:absolute;left:264px;top:211px;width:28px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДолжность5',
			text: 'Отчество:',
			style: 'position:absolute;left:416px;top:211px;width:56px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДолжность6',
			text: 'Сотрудник:',
			style: 'position:absolute;left:8px;top:116px;width:84px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'Надпись56',
			text: 'Укажите сведения о сотруднике организации, на имя которого будет издан сертификат ключа электронно-цифровой подписи',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:40px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаВызоваДанныхФИО',
			text: 'Подробнее...',
			style: 'position:absolute;left:584px;top:211px;width:76px;height:19px;',
		},
					]
				},
				{
					title:'Направления',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:140px;width:652px;height:312px;',
			height: 312,width: 652,
			columns:
			[
				{
					text:'N',
					width:'28',
				},
				{
					text:'Тип получателя',
					width:'100',
				},
				{
					text:'Код получателя',
					width:'100',
				},
				{
					text:'КПП',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:115px;width:652px;height:24px;',
			items:
			[
				{
					text:'Добавить',
				},
				{
					text:'Изменить',
				},
				{
					text:'Востановить',
				},
				{
					text:'Удалить',
				},
				'-',
				{
					text:'Скопировать',
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись34',
			text: ' ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись41',
			text: 'Шаг 7 из 8. Сведения о контролирующих органах',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'Надпись57',
			text: 'Укажите все контролирующие органы, с которыми будет осуществляться документооборот',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:24px;',
		},
					]
				},
				{
					title:'Подтверждение',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись35',
			text: '   ',
			style: 'position:absolute;left:0px;top:0px;width:668px;height:60px;',
		},
		{
			xtype: 'label',
			name: 'Надпись42',
			text: 'Шаг 8 из 8. Отправка заявления',
			style: 'position:absolute;left:8px;top:5px;width:652px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'Надпись51',
			text: 'Выберите дальнейшее действие:',
			style: 'position:absolute;left:8px;top:132px;width:168px;height:20px;',
		},
		{
			xtype: 'label',
			name: 'Надпись58',
			text: 'Заявление на подключение сформировано. Его необходимо отправить на сервер удостоверяющего центра для обработки и создания учетной записи электронного документооборота',
			style: 'position:absolute;left:8px;top:68px;width:652px;height:56px;',
		},
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:460px;width:668px;height:25px;',
			items:
			[
				'-',
				{
					text:'< Назад',
				},
				{
					text:'Отмена',
				},
				{
					text:'Далее >',
				},
			]
		},
	]
});