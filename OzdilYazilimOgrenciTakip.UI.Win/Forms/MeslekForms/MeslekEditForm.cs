﻿using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.MeslekForms
{
    public partial class MeslekEditForm : BaseEditForm
    {
        public MeslekEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MeslekBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Meslek;

            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Meslek() : ((MeslekBll)Bll).Single(FilterFunctions.Filter<Meslek>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MeslekBll)Bll).YeniKodVer();
            txtMeslekAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Meslek)OldEntity;

            txtKod.Text = entity.Kod;
            txtMeslekAdi.Text = entity.MeslekAdi;

            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Meslek
            {
                Id = Id,
                Kod = txtKod.Text,
                MeslekAdi = txtMeslekAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }


    }
}