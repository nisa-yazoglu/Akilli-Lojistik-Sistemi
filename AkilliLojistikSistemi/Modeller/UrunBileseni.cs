using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.Modeller
{
    public abstract class UrunBileseni
    {
        public int Id { get; set; }
        public string Ad {  get; set; }

        public abstract decimal FiyatHesapla();
        public abstract int StokMiktariGetir();

        public bool StokDusukMu(int esikDeger)
        {
            return StokMiktariGetir() < esikDeger;
        }
    }
}
