using DevExpress.XtraEditors.Controls;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.MakbuzForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Base;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class TahsilatRaporu : BaseRapor
    {
        public TahsilatRaporu()
        {
            InitializeComponent();

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnBelgeHareketleri };

        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Odemeler = txtOdemeler;
            BelgeDurumlari = txtBelgeDurumlari;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;
            IlkTarih = txtIlkTarih;
            SonTarih = txtSonTarih;


            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            OdemeTurleriYukle();
            BelgeDurumuYukle();
            txtIlkTarih.DateTime = System.DateTime.Now.Date;
            txtSonTarih.DateTime = System.DateTime.Now.Date;
            RaporTuru = KartTuru.TahsilatRaporu;



        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var odemeler = txtOdemeler.CheckedComboBoxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtKayitDurumu.CheckedComboBoxList<IptalDurumu>();
            var belgeDurumlari = txtBelgeDurumlari.CheckedComboBoxList<BelgeDurumu>();

            using (var bll = new TahsilatRaporuBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                  subeler.Contains(x.OdemeBilgileri.Tahakkuk.SubeId) &&
                  odemeler.Contains(x.OdemeBilgileri.OdemeTipi) &&
                  kayitSekli.Contains(x.OdemeBilgileri.Tahakkuk.KayitSekli) &&
                  kayitDurumu.Contains(x.OdemeBilgileri.Tahakkuk.KayitDurumu) && iptalDurumu.Contains(x.OdemeBilgileri.Tahakkuk.Durum
                  ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                  belgeDurumlari.Contains(x.BelgeDurumu)&&
                  x.Makbuz.Tarih>=txtIlkTarih.DateTime.Date && x.Makbuz.Tarih<=txtSonTarih.DateTime.Date&&
                  x.OdemeBilgileri.Tahakkuk.DonemId == AnaForm.DonemId);


                base.Listele();
            }

        }


        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<TahsilatRaporuL>();
            if (entity == null) return;
            ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.MakbuzId,entity.MakbuzTuru,entity.MakbuzHesapTuru, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);

        }

        protected override void BelgeHareketleri()
        {
            var entity = Tablo.GetRow<TahsilatRaporuL>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.PortfoyNo);

        }

        protected override void BelgeDurumuYukle()
        {

            var enums = Enum.GetValues(typeof(BelgeDurumu));

            foreach (BelgeDurumu entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = entity.ToName(),
                    Value = entity
                };

                if(entity==BelgeDurumu.AvukatYoluylaTahsilEtme 
                    || entity==BelgeDurumu.KismiAvukatYoluylaTahsilEtme
                    || entity==BelgeDurumu.BlokeCozumu
                    || entity==BelgeDurumu.MahsupEtme
                    || entity==BelgeDurumu.OdenmisOlarakIsaretleme
                    || entity==BelgeDurumu.TahsilEtmeBanka
                    ||entity==BelgeDurumu.TahsilEtmeKasa
                    || entity==BelgeDurumu.BankaYoluylaTahsilEtme
                    || entity==BelgeDurumu.KismiTahsilEdildi)

                BelgeDurumlari.Properties.Items.Add(item);
            }

        }


    }
}