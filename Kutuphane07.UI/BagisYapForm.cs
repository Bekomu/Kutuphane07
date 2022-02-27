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
    public partial class BagisYapForm : Form
    {
        private readonly KutuphaneYoneticisi _kutuphaneYoneticisi;
        private readonly List<Kitap> _kitaplar;
        public event EventHandler guncelle;

        public BagisYapForm(KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            _kutuphaneYoneticisi = kutuphaneYoneticisi;
            _kitaplar = kutuphaneYoneticisi.kitaplar;
            foreach (KitapTuru item in (KitapTuru[])Enum.GetValues(typeof(KitapTuru)))
            {
                cboxKitapTuru.Items.Add(item);
            }
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtKitapAdi.Text) &&
                cboxKitapTuru.SelectedIndex != -1 &&
                !string.IsNullOrEmpty(txtYazarAdi.Text) &&
                nudSayfaSayisi.Value != 0 &&
                nudAdet.Value != 0)
            {
                _kutuphaneYoneticisi.KitapBagisYap(txtKitapAdi.Text, dtpBasimTarihi.Value, (KitapTuru)cboxKitapTuru.SelectedItem, txtYazarAdi.Text, (int)nudSayfaSayisi.Value, txtAciklama.Text);
                MessageBox.Show("Bağış yaptığınız için teşekkürler!");
                FormuSifirla();
                guncelle(sender, e);
            }
            else
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz.");
        }

        private void FormuSifirla()
        {
            txtKitapAdi.Text = "";
            txtAciklama.Text = "";
            txtYazarAdi.Text = "";
            nudAdet.Value = 0;
            nudSayfaSayisi.Value = 0;
            cboxKitapTuru.SelectedIndex = -1;
        }
    }
}
