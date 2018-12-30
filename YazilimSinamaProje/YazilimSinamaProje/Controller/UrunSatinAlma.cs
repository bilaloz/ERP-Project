using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProje.Controller
{
    public class UrunSatinAlma
    {
        public bool UrunAdediKontrol(int sayi)
        {
            bool durum=false;
            if (sayi == 0)
                durum = true;
            return durum;
        }
    }
}
