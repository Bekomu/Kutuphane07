using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class Kullanici
    {
        public List<Kitap> OduncAlinanKitaplar { get; set; }
        public Kullanici()
        {
            Id = Guid.NewGuid();
            OduncAlinanKitaplar = new List<Kitap>();
            OduncAlinanKitaplar.Add(new Kitap() { Aciklama = "bitirdim", Ad = "Dönüş", YazarAd = "R.C.Wilson", BasimTarihi = new DateTime(2013, 07, 01), Id = Guid.NewGuid(), KitapTuru = KitapTuru.Korku, SayfaSayisi = 464 });
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
    }
}
