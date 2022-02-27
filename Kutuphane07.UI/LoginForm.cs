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
    public partial class LoginForm : Form
    {
        Kullanici kullanici;
        KullaniciYoneticisi admin;

        public LoginForm()
        {
            InitializeComponent();
            kullanici = new Kullanici();
            admin = new KullaniciYoneticisi();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                if (admin.KullaniciVarMi(txtKullaniciAdi.Text))
                {
                    Kullanici girisYapan = admin.GirisYap(txtKullaniciAdi.Text, txtParola.Text);
                    if (girisYapan != null)
                    {
                        KutuphaneForm form = new KutuphaneForm(girisYapan);
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("Parola veya Kullanıcı Adı yanlış. Tekrar Deneyin");
                }
                else
                    MessageBox.Show("Üye bulunamadı !");
            }
            else
                MessageBox.Show("Kullanıcı Adı ve Parola boş olamaz !");
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlForm form = new KayitOlForm(admin);
            form.ShowDialog();
        }


    }
}
