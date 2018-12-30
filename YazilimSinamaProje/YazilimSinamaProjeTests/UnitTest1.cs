using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinamaProje.Controller;
using YazilimSinamaProje.Model;

namespace YazilimSinamaProjeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoginOlma()
        {
            Login login = new Login();
            bool result =login.GirisYap("bilal","1234");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void KullaniciEkleme()
        {
            //Kullanıcı Eklemede boş değer gönderince kullanıcı eklemiyor.
            string durum = "";
            KullaniciEkleme kullanici = new KullaniciEkleme();
            durum=kullanici.KullaniciEkle("");
            Assert.AreEqual("KullaniciEklenemez", durum);

        }

        [TestMethod]
        public void ZimmetEkleme()
        {
            Zimmet zim = new Zimmet();
            bool result=zim.ZimmetEkleme("bilal");
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void UrunSatınAlma()
        {
            UrunSatinAlma urun = new UrunSatinAlma();
            bool durum=urun.UrunAdediKontrol(0);
            Assert.AreEqual(true, durum);
        }

        [TestMethod]
        public void UrunSilmeAdinaGore()
        {
            //Urun silme İşlemi için ürünün adının boş geçilmemesi önemlidir.Bu yüzden boşsa test başarısız olacaktır.
            UrunSilme silme = new UrunSilme();
            bool durum = silme.UrunAdinaGoreUrunSilme("DDR4");
            Assert.AreEqual(true, durum);
        }
    }
}
 