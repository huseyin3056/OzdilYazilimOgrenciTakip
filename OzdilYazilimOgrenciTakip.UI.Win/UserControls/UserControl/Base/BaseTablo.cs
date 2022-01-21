using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using OzdilYazilimOgrenciTakip.Common.Message;
using System;
using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.UI.Win.Interfaces;
using System.Linq;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        private bool _isLoaded;
        private bool _tabloSablonKayitEdilecek;
        protected GridView Tablo;
        protected internal bool TableValueChanged;
        protected internal BaseEditForm OwnerForm;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;
        protected IList<long> ListeDisiTutulacakKayitlar;

        public BaseTablo()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            // Button Events

            foreach (BarItem button in barManager.Items)
            {
                button.ItemClick += Button_ItemClick;

                // Navigator Events
                insUpNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

                // Table Events
                Tablo.CellValueChanged += Tablo_CellValueChanged;
                Tablo.MouseUp += Tablo_MouseUp;
                Tablo.GotFocus += Tablo_GotFocus;
                Tablo.LostFocus += Tablo_LostFocus;
                Tablo.KeyDown += Tablo_KeyDown;
                Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
                Tablo.ColumnPositionChanged += Tablo_SablonChanged;
                Tablo.ColumnWidthChanged += Tablo_SablonChanged;
                Tablo.EndSorting += Tablo_SablonChanged;

            }
        }


        protected internal void Yukle()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButtonEnabledDurumu();
            insUpNavigator.Navigator.NavigatableControl = Tablo.GridControl;
            SablonYukle();
            Listele();
            ButonGizleGoster();
            //   Tablo_LostFocus(tablo, EventArgs.Empty);

        }

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        private void SablonKaydet()
        {
            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(Tablo.ViewCaption);

        }
        protected virtual void Listele() { }

        private void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);

        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            if (e.Item == btnHareketEkle)
            {
                HareketEkle();
            }

            else if (e.Item == btnHareketSil)
            {
                HareketSil();
            }

            Cursor.Current = DefaultCursor;

        }

        protected virtual void HareketEkle()
        {
            throw new NotImplementedException();
        }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;

            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;

            Tablo.GetRow<IBaseHareketEntity>().Delete = true;
            Tablo.RefreshDataSource();
            ButonEnableDurumu(true);

        }

        protected void ButonEnableDurumu(bool durum)
        {
            TableValueChanged = durum;
            OwnerForm.ButtonEnabledDurumu();

        }

        protected internal bool Kaydet()
        {
            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<IBaseHareketEntity>().Where(x => x.Update && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())

                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Eklenemedi");
                    return false;
                }

            if (!((IBaseHareketGenelBll)Bll).Update(update))
            {
                Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Güncellenemedi");
                return false;
            }

            if (!((IBaseHareketGenelBll)Bll).Delete(delete))
            {
                Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Silinemedi");
                return false;
            }

            ButonEnableDurumu(false);

            return true;



        }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == insUpNavigator.Navigator.Buttons.Append)
                HareketEkle();
            else if (e.Button == insUpNavigator.Navigator.Buttons.Remove)
                HareketSil();

            //if (e.Button == insUpNavigator.Navigator.Buttons.Append || e.Button == insUpNavigator.Navigator.Buttons.Remove)
            //    e.Handled = true;

        }

        private void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (!entity.Insert)
                entity.Update = true;

            ButonEnableDurumu(true);

        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;

            btnHareketSil.Enabled = Tablo.RowCount > 0;
            e.SagMenuGoster(popupMenu);

        }


        private void Tablo_GotFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

            OwnerForm.statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
            OwnerForm.statusBarKisayol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
            OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)
                        insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.CancelEdit);
                    else
                        OwnerForm.Close();
                    break;

                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
                    break;

                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;

                case Keys.Delete when e.Shift:
                    HareketSil();
                    break;

            }
        }


        private void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;

            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, null);

            else if (((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol != null)
            {
                OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
                OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                OwnerForm.statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                OwnerForm.statusBarKisayol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
                OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
            }

            else if (((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama != null)
                OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
        }

        private void Tablo_SablonChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
            SablonKaydet();
        }


    }


}
