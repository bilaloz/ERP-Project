using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaProje.Formlar
{
    public partial class frmRaporListeleme : Form
    {
        public frmRaporListeleme()
        {
            InitializeComponent();
        }

        private void RaporListeleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_sinama_projesiDataSet5.rapor' table. You can move, or remove it, as needed.
            this.raporTableAdapter.Fill(this.yazilim_sinama_projesiDataSet5.rapor);

        }
    }
}
