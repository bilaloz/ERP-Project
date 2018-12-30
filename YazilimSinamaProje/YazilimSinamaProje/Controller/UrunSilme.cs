using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimSinamaProje.Model.Formlar;

namespace YazilimSinamaProje.Controller
{
    public  class UrunSilme
    {
        public bool UrunAdinaGoreUrunSilme(string urun_adi)
        {
            if (urun_adi == "")
                return false;
            else
                return true;
        }
    }
}
