using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class BeklemedeDurumu : ISiparisDurumu
    {
        public void SonrakiAsamayaGec(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} için ödeme alındı, sipariş onaylandı.");

            siparis.MevcutDurum = new OnaylandiDurumu();
        }

        public void IptalEt(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} beklemedeyken müşteri tarafından iptal edildi.");
        }

        public string DurumYazdir()
        {
            return "Beklemede";
        }
    }
}