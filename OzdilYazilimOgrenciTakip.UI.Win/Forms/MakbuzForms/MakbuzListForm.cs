using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class MakbuzListForm : BaseListForm
    {
        public MakbuzListForm()
        {
            InitializeComponent();

            Bll = new MakbuzBll();
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnYeniMakbuz };
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, btnSil, barDelete, barDeleteAciklama, btnAktifPasifKartlar };

            barInsertAciklama.Caption = "Yeni Makbuz";

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Makbuz;
            FormShow = new ShowEditForms<MakbuzEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MakbuzBll)Bll).List(x => x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);

        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            base.Button_ItemClick(sender, e);

            long id = 0;

            if (e.Item == btnYeniMakbuz)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();

            }

            else if (e.Item == btnAvukataGonderme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.AvukataGonderme, MakbuzHesapTuru.Avukat);


            else if (e.Item == btnAvukatYoluylaTahsilEtme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.AvukatYoluylaTahsilEtme, MakbuzHesapTuru.Avukat);


            else if (e.Item == btnTahsilEtmeBanka)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.TahsilEtmeBanka, MakbuzHesapTuru.Banka);


            else if (e.Item == btnBlokeyeAlma)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.BlokeyeAlma, MakbuzHesapTuru.Pos);


            else if (e.Item == btnBlokeCozme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.BlokeCozumu, MakbuzHesapTuru.Pos);


            else if (e.Item == btnBankayaTahsileGonderme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.BankayaTahsileGonderme, MakbuzHesapTuru.Banka);


            else if (e.Item == btnBankaYoluylaTahsilEtme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.BankaYoluylaTahsilEtme, MakbuzHesapTuru.Banka);


            else if (e.Item == btnCiroEtme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.CiroEtme, MakbuzHesapTuru.Cari);


            else if (e.Item == btnMahsupEtme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.MahsupEtme, MakbuzHesapTuru.Mahsup);


            else if (e.Item == btnOdenmisOlarakIsaretleme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.OdenmisOlarakIsaretleme, MakbuzHesapTuru.Cari);



            else if (e.Item == btnMusteriyeGeriIade)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.MusteriyeGeriIade, MakbuzHesapTuru.Iade);



            else if (e.Item == btnPortfoyeGeriIade)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.PortfoyeGeriIade, MakbuzHesapTuru.Banka);


            else if (e.Item == btnPortfoyeKarsiliksizIade)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.PortfoyeKarsiliksizIade, MakbuzHesapTuru.Banka);


            else if (e.Item == btnBaskaSubeyeGonderme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.BaskaSubeyeGonderme, MakbuzHesapTuru.Transfer);


            else if (e.Item == btnGelenBelgeyiOnaylama)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.GelenBelgeyiOnaylama, MakbuzHesapTuru.Transfer);


            else if (e.Item == btnTahsilEtmeKasa)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.TahsilEtmeKasa, MakbuzHesapTuru.Kasa);


            else if (e.Item == btnKarsiliksizOlarakIsaretleme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.KarsiliksizOlarakIsaretleme, MakbuzHesapTuru.Supheli);


            else if (e.Item == btnTahsiliImkansizHaleGelme)

                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, -1, MakbuzTuru.TahsiliImkansizHaleGelme, MakbuzHesapTuru.Supheli);


            if (id > 0)
                ShowEditFormDefault(id);

            tablo.Focus();

        }

        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<MakbuzL>();
            if (entity == null) return;

            var result = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.HesapTuru);


            ShowEditFormDefault(result);



        }
    }
}