using DevExpress.XtraEditors.Controls;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IletisimForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.YakinlikForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IletisimBilgileriTable :BaseTablo
    {
        public IletisimBilgileriTable()
        {
            InitializeComponent();

            Bll = new IletisimBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnKartDuzenle };

            repositoryAdres.Items.AddEnum<AdresTuru>();

        }


        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IletisimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IletisimBilgileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IletisimBilgileriL>().Where(x => !x.Delete).Select(x => x.IletisimId).ToList();
            ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);


            var entities = ShowListForms<IletisimListForm>.ShowDialogListForm(Common.Enums.KartTuru.Iletisim, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<IletisimL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IletisimBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    IletisimId=entity.Id,
                    TcKimlikNo=entity.TcKimlikNo,
                    Adi=entity.Adi,
                    SoyAdi=entity.SoyAdi,
                    EvTel=entity.EvTel,
                    IsTel1=entity.IsTel1,
                    IsTel2=entity.IsTel2,
                    CepTel1=entity.CepTel1,
                    CepTel2=entity.CepTel2,
                    EvAdres=entity.EvAdres,
                    EvAdresIlAdi=entity.EvAdresIlAdi,
                    EvAdresIlceAdi=entity.EvAdresIlceAdi,
                    IsAdres=entity.IsAdres,
                    IsAdresIlAdi=entity.IsAdresIlAdi,
                    IsAdresIlceAdi=entity.IsAdresIlceAdi,
                    MeslekAdi=entity.MeslekAdi,
                    IsyeriAdi=entity.IsYeriAdi,
                    GorevAdi=entity.GorevAdi,        
                    Insert = true,

                };

                if(source.Count==0)
                {
                    row.Veli = true;
                    row.FaturaAdresi = AdresTuru.EvAdresi;
                }

                var yakinlik =(Yakinlik) ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, -1);
                if (yakinlik == null) return;
                row.YakinlikId = yakinlik.Id;
                row.YakinlikAdi = yakinlik.YakinlikAdi;

                source.Add(row);

            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colVeli;

            ButonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors)
                tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IletisimBilgileriL>(i);
                if (entity.YakinlikAdi==null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colYakinlikAdi;
                    tablo.SetColumnError(colYakinlikAdi, "Yakınlık Adı Alanına Geçerli Bir Değer Giriniz");

                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu ");
                return true;

            }

            return false;

        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<IletisimBilgileriL>();
            if (entity == null) return;
            ShowEditForms<IletisimEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.IletisimId,null);


        }



    }
}
