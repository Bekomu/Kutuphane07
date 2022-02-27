using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KutuphaneYoneticisi
    {
        public List<Kitap> kitaplar { get; set; }
        public KutuphaneYoneticisi()
        {
            kitaplar = new List<Kitap>();
            kitaplar.Add(new Kitap() { Aciklama = "çok güzel kitap", Ad = "Son Detay", BasimTarihi = new DateTime(2013,2,3), KitapTuru = KitapTuru.Korku, YazarAd = "Harlan Coben", SayfaSayisi = 460, Id = Guid.NewGuid() });
        }

        public void KitapBagisYap(string ad, DateTime basimTarihi, KitapTuru kitapTuru, string yazarAd, int sayfaSayisi, string aciklama)
        {
            kitaplar.Add(new Kitap() { Aciklama = aciklama, Ad = ad, BasimTarihi = basimTarihi, KitapTuru = kitapTuru, YazarAd = yazarAd, SayfaSayisi = sayfaSayisi, Id = Guid.NewGuid() });
        }
        public void KitapImhaEt(Guid kitapId)
        {

        }
        public void KitapOduncAl(Kullanici kullanici, Guid kitapId)
        {

        }
    }
}
