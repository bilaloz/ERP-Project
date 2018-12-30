using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimSinamaProje.Model;

namespace YazilimSinamaProje.Controller
{
    public class Login
    {
        public Boolean GirisYap(string kullanıcıAdi,string sifre)
        {
            using(yazilim_sinama_projesiEntities context=new yazilim_sinama_projesiEntities())
            {
                kullanici kul = context.kullanicis.FirstOrDefault(c => c.kullaniciAdi == kullanıcıAdi && c.kullaniciSifre == sifre);
                if (kul != null)
                    return true;
                else
                    return false;

            }

        }
    }
}
