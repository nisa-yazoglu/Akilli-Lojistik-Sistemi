using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.Modeller
{
    public class BasitUrun : UrunBileseni
    {
        public decimal Fiyat {  get; set; }
        public int Stok {  get; set; }

        public override decimal FiyatHesapla()
        {
            return Fiyat;
        }

        public override int StokMiktariGetir()
        {
            return Stok;
        }

        public bool StokDusukMu(int esikDeger)
        {
            return Stok < esikDeger;
        }
    }
}
