using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciEditForm : BaseEditForm
    {
        public OgrenciEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new OgrenciBll(myDataLayoutControl);
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            BaseKartTuru = KartTuru.Iletisim;

            EventsLoad();


        }


        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OgrenciS() : ((OgrenciBll)Bll).Single(FilterFunctions.Filter<Ogrenci>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OgrenciBll)Bll).YeniKodVer();
            txtTCKimlikNo.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OgrenciS)OldEntity;
            txtKod.Text = entity.Kod;
            txtTCKimlikNo.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.SoyAdi;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();
            txtTel.Text = entity.Telefon;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtKimlikSeri.Text = entity.KimlikSeri;
            txtKimlikSiraNo.Text = entity.KimlikSiraNo;
            txtKimlikIl.Id = entity.KimlikIlId;
            txtKimlikIl.Text = entity.KimlikIlAdi;
            txtKimlikIlce.Id = entity.KimlikIlceId;
            txtKimlikIlce.Text = entity.KimlikIlceAdi;
            txtKimlikMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtKimlikCiltNo.Text = entity.KimlikCiltNo;
            txtKimlikAileSiraNo.Text = entity.KimlikAileSiraNo;
            txtKimlikBireySiraNo.Text = entity.KimlikBireySiraNo;
            txtKimlikVerildigiYer.Text = entity.KimlikVerildigiYer;
            txtKimlikVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKimlikKayitNo.Text = entity.KimlikKayitNo;
            txtKimlikVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            imgResim.EditValue = entity.Resim;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Ogrenci
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTCKimlikNo.Text,
                Adi = txtAdi.Text,
                SoyAdi = txtSoyadi.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                Telefon=txtTel.Text,
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
  
                KimlikSeri = txtKimlikSeri.Text,
                KimlikSiraNo = txtKimlikSiraNo.Text,
                KimlikIlId = txtKimlikIl.Id,
                KimlikIlceId = txtKimlikIlce.Id,
                KimlikMahalleKoy = txtKimlikMahalleKoy.Text,
                KimlikCiltNo = txtKimlikCiltNo.Text,
                KimlikAileSiraNo = txtKimlikAileSiraNo.Text,
                KimlikBireySiraNo = txtKimlikBireySiraNo.Text,
                KimlikVerildigiYer = txtKimlikVerildigiYer.Text,
                KimlikVerilisNedeni = txtKimlikVerilisNedeni.Text,
                KimlikKayitNo = txtKimlikKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtKimlikVerilisTarihi.EditValue,
                Resim=(byte[])imgResim.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = tglDurum.IsOn,
                

            };

            ButtonEnabledDurumu();

        }

        protected override void TabloYukle()
        {

            tahakkukBilgileriTable.OwnerForm = this;
            tahakkukBilgileriTable.Yukle();

        }


        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtKimlikIl)
                    sec.Sec(txtKimlikIl);
                else if (sender == txtKimlikIlce)
                    sec.Sec(txtKimlikIlce, txtKimlikIl);

                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Ogrenci);

                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Ogrenci);

                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Ogrenci);

                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Ogrenci);

                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Ogrenci);

             
        }



        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtKimlikIl ) return;

                txtKimlikIl.ControlEnabledChange(txtKimlikIlce);      

        }


        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }
    }
}