using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class SatinAlmaGozlemcisi : IStokGozlemcisi
    {
        public void StokKritikBildirimi(Modeller.UrunBileseni urun)
        {
            string mesaj = $"[E-POSTA] Yönetici'ye İletildi: {urun.Ad} stoğu kritik seviyede (Kalan: {urun.StokMiktariGetir()}). Yeniden sipariş verin.";
            VeriErisim.Log_Servisi.Ornek.LogKaydet(mesaj);
        }
    }
}
