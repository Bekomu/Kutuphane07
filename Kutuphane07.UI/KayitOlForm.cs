using Kutuphane07.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class KayitOlForm : Form
    {
        private readonly KullaniciYoneticisi _admin;

        public KayitOlForm(KullaniciYoneticisi admin)
        {
            _admin = admin;
            InitializeComponent();
            // şifre tekrar kontrolü ???? 
            // kullanici var mı kontrolü ???
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text))
            {
                _admin.KayitOl(txtAd.Text, txtSoyad.Text, txtKullaniciAdi.Text, txtSifre.Text);
                MessageBox.Show("Kayıt başarılı.");
                KayitFormTemizle();
            }
            else
                MessageBox.Show("Ad ve Soyad boş olamaz.");

        }

        private void KayitFormTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
            txtSifreTekrar.Enabled = false;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            KullaniciAdiVarMi();
            KayitOlButonAktif();
        }


        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifreTekrar.Enabled = true;
            ParolaTekrarKontrol();
            KayitOlButonAktif();
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            ParolaTekrarKontrol();
            KayitOlButonAktif();
        }

        private bool KullaniciAdiVarMi()
        {
            if (_admin.KullaniciVarMi(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                lblKullaniciGecersiz.ForeColor = Color.Red;
                lblKullaniciGecersiz.Text = "Kullanıcı adı geçersiz!";
                return false;
            }
            else
            {
                lblKullaniciGecersiz.ForeColor = Color.Green;
                lblKullaniciGecersiz.Text = "Kullanıcı adı uygun.";
                return true;
            }
        }
        private bool ParolaTekrarKontrol()
        {
            if (txtSifre.Text == txtSifreTekrar.Text && !string.IsNullOrEmpty(txtSifre.Text))
            {
                lblSifreGecersiz.ForeColor = Color.Green;
                lblSifreGecersiz.Text = "Parola uygun.";
                return true;
            }
            else
            {
                lblSifreGecersiz.ForeColor = Color.Red;
                lblSifreGecersiz.Text = "Parola eşleşmiyor.";
                return false;
            }
        }
        private void KayitOlButonAktif()
        {
            if (KullaniciAdiVarMi() && ParolaTekrarKontrol())
            {
                btnKayitOl.Enabled = true;
            }
            else
                btnKayitOl.Enabled = false;
        }

        private void btnKayitIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
