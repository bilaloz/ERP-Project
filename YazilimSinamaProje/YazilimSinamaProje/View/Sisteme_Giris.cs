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
using YazilimSinamaProje.View;

namespace YazilimSinamaProje.View
{
    public partial class frmSistemeGiris : Form
    {
        public static frmAdminPanel admin;
        public static frmYetkiliPanel yetkili;
        public static int bolumID=0;
        public frmSistemeGiris()
        {
            InitializeComponent();
        }

        yazilim_sinama_projesiEntities context = new yazilim_sinama_projesiEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text=="" || txtKullaniciSifre.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Doldurun");
                return;
            }
            kullanici kullanici = context.kullanicis.FirstOrDefault(k => k.kullaniciAdi == txtKullaniciAdi.Text && k.kullaniciSifre == txtKullaniciSifre.Text);
  
            if (kullanici != null)
            {

                bolumID = Convert.ToInt32(kullanici.bolumID);
                if (kullanici.kullaniciTipi == "admin")
                {
                    admin = new frmAdminPanel();
                    admin.Show();
                    this.Hide();
                }
                else if (kullanici.kullaniciTipi == "yetkili")
                {
                    yetkili = new frmYetkiliPanel();
                    yetkili.Show();
                    this.Hide();
                }
                else
                {
                    frmSatinAlmaSorumlusu calisan = new frmSatinAlmaSorumlusu();
                    calisan.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Kullanıcı adı veya parola hatalı.");
        }

        private void ımageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
