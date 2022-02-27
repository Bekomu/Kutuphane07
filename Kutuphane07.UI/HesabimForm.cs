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
    public partial class HesabimForm : Form
    {
        private readonly Kullanici _kullanici;

        public HesabimForm(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            dgvOduncAlinan.DataSource = _kullanici.OduncAlinanKitaplar;
            KullaniciBilgiListele();
        }

        private void dgvGuncelle()
        {
            dgvOduncAlinan.DataSource = null;
            dgvOduncAlinan.DataSource = _kullanici.OduncAlinanKitaplar;
        }

        private void KullaniciBilgiListele()
        {
            lblKullaniciId.Text = _kullanici.Id.ToString();
            lblKullaniciAdi.Text = _kullanici.KullaniciAdi;
            lblAdSoyad.Text = $"{_kullanici.Ad} {_kullanici.Soyad}";
            lblParola.Text = _kullanici.Parola;
        }

        private void btnKitapTeslimEt_Click(object sender, EventArgs e)
        {

        }
    }
}
