using System;
using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum BelgeDurumu : Byte
    {
        [Description("Portföyde")]
        Portfoyde=1,
        [Description("Tahsil Etme ( Kasa )")]
        TahsilEtmeKasa,
        [Description("Tahsil Etme ( Banka )")]
        TahsilEtmeBanka,
        [Description("Kısmi Tahsil Edildi")]
        KismiTahsilEdildi,
        [Description("Bankaya Tahsile Gönderme")]
        BankayaTahsileGonderme,
        [Description("Banka Yoluyla Tahsil Etme")]
        BankaYoluylaTahsilEtme,
        [Description("Portföye Geri İade")]
        PortfoyeGeriIade,
        [Description("Portföye Karşılıksız İade")]
        PortfoyeKarsiliksizIade,
        [Description("Avukata Gönderme")]
        AvukataGonderme,
        [Description("Avukat Yoluyla Tahsil Etme")]
        AvukatYoluylaTahsilEtme,
        [Description("Kısmi Avukat Yoluyla Tahsil Etme")]
        KismiAvukatYoluylaTahsilEtme,
        [Description("Blokeye Alma")]
        BlokeyeAlma,
        [Description("Bloke Çözümü")]
        BlokeCozumu,
        [Description("Ciro Etme")]
        CiroEtme,
        [Description("Müşteriye Geri İade")]
        MusteriyeGeriIade,
        [Description("Mahsup Etme")]
        MahsupEtme,
        [Description("Onay Bekliyor")]
        OnayBekliyor,
        [Description("Ödenmiş Olarak İşaretleme")]
        OdenmisOlarakIsaretleme,
        [Description("Karşılıksız Olarak İşaretleme")]
        KarsiliksizOlarakIsaretleme,
        [Description("Tahsili İmkansız Hale Gelme")]
        TahsiliImkansizHaleGelme





    }
}
