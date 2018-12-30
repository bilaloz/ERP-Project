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
using YazilimSinamaProje.Model.Formlar;
using YazilimSinamaProje.View;

namespace YazilimSinamaProje.Model.Formlar
{
    public partial class frmKullanicilar : Form
    {
        frmKullaniciDuzenle frmKul;
        frmAdminPanel frmAdmin;
        public frmKullanicilar()
        {
            InitializeComponent();
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_sinama_projesiDataSet.kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.yazilim_sinama_projesiDataSet.kullanici);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmAdmin = frmSistemeGiris.admin;
                frmAdmin.Show();

                frmKul = new frmKullaniciDuzenle();
                frmKul.KullaniciID = Convert.ToInt32((dataGridView1[0, e.RowIndex].Value));
                frmKul.MdiParent = frmAdmin;
                frmKul.Show();
            }
        }
    }
}
