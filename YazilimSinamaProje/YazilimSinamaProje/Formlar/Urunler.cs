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
using YazilimSinamaProje.Model.Formlar;

namespace YazilimSinamaProje.Model.Formlar
{
    public partial class frmUrunler : Form
    {
        frmUrunDuzenle frmUrun;
        frmAdminPanel frmAdmin;
        public frmUrunler()
        {
            InitializeComponent();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_sinama_projesiDataSet1.urunSatinAlma' table. You can move, or remove it, as needed.
            this.urunSatinAlmaTableAdapter.Fill(this.yazilim_sinama_projesiDataSet1.urunSatinAlma);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmAdmin = frmSistemeGiris.admin;
                frmAdmin.Show();

                frmUrun = new frmUrunDuzenle();
                frmUrun.UrunID = Convert.ToInt32((dataGridView1[0, e.RowIndex].Value));
                frmUrun.MdiParent = frmAdmin;
                frmUrun.Show();
            }
        }
    }
}
