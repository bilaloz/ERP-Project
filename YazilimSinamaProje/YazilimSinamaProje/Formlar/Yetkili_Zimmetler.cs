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
using YazilimSinamaProje.Model;

namespace YazilimSinamaProje.Formlar
{
    public partial class frmYetkiliZimmetler : Form
    {
        public frmYetkiliZimmetler()
        {
            InitializeComponent();
        }
        frmYetkiliZimmetDuzenleme frmZimmet;
        frmYetkiliPanel frmYetkili;

        yazilim_sinama_projesiEntities context = new yazilim_sinama_projesiEntities();

        private void Yetkili_Zimmetler_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "zimmetID";
            dataGridView1.Columns[1].Name = "zimmet";
            dataGridView1.Columns[2].Name = "kullaniciID";
            dataGridView1.Columns[3].Name = "urunID";


            kullanici kul = context.kullanicis.FirstOrDefault(c => c.bolumID == frmSistemeGiris.bolumID && c.kullaniciTipi=="calisan");

            foreach (zimmet item in context.zimmets)
            {
                if (item.kullaniciID == kul.kullaniciID)
                {
                    dataGridView1.Rows.Add(item.zimmetID,item.zimmet1,item.kullaniciID,item.urunID);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmYetkili = frmSistemeGiris.yetkili;
                frmYetkili.Show();

                frmZimmet = new frmYetkiliZimmetDuzenleme();
                frmZimmet.ZimmetID = Convert.ToInt32((dataGridView1[0, e.RowIndex].Value));
                frmZimmet.MdiParent = frmYetkili;
                frmZimmet.Show();
            }
        }
    }
}
