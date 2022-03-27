using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using System.Drawing;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class RenkEditForm : BaseEditForm
    {
        public RenkEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new RenkBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Renk;

            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Renk() : ((RenkBll)Bll).Single(FilterFunctions.Filter<Renk>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RenkBll)Bll).YeniKodVer();
            txtRenkAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Renk)OldEntity;

            txtKod.Text = entity.Kod;
            txtRenkAdi.Text = entity.RenkAdi;

            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
            txtRenk.Color = Color.FromArgb(entity.VarsayilanRenk);

        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Renk
            {
                Id = Id,
                Kod = txtKod.Text,
                RenkAdi = txtRenkAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
                VarsayilanRenk=txtRenk.Color.ToArgb()


            };

            ButtonEnabledDurumu();

        }

    }
}
