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
    public partial class frmZimmetDuzenle : Form
    {
        public frmZimmetDuzenle()
        {
            InitializeComponent();
        }
        public int ZimmetID { get; set; }


        yazilim_sinama_projesiEntities context;
        zimmet zim;
        kullanici kul;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                MessageBox.Show("Lütfen alanları boş geçmeyiniz.");
                return;
            }

            if (kul != null)
            {
                zim.kullaniciID = Convert.ToInt32(txtKullaniciAdi.Text);
                context.SaveChanges();
                MessageBox.Show("Zimmet Güncellendi");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                MessageBox.Show("Lütfen alanları boş geçmeyiniz.");
                return;
            }

            if (kul != null)
            {
                atik atik = new atik();

                atik.atikAdi = zim.zimmet1;
                atik.urunID = zim.urunID;
                atik.kullaniciID = kul.kullaniciID;
                context.atiks.Add(atik);

                rapor rapor = new rapor();
                rapor.aciklama="Zimmetten bırakılan üründür.";
                rapor.kullaniciID = kul.kullaniciID;
                rapor.urunID = zim.urunID;
                rapor.bolumID = kul.bolumID;
                context.rapors.Add(rapor);

                context.zimmets.Remove(zim);

                context.SaveChanges();
                MessageBox.Show("Zimmet Silindi");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı.");
            }
        }

        private void frmZimmetDuzenle_Load(object sender, EventArgs e)
        {
            context = new yazilim_sinama_projesiEntities();
            zim = context.zimmets.FirstOrDefault(c => c.zimmetID == ZimmetID);
            kul = context.kullanicis.FirstOrDefault(c => c.kullaniciAdi == txtKullaniciAdi.Text);
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
