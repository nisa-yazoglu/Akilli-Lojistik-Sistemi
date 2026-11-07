using Microsoft.VisualStudio.TestTools.UnitTesting;
using AkilliLojistikSistemi.IsMantigi;

namespace AkilliLojistikSistemi.Tests
{
    [TestClass]
    public class KargoTestleri
    {
        [TestMethod]
        public void GlobalExpres_FiyatHesapla_DogruSonucDonmeli()
        {
            IKargoServisi kargo = new GlobalExpres();

            decimal gerceklesenSonuc = kargo.FiyatHesapla(2.5, 150);

            Assert.AreEqual(100m, gerceklesenSonuc);
        }

        [TestMethod]
        public void SigortaliVeKirilacakKargo_FiyatHesapla_EklerUygulanmali()
        {
            IKargoServisi kargo = new KirilacakEsyaKargo(new SigortaliKargo(new GlobalExpres()));

            decimal gerceklesenSonuc = kargo.FiyatHesapla(2.5, 150);

            Assert.AreEqual(180m, gerceklesenSonuc);
        }
    }
}