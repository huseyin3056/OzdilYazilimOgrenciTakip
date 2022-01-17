﻿using DevExpress.XtraGrid;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.FiltreForms
{
    public partial class FiltreEditForm : BaseEditForm
    {

        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;

        public FiltreEditForm(params object[] prm)
        {
            InitializeComponent();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnyeni, btnGeriAl };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };

            DataLayoutControl = myDataLayoutControl;
            Bll = new FiltreBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Filtre;
            EventsLoad();

        }




        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;

            while (true)
            {
                if (BaseIslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new Filtre();
                    Id = BaseIslemTuru.IdOlustur(OldEntity);
                    txtKod.Text = ((FiltreBll)Bll).YeniKodVer(x => x.KartTuru == _filtreKartTuru);


                }

                else
                {
                    OldEntity = ((FiltreBll)Bll).Single(FilterFunctions.Filter<Filtre>(Id));
                    if (OldEntity == null)
                    {
                        BaseIslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }

                    NesneyiKontrollereBagla();

                }

                break;
            }

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Filtre)OldEntity;

            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.FilterString = entity.FiltreMetni;


        }


        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Filtre
            {
                Id = Id,
                Kod = txtKod.Text,
                FiltreAdi = txtFiltreAdi.Text,
                FiltreMetni = txtFiltreMetni.FilterString,
                KartTuru=_filtreKartTuru


            };
            ButtonEnabledDurumu();
        }


        protected override bool EntityInsert()
        {
            return ((FiltreBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru==_filtreKartTuru);

        }

        protected override bool EntityUpdate()
        {
            return ((FiltreBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);

        }

        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();


        }


        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnFarkliKaydet, btnSil, BaseIslemTuru, OldEntity, CurrentEntity);


        }


    }
}