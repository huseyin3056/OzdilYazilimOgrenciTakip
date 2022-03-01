using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms;
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
    public partial class OdemesiGecikenAlacaklarRaporu : BaseRapor
    {
        public OdemesiGecikenAlacaklarRaporu()
        {
            InitializeComponent();

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnBelgeHareketleri, btnTumDetaylariGenislet, btnTumDetaylariDaralt };
        }


        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Odemeler = txtOdemeler;
            IlkTarih = txtIlkTarih;
            SonTarih = txtSonTarih;
            BelgeDurumlari = txtBelgeDurumlari;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;


            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            OdemeTurleriYukle();
            BelgeDurumuYukle();
            txtIlkTarih.DateTime = AnaForm.DonemParametreleri.DonemBaslamaTarihi;
            txtSonTarih.DateTime = DateTime.Now.Date;


            RaporTuru = KartTuru.OdemesiGecikenAlacaklarRaporu;



        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var odemeler = txtOdemeler.CheckedComboBoxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtKayitDurumu.CheckedComboBoxList<IptalDurumu>();
            var belgeDurumlari = txtBelgeDurumlari.CheckedComboBoxList<BelgeDurumu>();

            using (var bll = new OdemesiGecikenAlacaklarBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                  subeler.Contains(x.Tahakkuk.SubeId) &&
                  odemeler.Contains(x.OdemeTipi) &&
                  kayitSekli.Contains(x.Tahakkuk.KayitSekli) &&
                  kayitDurumu.Contains(x.Tahakkuk.KayitDurumu) &&
                  iptalDurumu.Contains(x.Tahakkuk.Durum
                  ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) && 
                  x.Vade>=txtIlkTarih.DateTime.Date && x.Vade<=txtSonTarih.DateTime.Date
                  &&
                  x.Tahakkuk.DonemId == AnaForm.DonemId, belgeDurumlari);


                base.Listele();
            }

        }


        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<OdemesiGecikenAlacaklarRaporuL>();
            if (entity == null) return;
            ShowListForms<GecikmeAciklamalariListForm>.ShowDialogListForm(KartTuru.Aciklama, null, entity.PortfoyNo);

        }

        protected override void BelgeHareketleri()
        {
            var entity = Tablo.GetRow<OdemesiGecikenAlacaklarRaporuL>();
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

                if (entity == BelgeDurumu.Portfoyde
                    || entity == BelgeDurumu.KismiAvukatYoluylaTahsilEtme
                    || entity == BelgeDurumu.KismiTahsilEdildi
                    || entity == BelgeDurumu.BankayaTahsileGonderme
                    || entity == BelgeDurumu.AvukataGonderme
                    || entity == BelgeDurumu.CiroEtme
                    || entity == BelgeDurumu.BlokeyeAlma
                    || entity == BelgeDurumu.OnayBekliyor
                    || entity == BelgeDurumu.PortfoyeGeriIade
                    || entity == BelgeDurumu.PortfoyeKarsiliksizIade
                    || entity == BelgeDurumu.TahsiliImkansizHaleGelme
                    )

                    BelgeDurumlari.Properties.Items.Add(item);
            }


            

        }



        protected override void Tablo_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        protected override void Tablo_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "altGrid";
        }

        protected override void Tablo_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var entity = tablo.GetRow<OdemesiGecikenAlacaklarRaporuL>(e.RowHandle);
            if (entity == null) return;

            using (var bll=new GecikmeAciklamalariBll())
            {
                var list = bll.List(x => x.OdemeBilgileriId == entity.PortfoyNo).EntityListConvert<GecikmeAciklamalariL>().ToList();

                if (list.Any())
                    e.ChildList = list;


            }
        }
    }
}