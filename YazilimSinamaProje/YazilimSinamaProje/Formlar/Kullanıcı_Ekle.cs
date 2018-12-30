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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtKullaniciSifresi.Text == "" || cmbKullaniciTipi.Text == "" || cmbBolum.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Doldurun.");
                return;
            }

            yazilim_sinama_projesiEntities context = new yazilim_sinama_projesiEntities();
            kullanici kul = new kullanici();

            var kullanici = context.kullanicis.FirstOrDefault(c => c.kullaniciAdi == txtKullaniciAdi.Text);

            if (kullanici != null)
            {
                MessageBox.Show("Bu kullanıcı adı verilemez.");
            }
            else
            {
                kul.kullaniciAdi = txtKullaniciAdi.Text;
                kul.kullaniciSifre = txtKullaniciSifresi.Text;
                kul.kullaniciTipi = cmbKullaniciTipi.Text.ToLower();
                kul.bolumID = cmbBolum.SelectedIndex + 1;

                context.kullanicis.Add(kul);

                context.SaveChanges();

                MessageBox.Show("Kişi Eklendi.");
            }
        }
    }
}
