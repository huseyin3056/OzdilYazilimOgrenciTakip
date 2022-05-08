using System;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.KasaForms
{
    public partial class KasaEditForm :BaseEditForm
    {
        public KasaEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KasaBll(myDataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Kasa;
            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new KasaS() : ((KasaBll)Bll).Single(FilterFunctions.Filter<Kasa>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KasaBll)Bll).YeniKodVer(x=>x.SubeId==AnaForm.SubeId&&x.DonemId==AnaForm.DonemId);
            txtKasaAdi.Focus();


        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KasaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtKasaAdi.Text = entity.KasaAdi;

            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;

            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;  
            
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kasa
            {
                Id = Id,
                Kod = txtKod.Text,
                KasaAdi = txtKasaAdi.Text,

                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,

                SubeId=AnaForm.SubeId,
                DonemId=AnaForm.DonemId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();


        }

        protected override bool EntityInsert()
        {
            return ((KasaBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }
        protected override bool EntityUpdate()
        {
            return ((KasaBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }


        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1,Common.Enums.KartTuru.Kasa);

              else  if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, Common.Enums.KartTuru.Kasa);


            }
        }

      


    }
}