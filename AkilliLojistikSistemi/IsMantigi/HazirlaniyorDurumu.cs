using AkilliLojistikSistemi.IsMantigi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class HazirlaniyorDurumu : ISiparisDurumu
    {
        public void SonrakiAsamayaGec(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} paketlendi. Kargoya veriliyor.");
            siparis.MevcutDurum = new KargodaDurumu();
        }

        public void IptalEt(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} hazırlanırken iptal edildi. Depoya geri alınıyor.");
        }

        public string DurumYazdir()
        {
            return "Hazırlanıyor";
        }
    }
}