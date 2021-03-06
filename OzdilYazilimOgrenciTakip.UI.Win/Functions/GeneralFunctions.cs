using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1)
                return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesaji();
            return -1;

        }

        public static T GetRow<T>(this GridView tablo, bool mesajVer=true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);
            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();

            return default(T);

        }

        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
        {

            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))
                {
                    if (String.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }

                    if (String.IsNullOrEmpty(currentValue.ToString()))
                    {
                        currentValue = new byte[] { 0 };
                    }

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        return VeriDegisimYeri.Alan;
                    }

                }

                else if (currentValue.Equals(oldValue))
                {
                    return VeriDegisimYeri.Alan;
                }

            }

            return VeriDegisimYeri.VeriDegisimiYok;

        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni,BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnGeriAl.Enabled= buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;



        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity  )
        {
          

            string sifirEkle(string deger)
            {
                if(deger.Length==1)
                {
                    return "0" + deger;
                }
                else
                {
                    return deger;
                }

            }

            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                        break;

                    case 2:
                        return "0" + deger;
                        break;
                }
                return deger;
            }

            string Id()
            {
                var yil = sifirEkle(DateTime.Now.Date.Year.ToString());
                var ay= sifirEkle(DateTime.Now.Date.Month.ToString());
                var gun= sifirEkle(DateTime.Now.Date.Day.ToString());
                var saat = sifirEkle(DateTime.Now.Hour.ToString());
                var dakika = sifirEkle(DateTime.Now.Minute.ToString());
                var saniye = sifirEkle(DateTime.Now.Second.ToString());
                var milisaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random = sifirEkle(new Random().Next(0, 99).ToString());


                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;

            }

            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());


        }
    }
}
