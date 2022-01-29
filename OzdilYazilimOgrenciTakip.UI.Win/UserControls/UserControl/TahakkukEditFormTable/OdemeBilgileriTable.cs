using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class OdemeBilgileriTable : BaseTablo
    {
        public OdemeBilgileriTable()
        {
            InitializeComponent();

            Bll = new OdemeBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnBelgeHareketleri};


        }


        protected override void Listele()
        {

            tablo.GridControl.DataSource = ((OdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<OdemeBilgileriL>();
        
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var dahaOnceGirilenTaksitSayisi = source.Cast<OdemeBilgileriL>().Count(x => !x.Delete && x.BelgeDurumu != Common.Enums.BelgeDurumu.MusteriyeGeriIade);


        }

    }
}
