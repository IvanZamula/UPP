﻿Ext.define('Справочники.НастройкиЗакрытияМесяца.ФормаВыбораУправляемаяСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var st = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код', 'Наименование'],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/НастройкиЗакрытияМесяца/НайтиПоСсылке/' + ссылка, }),
		});
		Ext.require(['Справочники.НастройкиЗакрытияМесяца.ФормаЭлемента'], function () {
			var win = Ext.create('Справочники.НастройкиЗакрытияМесяца.ФормаЭлемента', {});

			var form = win.down('form');
			count = st.getCount();
			if (count == 0)
			{
				var массивЗначений = строкаЗначений;
			}
			else
			{
				st.on('load', function ()
				{
					var массивЗначений = st.data.items[0].data;
				});
			};

			form.getForm().setValues(массивЗначений);

			if (win)
			{
				win.show();
				return win;
			}
		});
	}
});