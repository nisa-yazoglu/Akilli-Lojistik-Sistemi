using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class StokTakipServisi
    {
        private List<IStokGozlemcisi> _gozlemciler = new List<IStokGozlemcisi>();
        private int _esikDeger = 10;

        public void GozlemciEkle(IStokGozlemcisi gozlemci)
        {
            _gozlemciler.Add(gozlemci);
        }

        public void StokKontrolEt(Modeller.UrunBileseni urun)
        {
            if (urun.StokMiktariGetir() < _esikDeger)
            {
                BildirimGonder(urun);
            }
        }

        private void BildirimGonder(Modeller.UrunBileseni urun)
        {
            foreach (var gozlemci in _gozlemciler)
            {
                gozlemci.StokKritikBildirimi(urun);
            }
        }
    }
}
