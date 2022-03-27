using DevExpress.XtraGrid.Views.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class SiparisBilgileriTable : BaseTablo
    {
        public SiparisBilgileriTable()
        {
            InitializeComponent();

            Bll = new SiparisBilgileriBll();
            Tablo = tablo;
            EventsLoad();


        }

        protected internal override void Listele()
        {
             tablo.GridControl.DataSource = ((SiparisBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<SiparisBilgileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new SiparisBilgileriL
            {
               TahakkukId = OwnerForm.Id,
               
                Insert = true,

            };

            ToplamHesapla(row);

            source.Add(row);



            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colRenkAdi;

            ButonEnabledDurumu(true);
        }


        protected override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<SiparisBilgileriL>();
            if (entity == null) return;

            SutunIndeksDuzenle();

            var beden = ((TahakkukEditForm)OwnerForm).txtBeden.Text;

            string[] value = beden.Split(',');
            foreach (var item in value)
            {

                if (item == "XS")
                {
                    colXS.VisibleIndex = 2;
                    colToplam.VisibleIndex = 100;
                    colXS.Visible = true;
                }

                if (item == "S")
                {
                    colS.VisibleIndex = 3;
                    colToplam.VisibleIndex = 100;
                    colS.Visible = true;
                }

                if (item == "M")
                {
                    colM.VisibleIndex = 4;
                    colToplam.VisibleIndex = 100;
                    colM.Visible = true;
                }

                if (item == "L")
                {
                    colL.VisibleIndex = 5;
                    colToplam.VisibleIndex = 100;
                    colL.Visible = true;
                }

                if (item == "XL")
                {
                    colXL.VisibleIndex = 6;
                    colToplam.VisibleIndex = 100;
                    colXL.Visible = true;
                }

                if (item == "XXL")
                {
                    colXXL.VisibleIndex = 7;
                    colToplam.VisibleIndex = 100;
                    colXXL.Visible = true;
                }

                if (item == "XXXL")
                {
                    colXXXL.VisibleIndex = 8;
                    colToplam.VisibleIndex = 100;
                    colXXXL.Visible = true;
                }


                if (item == "26")
                {
                    col26.VisibleIndex = 9;
                    colToplam.VisibleIndex = 100;
                    col26.Visible = true;
                }

                if (item == "28")
                {
                    col28.VisibleIndex = 10;
                    colToplam.VisibleIndex = 100;
                    col28.Visible = true;
                }


                if (item == "30")
                {
                    col30.VisibleIndex = 11;
                    colToplam.VisibleIndex = 100;
                    col30.Visible = true;
                }

                if (item == "32")
                {
                    col32.VisibleIndex = 12;
                    colToplam.VisibleIndex = 100;
                    col32.Visible = true;
                }

                if (item == "34")
                {
                    col34.VisibleIndex = 13;
                    colToplam.VisibleIndex = 100;
                    col34.Visible = true;
                }

                if (item == "36")
                {
                    col36.VisibleIndex = 14;
                    colToplam.VisibleIndex = 100;
                    col36.Visible = true;
                }

                if (item == "38")
                {
                    col38.VisibleIndex = 15;
                    colToplam.VisibleIndex = 100;
                    col38.Visible = true;
                }

                if (item == "40")
                {
                    col40.VisibleIndex = 16;
                    colToplam.VisibleIndex = 100;
                    col40.Visible = true;
                }

                if (item == "42")
                {
                    col42.VisibleIndex = 17;
                    colToplam.VisibleIndex = 100;
                    col42.Visible = true;
                }
                if (item == "44")
                {
                    col44.VisibleIndex = 18;
                    colToplam.VisibleIndex = 100;
                    col44.Visible = true;
                }
                if (item == "46")
                {
                    col46.VisibleIndex = 19;
                    colToplam.VisibleIndex = 100;
                    col46.Visible = true;
                }
                if (item == "48")
                {
                    col48.VisibleIndex = 20;
                    colToplam.VisibleIndex = 100;
                    col48.Visible = true;
                }
                if (item == "50")
                {
                    col50.VisibleIndex = 21;
                    colToplam.VisibleIndex = 100;
                    col50.Visible = true;
                }

                if (item == "52")
                {
                    col52.VisibleIndex = 22;
                    colToplam.VisibleIndex = 100;
                    col52.Visible = true;
                }

                if (item == "54")
                {
                    col54.VisibleIndex = 23;
                    colToplam.VisibleIndex = 100;
                    col54.Visible = true;
                }

                if (item == "56")
                {
                    col56.VisibleIndex = 24;
                    colToplam.VisibleIndex = 100;
                    col56.Visible = true;
                }

                if (item == "58")
                {
                    col58.VisibleIndex = 25;
                    colToplam.VisibleIndex = 100;
                    col58.Visible = true;
                }

                if (item == "60")
                {
                    col60.VisibleIndex = 26;
                    colToplam.VisibleIndex = 100;
                    col60.Visible = true;
                }

                if (item == "62")
                {
                    col62.VisibleIndex = 27;
                    colToplam.VisibleIndex = 100;
                    col62.Visible = true;
                }

                if (item == "64")
                {
                    col64.VisibleIndex = 28;
                    colToplam.VisibleIndex = 100;
                    col64.Visible = true;
                }

                if (item == "66")
                {
                    col66.VisibleIndex = 29;
                    colToplam.VisibleIndex = 100;
                    col66.Visible = true;
                }

            }

          

        }
     
        private void SutunIndeksDuzenle()
        {
            colXS.VisibleIndex = 2;
            colS.VisibleIndex = 3;
            colM.VisibleIndex = 4;
            colL.VisibleIndex = 5;
            colXL.VisibleIndex = 6;
            colXXL.VisibleIndex = 7;
            colXXXL.VisibleIndex = 8;

            col26.VisibleIndex = 9;
            col28.VisibleIndex = 10;
            col30.VisibleIndex = 11;
            col32.VisibleIndex = 12;
            col34.VisibleIndex = 13;
            col36.VisibleIndex = 14;
            col38.VisibleIndex = 15;
            col40.VisibleIndex = 16;
            col42.VisibleIndex = 17;
            col44.VisibleIndex = 18;
            col46.VisibleIndex = 19;
            col48.VisibleIndex = 20;
            col50.VisibleIndex = 21;
            col52.VisibleIndex = 22;
            col54.VisibleIndex = 23;
            col56.VisibleIndex = 24;
            col58.VisibleIndex = 25;
            col60.VisibleIndex = 26;
            col62.VisibleIndex = 27;
            col64.VisibleIndex = 28;
            col66.VisibleIndex = 29;

            colToplam.VisibleIndex = 100;

            col26.Visible = false;
            col28.Visible = false;
            col30.Visible = false;
            col32.Visible = false;
            col34.Visible = false;
            col36.Visible = false;
            col38.Visible = false;
            col40.Visible = false;
            col42.Visible = false;
            col44.Visible = false;
            col46.Visible = false;
            col48.Visible = false;
            col50.Visible = false;
            col52.Visible = false;
            col54.Visible = false;
            col56.Visible = false;
            col58.Visible = false;
            col60.Visible = false;
            col62.Visible = false;
            col64.Visible = false;
            col66.Visible = false;

            colXS.Visible = false;
            colS.Visible = false;
            colM.Visible = false;
            colL.Visible = false;
            colXL.Visible = false;
            colXXL.Visible = false;
            colXXXL.Visible = false;
        }

        private void ToplamHesapla(SiparisBilgileriL entity)
        {
            var XS = entity.XS == null ? 0 : entity.XS;
            var S = entity.S == null ? 0 : entity.S;
            var M = entity.M == null ? 0 : entity.M;
            var L = entity.L == null ? 0 : entity.L;
            var XL = entity.XL == null ? 0 : entity.XL;
            var XXL = entity.XXL == null ? 0 : entity.XXL;
            var XXXL = entity.XXXL == null ? 0 : entity.XXXL;

            var _26 = entity._26 == null ? 0 : entity._26;
            var _28 = entity._28 == null ? 0 : entity._28;

            var _30 = entity._30 == null ? 0 : entity._30;
            var _32 = entity._32 == null ? 0 : entity._32;
            var _34 = entity._34 == null ? 0 : entity._34;
            var _36 = entity._36 == null ? 0 : entity._36;
            var _38 = entity._38 == null ? 0 : entity._38;

            var _40 = entity._40 == null ? 0 : entity._40;
            var _42 = entity._42 == null ? 0 : entity._42;
            var _44 = entity._44 == null ? 0 : entity._44;
            var _46 = entity._46 == null ? 0 : entity._46;
            var _48 = entity._48 == null ? 0 : entity._48;

            var _50 = entity._50 == null ? 0 : entity._50;
            var _52 = entity._52 == null ? 0 : entity._52;
            var _54 = entity._54 == null ? 0 : entity._54;
            var _56 = entity._56 == null ? 0 : entity._56;
            var _58 = entity._58 == null ? 0 : entity._58;

            var _60 = entity._60 == null ? 0 : entity._60;
            var _62 = entity._62 == null ? 0 : entity._62;
            var _64 = entity._64 == null ? 0 : entity._64;
            var _66 = entity._66 == null ? 0 : entity._66;


            var toplam1 = XS+ S+ M + L + XL + XXL + XXL + XXXL;
            var toplam2 = _26 + _28 + _30 + _32 + _34 + _36 + _38 + _40 + _42;
            var toplam3 = _44 + _46 + _48+_50+_52+_54+_56+_58+_60 + _62 + _64 + _66;
            var sonuc = toplam1 + toplam2 + toplam3;
            entity.Toplam = sonuc;
            colToplam.VisibleIndex = 100;

        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors)
                tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<SiparisBilgileriL>(i);

                if (string.IsNullOrEmpty(entity.RenkAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colRenkAdi;
                    tablo.SetColumnError(colRenkAdi, "Renk Adı  Alanına Geçerli Bir Değer Giriniz");

                }


                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu ");
                return true;

            }

            return false;

        }


        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colRenkAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryRenk, colRenkId);

        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<SiparisBilgileriL>();

            ToplamHesapla(entity);
        }


    }
}
