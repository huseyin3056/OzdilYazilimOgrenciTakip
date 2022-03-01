using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class RolYetkiKartlariListForm : BaseListForm
    {
        public RolYetkiKartlariListForm()
        {
            InitializeComponent();

            HideItems = new DevExpress.XtraBars.BarItem[] { 

            btnYeni,btnSil,btnDuzelt,btnKolonlar,
            barInsert,barInsertAciklama,barDelete,barDeleteAciklama,
            barF3,barDuzeltAciklama,
            barKolonlar,barKolonlarAciklama
            
            };

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.YetkiKarti;
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            var enumList = Enum.GetValues(typeof(KartTuru)).Cast<KartTuru>().ToList();
            var Liste = new List<RolYetki>();

            enumList.ForEach(x =>
            {
                var entity = new RolYetki
                {
                    KartTuru=x

                };

                Liste.Add(entity);

            });


            var list = Liste.Where(x=>x.KartTuru!=KartTuru.UrunTanimi).Where(x => !ListeDisiTutulacakKayitlar.Contains((long)x.KartTuru)).OrderBy(x=>x.KartTuru.ToName());
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

    }
}