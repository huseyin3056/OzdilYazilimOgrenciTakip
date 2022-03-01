using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;

        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlceBll(DataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Ilce;
            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Ilce() : ((IlceBll)Bll).Single(FilterFunctions.Filter<Ilce>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ({_ilAdi})";
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlceBll)Bll).YeniKodVer(x=>x.IlId==_ilId);
            txtIlceAdi.Focus();

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ilce)OldEntity;

            txtKod.Text = entity.Kod;
            txtIlceAdi.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }


        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ilce
            {
                Id = Id,
                Kod = txtKod.Text,
                IlceAdi=txtIlceAdi.Text,
                IlId=_ilId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };
            ButtonEnabledDurumu();
        }


        protected override bool EntityInsert()
        {
            return ((IlceBll)Bll).Insert(CurrentEntity,x=>x.Kod==CurrentEntity.Kod && x.IlId==_ilId);

        }

        protected override bool EntityUpdate()
        {
            return ((IlceBll)Bll).Update(OldEntity,CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);

        }

    }
}