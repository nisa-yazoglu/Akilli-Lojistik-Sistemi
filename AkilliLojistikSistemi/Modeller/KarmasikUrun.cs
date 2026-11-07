using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.Modeller
{
    public class KarmasikUrun : UrunBileseni
    {
        private List<UrunBileseni> _parcalar = new List<UrunBileseni>();
        public void ParcaEkle(UrunBileseni parca)
        {
            _parcalar.Add(parca);
        }

        public void ParcaCikar(UrunBileseni parca)
        {
            _parcalar.Remove(parca);
        }

        public override decimal FiyatHesapla()
        {
            return _parcalar.Sum(p => p.FiyatHesapla());
        }

        public override int StokMiktariGetir()
        {
            if (_parcalar.Count == 0) return Stok;

            return Math.Min(Stok, _parcalar.Min(p => p.StokMiktariGetir()));
        }
        public bool StokDusukMu(int esikDeger)
        {
            return Stok < esikDeger;
        }
        public int Stok { get; set; }
    }
}
