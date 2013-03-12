﻿Ext.define('Обработки.ПомощникНастройкиОбменаДанными.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:740px;height:424px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка обмена данными',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:399px;width:740px;height:25px;',
			items:
			[
				{
					text:'Далее',
				},
				'-',
				{
					text:'Назад',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:183px;top:0px;width:557px;height:399px;',
			height: 399,width: 557,
			items:
			[
				{
					title:'Главная',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьВыборДействия',
			text: 'Настройка обмена данными между информационными базами',
			style: 'position:absolute;left:6px;top:6px;width:546px;height:39px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеПользователя',
			text: 'Имя и пароль пользователя для подключения к инф. базе - приемнику',
			style: 'position:absolute;left:171px;top:170px;width:363px;height:15px;',
		},
					]
				},
				{
					title:'Возможность подключения ко второй информационной базе',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьТипНастройки',
			text: 'Передача данных между информационными базами',
			style: 'position:absolute;left:6px;top:6px;width:546px;height:39px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИнформацияОФайлеСНастройками',
			text: 'Укажите имя файла с сохраненными настройками обмена, который был выгружен при настройке в первой информационной базе:',
			style: 'position:absolute;left:6px;top:55px;width:544px;height:42px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:161px;top:111px;width:390px;height:19px;',
			height: 19,width: 390,
			items:
			[
				{
					title:'Подключение файловая ИБ',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКаталогИБ1',
			text: 'Каталог базы:
',
			style: 'position:absolute;left:0px;top:0px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КаталогИнформационнойБазыДляПодключения1',
			style: 'position:absolute;left:85px;top:0px;width:305px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСерверПредприятия1',
			text: 'Имя сервера:',
			style: 'position:absolute;left:0px;top:0px;width:79px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИмяИнформационнойБазы1',
			text: 'Инф. база:',
			style: 'position:absolute;left:202px;top:0px;width:64px;height:19px;',
		},
					]
				},
				{
					title:'Подключение серверная ИБ',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяСервераИнформационнойБазыДляПодключения1',
			style: 'position:absolute;left:84px;top:0px;width:112px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяИнформационнойБазыНаСервереДляПодключения1',
			style: 'position:absolute;left:269px;top:0px;width:120px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Аутентификация Windows',
			style: 'position:absolute;left:161px;top:189px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПользовательИнформационнойБазыДляПодключения1',
			style: 'position:absolute;left:246px;top:152px;width:112px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПарольИнформационнойБазыДляПодключения1',
			style: 'position:absolute;left:431px;top:152px;width:120px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ТестПодключения1',
			text: 'Проверить...',
			style: 'position:absolute;left:431px;top:189px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеПользователя1',
			text: 'Требуется продолжение настройки обменов на стороне инф. базы - приемника',
			style: 'position:absolute;left:25px;top:237px;width:417px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеПользователя2',
			text: 'НЕ требуется продолжение настройки обменов на стороне инф. базы - приемника',
			style: 'position:absolute;left:25px;top:65px;width:425px;height:15px;',
		},
					]
				},
				{
					title:'Создание нового обмена',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьТипИнформационнойБазыДляОбмена',
			text: 'Укажите тип информационной базы-приемника:',
			style: 'position:absolute;left:6px;top:47px;width:250px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименованиеИнформационнойБазы',
			text: 'Укажите ЛЮБОЕ удобное для вас наименование информационной базы-приемника:',
			style: 'position:absolute;left:6px;top:94px;width:435px;height:18px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НаименованиеИнформационнойБазыДляОбмена',
			style: 'position:absolute;left:28px;top:117px;width:413px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:141px;width:546px;height:253px;',
			height: 253,width: 546,
			items:
			[
				{
					title:'Настройки обмена по организации',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьПояснениеКОбменуПоОрганизациям',
			text: 'Укажите параметры, информация по которым должна передаваться в информационную базу-приемник:',
			style: 'position:absolute;left:0px;top:0px;width:546px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:23px;width:546px;height:230px;',
			height: 230,width: 546,
			items:
			[
				{
					title:'Организации',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:34px;width:538px;height:176px;',
			height: 176,width: 538,
			columns:
			[
				{
					text:'Организация',
					width:'300',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:538px;height:24px;',
			items:
			[
				{
					text:'Выбрать все',
				},
				{
					text:'Отменить все',
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
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьВыборДействия1',
			text: 'Подключение к информационной базе-приемнику',
			style: 'position:absolute;left:6px;top:6px;width:545px;height:39px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВыборДействия5',
			text: 'Выбор файла настроек обмена',
			style: 'position:absolute;left:6px;top:6px;width:544px;height:39px;',
		},
					]
				},
				{
					title:'Ответные пакеты второй информационной базы',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьИмяФайлаССохраненнымиНастройкамиДляНастройкиОбмена',
			text: 'Имя файла с сохраненными настройками обмена для информационной базы - приемника (Этот файл нужно использовать для продолжения настройки обмена в информационной базе - приемнике):',
			style: 'position:absolute;left:6px;top:98px;width:546px;height:50px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВыборДействия4',
			text: 'Сопоставление справочников и документов в информационных базах',
			style: 'position:absolute;left:6px;top:6px;width:543px;height:39px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипНастройки2',
			text: 'Настройка обмена данными успешно завершена',
			style: 'position:absolute;left:6px;top:6px;width:546px;height:39px;',
		},
					]
				},
				{
					title:'Редактирование существующего обмена',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяФайлаНастроекОбменаПервойИнформационнойБазы',
			style: 'position:absolute;left:32px;top:101px;width:452px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВыборДействия3',
			text: 'Взаимодействие информационных баз при обмене',
			style: 'position:absolute;left:6px;top:6px;width:546px;height:39px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеКСопоставлению',
			text: 'При сопоставление в фоновом режиме при каждом обмене данными будет передаваться дополнительная информация о сопоставлении объектов. Рекомендуется для информационных баз с большим объемом данных.',
			style: 'position:absolute;left:23px;top:115px;width:526px;height:40px;',
		},
					]
				},
				{
					title:'Основные параметры настройки обмена данными',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:13px;top:206px;width:539px;height:160px;',
			height: 160,width: 539,
			items:
			[
				{
					title:'Файловый',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКаталогОбменаИнформацией',
			text: 'Каталог:',
			style: 'position:absolute;left:5px;top:0px;width:78px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КаталогОбменаИнформацией',
			style: 'position:absolute;left:87px;top:0px;width:452px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьFTPАдресОбмена',
			text: 'Адрес:',
			style: 'position:absolute;left:6px;top:0px;width:79px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПользовательFTPСоединения',
			text: 'Пользователь:',
			style: 'position:absolute;left:6px;top:24px;width:79px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПарольFTPСоединения',
			text: 'Пароль:',
			style: 'position:absolute;left:372px;top:24px;width:42px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьМаксимальныйРазмерПакетаЧерезFTP',
			text: 'Максимальный пакет:',
			style: 'position:absolute;left:177px;top:48px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипИнформационнойБазыДляПодключения',
			text: 'Тип информационной базы:',
			style: 'position:absolute;left:6px;top:24px;width:144px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПользовательДляПодключения',
			text: 'Пользователь:',
			style: 'position:absolute;left:6px;top:98px;width:144px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПароль',
			text: 'Пароль:',
			style: 'position:absolute;left:339px;top:98px;width:48px;height:19px;',
		},
					]
				},
				{
					title:'FTPОбмен',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'FTPАдресОбмена',
			style: 'position:absolute;left:87px;top:0px;width:278px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'Проверить',
			text: 'Проверить...',
			style: 'position:absolute;left:419px;top:48px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПользовательFTPСоединения',
			style: 'position:absolute;left:87px;top:24px;width:278px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПарольFTPСоединения',
			style: 'position:absolute;left:419px;top:24px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПортFTPСоединения',
			style: 'position:absolute;left:419px;top:0px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Пассивное FTP соединение',
			style: 'position:absolute;left:6px;top:48px;width:165px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP1',
			style: 'position:absolute;left:302px;top:48px;width:95px;height:19px;',
		},
					]
				},
				{
					title:'Обмен через COM',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:49px;width:533px;height:19px;',
			height: 19,width: 533,
			items:
			[
				{
					title:'Подключение файловая ИБ',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКаталогИБ',
			text: 'Каталог базы:
',
			style: 'position:absolute;left:0px;top:0px;width:143px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КаталогИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:148px;top:0px;width:385px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСерверПредприятия',
			text: 'Сервер 1С:Предприятия:',
			style: 'position:absolute;left:0px;top:0px;width:142px;height:19px;',
		},
					]
				},
				{
					title:'Подключение серверная ИБ',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяСервераИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:148px;top:0px;width:180px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИмяИнформационнойБазы',
			text: 'Инф. база:',
			style: 'position:absolute;left:331px;top:0px;width:64px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяИнформационнойБазыНаСервереДляПодключения',
			style: 'position:absolute;left:398px;top:0px;width:135px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Аутентификация Windows',
			style: 'position:absolute;left:6px;top:74px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПользовательИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:154px;top:98px;width:178px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПарольИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:403px;top:98px;width:136px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ТестПодключения',
			text: 'Проверить...',
			style: 'position:absolute;left:403px;top:74px;width:136px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИмяФайлаПравилДляВыгрузкиДанных2',
			text: 'Укажите параметры подключения к информационной базе для настройки обмена:',
			style: 'position:absolute;left:6px;top:0px;width:435px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеКПроцедуреОбмена',
			text: 'Надпись пояснение к процедуре обмена',
			style: 'position:absolute;left:224px;top:121px;width:328px;height:80px;',
		},
		{
			xtype: 'button',
			name: 'ДополнительныеНастройкиОбменаДанными',
			text: 'Дополнительно ...',
			style: 'position:absolute;left:442px;top:375px;width:110px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВыборДействия2',
			text: 'Параметры обмена и возможные ограничения',
			style: 'position:absolute;left:6px;top:6px;width:546px;height:39px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеОбменВДвухнаправления',
			text: 'Изменения, которые произошли в вашей информационной базе будут отправлены в информационную базу-приемник, а изменения которые в произошли в приемнике будут направлены в вашу информационную базу',
			style: 'position:absolute;left:255px;top:68px;width:297px;height:80px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеКСопоставлению1',
			text: 'Данная операция может потребовать значительного времени. Рекомендуется для информационных баз с маленьким объемом данных',
			style: 'position:absolute;left:23px;top:66px;width:526px;height:28px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипНастройки2',
			text: 'Первый этап настройки успешно завершен',
			style: 'position:absolute;left:6px;top:6px;width:546px;height:39px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:50px;width:210px;height:150px;',
			height: 150,width: 210,
			items:
			[
				{
					title:'Страница каталог',
					items:
					[
					]
				},
				{
					title:'Страница FTP',
				},
				{
					title:'Страница подключение',
				},
			]
		},
					]
				},
				{
					title:'Настройки знакомства информационных баз',
					items:
					[
		{
			xtype: 'button',
			name: 'ДополнитеьльныеНастройкиФоновогоЗнакомства',
			text: 'Дополнительно ...',
			style: 'position:absolute;left:427px;top:372px;width:122px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПояснениеОбменВОдномНаправлении',
			text: 'Изменения, которые произошли в вашей информационной базе будут отправлены в информационную базу-приемник',
			style: 'position:absolute;left:246px;top:235px;width:306px;height:56px;',
		},
					]
				},
				{
					title:'Итоговая страница завершения обмена',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСозданнаяНастройкаCOM1',
			text: 'Настройка для обмена данными:',
			style: 'position:absolute;left:6px;top:205px;width:173px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СозданнаяНастройкаОбмена1',
			style: 'position:absolute;left:36px;top:228px;width:390px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'Выполнить1',
			text: 'Выполнить обмен',
			style: 'position:absolute;left:430px;top:228px;width:122px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяФайлаНастроекОбменаПервойИнформационнойБазы1',
			style: 'position:absolute;left:36px;top:154px;width:516px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись121',
			text: 'Как определить параметры подключения к инф. базе - приемнику',
			style: 'position:absolute;left:194px;top:130px;width:339px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипИнформационнойБазыДляПодключения1',
			text: 'Тип инф. базы:',
			style: 'position:absolute;left:161px;top:86px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВажнопервыйЭтап',
			text: 'Для функционирования обмена необходимо выполнить настройки в информационной базе-приемнике',
			style: 'position:absolute;left:32px;top:48px;width:520px;height:36px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОбменовПоРасписанию',
			text: 'Обмен данными по расписанию:',
			style: 'position:absolute;left:6px;top:286px;width:188px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДобавлениеНастройкиВСуществующееРасписание',
			text: 'Добавить настройку в существующее расписание',
			style: 'position:absolute;left:36px;top:310px;width:281px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДобавлениеНастройкиВНовоеРасписание',
			text: 'Создать новое расписание для настройки обмена',
			style: 'position:absolute;left:36px;top:335px;width:281px;height:19px;',
		},
					]
				},
				{
					title:'Итоговая страница завершения обмена COM',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСозданнаяНастройкаCOM',
			text: 'Настройка для обмена данными:',
			style: 'position:absolute;left:6px;top:50px;width:173px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СозданнаяНастройкаОбмена',
			style: 'position:absolute;left:39px;top:73px;width:385px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'Выполнить',
			text: 'Выполнить обмен',
			style: 'position:absolute;left:430px;top:73px;width:122px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОбменовПоРасписанию1',
			text: 'Обмен данными по расписанию:',
			style: 'position:absolute;left:6px;top:126px;width:188px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДобавлениеНастройкиВСуществующееРасписание1',
			text: 'Добавить настройку в существующее расписание',
			style: 'position:absolute;left:36px;top:150px;width:281px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДобавлениеНастройкиВНовоеРасписание1',
			text: 'Создать новое расписание для настройки обмена',
			style: 'position:absolute;left:36px;top:175px;width:281px;height:19px;',
		},
					]
				},
				{
					title:'Параметры обмена документами',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьПараметрыОбменаДокументами',
			text: 'Параметры обмена данными',
			style: 'position:absolute;left:6px;top:6px;width:545px;height:39px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаНачалаВыгрузкиДокументов',
			text: 'Укажите начальную дату для выгрузки документов:',
			style: 'position:absolute;left:6px;top:50px;width:270px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНачалаВыгрузкиДокументов',
			style: 'position:absolute;left:282px;top:50px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПрефиксДляЗагружаемыхДокументов',
			style: 'position:absolute;left:376px;top:73px;width:64px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПрефиксТекущейИБ',
			text: 'Префикс для загрузки документов в текущую информационную базу:',
			style: 'position:absolute;left:6px;top:97px;width:366px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПрефиксДляДокументовВТекущейИБ',
			style: 'position:absolute;left:376px;top:97px;width:64px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПрефиксТекущейБазыПриемника',
			text: 'Префикс для загрузки документов в информационную базу приемник:',
			style: 'position:absolute;left:6px;top:73px;width:366px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:120px;width:545px;height:273px;',
			height: 273,width: 545,
			items:
			[
				{
					title:'Настройки выгрузки',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:33px;width:531px;height:214px;',
			height: 214,width: 531,
			columns:
			[
				{
					text:'Выгрузка',
					width:'54',
				},
				{
					text:'Наименование объекта',
					width:'185',
				},
				{
					text:'Настройка выгрузки',
					width:'157',
				},
				{
					text:'Выгружать',
					width:'44',
				},
				{
					text:'Выгружать по ссылке',
					width:'74',
				},
				{
					text:'Код правила выгрузки',
					width:'92',
				},
				{
					text:'Код правила обмена',
					width:'100',
				},
				{
					text:'Настройка не поддерживается',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:531px;height:24px;',
			items:
			[
				'-',
				{
					text:'Действие4',
				},
				{
					text:'Изменить настройку',
				},
				{
					text:'Действие2',
				},
			]
		},
					]
				},
				{
					title:'Сопоставление объектов',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:531px;height:24px;',
			items:
			[
				{
					text:'Действие2',
				},
				{
					text:'Действие4',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:35px;width:531px;height:212px;',
			height: 212,width: 531,
			columns:
			[
				{
					text:'Выгрузка',
					width:'60',
				},
				{
					text:'Наименование объекта',
					width:'130',
				},
				{
					text:'Настройка сопоставления',
					width:'140',
				},
				{
					text:'Описание',
					width:'130',
				},
				{
					text:'Имя настройки для алгоритма',
					width:'100',
				},
				{
					text:'Настройка не поддерживается',
					width:'100',
				},
				{
					text:'Вариант поиска не поддерживается',
					width:'100',
				},
				{
					text:'Код правила обмена',
					width:'100',
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
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:181px;height:399px;',
			height: 399,width: 181,
			items:
			[
				{
					title:'Страница настройки',
					items:
					[
					]
				},
				{
					title:'Страница готово',
				},
			]
		},
	]
});