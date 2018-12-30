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

namespace YazilimSinamaProje.Formlar
{
    public partial class frmZimmetEkleme : Form
    {
        public frmZimmetEkleme()
        {
            InitializeComponent();
        }
        public int UrunID { get; set; }
        public string UrunAd { get; set; }

        yazilim_sinama_projesiEntities context;

        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                MessageBox.Show("Lütfen alanları boş geçmeyiniz.");
                return;
            }

            context = new yazilim_sinama_projesiEntities();
            zimmet zim = new zimmet();

            kullanici kul = context.kullanicis.FirstOrDefault(c => c.kullaniciAdi ==txtKullaniciAdi.Text);

            if (kul != null)
            {
                zim.zimmet1 = UrunAd;
                zim.kullaniciID = kul.kullaniciID;
                zim.urunID = UrunID;

                context.zimmets.Add(zim);

                context.SaveChanges();

                MessageBox.Show("Ürün Zimmetlendi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Bulunamadı.");
            }

          
        }
    }
}
