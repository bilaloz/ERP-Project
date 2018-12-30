using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimSinamaProje.Model.Formlar;
using YazilimSinamaProje.Formlar;

namespace YazilimSinamaProje
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private frmKullaniciEkle kullaniciEkle;
        private frmKullanicilar kullanicilar;
        private frmSatinAlma satinAlma;
        private frmUrunler urunler;
        private frmZimmetUrun zimmeturun;
        private frmZimmetler zimmet;
        private frmAtikListeleme atikliste;
        private frmRaporListeleme raporliste;

        private void FormCagirma(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKullaniciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kullaniciEkle = new frmKullaniciEkle();
            FormCagirma(kullaniciEkle);
        }

        private void btnKullaniciListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kullanicilar = new frmKullanicilar();
            FormCagirma(kullanicilar);
        }

        private void btnUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            satinAlma = new frmSatinAlma();
            FormCagirma(satinAlma);
        }

        private void btnUrunListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            urunler = new frmUrunler();
            FormCagirma(urunler);
        }

        private void btnZimmetEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            zimmeturun = new frmZimmetUrun();
            FormCagirma(zimmeturun);
        }

        private void btnZimmetListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            zimmet = new frmZimmetler();
            FormCagirma(zimmet);
        }

        private void btnAtikListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            atikliste = new frmAtikListeleme();
            FormCagirma(atikliste);
        }

        private void btnRaporListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            raporliste = new frmRaporListeleme();
            FormCagirma(raporliste);
        }
    }
}
