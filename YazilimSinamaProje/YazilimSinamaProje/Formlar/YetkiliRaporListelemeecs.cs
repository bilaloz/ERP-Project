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
using YazilimSinamaProje.View;

namespace YazilimSinamaProje.Formlar
{
    public partial class frmYetkiliRaporListeleme : Form
    {
        public frmYetkiliRaporListeleme()
        {
            InitializeComponent();
        }

        private void frmYetkiliRaporListeleme_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "raporID";
            dataGridView1.Columns[1].Name = "aciklama";
            dataGridView1.Columns[2].Name = "kullaniciID";
            dataGridView1.Columns[3].Name = "urunID";
            dataGridView1.Columns[4].Name = "bolumID";

            yazilim_sinama_projesiEntities context = new yazilim_sinama_projesiEntities();
            kullanici kul = context.kullanicis.FirstOrDefault(c => c.bolumID == frmSistemeGiris.bolumID && c.kullaniciTipi == "calisan");

            foreach (rapor item in context.rapors)
            {
                if (item.kullaniciID == kul.kullaniciID)
                {
                    dataGridView1.Rows.Add(item.raporID, item.aciklama, item.kullaniciID, item.urunID,item.bolumID);
                }
            }
        }
    }
}
