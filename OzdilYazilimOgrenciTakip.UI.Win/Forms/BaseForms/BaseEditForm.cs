using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;
        protected MyDataLayoutControl DataLayoutControl;
        protected IBaseBll Bll;
        protected KartTuru KartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;

        public BaseEditForm()
        {
            InitializeComponent();

        }

        protected void EventsLoad()
        {
            // Button Events

            foreach (BarItem button in ribbonControl.Items)
       
                button.ItemClick += Button_ItemClick;

            // Form Events
            Load += BaseEditForm_Load;

        
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            // SablonYukle();
            // ButonGizleGoster();
            Id = IslemTuru.IdOlustur(OldEntity);

            // Güncelleme Yapılacak



        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
           if(e.Item==btnyeni)
            {
                // Yetki Kontrolü
                IslemTuru = IslemTuru.EntityInsert;
                Yukle();

            }

           else if(e.Item==btnKaydet)
            {
                Kaydet(false);
            }

           else if(e.Item==btnGeriAl)
            {
                GeriAl();
            }

            else if (e.Item == btnSil)
            {
                // Yetki Kontrolü

                EntityDelete();
            }

           else if(e.Item==btnCikis)
            {
                Close();
            }

        }

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void GeriAl()
        {
            throw new NotImplementedException();
        }

        private void Kaydet(bool v)
        {
            throw new NotImplementedException();
        }

        protected virtual internal void Yukle() { }

        protected virtual void NesneyiKontrollereBagla() { }

        protected virtual void GuncelNesneOlustur() { }

        protected internal virtual void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnyeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity);


        }
             

    }
}