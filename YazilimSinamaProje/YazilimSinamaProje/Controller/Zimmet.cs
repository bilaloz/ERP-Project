using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimSinamaProje.Model;

namespace YazilimSinamaProje.Controller
{
    public class Zimmet
    {
        public bool ZimmetEkleme(string kullaniciAdi)
        {
            yazilim_sinama_projesiEntities context = new yazilim_sinama_projesiEntities();
            kullanici kul = context.kullanicis.FirstOrDefault(c => c.kullaniciAdi == kullaniciAdi);

            if (kul != null)
                return true;
            else
                return false;
          

        }
    }
}
