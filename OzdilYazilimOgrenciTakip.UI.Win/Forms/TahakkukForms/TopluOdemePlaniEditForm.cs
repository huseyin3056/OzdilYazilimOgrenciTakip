﻿using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using System;
using System.Collections;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TopluOdemePlaniEditForm : BaseEditForm
    {
        private OdemeTipi _odemeTipi;
        private byte _blokeGunSayisi;
        private readonly IList _source;
        private readonly long _tahakkukId;
        private readonly decimal _bakiye;
        private readonly DateTime _kayitTarihi;
        private readonly int _dahaOnceGirilenTaksitSayisi;
        private bool _maksimumTaksitSayisinaUlasildi;





        public TopluOdemePlaniEditForm(IList source, long tahakkukId, decimal bakiye, DateTime kayitTarihi, int dahaOnceGirilenTaksitSayisi, bool maksimumTaksitSayisinaUlasildi)
        {
            InitializeComponent();

            _source = source;
            _tahakkukId = tahakkukId;
            _bakiye = bakiye;
            _kayitTarihi = kayitTarihi;
            _dahaOnceGirilenTaksitSayisi = dahaOnceGirilenTaksitSayisi;
            _maksimumTaksitSayisinaUlasildi = maksimumTaksitSayisinaUlasildi;



            DataLayoutControl = myDataLayoutControl;
            EventsLoad();

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnTaksitOlustur };
            HideItems = new DevExpress.XtraBars.BarItem[] { btnyeni, btnFarkliKaydet, btnGeriAl, btnSil };



        }

        protected internal override void Yukle()
        {
            ControlEnableChange(OdemeTipi.Acik);

            txtIlkTaksitTarihi.DateTime = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MinValue = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MaxValue = AnaForm.MaksimumTaksitTarihi;
            txtSabitTaksit.Value = 0;
            txtBakiye.Value = _bakiye;
            txtTaksitSayisi.Properties.MinValue = 1;
            txtTaksitSayisi.Properties.MaxValue = AnaForm.MaksimumTaksitSayisi - _dahaOnceGirilenTaksitSayisi;

            if (AnaForm.MaksimumTaksitSayisi - _dahaOnceGirilenTaksitSayisi > 0) return;
            Messages.HataMesaji("Maksimum Taksit Sayısı Aşılıyor");
            _maksimumTaksitSayisinaUlasildi = true;


        }

        private void ControlEnableChange(OdemeTipi odemeTipi)
        {
            txtBankaHesap.Enabled = odemeTipi == OdemeTipi.Epos || odemeTipi == OdemeTipi.Ots || odemeTipi == OdemeTipi.Pos;
            txtAsilBorclu.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtCiranta.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtBanka.Enabled = odemeTipi == OdemeTipi.Cek;
            txtBankaSube.Enabled = odemeTipi == OdemeTipi.Cek;
            txtHesapNo.Enabled = odemeTipi == OdemeTipi.Cek;
            txtIlkBelgeNo.Enabled = odemeTipi == OdemeTipi.Cek;
            txtBanka.ControlEnabledChange(txtBankaSube);

        }

        private bool HataliGiris()
        {
            if (txtIlkTaksitTarihi.DateTime.Date.AddMonths((int)txtTaksitSayisi.Value) > AnaForm.MaksimumTaksitTarihi)
            {
                Messages.HataMesaji("Maksimum Taksit Tarihi Aşılıyor");
                return true;
            }

            if (txtOdemeTuru.Id == null)
            {
                Messages.HataMesaji("Ödeme Türü Seçimi Yapmalısınız");
                txtOdemeTuru.Focus();
                return true;
            }

            if ((_odemeTipi == OdemeTipi.Epos || _odemeTipi == OdemeTipi.Pos) && txtBankaHesap.Id == null)
            {
                Messages.SecimHataMesaji("Banka Hesap");
                txtBankaHesap.Focus();
                return true;
            }


            if (txtSabitTaksit.Value == 0 && txtBakiye.Value == 0 || txtSabitTaksit.Value > 0 && txtBakiye.Value > 0)
            {
                Messages.HataMesaji("Sabit Taksit veya Bakiye Alanlarından Sadece Birisinin Değeri Sıfıra Eşit veya Sıfırdan Büyük Olmalıdır. ");
                txtSabitTaksit.Focus();
                return true;
            }

            if (_odemeTipi == OdemeTipi.Senet || _odemeTipi == OdemeTipi.Cek && string.IsNullOrEmpty(txtAsilBorclu.Text))
            {
                Messages.HataliVeriMesaji("Asıl Borçlu ");
                txtAsilBorclu.Focus();
                return true;
            }

            switch (_odemeTipi)
            {

                case OdemeTipi.Cek when txtBanka.Id == null:
                    Messages.SecimHataMesaji("Banka");
                    txtBanka.Focus();
                    return true;

                case OdemeTipi.Cek when txtBankaSube.Id == null:
                    Messages.SecimHataMesaji("Banka Şube ");
                    txtBankaSube.Focus();
                    return true;

                case OdemeTipi.Cek when txtIlkBelgeNo.Value == 0:
                    Messages.HataliVeriMesaji("İlke Belge No");
                    txtIlkBelgeNo.Focus();
                    return true;

            }

            return false;
        }

        protected override void TaksitOlustur()
        {

            if (HataliGiris()) return;
            txtOdemeTuru.Focus();

            var tutar = txtSabitTaksit.Value != 0 ? txtSabitTaksit.Value : Math.Round(txtBakiye.Value / txtTaksitSayisi.Value, AnaForm.OdemePlaniKurusKullan ? 2 : 0);
            decimal toplamGirilenTutar = 0;

            for (int i = 0; i < txtTaksitSayisi.Value; i++)
            {
                var taksit = new OdemeBilgileriL
                {
                    Id = 0,
                    TahakkukId = _tahakkukId,
                    OdemeTipi = _odemeTipi,
                    OdemeTuruId = (long)txtOdemeTuru.Id,
                    OdemeTuruAdi = txtOdemeTuru.Text,
                    GirisTarihi = DateTime.Now.Date,
                    Vade = txtIlkTaksitTarihi.DateTime.Date.AddMonths(i),
                    HesabaGecisTarihi = txtIlkTaksitTarihi.DateTime.Date.AddMonths(i),
                    Tutar = i == txtTaksitSayisi.Value - 1 && txtSabitTaksit.Value == 0 ? txtBakiye.Value - toplamGirilenTutar : tutar,
                   
                    BelgeDurumu = BelgeDurumu.Portfoyde,
                    Insert = true





                };

                taksit.TutarYazi = taksit.Tutar.YaziIleTutar();
                taksit.VadeYazi = taksit.Vade.YaziIleVade();
                taksit.Kalan = taksit.Tutar;
                toplamGirilenTutar += taksit.Tutar;

                switch (_odemeTipi)
                {             
                    case OdemeTipi.Epos:
                     
                    case OdemeTipi.Ots:
                     
                    case OdemeTipi.Pos:
                        taksit.BankaHesapId = txtBankaHesap.Id;
                        taksit.BankaAdi = txtBankaHesap.Text;
                        taksit.BlokeGunSayisi = _blokeGunSayisi;
                        taksit.HesabaGecisTarihi = taksit.Vade.Date.AddDays(_blokeGunSayisi);
                        break;

                    case OdemeTipi.Senet:
                        taksit.AsilBorclu = txtAsilBorclu.Text;
                        taksit.Ciranta = txtCiranta.Text;
                        break;

                    case OdemeTipi.Cek:
                        taksit.AsilBorclu = txtAsilBorclu.Text;
                        taksit.Ciranta = txtCiranta.Text;
                        taksit.BankaId = txtBanka.Id;
                        taksit.BankaAdi = txtBanka.Text;
                        taksit.BankaSubeId = txtBankaSube.Id;
                        taksit.BankaSubeAdi = txtBankaSube.Text;
                        taksit.HesapNo = txtHesapNo.Text;
                        taksit.BelgeNo = ((int)txtIlkBelgeNo.Value + i).ToString();


                        break;
                
                }

                _source.Add(taksit);

            }

            DialogResult = DialogResult.OK;
            Close();



        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec=new SelectFunctions())
            {
                if (sender == txtOdemeTuru)
                    sec.Sec(txtOdemeTuru);
                else if (sender == txtBankaHesap)
                    sec.Sec(txtBankaHesap, _odemeTipi);

                else if (sender == txtBanka)
                    sec.Sec(txtBanka);

                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);



            }
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
           if(sender==txtOdemeTuru)
            {
                _odemeTipi = txtOdemeTuru.Id == null ? OdemeTipi.Acik : txtOdemeTuru.Tag.ToString().GetEnum<OdemeTipi>();
                ControlEnableChange(_odemeTipi);
                txtBankaHesap.Id = null;
                txtBankaHesap.Text = null;

            }

           else if(sender==txtBankaHesap)
                _blokeGunSayisi =Convert.ToByte( txtBankaHesap.Tag);

           else if(sender==txtBanka)
            {
                txtBankaSube.Id = null;
                txtBankaSube.Text = null;

            }



        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtBanka) return;
            txtBanka.ControlEnabledChange(txtBankaSube);

        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();

            if (DialogResult != DialogResult.Cancel) return;

            if (Messages.HayirSeciliEvetHayir("Taksit Oluşturma Ekranı Kapatılacaktır. Onaylıyormusunuz?", "Kapatma Onayı") == DialogResult.No)
                e.Cancel = true;

        }
    }
}