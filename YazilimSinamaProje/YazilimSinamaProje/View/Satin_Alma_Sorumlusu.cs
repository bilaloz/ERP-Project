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

namespace YazilimSinamaProje.View
{
    public partial class frmSatinAlmaSorumlusu : Form
    {
        public frmSatinAlmaSorumlusu()
        {
            InitializeComponent();
        }
        private frmSatinAlma satin_alma;
        private frmUrunler urunler;

        private void FormCagirma(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }


        private void btnUrunSatinAlma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            satin_alma = new frmSatinAlma();
            FormCagirma(satin_alma);
        }

        private void btnUrunListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            urunler = new frmUrunler();
            FormCagirma(urunler);
        }
    }
}
