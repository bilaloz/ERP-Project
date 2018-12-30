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
    public partial class frmSatinAlma : Form
    {
        public frmSatinAlma()
        {
            InitializeComponent();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "" || txtUrunAdedi.Text == "" || txtSatinAlinanFirma.Text == "" || txtUrunFiyat.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Doldurun.");
                return;
            }

            yazilim_sinama_projesiEntities context = new yazilim_sinama_projesiEntities();
            urunSatinAlma urun = new urunSatinAlma();

            urun.urunAd = txtUrunAdi.Text;
            urun.urunAdedi = Convert.ToInt32(txtUrunAdedi.Text);
            urun.satinAlinanFirma = txtSatinAlinanFirma.Text;
            urun.urunTipi = cmbUrunTipi.Text;
            urun.satinAlmaTarihi = Convert.ToDateTime(dtSatinAlmaTarihi.Text);
            urun.urunFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            urun.urunToptanFiyat = urun.urunFiyat * urun.urunAdedi;

            context.urunSatinAlmas.Add(urun);
            context.SaveChanges();

            MessageBox.Show("Ürün satın alındı.");
        }

        private void txtUrunAdedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = Char.IsPunctuation(e.KeyChar);
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
