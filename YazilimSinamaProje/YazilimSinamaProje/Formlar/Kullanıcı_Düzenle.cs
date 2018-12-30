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
    public partial class frmKullaniciDuzenle : Form
    {
        public frmKullaniciDuzenle()
        {
            InitializeComponent();
        }

        public int KullaniciID { get; set; }
        kullanici kullanici;
        yazilim_sinama_projesiEntities context;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text=="" ||txtKullaniciSifresi.Text=="" || cmbKullaniciTipi.Text=="" || cmbBolum.Text=="")
            {
                MessageBox.Show("Lütfen Alanları Doldurun.");
                return;
            }
            kullanici.kullaniciAdi = txtKullaniciAdi.Text;
            kullanici.kullaniciSifre = txtKullaniciSifresi.Text;
            kullanici.kullaniciTipi = cmbKullaniciTipi.Text.ToLower();
            kullanici.bolumID = cmbBolum.SelectedIndex + 1;
            context.SaveChanges();
            MessageBox.Show("Kullanıcı Güncellendi");
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adını Doldurun.");
                return;
            }

            context.kullanicis.Remove(kullanici);
            context.SaveChanges();
            MessageBox.Show("Kullanıcı Silindi.");
        }

        private void frmKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            context = new yazilim_sinama_projesiEntities();
            kullanici = context.kullanicis.FirstOrDefault(k => k.kullaniciID == KullaniciID);

            lblkulID.Text = KullaniciID.ToString();
            txtKullaniciAdi.Text = kullanici.kullaniciAdi;
            txtKullaniciSifresi.Text = kullanici.kullaniciSifre;
            cmbKullaniciTipi.Text = kullanici.kullaniciTipi;
            cmbBolum.Text = kullanici.bolum.bolumAdi;
        }
    }
}
