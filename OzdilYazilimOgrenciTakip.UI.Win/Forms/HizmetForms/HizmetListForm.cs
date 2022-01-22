using System;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Utils.Extensions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
      

        private readonly Expression<Func<Hizmet, bool>> _filter;


        public HizmetListForm()
        {
            InitializeComponent();

            Bll = new HizmetBll();
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
         
            
         

        }

        public HizmetListForm(params object[] prm) : this()
        {
            if (prm != null)
            {

                var panelGoster = (bool)prm[0];
                ustPanel.Visible = DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && panelGoster;
            }

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Hizmet;
            FormShow = new ShowEditForms<HizmetEditForm>();
            Navigator = longNavigator.Navigator;
            TarihAyarla();


        }

        protected override void Listele()
        {
            var list = ((HizmetBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;
          
            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");



        }

        private void TarihAyarla()
        {
            txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir
                ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi
                ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date;

            txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir
                ? AnaForm.DonemBitisTarihi : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi
                ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemBitisTarihi
                ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;

            txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.EgitimBaslamaTarihi
                ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemBitisTarihi
                ? DateTime.Now.Date : DateTime.Now.Date > AnaForm.DonemBitisTarihi ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;




        }

        protected override void SelectEntity()
        {
           base.SelectEntity();

            if(MultiSelect)
            SelectedEntities.ForEach(x => ((HizmetL)x).BaslamaTarihi = txtHizmetBaslamaTarihi.DateTime.Date);

        }
    }
}