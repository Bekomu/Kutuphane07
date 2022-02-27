using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KullaniciYoneticisi
    {
        public List<Kullanici> kullanicilar { get; set; }

        public KullaniciYoneticisi()
        {
            kullanicilar = new List<Kullanici>();
            kullanicilar.Add(new Kullanici() { Ad = "Berkay", Soyad = "Özışık", KullaniciAdi = "bekomu", Parola = "asd123" });    // ödünç alınan kitaplar ??????????
        }
        public void KayitOl(string ad, string soyad, string kullaniciAdi, string parola)
        {
            kullanicilar.Add(new Kullanici() { Ad = ad, Soyad = soyad, KullaniciAdi = kullaniciAdi, Parola = parola });
        }
        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            if ((kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi)).Parola == parola)
            {
                return kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi);
            }
            return null;
        }
        public bool KullaniciVarMi(string KullaniciAdi)
        {
            return kullanicilar.Any(x => x.KullaniciAdi == KullaniciAdi);
        }
    }
}
