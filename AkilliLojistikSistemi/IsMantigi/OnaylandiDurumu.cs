using AkilliLojistikSistemi.IsMantigi;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class OnaylandiDurumu : ISiparisDurumu
    {
        public void SonrakiAsamayaGec(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} onaylandı. Şimdi hazırlanma aşamasına geçiliyor.");

            siparis.MevcutDurum = new HazirlaniyorDurumu();
        }

        public void IptalEt(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} onaylanmıştı ancak hazırlanmadan önce iptal edildi.");
        }

        public string DurumYazdir()
        {
            return "Onaylandı";
        }
    }
}