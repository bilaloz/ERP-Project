using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProje.Controller
{
    public class KullaniciEkleme
    {
        public string KullaniciEkle(string gelendeger)
        {
            string result = "";
            if (gelendeger == "")
            {
                result = "KullaniciEklenemez";
            }
            return result;
        }
    }
}
