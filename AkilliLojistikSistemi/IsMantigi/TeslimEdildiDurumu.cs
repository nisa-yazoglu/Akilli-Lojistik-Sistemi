using AkilliLojistikSistemi.IsMantigi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class TeslimEdildiDurumu : ISiparisDurumu
    {
        public void SonrakiAsamayaGec(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} zaten teslim edildi. Süreç bitti.");
        }

        public void IptalEt(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} teslim edildiği için iptal edilemez. İade süreci başlatılıyor.");
            siparis.MevcutDurum = new IadeDurumu();
        }

        public string DurumYazdir()
        {
            return "Teslim Edildi";
        }
    }
}
