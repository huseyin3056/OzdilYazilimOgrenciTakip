using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.Extensions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaPlaniListForm : BaseListForm
    {
        public FaturaPlaniListForm()
        {
            InitializeComponent();

            Bll = new TahakkukBll();

            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, barInsert, barInsertAciklama, barDelete, barDeleteAciklama, btnAktifPasifKartlar };
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnTahakkukYap };

            btnSil.Caption = "Fatura Planı İptal Et";
            btnTahakkukYap.Caption = "Toplu Fatura Planı";

            btnYazdir.CreateDropDownMenu(new DevExpress.XtraBars.BarItem[] { btnTabloYazdir });


        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Fatura;

            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((TahakkukBll)Bll).FaturaTahakkukList(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }

        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<FaturaL>();
            if (entity == null) return;

            if (entity.HizmetNetTutar == 0)
            {
                Messages.HataMesaji("Öğrencinin Net Ücreti Sıfır ( 0 ) Olduğu İçin Fatura Planı Oluşturamazsınız");
                return;
            }

            var result = ShowEditForms<FaturaPlaniEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Fatura, id, null);
            ShowEditFormDefault(result);

        }

        protected override void TahakkukYap()
        {
            var source = new List<FaturaL>();

            for (int i = 0; i < tablo.DataRowCount; i++)
                source.Add(tablo.GetRow<FaturaL>(i));

            if (source.Count == 0) return;

            if (ShowEditForms<TopluFaturaPlaniEditForm>.ShowDialogEditForm(KartTuru.Fatura, source))
                Listele();

        }

        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Seçilen Öğrencilere Ait Hareket Görmeyen Tüm Fatura Planları İptal Edilcektir. Onaylıyor musunuz? ", "İptal Onay") != System.Windows.Forms.DialogResult.Yes) return;

            var source = new List<FaturaL>();

            for (int i = 0; i < tablo.DataRowCount; i++)
                source.Add(tablo.GetRow<FaturaL>(i));

            if (source.Count == 0) return;

            using (var bll = new FaturaBll())
            {
                var position = 0.0;
                progressBarControl.Visible = true;
                progressBarControl.Left = (ClientSize.Width - progressBarControl.Width) / 2;
                progressBarControl.Top = (ClientSize.Height - progressBarControl.Height) / 2;

                source.ForEach(x =>
                {
                    var yuzde = 100.0 / source.Count;
                    position += yuzde;

                    var planSource = bll.List(y => y.TahakkukId == x.Id).Where(y => ((FaturaPlaniL)y).TahakkukTarih == null).ToList();
                    bll.Delete(planSource);

                    progressBarControl.Position = (int)position;
                    progressBarControl.Update();



                });
            }

            progressBarControl.Visible = false;
            Messages.BilgiMesaji("Seçilen Öğrencilere Ait Fatura Planları Başarılı Bir Şekilde İptal Edilmiştir");
            Listele();

        }

        protected override void Yazdir()
        {
            var source = new List<FaturaR>();

            using (var bll = new FaturaBll())
            {

                for (int i = 0; i < Tablo.DataRowCount; i++)
                {
                    var entity = Tablo.GetRow<FaturaL>(i);
                    if (entity == null) return;
                    var list = bll.FaturaTahakkukList(x => x.TahakkukId == entity.Id).Cast<FaturaPlaniL>();
                    list.ForEach(x =>
                    {

                        var row = new FaturaR
                        {
                            TahakkukId=x.TahakkukId,
                            OkulNo = x.OkulNo,
                            OgrenciNo = x.OgrenciNo,
                            TcKimlikNo = x.TcKimlikNo,
                            Adi = x.Adi,
                            Soyadi = x.Soyadi,
                            SinifAdi = x.SinifAdi,
                            VeliTcKimlikNo = x.VeliTcKimlikNo,
                            VeliAdi = x.VeliAdi,
                            VeliSoyadi = x.VeliSoyadi,
                            VeliYakinlikAdi = x.VeliYakinlikAdi,
                            VeliMeslekAdi = x.VeliMeslekAdi,
                            FaturaNo=x.FaturaNo,                      
                            FaturaAdres = x.FaturaAdres,                         
                            FaturaAdresIlAdi = x.FaturaAdresIlAdi,
                            FaturaAdresIlceAdi = x.FaturaAdresIlceAdi,
                            Aciklama = x.Aciklama,
                            Tarih = x.TahakkukTarih,
                            Tutar = x.TahakkukTutar,
                            Indirim = x.TahakkukIndirimTutar,
                            NetTutar = x.TahakkukNetTutar,
                            KdvSekli = x.KdvSekli,
                            KdvOrani = x.KdvOrani,
                            KdvHaricTutar = x.KdvHaricTutar,
                            KdvTutari = x.KdvTutar,
                            ToplamTutar = x.ToplamTutar,
                            TutarYazi = x.TutarYazi,
                            PlanTutar=entity.PlanTutar,
                            PlanIndirim=entity.PlanIndirim,
                            PlanNetTutar=entity.PlanNetTutar,
                           
                            Sube = x.Sube,
                            Donem = x.Donem

                        };

                        source.Add(row);

                    });
                }

                ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.FaturaRaporu, false, RaporBolumTuru.FaturaGenelRaporlar, source);

            }

        }
    }
}
