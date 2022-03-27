﻿using System;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show.Interfaces;

namespace OzdilYazilimOgrenciTakip.UI.Win.Show
{


    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {

        public long ShowDialogEditForm(KartTuru kartTuru, long id)
        {
            if (!GeneralFunctions.EditFormYetkiKontrolu(id, kartTuru)) return 0;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static long ShowDialogEditForm(KartTuru kartTuru, long id, params object[] prm)
        {
            if (!GeneralFunctions.EditFormYetkiKontrolu(id, kartTuru)) return 0;
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static long ShowDialogEditForm( long id, params object[] prm)
        {
            
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static void ShowDialogEditForm(long? id, params object[] prm)
        {

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();

            }
        }

        public static bool ShowDialogEditForm(params object[] prm)
        {

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                return frm.DialogResult == System.Windows.Forms.DialogResult.OK;
            }
        }

        public static bool ShowDialogEditForm(KartTuru kartTuru, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return false;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return frm.DialogResult == System.Windows.Forms.DialogResult.OK;
            }
        }

        public static void ShowDialogEditForm(KartTuru kartTuru)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return  ;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = IslemTuru.EntityUpdate;
                frm.Yukle();
                frm.ShowDialog();

            }
        }

        public static void ShowDialogEditForm()
        {

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
               
                frm.Yukle();
                frm.ShowDialog();

            }
        }

        public static bool ShowDialogEditForm(IslemTuru islemTuru, params object[] prm)
        {

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm))
            {
                frm.BaseIslemTuru = islemTuru;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak;
            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();

                return (T)frm.ReturnEntity();

            }
        }



    }
}
