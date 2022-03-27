using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Linq;
using GeneralFunctions = OzdilYazilimOgrenciTakip.UI.Win.Functions.GeneralFunctions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil.RenkBedenSiparis
{
    public partial class RenkBedenSiparisEditForm : BaseEditForm
    {
        public RenkBedenSiparisEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SiparisBll(myDataLayoutControl);

            txtSiparisTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SiparisTuru>());
            txtKur.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Kur>());

            BaseKartTuru = KartTuru.Siparis;
            EventsLoad();

            HideItems = new BarItem[] { btnyeni };
            ShowItems = new BarItem[] { btnYazdir };


        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SiparisS() : ((SiparisBll)Bll).Single(FilterFunctions.Filter<Siparis>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SiparisBll)Bll).YeniKodVer();
            txtAciklama.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SiparisS)OldEntity;

            txtMusSiparisNo.Text = entity.MusteriSiparisNo;
            txtKod.Text = entity.Kod;

            txtSiparisTarihi.DateTime = entity.SiparisTarihi;
            txtTeslimatTarihi.DateTime = entity.TeslimatTarihi;

            txtBeden.Id = entity.BedenId;
            txtBeden.Text = entity.BedenAdi;

            txtMusteri.Id = entity.MusteriId;
            txtMusteri.Text = entity.MusteriAdi;

            txtUrun.Id = entity.UrunId;
            txtUrun.Text = entity.UrunAdi;

            txtSiparisTuru.SelectedItem = entity.SiparisTuru.ToName();
            txtKur.SelectedItem = entity.Kur.ToName();


            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;



        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Siparis
            {
                Id = Id,
                Kod = txtKod.Text,
                MusteriSiparisNo = txtMusSiparisNo.Text,

                SiparisTarihi = txtSiparisTarihi.DateTime.Date,
                TeslimatTarihi = txtTeslimatTarihi.DateTime.Date,

                BedenId = System.Convert.ToInt64(txtBeden.Id),
                MusteriId = System.Convert.ToInt64(txtMusteri.Id),
                UrunId = System.Convert.ToInt64(txtUrun.Id),
                Aciklama = txtAciklama.Text,
                SiparisTuru = txtSiparisTuru.Text.GetEnum<SiparisTuru>(),
                Kur=txtKur.Text.GetEnum<Kur>(),
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnyeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, renkBedenSiparisBilgileriTable.TableValueChanged);

        }

        protected override bool EntityInsert()
        {
            if (renkBedenSiparisBilgileriTable.HataliGiris()) return false;

            return ((SiparisBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && renkBedenSiparisBilgileriTable.Kaydet();

        }
        protected override bool EntityUpdate()
        {
            if (renkBedenSiparisBilgileriTable.HataliGiris()) return false;
            return ((SiparisBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && renkBedenSiparisBilgileriTable.Kaydet();

        }


        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())

                if (sender == txtBeden)
                    sec.Sec(txtBeden);

                else if (sender == txtMusteri)
                    sec.Sec(txtMusteri);

                else if (sender == txtUrun)
                {
                    sec.Sec(txtUrun);


                }


        }

        protected override void TabloYukle()
        {

            renkBedenSiparisBilgileriTable.OwnerForm = this;
            renkBedenSiparisBilgileriTable.Yukle();


        }

        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!(sender is ButtonEdit)) return;

            if (sender == txtUrun)
            {
                using (UrunBll bll = new UrunBll())
                {
                    var entityUrun = (Urun)(bll.Single(x => x.Id == txtUrun.Id));
                    if (entityUrun == null) return;
                    myPictureEdit1.EditValue = entityUrun.Resim;
                }

            }

            GuncelNesneOlustur();

        }

        protected override void Yazdir()
        {

            var siparisBilgileri = ((SiparisBll)Bll).SingleDetail(x => x.Id == Id);
            var renkBedenSiparisBilgileri = renkBedenSiparisBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<RenkBedenSiparisBilgileriR>();

            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, true, RaporBolumTuru.SiparisRaporlari, siparisBilgileri,renkBedenSiparisBilgileri);
        }


    }
}
