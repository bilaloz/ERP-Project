using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimSinamaProje.Formlar;

namespace YazilimSinamaProje.View
{
    public partial class frmYetkiliPanel : Form
    {
        public frmYetkiliPanel()
        {
            InitializeComponent();
        }
        private frmYetkiliZimmetUrun zimmetUrun;
        private frmYetkiliZimmetler zimmetler;

        private void FormCagirma(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnZimmetEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            zimmetUrun = new frmYetkiliZimmetUrun();
            FormCagirma(zimmetUrun);
        }

        private void btnZimmetListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            zimmetler = new frmYetkiliZimmetler();
            FormCagirma(zimmetler);
        }
    }
}
