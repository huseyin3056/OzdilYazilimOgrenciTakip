using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Base;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class IndirimDagilimRaporu : BaseRapor
    {
        public IndirimDagilimRaporu()
        {
            InitializeComponent();
        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Indirimler = txtIndirimler;
            
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            IndirimKartlariYukle();
            RaporTuru = Common.Enums.KartTuru.IndirimDagilimRaporu;



        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var indirimler = txtIndirimler.CheckedComboBoxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtKayitDurumu.CheckedComboBoxList<IptalDurumu>();

            using (var bll = new IndirimDagilimRaporuBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                  subeler.Contains(x.SubeId) &&
                  kayitSekli.Contains(x.KayitSekli) &&
                  kayitDurumu.Contains(x.KayitDurumu) &&
                  iptalDurumu.Contains(x.Durum 
                  ? IptalDurumu.DevamEdiyor
                  : IptalDurumu.IptalEdildi) && x.DonemId == AnaForm.DonemId,indirimler);


                base.Listele();
            }


        }

        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<IndirimDagilimRaporuL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);

        }

      
    }
}