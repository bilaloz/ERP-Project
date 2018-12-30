using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimSinamaProje.View;
using YazilimSinamaProje.Formlar;

namespace YazilimSinamaProje.Formlar
{
    public partial class frmYetkiliZimmetUrun : Form
    {
        public frmYetkiliZimmetUrun()
        {
            InitializeComponent();
        }
        frmYetkiliZimmetEkle frmZimmet;
        frmYetkiliPanel frmYetkili;

        private void YetkiliZimmetUrun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_sinama_projesiDataSet6.urunSatinAlma' table. You can move, or remove it, as needed.
            this.urunSatinAlmaTableAdapter.Fill(this.yazilim_sinama_projesiDataSet6.urunSatinAlma);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmYetkili  = frmSistemeGiris.yetkili;
                frmYetkili.Show();

                frmZimmet = new frmYetkiliZimmetEkle();
                frmZimmet.UrunID = Convert.ToInt32((dataGridView1[0, e.RowIndex].Value));
                frmZimmet.UrunAd = dataGridView1[1, e.RowIndex].Value.ToString();
                frmZimmet.MdiParent = frmYetkili;
                frmZimmet.Show();
            }
        }
    }
}
