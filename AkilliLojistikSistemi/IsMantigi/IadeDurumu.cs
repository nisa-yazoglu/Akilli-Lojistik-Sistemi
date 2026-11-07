using AkilliLojistikSistemi.IsMantigi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class IadeDurumu : ISiparisDurumu
    {
        public void SonrakiAsamayaGec(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} iade süreci tamamlandı ve ürün depoya girdi.");
        }

        public void IptalEt(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet("İade süreci iptal edilemez.");
        }

        public string DurumYazdir()
        {
            return "İade";
        }
    }
}
