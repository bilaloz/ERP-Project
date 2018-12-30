using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimSinamaProje.Model;

namespace YazilimSinamaProje.Model.Formlar
{
    public partial class frmUrunDuzenle : Form
    {
        public frmUrunDuzenle()
        {
            InitializeComponent();
        }

        public int UrunID { get; set; }
        public static string urunAdi = "";
        urunSatinAlma urun;
        yazilim_sinama_projesiEntities context;
        private void frmUrunDuzenle_Load(object sender, EventArgs e)
        {
            urunAdi = txtUrunAdi.Text;
            context = new yazilim_sinama_projesiEntities();
            urun = context.urunSatinAlmas.FirstOrDefault(u => u.urunID == UrunID);

            lblUrunID.Text = UrunID.ToString();
            txtUrunAdi.Text = urun.urunAd;
            txtUrunAdedi.Text = urun.urunAdedi.ToString();
            txtSatinAlinanFirma.Text = urun.satinAlinanFirma;
            cmbUrunTipi.Text = urun.urunTipi;
            dtSatinAlmaTarihi.Text = urun.satinAlmaTarihi.ToString();
            txtUrunFiyat.Text = urun.urunFiyat.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "" || txtUrunAdedi.Text == "" || txtSatinAlinanFirma.Text == "" || txtUrunFiyat.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Doldurun.");
                return;
            }

            urun.urunAd = txtUrunAdi.Text;
            urun.urunAdedi = Convert.ToInt32(txtUrunAdedi.Text);
            urun.satinAlinanFirma = txtSatinAlinanFirma.Text;
            urun.urunTipi = cmbUrunTipi.Text;
            urun.satinAlmaTarihi = Convert.ToDateTime(dtSatinAlmaTarihi.Text);
            urun.urunFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            urun.urunToptanFiyat = urun.urunFiyat * urun.urunAdedi;

            context.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "" || txtUrunAdedi.Text == "" || txtSatinAlinanFirma.Text == "" || txtUrunFiyat.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Doldurun.");
                return;
            }

            context.urunSatinAlmas.Remove(urun);
            context.SaveChanges();
            MessageBox.Show("Ürün Silindi.");
        }

        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtUrunAdedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtSatinAlinanFirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }
    }
}
