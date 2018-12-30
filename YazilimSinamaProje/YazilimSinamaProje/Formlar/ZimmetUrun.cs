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

namespace YazilimSinamaProje.Formlar
{
    public partial class frmZimmetUrun : Form
    {
        frmZimmetEkleme frmZimmet;
        frmAdminPanel frmAdmin;
        public frmZimmetUrun()
        {
            InitializeComponent();
        }

        private void Zimmetler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_sinama_projesiDataSet2.urunSatinAlma' table. You can move, or remove it, as needed.
            this.urunSatinAlmaTableAdapter.Fill(this.yazilim_sinama_projesiDataSet2.urunSatinAlma);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmAdmin = frmSistemeGiris.admin;
                frmAdmin.Show();

                frmZimmet = new frmZimmetEkleme();
                frmZimmet.UrunID = Convert.ToInt32((dataGridView1[0, e.RowIndex].Value));
                frmZimmet.UrunAd = dataGridView1[1, e.RowIndex].Value.ToString();
                frmZimmet.MdiParent = frmAdmin;
                frmZimmet.Show();
            }
        }
    }
}
