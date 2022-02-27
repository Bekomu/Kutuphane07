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
    public partial class KutuphaneForm : Form
    {
        private readonly Kullanici _kullanici;
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;

        public KutuphaneForm(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            kutuphaneYoneticisi = new KutuphaneYoneticisi();
            dgvKutuphane.DataSource = kutuphaneYoneticisi.kitaplar;
            dgvGuncelle();
        }

        private void dgvGuncelle()
        {
            dgvKutuphane.DataSource = null;
            dgvKutuphane.DataSource = kutuphaneYoneticisi.kitaplar;
        }

        private void hesabımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesabimForm form = new HesabimForm(_kullanici);
            form.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bağışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BagisYapForm form = new BagisYapForm(kutuphaneYoneticisi);
            form.guncelle += Form_guncelle;
            form.ShowDialog();
        }

        private void Form_guncelle(object sender, EventArgs e)
        {
            dgvGuncelle();
        }
    }
}
