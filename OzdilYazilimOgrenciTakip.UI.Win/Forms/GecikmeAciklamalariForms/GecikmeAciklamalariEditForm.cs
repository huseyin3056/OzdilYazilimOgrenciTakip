using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariEditForm : BaseEditForm
    {

        private readonly int _portfoyNo;


        public GecikmeAciklamalariEditForm(params object[] prm)
        {
            InitializeComponent();

            _portfoyNo = (int)prm[0];


            DataLayoutControl = myDataLayoutControl;
            Bll = new GecikmeAciklamalariBll(DataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Aciklama;
            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new GecikmeAciklamalariS() : ((GecikmeAciklamalariBll)Bll).Single(FilterFunctions.Filter<GecikmeAciklamalari>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((GecikmeAciklamalariBll)Bll).YeniKodVer(x => x.OdemeBilgileriId == _portfoyNo);
            txtAciklama.Focus();

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (GecikmeAciklamalariS)OldEntity;

            txtKod.Text = entity.Kod;
            txtKullaniciAdi.Text = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? AnaForm.KullaniciAdi : entity.KullaniciAdi;
            txtTarihSaat.DateTime = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? DateTime.Now : entity.TarihSaat;
            txtAciklama.Text = entity.Aciklama;

        }


        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new GecikmeAciklamalari
            {
                Id = Id,
                Kod = txtKod.Text,
                OdemeBilgileriId = _portfoyNo,
                KullaniciId = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? AnaForm.KullaniciId : 0,
                TarihSaat=txtTarihSaat.DateTime,
                Aciklama = txtAciklama.Text,


            };
            ButtonEnabledDurumu();
        }


        protected override bool EntityInsert()
        {
            return ((GecikmeAciklamalariBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.OdemeBilgileriId==_portfoyNo);

        }

        protected override bool EntityUpdate()
        {
            return ((GecikmeAciklamalariBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.OdemeBilgileriId == _portfoyNo);

        }


    }
}