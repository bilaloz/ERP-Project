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
    public partial class frmZimmetler : Form
    {
        frmZimmetDuzenle  frmDuzenle;
        frmAdminPanel frmAdmin;
        public frmZimmetler()
        {
            InitializeComponent();
        }

        private void Zimmetler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_sinama_projesiDataSet3.zimmet' table. You can move, or remove it, as needed.
            this.zimmetTableAdapter.Fill(this.yazilim_sinama_projesiDataSet3.zimmet);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmAdmin = frmSistemeGiris.admin;
                frmAdmin.Show();

                frmDuzenle = new frmZimmetDuzenle();
                frmDuzenle.ZimmetID = Convert.ToInt32((dataGridView1[0, e.RowIndex].Value));
                frmDuzenle.MdiParent = frmAdmin;
                frmDuzenle.Show();
            }
        }
    }
}
