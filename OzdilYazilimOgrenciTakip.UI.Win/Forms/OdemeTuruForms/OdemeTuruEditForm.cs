﻿using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruEditForm : BaseEditForm
    {
        public OdemeTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new OdemeTuruBll(myDataLayoutControl);
            txtOdemeTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OdemeTipi>());
            BaseKartTuru = KartTuru.OdemeTuru;

            EventsLoad();
        }



        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OdemeTuru() : ((OdemeTuruBll)Bll).Single(FilterFunctions.Filter<OdemeTuru>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OdemeTuruBll)Bll).YeniKodVer();
            txtOdemeTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OdemeTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtOdemeTuruAdi.Text = entity.OdemeTuruAdi;
            txtOdemeTipi.SelectedItem = entity.OdemeTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new OdemeTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                OdemeTuruAdi = txtOdemeTuruAdi.Text,
                OdemeTipi = txtOdemeTipi.Text.GetEnum<OdemeTipi>(),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }


    }
}